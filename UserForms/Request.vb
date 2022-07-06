Public Class Request
    Dim Price(1) As Decimal
    Dim MyRequestID As Integer

    Private Sub RemoveDefaultText(Sender As TextBox, e As EventArgs) Handles TbNotes.GotFocus
        If Sender.Name = "TbNotes" And TbNotes.Text = "Additional Notes" Then
            TbNotes.Clear()
            TbNotes.ForeColor = System.Drawing.SystemColors.WindowText
        End If
    End Sub

    Private Sub ToDefaultText(Sender As TextBox, e As EventArgs) Handles TbNotes.LostFocus
        TbNotes.Text = TbNotes.Text.TrimEnd(CChar(" "))

        If Sender.Name = "TbNotes" And TbNotes.Text = "" Then
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

    Private Sub Submit() Handles BtnSubmit.Click
        If CbState.Text = "" OrElse TbPax.Text = "" OrElse TbDuration.Text = "" OrElse (TbPrice1.Text = "" And TbPrice2.Text = "") Then
            MsgBox("Error")
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
        'Dim another_feedback As MsgBoxResult = MsgBox("Feedback submitted successfully! Thank you!" & System.Environment.NewLine & "Submit Another Ticket?", MsgBoxStyle.YesNo, "Thank you")

        'If another_feedback = MsgBoxResult.Yes Then
        '    CBType.Text = ""
        '    TbTitle.Text = ""
        '    TbNotes.Text = ""
        'Else
        '    Catalogue.Show()
        '    Me.Hide()
        'End If
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

            ViewOffers()
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
        Next
    End Sub

End Class
