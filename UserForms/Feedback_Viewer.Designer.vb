<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Feedback_Viewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Feedback_Viewer))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.FeedbackTableAdapter1 = New Otrala_2._0.OtralaDBDataSetTableAdapters.FeedbackTableAdapter()
        Me.OtralaDBDataSet = New Otrala_2._0.OtralaDBDataSet()
        Me.UserInfoTableAdapter1 = New Otrala_2._0.OtralaDBDataSetTableAdapters.UserInfoTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.lblType)
        Me.Panel1.Controls.Add(Me.lblUser)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(14, 14)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(541, 372)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.lblDescription)
        Me.Panel2.Location = New System.Drawing.Point(13, 93)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(520, 266)
        Me.Panel2.TabIndex = 5
        '
        'lblDescription
        '
        Me.lblDescription.AllowDrop = True
        Me.lblDescription.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(3, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(514, 266)
        Me.lblDescription.TabIndex = 1
        Me.lblDescription.Text = "<Description>"
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(277, 49)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(256, 22)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "From : <Date>"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblType
        '
        Me.lblType.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(9, 49)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(260, 29)
        Me.lblType.TabIndex = 3
        Me.lblType.Text = "Feedback Type : <FeedbackType>"
        '
        'lblUser
        '
        Me.lblUser.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(277, 10)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(256, 22)
        Me.lblUser.TabIndex = 2
        Me.lblUser.Text = "From : <User>"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(8, 5)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(69, 27)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "<Title>"
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
        'UserInfoTableAdapter1
        '
        Me.UserInfoTableAdapter1.ClearBeforeFill = True
        '
        'Feedback_Viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(569, 400)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Feedback_Viewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Feedback_Viewer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents FeedbackTableAdapter1 As OtralaDBDataSetTableAdapters.FeedbackTableAdapter
    Friend WithEvents OtralaDBDataSet As OtralaDBDataSet
    Friend WithEvents UserInfoTableAdapter1 As OtralaDBDataSetTableAdapters.UserInfoTableAdapter
    Friend WithEvents Panel2 As Panel
End Class
