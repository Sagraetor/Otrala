Public Class FeedbackReview

    Private Sub FeedbackReview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OtralaDBDataSet.UserInfo' table. You can move, or remove it, as needed.
        Me.UserInfoTableAdapter.Fill(Me.OtralaDBDataSet.UserInfo)
        Me.FeedbackTableAdapter.Fill(Me.OtralaDBDataSet.Feedback)
    End Sub

    Private Sub changing_position(sender As Object, e As EventArgs) Handles FeedbackBindingSource.CurrentChanged, lblTitle.TextChanged, Me.Load

        If lblTitle.Text = "" Then
            lblSentBy.Text = "No Feedback Found"
            Exit Sub
        End If

        Dim found As Boolean = False
        Dim Feedback As DataTable = OtralaDBDataSet.Feedback.Copy()
        Dim UserInfo As DataTable = OtralaDBDataSet.UserInfo.Copy()
        Dim info_user_id() As String = {}
        Dim info_user_name() As String = {}
        Dim username_found As String = Nothing
        Dim date_found As String = Nothing

        For Each Row In UserInfo.Rows
            ReDim Preserve info_user_id(info_user_id.Length)
            ReDim Preserve info_user_name(info_user_name.Length)
            info_user_id(info_user_id.Length - 1) = Row("UserID")
            info_user_name(info_user_name.Length - 1) = Row("RealName")
        Next

        For i = 0 To info_user_id.Length - 1
            If found Then
                Exit For
            End If
            For Each row In Feedback.Rows
                If found Then
                    Exit For
                End If
                If CType(FeedbackBindingSource.Current("UserID"), String) = info_user_id(i) Then
                    username_found = info_user_name(i)
                    date_found = row("DateSent")
                    found = True
                End If
            Next
        Next

        lblSentBy.Text = "Sent By " + username_found + " on " + date_found

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim type_selected As Boolean
        Dim strFind As String
        Dim strType As String
        Dim find_record As EnumerableRowCollection(Of OtralaDBDataSet.FeedbackRow)
        strFind = txtFind.Text.ToUpper
        strType = CBType.Text.ToUpper

        If strType <> "" Then
            type_selected = True
        End If

        If Not type_selected Then
            find_record = From Feedback In OtralaDBDataSet.Feedback
                          Where Feedback.Description.ToUpper Like "*" & strFind & "*" Or Feedback.Title.ToUpper Like "*" & strFind & "*" Or Feedback.FeedbackID = Val(strFind)
                          Select Feedback
        ElseIf type_selected Then
            find_record = From Feedback In OtralaDBDataSet.Feedback
                          Where (Feedback.Description.ToUpper Like "*" & strFind & "*" Or Feedback.Title.ToUpper Like "*" & strFind & "*" Or Feedback.FeedbackID = Val(strFind)) And Feedback.Type.ToUpper = strType
                          Select Feedback
        End If
        FeedbackBindingSource.DataSource = find_record.AsDataView
    End Sub
End Class