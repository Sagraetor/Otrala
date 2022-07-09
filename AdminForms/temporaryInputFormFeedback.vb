Public Class temporaryInputFormFeedback

    Private Sub temporaryInputFormFeedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OtralaDBDataSet.Feedback' table. You can move, or remove it, as needed.
        Me.FeedbackTableAdapter.Fill(Me.OtralaDBDataSet.Feedback)

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Me.Validate()
        Me.FeedbackBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OtralaDBDataSet)
    End Sub

    Private Sub FeedbackBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FeedbackBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FeedbackBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OtralaDBDataSet)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            Me.FeedbackBindingSource.RemoveCurrent()
        End If
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        If MsgBox("Are you sure?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            Me.FeedbackBindingSource.AddNew()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim strFind As String
        Dim find_record As EnumerableRowCollection(Of OtralaDBDataSet.FeedbackRow)
        strFind = txtFind.Text.ToUpper

        find_record = From Feedback In OtralaDBDataSet.Feedback
                      Where Feedback.FeedbackID Like "*" & strFind & "*"
                      Select Feedback

        FeedbackBindingSource.DataSource = find_record.AsDataView
    End Sub

End Class