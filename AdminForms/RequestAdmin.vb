Public Class RequestAdmin

    Private Sub temporaryInputFormRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OtralaDBDataSet.Request' table. You can move, or remove it, as needed.
        Me.RequestTableAdapter.Fill(Me.OtralaDBDataSet.Request)
    End Sub

    Private Sub RequestBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RequestBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RequestBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OtralaDBDataSet)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Me.Validate()
        Me.RequestBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OtralaDBDataSet)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            Me.RequestBindingSource.RemoveCurrent()
        End If
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        If MsgBox("Are you sure?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            Me.RequestBindingSource.AddNew()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim strFind As String
        Dim find_record As EnumerableRowCollection(Of OtralaDBDataSet.RequestRow)
        strFind = txtFind.Text.ToUpper

        find_record = From Request In OtralaDBDataSet.Request
                      Where Request.RequestID Like "*" & strFind & "*"
                      Select Request

        RequestBindingSource.DataSource = find_record.AsDataView
    End Sub
End Class