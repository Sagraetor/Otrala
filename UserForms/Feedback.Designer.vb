<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Feedback
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Feedback))
        Me.TbDescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.CBType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbTitle = New System.Windows.Forms.TextBox()
        Me.PnlHistory = New System.Windows.Forms.Panel()
        Me.BtnHistory = New System.Windows.Forms.Button()
        Me.FeedbackTableAdapter1 = New Otrala_2._0.OtralaDBDataSetTableAdapters.FeedbackTableAdapter()
        Me.OtralaDBDataSet = New Otrala_2._0.OtralaDBDataSet()
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TbDescription
        '
        Me.TbDescription.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TbDescription.Location = New System.Drawing.Point(259, 302)
        Me.TbDescription.Multiline = True
        Me.TbDescription.Name = "TbDescription"
        Me.TbDescription.Size = New System.Drawing.Size(778, 279)
        Me.TbDescription.TabIndex = 12
        Me.TbDescription.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(255, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(378, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Otrala would love to hear your feedbacks."
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(924, 612)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(112, 34)
        Me.BtnSubmit.TabIndex = 15
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'CBType
        '
        Me.CBType.FormattingEnabled = True
        Me.CBType.Items.AddRange(New Object() {"Request", "Question", "Problem"})
        Me.CBType.Location = New System.Drawing.Point(891, 265)
        Me.CBType.Name = "CBType"
        Me.CBType.Size = New System.Drawing.Size(146, 31)
        Me.CBType.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(826, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 23)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Type:"
        '
        'TbTitle
        '
        Me.TbTitle.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TbTitle.Location = New System.Drawing.Point(259, 265)
        Me.TbTitle.Name = "TbTitle"
        Me.TbTitle.Size = New System.Drawing.Size(551, 30)
        Me.TbTitle.TabIndex = 21
        Me.TbTitle.Text = "Title"
        '
        'PnlHistory
        '
        Me.PnlHistory.AutoScroll = True
        Me.PnlHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.PnlHistory.Enabled = False
        Me.PnlHistory.Location = New System.Drawing.Point(454, 157)
        Me.PnlHistory.Name = "PnlHistory"
        Me.PnlHistory.Size = New System.Drawing.Size(470, 467)
        Me.PnlHistory.TabIndex = 22
        Me.PnlHistory.Visible = False
        '
        'BtnHistory
        '
        Me.BtnHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHistory.Location = New System.Drawing.Point(0, 334)
        Me.BtnHistory.Name = "BtnHistory"
        Me.BtnHistory.Size = New System.Drawing.Size(186, 50)
        Me.BtnHistory.TabIndex = 23
        Me.BtnHistory.Text = "Feedback History"
        Me.BtnHistory.UseVisualStyleBackColor = False
        '
        'FeedbackTableAdapter1
        '
        Me.FeedbackTableAdapter1.ClearBeforeFill = True
        '
        'OtralaDBDataSet
        '
        Me.OtralaDBDataSet.DataSetName = "OtralaDBDataSet"
        Me.OtralaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Feedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.BtnHistory)
        Me.Controls.Add(Me.PnlHistory)
        Me.Controls.Add(Me.TbTitle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBType)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbDescription)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Feedback"
        Me.Controls.SetChildIndex(Me.TbDescription, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.BtnSubmit, 0)
        Me.Controls.SetChildIndex(Me.CBType, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TbTitle, 0)
        Me.Controls.SetChildIndex(Me.PnlHistory, 0)
        Me.Controls.SetChildIndex(Me.BtnHistory, 0)
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TbDescription As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents CBType As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TbTitle As TextBox
    Friend WithEvents FeedbackTableAdapter1 As OtralaDBDataSetTableAdapters.FeedbackTableAdapter
    Friend WithEvents OtralaDBDataSet As OtralaDBDataSet
    Friend WithEvents PnlHistory As Panel
    Friend WithEvents BtnHistory As Button
End Class
