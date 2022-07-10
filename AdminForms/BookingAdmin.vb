Public Class BookingAdmin

    Private Sub BookingAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OtralaDBDataSet.Booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me.OtralaDBDataSet.Booking)

    End Sub

    Private Sub BookingBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BookingBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BookingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OtralaDBDataSet)

    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Me.Validate()
        Me.BookingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OtralaDBDataSet)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            Me.BookingBindingSource.RemoveCurrent()
        End If
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        If MsgBox("Are you sure?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            Me.BookingBindingSource.AddNew()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim strFind As String
        Dim find_record As EnumerableRowCollection(Of OtralaDBDataSet.BookingRow)
        strFind = txtFind.Text.ToUpper

        find_record = From Booking In OtralaDBDataSet.Booking
                      Where Booking.BookingID Like "*" & strFind & "*"
                      Select Booking

        BookingBindingSource.DataSource = find_record.AsDataView
    End Sub

End Class