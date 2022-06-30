Public Class Form1
    Private Sub PackageBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PackageBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PackageBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OtralaDBDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OtralaDBDataSet.Package' table. You can move, or remove it, as needed.
        Me.PackageTableAdapter.Fill(Me.OtralaDBDataSet.Package)
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnAddPic.Click
        Dim openphoto As New OpenFileDialog

        openphoto.Filter = ("Picture File|*.jpg; *.gif;.png;.bmp;.jpeg")
        openphoto.ShowDialog()
        picPackage.ImageLocation = openphoto.FileName
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Close()
    End Sub
End Class