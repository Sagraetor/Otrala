<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class temporaryInputFormPackage
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(temporaryInputFormPackage))
        Dim PackageIDLabel As System.Windows.Forms.Label
        Dim PackageNameLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim DestinationLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim PaxLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim DurationLabel As System.Windows.Forms.Label
        Dim SellerNameLabel As System.Windows.Forms.Label
        Dim UserIDLabel As System.Windows.Forms.Label
        Me.OtralaDBDataSet = New Otrala_2._0.OtralaDBDataSet()
        Me.PackageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PackageTableAdapter = New Otrala_2._0.OtralaDBDataSetTableAdapters.PackageTableAdapter()
        Me.TableAdapterManager = New Otrala_2._0.OtralaDBDataSetTableAdapters.TableAdapterManager()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.PackageBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PackageBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Back = New System.Windows.Forms.Button()
        Me.picPackage = New System.Windows.Forms.PictureBox()
        Me.btnAddPic = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PackageDataGridView = New System.Windows.Forms.DataGridView()
        Me.PackageIDTextBox = New System.Windows.Forms.TextBox()
        Me.PackageNameTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.DestinationTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.PaxTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.DurationTextBox = New System.Windows.Forms.TextBox()
        Me.SellerNameTextBox = New System.Windows.Forms.TextBox()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        PackageIDLabel = New System.Windows.Forms.Label()
        PackageNameLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        DestinationLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        PaxLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        DurationLabel = New System.Windows.Forms.Label()
        SellerNameLabel = New System.Windows.Forms.Label()
        UserIDLabel = New System.Windows.Forms.Label()
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PackageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PackageBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PackageBindingNavigator.SuspendLayout()
        CType(Me.picPackage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PackageDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'PackageTableAdapter
        '
        Me.PackageTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FeedbackTableAdapter = Nothing
        Me.TableAdapterManager.LoginInfoTableAdapter = Nothing
        Me.TableAdapterManager.PackageTableAdapter = Me.PackageTableAdapter
        Me.TableAdapterManager.RequestTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Otrala_2._0.OtralaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserInfoTableAdapter = Nothing
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'PackageBindingNavigatorSaveItem
        '
        Me.PackageBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PackageBindingNavigatorSaveItem.Image = CType(resources.GetObject("PackageBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PackageBindingNavigatorSaveItem.Name = "PackageBindingNavigatorSaveItem"
        Me.PackageBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.PackageBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PackageBindingNavigator
        '
        Me.PackageBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PackageBindingNavigator.BindingSource = Me.PackageBindingSource
        Me.PackageBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PackageBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PackageBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.PackageBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PackageBindingNavigatorSaveItem})
        Me.PackageBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PackageBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PackageBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PackageBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PackageBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PackageBindingNavigator.Name = "PackageBindingNavigator"
        Me.PackageBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PackageBindingNavigator.Size = New System.Drawing.Size(1182, 27)
        Me.PackageBindingNavigator.TabIndex = 0
        Me.PackageBindingNavigator.Text = "BindingNavigator1"
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(323, 339)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(75, 23)
        Me.Back.TabIndex = 13
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'picPackage
        '
        Me.picPackage.Cursor = System.Windows.Forms.Cursors.Default
        Me.picPackage.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.PackageBindingSource, "Picture", True))
        Me.picPackage.Location = New System.Drawing.Point(294, 114)
        Me.picPackage.Name = "picPackage"
        Me.picPackage.Size = New System.Drawing.Size(139, 151)
        Me.picPackage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPackage.TabIndex = 11
        Me.picPackage.TabStop = False
        '
        'btnAddPic
        '
        Me.btnAddPic.Location = New System.Drawing.Point(323, 290)
        Me.btnAddPic.Name = "btnAddPic"
        Me.btnAddPic.Size = New System.Drawing.Size(75, 23)
        Me.btnAddPic.TabIndex = 12
        Me.btnAddPic.Text = "Add Picture"
        Me.btnAddPic.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Duration"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Duration"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "Picture"
        Me.DataGridViewImageColumn1.HeaderText = "Picture"
        Me.DataGridViewImageColumn1.MinimumWidth = 6
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Pax"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Pax"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Destination"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Destination"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "State"
        Me.DataGridViewTextBoxColumn4.HeaderText = "State"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PackageName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PackageName"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PackageID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PackageID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'PackageDataGridView
        '
        Me.PackageDataGridView.AutoGenerateColumns = False
        Me.PackageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PackageDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn9})
        Me.PackageDataGridView.DataSource = Me.PackageBindingSource
        Me.PackageDataGridView.Location = New System.Drawing.Point(468, 77)
        Me.PackageDataGridView.Name = "PackageDataGridView"
        Me.PackageDataGridView.RowHeadersWidth = 51
        Me.PackageDataGridView.RowTemplate.Height = 24
        Me.PackageDataGridView.Size = New System.Drawing.Size(672, 332)
        Me.PackageDataGridView.TabIndex = 1
        '
        'PackageIDLabel
        '
        PackageIDLabel.AutoSize = True
        PackageIDLabel.Location = New System.Drawing.Point(56, 117)
        PackageIDLabel.Name = "PackageIDLabel"
        PackageIDLabel.Size = New System.Drawing.Size(81, 16)
        PackageIDLabel.TabIndex = 13
        PackageIDLabel.Text = "Package ID:"
        '
        'PackageIDTextBox
        '
        Me.PackageIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PackageBindingSource, "PackageID", True))
        Me.PackageIDTextBox.Location = New System.Drawing.Point(167, 114)
        Me.PackageIDTextBox.Name = "PackageIDTextBox"
        Me.PackageIDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PackageIDTextBox.TabIndex = 14
        '
        'PackageNameLabel
        '
        PackageNameLabel.AutoSize = True
        PackageNameLabel.Location = New System.Drawing.Point(56, 145)
        PackageNameLabel.Name = "PackageNameLabel"
        PackageNameLabel.Size = New System.Drawing.Size(105, 16)
        PackageNameLabel.TabIndex = 15
        PackageNameLabel.Text = "Package Name:"
        '
        'PackageNameTextBox
        '
        Me.PackageNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PackageBindingSource, "PackageName", True))
        Me.PackageNameTextBox.Location = New System.Drawing.Point(167, 142)
        Me.PackageNameTextBox.Name = "PackageNameTextBox"
        Me.PackageNameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PackageNameTextBox.TabIndex = 16
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(56, 173)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(41, 16)
        StateLabel.TabIndex = 17
        StateLabel.Text = "State:"
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PackageBindingSource, "State", True))
        Me.StateTextBox.Location = New System.Drawing.Point(167, 170)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(100, 22)
        Me.StateTextBox.TabIndex = 18
        '
        'DestinationLabel
        '
        DestinationLabel.AutoSize = True
        DestinationLabel.Location = New System.Drawing.Point(56, 201)
        DestinationLabel.Name = "DestinationLabel"
        DestinationLabel.Size = New System.Drawing.Size(77, 16)
        DestinationLabel.TabIndex = 19
        DestinationLabel.Text = "Destination:"
        '
        'DestinationTextBox
        '
        Me.DestinationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PackageBindingSource, "Destination", True))
        Me.DestinationTextBox.Location = New System.Drawing.Point(167, 198)
        Me.DestinationTextBox.Name = "DestinationTextBox"
        Me.DestinationTextBox.Size = New System.Drawing.Size(100, 22)
        Me.DestinationTextBox.TabIndex = 20
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(56, 229)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(41, 16)
        PriceLabel.TabIndex = 21
        PriceLabel.Text = "Price:"
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PackageBindingSource, "Price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(167, 226)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PriceTextBox.TabIndex = 22
        '
        'PaxLabel
        '
        PaxLabel.AutoSize = True
        PaxLabel.Location = New System.Drawing.Point(56, 257)
        PaxLabel.Name = "PaxLabel"
        PaxLabel.Size = New System.Drawing.Size(33, 16)
        PaxLabel.TabIndex = 23
        PaxLabel.Text = "Pax:"
        '
        'PaxTextBox
        '
        Me.PaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PackageBindingSource, "Pax", True))
        Me.PaxTextBox.Location = New System.Drawing.Point(167, 254)
        Me.PaxTextBox.Name = "PaxTextBox"
        Me.PaxTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PaxTextBox.TabIndex = 24
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(56, 285)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(78, 16)
        DescriptionLabel.TabIndex = 25
        DescriptionLabel.Text = "Description:"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PackageBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(167, 282)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(100, 22)
        Me.DescriptionTextBox.TabIndex = 26
        '
        'DurationLabel
        '
        DurationLabel.AutoSize = True
        DurationLabel.Location = New System.Drawing.Point(56, 313)
        DurationLabel.Name = "DurationLabel"
        DurationLabel.Size = New System.Drawing.Size(60, 16)
        DurationLabel.TabIndex = 27
        DurationLabel.Text = "Duration:"
        '
        'DurationTextBox
        '
        Me.DurationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PackageBindingSource, "Duration", True))
        Me.DurationTextBox.Location = New System.Drawing.Point(167, 310)
        Me.DurationTextBox.Name = "DurationTextBox"
        Me.DurationTextBox.Size = New System.Drawing.Size(100, 22)
        Me.DurationTextBox.TabIndex = 28
        '
        'SellerNameLabel
        '
        SellerNameLabel.AutoSize = True
        SellerNameLabel.Location = New System.Drawing.Point(56, 341)
        SellerNameLabel.Name = "SellerNameLabel"
        SellerNameLabel.Size = New System.Drawing.Size(85, 16)
        SellerNameLabel.TabIndex = 29
        SellerNameLabel.Text = "Seller Name:"
        '
        'SellerNameTextBox
        '
        Me.SellerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PackageBindingSource, "SellerName", True))
        Me.SellerNameTextBox.Location = New System.Drawing.Point(167, 338)
        Me.SellerNameTextBox.Name = "SellerNameTextBox"
        Me.SellerNameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.SellerNameTextBox.TabIndex = 30
        '
        'UserIDLabel
        '
        UserIDLabel.AutoSize = True
        UserIDLabel.Location = New System.Drawing.Point(56, 369)
        UserIDLabel.Name = "UserIDLabel"
        UserIDLabel.Size = New System.Drawing.Size(55, 16)
        UserIDLabel.TabIndex = 31
        UserIDLabel.Text = "User ID:"
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PackageBindingSource, "UserID", True))
        Me.UserIDTextBox.Location = New System.Drawing.Point(167, 366)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.UserIDTextBox.TabIndex = 32
        '
        'temporaryInputFormPackage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 553)
        Me.Controls.Add(PackageIDLabel)
        Me.Controls.Add(Me.PackageIDTextBox)
        Me.Controls.Add(PackageNameLabel)
        Me.Controls.Add(Me.PackageNameTextBox)
        Me.Controls.Add(StateLabel)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(DestinationLabel)
        Me.Controls.Add(Me.DestinationTextBox)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(PaxLabel)
        Me.Controls.Add(Me.PaxTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(DurationLabel)
        Me.Controls.Add(Me.DurationTextBox)
        Me.Controls.Add(SellerNameLabel)
        Me.Controls.Add(Me.SellerNameTextBox)
        Me.Controls.Add(UserIDLabel)
        Me.Controls.Add(Me.UserIDTextBox)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.btnAddPic)
        Me.Controls.Add(Me.picPackage)
        Me.Controls.Add(Me.PackageDataGridView)
        Me.Controls.Add(Me.PackageBindingNavigator)
        Me.Name = "temporaryInputFormPackage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Package"
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PackageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PackageBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PackageBindingNavigator.ResumeLayout(False)
        Me.PackageBindingNavigator.PerformLayout()
        CType(Me.picPackage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PackageDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OtralaDBDataSet As OtralaDBDataSet
    Friend WithEvents PackageBindingSource As BindingSource
    Friend WithEvents PackageTableAdapter As OtralaDBDataSetTableAdapters.PackageTableAdapter
    Friend WithEvents TableAdapterManager As OtralaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents PackageBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PackageBindingNavigator As BindingNavigator
    Friend WithEvents Back As Button
    Friend WithEvents picPackage As PictureBox
    Friend WithEvents btnAddPic As Button
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PackageDataGridView As DataGridView
    Friend WithEvents PackageIDTextBox As TextBox
    Friend WithEvents PackageNameTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents DestinationTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents PaxTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents DurationTextBox As TextBox
    Friend WithEvents SellerNameTextBox As TextBox
    Friend WithEvents UserIDTextBox As TextBox
End Class
