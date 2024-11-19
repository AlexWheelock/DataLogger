'Alex Wheelock
'RCET 3317
'Fall 2024
'DataLogger
'https://github.com/AlexWheelock/DataLogger.git

Option Explicit On
Option Strict On
'Imports System.Threading.Thread
Public Class DataLoggerForm

    Dim dataList As New List(Of Integer)
    Dim plottableList As New List(Of Integer)

    'Plot the data
    Sub Plot(plotData() As Integer)
        Dim g As Graphics = PlotPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Red)
        Dim oldX%, oldY%

        If Me.PlotPictureBox.InvokeRequired Then
            Me.PlotPictureBox.Invoke(New MethodInvoker(Sub() PlotPictureBox.Refresh()))
        End If

        If DisplayMode(-1) = 1 Then
            g.ScaleTransform(CSng(PlotPictureBox.Width / plottableList.Count), 1)
            For x = 0 To plottableList.Count - 1
                g.DrawLine(pen, oldX, oldY, x, plottableList.Item(x))
                oldX = x
                oldY = plottableList.Item(x)
            Next
        Else
            g.ScaleTransform(CSng(PlotPictureBox.Width / (30 * CInt(SampleRateTextBox.Text))), 1)
            For x = 0 To UBound(plotData)
                g.DrawLine(pen, oldX, oldY, x, plotData(x))
                oldX = x
                oldY = plotData(x)
            Next
        End If

    End Sub

    'Read the analog input 1 from the Qy@ board
    Function Qy_ReadAnalogInputA1() As Byte()
        Dim data(0) As Byte
        data(0) = &B1010001

        Try
            SerialPort.Write(data, 0, 1)
        Catch ex As Exception

        End Try

        Return data
    End Function

    'Shift array for 30 second display, scales the size of the array based on the sample rate
    Function ShiftArray(newData As Integer) As Integer()
        Static data(30 * CInt(SampleRateTextBox.Text)) As Integer

        For i = LBound(data) To UBound(data)
            Try
                data(i) = data(i + 1)
            Catch ex As Exception

            End Try
        Next

        data(UBound(data)) = newData
        Return data
    End Function

    'Determine that the sample rate in the text box is an integer
    Sub ValidateSampleRate()
        Dim numberTest As Integer
        Dim validInput As Boolean = False

        Try
            numberTest = CInt(SampleRateTextBox.Text)
            SampleRateTextBox.BackColor = Color.White
            validInput = True
        Catch ex As Exception
            SampleRateTextBox.BackColor = Color.LightYellow
        End Try

        If validInput Then
            If numberTest < 1 Then
                numberTest = 1
                SampleRateTextBox.Text = "10"
            ElseIf numberTest > 1000 Then
                numberTest = 1000
                SampleRateTextBox.Text = "1000"
            End If
            SampleTimer.Interval = SampleRateToTime(numberTest)
        End If
    End Sub

    'Return the frequency of samples/second to a time interval
    Function SampleRateToTime(samplesPerSecond As Integer) As Integer
        Dim interval As Integer = 1000 \ samplesPerSecond
        Return interval
    End Function

    'Receive and handle data as needed
    Sub ReceiveData()
        Dim data(SerialPort.BytesToRead) As Byte
        Dim temp() As Integer
        Dim combinedByteData As Integer

        Console.WriteLine(SerialPort.BytesToRead)
        SerialPort.Read(data, 0, SerialPort.BytesToRead)

        For bytes = 0 To UBound(data)
            Console.WriteLine(Hex(data(bytes)))
            dataList.Add(data(bytes))
        Next

        WriteDataToFile("AN1", data)
        combinedByteData = ((data(0) * 4) + (data(1) \ 64))

        If DisplayMode(-1) = 1 Then
            plottableList.Add(combinedByteData)
            Plot(temp)
        Else
            temp = ShiftArray(combinedByteData)
            Plot(temp)
        End If


    End Sub

    'Used to only try and receive data when the port has been opened properly
    Function ReadyToReceiveData(update As Integer) As Boolean
        Static currentState As Boolean

        If update <> -1 Then
            If update = 0 Then
                currentState = False
            ElseIf update = 1 Then
                currentState = True
            End If
        End If

        Return currentState
    End Function

    'Format and write data to file
    Sub WriteDataToFile(prefix As String, data As Byte())
        Dim time As String = DateTime.Now.ToString("yyMMddhh")

        FileOpen(1, $"log_{time}.log", OpenMode.Append)

        Write(1, $"$${prefix}")
        Write(1, data(0))
        Write(1, data(1))
        WriteLine(1, $"{DateTime.Now.ToString("yyMMddhhmmss")}{DateTime.Now.Millisecond}")

        FileClose(1)
    End Sub

    'Determine whether or not to display all or only 30 seconds of the history
    Function DisplayMode(modeSelect As Integer) As Integer
        Static currentMode As Integer

        If modeSelect <> -1 Then
            currentMode = modeSelect
        End If

        Return currentMode
    End Function

    'Update both lists from the file currently open
    Sub UpdateListFromFile()
        Dim time As String = DateTime.Now.ToString("yyMMddhh")
        Dim currentLine As String
        Dim temp() As String

        Try
            FileOpen(1, $"log_{time}.log", OpenMode.Input)
            Do Until EOF(1)
                currentLine = LineInput(1)
                temp = Split(currentLine, ",")
                dataList.Add(CInt(temp(1)))
                dataList.Add(CInt(temp(2)))
                plottableList.Add((CInt(temp(1)) * 4) + (CInt(temp(2)) \ 4))
            Loop

            FileClose(1)
        Catch ex As Exception

        End Try

    End Sub


    '================ Event Handlers Below Here ================


    Private Sub SerialPort_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        If ReadyToReceiveData(-1) Then
            ReceiveData()
        End If
    End Sub

    Private Sub DataLoggerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadyToReceiveData(0)
        DisplayMode(0)
        COMStatusStripLabel.Text = $"Port: N/A | Baud: 9600 | Status: False | Input Buffer: N/A"
    End Sub

    Private Sub SampleTimer_Tick(sender As Object, e As EventArgs) Handles SampleTimer.Tick
        Qy_ReadAnalogInputA1()
    End Sub

    Private Sub RecentRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RecentRadioButton.CheckedChanged
        DisplayMode(0)
    End Sub

    Private Sub AllRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AllRadioButton.CheckedChanged
        DisplayMode(1)
    End Sub

    Private Sub SelectCOMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectCOMToolStripMenuItem.Click
        PortSelectForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub DisplayRecentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayRecentToolStripMenuItem.Click
        RecentRadioButton.Checked = True
        DisplayMode(0)
    End Sub

    Private Sub DisplayAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayAllToolStripMenuItem.Click
        AllRadioButton.Checked = True
        DisplayMode(1)
        UpdateListFromFile()
    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        MsgBox("Welcome to Data Logger Form!" & vbCrLf _
               & vbCrLf _
               & "This form is designed to graph the analog inputs from the Qy@" & vbCrLf _
               & "board. It will save the data from the serial port every 100 ms," & vbCrLf _
               & "and then display either the last 10 seconds of data, or all" & vbCrLf _
               & "recorded data at the same time, compressing the display as new" & vbCrLf _
               & "is recorded." & vbCrLf _
               & vbCrLf _
               & "To select the Qy@ board and begin communicating, select the file" & vbCrLf _
               & "menu strip button, and then the Select COM button. This will bring" & vbCrLf _
               & "up another form that will allow you to choose the COM port that the" & vbCrLf _
               & "Qy@ board is connected to, and will then immediately begin" & vbCrLf _
               & "communicating and displaying recorded data.")
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        SampleTimer.Enabled = True
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        SampleTimer.Enabled = False
    End Sub

    Private Sub SampleRateTextBox_TextChanged(sender As Object, e As EventArgs) Handles SampleRateTextBox.TextChanged
        ValidateSampleRate()
    End Sub

    Private Sub SelectCOMPortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectCOMPortToolStripMenuItem.Click
        PortSelectForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub DisplayRecentToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DisplayRecentToolStripMenuItem1.Click
        RecentRadioButton.Checked = True
        DisplayMode(0)
    End Sub

    Private Sub DisplayAllContextMenuStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayToolStripMenuItem.Click
        AllRadioButton.Checked = True
        DisplayMode(1)
        UpdateListFromFile()
    End Sub

    Private Sub InfoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem1.Click
        MsgBox("Welcome to Data Logger Form!" & vbCrLf _
               & vbCrLf _
               & "This form is designed to graph the analog inputs from the Qy@" & vbCrLf _
               & "board. It will save the data from the serial port every 100 ms," & vbCrLf _
               & "and then display either the last 10 seconds of data, or all" & vbCrLf _
               & "recorded data at the same time, compressing the display as new" & vbCrLf _
               & "is recorded." & vbCrLf _
               & vbCrLf _
               & "To select the Qy@ board and begin communicating, select the file" & vbCrLf _
               & "menu strip button, and then the Select COM button. This will bring" & vbCrLf _
               & "up another form that will allow you to choose the COM port that the" & vbCrLf _
               & "Qy@ board is connected to, and will then immediately begin" & vbCrLf _
               & "communicating and displaying recorded data.")
    End Sub
End Class
