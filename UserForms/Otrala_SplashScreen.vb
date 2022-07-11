Public Class Otrala_SplashScreen

    Dim i As Integer

    Private Sub Otrala_SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Copyright.Text = My.Application.Info.Copyright
        Title.Text = ""
        SubTitle1.Text = ""
        SubTitle2.Visible = False
        Subtitle3.Visible = False
    End Sub

    Private Async Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        i += 1
        PictureBox1.Location = New System.Drawing.Point(PictureBox1.Location.X + 1, PictureBox1.Location.Y)
        If i >= 230 Then
            Timer1.Enabled = False
            Catalogue.Show()
            Me.Hide()
        ElseIf i >= 130 Then
            Title.Text = "OTRALA"
            Subtitle3.Visible = True
        ElseIf i >= 100 Then
            Title.Text = "OTRA"
            SubTitle2.Visible = True
        ElseIf i >= 70 Then
            Title.Text = "O"
            SubTitle1.Text = "Oh"
        End If
    End Sub

End Class