Public Class BaseForm
    Overridable Sub AddFormLoad()

    End Sub

    Protected Sub FormLoad() Handles Me.Load
        AddFormLoad()
        If User.LoggedIn Then
            LblName.Text = User.Name
        Else
            LblName.Text = "Log In / Sign Up"
        End If
    End Sub
    Protected Sub ToCatalogue() Handles PbOtralaIcon.Click
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
        If Me.Name = "UserSettings" Then
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
                Me.Hide()
            End If

            FormLoad()
        End If
    End Sub

    Protected Sub ToFeedback() Handles BtnFeedback.Click
        If Me.Name <> "Feedback" Then
            Feedback.Show()
            Feedback.FormLoad()
            Me.Hide()
        End If
    End Sub

    Protected Sub SearchBox_Click(sender As Object, e As EventArgs) Handles SearchBox.Click
        If Me.Name <> "Search" Then
            Dim s As New Search
            s.Name = "Search"
            s.SearchBox.Text = SearchBox.Text
            s.Show()
            s.FormLoad()
            Me.Hide()
        End If
    End Sub

    ' log out 
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim reply As MsgBoxResult = MsgBox("Thank you for using Otrala" + Environment.NewLine +
                                           "See you when we 'Travel Lagi'", MsgBoxStyle.OkCancel, "Exit")
        If reply = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        temporaryInputFormPackage.ShowDialog()
    End Sub

    Private Sub AddFeedbackToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem1.Click
        temporaryInputFormFeedback.ShowDialog()
    End Sub

    Private Sub AddLoginInfoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddLoginInfoToolStripMenuItem1.Click
        temporaryInputFormLoginInfo.ShowDialog()
    End Sub

    Private Sub AddUserInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserInfoToolStripMenuItem.Click
        temporaryInputFormUserInfo.ShowDialog()
    End Sub

    Private Sub AddRequestToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddRequestToolStripMenuItem1.Click
        temporaryInputFormRequest.ShowDialog()
    End Sub

    Private Sub ToCatalogue(sender As Object, e As EventArgs) Handles PbOtralaIcon.Click

    End Sub

End Class
