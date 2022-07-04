<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Search
    Inherits _0.BaseForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboPrice = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboPax = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboDuration = New System.Windows.Forms.ComboBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.PackageTableAdapter = New Otrala_2._0.OtralaDBDataSetTableAdapters.PackageTableAdapter()
        Me.OtralaDBDataSet = New Otrala_2._0.OtralaDBDataSet()
        Me.PackageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PnlCatalogue = New System.Windows.Forms.Panel()
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PackageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboState
        '
        Me.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboState.FormattingEnabled = True
        Me.cboState.Items.AddRange(New Object() {"<Select State>", "Johor", "Labuan", "Kedah", "Kelantan", "Kuala Lumpur", "Malacca", "Negeri Sembilan", "Pahang", "Penang", "Perak", "Perlis", "Putrajaya", "Sabah", "Sarawak", "Selangor", "Terengganu"})
        Me.cboState.Location = New System.Drawing.Point(343, 129)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(205, 31)
        Me.cboState.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(241, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 23)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "State:"
        '
        'cboPrice
        '
        Me.cboPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPrice.FormattingEnabled = True
        Me.cboPrice.Items.AddRange(New Object() {"<Select Price Range>", "Below 500", "500 - 1000", "1000 - 1500", "1500 - 2000", "2000 - 2500", "Above 2500"})
        Me.cboPrice.Location = New System.Drawing.Point(343, 197)
        Me.cboPrice.Name = "cboPrice"
        Me.cboPrice.Size = New System.Drawing.Size(205, 31)
        Me.cboPrice.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(241, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 23)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Price:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(675, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 23)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Pax:"
        '
        'cboPax
        '
        Me.cboPax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPax.FormattingEnabled = True
        Me.cboPax.Items.AddRange(New Object() {"<Select Pax>", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10+"})
        Me.cboPax.Location = New System.Drawing.Point(800, 129)
        Me.cboPax.Name = "cboPax"
        Me.cboPax.Size = New System.Drawing.Size(205, 31)
        Me.cboPax.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(675, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 23)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Duration:"
        '
        'cboDuration
        '
        Me.cboDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDuration.FormattingEnabled = True
        Me.cboDuration.Items.AddRange(New Object() {"<Select Duration>", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10+"})
        Me.cboDuration.Location = New System.Drawing.Point(800, 197)
        Me.cboDuration.Name = "cboDuration"
        Me.cboDuration.Size = New System.Drawing.Size(205, 31)
        Me.cboDuration.TabIndex = 20
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SearchButton.BackgroundImage = Global.Otrala_2._0.My.Resources.Resources.Search_Icon
        Me.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SearchButton.Location = New System.Drawing.Point(1094, 132)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(100, 100)
        Me.SearchButton.TabIndex = 21
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'PackageTableAdapter
        '
        Me.PackageTableAdapter.ClearBeforeFill = True
        '
        'OtralaDBDataSet
        '
        Me.OtralaDBDataSet.DataSetName = "OtralaDBDataSet"
        Me.OtralaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PackageBindingSource
        '
        Me.PackageBindingSource.DataMember = "Package"
        Me.PackageBindingSource.DataSource = Me.OtralaDBDataSet
        '
        'PnlCatalogue
        '
        Me.PnlCatalogue.AutoScroll = True
        Me.PnlCatalogue.Location = New System.Drawing.Point(185, 242)
        Me.PnlCatalogue.Name = "PnlCatalogue"
        Me.PnlCatalogue.Size = New System.Drawing.Size(1077, 430)
        Me.PnlCatalogue.TabIndex = 22
        '
        'Search
        '
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.PnlCatalogue)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.cboDuration)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboPax)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboState)
        Me.Name = "Search"
        Me.Controls.SetChildIndex(Me.cboState, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.cboPrice, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.cboPax, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.cboDuration, 0)
        Me.Controls.SetChildIndex(Me.SearchButton, 0)
        Me.Controls.SetChildIndex(Me.PnlCatalogue, 0)
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PackageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboState As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboPrice As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboPax As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboDuration As ComboBox
    Friend WithEvents SearchButton As Button
    Friend WithEvents PackageTableAdapter As OtralaDBDataSetTableAdapters.PackageTableAdapter
    Friend WithEvents OtralaDBDataSet As OtralaDBDataSet
    Friend WithEvents PackageBindingSource As BindingSource
    Friend WithEvents PnlCatalogue As Panel
End Class
