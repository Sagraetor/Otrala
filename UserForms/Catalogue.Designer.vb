﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Catalogue
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Catalogue))
        Me.GroupBoxObsolete2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBoxObsolete1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblDuration = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PnlCatalogue = New System.Windows.Forms.Panel()
        Me.PackageGrid = New System.Windows.Forms.DataGridView()
        Me.PackageIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SellerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PackageNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DestinationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DurationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PackageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OtralaDBDataSet = New Otrala_2._0.OtralaDBDataSet()
        Me.PackageTableAdapter = New Otrala_2._0.OtralaDBDataSetTableAdapters.PackageTableAdapter()
        Me.GroupBoxObsolete2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxObsolete1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlCatalogue.SuspendLayout()
        CType(Me.PackageGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PackageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxObsolete2
        '
        Me.GroupBoxObsolete2.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBoxObsolete2.Controls.Add(Me.Label10)
        Me.GroupBoxObsolete2.Controls.Add(Me.Label11)
        Me.GroupBoxObsolete2.Controls.Add(Me.Label12)
        Me.GroupBoxObsolete2.Controls.Add(Me.Label13)
        Me.GroupBoxObsolete2.Controls.Add(Me.Label14)
        Me.GroupBoxObsolete2.Controls.Add(Me.Label15)
        Me.GroupBoxObsolete2.Controls.Add(Me.PictureBox3)
        Me.GroupBoxObsolete2.Enabled = False
        Me.GroupBoxObsolete2.Location = New System.Drawing.Point(563, 56)
        Me.GroupBoxObsolete2.Name = "GroupBoxObsolete2"
        Me.GroupBoxObsolete2.Size = New System.Drawing.Size(435, 306)
        Me.GroupBoxObsolete2.TabIndex = 12
        Me.GroupBoxObsolete2.TabStop = False
        Me.GroupBoxObsolete2.Visible = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.Font = New System.Drawing.Font("Arial", 10.2!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label10.Location = New System.Drawing.Point(175, 280)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(254, 23)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Irfan Haziq and CO"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(175, 151)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(236, 117)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Desc Goes Here"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(175, 77)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 59)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "5 NIGHTS 4 DAYS"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(17, 244)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(242, 24)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "5 Person"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(17, 210)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(242, 24)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "RM1000.00"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(175, 29)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(236, 48)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Trip to KUALA LUMPUR"
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(17, 29)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(140, 140)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'GroupBoxObsolete1
        '
        Me.GroupBoxObsolete1.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBoxObsolete1.Controls.Add(Me.Label8)
        Me.GroupBoxObsolete1.Controls.Add(Me.Label9)
        Me.GroupBoxObsolete1.Controls.Add(Me.LblDuration)
        Me.GroupBoxObsolete1.Controls.Add(Me.Label6)
        Me.GroupBoxObsolete1.Controls.Add(Me.Label5)
        Me.GroupBoxObsolete1.Controls.Add(Me.Label3)
        Me.GroupBoxObsolete1.Controls.Add(Me.PictureBox2)
        Me.GroupBoxObsolete1.Enabled = False
        Me.GroupBoxObsolete1.Location = New System.Drawing.Point(58, 56)
        Me.GroupBoxObsolete1.Name = "GroupBoxObsolete1"
        Me.GroupBoxObsolete1.Size = New System.Drawing.Size(435, 306)
        Me.GroupBoxObsolete1.TabIndex = 12
        Me.GroupBoxObsolete1.TabStop = False
        Me.GroupBoxObsolete1.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Window
        Me.Label8.Font = New System.Drawing.Font("Arial", 10.2!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label8.Location = New System.Drawing.Point(175, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(254, 23)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Irfan Haziq and CO"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(175, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(236, 117)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Desc Goes Here"
        '
        'LblDuration
        '
        Me.LblDuration.Location = New System.Drawing.Point(175, 77)
        Me.LblDuration.Name = "LblDuration"
        Me.LblDuration.Size = New System.Drawing.Size(107, 59)
        Me.LblDuration.TabIndex = 13
        Me.LblDuration.Text = "5 NIGHTS 4 DAYS"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(17, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 24)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "5 Person"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(17, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 24)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "RM1000.00"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(175, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(236, 48)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Trip to KUALA LUMPUR"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(17, 29)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(140, 140)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PnlCatalogue
        '
        Me.PnlCatalogue.AutoScroll = True
        Me.PnlCatalogue.Controls.Add(Me.PackageGrid)
        Me.PnlCatalogue.Controls.Add(Me.GroupBoxObsolete1)
        Me.PnlCatalogue.Controls.Add(Me.GroupBoxObsolete2)
        Me.PnlCatalogue.Location = New System.Drawing.Point(186, 110)
        Me.PnlCatalogue.Name = "PnlCatalogue"
        Me.PnlCatalogue.Size = New System.Drawing.Size(1076, 563)
        Me.PnlCatalogue.TabIndex = 13
        '
        'PackageGrid
        '
        Me.PackageGrid.AutoGenerateColumns = False
        Me.PackageGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PackageGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PackageIDDataGridViewTextBoxColumn, Me.SellerIDDataGridViewTextBoxColumn, Me.PackageNameDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.DestinationDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.PaxDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.PictureDataGridViewImageColumn, Me.DurationDataGridViewTextBoxColumn})
        Me.PackageGrid.DataSource = Me.PackageBindingSource
        Me.PackageGrid.Location = New System.Drawing.Point(3, 3)
        Me.PackageGrid.Name = "PackageGrid"
        Me.PackageGrid.RowHeadersWidth = 51
        Me.PackageGrid.RowTemplate.Height = 24
        Me.PackageGrid.Size = New System.Drawing.Size(776, 150)
        Me.PackageGrid.TabIndex = 13
        Me.PackageGrid.Visible = False
        '
        'PackageIDDataGridViewTextBoxColumn
        '
        Me.PackageIDDataGridViewTextBoxColumn.DataPropertyName = "PackageID"
        Me.PackageIDDataGridViewTextBoxColumn.HeaderText = "PackageID"
        Me.PackageIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PackageIDDataGridViewTextBoxColumn.Name = "PackageIDDataGridViewTextBoxColumn"
        Me.PackageIDDataGridViewTextBoxColumn.Width = 125
        '
        'SellerIDDataGridViewTextBoxColumn
        '
        Me.SellerIDDataGridViewTextBoxColumn.DataPropertyName = "SellerID"
        Me.SellerIDDataGridViewTextBoxColumn.HeaderText = "SellerID"
        Me.SellerIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SellerIDDataGridViewTextBoxColumn.Name = "SellerIDDataGridViewTextBoxColumn"
        Me.SellerIDDataGridViewTextBoxColumn.Width = 125
        '
        'PackageNameDataGridViewTextBoxColumn
        '
        Me.PackageNameDataGridViewTextBoxColumn.DataPropertyName = "PackageName"
        Me.PackageNameDataGridViewTextBoxColumn.HeaderText = "PackageName"
        Me.PackageNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PackageNameDataGridViewTextBoxColumn.Name = "PackageNameDataGridViewTextBoxColumn"
        Me.PackageNameDataGridViewTextBoxColumn.Width = 125
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        Me.StateDataGridViewTextBoxColumn.Width = 125
        '
        'DestinationDataGridViewTextBoxColumn
        '
        Me.DestinationDataGridViewTextBoxColumn.DataPropertyName = "Destination"
        Me.DestinationDataGridViewTextBoxColumn.HeaderText = "Destination"
        Me.DestinationDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DestinationDataGridViewTextBoxColumn.Name = "DestinationDataGridViewTextBoxColumn"
        Me.DestinationDataGridViewTextBoxColumn.Width = 125
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.Width = 125
        '
        'PaxDataGridViewTextBoxColumn
        '
        Me.PaxDataGridViewTextBoxColumn.DataPropertyName = "Pax"
        Me.PaxDataGridViewTextBoxColumn.HeaderText = "Pax"
        Me.PaxDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PaxDataGridViewTextBoxColumn.Name = "PaxDataGridViewTextBoxColumn"
        Me.PaxDataGridViewTextBoxColumn.Width = 125
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.Width = 125
        '
        'PictureDataGridViewImageColumn
        '
        Me.PictureDataGridViewImageColumn.DataPropertyName = "Picture"
        Me.PictureDataGridViewImageColumn.HeaderText = "Picture"
        Me.PictureDataGridViewImageColumn.MinimumWidth = 6
        Me.PictureDataGridViewImageColumn.Name = "PictureDataGridViewImageColumn"
        Me.PictureDataGridViewImageColumn.Width = 125
        '
        'DurationDataGridViewTextBoxColumn
        '
        Me.DurationDataGridViewTextBoxColumn.DataPropertyName = "Duration"
        Me.DurationDataGridViewTextBoxColumn.HeaderText = "Duration"
        Me.DurationDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DurationDataGridViewTextBoxColumn.Name = "DurationDataGridViewTextBoxColumn"
        Me.DurationDataGridViewTextBoxColumn.Width = 125
        '
        'PackageBindingSource
        '
        Me.PackageBindingSource.DataMember = "Package"
        Me.PackageBindingSource.DataSource = Me.OtralaDBDataSet
        '
        'OtralaDBDataSet
        '
        Me.OtralaDBDataSet.DataSetName = "OtralaDBDataSet"
        Me.OtralaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PackageTableAdapter
        '
        Me.PackageTableAdapter.ClearBeforeFill = True
        '
        'Catalogue
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.PnlCatalogue)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "Catalogue"
        Me.Controls.SetChildIndex(Me.PnlCatalogue, 0)
        Me.GroupBoxObsolete2.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxObsolete1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlCatalogue.ResumeLayout(False)
        CType(Me.PackageGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PackageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxObsolete2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents GroupBoxObsolete1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LblDuration As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PnlCatalogue As Panel
    Friend WithEvents PackageGrid As DataGridView
    Friend WithEvents OtralaDBDataSet As OtralaDBDataSet
    Friend WithEvents PackageBindingSource As BindingSource
    Friend WithEvents PackageTableAdapter As OtralaDBDataSetTableAdapters.PackageTableAdapter
    Friend WithEvents PackageIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SellerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PackageNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DestinationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaxDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents DurationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
