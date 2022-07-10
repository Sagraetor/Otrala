Public Class UserInfoAdmin

    Dim viewing_seller As Boolean

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

        If Not viewing_seller Then
            find_record = From UserInfo In OtralaDBDataSet.UserInfo
                          Where UserInfo.UserInfoID Like "*" & strFind & "*"
                          Select UserInfo
        ElseIf viewing_seller Then
            find_record = From UserInfo In OtralaDBDataSet.UserInfo
                          Where UserInfo.UserInfoID Like "*" & strFind & "*" And UserInfo.Seller = True
                          Select UserInfo
        End If
        UserInfoBindingSource.DataSource = find_record.AsDataView
    End Sub

    Private Sub btnAddPic_Click(sender As Object, e As EventArgs) Handles btnAddPic.Click
        Dim openphoto As New OpenFileDialog

        openphoto.Filter = ("Picture File|*.jpg; *.gif;.png;.bmp;.jpeg")
        openphoto.ShowDialog()
        PicProfile.ImageLocation = openphoto.FileName
    End Sub

    Private Sub btnViewSeller_Click(sender As Object, e As EventArgs) Handles btnViewSeller.Click
        If Not viewing_seller Then
            Dim find_record As EnumerableRowCollection(Of OtralaDBDataSet.UserInfoRow)

            find_record = From UserInfo In OtralaDBDataSet.UserInfo
                          Where UserInfo.Seller = True
                          Select UserInfo

            UserInfoBindingSource.DataSource = find_record.AsDataView
            viewing_seller = True
            txtFind.Clear()
            btnViewSeller.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(2, Byte), Integer))
        ElseIf viewing_seller Then
            Dim find_record As EnumerableRowCollection(Of OtralaDBDataSet.UserInfoRow)

            find_record = From UserInfo In OtralaDBDataSet.UserInfo
                          Select UserInfo

            UserInfoBindingSource.DataSource = find_record.AsDataView
            viewing_seller = False
            txtFind.Clear()
            btnViewSeller.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        End If

    End Sub
End Class