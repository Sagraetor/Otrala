Public Class Request
    Dim IsViewingHistory As Boolean = False
    Dim Price(1) As Decimal

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
            TbPrice1.Text = Price.ToString("c")
        ElseIf sender.Name = "TbPrice2" Then
            Price(1) = CDec(TbPrice2.Text)
            TbPrice1.Text = Price.ToString("c")
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

        OtralaDBDataSet.Request.AddRequestRow(NewRequest)

        RequestTableAdapter.Update(Me.OtralaDBDataSet)

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
        Me.RequestTableAdapter.Fill(Me.OtralaDBDataSet.Request)

        DtpPlanned.MinDate = DateTime.Now


    End Sub

    Private Sub ViewHistory() Handles BtnHistory.Click
        IsViewingHistory = True

        PnlHistory.Enabled = True
        PnlHistory.Visible = True
        PnlHistory.Focus()

        BtnHistory.Enabled = False

        Dim Index As Integer = 0
        Dim dy As Integer = 112
        Dim HistoryFeedback() As DataRow = OtralaDBDataSet.Feedback.Select("UserID = " & User.UserID)

        If HistoryFeedback.Count > 4 Then
            PnlHistory.Size = New System.Drawing.Size(486, 467)
        Else
            PnlHistory.Size = New System.Drawing.Size(470, 467)
        End If

        For Each FeedbackRow In HistoryFeedback
            Dim NewLblDate As New Label
            With NewLblDate
                .Location = New System.Drawing.Point(325, 41)
                .Name = "FHLblDate" & Index
                .Size = New System.Drawing.Size(100, 54)
                .TabIndex = 0
                .Text = "Submitted " & FeedbackRow("DateSent")
            End With

            Dim NewLblDesc As New Label
            With NewLblDesc
                .BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                .Location = New System.Drawing.Point(6, 27)
                .Name = "FHLblDesc" & Index
                .Size = New System.Drawing.Size(313, 69)
                .TabIndex = 0
                .Text = FeedbackRow("Description")
            End With

            Dim NewGrpBox As New GroupBox
            With NewGrpBox
                .BackColor = System.Drawing.Color.White
                .Controls.Add(NewLblDate)
                .Controls.Add(NewLblDesc)
                .Location = New System.Drawing.Point(12, 9)
                .Name = "FHGrpBox" & Index
                .Size = New System.Drawing.Size(441, 106)
                .TabIndex = 0
                .TabStop = False
                .Text = FeedbackRow("Title")
            End With

            PnlHistory.Controls.Add(NewGrpBox)

            NewGrpBox.Top += (dy * Index)

            Index += 1
        Next

    End Sub
    Private Sub CloseHistory(sender As Object, e As EventArgs) Handles PnlHistory.LostFocus, Me.Click
        If sender.Name = "Feedback" And IsViewingHistory Then
            PnlHistory.Enabled = False
            PnlHistory.Visible = False
            BtnHistory.Enabled = True
            BtnHistory.Focus()
        ElseIf sender.Name = "PnlHistory" Then
            PnlHistory.Enabled = False
            PnlHistory.Visible = False
            BtnHistory.Enabled = True
            BtnHistory.Focus()
        End If
    End Sub

End Class
