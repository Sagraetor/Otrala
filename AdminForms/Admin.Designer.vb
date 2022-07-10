<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PackageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestAnswerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SellerApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SellerApprovalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeedbackReviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatabaseToolStripMenuItem, Me.SellerApprovalToolStripMenuItem, Me.FeedbackReviewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1262, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookingToolStripMenuItem, Me.PackageToolStripMenuItem, Me.LoginInfoToolStripMenuItem, Me.UserInfoToolStripMenuItem, Me.RequestToolStripMenuItem, Me.RequestAnswerToolStripMenuItem, Me.FeedbackToolStripMenuItem, Me.SellerApplicationToolStripMenuItem})
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(86, 24)
        Me.DatabaseToolStripMenuItem.Text = "Database"
        '
        'BookingToolStripMenuItem
        '
        Me.BookingToolStripMenuItem.Name = "BookingToolStripMenuItem"
        Me.BookingToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.BookingToolStripMenuItem.Text = "Booking"
        '
        'PackageToolStripMenuItem
        '
        Me.PackageToolStripMenuItem.Name = "PackageToolStripMenuItem"
        Me.PackageToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.PackageToolStripMenuItem.Text = "Package"
        '
        'LoginInfoToolStripMenuItem
        '
        Me.LoginInfoToolStripMenuItem.Name = "LoginInfoToolStripMenuItem"
        Me.LoginInfoToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.LoginInfoToolStripMenuItem.Text = "Login Info"
        '
        'UserInfoToolStripMenuItem
        '
        Me.UserInfoToolStripMenuItem.Name = "UserInfoToolStripMenuItem"
        Me.UserInfoToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.UserInfoToolStripMenuItem.Text = "User Info"
        '
        'RequestToolStripMenuItem
        '
        Me.RequestToolStripMenuItem.Name = "RequestToolStripMenuItem"
        Me.RequestToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.RequestToolStripMenuItem.Text = "Request"
        '
        'RequestAnswerToolStripMenuItem
        '
        Me.RequestAnswerToolStripMenuItem.Name = "RequestAnswerToolStripMenuItem"
        Me.RequestAnswerToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.RequestAnswerToolStripMenuItem.Text = "Request Answer"
        '
        'FeedbackToolStripMenuItem
        '
        Me.FeedbackToolStripMenuItem.Name = "FeedbackToolStripMenuItem"
        Me.FeedbackToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.FeedbackToolStripMenuItem.Text = "Feedback"
        '
        'SellerApplicationToolStripMenuItem
        '
        Me.SellerApplicationToolStripMenuItem.Name = "SellerApplicationToolStripMenuItem"
        Me.SellerApplicationToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.SellerApplicationToolStripMenuItem.Text = "Seller Application"
        '
        'SellerApprovalToolStripMenuItem
        '
        Me.SellerApprovalToolStripMenuItem.Name = "SellerApprovalToolStripMenuItem"
        Me.SellerApprovalToolStripMenuItem.Size = New System.Drawing.Size(125, 24)
        Me.SellerApprovalToolStripMenuItem.Text = "Seller Approval"
        '
        'FeedbackReviewToolStripMenuItem
        '
        Me.FeedbackReviewToolStripMenuItem.Name = "FeedbackReviewToolStripMenuItem"
        Me.FeedbackReviewToolStripMenuItem.Size = New System.Drawing.Size(139, 24)
        Me.FeedbackReviewToolStripMenuItem.Text = "Feedback/Review"
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1262, 733)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PackageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RequestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RequestAnswerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FeedbackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SellerApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SellerApprovalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FeedbackReviewToolStripMenuItem As ToolStripMenuItem
End Class
