﻿Public Class BaseForm
    Overridable Sub AddFormLoad()

    End Sub
    Private Sub FormLoad() Handles Me.Load
        AddFormLoad()
        If User.LoggedIn Then
            LblName.Text = User.Name
        End If
    End Sub
    Private Sub ToCatalogue() Handles PbOtralaIcon.Click
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

    Private Sub ToUserSettings() Handles LblName.Click
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

    Private Sub ToFeedback() Handles BtnFeedback.Click
        If Me.Name <> "Feedback" Then
            Feedback.Show()
            Feedback.FormLoad()
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

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs)
        temporaryInputFormPackage.ShowDialog()
    End Sub

    Private Sub AddFeedbackToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        temporaryInputFormFeedback.ShowDialog()
    End Sub

    Private Sub AddLoginInfoToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        temporaryInputFormLoginInfo.ShowDialog()
    End Sub

    Private Sub AddUserInfoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        temporaryInputFormUserInfo.ShowDialog()
    End Sub

    Private Sub AddRequestToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        temporaryInputFormRequest.ShowDialog()
    End Sub
End Class
