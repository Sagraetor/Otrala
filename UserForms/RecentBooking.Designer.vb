<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RecentBooking
    Inherits BaseForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecentBooking))
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GbxBooking = New System.Windows.Forms.GroupBox()
        Me.DTPickerStart = New System.Windows.Forms.DateTimePicker()
        Me.LblDescription = New System.Windows.Forms.Label()
        Me.LblEndDate = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblPax = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblPrice = New System.Windows.Forms.Label()
        Me.PicPackage = New System.Windows.Forms.PictureBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblDateDuration = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gbxPayment = New System.Windows.Forms.GroupBox()
        Me.mskCVV = New System.Windows.Forms.MaskedTextBox()
        Me.mskExpiration = New System.Windows.Forms.MaskedTextBox()
        Me.txtCardName = New System.Windows.Forms.TextBox()
        Me.mskCardNum = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GbxBooking.SuspendLayout()
        CType(Me.PicPackage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbxPayment.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(782, 623)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(109, 30)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GbxBooking
        '
        Me.GbxBooking.Controls.Add(Me.DTPickerStart)
        Me.GbxBooking.Controls.Add(Me.LblDescription)
        Me.GbxBooking.Controls.Add(Me.LblEndDate)
        Me.GbxBooking.Controls.Add(Me.Label14)
        Me.GbxBooking.Controls.Add(Me.Label10)
        Me.GbxBooking.Controls.Add(Me.LblPax)
        Me.GbxBooking.Controls.Add(Me.Label4)
        Me.GbxBooking.Controls.Add(Me.LblPrice)
        Me.GbxBooking.Controls.Add(Me.PicPackage)
        Me.GbxBooking.Location = New System.Drawing.Point(252, 141)
        Me.GbxBooking.Name = "GbxBooking"
        Me.GbxBooking.Size = New System.Drawing.Size(931, 211)
        Me.GbxBooking.TabIndex = 13
        Me.GbxBooking.TabStop = False
        Me.GbxBooking.Text = "Booking Details"
        '
        'DTPickerStart
        '
        Me.DTPickerStart.CalendarFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPickerStart.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPickerStart.Location = New System.Drawing.Point(555, 45)
        Me.DTPickerStart.Name = "DTPickerStart"
        Me.DTPickerStart.Size = New System.Drawing.Size(347, 30)
        Me.DTPickerStart.TabIndex = 15
        '
        'LblDescription
        '
        Me.LblDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDescription.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.LblDescription.Location = New System.Drawing.Point(222, 94)
        Me.LblDescription.Name = "LblDescription"
        Me.LblDescription.Size = New System.Drawing.Size(225, 101)
        Me.LblDescription.TabIndex = 2
        Me.LblDescription.Text = "(description)"
        Me.LblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblEndDate
        '
        Me.LblEndDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblEndDate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEndDate.Location = New System.Drawing.Point(555, 101)
        Me.LblEndDate.Name = "LblEndDate"
        Me.LblEndDate.Size = New System.Drawing.Size(347, 30)
        Me.LblEndDate.TabIndex = 17
        Me.LblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(454, 101)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 30)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "End Date : "
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(453, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 30)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Start Date : "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblPax
        '
        Me.LblPax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblPax.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LblPax.Location = New System.Drawing.Point(555, 165)
        Me.LblPax.Name = "LblPax"
        Me.LblPax.Size = New System.Drawing.Size(175, 30)
        Me.LblPax.TabIndex = 17
        Me.LblPax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(492, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 30)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Pax : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblPrice
        '
        Me.LblPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblPrice.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrice.Location = New System.Drawing.Point(222, 43)
        Me.LblPrice.Name = "LblPrice"
        Me.LblPrice.Size = New System.Drawing.Size(225, 29)
        Me.LblPrice.TabIndex = 1
        Me.LblPrice.Text = "(title package)"
        Me.LblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PicPackage
        '
        Me.PicPackage.Location = New System.Drawing.Point(26, 38)
        Me.PicPackage.Name = "PicPackage"
        Me.PicPackage.Size = New System.Drawing.Size(171, 157)
        Me.PicPackage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicPackage.TabIndex = 0
        Me.PicPackage.TabStop = False
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(1030, 623)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(109, 30)
        Me.btnConfirm.TabIndex = 14
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblDateDuration)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(768, 374)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 231)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'LblDateDuration
        '
        Me.LblDateDuration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDateDuration.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LblDateDuration.Location = New System.Drawing.Point(195, 177)
        Me.LblDateDuration.Name = "LblDateDuration"
        Me.LblDateDuration.Size = New System.Drawing.Size(158, 30)
        Me.LblDateDuration.TabIndex = 12
        Me.LblDateDuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(21, 177)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(158, 30)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Date"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.Location = New System.Drawing.Point(195, 123)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(158, 30)
        Me.Label19.TabIndex = 11
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(21, 123)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(158, 30)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Phone Number"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.Location = New System.Drawing.Point(195, 75)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(158, 30)
        Me.Label18.TabIndex = 10
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(21, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(158, 30)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "IC Number/Passport"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(195, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(158, 30)
        Me.Label16.TabIndex = 8
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(21, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(158, 30)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Name"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbxPayment
        '
        Me.gbxPayment.Controls.Add(Me.mskCVV)
        Me.gbxPayment.Controls.Add(Me.mskExpiration)
        Me.gbxPayment.Controls.Add(Me.txtCardName)
        Me.gbxPayment.Controls.Add(Me.mskCardNum)
        Me.gbxPayment.Controls.Add(Me.Label7)
        Me.gbxPayment.Controls.Add(Me.Label6)
        Me.gbxPayment.Controls.Add(Me.Label5)
        Me.gbxPayment.Controls.Add(Me.Label3)
        Me.gbxPayment.Location = New System.Drawing.Point(252, 396)
        Me.gbxPayment.Name = "gbxPayment"
        Me.gbxPayment.Size = New System.Drawing.Size(472, 245)
        Me.gbxPayment.TabIndex = 14
        Me.gbxPayment.TabStop = False
        Me.gbxPayment.Text = "Payment Info"
        '
        'mskCVV
        '
        Me.mskCVV.Location = New System.Drawing.Point(267, 191)
        Me.mskCVV.Mask = "###"
        Me.mskCVV.Name = "mskCVV"
        Me.mskCVV.Size = New System.Drawing.Size(86, 30)
        Me.mskCVV.TabIndex = 7
        Me.mskCVV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mskExpiration
        '
        Me.mskExpiration.Location = New System.Drawing.Point(67, 191)
        Me.mskExpiration.Mask = "## ####"
        Me.mskExpiration.Name = "mskExpiration"
        Me.mskExpiration.Size = New System.Drawing.Size(146, 30)
        Me.mskExpiration.TabIndex = 6
        Me.mskExpiration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCardName
        '
        Me.txtCardName.Location = New System.Drawing.Point(187, 54)
        Me.txtCardName.Name = "txtCardName"
        Me.txtCardName.Size = New System.Drawing.Size(260, 30)
        Me.txtCardName.TabIndex = 5
        '
        'mskCardNum
        '
        Me.mskCardNum.Location = New System.Drawing.Point(187, 103)
        Me.mskCardNum.Mask = "#### #### #### ####"
        Me.mskCardNum.Name = "mskCardNum"
        Me.mskCardNum.Size = New System.Drawing.Size(260, 30)
        Me.mskCardNum.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(267, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 30)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "CVV"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(67, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 30)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Expiration Date"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 30)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Card Number "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 30)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RecentBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.gbxPayment)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.GbxBooking)
        Me.Controls.Add(Me.btnCancel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RecentBooking"
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.GbxBooking, 0)
        Me.Controls.SetChildIndex(Me.btnConfirm, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.gbxPayment, 0)
        Me.GbxBooking.ResumeLayout(False)
        CType(Me.PicPackage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.gbxPayment.ResumeLayout(False)
        Me.gbxPayment.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As Button
    Friend WithEvents GbxBooking As GroupBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents gbxPayment As GroupBox
    Friend WithEvents LblDescription As Label
    Friend WithEvents LblPrice As Label
    Friend WithEvents PicPackage As PictureBox
    Friend WithEvents mskCVV As MaskedTextBox
    Friend WithEvents mskExpiration As MaskedTextBox
    Friend WithEvents txtCardName As TextBox
    Friend WithEvents mskCardNum As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LblDateDuration As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents LblPax As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DTPickerStart As DateTimePicker
    Friend WithEvents LblEndDate As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label10 As Label
End Class
