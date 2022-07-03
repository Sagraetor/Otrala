Public Class LoginSignUp
    'To note, we have 2 panels, PanelLogIn and PanelSignUp. Every control is named using the following convention
    'Controltype,parentpanel,identifyer where parentpanel is either SU for signup or LogIn for Login
    Private Sub ChangeStance(Sender As Button, e As EventArgs) Handles BtnLoginSignUp.Click, BtnSULogIn.Click
        If Sender.Name = "BtnLoginSignUp" Then
            PanelLogIn.Enabled = False
            PanelLogIn.Visible = False
            PanelSignUp.Enabled = True
            PanelSignUp.Visible = True
            Me.Text = "Sign Up"
            BtnSUSignUp.Focus()
            Me.AcceptButton = BtnSUSignUp
            TbLoginInfo.Clear()
            TbLoginPass.Clear()

        ElseIf Sender.Name = "BtnSULogIn" Then
            PanelLogIn.Enabled = True
            PanelLogIn.Visible = True
            PanelSignUp.Enabled = False
            PanelSignUp.Visible = False
            Me.Text = "Log In"
            BtnLoginLogin.Focus()
            Me.AcceptButton = BtnLoginLogin
            TbSUConfirmPass.Clear()
            TbSUEmail.Clear()
            TbSUPass.Clear()
            TbSUPhoneNum.Clear()
        End If
    End Sub

    Private Sub ExitForm() Handles BtnSUCancel.Click, BtnLoginCancel.Click
        Me.Close()
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OtralaDBDataSet.UserInfo' table and 'OtralaDBDataSet.LoginInfo' table. You can move, or remove it, as needed.
        Me.UserInfoTableAdapter.Fill(Me.OtralaDBDataSet.UserInfo)
        Me.LoginInfoTableAdapter.Fill(Me.OtralaDBDataSet.LoginInfo)

    End Sub

    '-------------------------------------------------------------------------------------- All below this is Login Functions
    Dim LoginPassHiden As Boolean = True
    Private Sub LoginToAcc() Handles BtnLoginLogin.Click
        Dim UserInfo As String = TbLoginInfo.Text
        Dim Pword As String = TbLoginPass.Text
        Dim FindInfo As System.Data.DataRow = Nothing

        Select Case OtralAPI.IsEmailOrPhone(UserInfo)
            Case "Email"
                Dim Temp() As DataRow = OtralaDBDataSet.LoginInfo.Select(String.Format("Email = '{0}'", UserInfo))
                If Temp.Length > 0 Then
                    FindInfo = Temp(0)
                Else
                    MsgBox("Incorrect Email/Phone number", MsgBoxStyle.Critical, "Wrong Info")
                    Exit Sub
                End If

            Case "Phone"
                Dim Temp() As DataRow = OtralaDBDataSet.LoginInfo.Select(String.Format("PhoneNumber = '{0}'", UserInfo))
                If Temp.Length > 0 Then
                    FindInfo = Temp(0)
                Else
                    MsgBox("Incorrect Email/Phone number", MsgBoxStyle.Critical, "Wrong Info")
                    Exit Sub
                End If
            Case "No"
                MsgBox("Please enter a valid Email/Phone number", MsgBoxStyle.Critical, "Wrong Info")
                Exit Sub
        End Select

        Dim Key As List(Of Integer) = OtralAPI.StrToLstInt(FindInfo("Key"))
        Dim CorrectPass As List(Of Integer) = OtralAPI.StrToLstInt(FindInfo("Password"))
        Dim DecryptedPass As String = OtralAPI.Decrypt(CorrectPass, Key)

        If Pword = DecryptedPass Then
            MsgBox("Correct!")
            Me.Close()
        ElseIf Pword <> DecryptedPass Then
            MsgBox("Incorrect Password")
            Exit Sub
        End If

        Dim UserID As Integer = FindInfo("UserID")
        Dim UserInfoRows As DataRow() = OtralaDBDataSet.UserInfo.Select(String.Format("UserID = '{0}'", UserID))
        Dim UserInfoRow As DataRow

        If UserInfoRows.Count = 0 Then
            With User
                .UserID = UserID
                .Email = FindInfo("Email")
                .PhoneNumber = FindInfo("PhoneNumber")
                .LoggedIn = True
            End With
        Else
            UserInfoRow = UserInfoRows(0)

            With User
                .UserID = UserID
                .Name = UserInfoRow("RealName")
                .Age = UserInfoRow("Age")
                .IsSeller = UserInfoRow("Seller")
                .Address = UserInfoRow("Address")
                .Email = UserInfoRow("Email")
                .PhoneNumber = UserInfoRow("Phone")

                .ICNum = UserInfoRow("ICnum")
                .Gender = UserInfoRow("Gender")
                .Birthday = UserInfoRow("Birthday")
                .nationality = UserInfoRow("Nationality")
                .IsAdmin = UserInfoRow("Admin")
                .LoggedIn = True

                If Not IsDBNull(UserInfoRow("Picture")) Then
                    .Picture = OtralAPI.ImageFromData(UserInfoRow("Picture"))
                End If

                If Not IsDBNull(UserInfoRow("Wishlist")) Then
                    .Wishlist = StrToLstInt(UserInfoRow("Wishlist"))
                End If
            End With
        End If
    End Sub

    Private Sub LoginShowHidePass() Handles PbLoginHidePass.Click
        If LoginPassHiden Then
            PbLoginHidePass.Image = Global.Otrala_2._0.My.Resources.Resources.Openeye
            TbLoginPass.PasswordChar = ""
        ElseIf Not LoginPassHiden Then
            PbLoginHidePass.Image = Global.Otrala_2._0.My.Resources.Resources.ClosedEye
            TbLoginPass.PasswordChar = "*"
        End If
        LoginPassHiden = Not LoginPassHiden
    End Sub

    '-------------------------------------------------------------------------------------- All below this is Sign up Functions
    Dim SUPassHiden As Boolean = True
    Private Sub CreateAcc() Handles BtnSUSignUp.Click
        'Makes sure all fields are not empty and in the correct format
        If OtralAPI.IsEmailOrPhone(TbSUEmail.Text) <> "Email" Or OtralAPI.IsEmailOrPhone(TbSUPhoneNum.Text) <> "Phone" Then
            MsgBox("Please enter valid information", MsgBoxStyle.Critical, "Wrong Info")
            Exit Sub
        End If

        If TbSUPass.Text <> TbSUConfirmPass.Text Then
            MsgBox("Please enter valid information", MsgBoxStyle.Critical, "Wrong Info")
            Exit Sub
        End If
        'Check and reject duplicate info
        If OtralaDBDataSet.LoginInfo.Select(String.Format("Email = '{0}'", TbSUEmail.Text)).Count > 0 Then
            MsgBox("That email address already exists", MsgBoxStyle.Critical, "Wrong Info")
            Exit Sub
        End If

        If OtralaDBDataSet.LoginInfo.Select(String.Format("PhoneNumber = '{0}'", TbSUPhoneNum.Text)).Count > 0 Then
            MsgBox("That phone number already exists", MsgBoxStyle.Critical, "Wrong Info")
            Exit Sub
        End If

        'Add info to Datatable
        Dim Temp = Encrypt(TbSUPass.Text)
        Dim EncryptedPass As String = LstIntToStr(Temp.Item1)
        Dim NewKey As String = LstIntToStr(Temp.Item2)

        Dim NewLoginInfo As DataRow = OtralaDBDataSet.LoginInfo.NewLoginInfoRow
        NewLoginInfo("Email") = TbSUEmail.Text
        NewLoginInfo("PhoneNumber") = TbSUPhoneNum.Text
        NewLoginInfo("Key") = NewKey
        NewLoginInfo("Password") = EncryptedPass
        NewLoginInfo("UserID") = (OtralaDBDataSet.LoginInfo.Rows(OtralaDBDataSet.LoginInfo.Rows.Count - 1)("UserID") + 1)

        OtralaDBDataSet.LoginInfo.AddLoginInfoRow(NewLoginInfo)

        LoginInfoTableAdapter.Update(OtralaDBDataSet.LoginInfo)

        With User
            Dim MyLoginInfo As DataRow = OtralaDBDataSet.LoginInfo.Select(String.Format("Email = '{0}'", TbSUEmail.Text))(0)
            .UserID = MyLoginInfo("UserID")
            .Email = MyLoginInfo("Email")
            .PhoneNumber = MyLoginInfo("PhoneNumber")
            .LoggedIn = True
        End With

        Me.Close()
    End Sub

    Private Sub SUShowHidePass() Handles PbSUHidePass.Click
        If SUPassHiden Then
            PbSUHidePass.Image = Global.Otrala_2._0.My.Resources.Resources.Openeye
            TbSUPass.PasswordChar = ""
            TbSUConfirmPass.PasswordChar = ""
        ElseIf Not SUPassHiden Then
            PbSUHidePass.Image = Global.Otrala_2._0.My.Resources.Resources.ClosedEye
            TbSUPass.PasswordChar = "*"
            TbSUConfirmPass.PasswordChar = "*"
        End If
        SUPassHiden = Not SUPassHiden
    End Sub

End Class
