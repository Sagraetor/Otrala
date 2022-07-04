<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BaseForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BaseForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.BtnFeedback = New System.Windows.Forms.Button()
        Me.LblName = New System.Windows.Forms.Label()
        Me.AddPackageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddFeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddLoginInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddRequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AddItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddLoginInfoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddRequestToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PbOtralaIcon = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PbOtralaIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1262, 110)
        Me.Label1.TabIndex = 0
        '
        'SearchBox
        '
        Me.SearchBox.Location = New System.Drawing.Point(227, 37)
        Me.SearchBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(484, 30)
        Me.SearchBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Location = New System.Drawing.Point(0, 110)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 563)
        Me.Label2.TabIndex = 3
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Location = New System.Drawing.Point(0, 623)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(186, 50)
        Me.btnLogOut.TabIndex = 7
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'BtnFeedback
        '
        Me.BtnFeedback.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFeedback.Location = New System.Drawing.Point(0, 567)
        Me.BtnFeedback.Name = "BtnFeedback"
        Me.BtnFeedback.Size = New System.Drawing.Size(186, 50)
        Me.BtnFeedback.TabIndex = 9
        Me.BtnFeedback.Text = "Feedbacks"
        Me.BtnFeedback.UseVisualStyleBackColor = False
        '
        'LblName
        '
        Me.LblName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.LblName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.ForeColor = System.Drawing.Color.White
        Me.LblName.Location = New System.Drawing.Point(836, 40)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(358, 23)
        Me.LblName.TabIndex = 11
        Me.LblName.Text = "Log In / Sign Up"
        Me.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AddPackageToolStripMenuItem
        '
        Me.AddPackageToolStripMenuItem.Name = "AddPackageToolStripMenuItem"
        Me.AddPackageToolStripMenuItem.Size = New System.Drawing.Size(177, 24)
        Me.AddPackageToolStripMenuItem.Text = "Add Package"
        '
        'AddFeedbackToolStripMenuItem
        '
        Me.AddFeedbackToolStripMenuItem.Name = "AddFeedbackToolStripMenuItem"
        Me.AddFeedbackToolStripMenuItem.Size = New System.Drawing.Size(177, 24)
        Me.AddFeedbackToolStripMenuItem.Text = "Add Feedback"
        '
        'AddLoginInfoToolStripMenuItem
        '
        Me.AddLoginInfoToolStripMenuItem.Name = "AddLoginInfoToolStripMenuItem"
        Me.AddLoginInfoToolStripMenuItem.Size = New System.Drawing.Size(177, 24)
        Me.AddLoginInfoToolStripMenuItem.Text = "Add Login Info"
        '
        'RequestToolStripMenuItem
        '
        Me.RequestToolStripMenuItem.Name = "RequestToolStripMenuItem"
        Me.RequestToolStripMenuItem.Size = New System.Drawing.Size(177, 24)
        Me.RequestToolStripMenuItem.Text = "Add User Info"
        '
        'AddRequestToolStripMenuItem
        '
        Me.AddRequestToolStripMenuItem.Name = "AddRequestToolStripMenuItem"
        Me.AddRequestToolStripMenuItem.Size = New System.Drawing.Size(177, 24)
        Me.AddRequestToolStripMenuItem.Text = "Add Request"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(764, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(186, 32)
        Me.Panel1.TabIndex = 12
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddItemsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(186, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddItemsToolStripMenuItem
        '
        Me.AddItemsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.AddToolStripMenuItem1, Me.AddLoginInfoToolStripMenuItem1, Me.AddUserInfoToolStripMenuItem, Me.AddRequestToolStripMenuItem1})
        Me.AddItemsToolStripMenuItem.Name = "AddItemsToolStripMenuItem"
        Me.AddItemsToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.AddItemsToolStripMenuItem.Text = "Database Items"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(191, 26)
        Me.AddToolStripMenuItem.Text = "Add Package"
        '
        'AddToolStripMenuItem1
        '
        Me.AddToolStripMenuItem1.Name = "AddToolStripMenuItem1"
        Me.AddToolStripMenuItem1.Size = New System.Drawing.Size(191, 26)
        Me.AddToolStripMenuItem1.Text = "Add Feedback"
        '
        'AddLoginInfoToolStripMenuItem1
        '
        Me.AddLoginInfoToolStripMenuItem1.Name = "AddLoginInfoToolStripMenuItem1"
        Me.AddLoginInfoToolStripMenuItem1.Size = New System.Drawing.Size(191, 26)
        Me.AddLoginInfoToolStripMenuItem1.Text = "Add Login Info"
        '
        'AddUserInfoToolStripMenuItem
        '
        Me.AddUserInfoToolStripMenuItem.Name = "AddUserInfoToolStripMenuItem"
        Me.AddUserInfoToolStripMenuItem.Size = New System.Drawing.Size(191, 26)
        Me.AddUserInfoToolStripMenuItem.Text = "Add User Info"
        '
        'AddRequestToolStripMenuItem1
        '
        Me.AddRequestToolStripMenuItem1.Name = "AddRequestToolStripMenuItem1"
        Me.AddRequestToolStripMenuItem1.Size = New System.Drawing.Size(191, 26)
        Me.AddRequestToolStripMenuItem1.Text = "Add Request"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(0, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 50)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Recommendation"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PbOtralaIcon
        '
        Me.PbOtralaIcon.BackColor = System.Drawing.Color.Transparent
        Me.PbOtralaIcon.Image = Global.Otrala_2._0.My.Resources.Resources.Otrala_Icon
        Me.PbOtralaIcon.Location = New System.Drawing.Point(22, 12)
        Me.PbOtralaIcon.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PbOtralaIcon.Name = "PbOtralaIcon"
        Me.PbOtralaIcon.Size = New System.Drawing.Size(140, 91)
        Me.PbOtralaIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbOtralaIcon.TabIndex = 1
        Me.PbOtralaIcon.TabStop = False
        '
        'BaseForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.BtnFeedback)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SearchBox)
        Me.Controls.Add(Me.PbOtralaIcon)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "BaseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Otrala"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PbOtralaIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PbOtralaIcon As PictureBox
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogOut As Button
    Friend WithEvents BtnFeedback As Button
    Friend WithEvents LblName As Label
    Friend WithEvents PackageBindingSource As BindingSource
    Friend WithEvents PackageBindingSource1 As BindingSource
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AddPackageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddFeedbackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddLoginInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RequestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddRequestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AddItemsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AddLoginInfoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AddUserInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddRequestToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Button1 As Button
End Class
