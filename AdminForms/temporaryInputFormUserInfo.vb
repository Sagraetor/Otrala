Public Class temporaryInputFormUserInfo
    Private Sub UserInfoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UserInfoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UserInfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OtralaDBDataSet)

    End Sub

    Private Sub temporaryInputFormUserInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OtralaDBDataSet.UserInfo' table. You can move, or remove it, as needed.
        Me.UserInfoTableAdapter.Fill(Me.OtralaDBDataSet.UserInfo)

    End Sub
End Class