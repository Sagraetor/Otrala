Public Class Package_Viewer

    Dim package = Catalogue.send_package()
    Dim seller_id = Catalogue.sellerID(package.Index)
    Dim package_id = Catalogue.packageID(package.Index)
    Dim packageName = Catalogue.packageName(package.Index)
    Dim packageState = Catalogue.packageState(package.Index)
    Dim packageDestination = Catalogue.packageDestination(package.Index)
    Dim packagePrice = Catalogue.packagePrice(package.Index)
    Dim packagePax = Catalogue.packagePax(package.Index)
    Dim packageDescription = Catalogue.packageDescription(package.Index)
    Dim packagePicture = Catalogue.packagePicture(package.Index)
    Dim packageDuration = Catalogue.packageDuration(package.Index)
    ' Dim customer_id = customer.CustomerID (add later).

    Private Sub isExistingValue(label As Object, labelValue As Object)
        ' This function clears all detail labels without values.
        If labelValue.Text = "" Then
            label.Visible = False
            labelValue.Visible = False
        End If
    End Sub

    Private Sub Package_Viewer_Load() Handles Me.Load

        ' Change Form Name to Package Name.
        Me.Text = packageName

        ' Change Image to Package Image.
        pctTravelPic.Image = packagePicture

        ' Change Seller Button Text.
        btnSeller.Text = "More From" + Environment.NewLine + package.SellerName

        ' Set Values to Labels in Details Table.
        lblTitle.Text = packageName
        lblPrice.Text = packagePrice
        lblDescriptionValue.Text = packageDescription
        lblStateValue.Text = packageState
        lblLocationValue.Text = packageDestination
        lblPaxValue.Text = packagePax
        lblDurationValue.Text = packageDuration
        lblTourOperatorValue.Text = package.SellerName

        ' Clear Labels without Values.
        For i = 0 To tableDetails.RowCount - 1
            isExistingValue(tableDetails.GetControlFromPosition(0, i), tableDetails.GetControlFromPosition(1, i))
        Next
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
        ' Go to booking page (send over package_id and seller_id and customer_id).
        Dim BookingForm As New RecentBooking
        BookingForm.Show()
        Me.Close()
    End Sub

    Private Sub btnSeller_Click(sender As Object, e As EventArgs) Handles btnSeller.Click
        ' Go to seller profile using seller_id.
    End Sub
End Class