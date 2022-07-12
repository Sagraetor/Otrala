Public Class Request
    Dim Price(1) As Decimal
    Dim MyRequestID As Integer
    Dim LstOfferID As New List(Of Integer)
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

    Private Sub RemoveDefaultText(Sender As TextBox, e As EventArgs) Handles TbNotes.GotFocus
        If TbNotes.Text = "Additional Notes" Then
            TbNotes.Clear()
            TbNotes.ForeColor = System.Drawing.SystemColors.WindowText
        End If
    End Sub

    Private Sub ToDefaultText(Sender As TextBox, e As EventArgs) Handles TbNotes.LostFocus
        TbNotes.Text = TbNotes.Text.TrimEnd(CChar(" "))

        If TbNotes.Text = "" Then
            TbNotes.Text = "Additional Notes"
            TbNotes.ForeColor = System.Drawing.SystemColors.GrayText
        End If
    End Sub
    Private Sub ForceState() Handles CbState.LostFocus
        If Not CbState.Items.Contains(CbState.Text) Then
            CbState.Text = ""
        End If
    End Sub

    Private Sub ForceNumber(sender As Object, e As EventArgs) Handles TbPax.LostFocus, TbPrice1.LostFocus, TbDuration.LostFocus, TbPrice2.LostFocus
        If sender.text = "" Then
            Exit Sub
        End If

        If Not IsNumeric(sender.text) Then
            MsgBox("Please enter a proper number")
            sender.text = ""
            Exit Sub
        End If

        If sender.Name = "TbPrice1" Then
            Price(0) = CDec(TbPrice1.Text)
            TbPrice1.Text = Price(0).ToString("c")
        ElseIf sender.Name = "TbPrice2" Then
            Price(1) = CDec(TbPrice2.Text)
            TbPrice2.Text = Price(1).ToString("c")
        End If
    End Sub
    Private Sub ClickOffer(Sender As Object, e As EventArgs)
        Dim NewPrompt As New RequestPrompt

        Dim Ans As Integer = NewPrompt.ShowDialog

        If Ans = 3 Then
            Exit Sub
        End If

        Dim OfferIndex As Integer = GetIndex(Sender.Name)
        Dim OfferRow As DataRow = OtralaDBDataSet.RequestAnswer.Select("RequestAnswerID = " & LstOfferID(OfferIndex))(0)
        Dim OfferRowIndex As Integer = OtralaDBDataSet.RequestAnswer.Rows.IndexOf(OfferRow)

        If Ans = 7 Then
            OtralaDBDataSet.RequestAnswer.Rows(OfferRowIndex).Delete()
        ElseIf Ans = 6 Then
            OtralaDBDataSet.RequestAnswer.Rows(OfferRowIndex)("Accepted") = DateAndTime.Now.ToString("d")

            'Dim NewBookingRow As DataRow = OtralaDBDataSet.Booking.NewBookingRow

            'NewBookingRow("RequestAnswerID") = OfferRow("RequestAnswerID")
            'NewBookingRow("UserID") = User.UserID
            'NewBookingRow("DateBooked") = DateTime.Today.ToString("d")
            'NewBookingRow("Quantity") = 1
            ''NewBookingRow("CardName") = txtCardName.Text
            ''NewBookingRow("CardNumber") = mskCardNum.Text
            'NewBookingRow("PlannedDate") = OfferRow("TripDate")
            'NewBookingRow("SellerFulfilled") = ""
            'NewBookingRow("ClientFulfilled") = ""
            'NewBookingRow("TotalPrice") = OfferRow("Price")

            'OtralaDBDataSet.Booking.AddBookingRow(NewBookingRow)
            'BookingTableAdapter.Update(OtralaDBDataSet)
        End If

        RequestAnswerTableAdapter.Update(OtralaDBDataSet)

        Me.FormLoad()
    End Sub
    Private Sub Remove() Handles BtnSubmit.Click
        If BtnSubmit.Text <> "Cancel Request" Then
            Exit Sub
        End If

        Dim ToDelete As DataRow = OtralaDBDataSet.Request.Select(String.Format("UserID = '{0}' AND Fulfilled = False", User.UserID))(0)
        Dim IndexToDelete As Integer = OtralaDBDataSet.Request.Rows.IndexOf(ToDelete)

        OtralaDBDataSet.Request.Rows(IndexToDelete).Delete()

        RequestTableAdapter.Update(OtralaDBDataSet)

        Me.FormLoad()
    End Sub

    Private Sub Submit() Handles BtnSubmit.Click
        If BtnSubmit.Text <> "Submit Request" Then
            Exit Sub
        End If

        If CbState.Text = "" OrElse TbPax.Text = "" OrElse TbDuration.Text = "" OrElse (TbPrice1.Text = "" And TbPrice2.Text = "") Then
            MsgBox("Please fill in all information", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Dim NewRequest As DataRow = OtralaDBDataSet.Request.NewRequestRow

        NewRequest("UserID") = User.UserID
        NewRequest("Location") = CbState.Text
        NewRequest("Price") = Price(0) & " - " & Price(1)
        NewRequest("Duration") = TbDuration.Text
        NewRequest("Pax") = TbPax.Text
        NewRequest("Notes") = TbNotes.Text
        NewRequest("PlannedDate") = DtpPlanned.Value.ToString("d")
        NewRequest("Fulfilled") = False

        OtralaDBDataSet.Request.AddRequestRow(NewRequest)

        RequestTableAdapter.Update(Me.OtralaDBDataSet)

        MsgBox("Request Submitted! You will be notified" & Environment.NewLine & "when a seller makes you an offer!")

        Me.FormLoad()
    End Sub

    Overrides Sub AddFormLoad()
        'TODO: This line of code loads data into the 'OtralaDBDataSet.LoginInfo' table. You can move, or remove it, as needed.
        Me.RequestAnswerTableAdapter.Fill(Me.OtralaDBDataSet.RequestAnswer)
        Me.RequestTableAdapter.Fill(Me.OtralaDBDataSet.Request)

        DtpPlanned.MinDate = DateTime.Now

        Dim MyRequests As DataRow() = OtralaDBDataSet.Request.Select(String.Format("UserID = '{0}' AND Fulfilled = False", User.UserID))

        If MyRequests.Count <> 0 Then
            TbDuration.ReadOnly = True
            TbNotes.ReadOnly = True
            TbPax.ReadOnly = True
            TbPrice1.ReadOnly = True
            TbPrice2.ReadOnly = True
            CbState.Enabled = False
            DtpPlanned.Enabled = False

            Dim MyRequest = MyRequests(0)

            TbDuration.Text = MyRequest("Duration")
            TbNotes.Text = MyRequest("Notes")
            TbPax.Text = MyRequest("Pax")
            CbState.Text = MyRequest("Location")

            DtpPlanned.MinDate = Convert.ToDateTime(MyRequest("PlannedDate")).AddDays(-10)
            DtpPlanned.Value = Convert.ToDateTime(MyRequest("PlannedDate"))

            Dim StrPrice As String = MyRequest("Price")
            Dim ArrayStrPrice() As String = StrPrice.Split("-")


            For i = 0 To 1

                If ArrayStrPrice(i) = "0" Then
                    Continue For
                End If
                Price(i) = CDec(ArrayStrPrice(i))
            Next

            TbPrice1.Text = Price(0).ToString("c")
            TbPrice2.Text = Price(1).ToString("c")

            MyRequestID = MyRequest("RequestID")

            lblInfo.Text = "This is your current request. You can click any offers to accept them or cancel your current request to make a new one"

            BtnSubmit.Text = "Cancel Request"

            ViewOffers()
        Else
            TbDuration.ReadOnly = False
            TbNotes.ReadOnly = False
            TbPax.ReadOnly = False
            TbPrice1.ReadOnly = False
            TbPrice2.ReadOnly = False
            CbState.Enabled = True
            DtpPlanned.Enabled = True

            TbDuration.Clear()
            TbNotes.Text = "Additional Notes"
            TbPax.Clear()
            TbPrice1.Clear()
            TbPrice2.Clear()
            CbState.Text = ""

            lblInfo.Text = "Not finding the right package? Request for one!"
            BtnSubmit.Text = "Submit Request"
        End If
    End Sub

    Private Sub ViewOffers()
        Dim Index As Integer = 0
        Dim dy As Integer = 232

        PnlOffers.Controls.Clear()

        Dim RequestAnswer() As DataRow = OtralaDBDataSet.RequestAnswer.Select("RequestID = " & MyRequestID)

        If RequestAnswer.Count > 2 Then
            PnlOffers.Location = New System.Drawing.Point(953, 139)
        Else
            PnlOffers.Location = New System.Drawing.Point(979, 139)
        End If

        For Each OfferRow In RequestAnswer
            Dim NewLblPrice As New Label
            With NewLblPrice
                .Location = New System.Drawing.Point(6, 40)
                .Name = "OffersLblPrice" & Index
                .AutoSize = True
                .TabIndex = 0
                .Text = Val(OfferRow("Price")).ToString("C")
            End With

            Dim NewLblPax As New Label
            With NewLblPax
                .Location = New System.Drawing.Point(6, 80)
                .Name = "OfferLblPax" & Index
                .AutoSize = True
                .TabIndex = 0
                .Text = OfferRow("Pax") & "People"
            End With

            Dim NewLblDuration As New Label
            With NewLblDuration
                .Location = New System.Drawing.Point(6, 121)
                .Name = "OfferLblDuration" & Index
                .AutoSize = True
                .TabIndex = 0
                If OfferRow("Duration") > 2 Then
                    .Text = OfferRow("Duration") & " DAYS " & System.Environment.NewLine & CInt(OfferRow("Duration")) - 1 & " NIGHTS"
                ElseIf OfferRow("Duration") > 1 Then
                    .Text = OfferRow("Duration") & " DAYS " & System.Environment.NewLine & CInt(OfferRow("Duration")) - 1 & " NIGHT"
                Else
                    .Text = OfferRow("Duration") & " DAY "
                End If
            End With

            Dim NewLblDate As New Label
            With NewLblDate
                .Location = New System.Drawing.Point(6, 164)
                .Name = "OfferLblDate" & Index
                .Size = New System.Drawing.Size(209, 53)
                .TabIndex = 0
                .Text = "Starting On " + Convert.ToDateTime(OfferRow("TripDate")).ToString("dddd, dd/MM/yyyy")
            End With

            Dim NewGrpBox As New GroupBox
            With NewGrpBox
                .ForeColor = System.Drawing.Color.White
                .Controls.Add(NewLblDate)
                .Controls.Add(NewLblDuration)
                .Controls.Add(NewLblPax)
                .Controls.Add(NewLblPrice)
                .Location = New System.Drawing.Point(7, 7)
                .Name = "OfferGrpBox" & Index
                .Size = New System.Drawing.Size(266, 226)
                .TabIndex = 0
                .TabStop = False
                .Text = "From " & OfferRow("SellerName")
            End With

            PnlOffers.Controls.Add(NewGrpBox)

            NewGrpBox.Top += (dy * Index)

            Index += 1

            AddHandler NewLblDate.Click, AddressOf ClickOffer
            AddHandler NewLblDuration.Click, AddressOf ClickOffer
            AddHandler NewLblPax.Click, AddressOf ClickOffer
            AddHandler NewLblPrice.Click, AddressOf ClickOffer
            AddHandler NewGrpBox.Click, AddressOf ClickOffer
            LstOfferID.Add(OfferRow("RequestAnswerID"))
        Next
    End Sub

    Private Sub CloseAll(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub Request_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OtralaDBDataSet.Booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me.OtralaDBDataSet.Booking)

    End Sub
End Class
