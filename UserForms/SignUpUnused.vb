Public Class SignUpUnused
    Dim TriggerForm As BaseForm

    Public Property Trigger()
        Get
            Return TriggerForm
        End Get
        Set(ByVal Value)
            TriggerForm = Value
        End Set
    End Property

    Private Sub CreateAcc() Handles BtnSignUp.Click
        If OtralAPI.IsEmailOrPhone(TbEmail.Text) <> "Email" Or OtralAPI.IsEmailOrPhone(TbPhoneNum.Text) <> "Phone" Then
            MsgBox("Please enter valid information", MsgBoxStyle.Critical, "Wrong Info")
            Exit Sub
        End If

        If TbPass.Text <> TbConfirmPass.Text Then
            MsgBox("Please enter valid information", MsgBoxStyle.Critical, "Wrong Info")
            Exit Sub
        End If

        Dim Temp = Encrypt(TbPass.Text)
        Dim EncryptedPass As String = LstIntToStr(Temp.Item1)
        Dim NewKey As String = LstIntToStr(Temp.Item2)

        Dim NewLoginInfo As DataRow = OtralaDBDataSet.LoginInfo.NewLoginInfoRow
        NewLoginInfo("Email") = TbEmail.Text
        NewLoginInfo("PhoneNumber") = TbPhoneNum.Text
        NewLoginInfo("Key") = NewKey
        NewLoginInfo("Password") = EncryptedPass

        OtralaDBDataSet.LoginInfo.AddLoginInfoRow(NewLoginInfo)

        LoginInfoTableAdapter.Update(OtralaDBDataSet)

    End Sub

    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'OtralaDBDataSet.LoginInfo' table. You can move, or remove it, as needed.
        Me.LoginInfoTableAdapter.Fill(Me.OtralaDBDataSet.LoginInfo)

    End Sub
End Class