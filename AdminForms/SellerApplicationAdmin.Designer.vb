﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SellerApplicationAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SellerApplicationAdmin))
        Dim ApplicationIDLabel As System.Windows.Forms.Label
        Dim UserIDLabel As System.Windows.Forms.Label
        Dim lblSeller As System.Windows.Forms.Label
        Dim lblProof As System.Windows.Forms.Label
        Me.OtralaDBDataSet = New Otrala_2._0.OtralaDBDataSet()
        Me.SellerApplicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SellerApplicationTableAdapter = New Otrala_2._0.OtralaDBDataSetTableAdapters.SellerApplicationTableAdapter()
        Me.TableAdapterManager = New Otrala_2._0.OtralaDBDataSetTableAdapters.TableAdapterManager()
        Me.SellerApplicationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SellerApplicationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SellerApplicationDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ApplicationIDTextBox = New System.Windows.Forms.TextBox()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.PicIC = New System.Windows.Forms.PictureBox()
        Me.PicProof = New System.Windows.Forms.PictureBox()
        ApplicationIDLabel = New System.Windows.Forms.Label()
        UserIDLabel = New System.Windows.Forms.Label()
        lblSeller = New System.Windows.Forms.Label()
        lblProof = New System.Windows.Forms.Label()
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SellerApplicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SellerApplicationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SellerApplicationBindingNavigator.SuspendLayout()
        CType(Me.SellerApplicationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicIC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicProof, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OtralaDBDataSet
        '
        Me.OtralaDBDataSet.DataSetName = "OtralaDBDataSet"
        Me.OtralaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SellerApplicationBindingSource
        '
        Me.SellerApplicationBindingSource.DataMember = "SellerApplication"
        Me.SellerApplicationBindingSource.DataSource = Me.OtralaDBDataSet
        '
        'SellerApplicationTableAdapter
        '
        Me.SellerApplicationTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.SellerApplicationTableAdapter = Me.SellerApplicationTableAdapter
        Me.TableAdapterManager.UpdateOrder = Otrala_2._0.OtralaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserInfoTableAdapter = Nothing
        '
        'SellerApplicationBindingNavigator
        '
        Me.SellerApplicationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SellerApplicationBindingNavigator.AutoSize = False
        Me.SellerApplicationBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SellerApplicationBindingNavigator.BindingSource = Me.SellerApplicationBindingSource
        Me.SellerApplicationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SellerApplicationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SellerApplicationBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SellerApplicationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SellerApplicationBindingNavigatorSaveItem})
        Me.SellerApplicationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SellerApplicationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SellerApplicationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SellerApplicationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SellerApplicationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SellerApplicationBindingNavigator.Name = "SellerApplicationBindingNavigator"
        Me.SellerApplicationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SellerApplicationBindingNavigator.Size = New System.Drawing.Size(1262, 40)
        Me.SellerApplicationBindingNavigator.TabIndex = 0
        Me.SellerApplicationBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 37)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 40)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 37)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'SellerApplicationBindingNavigatorSaveItem
        '
        Me.SellerApplicationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SellerApplicationBindingNavigatorSaveItem.Image = CType(resources.GetObject("SellerApplicationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SellerApplicationBindingNavigatorSaveItem.Name = "SellerApplicationBindingNavigatorSaveItem"
        Me.SellerApplicationBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 37)
        Me.SellerApplicationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SellerApplicationDataGridView
        '
        Me.SellerApplicationDataGridView.AutoGenerateColumns = False
        Me.SellerApplicationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SellerApplicationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewImageColumn1, Me.DataGridViewImageColumn2})
        Me.SellerApplicationDataGridView.DataSource = Me.SellerApplicationBindingSource
        Me.SellerApplicationDataGridView.Location = New System.Drawing.Point(77, 236)
        Me.SellerApplicationDataGridView.Name = "SellerApplicationDataGridView"
        Me.SellerApplicationDataGridView.RowHeadersWidth = 51
        Me.SellerApplicationDataGridView.RowTemplate.Height = 24
        Me.SellerApplicationDataGridView.Size = New System.Drawing.Size(300, 369)
        Me.SellerApplicationDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ApplicationID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ApplicationID"
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
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "ICPic"
        Me.DataGridViewImageColumn1.HeaderText = "ICPic"
        Me.DataGridViewImageColumn1.MinimumWidth = 6
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 125
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.DataPropertyName = "ProofOfAgency"
        Me.DataGridViewImageColumn2.HeaderText = "ProofOfAgency"
        Me.DataGridViewImageColumn2.MinimumWidth = 6
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Width = 125
        '
        'ApplicationIDLabel
        '
        ApplicationIDLabel.AutoSize = True
        ApplicationIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApplicationIDLabel.Location = New System.Drawing.Point(40, 82)
        ApplicationIDLabel.Name = "ApplicationIDLabel"
        ApplicationIDLabel.Size = New System.Drawing.Size(138, 25)
        ApplicationIDLabel.TabIndex = 2
        ApplicationIDLabel.Text = "Application ID:"
        '
        'ApplicationIDTextBox
        '
        Me.ApplicationIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SellerApplicationBindingSource, "ApplicationID", True))
        Me.ApplicationIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationIDTextBox.Location = New System.Drawing.Point(184, 82)
        Me.ApplicationIDTextBox.Name = "ApplicationIDTextBox"
        Me.ApplicationIDTextBox.Size = New System.Drawing.Size(212, 30)
        Me.ApplicationIDTextBox.TabIndex = 3
        '
        'UserIDLabel
        '
        UserIDLabel.AutoSize = True
        UserIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UserIDLabel.Location = New System.Drawing.Point(40, 133)
        UserIDLabel.Name = "UserIDLabel"
        UserIDLabel.Size = New System.Drawing.Size(83, 25)
        UserIDLabel.TabIndex = 4
        UserIDLabel.Text = "User ID:"
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SellerApplicationBindingSource, "UserID", True))
        Me.UserIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserIDTextBox.Location = New System.Drawing.Point(184, 130)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(212, 30)
        Me.UserIDTextBox.TabIndex = 5
        '
        'PicIC
        '
        Me.PicIC.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicIC.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.SellerApplicationBindingSource, "ICPic", True))
        Me.PicIC.Location = New System.Drawing.Point(498, 194)
        Me.PicIC.Name = "PicIC"
        Me.PicIC.Size = New System.Drawing.Size(304, 305)
        Me.PicIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicIC.TabIndex = 32
        Me.PicIC.TabStop = False
        '
        'PicProof
        '
        Me.PicProof.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicProof.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.SellerApplicationBindingSource, "ProofOfAgency", True))
        Me.PicProof.Location = New System.Drawing.Point(845, 194)
        Me.PicProof.Name = "PicProof"
        Me.PicProof.Size = New System.Drawing.Size(332, 305)
        Me.PicProof.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicProof.TabIndex = 33
        Me.PicProof.TabStop = False
        '
        'lblSeller
        '
        lblSeller.AutoSize = True
        lblSeller.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblSeller.Location = New System.Drawing.Point(590, 152)
        lblSeller.Name = "lblSeller"
        lblSeller.Size = New System.Drawing.Size(93, 25)
        lblSeller.TabIndex = 34
        lblSeller.Text = "Seller IC:"
        '
        'lblProof
        '
        lblProof.AutoSize = True
        lblProof.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblProof.Location = New System.Drawing.Point(899, 152)
        lblProof.Name = "lblProof"
        lblProof.Size = New System.Drawing.Size(212, 25)
        lblProof.TabIndex = 35
        lblProof.Text = "Seller Proof of Agency:"
        '
        'SellerApplicationAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(lblProof)
        Me.Controls.Add(lblSeller)
        Me.Controls.Add(Me.PicProof)
        Me.Controls.Add(Me.PicIC)
        Me.Controls.Add(ApplicationIDLabel)
        Me.Controls.Add(Me.ApplicationIDTextBox)
        Me.Controls.Add(UserIDLabel)
        Me.Controls.Add(Me.UserIDTextBox)
        Me.Controls.Add(Me.SellerApplicationDataGridView)
        Me.Controls.Add(Me.SellerApplicationBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SellerApplicationAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seller Application Database"
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SellerApplicationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SellerApplicationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SellerApplicationBindingNavigator.ResumeLayout(False)
        Me.SellerApplicationBindingNavigator.PerformLayout()
        CType(Me.SellerApplicationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicIC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicProof, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OtralaDBDataSet As OtralaDBDataSet
    Friend WithEvents SellerApplicationBindingSource As BindingSource
    Friend WithEvents SellerApplicationTableAdapter As OtralaDBDataSetTableAdapters.SellerApplicationTableAdapter
    Friend WithEvents TableAdapterManager As OtralaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SellerApplicationBindingNavigator As BindingNavigator
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
    Friend WithEvents SellerApplicationBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents SellerApplicationDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents ApplicationIDTextBox As TextBox
    Friend WithEvents UserIDTextBox As TextBox
    Friend WithEvents PicIC As PictureBox
    Friend WithEvents PicProof As PictureBox
End Class
