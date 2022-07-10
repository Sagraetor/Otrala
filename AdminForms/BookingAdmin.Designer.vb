<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookingAdmin
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
        Dim BookingIDLabel As System.Windows.Forms.Label
        Dim UserIDLabel As System.Windows.Forms.Label
        Dim PackageIDLabel As System.Windows.Forms.Label
        Dim DateBookedLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim CardNameLabel As System.Windows.Forms.Label
        Dim CardNumberLabel As System.Windows.Forms.Label
        Dim ClientFulfilledLabel As System.Windows.Forms.Label
        Dim SellerFulfilledLabel As System.Windows.Forms.Label
        Dim PlannedDateLabel As System.Windows.Forms.Label
        Dim TotalPriceLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookingAdmin))
        Dim Label1 As System.Windows.Forms.Label
        Me.OtralaDBDataSet = New Otrala_2._0.OtralaDBDataSet()
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookingTableAdapter = New Otrala_2._0.OtralaDBDataSetTableAdapters.BookingTableAdapter()
        Me.TableAdapterManager = New Otrala_2._0.OtralaDBDataSetTableAdapters.TableAdapterManager()
        Me.BookingBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BookingBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BookingIDTextBox = New System.Windows.Forms.TextBox()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.PackageIDTextBox = New System.Windows.Forms.TextBox()
        Me.DateBookedTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.CardNameTextBox = New System.Windows.Forms.TextBox()
        Me.CardNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ClientFulfilledTextBox = New System.Windows.Forms.TextBox()
        Me.SellerFulfilledTextBox = New System.Windows.Forms.TextBox()
        Me.PlannedDateTextBox = New System.Windows.Forms.TextBox()
        Me.TotalPriceTextBox = New System.Windows.Forms.TextBox()
        Me.BookingDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        BookingIDLabel = New System.Windows.Forms.Label()
        UserIDLabel = New System.Windows.Forms.Label()
        PackageIDLabel = New System.Windows.Forms.Label()
        DateBookedLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        CardNameLabel = New System.Windows.Forms.Label()
        CardNumberLabel = New System.Windows.Forms.Label()
        ClientFulfilledLabel = New System.Windows.Forms.Label()
        SellerFulfilledLabel = New System.Windows.Forms.Label()
        PlannedDateLabel = New System.Windows.Forms.Label()
        TotalPriceLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BookingBindingNavigator.SuspendLayout()
        CType(Me.BookingDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BookingIDLabel
        '
        BookingIDLabel.AutoSize = True
        BookingIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BookingIDLabel.Location = New System.Drawing.Point(12, 109)
        BookingIDLabel.Name = "BookingIDLabel"
        BookingIDLabel.Size = New System.Drawing.Size(113, 25)
        BookingIDLabel.TabIndex = 1
        BookingIDLabel.Text = "Booking ID:"
        '
        'UserIDLabel
        '
        UserIDLabel.AutoSize = True
        UserIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UserIDLabel.Location = New System.Drawing.Point(12, 147)
        UserIDLabel.Name = "UserIDLabel"
        UserIDLabel.Size = New System.Drawing.Size(83, 25)
        UserIDLabel.TabIndex = 3
        UserIDLabel.Text = "User ID:"
        '
        'PackageIDLabel
        '
        PackageIDLabel.AutoSize = True
        PackageIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PackageIDLabel.Location = New System.Drawing.Point(12, 185)
        PackageIDLabel.Name = "PackageIDLabel"
        PackageIDLabel.Size = New System.Drawing.Size(119, 25)
        PackageIDLabel.TabIndex = 5
        PackageIDLabel.Text = "Package ID:"
        '
        'DateBookedLabel
        '
        DateBookedLabel.AutoSize = True
        DateBookedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateBookedLabel.Location = New System.Drawing.Point(12, 223)
        DateBookedLabel.Name = "DateBookedLabel"
        DateBookedLabel.Size = New System.Drawing.Size(131, 25)
        DateBookedLabel.TabIndex = 7
        DateBookedLabel.Text = "Date Booked:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QuantityLabel.Location = New System.Drawing.Point(12, 261)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(91, 25)
        QuantityLabel.TabIndex = 9
        QuantityLabel.Text = "Quantity:"
        '
        'CardNameLabel
        '
        CardNameLabel.AutoSize = True
        CardNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CardNameLabel.Location = New System.Drawing.Point(12, 299)
        CardNameLabel.Name = "CardNameLabel"
        CardNameLabel.Size = New System.Drawing.Size(118, 25)
        CardNameLabel.TabIndex = 11
        CardNameLabel.Text = "Card Name:"
        '
        'CardNumberLabel
        '
        CardNumberLabel.AutoSize = True
        CardNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CardNumberLabel.Location = New System.Drawing.Point(12, 337)
        CardNumberLabel.Name = "CardNumberLabel"
        CardNumberLabel.Size = New System.Drawing.Size(135, 25)
        CardNumberLabel.TabIndex = 13
        CardNumberLabel.Text = "Card Number:"
        '
        'ClientFulfilledLabel
        '
        ClientFulfilledLabel.AutoSize = True
        ClientFulfilledLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ClientFulfilledLabel.Location = New System.Drawing.Point(12, 375)
        ClientFulfilledLabel.Name = "ClientFulfilledLabel"
        ClientFulfilledLabel.Size = New System.Drawing.Size(139, 25)
        ClientFulfilledLabel.TabIndex = 15
        ClientFulfilledLabel.Text = "Client Fulfilled:"
        '
        'SellerFulfilledLabel
        '
        SellerFulfilledLabel.AutoSize = True
        SellerFulfilledLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SellerFulfilledLabel.Location = New System.Drawing.Point(12, 413)
        SellerFulfilledLabel.Name = "SellerFulfilledLabel"
        SellerFulfilledLabel.Size = New System.Drawing.Size(139, 25)
        SellerFulfilledLabel.TabIndex = 17
        SellerFulfilledLabel.Text = "Seller Fulfilled:"
        '
        'PlannedDateLabel
        '
        PlannedDateLabel.AutoSize = True
        PlannedDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PlannedDateLabel.Location = New System.Drawing.Point(12, 451)
        PlannedDateLabel.Name = "PlannedDateLabel"
        PlannedDateLabel.Size = New System.Drawing.Size(136, 25)
        PlannedDateLabel.TabIndex = 19
        PlannedDateLabel.Text = "Planned Date:"
        '
        'TotalPriceLabel
        '
        TotalPriceLabel.AutoSize = True
        TotalPriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalPriceLabel.Location = New System.Drawing.Point(12, 489)
        TotalPriceLabel.Name = "TotalPriceLabel"
        TotalPriceLabel.Size = New System.Drawing.Size(111, 25)
        TotalPriceLabel.TabIndex = 21
        TotalPriceLabel.Text = "Total Price:"
        '
        'OtralaDBDataSet
        '
        Me.OtralaDBDataSet.DataSetName = "OtralaDBDataSet"
        Me.OtralaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookingTableAdapter = Me.BookingTableAdapter
        Me.TableAdapterManager.FeedbackTableAdapter = Nothing
        Me.TableAdapterManager.LoginInfoTableAdapter = Nothing
        Me.TableAdapterManager.PackageTableAdapter = Nothing
        Me.TableAdapterManager.RequestAnswerTableAdapter = Nothing
        Me.TableAdapterManager.RequestTableAdapter = Nothing
        Me.TableAdapterManager.SellerApplicationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Otrala_2._0.OtralaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserInfoTableAdapter = Nothing
        '
        'BookingBindingNavigator
        '
        Me.BookingBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BookingBindingNavigator.AutoSize = False
        Me.BookingBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BookingBindingNavigator.BindingSource = Me.BookingBindingSource
        Me.BookingBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BookingBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BookingBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BookingBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BookingBindingNavigatorSaveItem})
        Me.BookingBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BookingBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BookingBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BookingBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BookingBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BookingBindingNavigator.Name = "BookingBindingNavigator"
        Me.BookingBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BookingBindingNavigator.Size = New System.Drawing.Size(1262, 40)
        Me.BookingBindingNavigator.TabIndex = 0
        Me.BookingBindingNavigator.Text = "BindingNavigator1"
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
        'BookingBindingNavigatorSaveItem
        '
        Me.BookingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BookingBindingNavigatorSaveItem.Image = CType(resources.GetObject("BookingBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BookingBindingNavigatorSaveItem.Name = "BookingBindingNavigatorSaveItem"
        Me.BookingBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 37)
        Me.BookingBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BookingIDTextBox
        '
        Me.BookingIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "BookingID", True))
        Me.BookingIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookingIDTextBox.Location = New System.Drawing.Point(186, 106)
        Me.BookingIDTextBox.Name = "BookingIDTextBox"
        Me.BookingIDTextBox.Size = New System.Drawing.Size(238, 30)
        Me.BookingIDTextBox.TabIndex = 2
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "UserID", True))
        Me.UserIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserIDTextBox.Location = New System.Drawing.Point(186, 144)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(238, 30)
        Me.UserIDTextBox.TabIndex = 4
        '
        'PackageIDTextBox
        '
        Me.PackageIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "PackageID", True))
        Me.PackageIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PackageIDTextBox.Location = New System.Drawing.Point(186, 182)
        Me.PackageIDTextBox.Name = "PackageIDTextBox"
        Me.PackageIDTextBox.Size = New System.Drawing.Size(238, 30)
        Me.PackageIDTextBox.TabIndex = 6
        '
        'DateBookedTextBox
        '
        Me.DateBookedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "DateBooked", True))
        Me.DateBookedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateBookedTextBox.Location = New System.Drawing.Point(186, 220)
        Me.DateBookedTextBox.Name = "DateBookedTextBox"
        Me.DateBookedTextBox.Size = New System.Drawing.Size(238, 30)
        Me.DateBookedTextBox.TabIndex = 8
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "Quantity", True))
        Me.QuantityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTextBox.Location = New System.Drawing.Point(186, 258)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(238, 30)
        Me.QuantityTextBox.TabIndex = 10
        '
        'CardNameTextBox
        '
        Me.CardNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "CardName", True))
        Me.CardNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CardNameTextBox.Location = New System.Drawing.Point(186, 296)
        Me.CardNameTextBox.Name = "CardNameTextBox"
        Me.CardNameTextBox.Size = New System.Drawing.Size(238, 30)
        Me.CardNameTextBox.TabIndex = 12
        '
        'CardNumberTextBox
        '
        Me.CardNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "CardNumber", True))
        Me.CardNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CardNumberTextBox.Location = New System.Drawing.Point(186, 334)
        Me.CardNumberTextBox.Name = "CardNumberTextBox"
        Me.CardNumberTextBox.Size = New System.Drawing.Size(238, 30)
        Me.CardNumberTextBox.TabIndex = 14
        '
        'ClientFulfilledTextBox
        '
        Me.ClientFulfilledTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "ClientFulfilled", True))
        Me.ClientFulfilledTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientFulfilledTextBox.Location = New System.Drawing.Point(186, 372)
        Me.ClientFulfilledTextBox.Name = "ClientFulfilledTextBox"
        Me.ClientFulfilledTextBox.Size = New System.Drawing.Size(238, 30)
        Me.ClientFulfilledTextBox.TabIndex = 16
        '
        'SellerFulfilledTextBox
        '
        Me.SellerFulfilledTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "SellerFulfilled", True))
        Me.SellerFulfilledTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SellerFulfilledTextBox.Location = New System.Drawing.Point(186, 410)
        Me.SellerFulfilledTextBox.Name = "SellerFulfilledTextBox"
        Me.SellerFulfilledTextBox.Size = New System.Drawing.Size(238, 30)
        Me.SellerFulfilledTextBox.TabIndex = 18
        '
        'PlannedDateTextBox
        '
        Me.PlannedDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "PlannedDate", True))
        Me.PlannedDateTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlannedDateTextBox.Location = New System.Drawing.Point(186, 448)
        Me.PlannedDateTextBox.Name = "PlannedDateTextBox"
        Me.PlannedDateTextBox.Size = New System.Drawing.Size(238, 30)
        Me.PlannedDateTextBox.TabIndex = 20
        '
        'TotalPriceTextBox
        '
        Me.TotalPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "TotalPrice", True))
        Me.TotalPriceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPriceTextBox.Location = New System.Drawing.Point(186, 486)
        Me.TotalPriceTextBox.Name = "TotalPriceTextBox"
        Me.TotalPriceTextBox.Size = New System.Drawing.Size(238, 30)
        Me.TotalPriceTextBox.TabIndex = 22
        '
        'BookingDataGridView
        '
        Me.BookingDataGridView.AutoGenerateColumns = False
        Me.BookingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BookingDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.BookingDataGridView.DataSource = Me.BookingBindingSource
        Me.BookingDataGridView.Location = New System.Drawing.Point(446, 106)
        Me.BookingDataGridView.Name = "BookingDataGridView"
        Me.BookingDataGridView.RowHeadersWidth = 51
        Me.BookingDataGridView.RowTemplate.Height = 24
        Me.BookingDataGridView.Size = New System.Drawing.Size(804, 555)
        Me.BookingDataGridView.TabIndex = 23
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "BookingID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "BookingID"
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PackageID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PackageID"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DateBooked"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DateBooked"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CardName"
        Me.DataGridViewTextBoxColumn6.HeaderText = "CardName"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CardNumber"
        Me.DataGridViewTextBoxColumn7.HeaderText = "CardNumber"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ClientFulfilled"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ClientFulfilled"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "SellerFulfilled"
        Me.DataGridViewTextBoxColumn9.HeaderText = "SellerFulfilled"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PlannedDate"
        Me.DataGridViewTextBoxColumn10.HeaderText = "PlannedDate"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "TotalPrice"
        Me.DataGridViewTextBoxColumn11.HeaderText = "TotalPrice"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 125
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(526, 59)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(131, 25)
        Label1.TabIndex = 26
        Label1.Text = "Search by ID:"
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = Global.Otrala_2._0.My.Resources.Resources.Search_Icon
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSearch.Location = New System.Drawing.Point(1160, 56)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(30, 30)
        Me.btnSearch.TabIndex = 25
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtFind
        '
        Me.txtFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFind.Location = New System.Drawing.Point(680, 56)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(455, 30)
        Me.txtFind.TabIndex = 24
        '
        'btnAddNew
        '
        Me.btnAddNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnAddNew.ForeColor = System.Drawing.Color.White
        Me.btnAddNew.Location = New System.Drawing.Point(313, 588)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(111, 43)
        Me.btnAddNew.TabIndex = 29
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(165, 588)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(111, 43)
        Me.btnDelete.TabIndex = 28
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(17, 588)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(111, 43)
        Me.BtnSave.TabIndex = 27
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BookingAdmin
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
        Me.Controls.Add(Me.BookingDataGridView)
        Me.Controls.Add(BookingIDLabel)
        Me.Controls.Add(Me.BookingIDTextBox)
        Me.Controls.Add(UserIDLabel)
        Me.Controls.Add(Me.UserIDTextBox)
        Me.Controls.Add(PackageIDLabel)
        Me.Controls.Add(Me.PackageIDTextBox)
        Me.Controls.Add(DateBookedLabel)
        Me.Controls.Add(Me.DateBookedTextBox)
        Me.Controls.Add(QuantityLabel)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(CardNameLabel)
        Me.Controls.Add(Me.CardNameTextBox)
        Me.Controls.Add(CardNumberLabel)
        Me.Controls.Add(Me.CardNumberTextBox)
        Me.Controls.Add(ClientFulfilledLabel)
        Me.Controls.Add(Me.ClientFulfilledTextBox)
        Me.Controls.Add(SellerFulfilledLabel)
        Me.Controls.Add(Me.SellerFulfilledTextBox)
        Me.Controls.Add(PlannedDateLabel)
        Me.Controls.Add(Me.PlannedDateTextBox)
        Me.Controls.Add(TotalPriceLabel)
        Me.Controls.Add(Me.TotalPriceTextBox)
        Me.Controls.Add(Me.BookingBindingNavigator)
        Me.Name = "BookingAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BookingAdmin"
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BookingBindingNavigator.ResumeLayout(False)
        Me.BookingBindingNavigator.PerformLayout()
        CType(Me.BookingDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OtralaDBDataSet As OtralaDBDataSet
    Friend WithEvents BookingBindingSource As BindingSource
    Friend WithEvents BookingTableAdapter As OtralaDBDataSetTableAdapters.BookingTableAdapter
    Friend WithEvents TableAdapterManager As OtralaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BookingBindingNavigator As BindingNavigator
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
    Friend WithEvents BookingBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents BookingIDTextBox As TextBox
    Friend WithEvents UserIDTextBox As TextBox
    Friend WithEvents PackageIDTextBox As TextBox
    Friend WithEvents DateBookedTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents CardNameTextBox As TextBox
    Friend WithEvents CardNumberTextBox As TextBox
    Friend WithEvents ClientFulfilledTextBox As TextBox
    Friend WithEvents SellerFulfilledTextBox As TextBox
    Friend WithEvents PlannedDateTextBox As TextBox
    Friend WithEvents TotalPriceTextBox As TextBox
    Friend WithEvents BookingDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtFind As TextBox
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents BtnSave As Button
End Class
