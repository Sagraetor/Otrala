Public Class AddPackage
    Public NewPackage As New Package

    Dim Price As Decimal

    Private Sub SubmitPackage() Handles BtnAdd.Click
        If TbPackageName.Text = "" OrElse TbPrice.Text = "" OrElse TbDesc.Text = "" OrElse CbState.Text = "" OrElse TbLocations.Text = "" OrElse TbPax.Text = "" OrElse TbDuration.Text = "" OrElse PicBox.Image Is Nothing Then
            MsgBox("Please fill in all fields")
            Exit Sub
        End If
        With NewPackage
            .SellerID = User.UserID
            .SellerName = User.Name
            .PackageName = TbPackageName.Text
            .Price = Price
            .Description = TbDesc.Text
            .State = CbState.Text
            .Location = TbLocations.Text
            .Pax = TbPax.Text
            .Duration = TbDuration.Text
            .Picture = PicBox.Image
        End With
        Me.Close()
    End Sub

    Private Sub Cancel() Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub AddPic() Handles PicBox.Click
        Dim OpenPhoto As New OpenFileDialog

        OpenPhoto.Filter = ("Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png")

        OpenPhoto.ShowDialog()

        If OpenPhoto.FileNames.Count = 1 Then
            PicBox.Image = Image.FromFile(OpenPhoto.FileName)
        End If
    End Sub

    Private Sub ForceState() Handles CbState.LostFocus
        If Not CbState.Items.Contains(CbState.Text) Then
            CbState.Text = ""
        End If
    End Sub

    Private Sub ClearOnFocus(sender As Object, e As EventArgs) Handles TbPrice.GotFocus
        sender.Clear()
    End Sub

    Private Sub ForceNumber(sender As Object, e As EventArgs) Handles TbPax.LostFocus, TbPrice.LostFocus, TbDuration.LostFocus
        If sender.text = "" Then
            Exit Sub
        End If

        If Not IsNumeric(sender.text) Then
            MsgBox("Please enter a proper number")
            sender.text = ""
            Exit Sub
        End If

        If sender.Name = "TbPrice" Then
            Price = CDec(TbPrice.Text)
            TbPrice.Text = Price.ToString("c")
        End If
    End Sub

    Private Sub AddPackage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class