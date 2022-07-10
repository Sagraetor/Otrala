<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class temporaryInputFormUserInfo
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
        Dim UserIDLabel As System.Windows.Forms.Label
        Dim RealNameLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim SellerLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(temporaryInputFormUserInfo))
        Me.OtralaDBDataSet = New Otrala_2._0.OtralaDBDataSet()
        Me.UserInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserInfoTableAdapter = New Otrala_2._0.OtralaDBDataSetTableAdapters.UserInfoTableAdapter()
        Me.TableAdapterManager = New Otrala_2._0.OtralaDBDataSetTableAdapters.TableAdapterManager()
        Me.UserInfoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.UserInfoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.UserInfoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.RealNameTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.SellerCheckBox = New System.Windows.Forms.CheckBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        UserIDLabel = New System.Windows.Forms.Label()
        RealNameLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        SellerLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserInfoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserInfoBindingNavigator.SuspendLayout()
        CType(Me.UserInfoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserIDLabel
        '
        UserIDLabel.AutoSize = True
        UserIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UserIDLabel.Location = New System.Drawing.Point(32, 101)
        UserIDLabel.Name = "UserIDLabel"
        UserIDLabel.Size = New System.Drawing.Size(83, 25)
        UserIDLabel.TabIndex = 2
        UserIDLabel.Text = "User ID:"
        '
        'RealNameLabel
        '
        RealNameLabel.AutoSize = True
        RealNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RealNameLabel.Location = New System.Drawing.Point(32, 159)
        RealNameLabel.Name = "RealNameLabel"
        RealNameLabel.Size = New System.Drawing.Size(114, 25)
        RealNameLabel.TabIndex = 4
        RealNameLabel.Text = "Real Name:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AgeLabel.Location = New System.Drawing.Point(32, 217)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(54, 25)
        AgeLabel.TabIndex = 6
        AgeLabel.Text = "Age:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhoneLabel.Location = New System.Drawing.Point(32, 275)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(75, 25)
        PhoneLabel.TabIndex = 8
        PhoneLabel.Text = "Phone:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(32, 333)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(66, 25)
        EmailLabel.TabIndex = 10
        EmailLabel.Text = "Email:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(32, 391)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(91, 25)
        AddressLabel.TabIndex = 12
        AddressLabel.Text = "Address:"
        '
        'SellerLabel
        '
        SellerLabel.AutoSize = True
        SellerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SellerLabel.Location = New System.Drawing.Point(32, 449)
        SellerLabel.Name = "SellerLabel"
        SellerLabel.Size = New System.Drawing.Size(68, 25)
        SellerLabel.TabIndex = 14
        SellerLabel.Text = "Seller:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(512, 56)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(131, 25)
        Label1.TabIndex = 26
        Label1.Text = "Search by ID:"
        '
        'OtralaDBDataSet
        '
        Me.OtralaDBDataSet.DataSetName = "OtralaDBDataSet"
        Me.OtralaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserInfoBindingSource
        '
        Me.UserInfoBindingSource.DataMember = "UserInfo"
        Me.UserInfoBindingSource.DataSource = Me.OtralaDBDataSet
        '
        'UserInfoTableAdapter
        '
        Me.UserInfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookingTableAdapter = Nothing
        Me.TableAdapterManager.FeedbackTableAdapter = Nothing
        Me.TableAdapterManager.LoginInfoTableAdapter = Nothing
        Me.TableAdapterManager.PackageTableAdapter = Nothing
        Me.TableAdapterManager.RequestAnswerTableAdapter = Nothing
        Me.TableAdapterManager.RequestTableAdapter = Nothing
        Me.TableAdapterManager.SellerApplicationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Otrala_2._0.OtralaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserInfoTableAdapter = Me.UserInfoTableAdapter
        '
        'UserInfoBindingNavigator
        '
        Me.UserInfoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UserInfoBindingNavigator.AutoSize = False
        Me.UserInfoBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UserInfoBindingNavigator.BindingSource = Me.UserInfoBindingSource
        Me.UserInfoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UserInfoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UserInfoBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.UserInfoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UserInfoBindingNavigatorSaveItem})
        Me.UserInfoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UserInfoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UserInfoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UserInfoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UserInfoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UserInfoBindingNavigator.Name = "UserInfoBindingNavigator"
        Me.UserInfoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UserInfoBindingNavigator.Size = New System.Drawing.Size(1262, 40)
        Me.UserInfoBindingNavigator.TabIndex = 0
        Me.UserInfoBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 37)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 37)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 37)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 37)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 37)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 40)
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 40)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 37)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 37)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 40)
        '
        'UserInfoBindingNavigatorSaveItem
        '
        Me.UserInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UserInfoBindingNavigatorSaveItem.Image = CType(resources.GetObject("UserInfoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UserInfoBindingNavigatorSaveItem.Name = "UserInfoBindingNavigatorSaveItem"
        Me.UserInfoBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 37)
        Me.UserInfoBindingNavigatorSaveItem.Text = "Save Data"
        '
        'UserInfoDataGridView
        '
        Me.UserInfoDataGridView.AutoGenerateColumns = False
        Me.UserInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserInfoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewCheckBoxColumn1})
        Me.UserInfoDataGridView.DataSource = Me.UserInfoBindingSource
        Me.UserInfoDataGridView.Location = New System.Drawing.Point(446, 106)
        Me.UserInfoDataGridView.Name = "UserInfoDataGridView"
        Me.UserInfoDataGridView.RowHeadersWidth = 51
        Me.UserInfoDataGridView.RowTemplate.Height = 24
        Me.UserInfoDataGridView.Size = New System.Drawing.Size(804, 555)
        Me.UserInfoDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "UserID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "UserID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RealName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "RealName"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Age"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Phone"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Seller"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Seller"
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 125
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserInfoBindingSource, "UserID", True))
        Me.UserIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserIDTextBox.Location = New System.Drawing.Point(181, 98)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(237, 30)
        Me.UserIDTextBox.TabIndex = 3
        '
        'RealNameTextBox
        '
        Me.RealNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserInfoBindingSource, "RealName", True))
        Me.RealNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RealNameTextBox.Location = New System.Drawing.Point(181, 156)
        Me.RealNameTextBox.Name = "RealNameTextBox"
        Me.RealNameTextBox.Size = New System.Drawing.Size(237, 30)
        Me.RealNameTextBox.TabIndex = 5
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserInfoBindingSource, "Age", True))
        Me.AgeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeTextBox.Location = New System.Drawing.Point(181, 214)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(237, 30)
        Me.AgeTextBox.TabIndex = 7
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserInfoBindingSource, "Phone", True))
        Me.PhoneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneTextBox.Location = New System.Drawing.Point(181, 272)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(237, 30)
        Me.PhoneTextBox.TabIndex = 9
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserInfoBindingSource, "Email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(181, 330)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(237, 30)
        Me.EmailTextBox.TabIndex = 11
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserInfoBindingSource, "Address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(181, 388)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(237, 30)
        Me.AddressTextBox.TabIndex = 13
        '
        'SellerCheckBox
        '
        Me.SellerCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UserInfoBindingSource, "Seller", True))
        Me.SellerCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SellerCheckBox.Location = New System.Drawing.Point(181, 446)
        Me.SellerCheckBox.Name = "SellerCheckBox"
        Me.SellerCheckBox.Size = New System.Drawing.Size(237, 24)
        Me.SellerCheckBox.TabIndex = 15
        Me.SellerCheckBox.Text = "IsSeller"
        Me.SellerCheckBox.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = Global.Otrala_2._0.My.Resources.Resources.Search_Icon
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSearch.Location = New System.Drawing.Point(1146, 53)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(30, 30)
        Me.btnSearch.TabIndex = 25
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtFind
        '
        Me.txtFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFind.Location = New System.Drawing.Point(666, 53)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(455, 30)
        Me.txtFind.TabIndex = 24
        '
        'btnAddNew
        '
        Me.btnAddNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnAddNew.ForeColor = System.Drawing.Color.White
        Me.btnAddNew.Location = New System.Drawing.Point(315, 586)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(102, 43)
        Me.btnAddNew.TabIndex = 29
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(176, 586)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(102, 43)
        Me.btnDelete.TabIndex = 28
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(37, 586)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(102, 43)
        Me.BtnSave.TabIndex = 27
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'temporaryInputFormUserInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(UserIDLabel)
        Me.Controls.Add(Me.UserIDTextBox)
        Me.Controls.Add(RealNameLabel)
        Me.Controls.Add(Me.RealNameTextBox)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(SellerLabel)
        Me.Controls.Add(Me.SellerCheckBox)
        Me.Controls.Add(Me.UserInfoDataGridView)
        Me.Controls.Add(Me.UserInfoBindingNavigator)
        Me.Name = "temporaryInputFormUserInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add User Info"
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserInfoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserInfoBindingNavigator.ResumeLayout(False)
        Me.UserInfoBindingNavigator.PerformLayout()
        CType(Me.UserInfoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OtralaDBDataSet As OtralaDBDataSet
    Friend WithEvents UserInfoBindingSource As BindingSource
    Friend WithEvents UserInfoTableAdapter As OtralaDBDataSetTableAdapters.UserInfoTableAdapter
    Friend WithEvents TableAdapterManager As OtralaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UserInfoBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents UserInfoBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents UserInfoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents UserIDTextBox As TextBox
    Friend WithEvents RealNameTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents SellerCheckBox As CheckBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtFind As TextBox
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents BtnSave As Button
End Class
