Public Class RequestPrompt
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnAccept.Click
        Me.Close()
        Me.DialogResult = DialogResult.Yes
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnReject.Click
        Me.Close()
        Me.DialogResult = DialogResult.No
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
        Me.DialogResult = DialogResult.Abort
    End Sub
End Class