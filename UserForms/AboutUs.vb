﻿Public Class AboutUs
    ' log out 
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs)
        Dim reply As MsgBoxResult = MsgBox("Thank you for using Otrala" + Environment.NewLine +
                                           "See you when we 'Travel Lagi'", MsgBoxStyle.OkCancel, "Exit")
        If reply = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub

    Private Sub AboutUs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Catalogue.Show()
        Me.Hide()
    End Sub
End Class