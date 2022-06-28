Public Class Feedback

    Dim level As String

    Private Sub Levels(sender As Object, e As EventArgs) Handles RadioButton5.Click, RadioButton4.Click, RadioButton3.Click, RadioButton2.Click, RadioButton1.Click
        'Satisfaction level 
        If RadioButton1.Checked = True Then
            level = RadioButton1.Text
        ElseIf RadioButton2.Checked = True Then
            level = RadioButton2.Text
        ElseIf RadioButton3.Checked = True Then
            level = RadioButton3.Text
        ElseIf RadioButton4.Checked = True Then
            level = RadioButton4.Text
        ElseIf RadioButton5.Checked = True Then
            level = RadioButton5.Text
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Sumbit
        MsgBox("Your feedback have submitted! Thank You.")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear
        txtfeedback.Clear()
        txtfeedback.Text = "Enter your feedback..."
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Delete
        If txtfeedback.Text.Length > 0 Then
            txtfeedback.Text = txtfeedback.Text.Remove(txtfeedback.Text.Length - 1, 1)
        ElseIf txtfeedback.Text.Length = 0 Then
            txtfeedback.Text = "Enter your feedback..."
        End If
    End Sub


End Class
