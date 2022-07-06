<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ApplySeller
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ApplySeller))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblCommand = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.BtnUpload = New System.Windows.Forms.Button()
        Me.PicBoxSubmission = New System.Windows.Forms.PictureBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PicBoxSubmission, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.LblCommand)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnCancel)
        Me.Panel1.Controls.Add(Me.BtnSubmit)
        Me.Panel1.Controls.Add(Me.BtnUpload)
        Me.Panel1.Controls.Add(Me.PicBoxSubmission)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(15, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(633, 481)
        Me.Panel1.TabIndex = 0
        '
        'LblCommand
        '
        Me.LblCommand.AutoSize = True
        Me.LblCommand.Location = New System.Drawing.Point(18, 107)
        Me.LblCommand.Name = "LblCommand"
        Me.LblCommand.Size = New System.Drawing.Size(204, 23)
        Me.LblCommand.TabIndex = 1
        Me.LblCommand.Text = "Please upload your IC"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(407, 92)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "To apply to be a seller. You must upload your IC and any document that can act as" &
    " a proof of business to be reviewed by an Admin"
        '
        'BtnSubmit
        '
        Me.BtnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnSubmit.ForeColor = System.Drawing.Color.White
        Me.BtnSubmit.Location = New System.Drawing.Point(418, 72)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(188, 43)
        Me.BtnSubmit.TabIndex = 3
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = False
        '
        'BtnUpload
        '
        Me.BtnUpload.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnUpload.ForeColor = System.Drawing.Color.White
        Me.BtnUpload.Location = New System.Drawing.Point(418, 23)
        Me.BtnUpload.Name = "BtnUpload"
        Me.BtnUpload.Size = New System.Drawing.Size(188, 43)
        Me.BtnUpload.TabIndex = 3
        Me.BtnUpload.Text = "Upload IC"
        Me.BtnUpload.UseVisualStyleBackColor = False
        '
        'PicBoxSubmission
        '
        Me.PicBoxSubmission.Location = New System.Drawing.Point(22, 133)
        Me.PicBoxSubmission.Name = "PicBoxSubmission"
        Me.PicBoxSubmission.Size = New System.Drawing.Size(584, 283)
        Me.PicBoxSubmission.TabIndex = 2
        Me.PicBoxSubmission.TabStop = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(22, 422)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(188, 43)
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'ApplySeller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(663, 511)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ApplySeller"
        Me.Padding = New System.Windows.Forms.Padding(15)
        Me.Text = "Otrala"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PicBoxSubmission, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PicBoxSubmission As PictureBox
    Friend WithEvents LblCommand As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnUpload As Button
    Friend WithEvents BtnCancel As Button
End Class
