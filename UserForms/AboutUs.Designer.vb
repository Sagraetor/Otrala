<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AboutUs
    Inherits BaseForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutUs))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxDescription = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LblProductName = New System.Windows.Forms.Label()
        Me.LblVersion = New System.Windows.Forms.Label()
        Me.LblCompanyName = New System.Windows.Forms.Label()
        Me.LblCopyright = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Image = Global.Otrala_2._0.My.Resources.Resources.Otrala_About_Us
        Me.PictureBox2.Location = New System.Drawing.Point(208, 133)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(373, 228)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(588, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 52)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "OTRALA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(810, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(440, 60)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "OTRALA is a travel booking app that allows customers to request" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  their own idea" &
    " package, which our system will then recommend " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "           the finest travel ag" &
    "ency option for them to choose."
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.Location = New System.Drawing.Point(208, 379)
        Me.TextBoxDescription.Margin = New System.Windows.Forms.Padding(8, 4, 4, 4)
        Me.TextBoxDescription.Multiline = True
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.ReadOnly = True
        Me.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxDescription.Size = New System.Drawing.Size(1041, 281)
        Me.TextBoxDescription.TabIndex = 17
        Me.TextBoxDescription.TabStop = False
        Me.TextBoxDescription.Text = resources.GetString("TextBoxDescription.Text")
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LblProductName, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LblVersion, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LblCompanyName, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LblCopyright, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(597, 188)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.47475!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.52525!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(652, 184)
        Me.TableLayoutPanel1.TabIndex = 18
        '
        'LblProductName
        '
        Me.LblProductName.AutoSize = True
        Me.LblProductName.Location = New System.Drawing.Point(3, 0)
        Me.LblProductName.Name = "LblProductName"
        Me.LblProductName.Size = New System.Drawing.Size(135, 23)
        Me.LblProductName.TabIndex = 0
        Me.LblProductName.Text = "Product Name"
        '
        'LblVersion
        '
        Me.LblVersion.AutoSize = True
        Me.LblVersion.Location = New System.Drawing.Point(3, 45)
        Me.LblVersion.Name = "LblVersion"
        Me.LblVersion.Size = New System.Drawing.Size(75, 23)
        Me.LblVersion.TabIndex = 0
        Me.LblVersion.Text = "Version"
        '
        'LblCompanyName
        '
        Me.LblCompanyName.AutoSize = True
        Me.LblCompanyName.Location = New System.Drawing.Point(3, 145)
        Me.LblCompanyName.Name = "LblCompanyName"
        Me.LblCompanyName.Size = New System.Drawing.Size(150, 23)
        Me.LblCompanyName.TabIndex = 0
        Me.LblCompanyName.Text = "Company Name"
        '
        'LblCopyright
        '
        Me.LblCopyright.AutoSize = True
        Me.LblCopyright.Location = New System.Drawing.Point(3, 94)
        Me.LblCopyright.Name = "LblCopyright"
        Me.LblCopyright.Size = New System.Drawing.Size(94, 23)
        Me.LblCopyright.TabIndex = 0
        Me.LblCopyright.Text = "Copyright"
        '
        'AboutUs
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TextBoxDescription)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AboutUs"
        Me.Controls.SetChildIndex(Me.PictureBox2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TextBoxDescription, 0)
        Me.Controls.SetChildIndex(Me.TableLayoutPanel1, 0)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxDescription As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LblProductName As Label
    Friend WithEvents LblVersion As Label
    Friend WithEvents LblCompanyName As Label
    Friend WithEvents LblCopyright As Label
End Class
