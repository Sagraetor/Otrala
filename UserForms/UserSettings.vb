Public Class UserSettings
    Public Editing As Boolean = False
    Dim PassPendingChange As Boolean = False
    Dim NewPass As String
    Dim StrMyPackages As String
    Dim LstBookingID As New List(Of Integer)
    Dim MyPackageList As List(Of Package)

    Public Overrides Sub AddFormLoad()
        Me.BookingTableAdapter.Fill(Me.OtralaDBDataSet.Booking)
        Me.RequestAnswerTableAdapter.Fill(Me.OtralaDBDataSet.RequestAnswer)
        Me.RequestTableAdapter.Fill(Me.OtralaDBDataSet.Request)
        Me.LoginInfoTableAdapter.Fill(Me.OtralaDBDataSet.LoginInfo)
        Me.PackageTableAdapter.Fill(Me.OtralaDBDataSet.Package)
        Me.UserInfoTableAdapter.Fill(Me.OtralaDBDataSet.UserInfo)
        If Not User.IsSeller Then
            BtnSeller.Text = "Become a seller"
        Else
            BtnSeller.Text = "Edit Travel Agency"
        End If
        LoadUserInfo()
    End Sub

    Public Sub ForceEdit()
        If Editing = False Then
            EditMode()
            Editing = True
            BtnEdit.Text = "Double click fields to edit, Click me to save changes"
        End If
    End Sub

    Private Function GetIndex(Name As String)
        Dim House As Short = 0
        Dim Index As Short = 0
        For Each Letter In Name.Reverse
            If IsNumeric(Letter) Then
                Index += Val(Letter) * (10 ^ House)
            End If
        Next
        Return Index
    End Function


    Private Sub RequestToBeSeller() Handles BtnSeller.Click

        If Editing Then
            MsgBox("Please update your profile first")
            Exit Sub
        End If

        If User.IsSeller Then
            Exit Sub
        End If

        Dim ApplicationExist As DataRow() = OtralaDBDataSet.SellerApplication.Select("UserID = " & User.UserID)

        For Each row In ApplicationExist
            If Not row.IsNull(0) Then
                MsgBox("You have already submitted a previous application." & Environment.NewLine & "Please wait patiently for the approval of our admins.")
                Exit Sub
            End If
        Next

        Dim NewApplicationForm As New ApplySeller
        NewApplicationForm.ShowDialog()

        If NewApplicationForm.ImgIC IsNot Nothing AndAlso NewApplicationForm.ImgDocument IsNot Nothing Then
            Dim NewIcPic As Image = NewApplicationForm.ImgIC
            Dim NewDocPic As Image = NewApplicationForm.ImgDocument

            Dim NewSellerApplication As DataRow = OtralaDBDataSet.SellerApplication.NewSellerApplicationRow

            NewSellerApplication("UserID") = User.UserID
            NewSellerApplication("ICPic") = DataFromImage(NewIcPic)
            NewSellerApplication("ProofOfAgency") = DataFromImage(NewDocPic)

            OtralaDBDataSet.SellerApplication.AddSellerApplicationRow(NewSellerApplication)

            SellerApplicationTableAdapter.Update(OtralaDBDataSet)
        End If

    End Sub
    Private Sub OfferRequest(Sender As Object, e As EventArgs)
        Dim OfferIndex = GetIndex(Sender.Name)

        Dim NewOfferRow As DataRow = OtralaDBDataSet.RequestAnswer.NewRequestAnswerRow

        Dim RequestRow As DataRow = OtralaDBDataSet.Request.Select("RequestID = " & OfferIndex)(0)

        Dim NewOfferForm As New AddPackage
        Dim RequestState As String = RequestRow("Location")

        Do While NewOfferForm.date_selected = False
            NewOfferForm.OfferPackage(RequestState)
            NewOfferForm.ShowDialog()
            If Not NewOfferForm.date_selected Then
                MsgBox("Date Not Selected")
            End If
        Loop

        Dim Offer As Package = NewOfferForm.NewPackage

        If Offer.Pax = "CANCEL" Then
            Exit Sub
        End If

        NewOfferRow("RequestID") = RequestRow("RequestID")
        NewOfferRow("UserID") = User.UserID
        NewOfferRow("Pax") = Offer.Pax
        NewOfferRow("Price") = Offer.Price
        NewOfferRow("SellerName") = User.Name
        NewOfferRow("Duration") = Offer.Duration
        NewOfferRow("Description") = Offer.Description
        NewOfferRow("TripDate") = Offer.Location


        OtralaDBDataSet.RequestAnswer.AddRequestAnswerRow(NewOfferRow)

        RequestAnswerTableAdapter.Update(OtralaDBDataSet)
    End Sub

    Private Sub ViewBooking(sender As Object, e As EventArgs)
        Dim PackageIndex As Integer = GetIndex(sender.name)
    End Sub

    Private Sub EditPackage(sender As Object, e As EventArgs)
        Dim PackageIndex As Integer = GetIndex(sender.name)

        Dim FormEditPackage As New AddPackage
        FormEditPackage.EditMode(MyPackageList(PackageIndex - 1))
        FormEditPackage.ShowDialog()
        Dim ResultPackage As Package = FormEditPackage.NewPackage

        If ResultPackage.Pax = "CANCEL" Then
            Exit Sub
        ElseIf ResultPackage.Pax = "DELETE" Then
            Dim RowToDelete As DataRow = OtralaDBDataSet.Package.Select("PackageID = " & MyPackageList(PackageIndex - 1).PackageID)(0)
            Dim IndexToDelete As Integer = OtralaDBDataSet.Package.Rows.IndexOf(RowToDelete)

            OtralaDBDataSet.Package.Rows(IndexToDelete).Delete()
        ElseIf ResultPackage.Pax <> "" Then
            Dim RowToEdit As DataRow = OtralaDBDataSet.Package.Select("PackageID = " & MyPackageList(PackageIndex - 1).PackageID)(0)
            Dim IndexToEdit As Integer = OtralaDBDataSet.Package.Rows.IndexOf(RowToEdit)

            OtralaDBDataSet.Package.Rows(IndexToEdit)("UserID") = ResultPackage.SellerID
            OtralaDBDataSet.Package.Rows(IndexToEdit)("PackageName") = ResultPackage.PackageName
            OtralaDBDataSet.Package.Rows(IndexToEdit)("Price") = ResultPackage.Price
            OtralaDBDataSet.Package.Rows(IndexToEdit)("Description") = ResultPackage.Description
            OtralaDBDataSet.Package.Rows(IndexToEdit)("State") = ResultPackage.State
            OtralaDBDataSet.Package.Rows(IndexToEdit)("Destination") = ResultPackage.Location
            OtralaDBDataSet.Package.Rows(IndexToEdit)("Pax") = ResultPackage.Pax
            OtralaDBDataSet.Package.Rows(IndexToEdit)("Duration") = ResultPackage.Duration
            OtralaDBDataSet.Package.Rows(IndexToEdit)("SellerName") = ResultPackage.SellerName
            OtralaDBDataSet.Package.Rows(IndexToEdit)("Picture") = OtralAPI.DataFromImage(ResultPackage.Picture)
        End If

        PackageTableAdapter.Update(OtralaDBDataSet)
        Me.PackageTableAdapter.Fill(Me.OtralaDBDataSet.Package)
        SwapToSeller()
    End Sub
    Private Sub SeeRequests() Handles BtnSeeReqs.Click
        BtnSeller.Enabled = True
        PnlSeller.Controls.Clear()

        Dim Requests As DataRow() = OtralaDBDataSet.Request.Select("Fulfilled = False")

        If Requests.Count = 0 Then
            Dim no_result As New Label
            With no_result
                .Name = "lblNoResult"
                .Location = New System.Drawing.Point(PnlSeller.Width / 2 - 400, PnlSeller.Height / 2 - 100)
                .Text = "Oops, it looks like you don't have any requests currently."
                .Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
                .Size = New System.Drawing.Size(800, 300)
                .TextAlign = ContentAlignment.TopLeft
            End With

            PnlSeller.Controls.Add(no_result)
            Exit Sub
        End If

        Dim RequestIndex As Long = 1
        Const Dy As Short = 387

        For Each RequestRow In Requests
            Dim ClientInfo As DataRow = OtralaDBDataSet.UserInfo.Select("UserID = " & RequestRow("UserID"))(0)
            Dim RequestID As Integer = RequestRow("RequestID")

            Dim NewLblContactInfo As New Label
            With NewLblContactInfo
                .Location = New System.Drawing.Point(181, 21)
                .Name = "LblRequestContactInfo" & RequestID
                .Size = New System.Drawing.Size(295, 100)
                .TabIndex = 31
                .Text = "Contact Info :" & vbNewLine & ClientInfo("RealName") & vbNewLine & ClientInfo("Email") & vbNewLine & ClientInfo("Phone")
            End With

            Dim NewLblDate As New Label
            With NewLblDate
                .AutoSize = True
                .Location = New System.Drawing.Point(181, 137)
                .Name = "LblRequestDate" & RequestID
                .Size = New System.Drawing.Size(234, 23)
                .TabIndex = 31
                .Text = "Planned Date : " & RequestRow("PlannedDate")
            End With

            Dim NewLblLocation As New Label
            With NewLblLocation
                .AutoSize = True
                .Location = New System.Drawing.Point(17, 280)
                .Name = "LblRequestLocation" & RequestID
                .Size = New System.Drawing.Size(102, 23)
                .TabIndex = 32
                .Text = "Location : " & RequestRow("Location")
            End With

            Dim NewLblPax As New Label
            With NewLblPax
                .AutoSize = True
                .Location = New System.Drawing.Point(17, 201)
                .Name = "LblRequestPax" & RequestID
                .Size = New System.Drawing.Size(61, 23)
                .TabIndex = 32
                .Text = "Pax : " & RequestRow("Pax")
            End With

            Dim NewLblPrice As New Label
            With NewLblPrice
                .AutoSize = True
                .Location = New System.Drawing.Point(17, 241)
                .Name = "LblRequestPrice" & RequestID
                .Size = New System.Drawing.Size(123, 23)
                .TabIndex = 32

                Dim StrPrice As String = RequestRow("Price")
                Dim ArrayStrPrice() As String = StrPrice.Split("-")
                Dim Price(1) As Decimal

                For i = 0 To 1

                    If ArrayStrPrice(i) = "0" Then
                        Continue For
                    End If
                    Price(i) = CDec(ArrayStrPrice(i))
                Next

                If Price(0) = 0 Then
                    .Text = "Price range : Less than " & Price(1).ToString("c")
                ElseIf Price(1) = 0 Then
                    .Text = "Price range : More than " & Price(0).ToString("c")
                Else
                    .Text = String.Format("Price range : {0} to {1}", Price(0).ToString("c"), Price(1).ToString("c"))
                End If
            End With

            Dim NewLblAdditional As New Label
            With NewLblAdditional
                .AutoSize = True
                .Location = New System.Drawing.Point(495, 17)
                .Name = "LblRequestAdditional" & RequestID
                .Size = New System.Drawing.Size(170, 23)
                .TabIndex = 32
                .Text = "Additional Notes : "
            End With

            Dim NewLblNotes As New Label
            With NewLblNotes
                .BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                .Location = New System.Drawing.Point(495, 40)
                .Name = "lblRequestNotes" & RequestID
                .Size = New System.Drawing.Size(439, 290)
                .TabIndex = 31
                .Text = RequestRow("Notes")
            End With

            Dim NewLblDuration As New Label
            With NewLblDuration
                .AutoSize = True
                .Location = New System.Drawing.Point(181, 201)
                .Name = "LblRequestDuration" & RequestID
                .Size = New System.Drawing.Size(101, 23)
                .TabIndex = 32
                .Text = "Duration : " & RequestRow("Duration")
            End With

            Dim NewClientPicBox As New PictureBox
            With NewClientPicBox
                .Location = New System.Drawing.Point(21, 21)
                .Name = "PbRequestClient" & RequestID
                .Size = New System.Drawing.Size(156, 156)
                .SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
                .TabIndex = 30
                .TabStop = False

                If Not IsDBNull(ClientInfo("Picture")) Then
                    .Image = OtralAPI.ImageFromData(ClientInfo("Picture"))
                End If
            End With

            Dim NewBtnOffer As New Button
            With NewBtnOffer
                .Location = New System.Drawing.Point(315, 299)
                .Name = "BtnOffer" & RequestID
                .Size = New System.Drawing.Size(163, 31)
                .TabIndex = 33
                .Text = "Make an Offer"
                .UseVisualStyleBackColor = True
                .BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
                .ForeColor = System.Drawing.Color.White
            End With

            Dim NewRequestPanel As New Panel
            With NewRequestPanel
                .BackColor = System.Drawing.Color.White
                .Controls.Add(NewLblAdditional)
                .Controls.Add(NewLblLocation)
                .Controls.Add(NewClientPicBox)
                .Controls.Add(NewLblDuration)
                .Controls.Add(NewLblContactInfo)
                .Controls.Add(NewLblNotes)
                .Controls.Add(NewLblDate)
                .Controls.Add(NewLblPrice)
                .Controls.Add(NewLblPax)
                .Controls.Add(NewBtnOffer)
                .Location = New System.Drawing.Point(47, 41)
                .Name = "PnlBookings" & RequestID
                .Size = New System.Drawing.Size(961, 359)
                .TabIndex = 29
            End With


            PnlSeller.Controls.Add(NewRequestPanel)
            NewRequestPanel.Top += Dy * (RequestIndex - 1)
            RequestIndex += 1

            AddHandler NewBtnOffer.Click, AddressOf OfferRequest
        Next
    End Sub
    Private Sub ViewClients() Handles BtnClient.Click
        BtnSeller.Enabled = True

        PnlSeller.Controls.Clear()
        LstBookingID.Clear()
        Dim MyClientsBookings As DataRow()

        Dim MyOffers As DataRow() = OtralaDBDataSet.RequestAnswer.Select(String.Format("UserID = '{0}' AND Accepted <> ''", User.UserID))

        MyClientsBookings = OtralaDBDataSet.Booking.Select("PackageID IN (" & StrMyPackages & ")")


        If MyClientsBookings.Count = 0 And MyOffers.Count = 0 Then
            Dim no_result As New Label
            With no_result
                .Name = "lblNoResult"
                .Location = New System.Drawing.Point(PnlSeller.Width / 2 - 400, PnlSeller.Height / 2 - 100)
                .Text = "Oops, it looks like you don't have any clients currently."
                .Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
                .Size = New System.Drawing.Size(800, 300)
                .TextAlign = ContentAlignment.TopLeft
            End With

            PnlSeller.Controls.Add(no_result)
            Exit Sub
        End If

        Dim BookingIndex As Long = 1
        Const Dy As Short = 387

        For Each ClientBooking In MyClientsBookings
            Dim ClientInfo As DataRow
            Dim RequestInfo As DataRow

            If MyClientsBookings.Contains(ClientBooking) Then
                ClientInfo = OtralaDBDataSet.UserInfo.Select("UserID = " & ClientBooking("UserID"))(0)
            ElseIf MyOffers.Contains(ClientBooking) Then
                RequestInfo = OtralaDBDataSet.UserInfo.Select("RequestID = " & ClientBooking("RequestID"))(0)
                ClientInfo = OtralaDBDataSet.UserInfo.Select("UserID = " & RequestInfo("UserID"))(0)
            End If
            Dim NewLblContactInfo As New Label
            With NewLblContactInfo
                .Location = New System.Drawing.Point(181, 21)
                .Name = "LblBookingContactInfo" & BookingIndex
                .Size = New System.Drawing.Size(295, 100)
                .TabIndex = 31
                .Text = "Contact Info :" & vbNewLine & ClientInfo("RealName") & vbNewLine & ClientInfo("Email") & vbNewLine & ClientInfo("Phone")
            End With

            Dim NewLblDate As New Label
            With NewLblDate
                .AutoSize = True
                .Location = New System.Drawing.Point(181, 137)
                .Name = "LblBookingDate" & BookingIndex
                .Size = New System.Drawing.Size(234, 23)
                .TabIndex = 31
                If MyClientsBookings.Contains(ClientBooking) Then
                    If ClientBooking("ClientFulfilled") = "" Then
                        .Text = "Planned Date : " & ClientBooking("PlannedDate")
                    Else
                        .Text = "Client marked as completed on : " & ClientBooking("ClientFulfilled")
                    End If
                Else
                    .Text = "Planned Date : " & ClientBooking("TripDate")
                End If
            End With

            Dim NewLblQuantity As New Label
            With NewLblQuantity
                .AutoSize = True
                .Location = New System.Drawing.Point(17, 201)
                .Name = "LblBookingQuantity" & BookingIndex
                .Size = New System.Drawing.Size(95, 23)
                .TabIndex = 32
                If MyClientsBookings.Contains(ClientBooking) Then
                    .Text = "Quantity: " & ClientBooking("Quantity")
                Else
                    .Text = "Quantity: 1"
                End If
            End With

            Dim NewLblTotalPaid As New Label
            With NewLblTotalPaid
                .AutoSize = True
                .Location = New System.Drawing.Point(17, 238)
                .Name = "LblBookingTotalPaid" & BookingIndex
                .Size = New System.Drawing.Size(160, 23)
                .TabIndex = 32
                If MyClientsBookings.Contains(ClientBooking) Then
                    .Text = "Total Price Paid: " & ClientBooking("TotalPrice")
                Else
                    .Text = "Total Price Paid: " & ClientBooking("Price")
                End If
            End With

            Dim NewClientPicBox As New PictureBox
            With NewClientPicBox
                .Location = New System.Drawing.Point(21, 21)
                .Name = "PbBookingClient" & BookingIndex
                .Size = New System.Drawing.Size(156, 156)
                .SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
                .TabIndex = 30
                .TabStop = False

                If Not IsDBNull(ClientInfo("Picture")) Then
                    .Image = OtralAPI.ImageFromData(ClientInfo("Picture"))
                End If
            End With

            Dim NewBtnCancel As New Button
            With NewBtnCancel
                .Location = New System.Drawing.Point(21, 299)
                .Name = "BtnBookingCancel" & BookingIndex
                .Size = New System.Drawing.Size(195, 31)
                .TabIndex = 33
                .Text = "Cancel"
                .BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
                .ForeColor = System.Drawing.Color.White
            End With

            Dim NewBtnComplete As New Button
            With NewBtnComplete
                .Location = New System.Drawing.Point(283, 299)
                .Name = "BtnBookingComplete" & BookingIndex
                .Size = New System.Drawing.Size(195, 31)
                .TabIndex = 33
                .Text = "Mark As Completed"
                .BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
                .ForeColor = System.Drawing.Color.White
            End With

            'Creates package
            Dim BookedPackage As DataRow = OtralaDBDataSet.Package.Select("PackageID = " & ClientBooking("PackageID"))(0)



            Dim NewLblTitle As New Label
            With NewLblTitle
                .Location = New System.Drawing.Point(175, 29)
                .Name = "LblTitleBooking" & BookingIndex
                .Size = New System.Drawing.Size(236, 48)
                .TabIndex = 13
                If MyClientsBookings.Contains(ClientBooking) Then
                    .Text = BookedPackage("PackageName")
                Else
                    .Text = "Custom Offer"
                End If
            End With

            Dim NewLblSeller As New Label
            With NewLblSeller
                .BackColor = System.Drawing.SystemColors.Window
                .Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
                .ForeColor = System.Drawing.SystemColors.ControlDark
                .Location = New System.Drawing.Point(175, 280)
                .Name = "LblSellerBooking" & BookingIndex
                .Size = New System.Drawing.Size(254, 23)
                .TabIndex = 13
                .Text = BookedPackage("SellerName")
                .TextAlign = System.Drawing.ContentAlignment.MiddleRight
            End With

            Dim NewLblDesc As New Label
            With NewLblDesc
                .Location = New System.Drawing.Point(175, 151)
                .Name = "LblDescBooking" & BookingIndex
                .Size = New System.Drawing.Size(236, 117)
                .TabIndex = 13
                .Text = BookedPackage("Description")
            End With

            Dim NewLblDuration As New Label
            With NewLblDuration
                .Location = New System.Drawing.Point(175, 77)
                .Name = "LblDurationBooking" & BookingIndex
                .Size = New System.Drawing.Size(107, 59)
                .TabIndex = 13
                If BookedPackage("Duration") > 2 Then
                    .Text = BookedPackage("Duration") & " DAYS " & System.Environment.NewLine & CInt(BookedPackage("Duration")) - 1 & " NIGHTS"
                ElseIf BookedPackage("Duration") > 1 Then
                    .Text = BookedPackage("Duration") & " DAYS " & System.Environment.NewLine & CInt(BookedPackage("Duration")) - 1 & " NIGHT"
                Else
                    .Text = BookedPackage("Duration") & " DAY "
                End If
            End With

            Dim NewLblPrice As New Label
            With NewLblPrice
                .Location = New System.Drawing.Point(17, 210)
                .Name = "LblPriceBooking" & BookingIndex
                .Size = New System.Drawing.Size(152, 24)
                .TabIndex = 13
                Dim PriceToWrite As Decimal = BookedPackage("Price")
                .Text = PriceToWrite.ToString("C")
            End With

            Dim NewLblPax As New Label
            With NewLblPax
                .Location = New System.Drawing.Point(17, 244)
                .Name = "LblPaxBooking" & BookingIndex
                .Size = New System.Drawing.Size(152, 24)
                .TabIndex = 13
                .Text = BookedPackage("Pax") & " Person"
            End With

            Dim NewPicBox As New PictureBox
            With NewPicBox
                If MyClientsBookings.Contains(ClientBooking) Then
                    .Image = ImageFromData(BookedPackage("Picture"))
                Else
                    .Image = Global.Otrala_2._0.My.Resources.Resources.AddPackagePicUnavailable
                End If
                .Location = New System.Drawing.Point(17, 29)
                .Name = "PictureBox" & BookingIndex
                .Size = New System.Drawing.Size(140, 140)
                .SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
                .TabIndex = 0
                .TabStop = False
            End With

            Dim NewGrpBox As New GroupBox
            With NewGrpBox
                .BackColor = System.Drawing.SystemColors.Window
                .Size = New System.Drawing.Size(435, 306)
                .Location = New System.Drawing.Point(499, 29)
                .Name = "GrpBoxBooking" & BookingIndex
                .Controls.Add(NewLblDesc)
                .Controls.Add(NewLblDuration)
                .Controls.Add(NewLblPax)
                .Controls.Add(NewLblPrice)
                .Controls.Add(NewLblSeller)
                .Controls.Add(NewLblTitle)
                .Controls.Add(NewPicBox)
            End With

            'End Package. Continue rest of booking

            Dim NewBookingPanel As New Panel
            With NewBookingPanel
                .BackColor = System.Drawing.Color.White
                .Controls.Add(NewBtnCancel)
                .Controls.Add(NewBtnComplete)
                .Controls.Add(NewClientPicBox)
                .Controls.Add(NewGrpBox)
                .Controls.Add(NewLblContactInfo)
                .Controls.Add(NewLblTotalPaid)
                .Controls.Add(NewLblDate)
                .Controls.Add(NewLblQuantity)
                .Location = New System.Drawing.Point(47, 41)
                .Name = "PnlBookings" & BookingIndex
                .Size = New System.Drawing.Size(961, 359)
                .TabIndex = 29
            End With

            PnlSeller.Controls.Add(NewBookingPanel)
            NewBookingPanel.Top += Dy * (BookingIndex - 1)
            BookingIndex += 1

            If MyClientsBookings.Contains(ClientBooking) Then
                AddHandler NewBtnCancel.Click, AddressOf CancelBooked
                AddHandler NewBtnComplete.Click, AddressOf MarkComplete
            End If

            LstBookingID.Add(BookedPackage("PackageID"))
        Next

        For Each ClientBooking In MyOffers
            Dim ClientInfo As DataRow
            Dim RequestInfo As DataRow

            If MyClientsBookings.Contains(ClientBooking) Then
                ClientInfo = OtralaDBDataSet.UserInfo.Select("UserID = " & ClientBooking("UserID"))(0)
            ElseIf MyOffers.Contains(ClientBooking) Then
                RequestInfo = OtralaDBDataSet.Request.Select("RequestID = " & ClientBooking("RequestID"))(0)
                ClientInfo = OtralaDBDataSet.UserInfo.Select("UserID = " & RequestInfo("UserID"))(0)
            End If
            Dim NewLblContactInfo As New Label
            With NewLblContactInfo
                .Location = New System.Drawing.Point(181, 21)
                .Name = "LblBookingContactInfo" & BookingIndex
                .Size = New System.Drawing.Size(295, 100)
                .TabIndex = 31
                .Text = "Contact Info :" & vbNewLine & ClientInfo("RealName") & vbNewLine & ClientInfo("Email") & vbNewLine & ClientInfo("Phone")
            End With

            Dim NewLblDate As New Label
            With NewLblDate
                .AutoSize = True
                .Location = New System.Drawing.Point(181, 137)
                .Name = "LblBookingDate" & BookingIndex
                .Size = New System.Drawing.Size(234, 23)
                .TabIndex = 31
                If MyClientsBookings.Contains(ClientBooking) Then
                    If ClientBooking("ClientFulfilled") = "" Then
                        .Text = "Planned Date : " & ClientBooking("PlannedDate")
                    Else
                        .Text = "Client marked as completed on : " & ClientBooking("ClientFulfilled")
                    End If
                Else
                    .Text = "Planned Date : " & ClientBooking("TripDate")
                End If
            End With

            Dim NewLblQuantity As New Label
            With NewLblQuantity
                .AutoSize = True
                .Location = New System.Drawing.Point(17, 201)
                .Name = "LblBookingQuantity" & BookingIndex
                .Size = New System.Drawing.Size(95, 23)
                .TabIndex = 32
                If MyClientsBookings.Contains(ClientBooking) Then
                    .Text = "Quantity: " & ClientBooking("Quantity")
                Else
                    .Text = "Quantity: 1"
                End If
            End With

            Dim NewLblTotalPaid As New Label
            With NewLblTotalPaid
                .AutoSize = True
                .Location = New System.Drawing.Point(17, 238)
                .Name = "LblBookingTotalPaid" & BookingIndex
                .Size = New System.Drawing.Size(160, 23)
                .TabIndex = 32
                If MyClientsBookings.Contains(ClientBooking) Then
                    .Text = "Total Price Paid: " & ClientBooking("TotalPrice")
                Else
                    .Text = "Total Price Paid: " & ClientBooking("Price")
                End If
            End With

            Dim NewClientPicBox As New PictureBox
            With NewClientPicBox
                .Location = New System.Drawing.Point(21, 21)
                .Name = "PbBookingClient" & BookingIndex
                .Size = New System.Drawing.Size(156, 156)
                .SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
                .TabIndex = 30
                .TabStop = False

                If Not IsDBNull(ClientInfo("Picture")) Then
                    .Image = OtralAPI.ImageFromData(ClientInfo("Picture"))
                End If
            End With

            Dim NewBtnCancel As New Button
            With NewBtnCancel
                .Location = New System.Drawing.Point(21, 299)
                .Name = "BtnBookingCancel" & BookingIndex
                .Size = New System.Drawing.Size(195, 31)
                .TabIndex = 33
                .Text = "Cancel"
                .UseVisualStyleBackColor = True
            End With

            Dim NewBtnComplete As New Button
            With NewBtnComplete
                .Location = New System.Drawing.Point(283, 299)
                .Name = "BtnBookingComplete" & BookingIndex
                .Size = New System.Drawing.Size(195, 31)
                .TabIndex = 33
                .Text = "Mark As Completed"
                .UseVisualStyleBackColor = True
            End With

            'Creates package
            Dim BookedPackage As DataRow = OtralaDBDataSet.RequestAnswer.Select("RequestAnswerID = " & ClientBooking("RequestAnswerID"))(0)



            Dim NewLblTitle As New Label
            With NewLblTitle
                .Location = New System.Drawing.Point(175, 29)
                .Name = "LblTitleBooking" & BookingIndex
                .Size = New System.Drawing.Size(236, 48)
                .TabIndex = 13
                If MyClientsBookings.Contains(ClientBooking) Then
                    .Text = BookedPackage("PackageName")
                Else
                    .Text = "Custom Offer"
                End If
            End With

            Dim NewLblSeller As New Label
            With NewLblSeller
                .BackColor = System.Drawing.SystemColors.Window
                .Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
                .ForeColor = System.Drawing.SystemColors.ControlDark
                .Location = New System.Drawing.Point(175, 280)
                .Name = "LblSellerBooking" & BookingIndex
                .Size = New System.Drawing.Size(254, 23)
                .TabIndex = 13
                .Text = BookedPackage("SellerName")
                .TextAlign = System.Drawing.ContentAlignment.MiddleRight
            End With

            Dim NewLblDesc As New Label
            With NewLblDesc
                .Location = New System.Drawing.Point(175, 151)
                .Name = "LblDescBooking" & BookingIndex
                .Size = New System.Drawing.Size(236, 117)
                .TabIndex = 13
                .Text = BookedPackage("Description")
            End With

            Dim NewLblDuration As New Label
            With NewLblDuration
                .Location = New System.Drawing.Point(175, 77)
                .Name = "LblDurationBooking" & BookingIndex
                .Size = New System.Drawing.Size(107, 59)
                .TabIndex = 13
                If BookedPackage("Duration") > 2 Then
                    .Text = BookedPackage("Duration") & " DAYS " & System.Environment.NewLine & CInt(BookedPackage("Duration")) - 1 & " NIGHTS"
                ElseIf BookedPackage("Duration") > 1 Then
                    .Text = BookedPackage("Duration") & " DAYS " & System.Environment.NewLine & CInt(BookedPackage("Duration")) - 1 & " NIGHT"
                Else
                    .Text = BookedPackage("Duration") & " DAY "
                End If
            End With

            Dim NewLblPrice As New Label
            With NewLblPrice
                .Location = New System.Drawing.Point(17, 210)
                .Name = "LblPriceBooking" & BookingIndex
                .Size = New System.Drawing.Size(152, 24)
                .TabIndex = 13
                Dim PriceToWrite As Decimal = BookedPackage("Price")
                .Text = PriceToWrite.ToString("C")
            End With

            Dim NewLblPax As New Label
            With NewLblPax
                .Location = New System.Drawing.Point(17, 244)
                .Name = "LblPaxBooking" & BookingIndex
                .Size = New System.Drawing.Size(152, 24)
                .TabIndex = 13
                .Text = BookedPackage("Pax") & " Person"
            End With

            Dim NewPicBox As New PictureBox
            With NewPicBox
                If MyClientsBookings.Contains(ClientBooking) Then
                    .Image = ImageFromData(BookedPackage("Picture"))
                Else
                    .Image = Global.Otrala_2._0.My.Resources.Resources.AddPackagePicUnavailable
                End If
                .Location = New System.Drawing.Point(17, 29)
                .Name = "PictureBox" & BookingIndex
                .Size = New System.Drawing.Size(140, 140)
                .SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
                .TabIndex = 0
                .TabStop = False
            End With

            Dim NewGrpBox As New GroupBox
            With NewGrpBox
                .BackColor = System.Drawing.SystemColors.Window
                .Size = New System.Drawing.Size(435, 306)
                .Location = New System.Drawing.Point(499, 29)
                .Name = "GrpBoxBooking" & BookingIndex
                .Controls.Add(NewLblDesc)
                .Controls.Add(NewLblDuration)
                .Controls.Add(NewLblPax)
                .Controls.Add(NewLblPrice)
                .Controls.Add(NewLblSeller)
                .Controls.Add(NewLblTitle)
                .Controls.Add(NewPicBox)
            End With

            'End Package. Continue rest of booking

            Dim NewBookingPanel As New Panel
            With NewBookingPanel
                .BackColor = System.Drawing.Color.White
                .Controls.Add(NewBtnCancel)
                .Controls.Add(NewBtnComplete)
                .Controls.Add(NewClientPicBox)
                .Controls.Add(NewGrpBox)
                .Controls.Add(NewLblContactInfo)
                .Controls.Add(NewLblTotalPaid)
                .Controls.Add(NewLblDate)
                .Controls.Add(NewLblQuantity)
                .Location = New System.Drawing.Point(47, 41)
                .Name = "PnlBookings" & BookingIndex
                .Size = New System.Drawing.Size(961, 359)
                .TabIndex = 29
            End With

            PnlSeller.Controls.Add(NewBookingPanel)
            NewBookingPanel.Top += Dy * (BookingIndex - 1)
            BookingIndex += 1

            If MyClientsBookings.Contains(ClientBooking) Then
                AddHandler NewBtnCancel.Click, AddressOf CancelBooked
                AddHandler NewBtnComplete.Click, AddressOf MarkComplete
            End If

            If MyClientsBookings.Contains(ClientBooking) Then
                LstBookingID.Add(BookedPackage("PackageID"))
            End If
        Next
    End Sub

    Private Sub MarkComplete(sender As Object, e As EventArgs)
        Dim BookingIndex As Short = GetIndex(sender.Name)

        Dim BookingRow As DataRow = OtralaDBDataSet.Booking.Select("PackageID = " & LstBookingID(BookingIndex - 1))(0)
        Dim BookingRowIndex As Integer = OtralaDBDataSet.Booking.Rows.IndexOf(BookingRow)

        OtralaDBDataSet.Booking.Rows(BookingRowIndex)("SellerFulfilled") = DateTime.Today.ToString("d")

        BookingTableAdapter.Update(OtralaDBDataSet)

        Me.BookingTableAdapter.Fill(Me.OtralaDBDataSet.Booking)

        ViewClients()
    End Sub
    Private Sub CancelBooked(sender As Object, e As EventArgs)
        Dim BookingIndex As Short = GetIndex(sender.Name)

        Dim BookingRow As DataRow = OtralaDBDataSet.Booking.Select("PackageID = " & LstBookingID(BookingIndex - 1))(0)
        Dim BookingRowIndex As Integer = OtralaDBDataSet.Booking.Rows.IndexOf(BookingRow)

        OtralaDBDataSet.Booking.Rows(BookingRowIndex).Delete()

        BookingTableAdapter.Update(OtralaDBDataSet)

        Me.BookingTableAdapter.Fill(Me.OtralaDBDataSet.Booking)

        ViewClients()
    End Sub
    Private Sub btnAddPackage_CLick() Handles BtnAddPackage.Click
        Dim PackageToAdd As Package
        Dim AddPackageForm As New AddPackage

        AddPackageForm.ShowDialog()
        PackageToAdd = AddPackageForm.NewPackage

        If PackageToAdd.Pax = "CANCEL" Then
            Exit Sub
        End If

        If PackageToAdd.Pax <> "" Then
            Dim NewPackageDataRow As DataRow = OtralaDBDataSet.Package.NewPackageRow()

            NewPackageDataRow("UserID") = PackageToAdd.SellerID
            NewPackageDataRow("PackageName") = PackageToAdd.PackageName
            NewPackageDataRow("Price") = PackageToAdd.Price
            NewPackageDataRow("Description") = PackageToAdd.Description
            NewPackageDataRow("State") = PackageToAdd.State
            NewPackageDataRow("Destination") = PackageToAdd.Location
            NewPackageDataRow("Pax") = PackageToAdd.Pax
            NewPackageDataRow("Duration") = PackageToAdd.Duration
            NewPackageDataRow("SellerName") = PackageToAdd.SellerName
            NewPackageDataRow("Picture") = OtralAPI.DataFromImage(PackageToAdd.Picture)

            OtralaDBDataSet.Package.AddPackageRow(NewPackageDataRow)

            PackageTableAdapter.Update(OtralaDBDataSet)

            Me.FormLoad()

            PnlSeller.Controls.Clear()

            SwapToSeller()
        End If
    End Sub

    Private Sub GenerateCatalogue(CatalogueItems As List(Of Package), Optional IsSeller As Boolean = True)
        Dim CatalogueIndex As Long = 1
        Dim CatalogueYIndex As Integer = 0
        ' Count will determine how many catalogues to generate.
        ' Change to how many database logs we have after we make the database.

        Const Dx As Integer = 505 ' Distance between catalogues in the same row.
        Const Dy As Integer = 363 ' Distance between catalogues between rows.

        ' Lines below with ** need to be substituted with database calling (added so we remember later lol)

        For Each CatalogueItem In CatalogueItems
            Dim NewLblTitle As New Label
            With NewLblTitle
                .Location = New System.Drawing.Point(175, 29)
                .Name = "LblTitleCatalogue" & CatalogueIndex
                .Size = New System.Drawing.Size(236, 48)
                .TabIndex = 13
                .Text = CatalogueItem.PackageName
            End With

            Dim NewLblSeller As New Label
            With NewLblSeller
                .BackColor = System.Drawing.SystemColors.Window
                .Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
                .ForeColor = System.Drawing.SystemColors.ControlDark
                .Location = New System.Drawing.Point(175, 280)
                .Name = "LblSellerCatalogue" & CatalogueIndex
                .Size = New System.Drawing.Size(254, 23)
                .TabIndex = 13
                .Text = CatalogueItem.SellerName
                .TextAlign = System.Drawing.ContentAlignment.MiddleRight
            End With

            Dim NewLblDesc As New Label
            With NewLblDesc
                .Location = New System.Drawing.Point(175, 151)
                .Name = "LblDescCatalogue" & CatalogueIndex
                .Size = New System.Drawing.Size(236, 117)
                .TabIndex = 13
                .Text = CatalogueItem.Description
            End With

            Dim NewLblDuration As New Label
            With NewLblDuration
                .Location = New System.Drawing.Point(175, 77)
                .Name = "LblDurationCatalogue" & CatalogueIndex
                .Size = New System.Drawing.Size(107, 59)
                .TabIndex = 13
                If CatalogueItem.Duration > 2 Then
                    .Text = CatalogueItem.Duration & " DAYS " & System.Environment.NewLine & CInt(CatalogueItem.Duration) - 1 & " NIGHTS"
                ElseIf CatalogueItem.Duration > 1 Then
                    .Text = CatalogueItem.Duration & " DAYS " & System.Environment.NewLine & CInt(CatalogueItem.Duration) - 1 & " NIGHT"
                Else
                    .Text = CatalogueItem.Duration & " DAY "
                End If
            End With

            Dim NewLblPrice As New Label
            With NewLblPrice
                .Location = New System.Drawing.Point(17, 210)
                .Name = "LblPriceCatalogue" & CatalogueIndex
                .Size = New System.Drawing.Size(152, 24)
                .TabIndex = 13
                .Text = CatalogueItem.Price.ToString("C")
            End With

            Dim NewLblPax As New Label
            With NewLblPax
                .Location = New System.Drawing.Point(17, 244)
                .Name = "LblPaxCatalogue" & CatalogueIndex
                .Size = New System.Drawing.Size(152, 24)
                .TabIndex = 13
                .Text = CatalogueItem.Pax & " Person"
            End With

            Dim NewPicBox As New PictureBox
            With NewPicBox
                .Image = CatalogueItem.Picture
                .Location = New System.Drawing.Point(17, 29)
                .Name = "PictureBox" & CatalogueIndex
                .Size = New System.Drawing.Size(140, 140)
                .SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
                .TabIndex = 0
                .TabStop = False
            End With

            Dim NewGrpBox As New GroupBox
            With NewGrpBox
                .BackColor = System.Drawing.SystemColors.Window
                .Size = New System.Drawing.Size(435, 306)
                .Location = New System.Drawing.Point(58, 56)
                .Name = "GrpBoxCatalogue" & CatalogueIndex
                .Controls.Add(NewLblDesc)
                .Controls.Add(NewLblDuration)
                .Controls.Add(NewLblPax)
                .Controls.Add(NewLblPrice)
                .Controls.Add(NewLblSeller)
                .Controls.Add(NewLblTitle)
                .Controls.Add(NewPicBox)
            End With

            PnlSeller.Controls.Add(NewGrpBox)
            NewGrpBox.Top += Dy * CatalogueYIndex

            If IsSeller Then
                AddHandler NewLblTitle.Click, AddressOf EditPackage
                AddHandler NewLblSeller.Click, AddressOf EditPackage
                AddHandler NewLblDesc.Click, AddressOf EditPackage
                AddHandler NewLblDuration.Click, AddressOf EditPackage
                AddHandler NewLblPrice.Click, AddressOf EditPackage
                AddHandler NewLblPax.Click, AddressOf EditPackage
                AddHandler NewPicBox.Click, AddressOf EditPackage
                AddHandler NewGrpBox.Click, AddressOf EditPackage
            End If

            If Not IsSeller Then
                AddHandler NewLblTitle.Click, AddressOf ViewBooking
                AddHandler NewLblSeller.Click, AddressOf ViewBooking
                AddHandler NewLblDesc.Click, AddressOf ViewBooking
                AddHandler NewLblDuration.Click, AddressOf ViewBooking
                AddHandler NewLblPrice.Click, AddressOf ViewBooking
                AddHandler NewLblPax.Click, AddressOf ViewBooking
                AddHandler NewPicBox.Click, AddressOf ViewBooking
                AddHandler NewGrpBox.Click, AddressOf ViewBooking
            End If

            If CatalogueIndex Mod 2 = 0 Then
                NewGrpBox.Left += Dx
                CatalogueYIndex += 1
            End If

            CatalogueIndex += 1

        Next
    End Sub

    Private Sub SwapToUser() Handles BtnUser.Click
        PnlSeller.Visible = False
        PnlSeller.Enabled = False

        PnlUser.Visible = True
        PnlUser.Enabled = True

        BtnUser.Enabled = False
        BtnSeller.Enabled = True

        BtnAddPackage.Enabled = False
        BtnAddPackage.Visible = False

        BtnSeeReqs.Enabled = False
        BtnSeeReqs.Visible = False

        BtnSeeBookings.Enabled = True
        BtnSeeBookings.Visible = True

        BtnClient.Enabled = False
        BtnClient.Visible = False
    End Sub
    Private Sub SwapToSeller() Handles BtnSeller.Click
        If User.IsSeller Then
            PnlSeller.Visible = True
            PnlSeller.Enabled = True

            PnlUser.Visible = False
            PnlUser.Enabled = False

            BtnUser.Enabled = True
            BtnSeller.Enabled = False

            BtnAddPackage.Enabled = True
            BtnAddPackage.Visible = True

            BtnSeeReqs.Enabled = True
            BtnSeeReqs.Visible = True

            BtnSeeBookings.Enabled = False
            BtnSeeBookings.Visible = False

            BtnClient.Enabled = True
            BtnClient.Visible = True

            PnlSeller.Controls.Clear()
            StrMyPackages = ""

            Dim MyPackages As DataRow() = OtralaDBDataSet.Package.Select("UserID = " & User.UserID)

            If MyPackages.Count() = 0 Then
                Exit Sub
            End If

            For Each PackageRow In MyPackages
                StrMyPackages += Str(PackageRow("PackageID"))
                StrMyPackages += ", "
            Next

            StrMyPackages = StrMyPackages.TrimEnd(CChar(" "))
            StrMyPackages = StrMyPackages.TrimEnd(CChar(","))

            MyPackageList = New List(Of Package)

            For Each Row In MyPackages
                Dim NewPackage As New Package
                With NewPackage
                    .SellerID = Row("UserID")
                    .PackageID = Row("PackageID")
                    .SellerName = "Temp"
                    .PackageName = Row("PackageName")
                    .Price = Row("Price")
                    .Description = Row("Description")
                    .State = Row("State")
                    .Location = Row("Destination")
                    .Pax = Row("Pax")
                    .Duration = Row("Duration")
                    .SellerName = Row("SellerName")
                    .Picture = ImageFromData(Row("Picture"))
                End With

                MyPackageList.Add(NewPackage)
            Next

            GenerateCatalogue(MyPackageList)
        Else

        End If
    End Sub

    Private Sub ViewMyBookings() Handles BtnSeeBookings.Click

        If Editing Then
            MsgBox("Please update your profile first")
            Exit Sub
        End If

        PnlSeller.Controls.Clear()

        PnlSeller.Visible = True
        PnlSeller.Enabled = True

        PnlUser.Visible = False
        PnlUser.Enabled = False

        BtnUser.Enabled = True

        Dim MyBookings As DataRow() = OtralaDBDataSet.Booking.Select("UserID = " & User.UserID)

        If MyBookings.Count = 0 Then
            Exit Sub
        End If

        Dim BookedPackageID As String = ""

        For Each Booking In MyBookings
            BookedPackageID += Booking("PackageID")
            BookedPackageID += ", "
        Next

        BookedPackageID = BookedPackageID.TrimEnd(CChar(" "))
        BookedPackageID = BookedPackageID.TrimEnd(CChar(","))

        Dim MyPackages As DataRow() = OtralaDBDataSet.Package.Select("PackageID IN (" & BookedPackageID & ")")

        Dim MyPackageList As New List(Of Package)

        For Each Row In MyPackages
            Dim NewPackage As New Package
            With NewPackage
                .SellerID = Row("UserID")
                .PackageID = Row("PackageID")
                .SellerName = "Temp"
                .PackageName = Row("PackageName")
                .Price = Row("Price")
                .Description = Row("Description")
                .State = Row("State")
                .Location = Row("Destination")
                .Pax = Row("Pax")
                .Duration = Row("Duration")
                .SellerName = Row("SellerName")
                .Picture = ImageFromData(Row("Picture"))
            End With

            MyPackageList.Add(NewPackage)
        Next

        GenerateCatalogue(MyPackageList, False)
    End Sub

    Private Sub DeleteAcc() Handles BtnDelete.Click
        If Editing Then
            MsgBox("Please update your profile first")
            Exit Sub
        End If
        If ConfirmPass(OtralaDBDataSet.LoginInfo, "You are about to delete your account. Please re-enter password." & vbNewLine & "This process cannot be reverted") Then
            Dim ToRemoveUser As DataRow
            Dim ToRemoveRows() As DataRow = OtralaDBDataSet.UserInfo.Select("UserID = " & User.UserID)
            Dim IndexUser, IndexLogin As Integer


            If ToRemoveRows.Count <> 0 Then
                ToRemoveUser = ToRemoveRows(0)
                IndexUser = OtralaDBDataSet.UserInfo.Rows.IndexOf(ToRemoveUser)
            End If

            Dim ToRemoveLogin As DataRow = OtralaDBDataSet.LoginInfo.Select("UserID = " & User.UserID)(0)
            IndexLogin = OtralaDBDataSet.LoginInfo.Rows.IndexOf(ToRemoveLogin)


            OtralaDBDataSet.UserInfo.Rows(IndexUser).Delete()
            OtralaDBDataSet.LoginInfo.Rows(IndexLogin).Delete()

            LoginInfoTableAdapter.Update(OtralaDBDataSet)
            UserInfoTableAdapter.Update(OtralaDBDataSet)

            User = New UserInfo With {
                .LoggedIn = False
            }

            Me.ToCatalogue()
        Else
            MsgBox("Wrong password entered", MsgBoxStyle.OkOnly, "Aborted")
        End If
    End Sub
    Private Sub ForceLowerCase() Handles LblProfileEmail.TextChanged
        LblProfileEmail.Text = LCase(LblProfileEmail.Text)
    End Sub
    Private Sub EditMode() Handles BtnEdit.Click
        If Not Editing Then
            Editing = True
            BtnEdit.Text = "Double click fields to edit, Click me to save changes"
        Else
            Dim UserInput As Integer = MsgBox("Do you want to save these changes?", MsgBoxStyle.YesNoCancel, "Otrala")
            If UserInput = MsgBoxResult.Yes Then

                Editing = False
                BtnEdit.Text = "Edit Profile"

                Dim UserInfoDataRow As DataRow() = OtralaDBDataSet.UserInfo.Select("UserID = " & User.UserID)
                Dim MyProfile As DataRow

                If UserInfoDataRow.Count = 0 Then
                    MyProfile = OtralaDBDataSet.UserInfo.NewUserInfoRow

                    MyProfile("Picture") = DataFromImage(PbProfile.Image)
                    MyProfile("RealName") = LblProfileName.Text
                    MyProfile("Address") = LblProfileAddress.Text
                    MyProfile("Age") = LblProfileAge.Text
                    MyProfile("Gender") = LblProfileGender.Text
                    MyProfile("Nationality") = LblProfileCountry.Text
                    MyProfile("Email") = LblProfileEmail.Text
                    MyProfile("Phone") = LblProfilePhoneNumber.Text
                    MyProfile("ICnum") = LblProfileIcNum.Text
                    MyProfile("UserID") = User.UserID
                    MyProfile("Birthday") = Convert.ToDateTime(LblProfileBirthday.Text).ToString("d")

                    OtralaDBDataSet.UserInfo.Rows.InsertAt(MyProfile, (User.UserID))

                    With User
                        .Name = LblProfileName.Text
                        .Age = LblProfileAge.Text
                        .IsSeller = False
                        .Address = LblProfileAddress.Text
                        .Picture = PbProfile.Image
                        .ICNum = LblProfileIcNum.Text
                        .Gender = LblProfileGender.Text
                        .Birthday = Convert.ToDateTime(LblProfileBirthday.Text).ToString("d")
                        .nationality = LblProfileCountry.Text
                        .IsAdmin = False
                    End With

                Else
                    MyProfile = UserInfoDataRow(0)
                    Dim ProfileIndex As Short = OtralaDBDataSet.UserInfo.Rows.IndexOf(MyProfile)

                    OtralaDBDataSet.UserInfo.Rows(ProfileIndex)("Picture") = DataFromImage(PbProfile.Image)
                    OtralaDBDataSet.UserInfo.Rows(ProfileIndex)("RealName") = LblProfileName.Text
                    OtralaDBDataSet.UserInfo.Rows(ProfileIndex)("Address") = LblProfileAddress.Text
                    OtralaDBDataSet.UserInfo.Rows(ProfileIndex)("Age") = LblProfileAge.Text
                    OtralaDBDataSet.UserInfo.Rows(ProfileIndex)("Gender") = LblProfileGender.Text
                    OtralaDBDataSet.UserInfo.Rows(ProfileIndex)("Nationality") = LblProfileCountry.Text
                    OtralaDBDataSet.UserInfo.Rows(ProfileIndex)("Email") = LblProfileEmail.Text
                    OtralaDBDataSet.UserInfo.Rows(ProfileIndex)("Phone") = LblProfilePhoneNumber.Text
                    OtralaDBDataSet.UserInfo.Rows(ProfileIndex)("ICnum") = LblProfileIcNum.Text
                    OtralaDBDataSet.UserInfo.Rows(ProfileIndex)("Birthday") = Convert.ToDateTime(LblProfileBirthday.Text).ToString("d")

                    With User
                        .Name = LblProfileName.Text
                        .Age = LblProfileAge.Text
                        .Address = LblProfileAddress.Text
                        .Picture = PbProfile.Image
                        .ICNum = LblProfileIcNum.Text
                        .Gender = LblProfileGender.Text
                        .Birthday = Convert.ToDateTime(LblProfileBirthday.Text).ToString("d")
                        .nationality = LblProfileCountry.Text
                    End With

                End If



                Dim MyLogin As DataRow = OtralaDBDataSet.LoginInfo.Select("UserID = " & User.UserID)(0)
                Dim LoginIndex As Short = OtralaDBDataSet.LoginInfo.Rows.IndexOf(MyLogin)



                If PassPendingChange Then
                    Dim Temp = Encrypt(NewPass)
                    Dim EncryptedPass As String = LstIntToStr(Temp.Item1)
                    Dim NewKey As String = LstIntToStr(Temp.Item2)

                    OtralaDBDataSet.LoginInfo(LoginIndex)("Key") = NewKey
                    OtralaDBDataSet.LoginInfo(LoginIndex)("Password") = EncryptedPass
                End If

                OtralaDBDataSet.LoginInfo(LoginIndex)("Email") = LblProfileEmail.Text
                OtralaDBDataSet.LoginInfo(LoginIndex)("PhoneNumber") = LblProfilePhoneNumber.Text

                UserInfoTableAdapter.Update(OtralaDBDataSet)
                LoginInfoTableAdapter.Update(OtralaDBDataSet)
            ElseIf UserInput = MsgBoxResult.No Then

                Editing = False
                BtnEdit.Text = "Edit Profile"
            End If

            Me.FormLoad()
            LoadUserInfo()

        End If

    End Sub
    Private Sub LoadUserInfo()
        If Not IsNothing(User.Picture) Then
            PbProfile.Image = User.Picture
        End If
        LblProfileName.Text = User.Name
        LblProfileAddress.Text = User.Address
        LblProfileAge.Text = User.Age
        LblProfileGender.Text = User.Gender
        LblProfileCountry.Text = User.nationality
        LblProfileEmail.Text = User.Email
        LblProfilePhoneNumber.Text = User.PhoneNumber
        LblProfileIcNum.Text = User.ICNum
        LblProfileBirthday.Text = Convert.ToDateTime(User.Birthday).ToString("D")
        LblProfilePassword.Text = "********"

        If User.LoggedIn Then
            LblName.Text = User.Name
        End If
    End Sub

    Private Sub EditPic() Handles PbProfile.DoubleClick
        If Not Editing Then
            Exit Sub
        End If
        Dim OpenPhoto As New OpenFileDialog

        OpenPhoto.Filter = ("Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png")

        OpenPhoto.ShowDialog()

        If OpenPhoto.FileNames.Count = 1 Then
            PbProfile.Image = Image.FromFile(OpenPhoto.FileName)
        End If
    End Sub
    Private Sub EditValue(sender, e) Handles LblProfileName.DoubleClick, LblProfileAge.DoubleClick, LblProfileGender.DoubleClick, LblProfileEmail.DoubleClick, LblProfilePhoneNumber.DoubleClick, LblProfileBirthday.DoubleClick, LblProfileCountry.DoubleClick, LblProfilePassword.DoubleClick, LblProfileIcNum.DoubleClick, LblProfileAddress.DoubleClick
        If Not Editing Then
            Exit Sub
        End If

        If sender.Name = "LblProfileEmail" OrElse sender.Name = "LblProfilePhoneNumber" OrElse sender.name = "LblProfilePassword" OrElse sender.Name = "LblProfileIcNum" Then
            Dim CheckPass As Boolean = ConfirmPass(OtralaDBDataSet.LoginInfo)

            If Not CheckPass Then
                MsgBox("Incorrect Password")
                Exit Sub
            End If
        End If

        Dim EditProfileForm As New Prompt
        EditProfileForm.Initialize(sender)
        EditProfileForm.ShowDialog()

        Dim Result As String = EditProfileForm.Result

        If sender.Name = "LblProfileEmail" And IsEmailOrPhone(Result) <> "Email" Then
            MsgBox("Please enter a valid Email")
            Exit Sub
        End If

        If (sender.Name = "LblProfilePhoneNumber" OrElse sender.Name = "LblProfileAge" OrElse sender.Name = "LblProfileIcNum") And IsEmailOrPhone(Result) <> "Phone" Then
            MsgBox("Please enter a valid Value")
            Exit Sub
        End If

        If sender.name = "LblProfilePassword" Then
            PassPendingChange = True
            NewPass = Result
        Else
            sender.Text = Result
        End If
    End Sub



    ' log out 
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs)

        Dim reply As MsgBoxResult = MsgBox("Thank you For Using Otrala" + Environment.NewLine +
                                           "See you When we 'Travel Lagi'", MsgBoxStyle.OkCancel, "Exit")
        If reply = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub

    Private Sub UserSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OtralaDBDataSet.SellerApplication' table. You can move, or remove it, as needed.
        Me.SellerApplicationTableAdapter.Fill(Me.OtralaDBDataSet.SellerApplication)
    End Sub


    Private Sub DenyClosing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        If Editing Then
            MsgBox("Please update your profile first")
            e.Cancel = True
        End If
    End Sub

    Private Sub CloseAll(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub btnSwitchAccount_Click(sender As Object, e As EventArgs) Handles btnSwitchAccount.Click
        If MsgBox("Confirm Switch Account?", MsgBoxStyle.OkCancel, "Switch Account") = MsgBoxResult.Cancel Then
            Exit Sub
        End If
        User.LogOut()
        Me.ToCatalogue()
        Me.ToUserSettings()
        FormLoad()
    End Sub
End Class
