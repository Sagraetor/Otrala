Public Class UserSettings
    Dim Editing As Boolean = False
    Dim PassPendingChange As Boolean = False
    Dim NewPass As String

    Public Overrides Sub AddFormLoad()
        LoadUserInfo()
    End Sub

    Public Sub ForceEdit()
        If Editing = False Then
            EditMode()
        End If
    End Sub

    Private Sub DeleteAcc() Handles BtnDelete.Click
        If ConfirmPass(OtralaDBDataSet.LoginInfo, "You are about to delete your account. Please re-enter password." & vbNewLine & "This process cannot be reverted") Then
            Dim ToRemoveUser As DataRow
            Dim ToRemoveRows() As DataRow = OtralaDBDataSet.UserInfo.Select("UserID = " & User.UserID)
            Dim IndexUser, IndexLogin As Integer


            If ToRemoveRows.Count <> 0 Then
                ToRemoveUser = ToRemoveRows(0)
                IndexUser = OtralaDBDataSet.UserInfo.Rows.IndexOf(ToRemoveUser)
            End If

            Dim ToRemoveLogin As DataRow = OtralaDBDataSet.LoginInfo.Select("UserID = " & User.UserID)(0)
            IndexLogin = OtralaDBDataSet.LoginInfo.Rows.IndexOf(ToRemoveLogin)


            OtralaDBDataSet.UserInfo.Rows(IndexUser).Delete()
            OtralaDBDataSet.LoginInfo.Rows(IndexLogin).Delete()

            LoginInfoTableAdapter.Update(OtralaDBDataSet)
            UserInfoTableAdapter.Update(OtralaDBDataSet)

            User = New UserInfo With {
                .LoggedIn = False
            }

            LoadUserInfo()
        Else
                MsgBox("Aborted")
        End If
    End Sub
    Private Sub ForceLowerCase() Handles LblProfileEmail.TextChanged
        LblProfileEmail.Text = LCase(LblProfileEmail.Text)
    End Sub
    Private Sub EditMode() Handles BtnEdit.Click
        If Not Editing Then
            Editing = True
            BtnEdit.Text = "Double click fields to edit, Click me to save changes"
        Else
            Editing = False
            BtnEdit.Text = "Edit Profile"

            If MsgBox("Are you sure you want to save these changes?", MsgBoxStyle.YesNo, "Otrala") = MsgBoxResult.Yes Then
                Dim UserInfoDataRow As DataRow() = OtralaDBDataSet.UserInfo.Select("UserID = " & User.UserID)
                Dim MyProfile As DataRow

                If UserInfoDataRow.Count = 0 Then
                    MyProfile = OtralaDBDataSet.UserInfo.NewUserInfoRow

                    MyProfile("Picture") = DataFromImage(PbProfile.Image)
                    MyProfile("RealName") = LblProfileName.Text
                    MyProfile("Address") = LblProfileAddress.Text
                    MyProfile("Age") = LblProfileAge.Text
                    MyProfile("Gender") = LblProfileGender.Text
                    MyProfile("Nationality") = LblProfileCountry.Text
                    MyProfile("Email") = LblProfileEmail.Text
                    MyProfile("Phone") = LblProfilePhoneNumber.Text
                    MyProfile("ICnum") = LblProfileIcNum.Text
                    MyProfile("UserID") = User.UserID
                    MyProfile("Birthday") = Convert.ToDateTime(LblProfileBirthday.Text).ToString("d")

                    OtralaDBDataSet.UserInfo.Rows.InsertAt(MyProfile, (User.UserID))

                    With User
                        .Name = LblProfileName.Text
                        .Age = LblProfileAge.Text
                        .IsSeller = False
                        .Address = LblProfileAddress.Text
                        .Picture = PbProfile.Image
                        .ICNum = LblProfileIcNum.Text
                        .Gender = LblProfileGender.Text
                        .Birthday = Convert.ToDateTime(LblProfileBirthday.Text).ToString("d")
                        .nationality = LblProfileCountry.Text
                        .IsAdmin = False
                    End With

                Else
                    MyProfile = UserInfoDataRow(0)
                    Dim ProfileIndex As Short = OtralaDBDataSet.UserInfo.Rows.IndexOf(MyProfile)

                    OtralaDBDataSet.UserInfo.Rows(ProfileIndex)("Picture") = DataFromImage(PbProfile.Image)
                    OtralaDBDataSet.UserInfo.Rows(ProfileIndex)("RealName") = LblProfileName.Text
                    OtralaDBDataSet.UserInfo.Rows(ProfileIndex)("Address") = LblProfileAddress.Text
                    OtralaDBDataSet.UserInfo.Rows(ProfileIndex)("Age") = LblProfileAge.Text
                    OtralaDBDataSet.UserInfo.Rows(ProfileIndex)("Gender") = LblProfileGender.Text
                    OtralaDBDataSet.UserInfo.Rows(ProfileIndex)("Nationality") = LblProfileCountry.Text
                    OtralaDBDataSet.UserInfo.Rows(ProfileIndex)("Email") = LblProfileEmail.Text
                    OtralaDBDataSet.UserInfo.Rows(ProfileIndex)("Phone") = LblProfilePhoneNumber.Text
                    OtralaDBDataSet.UserInfo.Rows(ProfileIndex)("ICnum") = LblProfileIcNum.Text
                    OtralaDBDataSet.UserInfo.Rows(ProfileIndex)("Birthday") = Convert.ToDateTime(LblProfileBirthday.Text).ToString("d")

                    With User
                        .Name = LblProfileName.Text
                        .Age = LblProfileAge.Text
                        .Address = LblProfileAddress.Text
                        .Picture = PbProfile.Image
                        .ICNum = LblProfileIcNum.Text
                        .Gender = LblProfileGender.Text
                        .Birthday = Convert.ToDateTime(LblProfileBirthday.Text).ToString("d")
                        .nationality = LblProfileCountry.Text
                    End With

                End If



                Dim MyLogin As DataRow = OtralaDBDataSet.LoginInfo.Select("UserID = " & User.UserID)(0)
                Dim LoginIndex As Short = OtralaDBDataSet.LoginInfo.Rows.IndexOf(MyLogin)



                If PassPendingChange Then
                    Dim Temp = Encrypt(NewPass)
                    Dim EncryptedPass As String = LstIntToStr(Temp.Item1)
                    Dim NewKey As String = LstIntToStr(Temp.Item2)

                    OtralaDBDataSet.LoginInfo(LoginIndex)("Key") = NewKey
                    OtralaDBDataSet.LoginInfo(LoginIndex)("Password") = EncryptedPass
                End If

                OtralaDBDataSet.LoginInfo(LoginIndex)("Email") = LblProfileEmail.Text
                OtralaDBDataSet.LoginInfo(LoginIndex)("PhoneNumber") = LblProfilePhoneNumber.Text

                UserInfoTableAdapter.Update(OtralaDBDataSet)
                LoginInfoTableAdapter.Update(OtralaDBDataSet)
            End If
            OneTimeLoad()
            LoadUserInfo()
        End If

    End Sub
    Private Sub LoadUserInfo()
        PbProfile.Image = User.Picture
        LblProfileName.Text = User.Name
        LblProfileAddress.Text = User.Address
        LblProfileAge.Text = User.Age
        LblProfileGender.Text = User.Gender
        LblProfileCountry.Text = User.nationality
        LblProfileEmail.Text = User.Email
        LblProfilePhoneNumber.Text = User.PhoneNumber
        LblProfileIcNum.Text = User.ICNum
        LblProfileBirthday.Text = Convert.ToDateTime(User.Birthday).ToString("D")
        LblProfilePassword.Text = "********"

        If User.LoggedIn Then
            LblName.Text = User.Name
        End If
    End Sub

    Private Sub EditPic() Handles PbProfile.DoubleClick
        If Not Editing Then
            Exit Sub
        End If
        Dim OpenPhoto As New OpenFileDialog

        OpenPhoto.Filter = ("Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png")

        OpenPhoto.ShowDialog()

        If OpenPhoto.FileNames.Count = 1 Then
            PbProfile.Image = Image.FromFile(OpenPhoto.FileName)
        End If
    End Sub
    Private Sub EditValue(sender, e) Handles LblProfileName.DoubleClick, LblProfileAge.DoubleClick, LblProfileGender.DoubleClick, LblProfileEmail.DoubleClick, LblProfilePhoneNumber.DoubleClick, LblProfileBirthday.DoubleClick, LblProfileCountry.DoubleClick, LblProfilePassword.DoubleClick, LblProfileIcNum.DoubleClick, LblProfileAddress.DoubleClick
        If Not Editing Then
            Exit Sub
        End If

        If sender.Name = "LblProfileEmail" OrElse sender.Name = "LblProfilePhoneNumber" OrElse sender.name = "LblProfilePassword" OrElse sender.Name = "LblProfileIcNum" Then
            Dim CheckPass As Boolean = ConfirmPass(OtralaDBDataSet.LoginInfo)

            If Not CheckPass Then
                MsgBox("Incorrect Password")
                Exit Sub
            End If
        End If

        Dim EditProfileForm As New Prompt
        EditProfileForm.Initialize(sender)
        EditProfileForm.ShowDialog()

        Dim Result As String = EditProfileForm.Result

        If sender.Name = "LblProfileEmail" And IsEmailOrPhone(Result) <> "Email" Then
            MsgBox("Please enter a valid Email")
            Exit Sub
        End If

        If (sender.Name = "LblProfilePhoneNumber" OrElse sender.Name = "LblProfileAge" OrElse sender.Name = "LblProfileIcNum") And IsEmailOrPhone(Result) <> "Phone" Then
            MsgBox("Please enter a valid Value")
            Exit Sub
        End If

        If sender.name = "LblProfilePassword" Then
            PassPendingChange = True
            NewPass = Result
        Else
            sender.Text = Result
        End If
    End Sub



    ' log out 
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs)
        Dim reply As MsgBoxResult = MsgBox("Thank you For Using Otrala" + Environment.NewLine +
                                           "See you When we 'Travel Lagi'", MsgBoxStyle.OkCancel, "Exit")
        If reply = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub
    Private Sub CloseAll(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub

    Public Sub OneTimeLoad() Handles MyBase.Load
        'TODO: This line of code loads data into the 'OtralaDBDataSet.LoginInfo' table. You can move, or remove it, as needed.
        Me.LoginInfoTableAdapter.Fill(Me.OtralaDBDataSet.LoginInfo)
        Me.PackageTableAdapter.Fill(Me.OtralaDBDataSet.Package)
        Me.UserInfoTableAdapter.Fill(Me.OtralaDBDataSet.UserInfo)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox(User.UserID)
    End Sub
End Class
