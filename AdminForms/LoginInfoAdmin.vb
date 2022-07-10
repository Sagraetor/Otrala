Public Class LoginInfoAdmin

    Private Sub temporaryInputFormLoginInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OtralaDBDataSet.LoginInfo' table. You can move, or remove it, as needed.
        Me.LoginInfoTableAdapter.Fill(Me.OtralaDBDataSet.LoginInfo)
    End Sub

    Private Sub LoginInfoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles LoginInfoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LoginInfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OtralaDBDataSet)

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Me.Validate()
        Me.LoginInfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OtralaDBDataSet)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            Me.LoginInfoBindingSource.RemoveCurrent()
        End If
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        If MsgBox("Are you sure?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            Me.LoginInfoBindingSource.AddNew()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim strFind As String
        Dim find_record As EnumerableRowCollection(Of OtralaDBDataSet.LoginInfoRow)
        strFind = txtFind.Text.ToUpper

        find_record = From LoginInfo In OtralaDBDataSet.LoginInfo
                      Where LoginInfo.UserID Like "*" & strFind & "*"
                      Select LoginInfo

        LoginInfoBindingSource.DataSource = find_record.AsDataView
    End Sub

End Class