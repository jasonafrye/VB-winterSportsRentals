<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowse
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
        Me.webWeather = New System.Windows.Forms.WebBrowser()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tstURL = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbGo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'webWeather
        '
        Me.webWeather.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webWeather.Location = New System.Drawing.Point(0, 0)
        Me.webWeather.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webWeather.Name = "webWeather"
        Me.webWeather.Size = New System.Drawing.Size(866, 554)
        Me.webWeather.TabIndex = 0
        Me.webWeather.Url = New System.Uri("", System.UriKind.Relative)
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(866, 529)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(866, 554)
        Me.ToolStripContainer1.TabIndex = 1
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstURL, Me.tsbGo})
        Me.ToolStrip1.Location = New System.Drawing.Point(13, 4)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(737, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tstURL
        '
        Me.tstURL.Name = "tstURL"
        Me.tstURL.Size = New System.Drawing.Size(700, 25)
        '
        'tsbGo
        '
        Me.tsbGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbGo.Image = Global.winterSportsRentals.My.Resources.Resources.large_go_button
        Me.tsbGo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGo.Name = "tsbGo"
        Me.tsbGo.Size = New System.Drawing.Size(23, 22)
        Me.tsbGo.Text = "ToolStripButton1"
        Me.tsbGo.ToolTipText = "Go!"
        '
        'ToolStripContainer2
        '
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.AutoScroll = True
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.ToolStrip1)
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.webWeather)
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(866, 554)
        Me.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.Size = New System.Drawing.Size(866, 554)
        Me.ToolStripContainer2.TabIndex = 2
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'frmBrowse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 554)
        Me.Controls.Add(Me.ToolStripContainer2)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "frmBrowse"
        Me.Text = "Weather"
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.ContentPanel.PerformLayout()
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents webWeather As System.Windows.Forms.WebBrowser
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tstURL As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tsbGo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
End Class
