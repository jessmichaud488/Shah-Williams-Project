<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.radBasic = New System.Windows.Forms.RadioButton()
        Me.radSilver = New System.Windows.Forms.RadioButton()
        Me.radGold = New System.Windows.Forms.RadioButton()
        Me.radDiamond = New System.Windows.Forms.RadioButton()
        Me.lblPackages = New System.Windows.Forms.Label()
        Me.lblCharge = New System.Windows.Forms.Label()
        Me.lblBasic = New System.Windows.Forms.Label()
        Me.lblSilver = New System.Windows.Forms.Label()
        Me.lblGold = New System.Windows.Forms.Label()
        Me.lblDiamond = New System.Windows.Forms.Label()
        Me.lblAddOn = New System.Windows.Forms.Label()
        Me.lblAddOnCharge = New System.Windows.Forms.Label()
        Me.lblCinnematicPrice = New System.Windows.Forms.Label()
        Me.lblHBIPrice = New System.Windows.Forms.Label()
        Me.lblShowtimerPrice = New System.Windows.Forms.Label()
        Me.lblLocalPrice = New System.Windows.Forms.Label()
        Me.chkCinnematic = New System.Windows.Forms.CheckBox()
        Me.chkHBI = New System.Windows.Forms.CheckBox()
        Me.chkShowtimer = New System.Windows.Forms.CheckBox()
        Me.chkLocal = New System.Windows.Forms.CheckBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotalBox = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'radBasic
        '
        Me.radBasic.AutoSize = True
        Me.radBasic.Location = New System.Drawing.Point(33, 63)
        Me.radBasic.Name = "radBasic"
        Me.radBasic.Size = New System.Drawing.Size(51, 17)
        Me.radBasic.TabIndex = 1
        Me.radBasic.TabStop = True
        Me.radBasic.Text = "Basic"
        Me.radBasic.UseVisualStyleBackColor = True
        '
        'radSilver
        '
        Me.radSilver.AutoSize = True
        Me.radSilver.Location = New System.Drawing.Point(33, 88)
        Me.radSilver.Name = "radSilver"
        Me.radSilver.Size = New System.Drawing.Size(51, 17)
        Me.radSilver.TabIndex = 2
        Me.radSilver.TabStop = True
        Me.radSilver.Text = "Silver"
        Me.radSilver.UseVisualStyleBackColor = True
        '
        'radGold
        '
        Me.radGold.AutoSize = True
        Me.radGold.Location = New System.Drawing.Point(33, 113)
        Me.radGold.Name = "radGold"
        Me.radGold.Size = New System.Drawing.Size(47, 17)
        Me.radGold.TabIndex = 3
        Me.radGold.TabStop = True
        Me.radGold.Text = "Gold"
        Me.radGold.UseVisualStyleBackColor = True
        '
        'radDiamond
        '
        Me.radDiamond.AutoSize = True
        Me.radDiamond.Location = New System.Drawing.Point(33, 138)
        Me.radDiamond.Name = "radDiamond"
        Me.radDiamond.Size = New System.Drawing.Size(67, 17)
        Me.radDiamond.TabIndex = 4
        Me.radDiamond.TabStop = True
        Me.radDiamond.Text = "Diamond"
        Me.radDiamond.UseVisualStyleBackColor = True
        '
        'lblPackages
        '
        Me.lblPackages.AutoSize = True
        Me.lblPackages.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPackages.Location = New System.Drawing.Point(30, 42)
        Me.lblPackages.Name = "lblPackages"
        Me.lblPackages.Size = New System.Drawing.Size(58, 13)
        Me.lblPackages.TabIndex = 0
        Me.lblPackages.Text = "Packages:"
        '
        'lblCharge
        '
        Me.lblCharge.AutoSize = True
        Me.lblCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharge.Location = New System.Drawing.Point(175, 42)
        Me.lblCharge.Name = "lblCharge"
        Me.lblCharge.Size = New System.Drawing.Size(99, 13)
        Me.lblCharge.TabIndex = 13
        Me.lblCharge.Text = "Monthly Charge ($):"
        '
        'lblBasic
        '
        Me.lblBasic.AutoSize = True
        Me.lblBasic.Location = New System.Drawing.Point(175, 67)
        Me.lblBasic.Name = "lblBasic"
        Me.lblBasic.Size = New System.Drawing.Size(34, 13)
        Me.lblBasic.TabIndex = 14
        Me.lblBasic.Text = "24.99"
        '
        'lblSilver
        '
        Me.lblSilver.AutoSize = True
        Me.lblSilver.Location = New System.Drawing.Point(175, 92)
        Me.lblSilver.Name = "lblSilver"
        Me.lblSilver.Size = New System.Drawing.Size(34, 13)
        Me.lblSilver.TabIndex = 15
        Me.lblSilver.Text = "42.99"
        '
        'lblGold
        '
        Me.lblGold.AutoSize = True
        Me.lblGold.Location = New System.Drawing.Point(175, 117)
        Me.lblGold.Name = "lblGold"
        Me.lblGold.Size = New System.Drawing.Size(34, 13)
        Me.lblGold.TabIndex = 16
        Me.lblGold.Text = "84.99"
        '
        'lblDiamond
        '
        Me.lblDiamond.AutoSize = True
        Me.lblDiamond.Location = New System.Drawing.Point(175, 142)
        Me.lblDiamond.Name = "lblDiamond"
        Me.lblDiamond.Size = New System.Drawing.Size(34, 13)
        Me.lblDiamond.TabIndex = 17
        Me.lblDiamond.Text = "99.99"
        '
        'lblAddOn
        '
        Me.lblAddOn.AutoSize = True
        Me.lblAddOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddOn.Location = New System.Drawing.Point(30, 200)
        Me.lblAddOn.Name = "lblAddOn"
        Me.lblAddOn.Size = New System.Drawing.Size(94, 13)
        Me.lblAddOn.TabIndex = 5
        Me.lblAddOn.Text = "Additional features"
        '
        'lblAddOnCharge
        '
        Me.lblAddOnCharge.AutoSize = True
        Me.lblAddOnCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddOnCharge.Location = New System.Drawing.Point(227, 200)
        Me.lblAddOnCharge.Name = "lblAddOnCharge"
        Me.lblAddOnCharge.Size = New System.Drawing.Size(99, 13)
        Me.lblAddOnCharge.TabIndex = 18
        Me.lblAddOnCharge.Text = "Monthly Charge ($):"
        '
        'lblCinnematicPrice
        '
        Me.lblCinnematicPrice.AutoSize = True
        Me.lblCinnematicPrice.Location = New System.Drawing.Point(227, 228)
        Me.lblCinnematicPrice.Name = "lblCinnematicPrice"
        Me.lblCinnematicPrice.Size = New System.Drawing.Size(28, 13)
        Me.lblCinnematicPrice.TabIndex = 19
        Me.lblCinnematicPrice.Text = "9.50"
        '
        'lblHBIPrice
        '
        Me.lblHBIPrice.AutoSize = True
        Me.lblHBIPrice.Location = New System.Drawing.Point(227, 256)
        Me.lblHBIPrice.Name = "lblHBIPrice"
        Me.lblHBIPrice.Size = New System.Drawing.Size(28, 13)
        Me.lblHBIPrice.TabIndex = 20
        Me.lblHBIPrice.Text = "9.50"
        '
        'lblShowtimerPrice
        '
        Me.lblShowtimerPrice.AutoSize = True
        Me.lblShowtimerPrice.Location = New System.Drawing.Point(227, 284)
        Me.lblShowtimerPrice.Name = "lblShowtimerPrice"
        Me.lblShowtimerPrice.Size = New System.Drawing.Size(34, 13)
        Me.lblShowtimerPrice.TabIndex = 21
        Me.lblShowtimerPrice.Text = "10.50"
        '
        'lblLocalPrice
        '
        Me.lblLocalPrice.AutoSize = True
        Me.lblLocalPrice.Location = New System.Drawing.Point(227, 312)
        Me.lblLocalPrice.Name = "lblLocalPrice"
        Me.lblLocalPrice.Size = New System.Drawing.Size(28, 13)
        Me.lblLocalPrice.TabIndex = 22
        Me.lblLocalPrice.Text = "6.00"
        '
        'chkCinnematic
        '
        Me.chkCinnematic.AutoSize = True
        Me.chkCinnematic.Location = New System.Drawing.Point(33, 225)
        Me.chkCinnematic.Name = "chkCinnematic"
        Me.chkCinnematic.Size = New System.Drawing.Size(157, 17)
        Me.chkCinnematic.TabIndex = 6
        Me.chkCinnematic.Text = "Cinnematic Movie Channels"
        Me.chkCinnematic.UseVisualStyleBackColor = True
        '
        'chkHBI
        '
        Me.chkHBI.AutoSize = True
        Me.chkHBI.Location = New System.Drawing.Point(33, 254)
        Me.chkHBI.Name = "chkHBI"
        Me.chkHBI.Size = New System.Drawing.Size(123, 17)
        Me.chkHBI.TabIndex = 7
        Me.chkHBI.Text = "HBI Movie Channels"
        Me.chkHBI.UseVisualStyleBackColor = True
        '
        'chkShowtimer
        '
        Me.chkShowtimer.AutoSize = True
        Me.chkShowtimer.Location = New System.Drawing.Point(33, 283)
        Me.chkShowtimer.Name = "chkShowtimer"
        Me.chkShowtimer.Size = New System.Drawing.Size(154, 17)
        Me.chkShowtimer.TabIndex = 8
        Me.chkShowtimer.Text = "Showtimer Movie Channels"
        Me.chkShowtimer.UseVisualStyleBackColor = True
        '
        'chkLocal
        '
        Me.chkLocal.AutoSize = True
        Me.chkLocal.Location = New System.Drawing.Point(33, 312)
        Me.chkLocal.Name = "chkLocal"
        Me.chkLocal.Size = New System.Drawing.Size(93, 17)
        Me.chkLocal.TabIndex = 9
        Me.chkLocal.Text = "Local Stations"
        Me.chkLocal.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(64, 390)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 10
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(199, 390)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(61, 352)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 24
        Me.lblTotal.Text = "Total:"
        '
        'lblTotalBox
        '
        Me.lblTotalBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblTotalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalBox.Location = New System.Drawing.Point(227, 342)
        Me.lblTotalBox.Name = "lblTotalBox"
        Me.lblTotalBox.Size = New System.Drawing.Size(75, 23)
        Me.lblTotalBox.TabIndex = 23
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTotalBox)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.chkLocal)
        Me.Controls.Add(Me.chkShowtimer)
        Me.Controls.Add(Me.chkHBI)
        Me.Controls.Add(Me.chkCinnematic)
        Me.Controls.Add(Me.lblLocalPrice)
        Me.Controls.Add(Me.lblShowtimerPrice)
        Me.Controls.Add(Me.lblHBIPrice)
        Me.Controls.Add(Me.lblCinnematicPrice)
        Me.Controls.Add(Me.lblAddOnCharge)
        Me.Controls.Add(Me.lblAddOn)
        Me.Controls.Add(Me.lblDiamond)
        Me.Controls.Add(Me.lblGold)
        Me.Controls.Add(Me.lblSilver)
        Me.Controls.Add(Me.lblBasic)
        Me.Controls.Add(Me.lblCharge)
        Me.Controls.Add(Me.lblPackages)
        Me.Controls.Add(Me.radDiamond)
        Me.Controls.Add(Me.radGold)
        Me.Controls.Add(Me.radSilver)
        Me.Controls.Add(Me.radBasic)
        Me.Name = "Form1"
        Me.Text = "frmMain"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radBasic As RadioButton
    Friend WithEvents radSilver As RadioButton
    Friend WithEvents radGold As RadioButton
    Friend WithEvents radDiamond As RadioButton
    Friend WithEvents lblPackages As Label
    Friend WithEvents lblCharge As Label
    Friend WithEvents lblBasic As Label
    Friend WithEvents lblSilver As Label
    Friend WithEvents lblGold As Label
    Friend WithEvents lblDiamond As Label
    Friend WithEvents lblAddOn As Label
    Friend WithEvents lblAddOnCharge As Label
    Friend WithEvents lblCinnematicPrice As Label
    Friend WithEvents lblHBIPrice As Label
    Friend WithEvents lblShowtimerPrice As Label
    Friend WithEvents lblLocalPrice As Label
    Friend WithEvents chkCinnematic As CheckBox
    Friend WithEvents chkHBI As CheckBox
    Friend WithEvents chkShowtimer As CheckBox
    Friend WithEvents chkLocal As CheckBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotalBox As Label
End Class
