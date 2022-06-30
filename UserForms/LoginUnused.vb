Public Class Login
    Dim TriggerForm As BaseForm
    Public Property Trigger()
        Get
            Return TriggerForm
        End Get
        Set(ByVal Value)
            TriggerForm = Value
        End Set
    End Property


    Private Sub LoginToAcc() Handles BtnLogin.Click
        Dim UserInfo As String = TbLoginInfo.Text
        Dim Pword As String = TbPass.Text
        Dim FindInfo As System.Data.DataRow = Nothing

        Select Case OtralAPI.IsEmailOrPhone(UserInfo)
            Case "Email"
                Dim Temp() As DataRow = OtralaDBDataSet.LoginInfo.Select(String.Format("Email = '{0}'", UserInfo))
                If Temp.Length > 0 Then
                    FindInfo = Temp(0)
                Else
                    MsgBox("Incorrect Email/Phone number", MsgBoxStyle.Exclamation, "Wrong Info")
                    Exit Sub
                End If

            Case "Phone"
                Dim Temp() As DataRow = OtralaDBDataSet.LoginInfo.Select(String.Format("PhoneNumber = '{0}'", UserInfo))
                If Temp.Length > 0 Then
                    FindInfo = Temp(0)
                Else
                    MsgBox("Incorrect Email/Phone number", MsgBoxStyle.Exclamation, "Wrong Info")
                    Exit Sub
                End If
            Case "No"
                MsgBox("Please enter a valid Email/Phone number", MsgBoxStyle.Exclamation, "Wrong Info")
                Exit Sub
        End Select

        Dim Key As List(Of Integer) = OtralAPI.StrToLstInt(FindInfo(2))
        Dim CorrectPass As List(Of Integer) = OtralAPI.StrToLstInt(FindInfo(1))
        Dim DecryptedPass As String = OtralAPI.Decrypt(CorrectPass, Key)

        If Pword = DecryptedPass Then
            MsgBox("Correct!")
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OtralaDBDataSet.LoginInfo' table. You can move, or remove it, as needed.
        Me.LoginInfoTableAdapter.Fill(Me.OtralaDBDataSet.LoginInfo)

    End Sub
End Class
