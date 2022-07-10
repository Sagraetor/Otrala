Public Class AboutUs
    ' log out 
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs)
        Dim reply As MsgBoxResult = MsgBox("Thank you for using Otrala" + Environment.NewLine +
                                           "See you when we 'Travel Lagi'", MsgBoxStyle.OkCancel, "Exit")
        If reply = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Catalogue.Show()
        Me.Hide()
    End Sub

    Private Sub CloseAll(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.ToFeedback()
    End Sub
End Class