Public Class temporaryInputFormLoginInfo
    Private Sub LoginInfoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles LoginInfoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LoginInfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OtralaDBDataSet)

    End Sub

    Private Sub temporaryInputFormLoginInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OtralaDBDataSet.LoginInfo' table. You can move, or remove it, as needed.
        Me.LoginInfoTableAdapter.Fill(Me.OtralaDBDataSet.LoginInfo)

    End Sub
End Class