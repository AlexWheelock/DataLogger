Imports System.IO.Ports

Public Class PortSelect

    Sub GetComPorts()
        SerialComPortsComboBox.Text = ""
        SerialComPortsComboBox.Items.Clear()

        For Each portName In DataLoggerForm.SerialPort.GetPortNames()
            SerialComPortsComboBox.Items.Add(portName)
        Next
    End Sub

    Private Sub PortSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetComPorts()
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        GetComPorts()
    End Sub

    Private Sub ConnectButton_Click(sender As Object, e As EventArgs) Handles ConnectButton.Click
        Try
            DataLoggerForm.SerialPort.PortName = $"{SerialComPortsComboBox.SelectedItem}"
            DataLoggerForm.SerialPort.Open()
        Catch ex As Exception
            MsgBox("Selected COM Port is not a Qy@ board." & vbCrLf _
                   & vbCrLf _
                   & "Please choose another one, And then try again.")
        End Try
    End Sub
End Class