Public Class BaseForm
    Overridable Sub AddFormLoad()

    End Sub

    Public Sub FormLoad() Handles Me.Load
        AddFormLoad()
        If User.LoggedIn Then
            LblName.Text = User.Name
        Else
            LblName.Text = "Log In / Sign Up"
        End If
    End Sub
    Protected Sub ToCatalogue() Handles PbOtralaIcon.Click

        If UserSettings.Editing Then
            MsgBox("Please update your profile first")
            Exit Sub
        End If

        If Me.Name = "Catalogue" Then
            AboutUs.Show()
            AboutUs.FormLoad()
            Me.Hide()
        Else
            Catalogue.Show()
            Catalogue.FormLoad()
            Me.Hide()
        End If
    End Sub

    Protected Sub ToUserSettings() Handles LblName.Click
        If Me.Name = "UserSettings" And User.LoggedIn Then
            Exit Sub
        End If

        If User.LoggedIn Then
            UserSettings.Show()
            UserSettings.FormLoad()
            Me.Hide()

        Else
            Dim LoginSignUpForm As New LoginSignUp
            LoginSignUpForm.ShowDialog()

            If User.LoggedIn AndAlso User.Age = 0 Then
                UserSettings.Show()
                UserSettings.FormLoad()
                UserSettings.ForceEdit()
                UserSettings.PbProfile.Image = Otrala_2._0.My.Resources.Resources.NoAvatar
                Me.Hide()
            End If

            FormLoad()
        End If
    End Sub

    Protected Sub ToFeedback() Handles BtnFeedback.Click

        If UserSettings.Editing Then
            MsgBox("Please update your profile first")
            Exit Sub
        End If

        If Me.Name <> "Feedback" And User.LoggedIn Then
            Feedback.Show()
            Feedback.FormLoad()
            Me.Hide()
        ElseIf Me.Name <> "Feedback" Then
            MsgBox("You need to be signed in to submit a feedback")
        End If
    End Sub

    Protected Sub SearchBox_Click(sender As Object, e As EventArgs) Handles SearchBox.Click

        SearchBox.Text = ""

        If UserSettings.Editing Then
            MsgBox("Please update your profile first")
            Exit Sub
        End If

        If Me.Name <> "Search" Then
            Dim s As New Search
            s.SearchBox.Text = SearchBox.Text
            s.Show()
            s.FormLoad()
            Me.Hide()
        End If
    End Sub

    ' log out 
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click

        If UserSettings.Editing Then
            MsgBox("Please update your profile first")
            Exit Sub
        End If

        Dim reply As MsgBoxResult = MsgBox("Thank you for using Otrala" + Environment.NewLine +
                                           "See you when we 'Travel Lagi'", MsgBoxStyle.OkCancel, "Exit")
        If reply = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs)
        PackageAdmin.ShowDialog()
    End Sub

    Private Sub AddFeedbackToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        FeedbackAdmin.ShowDialog()
    End Sub

    Private Sub AddLoginInfoToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        LoginInfoAdmin.ShowDialog()
    End Sub

    Private Sub AddUserInfoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        UserInfoAdmin.ShowDialog()
    End Sub

    Private Sub AddRequestToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        RequestAdmin.ShowDialog()
    End Sub

    Private Sub ToCatalogue(sender As Object, e As EventArgs) Handles PbOtralaIcon.Click

    End Sub

End Class
