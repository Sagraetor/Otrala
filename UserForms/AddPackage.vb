Public Class AddPackage
    Public NewPackage As New Package
    Public TripDate As String

    Dim Price As Decimal

    Public Sub OfferPackage(State As String)
        PicBox.Image = Global.Otrala_2._0.My.Resources.Resources.AddPackagePicUnavailable
        PicBox.Enabled = False

        TbLocations.Text = "Offers don't support locations. Add them to additional notes."
        TbLocations.Enabled = False
        TbLocations.Size = New System.Drawing.Size(185, 61)
        TbLocations.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        TbPackageName.Text = "Offers don't support package names"
        TbPackageName.Enabled = False

        CbState.Text = State
        CbState.Enabled = False

        LblTitleOfDesc.Text = "Additional Notes :"

        Dim NewDtpLbl As New Label
        With NewDtpLbl
            .AutoSize = True
            .Location = New System.Drawing.Point(389, 130)
            .Name = "Label6"
            .Size = New System.Drawing.Size(103, 23)
            .TabIndex = 1
            .Text = "Trip Date: "
        End With

        Dim NewDtp As New DateTimePicker
        With NewDtp
            .CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
            .Location = New System.Drawing.Point(393, 158)
            .Name = "DtpTripDate"
            .Size = New System.Drawing.Size(346, 30)
            .TabIndex = 11
        End With

        Panel1.Controls.Add(NewDtp)
        Panel1.Controls.Add(NewDtpLbl)

        AddHandler NewDtp.CloseUp, AddressOf DtpChange

        BtnAdd.Text = "Make Offer"
    End Sub
    Public Sub EditMode(Package As Package)
        Dim NewBtnDelete As New Button
        With NewBtnDelete
            .BackColor = System.Drawing.Color.White
            .FlatStyle = System.Windows.Forms.FlatStyle.Flat
            .Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            .ForeColor = System.Drawing.SystemColors.ControlText
            .Location = New System.Drawing.Point(289, 424)
            .Name = "BtnDelete"
            .Size = New System.Drawing.Size(153, 33)
            .TabIndex = 10
            .Text = "Delete"
            .UseVisualStyleBackColor = False
        End With

        Panel1.Controls.Add(NewBtnDelete)
        AddHandler NewBtnDelete.Click, AddressOf DeletePackage

        TbPackageName.Text = Package.PackageName
        Price = Package.Price
        TbPrice.Text = Package.Price
        TbDesc.Text = Package.Description
        CbState.Text = Package.State
        TbLocations.Text = Package.Location
        TbPax.Text = Package.Pax
        TbDuration.Text = Package.Duration
        PicBox.Image = Package.Picture

        BtnAdd.Text = "Save Edits"
    End Sub
    Private Sub DeletePackage()
        NewPackage.Pax = "DELETE"
        Me.Close()
    End Sub
    Private Sub DtpChange(sender As DateTimePicker, e As EventArgs)
        NewPackage.Location = sender.Value.ToString("d")
    End Sub
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
            .Pax = TbPax.Text
            .Duration = TbDuration.Text
            .Picture = PicBox.Image

            If TbLocations.Enabled Then
                .Location = TbLocations.Text
            End If

        End With
        Me.Close()
    End Sub

    Private Sub Cancel() Handles BtnCancel.Click
        NewPackage.Pax = "CANCEL"
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

    Private Sub AddPic(sender As Object, e As EventArgs) Handles PicBox.Click

    End Sub
End Class