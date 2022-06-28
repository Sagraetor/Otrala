Public Class RecentBooking
    Dim package As Package = Catalogue.send_package()

    Private Sub LoadPackage() Handles Me.Load
        GbxBooking.Text = package.Name
        LblPrice.Text = package.Price
        LblDescription.Text = package.Description
        PicPackage.Image = package.Image
        LblPax.Text = package.Pax
    End Sub

    Private Sub StartDateChanged(sender As DateTimePicker, e As EventArgs) Handles DTPickerStart.ValueChanged
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
