Public Class Admin

    Private Sub Open_As_Child(f As Form)
        For Each form In Me.MdiChildren
            If form IsNot f Then
                form.Close()
            End If
        Next
        Dim child As Form = f
        child.MdiParent = Me
        child.Show()
        child.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BookingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookingToolStripMenuItem.Click
        Open_As_Child(BookingAdmin)
    End Sub

    Private Sub PackageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PackageToolStripMenuItem.Click
        Open_As_Child(PackageAdmin)
    End Sub

    Private Sub LoginInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginInfoToolStripMenuItem.Click
        Open_As_Child(LoginInfoAdmin)
    End Sub

    Private Sub UserInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserInfoToolStripMenuItem.Click
        Open_As_Child(UserInfoAdmin)
    End Sub

    Private Sub RequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestToolStripMenuItem.Click
        Open_As_Child(RequestAdmin)
    End Sub

    Private Sub RequestAnswerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestAnswerToolStripMenuItem.Click
        Open_As_Child(RequestAnswerAdmin)
    End Sub

    Private Sub FeedbackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeedbackToolStripMenuItem.Click
        Open_As_Child(FeedbackAdmin)
    End Sub

    Private Sub SellerApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SellerApplicationToolStripMenuItem.Click
        Open_As_Child(SellerApplicationAdmin)
    End Sub

    Private Sub FeedbackReviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeedbackReviewToolStripMenuItem.Click
        Open_As_Child(FeedbackReview)
    End Sub

    Private Sub SellerApprovalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SellerApprovalToolStripMenuItem.Click
        Open_As_Child(Seller_Approval)
    End Sub
End Class