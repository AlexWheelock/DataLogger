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
        Me.PlotPictureBox = New System.Windows.Forms.PictureBox()
        Me.DisplayOptionGroupBox = New System.Windows.Forms.GroupBox()
        Me.AllRadioButton = New System.Windows.Forms.RadioButton()
        Me.RecentRadioButton = New System.Windows.Forms.RadioButton()
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
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.COMStatusStripLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.SampleRateTextBox = New System.Windows.Forms.TextBox()
        Me.SampleRateLabel = New System.Windows.Forms.Label()
        Me.RangeLabel = New System.Windows.Forms.Label()
        CType(Me.PlotPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DisplayOptionGroupBox.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort
        '
        '
        'SampleTimer
        '
        '
        'PlotPictureBox
        '
        Me.PlotPictureBox.Location = New System.Drawing.Point(0, 31)
        Me.PlotPictureBox.Name = "PlotPictureBox"
        Me.PlotPictureBox.Size = New System.Drawing.Size(800, 435)
        Me.PlotPictureBox.TabIndex = 0
        Me.PlotPictureBox.TabStop = False
        '
        'DisplayOptionGroupBox
        '
        Me.DisplayOptionGroupBox.Controls.Add(Me.AllRadioButton)
        Me.DisplayOptionGroupBox.Controls.Add(Me.RecentRadioButton)
        Me.DisplayOptionGroupBox.Location = New System.Drawing.Point(478, 472)
        Me.DisplayOptionGroupBox.Name = "DisplayOptionGroupBox"
        Me.DisplayOptionGroupBox.Size = New System.Drawing.Size(149, 47)
        Me.DisplayOptionGroupBox.TabIndex = 1
        Me.DisplayOptionGroupBox.TabStop = False
        Me.DisplayOptionGroupBox.Text = "Display"
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
        Me.SelectCOMToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
        Me.SelectCOMToolStripMenuItem.Text = "&Select COM"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
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
        Me.DisplayRecentToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.DisplayRecentToolStripMenuItem.Text = "Display &Recent"
        '
        'DisplayAllToolStripMenuItem
        '
        Me.DisplayAllToolStripMenuItem.Name = "DisplayAllToolStripMenuItem"
        Me.DisplayAllToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
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
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(118, 26)
        Me.InfoToolStripMenuItem.Text = "&Info"
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.COMStatusStripLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 525)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(800, 26)
        Me.StatusStrip.TabIndex = 5
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'COMStatusStripLabel
        '
        Me.COMStatusStripLabel.Name = "COMStatusStripLabel"
        Me.COMStatusStripLabel.Size = New System.Drawing.Size(149, 20)
        Me.COMStatusStripLabel.Text = "COMStatusStripLabel"
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(12, 472)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(104, 47)
        Me.StartButton.TabIndex = 6
        Me.StartButton.Text = "&Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.Location = New System.Drawing.Point(122, 472)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(104, 47)
        Me.StopButton.TabIndex = 7
        Me.StopButton.Text = "S&top"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'SampleRateTextBox
        '
        Me.SampleRateTextBox.Location = New System.Drawing.Point(270, 494)
        Me.SampleRateTextBox.Name = "SampleRateTextBox"
        Me.SampleRateTextBox.Size = New System.Drawing.Size(103, 22)
        Me.SampleRateTextBox.TabIndex = 8
        Me.SampleRateTextBox.Text = "10"
        '
        'SampleRateLabel
        '
        Me.SampleRateLabel.AutoSize = True
        Me.SampleRateLabel.Location = New System.Drawing.Point(267, 472)
        Me.SampleRateLabel.Name = "SampleRateLabel"
        Me.SampleRateLabel.Size = New System.Drawing.Size(165, 16)
        Me.SampleRateLabel.TabIndex = 9
        Me.SampleRateLabel.Text = "Sample Rate (per second)"
        '
        'RangeLabel
        '
        Me.RangeLabel.AutoSize = True
        Me.RangeLabel.Location = New System.Drawing.Point(379, 497)
        Me.RangeLabel.Name = "RangeLabel"
        Me.RangeLabel.Size = New System.Drawing.Size(53, 16)
        Me.RangeLabel.TabIndex = 10
        Me.RangeLabel.Text = "10-1000"
        '
        'DataLoggerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 551)
        Me.Controls.Add(Me.RangeLabel)
        Me.Controls.Add(Me.SampleRateLabel)
        Me.Controls.Add(Me.SampleRateTextBox)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.DisplayOptionGroupBox)
        Me.Controls.Add(Me.PlotPictureBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "DataLoggerForm"
        Me.Text = "Data Logger"
        CType(Me.PlotPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DisplayOptionGroupBox.ResumeLayout(False)
        Me.DisplayOptionGroupBox.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SampleTimer As Timer
    Friend WithEvents PlotPictureBox As PictureBox
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
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents COMStatusStripLabel As ToolStripStatusLabel
    Friend WithEvents StartButton As Button
    Friend WithEvents StopButton As Button
    Friend WithEvents SampleRateTextBox As TextBox
    Friend WithEvents SampleRateLabel As Label
    Friend WithEvents RangeLabel As Label
End Class
