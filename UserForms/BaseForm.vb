Public Class BaseForm

    Private Sub FormLoad() Handles Me.Load
        If User.Name <> "" Then
            PersonalizeGUI()
        End If
    End Sub
    Private Sub ToCatalogue() Handles PbOtralaIcon.Click
        If Me.Name = "Catalogue" Then
            AboutUs.Show()
            Me.Hide()
        Else
            Catalogue.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub ToUserSettings() Handles LblName.Click
        Dim LoginSignUnForm As New LoginSignUp
        LoginSignUnForm.ShowDialog()
        If User.Name <> "" Then
            PersonalizeGUI()
        End If



        'If Me.Name <> "UserSettings" Then
        'UserSettings.Show()
        'Me.Hide()
        'End If
    End Sub

    Private Sub PersonalizeGUI()
        LblName.Text = User.Name
    End Sub

    Private Sub ToFeedback() Handles BtnFeedback.Click
        If Me.Name <> "Feedback" Then
            Feedback.Show()
            Me.Hide()
        End If
    End Sub
    ' log out 
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim reply As MsgBoxResult = MsgBox("Thank you for using Otrala" + Environment.NewLine +
                                           "See you when we 'Travel Lagi'", MsgBoxStyle.OkCancel, "Exit")
        If reply = MsgBoxResult.Ok Then
            Me.Close()
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

End Class
