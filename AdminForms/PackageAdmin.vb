Public Class PackageAdmin

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OtralaDBDataSet.Package' table. You can move, or remove it, as needed.
        Me.PackageTableAdapter.Fill(Me.OtralaDBDataSet.Package)
    End Sub

    Private Sub PackageBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PackageBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PackageBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OtralaDBDataSet)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Me.Validate()
        Me.PackageBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OtralaDBDataSet)
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            Me.PackageBindingSource.RemoveCurrent()
        End If
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        If MsgBox("Are you sure?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            Me.PackageBindingSource.AddNew()
        End If
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnAddPic.Click
        Dim openphoto As New OpenFileDialog

        openphoto.Filter = ("Picture File|*.jpg; *.gif;.png;.bmp;.jpeg")
        openphoto.ShowDialog()
        picPackage.ImageLocation = openphoto.FileName
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim strFind As String
        Dim find_record As EnumerableRowCollection(Of OtralaDBDataSet.PackageRow)
        strFind = txtFind.Text.ToUpper

        find_record = From Package In OtralaDBDataSet.Package
                      Where Package.PackageID Like "*" & strFind & "*"
                      Select Package

        PackageBindingSource.DataSource = find_record.AsDataView
    End Sub
End Class