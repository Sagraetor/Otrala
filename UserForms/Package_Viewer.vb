Public Class Package_Viewer

    Public Package As New Package

    Private Sub isExistingValue(label As Object, labelValue As Object)
        ' This function clears all detail labels without values.
        If labelValue.Text = "" Then
            label.Visible = False
            labelValue.Visible = False
        End If
    End Sub

    Private Sub Package_Viewer_Load() Handles Me.Load

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
    End Sub

    Private Sub After_Load_Tick(sender As Object, e As EventArgs) Handles after_load.Tick
        Me.AutoScrollPosition = New Point(0, 0) 'Scroll to top
        after_load.Enabled = False
    End Sub

    Private Sub btnWishlist_Click(sender As Object, e As EventArgs) Handles btnWishlist.Click

        ' Add Code here to check if item is already wishlisted from database.
        ' If (already wishlisted) Then disable this button

        If btnWishlist.Text <> "In Wishlist" Then
            btnWishlist.Text = "In Wishlist"
            btnWishlist.Enabled = False
        End If

        ' Add code to move item to wishlist in database.

    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        Dim BookingForm As New RecentBooking
        BookingForm.package = Package
        BookingForm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnSeller_Click(sender As Object, e As EventArgs) Handles btnSeller.Click
        ' Go to seller profile using seller_id.
    End Sub

End Class