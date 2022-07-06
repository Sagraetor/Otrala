Public Class Feedback
    Dim IsViewingHistory As Boolean = False
    Private Sub RemoveDefaultText(Sender As TextBox, e As EventArgs) Handles TbDescription.GotFocus, TbTitle.GotFocus
        If Sender.Name = "TbDescription" And TbDescription.Text = "Description" Then
            TbDescription.Clear()
            TbDescription.ForeColor = System.Drawing.SystemColors.WindowText
        ElseIf Sender.Name = "TbTitle" And TbTitle.Text = "Title" Then
            TbTitle.Clear()
            TbTitle.ForeColor = System.Drawing.SystemColors.WindowText
        End If
    End Sub

    Private Sub ToDefaultText(Sender As TextBox, e As EventArgs) Handles TbDescription.LostFocus, TbTitle.LostFocus
        TbDescription.Text = TbDescription.Text.TrimEnd(CChar(" "))
        TbTitle.Text = TbTitle.Text.TrimEnd(CChar(" "))

        If Sender.Name = "TbDescription" And TbDescription.Text = "" Then
            TbDescription.Text = "Description"
            TbDescription.ForeColor = System.Drawing.SystemColors.GrayText
        ElseIf Sender.Name = "TbTitle" And TbTitle.Text = "" Then
            TbTitle.Text = "Title"
            TbTitle.ForeColor = System.Drawing.SystemColors.GrayText
        End If
    End Sub
    Private Sub Submit() Handles BtnSubmit.Click
        If CBType.Text = "" OrElse TbTitle.Text = "" Then
            MsgBox("Error")
            Exit Sub
        End If

        Dim NewFeedback As DataRow = OtralaDBDataSet.Feedback.NewFeedbackRow

        NewFeedback("Title") = TbTitle.Text
        NewFeedback("Description") = TbDescription.Text
        NewFeedback("UserID") = User.UserID
        NewFeedback("Type") = CBType.Text
        NewFeedback("DateSent") = DateTime.Today.ToString("d")

        OtralaDBDataSet.Feedback.AddFeedbackRow(NewFeedback)

        FeedbackTableAdapter1.Update(Me.OtralaDBDataSet)

        Dim another_feedback As MsgBoxResult = MsgBox("Feedback submitted successfully! Thank you!" & System.Environment.NewLine & "Submit Another Ticket?", MsgBoxStyle.YesNo, "Thank you")

        If another_feedback = MsgBoxResult.Yes Then
            CBType.Text = ""
            TbTitle.Text = ""
            TbDescription.Text = ""
        Else
            Me.ToCatalogue()
        End If

        Me.FeedbackTableAdapter1.Fill(Me.OtralaDBDataSet.Feedback)
    End Sub

    Private Sub Feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OtralaDBDataSet.LoginInfo' table. You can move, or remove it, as needed.
        Me.FeedbackTableAdapter1.Fill(Me.OtralaDBDataSet.Feedback)
    End Sub

    Private Sub ViewHistory() Handles BtnHistory.Click
        IsViewingHistory = True

        PnlHistory.Enabled = True
        PnlHistory.Visible = True
        PnlHistory.Focus()
        PnlHistory.Controls.Clear()

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
                .Location = New System.Drawing.Point(325, 58)
                .Name = "FHLblDate" & Index
                .Size = New System.Drawing.Size(100, 45)
                .TabIndex = 0
                .Text = "Submitted " & FeedbackRow("DateSent")
            End With

            Dim NewLblDesc As New Label
            With NewLblDesc
                .ForeColor = System.Drawing.Color.White
                .Location = New System.Drawing.Point(6, 27)
                .Name = "FHLblDesc" & Index
                .Size = New System.Drawing.Size(313, 69)
                .TabIndex = 0
                .Text = FeedbackRow("Description")
            End With

            Dim NewDataIndex As New Label
            With NewDataIndex
                .Visible = False
                .Text = FeedbackRow("FeedbackID")
            End With

            Dim NewGrpBox As New GroupBox
            With NewGrpBox
                .ForeColor = System.Drawing.Color.White
                .Controls.Add(NewLblDate)
                .Controls.Add(NewLblDesc)
                .Controls.Add(NewDataIndex)
                .Location = New System.Drawing.Point(12, 9)
                .Name = "FHGrpBox" & Index
                .Size = New System.Drawing.Size(441, 106)
                .TabIndex = 0
                .TabStop = False
                .Text = FeedbackRow("Title")
            End With

            AddHandler NewGrpBox.Click, AddressOf show_feedback_details
            AddHandler NewLblDate.Click, AddressOf show_feedback_details
            AddHandler NewLblDesc.Click, AddressOf show_feedback_details

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

    Sub show_feedback_details(sender As Object, e As EventArgs)

        If TypeOf sender IsNot GroupBox Then
            sender = sender.Parent
        End If

        Dim feedback_id As String = sender.Controls(2).Text

        Dim view As New Feedback_Viewer
        view.FeedbackID = feedback_id
        view.ShowDialog()

    End Sub

    Private Sub CloseAll(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub

End Class
