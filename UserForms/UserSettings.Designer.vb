<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserSettings
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserSettings))
        Me.BtnUser = New System.Windows.Forms.Button()
        Me.BtnSeller = New System.Windows.Forms.Button()
        Me.PbProfile = New System.Windows.Forms.PictureBox()
        Me.PnlUser = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.btnSwitchAccount = New System.Windows.Forms.Button()
        Me.SecurityInformation = New System.Windows.Forms.GroupBox()
        Me.LblProfileIcNum = New System.Windows.Forms.Label()
        Me.LblProfilePassword = New System.Windows.Forms.Label()
        Me.LblProfilePhoneNumber = New System.Windows.Forms.Label()
        Me.LblProfileEmail = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblProfileGender = New System.Windows.Forms.Label()
        Me.LblProfileCountry = New System.Windows.Forms.Label()
        Me.LblProfileBirthday = New System.Windows.Forms.Label()
        Me.LblProfileAge = New System.Windows.Forms.Label()
        Me.LblProfileAddress = New System.Windows.Forms.Label()
        Me.LblProfileName = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PnlSeller = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnAddPackage = New System.Windows.Forms.Button()
        Me.BtnSeeReqs = New System.Windows.Forms.Button()
        Me.BtnClient = New System.Windows.Forms.Button()
        Me.BtnSeeBookings = New System.Windows.Forms.Button()
        Me.OtralaDBDataSet = New Otrala_2._0.OtralaDBDataSet()
        Me.UserInfoTableAdapter = New Otrala_2._0.OtralaDBDataSetTableAdapters.UserInfoTableAdapter()
        Me.PackageTableAdapter = New Otrala_2._0.OtralaDBDataSetTableAdapters.PackageTableAdapter()
        Me.LoginInfoTableAdapter = New Otrala_2._0.OtralaDBDataSetTableAdapters.LoginInfoTableAdapter()
        Me.RequestTableAdapter = New Otrala_2._0.OtralaDBDataSetTableAdapters.RequestTableAdapter()
        Me.RequestAnswerTableAdapter = New Otrala_2._0.OtralaDBDataSetTableAdapters.RequestAnswerTableAdapter()
        Me.BookingTableAdapter = New Otrala_2._0.OtralaDBDataSetTableAdapters.BookingTableAdapter()
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SellerApplicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SellerApplicationTableAdapter = New Otrala_2._0.OtralaDBDataSetTableAdapters.SellerApplicationTableAdapter()
        CType(Me.PbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlUser.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SecurityInformation.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PnlSeller.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SellerApplicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnUser
        '
        Me.BtnUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnUser.Enabled = False
        Me.BtnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUser.Location = New System.Drawing.Point(0, 110)
        Me.BtnUser.Name = "BtnUser"
        Me.BtnUser.Size = New System.Drawing.Size(186, 50)
        Me.BtnUser.TabIndex = 24
        Me.BtnUser.Text = "Profile"
        Me.BtnUser.UseVisualStyleBackColor = False
        '
        'BtnSeller
        '
        Me.BtnSeller.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSeller.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSeller.Location = New System.Drawing.Point(0, 166)
        Me.BtnSeller.Name = "BtnSeller"
        Me.BtnSeller.Size = New System.Drawing.Size(186, 50)
        Me.BtnSeller.TabIndex = 24
        Me.BtnSeller.Text = "Edit Travel Agency"
        Me.BtnSeller.UseVisualStyleBackColor = False
        '
        'PbProfile
        '
        Me.PbProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PbProfile.Image = Global.Otrala_2._0.My.Resources.Resources.NoAvatar
        Me.PbProfile.Location = New System.Drawing.Point(141, 29)
        Me.PbProfile.Name = "PbProfile"
        Me.PbProfile.Size = New System.Drawing.Size(154, 154)
        Me.PbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbProfile.TabIndex = 25
        Me.PbProfile.TabStop = False
        '
        'PnlUser
        '
        Me.PnlUser.AutoScroll = True
        Me.PnlUser.AutoScrollMargin = New System.Drawing.Size(0, 20)
        Me.PnlUser.Controls.Add(Me.GroupBox2)
        Me.PnlUser.Controls.Add(Me.SecurityInformation)
        Me.PnlUser.Controls.Add(Me.GroupBox1)
        Me.PnlUser.Location = New System.Drawing.Point(186, 110)
        Me.PnlUser.Name = "PnlUser"
        Me.PnlUser.Size = New System.Drawing.Size(1076, 563)
        Me.PnlUser.TabIndex = 26
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.BtnDelete)
        Me.GroupBox2.Controls.Add(Me.BtnEdit)
        Me.GroupBox2.Controls.Add(Me.btnSwitchAccount)
        Me.GroupBox2.Location = New System.Drawing.Point(529, 377)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(495, 200)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.Location = New System.Drawing.Point(79, 144)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(332, 43)
        Me.BtnDelete.TabIndex = 0
        Me.BtnDelete.Text = "Delete Account"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnEdit.ForeColor = System.Drawing.Color.White
        Me.BtnEdit.Location = New System.Drawing.Point(79, 29)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(332, 43)
        Me.BtnEdit.TabIndex = 0
        Me.BtnEdit.Text = "Edit Profile"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'btnSwitchAccount
        '
        Me.btnSwitchAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnSwitchAccount.ForeColor = System.Drawing.Color.White
        Me.btnSwitchAccount.Location = New System.Drawing.Point(79, 88)
        Me.btnSwitchAccount.Name = "btnSwitchAccount"
        Me.btnSwitchAccount.Size = New System.Drawing.Size(332, 43)
        Me.btnSwitchAccount.TabIndex = 0
        Me.btnSwitchAccount.Text = "Switch Account"
        Me.btnSwitchAccount.UseVisualStyleBackColor = False
        '
        'SecurityInformation
        '
        Me.SecurityInformation.BackColor = System.Drawing.Color.White
        Me.SecurityInformation.Controls.Add(Me.LblProfileIcNum)
        Me.SecurityInformation.Controls.Add(Me.LblProfilePassword)
        Me.SecurityInformation.Controls.Add(Me.LblProfilePhoneNumber)
        Me.SecurityInformation.Controls.Add(Me.LblProfileEmail)
        Me.SecurityInformation.Controls.Add(Me.Label12)
        Me.SecurityInformation.Controls.Add(Me.Label8)
        Me.SecurityInformation.Controls.Add(Me.Label11)
        Me.SecurityInformation.Controls.Add(Me.Label10)
        Me.SecurityInformation.Controls.Add(Me.Label3)
        Me.SecurityInformation.Location = New System.Drawing.Point(529, 41)
        Me.SecurityInformation.Name = "SecurityInformation"
        Me.SecurityInformation.Size = New System.Drawing.Size(495, 330)
        Me.SecurityInformation.TabIndex = 27
        Me.SecurityInformation.TabStop = False
        Me.SecurityInformation.Text = "Security Information"
        '
        'LblProfileIcNum
        '
        Me.LblProfileIcNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblProfileIcNum.Location = New System.Drawing.Point(29, 270)
        Me.LblProfileIcNum.Name = "LblProfileIcNum"
        Me.LblProfileIcNum.Size = New System.Drawing.Size(450, 30)
        Me.LblProfileIcNum.TabIndex = 27
        Me.LblProfileIcNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblProfilePassword
        '
        Me.LblProfilePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblProfilePassword.Location = New System.Drawing.Point(29, 201)
        Me.LblProfilePassword.Name = "LblProfilePassword"
        Me.LblProfilePassword.Size = New System.Drawing.Size(450, 30)
        Me.LblProfilePassword.TabIndex = 27
        Me.LblProfilePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblProfilePhoneNumber
        '
        Me.LblProfilePhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblProfilePhoneNumber.Location = New System.Drawing.Point(29, 137)
        Me.LblProfilePhoneNumber.Name = "LblProfilePhoneNumber"
        Me.LblProfilePhoneNumber.Size = New System.Drawing.Size(450, 30)
        Me.LblProfilePhoneNumber.TabIndex = 27
        Me.LblProfilePhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblProfileEmail
        '
        Me.LblProfileEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblProfileEmail.Location = New System.Drawing.Point(29, 74)
        Me.LblProfileEmail.Name = "LblProfileEmail"
        Me.LblProfileEmail.Size = New System.Drawing.Size(450, 30)
        Me.LblProfileEmail.TabIndex = 27
        Me.LblProfileEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(31, 244)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(195, 23)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "IC Number/Passport:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 23)
        Me.Label8.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(31, 175)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 23)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Password: "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(31, 111)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(145, 23)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Phone Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 23)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Email:  "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.LblProfileGender)
        Me.GroupBox1.Controls.Add(Me.LblProfileCountry)
        Me.GroupBox1.Controls.Add(Me.LblProfileBirthday)
        Me.GroupBox1.Controls.Add(Me.LblProfileAge)
        Me.GroupBox1.Controls.Add(Me.LblProfileAddress)
        Me.GroupBox1.Controls.Add(Me.LblProfileName)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.PbProfile)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(41, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 536)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Basic Information"
        '
        'LblProfileGender
        '
        Me.LblProfileGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblProfileGender.Location = New System.Drawing.Point(321, 393)
        Me.LblProfileGender.Name = "LblProfileGender"
        Me.LblProfileGender.Size = New System.Drawing.Size(104, 30)
        Me.LblProfileGender.TabIndex = 27
        Me.LblProfileGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblProfileCountry
        '
        Me.LblProfileCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblProfileCountry.Location = New System.Drawing.Point(117, 488)
        Me.LblProfileCountry.Name = "LblProfileCountry"
        Me.LblProfileCountry.Size = New System.Drawing.Size(143, 30)
        Me.LblProfileCountry.TabIndex = 27
        Me.LblProfileCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblProfileBirthday
        '
        Me.LblProfileBirthday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblProfileBirthday.Location = New System.Drawing.Point(117, 443)
        Me.LblProfileBirthday.Name = "LblProfileBirthday"
        Me.LblProfileBirthday.Size = New System.Drawing.Size(308, 30)
        Me.LblProfileBirthday.TabIndex = 27
        Me.LblProfileBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblProfileAge
        '
        Me.LblProfileAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblProfileAge.Location = New System.Drawing.Point(117, 393)
        Me.LblProfileAge.Name = "LblProfileAge"
        Me.LblProfileAge.Size = New System.Drawing.Size(79, 30)
        Me.LblProfileAge.TabIndex = 27
        Me.LblProfileAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblProfileAddress
        '
        Me.LblProfileAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblProfileAddress.Location = New System.Drawing.Point(27, 261)
        Me.LblProfileAddress.Name = "LblProfileAddress"
        Me.LblProfileAddress.Size = New System.Drawing.Size(398, 123)
        Me.LblProfileAddress.TabIndex = 27
        '
        'LblProfileName
        '
        Me.LblProfileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblProfileName.Location = New System.Drawing.Point(98, 201)
        Me.LblProfileName.Name = "LblProfileName"
        Me.LblProfileName.Size = New System.Drawing.Size(327, 30)
        Me.LblProfileName.TabIndex = 27
        Me.LblProfileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(23, 489)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 23)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Country: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 204)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 23)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Name: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 444)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 23)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Birthday:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(227, 397)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 23)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Gender: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 397)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 23)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Age: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 23)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Address: "
        '
        'PnlSeller
        '
        Me.PnlSeller.AutoScroll = True
        Me.PnlSeller.AutoScrollMargin = New System.Drawing.Size(0, 20)
        Me.PnlSeller.Controls.Add(Me.Panel3)
        Me.PnlSeller.Controls.Add(Me.Panel2)
        Me.PnlSeller.Enabled = False
        Me.PnlSeller.Location = New System.Drawing.Point(186, 110)
        Me.PnlSeller.Name = "PnlSeller"
        Me.PnlSeller.Size = New System.Drawing.Size(1076, 563)
        Me.PnlSeller.TabIndex = 29
        Me.PnlSeller.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.Label25)
        Me.Panel3.Controls.Add(Me.Label24)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Location = New System.Drawing.Point(47, 406)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(961, 359)
        Me.Panel3.TabIndex = 34
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(315, 299)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(163, 31)
        Me.Button5.TabIndex = 33
        Me.Button5.Text = "Make an Offer"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(17, 241)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(123, 23)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Price range :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(495, 17)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(170, 23)
        Me.Label22.TabIndex = 32
        Me.Label22.Text = "Additional Notes : "
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(181, 201)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(101, 23)
        Me.Label25.TabIndex = 32
        Me.Label25.Text = "Duration : "
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(17, 280)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(102, 23)
        Me.Label24.TabIndex = 32
        Me.Label24.Text = "Location : "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(17, 201)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 23)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Pax : "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(181, 137)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(234, 23)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Planned Date : 11/7/2003"
        '
        'Label23
        '
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Location = New System.Drawing.Point(495, 40)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(439, 290)
        Me.Label23.TabIndex = 31
        Me.Label23.Text = "Contact Info :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Luqman Nur Hakim" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Luqman@Tard.com" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "01238098"
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(181, 21)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(295, 100)
        Me.Label21.TabIndex = 31
        Me.Label21.Text = "Contact Info :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Luqman Nur Hakim" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Luqman@Tard.com" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "01238098"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(21, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(156, 156)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Location = New System.Drawing.Point(47, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(961, 359)
        Me.Panel2.TabIndex = 29
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(21, 299)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(195, 31)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(283, 299)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 31)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Mark As Completed"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(17, 238)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(160, 23)
        Me.Label20.TabIndex = 32
        Me.Label20.Text = "Total Price Paid: "
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(17, 201)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(95, 23)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "Quantity: "
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(181, 137)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(295, 46)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "Planned Date : 11/7/2003"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(181, 21)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(295, 100)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Contact Info :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Luqman Nur Hakim" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Luqman@Tard.com" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "01238098"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(21, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(156, 156)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(499, 29)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(435, 306)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'BtnAddPackage
        '
        Me.BtnAddPackage.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnAddPackage.Enabled = False
        Me.BtnAddPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddPackage.Location = New System.Drawing.Point(0, 222)
        Me.BtnAddPackage.Name = "BtnAddPackage"
        Me.BtnAddPackage.Size = New System.Drawing.Size(186, 50)
        Me.BtnAddPackage.TabIndex = 24
        Me.BtnAddPackage.Text = "Add Package"
        Me.BtnAddPackage.UseVisualStyleBackColor = False
        Me.BtnAddPackage.Visible = False
        '
        'BtnSeeReqs
        '
        Me.BtnSeeReqs.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSeeReqs.Enabled = False
        Me.BtnSeeReqs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSeeReqs.Location = New System.Drawing.Point(0, 278)
        Me.BtnSeeReqs.Name = "BtnSeeReqs"
        Me.BtnSeeReqs.Size = New System.Drawing.Size(186, 50)
        Me.BtnSeeReqs.TabIndex = 24
        Me.BtnSeeReqs.Text = "See Requests"
        Me.BtnSeeReqs.UseVisualStyleBackColor = False
        Me.BtnSeeReqs.Visible = False
        '
        'BtnClient
        '
        Me.BtnClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnClient.Enabled = False
        Me.BtnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClient.Location = New System.Drawing.Point(0, 334)
        Me.BtnClient.Name = "BtnClient"
        Me.BtnClient.Size = New System.Drawing.Size(186, 50)
        Me.BtnClient.TabIndex = 24
        Me.BtnClient.Text = "Client Bookings"
        Me.BtnClient.UseVisualStyleBackColor = False
        Me.BtnClient.Visible = False
        '
        'BtnSeeBookings
        '
        Me.BtnSeeBookings.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSeeBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSeeBookings.Location = New System.Drawing.Point(0, 222)
        Me.BtnSeeBookings.Name = "BtnSeeBookings"
        Me.BtnSeeBookings.Size = New System.Drawing.Size(186, 50)
        Me.BtnSeeBookings.TabIndex = 24
        Me.BtnSeeBookings.Text = "See Bookings"
        Me.BtnSeeBookings.UseVisualStyleBackColor = False
        '
        'OtralaDBDataSet
        '
        Me.OtralaDBDataSet.DataSetName = "OtralaDBDataSet"
        Me.OtralaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserInfoTableAdapter
        '
        Me.UserInfoTableAdapter.ClearBeforeFill = True
        '
        'PackageTableAdapter
        '
        Me.PackageTableAdapter.ClearBeforeFill = True
        '
        'LoginInfoTableAdapter
        '
        Me.LoginInfoTableAdapter.ClearBeforeFill = True
        '
        'RequestTableAdapter
        '
        Me.RequestTableAdapter.ClearBeforeFill = True
        '
        'RequestAnswerTableAdapter
        '
        Me.RequestAnswerTableAdapter.ClearBeforeFill = True
        '
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
        '
        'BookingBindingSource
        '
        Me.BookingBindingSource.DataMember = "Booking"
        Me.BookingBindingSource.DataSource = Me.OtralaDBDataSet
        '
        'SellerApplicationBindingSource
        '
        Me.SellerApplicationBindingSource.DataMember = "SellerApplication"
        Me.SellerApplicationBindingSource.DataSource = Me.OtralaDBDataSet
        '
        'SellerApplicationTableAdapter
        '
        Me.SellerApplicationTableAdapter.ClearBeforeFill = True
        '
        'UserSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.BtnClient)
        Me.Controls.Add(Me.BtnSeeReqs)
        Me.Controls.Add(Me.BtnSeller)
        Me.Controls.Add(Me.BtnUser)
        Me.Controls.Add(Me.BtnSeeBookings)
        Me.Controls.Add(Me.BtnAddPackage)
        Me.Controls.Add(Me.PnlUser)
        Me.Controls.Add(Me.PnlSeller)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UserSettings"
        Me.Controls.SetChildIndex(Me.PnlSeller, 0)
        Me.Controls.SetChildIndex(Me.PnlUser, 0)
        Me.Controls.SetChildIndex(Me.BtnAddPackage, 0)
        Me.Controls.SetChildIndex(Me.BtnSeeBookings, 0)
        Me.Controls.SetChildIndex(Me.BtnUser, 0)
        Me.Controls.SetChildIndex(Me.BtnSeller, 0)
        Me.Controls.SetChildIndex(Me.BtnSeeReqs, 0)
        Me.Controls.SetChildIndex(Me.BtnClient, 0)
        CType(Me.PbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlUser.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.SecurityInformation.ResumeLayout(False)
        Me.SecurityInformation.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PnlSeller.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SellerApplicationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnUser As Button
    Friend WithEvents BtnSeller As Button
    Friend WithEvents PbProfile As PictureBox
    Friend WithEvents PnlUser As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SecurityInformation As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents BtnDelete As Button
    Friend WithEvents OtralaDBDataSet As OtralaDBDataSet
    Friend WithEvents UserInfoTableAdapter As OtralaDBDataSetTableAdapters.UserInfoTableAdapter
    Friend WithEvents PackageTableAdapter As OtralaDBDataSetTableAdapters.PackageTableAdapter
    Friend WithEvents BtnEdit As Button
    Friend WithEvents LblProfileIcNum As Label
    Friend WithEvents LblProfilePassword As Label
    Friend WithEvents LblProfilePhoneNumber As Label
    Friend WithEvents LblProfileEmail As Label
    Friend WithEvents LblProfileGender As Label
    Friend WithEvents LblProfileAge As Label
    Friend WithEvents LblProfileName As Label
    Friend WithEvents LblProfileCountry As Label
    Friend WithEvents LblProfileBirthday As Label
    Friend WithEvents LoginInfoTableAdapter As OtralaDBDataSetTableAdapters.LoginInfoTableAdapter
    Friend WithEvents LblProfileAddress As Label
    Friend WithEvents PnlSeller As Panel
    Friend WithEvents BtnAddPackage As Button
    Friend WithEvents BtnSeeReqs As Button
    Friend WithEvents RequestTableAdapter As OtralaDBDataSetTableAdapters.RequestTableAdapter
    Friend WithEvents RequestAnswerTableAdapter As OtralaDBDataSetTableAdapters.RequestAnswerTableAdapter
    Friend WithEvents BtnClient As Button
    Friend WithEvents BookingTableAdapter As OtralaDBDataSetTableAdapters.BookingTableAdapter
    Friend WithEvents BookingBindingSource As BindingSource
    Friend WithEvents BtnSeeBookings As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents btnSwitchAccount As Button
    Friend WithEvents SellerApplicationBindingSource As BindingSource
    Friend WithEvents SellerApplicationTableAdapter As OtralaDBDataSetTableAdapters.SellerApplicationTableAdapter
End Class
