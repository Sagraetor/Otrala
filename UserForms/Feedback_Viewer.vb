Public Class Feedback_Viewer
    Public FeedbackID As String

    Private Sub Feedback_Viewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FeedbackTableAdapter1.Fill(Me.OtralaDBDataSet.Feedback)
        Me.UserInfoTableAdapter1.Fill(Me.OtralaDBDataSet.UserInfo)

        Dim Feedback() As DataRow = OtralaDBDataSet.Feedback.Select("FeedbackID = " & FeedbackID)
        Dim UserInfo() As DataRow = OtralaDBDataSet.UserInfo.Select("UserID = " & Feedback.GetValue(0)(3))

        lblTitle.Text = Feedback.GetValue(0)(1)
        lblType.Text = "Feedback Type : " & Feedback.GetValue(0)(2)
        lblUser.Text = "User : " & UserInfo.GetValue(0)(0)
        lblDescription.Text = Feedback.GetValue(0)(4)
        lblDate.Text = "Date : " & Feedback.GetValue(0)(5)
    End Sub

End Class