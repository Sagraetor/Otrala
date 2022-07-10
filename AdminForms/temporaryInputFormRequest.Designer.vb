<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class temporaryInputFormRequest
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
        Dim RequestIDLabel As System.Windows.Forms.Label
        Dim UserIDLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim DurationLabel As System.Windows.Forms.Label
        Dim PaxLabel As System.Windows.Forms.Label
        Dim PlannedDateLabel As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(temporaryInputFormRequest))
        Dim Label1 As System.Windows.Forms.Label
        Me.OtralaDBDataSet = New Otrala_2._0.OtralaDBDataSet()
        Me.RequestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequestTableAdapter = New Otrala_2._0.OtralaDBDataSetTableAdapters.RequestTableAdapter()
        Me.TableAdapterManager = New Otrala_2._0.OtralaDBDataSetTableAdapters.TableAdapterManager()
        Me.RequestBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.RequestBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.RequestDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequestIDTextBox = New System.Windows.Forms.TextBox()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.DurationTextBox = New System.Windows.Forms.TextBox()
        Me.PaxTextBox = New System.Windows.Forms.TextBox()
        Me.PlannedDateTextBox = New System.Windows.Forms.TextBox()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtFind = New System.Windows.Forms.TextBox()
        RequestIDLabel = New System.Windows.Forms.Label()
        UserIDLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        DurationLabel = New System.Windows.Forms.Label()
        PaxLabel = New System.Windows.Forms.Label()
        PlannedDateLabel = New System.Windows.Forms.Label()
        NotesLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequestBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RequestBindingNavigator.SuspendLayout()
        CType(Me.RequestDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RequestIDLabel
        '
        RequestIDLabel.AutoSize = True
        RequestIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RequestIDLabel.Location = New System.Drawing.Point(19, 112)
        RequestIDLabel.Name = "RequestIDLabel"
        RequestIDLabel.Size = New System.Drawing.Size(114, 25)
        RequestIDLabel.TabIndex = 2
        RequestIDLabel.Text = "Request ID:"
        '
        'UserIDLabel
        '
        UserIDLabel.AutoSize = True
        UserIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UserIDLabel.Location = New System.Drawing.Point(19, 155)
        UserIDLabel.Name = "UserIDLabel"
        UserIDLabel.Size = New System.Drawing.Size(83, 25)
        UserIDLabel.TabIndex = 4
        UserIDLabel.Text = "User ID:"
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LocationLabel.Location = New System.Drawing.Point(19, 198)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(92, 25)
        LocationLabel.TabIndex = 6
        LocationLabel.Text = "Location:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PriceLabel.Location = New System.Drawing.Point(19, 241)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(62, 25)
        PriceLabel.TabIndex = 8
        PriceLabel.Text = "Price:"
        '
        'DurationLabel
        '
        DurationLabel.AutoSize = True
        DurationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DurationLabel.Location = New System.Drawing.Point(19, 284)
        DurationLabel.Name = "DurationLabel"
        DurationLabel.Size = New System.Drawing.Size(91, 25)
        DurationLabel.TabIndex = 10
        DurationLabel.Text = "Duration:"
        '
        'PaxLabel
        '
        PaxLabel.AutoSize = True
        PaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PaxLabel.Location = New System.Drawing.Point(19, 327)
        PaxLabel.Name = "PaxLabel"
        PaxLabel.Size = New System.Drawing.Size(52, 25)
        PaxLabel.TabIndex = 12
        PaxLabel.Text = "Pax:"
        '
        'PlannedDateLabel
        '
        PlannedDateLabel.AutoSize = True
        PlannedDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PlannedDateLabel.Location = New System.Drawing.Point(19, 370)
        PlannedDateLabel.Name = "PlannedDateLabel"
        PlannedDateLabel.Size = New System.Drawing.Size(136, 25)
        PlannedDateLabel.TabIndex = 14
        PlannedDateLabel.Text = "Planned Date:"
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NotesLabel.Location = New System.Drawing.Point(19, 413)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(69, 25)
        NotesLabel.TabIndex = 16
        NotesLabel.Text = "Notes:"
        '
        'OtralaDBDataSet
        '
        Me.OtralaDBDataSet.DataSetName = "OtralaDBDataSet"
        Me.OtralaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookingTableAdapter = Nothing
        Me.TableAdapterManager.FeedbackTableAdapter = Nothing
        Me.TableAdapterManager.LoginInfoTableAdapter = Nothing
        Me.TableAdapterManager.PackageTableAdapter = Nothing
        Me.TableAdapterManager.RequestAnswerTableAdapter = Nothing
        Me.TableAdapterManager.RequestTableAdapter = Me.RequestTableAdapter
        Me.TableAdapterManager.SellerApplicationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Otrala_2._0.OtralaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserInfoTableAdapter = Nothing
        '
        'RequestBindingNavigator
        '
        Me.RequestBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RequestBindingNavigator.BindingSource = Me.RequestBindingSource
        Me.RequestBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RequestBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RequestBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.RequestBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RequestBindingNavigatorSaveItem})
        Me.RequestBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RequestBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RequestBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RequestBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RequestBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RequestBindingNavigator.Name = "RequestBindingNavigator"
        Me.RequestBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RequestBindingNavigator.Size = New System.Drawing.Size(1262, 27)
        Me.RequestBindingNavigator.TabIndex = 0
        Me.RequestBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'RequestBindingNavigatorSaveItem
        '
        Me.RequestBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RequestBindingNavigatorSaveItem.Image = CType(resources.GetObject("RequestBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RequestBindingNavigatorSaveItem.Name = "RequestBindingNavigatorSaveItem"
        Me.RequestBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.RequestBindingNavigatorSaveItem.Text = "Save Data"
        '
        'RequestDataGridView
        '
        Me.RequestDataGridView.AutoGenerateColumns = False
        Me.RequestDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RequestDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.RequestDataGridView.DataSource = Me.RequestBindingSource
        Me.RequestDataGridView.Location = New System.Drawing.Point(446, 106)
        Me.RequestDataGridView.Name = "RequestDataGridView"
        Me.RequestDataGridView.RowHeadersWidth = 51
        Me.RequestDataGridView.RowTemplate.Height = 24
        Me.RequestDataGridView.Size = New System.Drawing.Size(804, 555)
        Me.RequestDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "RequestID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "RequestID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "UserID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "UserID"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Location"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Duration"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Duration"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Pax"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Pax"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PlannedDate"
        Me.DataGridViewTextBoxColumn7.HeaderText = "PlannedDate"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'RequestIDTextBox
        '
        Me.RequestIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RequestBindingSource, "RequestID", True))
        Me.RequestIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RequestIDTextBox.Location = New System.Drawing.Point(186, 109)
        Me.RequestIDTextBox.Name = "RequestIDTextBox"
        Me.RequestIDTextBox.Size = New System.Drawing.Size(194, 30)
        Me.RequestIDTextBox.TabIndex = 3
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RequestBindingSource, "UserID", True))
        Me.UserIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserIDTextBox.Location = New System.Drawing.Point(186, 152)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(194, 30)
        Me.UserIDTextBox.TabIndex = 5
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RequestBindingSource, "Location", True))
        Me.LocationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationTextBox.Location = New System.Drawing.Point(186, 195)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(194, 30)
        Me.LocationTextBox.TabIndex = 7
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RequestBindingSource, "Price", True))
        Me.PriceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceTextBox.Location = New System.Drawing.Point(186, 238)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(194, 30)
        Me.PriceTextBox.TabIndex = 9
        '
        'DurationTextBox
        '
        Me.DurationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RequestBindingSource, "Duration", True))
        Me.DurationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DurationTextBox.Location = New System.Drawing.Point(186, 281)
        Me.DurationTextBox.Name = "DurationTextBox"
        Me.DurationTextBox.Size = New System.Drawing.Size(194, 30)
        Me.DurationTextBox.TabIndex = 11
        '
        'PaxTextBox
        '
        Me.PaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RequestBindingSource, "Pax", True))
        Me.PaxTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaxTextBox.Location = New System.Drawing.Point(186, 324)
        Me.PaxTextBox.Name = "PaxTextBox"
        Me.PaxTextBox.Size = New System.Drawing.Size(194, 30)
        Me.PaxTextBox.TabIndex = 13
        '
        'PlannedDateTextBox
        '
        Me.PlannedDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RequestBindingSource, "PlannedDate", True))
        Me.PlannedDateTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlannedDateTextBox.Location = New System.Drawing.Point(186, 367)
        Me.PlannedDateTextBox.Name = "PlannedDateTextBox"
        Me.PlannedDateTextBox.Size = New System.Drawing.Size(194, 30)
        Me.PlannedDateTextBox.TabIndex = 15
        '
        'NotesTextBox
        '
        Me.NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RequestBindingSource, "Notes", True))
        Me.NotesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotesTextBox.Location = New System.Drawing.Point(186, 410)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NotesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.NotesTextBox.Size = New System.Drawing.Size(194, 158)
        Me.NotesTextBox.TabIndex = 17
        '
        'btnAddNew
        '
        Me.btnAddNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnAddNew.ForeColor = System.Drawing.Color.White
        Me.btnAddNew.Location = New System.Drawing.Point(320, 618)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(111, 43)
        Me.btnAddNew.TabIndex = 20
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(168, 618)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(111, 43)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(16, 618)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(111, 43)
        Me.BtnSave.TabIndex = 18
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(513, 57)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(131, 25)
        Label1.TabIndex = 23
        Label1.Text = "Search by ID:"
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = Global.Otrala_2._0.My.Resources.Resources.Search_Icon
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSearch.Location = New System.Drawing.Point(1147, 54)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(30, 30)
        Me.btnSearch.TabIndex = 22
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtFind
        '
        Me.txtFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFind.Location = New System.Drawing.Point(667, 54)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(455, 30)
        Me.txtFind.TabIndex = 21
        '
        'temporaryInputFormRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(RequestIDLabel)
        Me.Controls.Add(Me.RequestIDTextBox)
        Me.Controls.Add(UserIDLabel)
        Me.Controls.Add(Me.UserIDTextBox)
        Me.Controls.Add(LocationLabel)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(DurationLabel)
        Me.Controls.Add(Me.DurationTextBox)
        Me.Controls.Add(PaxLabel)
        Me.Controls.Add(Me.PaxTextBox)
        Me.Controls.Add(PlannedDateLabel)
        Me.Controls.Add(Me.PlannedDateTextBox)
        Me.Controls.Add(NotesLabel)
        Me.Controls.Add(Me.NotesTextBox)
        Me.Controls.Add(Me.RequestDataGridView)
        Me.Controls.Add(Me.RequestBindingNavigator)
        Me.Name = "temporaryInputFormRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Request"
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequestBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RequestBindingNavigator.ResumeLayout(False)
        Me.RequestBindingNavigator.PerformLayout()
        CType(Me.RequestDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OtralaDBDataSet As OtralaDBDataSet
    Friend WithEvents RequestBindingSource As BindingSource
    Friend WithEvents RequestTableAdapter As OtralaDBDataSetTableAdapters.RequestTableAdapter
    Friend WithEvents TableAdapterManager As OtralaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RequestBindingNavigator As BindingNavigator
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
    Friend WithEvents RequestBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents RequestDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents RequestIDTextBox As TextBox
    Friend WithEvents UserIDTextBox As TextBox
    Friend WithEvents LocationTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents DurationTextBox As TextBox
    Friend WithEvents PaxTextBox As TextBox
    Friend WithEvents PlannedDateTextBox As TextBox
    Friend WithEvents NotesTextBox As TextBox
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtFind As TextBox
End Class
