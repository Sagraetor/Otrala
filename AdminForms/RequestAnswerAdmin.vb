Public Class RequestAnswerAdmin

    Private Sub RequestAnswerAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OtralaDBDataSet.RequestAnswer' table. You can move, or remove it, as needed.
        Me.RequestAnswerTableAdapter.Fill(Me.OtralaDBDataSet.RequestAnswer)
    End Sub

    Private Sub RequestAnswerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RequestAnswerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RequestAnswerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OtralaDBDataSet)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Me.Validate()
        Me.RequestAnswerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OtralaDBDataSet)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            Me.RequestAnswerBindingSource.RemoveCurrent()
        End If
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        If MsgBox("Are you sure?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            Me.RequestAnswerBindingSource.AddNew()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim strFind As String
        Dim find_record As EnumerableRowCollection(Of OtralaDBDataSet.RequestAnswerRow)
        strFind = txtFind.Text.ToUpper

        find_record = From RequestAnswer In OtralaDBDataSet.RequestAnswer
                      Where RequestAnswer.RequestAnswerID Like "*" & strFind & "*"
                      Select RequestAnswer

        RequestAnswerBindingSource.DataSource = find_record.AsDataView
    End Sub
End Class