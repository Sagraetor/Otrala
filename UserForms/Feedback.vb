Public Class Feedback

    Private Sub RemoveDefaultText(Sender As TextBox, e As EventArgs) Handles TbDescription.GotFocus, TbTitle.GotFocus
        If Sender.Name = "TbDescription" And TbDescription.Text = "Description" Then
            TbDescription.Clear()
            TbDescription.ForeColor = System.Drawing.SystemColors.WindowText
        ElseIf Sender.Name = "TbTitle" And TbTitle.Text = "Title" Then
            TbTitle.Clear()
            TbTitle.ForeColor = System.Drawing.SystemColors.WindowText
        End If
    End Sub

    Private Sub ToDefaultText(Sender As TextBox, e As EventArgs) Handles TbDescription.LostFocus, TbTitle.LostFocus
        TbDescription.Text = TbDescription.Text.TrimEnd(CChar(" "))
        TbTitle.Text = TbTitle.Text.TrimEnd(CChar(" "))

        If Sender.Name = "TbDescription" And TbDescription.Text = "" Then
            TbDescription.Text = "Description"
            TbDescription.ForeColor = System.Drawing.SystemColors.GrayText
        ElseIf Sender.Name = "TbTitle" And TbTitle.Text = "" Then
            TbTitle.Text = "Title"
            TbTitle.ForeColor = System.Drawing.SystemColors.GrayText
        End If
    End Sub
    Private Sub Submit() Handles BtnSubmit.Click
        If CBType.Text = "" OrElse TbTitle.Text = "" Then
            MsgBox("Error")
            Exit Sub
        End If

        Dim NewFeedback As DataRow = OtralaDBDataSet.Feedback.NewFeedbackRow

        NewFeedback("Title") = TbTitle.Text
        NewFeedback("Description") = TbDescription.Text
        NewFeedback("UserID") = User.UserID
        NewFeedback("Type") = CBType.Text

        OtralaDBDataSet.Feedback.AddFeedbackRow(NewFeedback)

        FeedbackTableAdapter1.Update(Me.OtralaDBDataSet)
    End Sub

    Private Sub Feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OtralaDBDataSet.LoginInfo' table. You can move, or remove it, as needed.
        Me.FeedbackTableAdapter1.Fill(Me.OtralaDBDataSet.Feedback)
    End Sub

    Private Sub CloseAll(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

End Class
