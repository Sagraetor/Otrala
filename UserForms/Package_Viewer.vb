Public Class Package_Viewer

    Public Package As New Package With {
    .SellerID = Nothing,
    .PackageID = Nothing,
    .PackageName = Nothing,
    .Price = Nothing,
    .Description = Nothing,
    .State = Nothing,
    .Location = Nothing,
    .Pax = Nothing,
    .Duration = Nothing,
    .SellerName = Nothing,
    .Picture = Nothing
    }

    Private Sub isExistingValue(label As Object, labelValue As Object)
        ' This function clears all detail labels without values.
        If labelValue.Text = "" Then
            label.Visible = False
            labelValue.Visible = False
        End If
    End Sub

    Private Sub Package_Viewer_Load() Handles Me.Load
        'TODO: This line of code loads data into the 'OtralaDBDataSet.UserInfo' table. You can move, or remove it, as needed.
        Me.UserInfoTableAdapter.Fill(Me.OtralaDBDataSet.UserInfo)

        ' Change Form Name to Package Name.
        Me.Text = Package.PackageName

        ' Change Image to Package Image.
        pctTravelPic.Image = Package.Picture

        ' Change Seller Button Text.
        btnSeller.Text = "More From" + Environment.NewLine + Package.SellerName

        ' Set Values to Labels in Details Table.
        lblTitle.Text = Package.PackageName
        lblPrice.Text = Package.Price
        lblDescriptionValue.Text = Package.Description
        lblStateValue.Text = Package.State
        lblLocationValue.Text = Package.Location
        lblPaxValue.Text = Package.Pax
        lblDurationValue.Text = Package.Duration


        If User.Wishlist.Contains(Package.PackageID) Then
            btnWishlist.Text = "In Wishlist"
        End If
    End Sub

    Private Sub After_Load_Tick(sender As Object, e As EventArgs) Handles after_load.Tick
        Me.AutoScrollPosition = New Point(0, 0) 'Scroll to top
        after_load.Enabled = False
    End Sub

    Private Sub btnWishlist_Click(sender As Object, e As EventArgs) Handles btnWishlist.Click
        If User.LoggedIn = False Then
            MsgBox("Please log in to wishlist")
            Exit Sub
        End If

        If User.Wishlist.Contains(Package.PackageID) Then
            btnWishlist.Text = "Add to Wishlist"
            User.Wishlist.Remove(Package.PackageID)
        Else
            btnWishlist.Text = "In Wishlist"
            User.Wishlist.Add(Package.PackageID)
        End If

        Dim StrWishlist As String = LstIntToStr(User.Wishlist)
        Dim MyUserInfo As DataRow = OtralaDBDataSet.UserInfo.Select("UserID = " & User.UserID)(0)
        Dim MyIndex As Integer = OtralaDBDataSet.UserInfo.Rows.IndexOf(MyUserInfo)
        OtralaDBDataSet.UserInfo.Rows(MyIndex)("Wishlist") = StrWishlist

        UserInfoTableAdapter.Update(OtralaDBDataSet)
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        Dim BookingForm As New Bookings
        BookingForm.package = Package
        BookingForm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnSeller_Click(sender As Object, e As EventArgs) Handles btnSeller.Click
        ' Go to seller profile using seller_id.
    End Sub

End Class