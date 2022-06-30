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
        'TODO: This line of code loads data into the 'OtralaDBDataSet.LoginInfo' table. You can move, or remove it, as needed.
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

        Dim Key As List(Of Integer) = OtralAPI.StrToLstInt(FindInfo(2))
        Dim CorrectPass As List(Of Integer) = OtralAPI.StrToLstInt(FindInfo(1))
        Dim DecryptedPass As String = OtralAPI.Decrypt(CorrectPass, Key)

        If Pword = DecryptedPass Then
            MsgBox("Correct!")
        ElseIf Pword <> DecryptedPass Then
            MsgBox("Incorrect Password")
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

        OtralaDBDataSet.LoginInfo.AddLoginInfoRow(NewLoginInfo)

        LoginInfoTableAdapter.Update(OtralaDBDataSet)

        MsgBox("Sign UP SUCCESS")

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
