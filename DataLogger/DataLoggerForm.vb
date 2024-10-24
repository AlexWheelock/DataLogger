'Alex Wheelock
'RCET 3317
'Fall 2024
'DataLogger
'

Option Explicit On
Option Strict On

Public Class DataLoggerForm

    Sub Plot(plotData() As Integer)
        Dim g As Graphics = PlotPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Red)
        Dim oldX%, oldY%
        PlotPictureBox.Refresh()
        g.ScaleTransform(CSng(PlotPictureBox.Width / 100), 1)
        For x = 0 To UBound(plotData)
            g.DrawLine(pen, oldX, oldY, x, plotData(x))
            oldX = x
            oldY = plotData(x)
        Next
    End Sub

    Function Qy_ReadAnalogInputA1() As Byte()
        Dim data(0) As Byte
        data(0) = &B1010001

        Try
            SerialPort.Write(data, 0, 1)
        Catch ex As Exception

        End Try

        Return data
    End Function

    Function ShiftArray(newData As Integer) As Integer()
        Static data(99) As Integer

        For i = LBound(data) To UBound(data)

            Try
                data(i) = data(i + 1)
            Catch ex As Exception

            End Try

        Next

        data(UBound(data)) = newData
        Return data
    End Function



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
            If numberTest < 10 Then
                numberTest = 10
                SampleRateTextBox.Text = "10"
            ElseIf numberTest > 1000 Then
                numberTest = 1000
                SampleRateTextBox.Text = "1000"
            End If
            SampleTimer.Interval = SampleRateToTime(numberTest)
        End If
    End Sub

    Function SampleRateToTime(samplesPerSecond As Integer) As Integer
        Dim interval As Integer = 1000 \ samplesPerSecond
        Return interval
    End Function


    '================ Event Handlers Below Here ================


    Private Sub SerialPort_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        Dim data(SerialPort.BytesToRead) As Byte

        Console.WriteLine(SerialPort.BytesToRead)
        SerialPort.Read(data, 0, SerialPort.BytesToRead)

        For Each Bytes In data
            Console.WriteLine(Hex(data(Bytes)))
        Next

    End Sub

    Private Sub DataLoggerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SampleTimer_Tick(sender As Object, e As EventArgs) Handles SampleTimer.Tick

    End Sub

    Private Sub RecentRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RecentRadioButton.CheckedChanged

    End Sub

    Private Sub AllRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AllRadioButton.CheckedChanged

    End Sub

    Private Sub SelectCOMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectCOMToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub DisplayRecentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayRecentToolStripMenuItem.Click
        RecentRadioButton.Checked = True
    End Sub

    Private Sub DisplayAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayAllToolStripMenuItem.Click
        AllRadioButton.Checked = True
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

    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click

    End Sub

    Private Sub SampleRateTextBox_TextChanged(sender As Object, e As EventArgs) Handles SampleRateTextBox.TextChanged
        ValidateSampleRate()
    End Sub
End Class
