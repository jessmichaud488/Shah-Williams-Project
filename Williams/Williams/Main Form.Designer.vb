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
        Me.RadBasic = New System.Windows.Forms.RadioButton()
        Me.RadSilver = New System.Windows.Forms.RadioButton()
        Me.RadGold = New System.Windows.Forms.RadioButton()
        Me.RadDiamond = New System.Windows.Forms.RadioButton()
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
        Me.ChkCinnematic = New System.Windows.Forms.CheckBox()
        Me.chkHBI = New System.Windows.Forms.CheckBox()
        Me.ChkShowtimer = New System.Windows.Forms.CheckBox()
        Me.ChkLocal = New System.Windows.Forms.CheckBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotalBox = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RadBasic
        '
        Me.RadBasic.AutoSize = True
        Me.RadBasic.Location = New System.Drawing.Point(33, 63)
        Me.RadBasic.Name = "RadBasic"
        Me.RadBasic.Size = New System.Drawing.Size(51, 17)
        Me.RadBasic.TabIndex = 1
        Me.RadBasic.TabStop = True
        Me.RadBasic.Text = "Basic"
        Me.RadBasic.UseVisualStyleBackColor = True
        '
        'RadSilver
        '
        Me.RadSilver.AutoSize = True
        Me.RadSilver.Location = New System.Drawing.Point(33, 88)
        Me.RadSilver.Name = "RadSilver"
        Me.RadSilver.Size = New System.Drawing.Size(51, 17)
        Me.RadSilver.TabIndex = 2
        Me.RadSilver.TabStop = True
        Me.RadSilver.Text = "Silver"
        Me.RadSilver.UseVisualStyleBackColor = True
        '
        'RadGold
        '
        Me.RadGold.AutoSize = True
        Me.RadGold.Location = New System.Drawing.Point(33, 113)
        Me.RadGold.Name = "RadGold"
        Me.RadGold.Size = New System.Drawing.Size(47, 17)
        Me.RadGold.TabIndex = 3
        Me.RadGold.TabStop = True
        Me.RadGold.Text = "Gold"
        Me.RadGold.UseVisualStyleBackColor = True
        '
        'RadDiamond
        '
        Me.RadDiamond.AutoSize = True
        Me.RadDiamond.Location = New System.Drawing.Point(33, 138)
        Me.RadDiamond.Name = "RadDiamond"
        Me.RadDiamond.Size = New System.Drawing.Size(67, 17)
        Me.RadDiamond.TabIndex = 4
        Me.RadDiamond.TabStop = True
        Me.RadDiamond.Text = "Diamond"
        Me.RadDiamond.UseVisualStyleBackColor = True
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
        'ChkCinnematic
        '
        Me.ChkCinnematic.AutoSize = True
        Me.ChkCinnematic.Location = New System.Drawing.Point(33, 225)
        Me.ChkCinnematic.Name = "ChkCinnematic"
        Me.ChkCinnematic.Size = New System.Drawing.Size(157, 17)
        Me.ChkCinnematic.TabIndex = 6
        Me.ChkCinnematic.Text = "Cinnematic Movie Channels"
        Me.ChkCinnematic.UseVisualStyleBackColor = True
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
        'ChkShowtimer
        '
        Me.ChkShowtimer.AutoSize = True
        Me.ChkShowtimer.Location = New System.Drawing.Point(33, 283)
        Me.ChkShowtimer.Name = "ChkShowtimer"
        Me.ChkShowtimer.Size = New System.Drawing.Size(154, 17)
        Me.ChkShowtimer.TabIndex = 8
        Me.ChkShowtimer.Text = "Showtimer Movie Channels"
        Me.ChkShowtimer.UseVisualStyleBackColor = True
        '
        'ChkLocal
        '
        Me.ChkLocal.AutoSize = True
        Me.ChkLocal.Location = New System.Drawing.Point(33, 312)
        Me.ChkLocal.Name = "ChkLocal"
        Me.ChkLocal.Size = New System.Drawing.Size(93, 17)
        Me.ChkLocal.TabIndex = 9
        Me.ChkLocal.Text = "Local Stations"
        Me.ChkLocal.UseVisualStyleBackColor = True
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
        Me.Controls.Add(Me.ChkLocal)
        Me.Controls.Add(Me.ChkShowtimer)
        Me.Controls.Add(Me.chkHBI)
        Me.Controls.Add(Me.ChkCinnematic)
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
        Me.Controls.Add(Me.RadDiamond)
        Me.Controls.Add(Me.RadGold)
        Me.Controls.Add(Me.RadSilver)
        Me.Controls.Add(Me.RadBasic)
        Me.Name = "Form1"
        Me.Text = "frmMain"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadBasic As RadioButton
    Friend WithEvents RadSilver As RadioButton
    Friend WithEvents RadGold As RadioButton
    Friend WithEvents RadDiamond As RadioButton
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
    Friend WithEvents ChkCinnematic As CheckBox
    Friend WithEvents chkHBI As CheckBox
    Friend WithEvents ChkShowtimer As CheckBox
    Friend WithEvents ChkLocal As CheckBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotalBox As Label
End Class
