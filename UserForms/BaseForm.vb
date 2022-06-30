Public Class BaseForm
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



        'If Me.Name <> "UserSettings" Then
        'UserSettings.Show()
        'Me.Hide()
        'End If
    End Sub

    Private Sub PersonalizeGUI() Handles Me.Load
        'User is a structure found in Otralapi and initialized in sub main
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


End Class
