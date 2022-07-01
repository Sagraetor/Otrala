<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginSignUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginSignUp))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelLogIn = New System.Windows.Forms.Panel()
        Me.PbLoginHidePass = New System.Windows.Forms.PictureBox()
        Me.BtnLoginCancel = New System.Windows.Forms.Button()
        Me.BtnLoginSignUp = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnLoginLogin = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TbLoginPass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbLoginInfo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OtralaDBDataSet = New Otrala_2._0.OtralaDBDataSet()
        Me.LoginInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginInfoTableAdapter = New Otrala_2._0.OtralaDBDataSetTableAdapters.LoginInfoTableAdapter()
        Me.LoginInfoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelSignUp = New System.Windows.Forms.Panel()
        Me.PbSUHidePass = New System.Windows.Forms.PictureBox()
        Me.BtnSUCancel = New System.Windows.Forms.Button()
        Me.BtnSULogIn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnSUSignUp = New System.Windows.Forms.Button()
        Me.TbSUConfirmPass = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbSUPass = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbSUEmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbSUPhoneNum = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.UserInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserInfoTableAdapter = New Otrala_2._0.OtralaDBDataSetTableAdapters.UserInfoTableAdapter()
        Me.PanelLogIn.SuspendLayout()
        CType(Me.PbLoginHidePass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginInfoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSignUp.SuspendLayout()
        CType(Me.PbSUHidePass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(51, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WELCOME TO OTRALA!"
        '
        'PanelLogIn
        '
        Me.PanelLogIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelLogIn.Controls.Add(Me.PbLoginHidePass)
        Me.PanelLogIn.Controls.Add(Me.BtnLoginCancel)
        Me.PanelLogIn.Controls.Add(Me.BtnLoginSignUp)
        Me.PanelLogIn.Controls.Add(Me.PictureBox1)
        Me.PanelLogIn.Controls.Add(Me.Label1)
        Me.PanelLogIn.Controls.Add(Me.BtnLoginLogin)
        Me.PanelLogIn.Controls.Add(Me.LinkLabel1)
        Me.PanelLogIn.Controls.Add(Me.TbLoginPass)
        Me.PanelLogIn.Controls.Add(Me.Label4)
        Me.PanelLogIn.Controls.Add(Me.TbLoginInfo)
        Me.PanelLogIn.Controls.Add(Me.Label3)
        Me.PanelLogIn.Controls.Add(Me.Label2)
        Me.PanelLogIn.Location = New System.Drawing.Point(14, 12)
        Me.PanelLogIn.Name = "PanelLogIn"
        Me.PanelLogIn.Size = New System.Drawing.Size(377, 392)
        Me.PanelLogIn.TabIndex = 2
        '
        'PbLoginHidePass
        '
        Me.PbLoginHidePass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PbLoginHidePass.Image = Global.Otrala_2._0.My.Resources.Resources.ClosedEye
        Me.PbLoginHidePass.Location = New System.Drawing.Point(312, 266)
        Me.PbLoginHidePass.Name = "PbLoginHidePass"
        Me.PbLoginHidePass.Size = New System.Drawing.Size(33, 25)
        Me.PbLoginHidePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbLoginHidePass.TabIndex = 10
        Me.PbLoginHidePass.TabStop = False
        '
        'BtnLoginCancel
        '
        Me.BtnLoginCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnLoginCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLoginCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoginCancel.ForeColor = System.Drawing.Color.Black
        Me.BtnLoginCancel.Location = New System.Drawing.Point(147, 350)
        Me.BtnLoginCancel.Name = "BtnLoginCancel"
        Me.BtnLoginCancel.Size = New System.Drawing.Size(86, 33)
        Me.BtnLoginCancel.TabIndex = 9
        Me.BtnLoginCancel.Text = "Cancel"
        Me.BtnLoginCancel.UseVisualStyleBackColor = False
        '
        'BtnLoginSignUp
        '
        Me.BtnLoginSignUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnLoginSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLoginSignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoginSignUp.ForeColor = System.Drawing.Color.Black
        Me.BtnLoginSignUp.Location = New System.Drawing.Point(14, 350)
        Me.BtnLoginSignUp.Name = "BtnLoginSignUp"
        Me.BtnLoginSignUp.Size = New System.Drawing.Size(86, 33)
        Me.BtnLoginSignUp.TabIndex = 9
        Me.BtnLoginSignUp.Text = "Sign Up"
        Me.BtnLoginSignUp.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Otrala_2._0.My.Resources.Resources.Otrala_Icon
        Me.PictureBox1.Location = New System.Drawing.Point(68, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(240, 141)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BtnLoginLogin
        '
        Me.BtnLoginLogin.BackColor = System.Drawing.Color.Black
        Me.BtnLoginLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLoginLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoginLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnLoginLogin.Location = New System.Drawing.Point(278, 350)
        Me.BtnLoginLogin.Name = "BtnLoginLogin"
        Me.BtnLoginLogin.Size = New System.Drawing.Size(86, 33)
        Me.BtnLoginLogin.TabIndex = 3
        Me.BtnLoginLogin.Text = "Login"
        Me.BtnLoginLogin.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(31, 325)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(116, 16)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Forgot Password?"
        '
        'TbLoginPass
        '
        Me.TbLoginPass.BackColor = System.Drawing.Color.White
        Me.TbLoginPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbLoginPass.Location = New System.Drawing.Point(34, 292)
        Me.TbLoginPass.Name = "TbLoginPass"
        Me.TbLoginPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbLoginPass.Size = New System.Drawing.Size(311, 27)
        Me.TbLoginPass.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Password :"
        '
        'TbLoginInfo
        '
        Me.TbLoginInfo.BackColor = System.Drawing.Color.White
        Me.TbLoginInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbLoginInfo.Location = New System.Drawing.Point(34, 233)
        Me.TbLoginInfo.Name = "TbLoginInfo"
        Me.TbLoginInfo.Size = New System.Drawing.Size(311, 27)
        Me.TbLoginInfo.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Email/Phone Number :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(283, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Login to your OTRALA account."
        '
        'OtralaDBDataSet
        '
        Me.OtralaDBDataSet.DataSetName = "OtralaDBDataSet"
        Me.OtralaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'LoginInfoBindingSource1
        '
        Me.LoginInfoBindingSource1.DataMember = "LoginInfo"
        Me.LoginInfoBindingSource1.DataSource = Me.OtralaDBDataSet
        '
        'PanelSignUp
        '
        Me.PanelSignUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelSignUp.Controls.Add(Me.PbSUHidePass)
        Me.PanelSignUp.Controls.Add(Me.BtnSUCancel)
        Me.PanelSignUp.Controls.Add(Me.BtnSULogIn)
        Me.PanelSignUp.Controls.Add(Me.PictureBox2)
        Me.PanelSignUp.Controls.Add(Me.Label5)
        Me.PanelSignUp.Controls.Add(Me.BtnSUSignUp)
        Me.PanelSignUp.Controls.Add(Me.TbSUConfirmPass)
        Me.PanelSignUp.Controls.Add(Me.Label6)
        Me.PanelSignUp.Controls.Add(Me.TbSUPass)
        Me.PanelSignUp.Controls.Add(Me.Label7)
        Me.PanelSignUp.Controls.Add(Me.TbSUEmail)
        Me.PanelSignUp.Controls.Add(Me.Label8)
        Me.PanelSignUp.Controls.Add(Me.TbSUPhoneNum)
        Me.PanelSignUp.Controls.Add(Me.Label9)
        Me.PanelSignUp.Controls.Add(Me.Label10)
        Me.PanelSignUp.Enabled = False
        Me.PanelSignUp.Location = New System.Drawing.Point(14, 12)
        Me.PanelSignUp.Name = "PanelSignUp"
        Me.PanelSignUp.Size = New System.Drawing.Size(377, 392)
        Me.PanelSignUp.TabIndex = 3
        Me.PanelSignUp.Visible = False
        '
        'PbSUHidePass
        '
        Me.PbSUHidePass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PbSUHidePass.Image = Global.Otrala_2._0.My.Resources.Resources.ClosedEye
        Me.PbSUHidePass.Location = New System.Drawing.Point(315, 216)
        Me.PbSUHidePass.Name = "PbSUHidePass"
        Me.PbSUHidePass.Size = New System.Drawing.Size(33, 25)
        Me.PbSUHidePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbSUHidePass.TabIndex = 4
        Me.PbSUHidePass.TabStop = False
        '
        'BtnSUCancel
        '
        Me.BtnSUCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSUCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSUCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSUCancel.ForeColor = System.Drawing.Color.Black
        Me.BtnSUCancel.Location = New System.Drawing.Point(147, 344)
        Me.BtnSUCancel.Name = "BtnSUCancel"
        Me.BtnSUCancel.Size = New System.Drawing.Size(86, 33)
        Me.BtnSUCancel.TabIndex = 9
        Me.BtnSUCancel.Text = "Cancel"
        Me.BtnSUCancel.UseVisualStyleBackColor = False
        '
        'BtnSULogIn
        '
        Me.BtnSULogIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSULogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSULogIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSULogIn.ForeColor = System.Drawing.Color.Black
        Me.BtnSULogIn.Location = New System.Drawing.Point(14, 344)
        Me.BtnSULogIn.Name = "BtnSULogIn"
        Me.BtnSULogIn.Size = New System.Drawing.Size(86, 33)
        Me.BtnSULogIn.TabIndex = 9
        Me.BtnSULogIn.Text = "Log In"
        Me.BtnSULogIn.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Otrala_2._0.My.Resources.Resources.Otrala_Icon
        Me.PictureBox2.Location = New System.Drawing.Point(14, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(105, 80)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(125, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(248, 30)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "CREATE AN ACCOUNT"
        '
        'BtnSUSignUp
        '
        Me.BtnSUSignUp.BackColor = System.Drawing.Color.Black
        Me.BtnSUSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSUSignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSUSignUp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSUSignUp.Location = New System.Drawing.Point(278, 344)
        Me.BtnSUSignUp.Name = "BtnSUSignUp"
        Me.BtnSUSignUp.Size = New System.Drawing.Size(86, 33)
        Me.BtnSUSignUp.TabIndex = 3
        Me.BtnSUSignUp.Text = "Sign Up"
        Me.BtnSUSignUp.UseVisualStyleBackColor = False
        '
        'TbSUConfirmPass
        '
        Me.TbSUConfirmPass.BackColor = System.Drawing.Color.White
        Me.TbSUConfirmPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbSUConfirmPass.Location = New System.Drawing.Point(37, 296)
        Me.TbSUConfirmPass.Name = "TbSUConfirmPass"
        Me.TbSUConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbSUConfirmPass.Size = New System.Drawing.Size(311, 27)
        Me.TbSUConfirmPass.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(37, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Confirm Password :"
        '
        'TbSUPass
        '
        Me.TbSUPass.BackColor = System.Drawing.Color.White
        Me.TbSUPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbSUPass.Location = New System.Drawing.Point(37, 242)
        Me.TbSUPass.Name = "TbSUPass"
        Me.TbSUPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbSUPass.Size = New System.Drawing.Size(311, 27)
        Me.TbSUPass.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(37, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Password :"
        '
        'TbSUEmail
        '
        Me.TbSUEmail.BackColor = System.Drawing.Color.White
        Me.TbSUEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbSUEmail.Location = New System.Drawing.Point(37, 127)
        Me.TbSUEmail.Name = "TbSUEmail"
        Me.TbSUEmail.Size = New System.Drawing.Size(311, 27)
        Me.TbSUEmail.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(37, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 18)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Email :"
        '
        'TbSUPhoneNum
        '
        Me.TbSUPhoneNum.BackColor = System.Drawing.Color.White
        Me.TbSUPhoneNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbSUPhoneNum.Location = New System.Drawing.Point(37, 185)
        Me.TbSUPhoneNum.Name = "TbSUPhoneNum"
        Me.TbSUPhoneNum.Size = New System.Drawing.Size(311, 27)
        Me.TbSUPhoneNum.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(37, 166)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 18)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Phone Number :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(126, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(191, 21)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Please fill in all fields"
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
        'LoginSignUp
        '
        Me.AcceptButton = Me.BtnLoginLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(405, 416)
        Me.Controls.Add(Me.PanelSignUp)
        Me.Controls.Add(Me.PanelLogIn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginSignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.PanelLogIn.ResumeLayout(False)
        Me.PanelLogIn.PerformLayout()
        CType(Me.PbLoginHidePass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginInfoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSignUp.ResumeLayout(False)
        Me.PanelSignUp.PerformLayout()
        CType(Me.PbSUHidePass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelLogIn As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TbLoginPass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TbLoginInfo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnLoginSignUp As Button
    Friend WithEvents BtnLoginLogin As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents OtralaDBDataSet As OtralaDBDataSet
    Friend WithEvents LoginInfoBindingSource As BindingSource
    Friend WithEvents LoginInfoTableAdapter As OtralaDBDataSetTableAdapters.LoginInfoTableAdapter
    Friend WithEvents LoginInfoBindingSource1 As BindingSource
    Friend WithEvents PanelSignUp As Panel
    Friend WithEvents BtnSULogIn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnSUSignUp As Button
    Friend WithEvents TbSUConfirmPass As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TbSUPass As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TbSUEmail As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TbSUPhoneNum As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnLoginCancel As Button
    Friend WithEvents BtnSUCancel As Button
    Friend WithEvents PbSUHidePass As PictureBox
    Friend WithEvents PbLoginHidePass As PictureBox
    Friend WithEvents UserInfoBindingSource As BindingSource
    Friend WithEvents UserInfoTableAdapter As OtralaDBDataSetTableAdapters.UserInfoTableAdapter
End Class
