Public Class temporaryInputFormRequest
    Private Sub RequestBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RequestBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RequestBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OtralaDBDataSet)

    End Sub

    Private Sub temporaryInputFormRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OtralaDBDataSet.Request' table. You can move, or remove it, as needed.
        Me.RequestTableAdapter.Fill(Me.OtralaDBDataSet.Request)

    End Sub
End Class