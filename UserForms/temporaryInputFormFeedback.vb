Public Class temporaryInputFormFeedback
    Private Sub FeedbackBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FeedbackBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FeedbackBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OtralaDBDataSet)

    End Sub

    Private Sub temporaryInputFormFeedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OtralaDBDataSet.Feedback' table. You can move, or remove it, as needed.
        Me.FeedbackTableAdapter.Fill(Me.OtralaDBDataSet.Feedback)

    End Sub

End Class