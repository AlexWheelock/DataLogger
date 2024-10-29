<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PortSelectForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SerialComPortsComboBox = New System.Windows.Forms.ComboBox()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SerialComPortsComboBox
        '
        Me.SerialComPortsComboBox.FormattingEnabled = True
        Me.SerialComPortsComboBox.Location = New System.Drawing.Point(63, 12)
        Me.SerialComPortsComboBox.Name = "SerialComPortsComboBox"
        Me.SerialComPortsComboBox.Size = New System.Drawing.Size(179, 24)
        Me.SerialComPortsComboBox.TabIndex = 0
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(63, 42)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(179, 23)
        Me.RefreshButton.TabIndex = 1
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'ConnectButton
        '
        Me.ConnectButton.Location = New System.Drawing.Point(63, 71)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(179, 23)
        Me.ConnectButton.TabIndex = 2
        Me.ConnectButton.Text = "Connect"
        Me.ConnectButton.UseVisualStyleBackColor = True
        '
        'PortSelectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 105)
        Me.Controls.Add(Me.ConnectButton)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.SerialComPortsComboBox)
        Me.Name = "PortSelectForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COM Port Select"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SerialComPortsComboBox As ComboBox
    Friend WithEvents RefreshButton As Button
    Friend WithEvents ConnectButton As Button
End Class
