<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataLoggerForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.SampleTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DisplayOptionGroupBox = New System.Windows.Forms.GroupBox()
        Me.RecentRadioButton = New System.Windows.Forms.RadioButton()
        Me.AllRadioButton = New System.Windows.Forms.RadioButton()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectCOMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayRecentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DisplayOptionGroupBox.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SampleTimer
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(801, 438)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'DisplayOptionGroupBox
        '
        Me.DisplayOptionGroupBox.Controls.Add(Me.AllRadioButton)
        Me.DisplayOptionGroupBox.Controls.Add(Me.RecentRadioButton)
        Me.DisplayOptionGroupBox.Location = New System.Drawing.Point(319, 472)
        Me.DisplayOptionGroupBox.Name = "DisplayOptionGroupBox"
        Me.DisplayOptionGroupBox.Size = New System.Drawing.Size(149, 47)
        Me.DisplayOptionGroupBox.TabIndex = 1
        Me.DisplayOptionGroupBox.TabStop = False
        Me.DisplayOptionGroupBox.Text = "Display"
        '
        'RecentRadioButton
        '
        Me.RecentRadioButton.AutoSize = True
        Me.RecentRadioButton.Checked = True
        Me.RecentRadioButton.Location = New System.Drawing.Point(6, 18)
        Me.RecentRadioButton.Name = "RecentRadioButton"
        Me.RecentRadioButton.Size = New System.Drawing.Size(71, 20)
        Me.RecentRadioButton.TabIndex = 0
        Me.RecentRadioButton.TabStop = True
        Me.RecentRadioButton.Text = "Recent"
        Me.RecentRadioButton.UseVisualStyleBackColor = True
        '
        'AllRadioButton
        '
        Me.AllRadioButton.AutoSize = True
        Me.AllRadioButton.Location = New System.Drawing.Point(105, 18)
        Me.AllRadioButton.Name = "AllRadioButton"
        Me.AllRadioButton.Size = New System.Drawing.Size(43, 20)
        Me.AllRadioButton.TabIndex = 1
        Me.AllRadioButton.Text = "All"
        Me.AllRadioButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(684, 472)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(104, 47)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "TopMenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectCOMToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SelectCOMToolStripMenuItem
        '
        Me.SelectCOMToolStripMenuItem.Name = "SelectCOMToolStripMenuItem"
        Me.SelectCOMToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SelectCOMToolStripMenuItem.Text = "&Select COM"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplayRecentToolStripMenuItem, Me.DisplayAllToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'DisplayRecentToolStripMenuItem
        '
        Me.DisplayRecentToolStripMenuItem.Name = "DisplayRecentToolStripMenuItem"
        Me.DisplayRecentToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.DisplayRecentToolStripMenuItem.Text = "Display &Recent"
        '
        'DisplayAllToolStripMenuItem
        '
        Me.DisplayAllToolStripMenuItem.Name = "DisplayAllToolStripMenuItem"
        Me.DisplayAllToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.DisplayAllToolStripMenuItem.Text = "Display &All"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.InfoToolStripMenuItem.Text = "&Info"
        '
        'DataLoggerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 527)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.DisplayOptionGroupBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "DataLoggerForm"
        Me.Text = "Data Logger"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DisplayOptionGroupBox.ResumeLayout(False)
        Me.DisplayOptionGroupBox.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SampleTimer As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DisplayOptionGroupBox As GroupBox
    Friend WithEvents RecentRadioButton As RadioButton
    Friend WithEvents AllRadioButton As RadioButton
    Friend WithEvents ExitButton As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectCOMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayRecentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Public WithEvents SerialPort As IO.Ports.SerialPort
End Class
