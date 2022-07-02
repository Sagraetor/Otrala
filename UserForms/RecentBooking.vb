Public Class RecentBooking
    Public package As Package

    Private Sub LoadPackage() Handles Me.Load
        GbxBooking.Text = package.PackageName
        LblPrice.Text = package.Price.ToString("c")
        LblDescription.Text = package.Description
        PicPackage.Image = package.Picture
        LblPax.Text = package.Pax
        LblUserName.Text = User.Name
        LblUserPhone.Text = User.PhoneNumber

        StartDateChanged()

    End Sub

    Private Sub StartDateChanged() Handles DTPickerStart.ValueChanged
        Dim StartDate As DateTime = DTPickerStart.Value
        Dim EndDate As DateTime = StartDate.AddDays(Val(package.Duration))
        LblEndDate.Text = EndDate.ToString("D")
        LblDateDuration.Text = String.Format("{0} - {1}", StartDate.ToString("d"), EndDate.ToString("d"))
    End Sub

    Private Sub Cancel() Handles btnCancel.Click
        If MsgBox("You are about to cancel the transaction, are you sure?", MsgBoxStyle.YesNo, "Otrala") = MsgBoxResult.Yes Then
            Catalogue.Show()
            Me.Close()
        End If
    End Sub
End Class
