<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lnkWeather = New System.Windows.Forms.LinkLabel()
        Me.cklEquip = New System.Windows.Forms.CheckedListBox()
        Me.cboLength = New System.Windows.Forms.ComboBox()
        Me.chkDamage = New System.Windows.Forms.CheckBox()
        Me.chkWaiver = New System.Windows.Forms.CheckBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSub = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGrand = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbCalc = New System.Windows.Forms.ToolStripButton()
        Me.tsbClose = New System.Windows.Forms.ToolStripButton()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select all Equipment to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "be Rented"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lnkWeather
        '
        Me.lnkWeather.AutoSize = True
        Me.lnkWeather.Location = New System.Drawing.Point(266, 191)
        Me.lnkWeather.Name = "lnkWeather"
        Me.lnkWeather.Size = New System.Drawing.Size(92, 13)
        Me.lnkWeather.TabIndex = 1
        Me.lnkWeather.TabStop = True
        Me.lnkWeather.Text = "Weather Forecast"
        '
        'cklEquip
        '
        Me.cklEquip.CheckOnClick = True
        Me.cklEquip.FormattingEnabled = True
        Me.cklEquip.Items.AddRange(New Object() {"Skis, Beginner", "Skis, Advanced", "Snowboard, Beginner", "Snowboard, Advanced", "Ski Boots", "Snowboard Boots", "Helmet, Standard", "Helmet, Deluxe"})
        Me.cklEquip.Location = New System.Drawing.Point(17, 78)
        Me.cklEquip.Name = "cklEquip"
        Me.cklEquip.Size = New System.Drawing.Size(136, 124)
        Me.cklEquip.TabIndex = 2
        '
        'cboLength
        '
        Me.cboLength.FormattingEnabled = True
        Me.cboLength.Items.AddRange(New Object() {"1 Day", "2 Days", "3 Days", "1 Week", "2 Weeks"})
        Me.cboLength.Location = New System.Drawing.Point(175, 78)
        Me.cboLength.Name = "cboLength"
        Me.cboLength.Size = New System.Drawing.Size(121, 21)
        Me.cboLength.TabIndex = 3
        Me.cboLength.Text = "Choose One..."
        '
        'chkDamage
        '
        Me.chkDamage.AutoSize = True
        Me.chkDamage.Location = New System.Drawing.Point(175, 125)
        Me.chkDamage.Name = "chkDamage"
        Me.chkDamage.Size = New System.Drawing.Size(116, 17)
        Me.chkDamage.TabIndex = 4
        Me.chkDamage.Text = "Damage Insurance"
        Me.chkDamage.UseVisualStyleBackColor = True
        '
        'chkWaiver
        '
        Me.chkWaiver.AutoSize = True
        Me.chkWaiver.Location = New System.Drawing.Point(175, 168)
        Me.chkWaiver.Name = "chkWaiver"
        Me.chkWaiver.Size = New System.Drawing.Size(97, 17)
        Me.chkWaiver.TabIndex = 5
        Me.chkWaiver.Text = "Liability Waiver"
        Me.chkWaiver.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(345, 35)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(39, 13)
        Me.lblDate.TabIndex = 8
        Me.lblDate.Text = "Label2"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(324, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Subtotal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(345, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Tax"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(327, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Deposit"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(307, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Grand Total"
        '
        'txtSub
        '
        Me.txtSub.Enabled = False
        Me.txtSub.Location = New System.Drawing.Point(392, 79)
        Me.txtSub.Name = "txtSub"
        Me.txtSub.Size = New System.Drawing.Size(100, 20)
        Me.txtSub.TabIndex = 16
        Me.txtSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTax
        '
        Me.txtTax.Enabled = False
        Me.txtTax.Location = New System.Drawing.Point(392, 105)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(100, 20)
        Me.txtTax.TabIndex = 17
        Me.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(392, 131)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(100, 20)
        Me.txtDeposit.TabIndex = 18
        Me.txtDeposit.Text = "0"
        Me.txtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(195, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Rental Duration"
        '
        'txtGrand
        '
        Me.txtGrand.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtGrand.Enabled = False
        Me.txtGrand.Font = New System.Drawing.Font("Miramonte", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrand.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtGrand.Location = New System.Drawing.Point(373, 157)
        Me.txtGrand.Name = "txtGrand"
        Me.txtGrand.Size = New System.Drawing.Size(119, 27)
        Me.txtGrand.TabIndex = 19
        Me.txtGrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbCalc, Me.tsbClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(540, 25)
        Me.ToolStrip1.TabIndex = 21
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbCalc
        '
        Me.tsbCalc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbCalc.Image = CType(resources.GetObject("tsbCalc.Image"), System.Drawing.Image)
        Me.tsbCalc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCalc.Name = "tsbCalc"
        Me.tsbCalc.Size = New System.Drawing.Size(60, 22)
        Me.tsbCalc.Text = "Calculate"
        '
        'tsbClose
        '
        Me.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbClose.Image = CType(resources.GetObject("tsbClose.Image"), System.Drawing.Image)
        Me.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbClose.Name = "tsbClose"
        Me.tsbClose.Size = New System.Drawing.Size(40, 22)
        Me.tsbClose.Text = "Close"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(540, 247)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtGrand)
        Me.Controls.Add(Me.txtDeposit)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.txtSub)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.chkWaiver)
        Me.Controls.Add(Me.chkDamage)
        Me.Controls.Add(Me.cboLength)
        Me.Controls.Add(Me.cklEquip)
        Me.Controls.Add(Me.lnkWeather)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMain"
        Me.Text = "Winter Sports Equipment Rental"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lnkWeather As System.Windows.Forms.LinkLabel
    Friend WithEvents cklEquip As System.Windows.Forms.CheckedListBox
    Friend WithEvents cboLength As System.Windows.Forms.ComboBox
    Friend WithEvents chkDamage As System.Windows.Forms.CheckBox
    Friend WithEvents chkWaiver As System.Windows.Forms.CheckBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSub As System.Windows.Forms.TextBox
    Friend WithEvents txtTax As System.Windows.Forms.TextBox
    Friend WithEvents txtDeposit As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtGrand As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbCalc As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbClose As System.Windows.Forms.ToolStripButton

End Class
