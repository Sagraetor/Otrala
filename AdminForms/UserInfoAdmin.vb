Public Class UserInfoAdmin

    Private Sub temporaryInputFormUserInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OtralaDBDataSet.UserInfo' table. You can move, or remove it, as needed.
        Me.UserInfoTableAdapter.Fill(Me.OtralaDBDataSet.UserInfo)
    End Sub

    Private Sub UserInfoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UserInfoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UserInfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OtralaDBDataSet)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Me.Validate()
        Me.UserInfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OtralaDBDataSet)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            Me.UserInfoBindingSource.RemoveCurrent()
        End If
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        If MsgBox("Are you sure?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            Me.UserInfoBindingSource.AddNew()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim strFind As String
        Dim find_record As EnumerableRowCollection(Of OtralaDBDataSet.UserInfoRow)
        strFind = txtFind.Text.ToUpper

        find_record = From UserInfo In OtralaDBDataSet.UserInfo
                      Where UserInfo.UserInfoID Like "*" & strFind & "*"
                      Select UserInfo

        UserInfoBindingSource.DataSource = find_record.AsDataView
    End Sub

End Class