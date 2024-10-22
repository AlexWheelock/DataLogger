'Alex Wheelock
'RCET 3317
'Fall 2024
'DataLogger
'

Option Explicit On
Option Strict On

Public Class DataLoggerForm



    '================ Event Handlers Below Here ================


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


End Class
