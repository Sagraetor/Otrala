<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Otrala_SplashScreen
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
        Me.components = New System.ComponentModel.Container()
        Me.Copyright = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Version = New System.Windows.Forms.Label()
        Me.SubTitle1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SubTitle2 = New System.Windows.Forms.Label()
        Me.Subtitle3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Copyright
        '
        Me.Copyright.AutoSize = True
        Me.Copyright.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copyright.ForeColor = System.Drawing.Color.White
        Me.Copyright.Location = New System.Drawing.Point(170, 122)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(80, 24)
        Me.Copyright.TabIndex = 0
        Me.Copyright.Text = "Copyright"
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.White
        Me.Title.Location = New System.Drawing.Point(158, 9)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(368, 93)
        Me.Title.TabIndex = 1
        Me.Title.Text = "OTRALA"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Otrala_2._0.My.Resources.Resources.Otrala_Icon
        Me.PictureBox1.Location = New System.Drawing.Point(12, 149)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(199, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Version
        '
        Me.Version.AutoSize = True
        Me.Version.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.ForeColor = System.Drawing.Color.White
        Me.Version.Location = New System.Drawing.Point(170, 98)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(106, 24)
        Me.Version.TabIndex = 3
        Me.Version.Text = "Version 1.0.0"
        '
        'SubTitle1
        '
        Me.SubTitle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SubTitle1.Font = New System.Drawing.Font("Arial", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTitle1.ForeColor = System.Drawing.Color.White
        Me.SubTitle1.Location = New System.Drawing.Point(15, 9)
        Me.SubTitle1.Name = "SubTitle1"
        Me.SubTitle1.Size = New System.Drawing.Size(137, 137)
        Me.SubTitle1.TabIndex = 4
        Me.SubTitle1.Text = "Oh"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'SubTitle2
        '
        Me.SubTitle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SubTitle2.Font = New System.Drawing.Font("Arial", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTitle2.ForeColor = System.Drawing.Color.White
        Me.SubTitle2.Location = New System.Drawing.Point(15, 53)
        Me.SubTitle2.Name = "SubTitle2"
        Me.SubTitle2.Size = New System.Drawing.Size(137, 49)
        Me.SubTitle2.TabIndex = 5
        Me.SubTitle2.Text = "Travel"
        '
        'Subtitle3
        '
        Me.Subtitle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Subtitle3.Font = New System.Drawing.Font("Arial", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subtitle3.ForeColor = System.Drawing.Color.White
        Me.Subtitle3.Location = New System.Drawing.Point(15, 98)
        Me.Subtitle3.Name = "Subtitle3"
        Me.Subtitle3.Size = New System.Drawing.Size(137, 49)
        Me.Subtitle3.TabIndex = 6
        Me.Subtitle3.Text = "Lagi"
        '
        'Otrala_SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(538, 293)
        Me.Controls.Add(Me.Subtitle3)
        Me.Controls.Add(Me.SubTitle2)
        Me.Controls.Add(Me.SubTitle1)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Copyright)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Otrala_SplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Otrala_SplashScreen"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Copyright As Label
    Friend WithEvents Title As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Version As Label
    Friend WithEvents SubTitle1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SubTitle2 As Label
    Friend WithEvents Subtitle3 As Label
End Class
