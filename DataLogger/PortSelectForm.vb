Imports System.IO.Ports
Imports System.Threading.Thread
Public Class PortSelectForm

    'Sub GetComPorts()
    '    SerialComPortsComboBox.Text = ""
    '    SerialComPortsComboBox.Items.Clear()

    '    For Each portName In DataLoggerForm.SerialPort.GetPortNames()
    '        SerialComPortsComboBox.Items.Add(portName)
    '    Next
    'End Sub

    Sub GetComPorts()
        SerialComPortsComboBox.Items.Clear()
        SerialComPortsComboBox.Text = ""

        For Each portName In SerialPort.GetPortNames()
            SerialConnect(portName)
            GetSettings()
            Sleep(5)
            Dim data(DataLoggerForm.SerialPort.BytesToRead) As Byte
            DataLoggerForm.SerialPort.Read(data, 0, DataLoggerForm.SerialPort.BytesToRead)
            'Byte :  58 | HEX: 51 | DEC: 81 | ASCII: Q
            'Byte :  59 | HEX: 79 | DEC: 121 | ASCII: y
            'Byte :  60 | HEX: 40 | DEC: 64 | ASCII: @
            If data.Length >= 64 Then
                If data(58) = 81 And data(59) = 121 And data(60) = 64 Then
                    'MsgBox($"Qy@ Board COM Confirmed on port: {SerialPort.PortName}")
                    SerialComPortsComboBox.Items.Add(DataLoggerForm.SerialPort.PortName)
                    SerialComPortsComboBox.SelectedItem = DataLoggerForm.SerialPort.PortName

                    'UpdateStatus()
                End If
            Else
                'MsgBox($"{SerialPort.PortName} is not a Qy@ board.")
            End If
        Next
        'PortComboBox.SelectedIndex = 0

        DataLoggerForm.SerialPort.Close()
    End Sub

    Function GetSettings() As Byte()
        Dim data(0) As Byte
        data(0) = &B11110000
        DataLoggerForm.SerialPort.Write(data, 0, 1)
        Return data
    End Function

    Sub SerialConnect(portName As String)
        DataLoggerForm.SerialPort.Close()
        DataLoggerForm.SerialPort.PortName = portName
        DataLoggerForm.SerialPort.BaudRate = 9600
        DataLoggerForm.SerialPort.Open()
        UpdateStatus()
    End Sub

    Sub UpdateStatus()
        'add all current serial port info to the status label
        DataLoggerForm.COMStatusStripLabel.Text = $"Port: {DataLoggerForm.SerialPort.PortName} Baud: {DataLoggerForm.SerialPort.BaudRate} Status: {DataLoggerForm.SerialPort.IsOpen} Input Buffer: {DataLoggerForm.SerialPort.BytesToRead}"
    End Sub

    Private Sub PortSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetComPorts()
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        GetComPorts()
    End Sub

    Private Sub ConnectButton_Click(sender As Object, e As EventArgs) Handles ConnectButton.Click
        Try
            SerialConnect(SerialComPortsComboBox.Text)
            DataLoggerForm.ReadyToReceiveData(1)
            Me.Close()
        Catch ex As Exception
            If SerialComPortsComboBox.Text = "" Then
                MsgBox("Please select a COM port and try again.")
            Else
                MsgBox("Attempting to connect to the selected COM port caused an error.")
            End If
        End Try

    End Sub
End Class