Public Class SellerApplicationAdmin
    Private Sub SellerApplicationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SellerApplicationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SellerApplicationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OtralaDBDataSet)

    End Sub

    Private Sub SellerApplicationAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OtralaDBDataSet.SellerApplication' table. You can move, or remove it, as needed.
        Me.SellerApplicationTableAdapter.Fill(Me.OtralaDBDataSet.SellerApplication)

    End Sub
End Class