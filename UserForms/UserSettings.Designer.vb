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
        Me.BtnHistory = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PbProfile = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
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
        Me.LblProfileName = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbAddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OtralaDBDataSet = New Otrala_2._0.OtralaDBDataSet()
        Me.UserInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserInfoTableAdapter = New Otrala_2._0.OtralaDBDataSetTableAdapters.UserInfoTableAdapter()
        Me.PackageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PackageTableAdapter = New Otrala_2._0.OtralaDBDataSetTableAdapters.PackageTableAdapter()
        Me.LoginInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginInfoTableAdapter = New Otrala_2._0.OtralaDBDataSetTableAdapters.LoginInfoTableAdapter()
        CType(Me.PbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SecurityInformation.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PackageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnHistory
        '
        Me.BtnHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHistory.Location = New System.Drawing.Point(0, 110)
        Me.BtnHistory.Name = "BtnHistory"
        Me.BtnHistory.Size = New System.Drawing.Size(186, 50)
        Me.BtnHistory.TabIndex = 24
        Me.BtnHistory.Text = "Profile"
        Me.BtnHistory.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(0, 166)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(186, 50)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Edit Travel Agency"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PbProfile
        '
        Me.PbProfile.Location = New System.Drawing.Point(141, 29)
        Me.PbProfile.Name = "PbProfile"
        Me.PbProfile.Size = New System.Drawing.Size(154, 154)
        Me.PbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbProfile.TabIndex = 25
        Me.PbProfile.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.AutoScrollMargin = New System.Drawing.Size(0, 20)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.SecurityInformation)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(186, 110)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1076, 563)
        Me.Panel1.TabIndex = 26
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.BtnEdit)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Location = New System.Drawing.Point(529, 377)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(495, 200)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(79, 144)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(332, 43)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Delete Account"
        Me.Button4.UseVisualStyleBackColor = False
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
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(79, 88)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(332, 43)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Become a Seller"
        Me.Button3.UseVisualStyleBackColor = False
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
        Me.GroupBox1.Controls.Add(Me.LblProfileName)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TbAddress)
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
        'TbAddress
        '
        Me.TbAddress.Enabled = False
        Me.TbAddress.Location = New System.Drawing.Point(27, 264)
        Me.TbAddress.Multiline = True
        Me.TbAddress.Name = "TbAddress"
        Me.TbAddress.Size = New System.Drawing.Size(398, 114)
        Me.TbAddress.TabIndex = 27
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
        'OtralaDBDataSet
        '
        Me.OtralaDBDataSet.DataSetName = "OtralaDBDataSet"
        Me.OtralaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserInfoBindingSource
        '
        Me.UserInfoBindingSource.DataMember = "UserInfo"
        Me.UserInfoBindingSource.DataSource = Me.OtralaDBDataSet
        '
        'UserInfoTableAdapter
        '
        Me.UserInfoTableAdapter.ClearBeforeFill = True
        '
        'PackageBindingSource
        '
        Me.PackageBindingSource.DataMember = "Package"
        Me.PackageBindingSource.DataSource = Me.OtralaDBDataSet
        '
        'PackageTableAdapter
        '
        Me.PackageTableAdapter.ClearBeforeFill = True
        '
        'LoginInfoBindingSource
        '
        Me.LoginInfoBindingSource.DataMember = "LoginInfo"
        Me.LoginInfoBindingSource.DataSource = Me.OtralaDBDataSet
        '
        'LoginInfoTableAdapter
        '
        Me.LoginInfoTableAdapter.ClearBeforeFill = True
        '
        'UserSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnHistory)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UserSettings"
        Me.Controls.SetChildIndex(Me.BtnHistory, 0)
        Me.Controls.SetChildIndex(Me.Button2, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        CType(Me.PbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.SecurityInformation.ResumeLayout(False)
        Me.SecurityInformation.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PackageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnHistory As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PbProfile As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TbAddress As TextBox
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
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents OtralaDBDataSet As OtralaDBDataSet
    Friend WithEvents UserInfoBindingSource As BindingSource
    Friend WithEvents UserInfoTableAdapter As OtralaDBDataSetTableAdapters.UserInfoTableAdapter
    Friend WithEvents PackageBindingSource As BindingSource
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
    Friend WithEvents LoginInfoBindingSource As BindingSource
    Friend WithEvents LoginInfoTableAdapter As OtralaDBDataSetTableAdapters.LoginInfoTableAdapter
End Class
