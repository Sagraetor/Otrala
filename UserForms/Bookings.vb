Public Class Bookings
    Public package As Package

    Private Sub LoadPackage() Handles Me.Load
        'TODO: This line of code loads data into the 'OtralaDBDataSet.Booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me.OtralaDBDataSet.Booking)
        GbxBooking.Text = package.PackageName
        LblPrice.Text = package.Price.ToString("c")
        LblDescription.Text = package.Description
        PicPackage.Image = package.Picture
        LblPax.Text = package.Pax
        LblUserName.Text = User.Name
        LblUserPhone.Text = User.PhoneNumber
        LblNumberIC.Text = User.ICNum

        StartDateChanged()

    End Sub

    Private Sub ForceNumber(sender As Object, e As EventArgs) Handles TbQuantity.LostFocus
        If sender.text = "" Then
            Exit Sub
        End If

        If Not IsNumeric(sender.text) Then
            MsgBox("Please enter a proper number")
            sender.text = ""
            Exit Sub
        End If

        LblTotPrice.Text = (Val(TbQuantity.Text) * package.Price).ToString("c")
    End Sub

    Private Sub StartDateChanged() Handles DTPickerStart.ValueChanged
        Dim StartDate As DateTime = DTPickerStart.Value
        Dim EndDate As DateTime = StartDate.AddDays(Val(package.Duration))
        LblEndDate.Text = EndDate.ToString("D")
        LblDateDuration.Text = String.Format("{0} - {1}", StartDate.ToString("d"), EndDate.ToString("d"))
    End Sub

    Private Sub Book() Handles btnConfirm.Click
        If Not mskCardNum.MaskCompleted OrElse Not mskCVV.MaskCompleted OrElse Not mskExpiration.MaskCompleted Then
            MsgBox("Please enter all relevant credit card info", MsgBoxStyle.Critical, "Credit Card error")
            Exit Sub
        End If

        If TbQuantity.Text = "" Then
            MsgBox("Please enter the quantity of package(s) that you want to purchase", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Dim NewBookingRow As DataRow = OtralaDBDataSet.Booking.NewBookingRow

        NewBookingRow("PackageID") = package.PackageID
        NewBookingRow("UserID") = User.UserID
        NewBookingRow("DateBooked") = DateTime.Today.ToString("d")
        NewBookingRow("Quantity") = TbQuantity.Text
        NewBookingRow("CardName") = txtCardName.Text
        NewBookingRow("CardNumber") = mskCardNum.Text
        NewBookingRow("PlannedDate") = DTPickerStart.Value.ToString("d")
        NewBookingRow("ClientFulfilled") = ""
        NewBookingRow("SellerFulfilled") = ""
        NewBookingRow("TotalPrice") = LblTotPrice.Text

        OtralaDBDataSet.Booking.AddBookingRow(NewBookingRow)
        BookingTableAdapter.Update(OtralaDBDataSet)

        MsgBox("Booking sucessful!")

        Me.Close()
    End Sub

    Private Sub Cancel() Handles btnCancel.Click
        If MsgBox("You are about to cancel the transaction, are you sure?", MsgBoxStyle.YesNo, "Otrala") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class
