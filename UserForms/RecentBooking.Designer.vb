<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RecentBooking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecentBooking))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRecommend = New System.Windows.Forms.Button()
        Me.btnTodaysDeal = New System.Windows.Forms.Button()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnFeedbacks = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.gbxBooking = New System.Windows.Forms.GroupBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picPackage = New System.Windows.Forms.PictureBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.gbxSummary = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gbxPayment = New System.Windows.Forms.GroupBox()
        Me.mskCVV = New System.Windows.Forms.MaskedTextBox()
        Me.mskExpiration = New System.Windows.Forms.MaskedTextBox()
        Me.txtCardName = New System.Windows.Forms.TextBox()
        Me.mskCardNum = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxBooking.SuspendLayout()
        CType(Me.picPackage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxSummary.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbxPayment.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1262, 110)
        Me.Label1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Otrala_2._0.My.Resources.Resources.Otrala_Icon
        Me.PictureBox1.Location = New System.Drawing.Point(22, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 91)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(227, 37)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(484, 30)
        Me.txtSearch.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Location = New System.Drawing.Point(0, 110)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 563)
        Me.Label2.TabIndex = 3
        '
        'btnRecommend
        '
        Me.btnRecommend.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRecommend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecommend.Location = New System.Drawing.Point(0, 123)
        Me.btnRecommend.Name = "btnRecommend"
        Me.btnRecommend.Size = New System.Drawing.Size(186, 50)
        Me.btnRecommend.TabIndex = 4
        Me.btnRecommend.Text = "Recommendation"
        Me.btnRecommend.UseVisualStyleBackColor = False
        '
        'btnTodaysDeal
        '
        Me.btnTodaysDeal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnTodaysDeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTodaysDeal.Location = New System.Drawing.Point(0, 179)
        Me.btnTodaysDeal.Name = "btnTodaysDeal"
        Me.btnTodaysDeal.Size = New System.Drawing.Size(186, 50)
        Me.btnTodaysDeal.TabIndex = 5
        Me.btnTodaysDeal.Text = "Today's Deal"
        Me.btnTodaysDeal.UseVisualStyleBackColor = False
        '
        'btnOrder
        '
        Me.btnOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrder.Location = New System.Drawing.Point(0, 235)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(186, 50)
        Me.btnOrder.TabIndex = 6
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Location = New System.Drawing.Point(0, 623)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(186, 50)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Location = New System.Drawing.Point(0, 567)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(186, 50)
        Me.btnAbout.TabIndex = 8
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'btnFeedbacks
        '
        Me.btnFeedbacks.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnFeedbacks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFeedbacks.Location = New System.Drawing.Point(0, 511)
        Me.btnFeedbacks.Name = "btnFeedbacks"
        Me.btnFeedbacks.Size = New System.Drawing.Size(186, 50)
        Me.btnFeedbacks.TabIndex = 9
        Me.btnFeedbacks.Text = "Feedbacks"
        Me.btnFeedbacks.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1087, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Label4"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(782, 611)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(109, 30)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'gbxBooking
        '
        Me.gbxBooking.Controls.Add(Me.lblDescription)
        Me.gbxBooking.Controls.Add(Me.lblTitle)
        Me.gbxBooking.Controls.Add(Me.picPackage)
        Me.gbxBooking.Location = New System.Drawing.Point(252, 141)
        Me.gbxBooking.Name = "gbxBooking"
        Me.gbxBooking.Size = New System.Drawing.Size(472, 219)
        Me.gbxBooking.TabIndex = 13
        Me.gbxBooking.TabStop = False
        Me.gbxBooking.Text = "Booking Details"
        '
        'lblDescription
        '
        Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDescription.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblDescription.Location = New System.Drawing.Point(222, 94)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(225, 101)
        Me.lblDescription.TabIndex = 2
        Me.lblDescription.Text = "(description)"
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTitle
        '
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitle.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(222, 43)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(225, 29)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "(title package)"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picPackage
        '
        Me.picPackage.Location = New System.Drawing.Point(26, 38)
        Me.picPackage.Name = "picPackage"
        Me.picPackage.Size = New System.Drawing.Size(171, 157)
        Me.picPackage.TabIndex = 0
        Me.picPackage.TabStop = False
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(1030, 611)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(109, 30)
        Me.btnConfirm.TabIndex = 14
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'gbxSummary
        '
        Me.gbxSummary.Controls.Add(Me.lblTotal)
        Me.gbxSummary.Controls.Add(Me.Label14)
        Me.gbxSummary.Controls.Add(Me.Label13)
        Me.gbxSummary.Controls.Add(Me.GroupBox1)
        Me.gbxSummary.Controls.Add(Me.Label8)
        Me.gbxSummary.Location = New System.Drawing.Point(754, 141)
        Me.gbxSummary.Name = "gbxSummary"
        Me.gbxSummary.Size = New System.Drawing.Size(446, 451)
        Me.gbxSummary.TabIndex = 14
        Me.gbxSummary.TabStop = False
        Me.gbxSummary.Text = "Summary"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.Location = New System.Drawing.Point(210, 383)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(175, 30)
        Me.lblTotal.TabIndex = 17
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 7.8!, System.Drawing.FontStyle.Italic)
        Me.Label14.Location = New System.Drawing.Point(189, 413)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(196, 30)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Pay with Credit Card"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(71, 383)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 30)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Total "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 289)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'Label20
        '
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.Location = New System.Drawing.Point(195, 236)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(158, 30)
        Me.Label20.TabIndex = 12
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(21, 236)
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
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(195, 170)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(158, 54)
        Me.Label17.TabIndex = 9
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(21, 170)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(158, 54)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Package" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Booked"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Arial", 10.2!)
        Me.Label8.Location = New System.Drawing.Point(32, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(373, 34)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "The summary of your package choice"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(267, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 30)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "CVV"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(67, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 30)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Expiration Date"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(26, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 30)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Card Number "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(26, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 30)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Name Card "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RecentBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.gbxPayment)
        Me.Controls.Add(Me.gbxSummary)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.gbxBooking)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnFeedbacks)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.btnTodaysDeal)
        Me.Controls.Add(Me.btnRecommend)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "RecentBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OTRALA"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxBooking.ResumeLayout(False)
        CType(Me.picPackage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxSummary.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.gbxPayment.ResumeLayout(False)
        Me.gbxPayment.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRecommend As Button
    Friend WithEvents btnTodaysDeal As Button
    Friend WithEvents btnOrder As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnFeedbacks As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents gbxBooking As GroupBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents gbxSummary As GroupBox
    Friend WithEvents gbxPayment As GroupBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents picPackage As PictureBox
    Friend WithEvents mskCVV As MaskedTextBox
    Friend WithEvents mskExpiration As MaskedTextBox
    Friend WithEvents txtCardName As TextBox
    Friend WithEvents mskCardNum As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
End Class
