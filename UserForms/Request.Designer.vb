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
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.PnlOffers = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
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
        Me.RequestAnswerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequestAnswerTableAdapter = New Otrala_2._0.OtralaDBDataSetTableAdapters.RequestAnswerTableAdapter()
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookingTableAdapter = New Otrala_2._0.OtralaDBDataSetTableAdapters.BookingTableAdapter()
        Me.PnlOffers.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequestAnswerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'lblInfo
        '
        Me.lblInfo.Location = New System.Drawing.Point(208, 124)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(717, 55)
        Me.lblInfo.TabIndex = 13
        Me.lblInfo.Text = "Not finding the right package? Request for one!"
        '
        'BtnSubmit
        '
        Me.BtnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnSubmit.ForeColor = System.Drawing.Color.White
        Me.BtnSubmit.Location = New System.Drawing.Point(751, 594)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(174, 41)
        Me.BtnSubmit.TabIndex = 15
        Me.BtnSubmit.Text = "Submit Request"
        Me.BtnSubmit.UseVisualStyleBackColor = False
        '
        'PnlOffers
        '
        Me.PnlOffers.AutoScroll = True
        Me.PnlOffers.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.PnlOffers.Controls.Add(Me.GroupBox1)
        Me.PnlOffers.Controls.Add(Me.Label11)
        Me.PnlOffers.Location = New System.Drawing.Point(979, 139)
        Me.PnlOffers.Name = "PnlOffers"
        Me.PnlOffers.Size = New System.Drawing.Size(309, 534)
        Me.PnlOffers.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(7, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(266, 226)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "From Irfan Haziq n Co"
        Me.GroupBox1.Visible = False
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(6, 164)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(209, 53)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Starting On Thursday, 11/7/2022"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 121)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(149, 23)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "5 Days 4 Nights"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 23)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "5 persons"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 23)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "RM 5000"
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
        'RequestAnswerBindingSource
        '
        Me.RequestAnswerBindingSource.DataMember = "RequestAnswer"
        Me.RequestAnswerBindingSource.DataSource = Me.OtralaDBDataSet
        '
        'RequestAnswerTableAdapter
        '
        Me.RequestAnswerTableAdapter.ClearBeforeFill = True
        '
        'BookingBindingSource
        '
        Me.BookingBindingSource.DataMember = "Booking"
        Me.BookingBindingSource.DataSource = Me.OtralaDBDataSet
        '
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
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
        Me.Controls.Add(Me.PnlOffers)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.TbNotes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Request"
        Me.Controls.SetChildIndex(Me.TbNotes, 0)
        Me.Controls.SetChildIndex(Me.lblInfo, 0)
        Me.Controls.SetChildIndex(Me.BtnSubmit, 0)
        Me.Controls.SetChildIndex(Me.PnlOffers, 0)
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
        Me.PnlOffers.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequestAnswerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TbNotes As TextBox
    Friend WithEvents lblInfo As Label
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents OtralaDBDataSet As OtralaDBDataSet
    Friend WithEvents PnlOffers As Panel
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents RequestAnswerBindingSource As BindingSource
    Friend WithEvents RequestAnswerTableAdapter As OtralaDBDataSetTableAdapters.RequestAnswerTableAdapter
    Friend WithEvents BookingBindingSource As BindingSource
    Friend WithEvents BookingTableAdapter As OtralaDBDataSetTableAdapters.BookingTableAdapter
End Class
