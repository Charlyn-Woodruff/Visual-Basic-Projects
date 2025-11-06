<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAirBnBReservations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAirBnBReservations))
        Me.picCellPhoneImage = New System.Windows.Forms.PictureBox()
        Me.lblAirBnBTitle = New System.Windows.Forms.Label()
        Me.lblCostPerNight = New System.Windows.Forms.Label()
        Me.lblNumOfNights = New System.Windows.Forms.Label()
        Me.txtEnterNumOfNights = New System.Windows.Forms.TextBox()
        Me.lblCostOfStay = New System.Windows.Forms.Label()
        Me.lblDisplayTotalPriceOfStay = New System.Windows.Forms.Label()
        Me.btnDisplayCost = New System.Windows.Forms.Button()
        Me.btnExitProgram = New System.Windows.Forms.Button()
        Me.btnClearData = New System.Windows.Forms.Button()
        CType(Me.picCellPhoneImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCellPhoneImage
        '
        Me.picCellPhoneImage.Image = CType(resources.GetObject("picCellPhoneImage.Image"), System.Drawing.Image)
        Me.picCellPhoneImage.Location = New System.Drawing.Point(12, -2)
        Me.picCellPhoneImage.Name = "picCellPhoneImage"
        Me.picCellPhoneImage.Size = New System.Drawing.Size(357, 452)
        Me.picCellPhoneImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCellPhoneImage.TabIndex = 0
        Me.picCellPhoneImage.TabStop = False
        '
        'lblAirBnBTitle
        '
        Me.lblAirBnBTitle.AutoSize = True
        Me.lblAirBnBTitle.Font = New System.Drawing.Font("Coolsville", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAirBnBTitle.Location = New System.Drawing.Point(416, 45)
        Me.lblAirBnBTitle.Name = "lblAirBnBTitle"
        Me.lblAirBnBTitle.Size = New System.Drawing.Size(328, 48)
        Me.lblAirBnBTitle.TabIndex = 1
        Me.lblAirBnBTitle.Text = "Orlando AirBnB"
        '
        'lblCostPerNight
        '
        Me.lblCostPerNight.AutoSize = True
        Me.lblCostPerNight.Font = New System.Drawing.Font("Coolsville", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostPerNight.Location = New System.Drawing.Point(481, 120)
        Me.lblCostPerNight.Name = "lblCostPerNight"
        Me.lblCostPerNight.Size = New System.Drawing.Size(0, 24)
        Me.lblCostPerNight.TabIndex = 2
        '
        'lblNumOfNights
        '
        Me.lblNumOfNights.AutoSize = True
        Me.lblNumOfNights.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumOfNights.Location = New System.Drawing.Point(429, 192)
        Me.lblNumOfNights.Name = "lblNumOfNights"
        Me.lblNumOfNights.Size = New System.Drawing.Size(142, 23)
        Me.lblNumOfNights.TabIndex = 3
        Me.lblNumOfNights.Text = "Number of Nights"
        '
        'txtEnterNumOfNights
        '
        Me.txtEnterNumOfNights.Location = New System.Drawing.Point(645, 194)
        Me.txtEnterNumOfNights.Name = "txtEnterNumOfNights"
        Me.txtEnterNumOfNights.Size = New System.Drawing.Size(26, 22)
        Me.txtEnterNumOfNights.TabIndex = 4
        Me.txtEnterNumOfNights.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCostOfStay
        '
        Me.lblCostOfStay.AutoSize = True
        Me.lblCostOfStay.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostOfStay.Location = New System.Drawing.Point(429, 261)
        Me.lblCostOfStay.Name = "lblCostOfStay"
        Me.lblCostOfStay.Size = New System.Drawing.Size(105, 24)
        Me.lblCostOfStay.TabIndex = 5
        Me.lblCostOfStay.Text = "Cost of Stay"
        '
        'lblDisplayTotalPriceOfStay
        '
        Me.lblDisplayTotalPriceOfStay.AutoSize = True
        Me.lblDisplayTotalPriceOfStay.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayTotalPriceOfStay.Location = New System.Drawing.Point(618, 261)
        Me.lblDisplayTotalPriceOfStay.Name = "lblDisplayTotalPriceOfStay"
        Me.lblDisplayTotalPriceOfStay.Size = New System.Drawing.Size(0, 24)
        Me.lblDisplayTotalPriceOfStay.TabIndex = 6
        '
        'btnDisplayCost
        '
        Me.btnDisplayCost.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayCost.Location = New System.Drawing.Point(399, 342)
        Me.btnDisplayCost.Name = "btnDisplayCost"
        Me.btnDisplayCost.Size = New System.Drawing.Size(118, 44)
        Me.btnDisplayCost.TabIndex = 7
        Me.btnDisplayCost.Text = "Display Cost"
        Me.btnDisplayCost.UseVisualStyleBackColor = True
        '
        'btnExitProgram
        '
        Me.btnExitProgram.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitProgram.Location = New System.Drawing.Point(662, 342)
        Me.btnExitProgram.Name = "btnExitProgram"
        Me.btnExitProgram.Size = New System.Drawing.Size(118, 44)
        Me.btnExitProgram.TabIndex = 8
        Me.btnExitProgram.Text = "Exit"
        Me.btnExitProgram.UseVisualStyleBackColor = True
        '
        'btnClearData
        '
        Me.btnClearData.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearData.Location = New System.Drawing.Point(532, 342)
        Me.btnClearData.Name = "btnClearData"
        Me.btnClearData.Size = New System.Drawing.Size(118, 44)
        Me.btnClearData.TabIndex = 9
        Me.btnClearData.Text = "Clear"
        Me.btnClearData.UseVisualStyleBackColor = True
        '
        'frmAirBnBReservations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClearData)
        Me.Controls.Add(Me.btnExitProgram)
        Me.Controls.Add(Me.btnDisplayCost)
        Me.Controls.Add(Me.lblDisplayTotalPriceOfStay)
        Me.Controls.Add(Me.lblCostOfStay)
        Me.Controls.Add(Me.txtEnterNumOfNights)
        Me.Controls.Add(Me.lblNumOfNights)
        Me.Controls.Add(Me.lblCostPerNight)
        Me.Controls.Add(Me.lblAirBnBTitle)
        Me.Controls.Add(Me.picCellPhoneImage)
        Me.Name = "frmAirBnBReservations"
        Me.Text = "AirBnB Reservations"
        CType(Me.picCellPhoneImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picCellPhoneImage As PictureBox
    Friend WithEvents lblAirBnBTitle As Label
    Friend WithEvents lblCostPerNight As Label
    Friend WithEvents lblNumOfNights As Label
    Friend WithEvents txtEnterNumOfNights As TextBox
    Friend WithEvents lblCostOfStay As Label
    Friend WithEvents lblDisplayTotalPriceOfStay As Label
    Friend WithEvents btnDisplayCost As Button
    Friend WithEvents btnExitProgram As Button
    Friend WithEvents btnClearData As Button
End Class
