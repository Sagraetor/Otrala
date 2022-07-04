<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Request
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Request))
        Me.TbNotes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.PnlHistory = New System.Windows.Forms.Panel()
        Me.BtnHistory = New System.Windows.Forms.Button()
        Me.OtralaDBDataSet = New Otrala_2._0.OtralaDBDataSet()
        Me.CbState = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DtpPlanned = New System.Windows.Forms.DateTimePicker()
        Me.TbPrice1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbPrice2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbDuration = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TbPax = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RequestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequestTableAdapter = New Otrala_2._0.OtralaDBDataSetTableAdapters.RequestTableAdapter()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PnlHistory.SuspendLayout()
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TbNotes
        '
        Me.TbNotes.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TbNotes.Location = New System.Drawing.Point(220, 375)
        Me.TbNotes.Multiline = True
        Me.TbNotes.Name = "TbNotes"
        Me.TbNotes.Size = New System.Drawing.Size(705, 199)
        Me.TbNotes.TabIndex = 12
        Me.TbNotes.Text = "Additional Notes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(208, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(424, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Not finding the right package? Request for one!"
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(762, 601)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(163, 34)
        Me.BtnSubmit.TabIndex = 15
        Me.BtnSubmit.Text = "Submit Request"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'PnlHistory
        '
        Me.PnlHistory.AutoScroll = True
        Me.PnlHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.PnlHistory.Controls.Add(Me.Label11)
        Me.PnlHistory.Location = New System.Drawing.Point(977, 139)
        Me.PnlHistory.Name = "PnlHistory"
        Me.PnlHistory.Size = New System.Drawing.Size(285, 534)
        Me.PnlHistory.TabIndex = 22
        '
        'BtnHistory
        '
        Me.BtnHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHistory.Location = New System.Drawing.Point(0, 110)
        Me.BtnHistory.Name = "BtnHistory"
        Me.BtnHistory.Size = New System.Drawing.Size(186, 50)
        Me.BtnHistory.TabIndex = 23
        Me.BtnHistory.Text = "Feedback History"
        Me.BtnHistory.UseVisualStyleBackColor = False
        '
        'OtralaDBDataSet
        '
        Me.OtralaDBDataSet.DataSetName = "OtralaDBDataSet"
        Me.OtralaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CbState
        '
        Me.CbState.AutoCompleteCustomSource.AddRange(New String() {"Johor", "Kedah", "Kelantan", "Melaka", "Negeri Sembilan", "Pahang", "Penang", "Perak", "Perlis", "Sabah", "Sarawak", "Selangor", "Terengganu", "Kuala Lumpur", "Putrajaya"})
        Me.CbState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CbState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.CbState.FormattingEnabled = True
        Me.CbState.Items.AddRange(New Object() {"Johor", "Kedah", "Kelantan", "Melaka", "Negeri Sembilan", "Pahang", "Penang", "Perak", "Perlis", "Sabah", "Sarawak", "Selangor", "Terengganu", "Kuala Lumpur", "Putrajaya"})
        Me.CbState.Location = New System.Drawing.Point(736, 330)
        Me.CbState.Name = "CbState"
        Me.CbState.Size = New System.Drawing.Size(189, 31)
        Me.CbState.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(663, 333)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 23)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "State :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(220, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 23)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Planned Date :"
        '
        'DtpPlanned
        '
        Me.DtpPlanned.Location = New System.Drawing.Point(366, 268)
        Me.DtpPlanned.MinDate = New Date(2022, 7, 5, 0, 0, 0, 0)
        Me.DtpPlanned.Name = "DtpPlanned"
        Me.DtpPlanned.Size = New System.Drawing.Size(342, 30)
        Me.DtpPlanned.TabIndex = 26
        '
        'TbPrice1
        '
        Me.TbPrice1.Location = New System.Drawing.Point(219, 214)
        Me.TbPrice1.Name = "TbPrice1"
        Me.TbPrice1.Size = New System.Drawing.Size(152, 30)
        Me.TbPrice1.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(218, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 23)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Price range :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(377, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 23)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "To"
        '
        'TbPrice2
        '
        Me.TbPrice2.Location = New System.Drawing.Point(414, 214)
        Me.TbPrice2.Name = "TbPrice2"
        Me.TbPrice2.Size = New System.Drawing.Size(152, 30)
        Me.TbPrice2.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(397, 333)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 23)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Duration :"
        '
        'TbDuration
        '
        Me.TbDuration.Location = New System.Drawing.Point(498, 330)
        Me.TbDuration.Name = "TbDuration"
        Me.TbDuration.Size = New System.Drawing.Size(152, 30)
        Me.TbDuration.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(220, 333)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 23)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Pax :"
        '
        'TbPax
        '
        Me.TbPax.Location = New System.Drawing.Point(281, 330)
        Me.TbPax.Name = "TbPax"
        Me.TbPax.Size = New System.Drawing.Size(110, 30)
        Me.TbPax.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(413, 356)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 16)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "(In Days)"
        '
        'RequestBindingSource
        '
        Me.RequestBindingSource.DataMember = "Request"
        Me.RequestBindingSource.DataSource = Me.OtralaDBDataSet
        '
        'RequestTableAdapter
        '
        Me.RequestTableAdapter.ClearBeforeFill = True
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(3, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(282, 52)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Your custom offers will appear here."
        '
        'Request
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TbPrice2)
        Me.Controls.Add(Me.TbPax)
        Me.Controls.Add(Me.TbDuration)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TbPrice1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DtpPlanned)
        Me.Controls.Add(Me.CbState)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnHistory)
        Me.Controls.Add(Me.PnlHistory)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbNotes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Request"
        Me.Controls.SetChildIndex(Me.TbNotes, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.BtnSubmit, 0)
        Me.Controls.SetChildIndex(Me.PnlHistory, 0)
        Me.Controls.SetChildIndex(Me.BtnHistory, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.CbState, 0)
        Me.Controls.SetChildIndex(Me.DtpPlanned, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.TbPrice1, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.TbDuration, 0)
        Me.Controls.SetChildIndex(Me.TbPax, 0)
        Me.Controls.SetChildIndex(Me.TbPrice2, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.PnlHistory.ResumeLayout(False)
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TbNotes As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents OtralaDBDataSet As OtralaDBDataSet
    Friend WithEvents PnlHistory As Panel
    Friend WithEvents BtnHistory As Button
    Friend WithEvents CbState As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DtpPlanned As DateTimePicker
    Friend WithEvents TbPrice1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TbPrice2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TbDuration As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TbPax As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents RequestBindingSource As BindingSource
    Friend WithEvents RequestTableAdapter As OtralaDBDataSetTableAdapters.RequestTableAdapter
    Friend WithEvents Label11 As Label
End Class
