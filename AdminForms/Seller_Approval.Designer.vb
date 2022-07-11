<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Seller_Approval
    Inherits System.Windows.Forms.Form

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
        Dim lblProof As System.Windows.Forms.Label
        Dim lblSeller As System.Windows.Forms.Label
        Dim ApplicationIDLabel As System.Windows.Forms.Label
        Dim UserIDLabel As System.Windows.Forms.Label
        Dim UserNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Seller_Approval))
        Me.OtralaDBDataSet = New Otrala_2._0.OtralaDBDataSet()
        Me.SellerApplicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SellerApplicationTableAdapter = New Otrala_2._0.OtralaDBDataSetTableAdapters.SellerApplicationTableAdapter()
        Me.TableAdapterManager = New Otrala_2._0.OtralaDBDataSetTableAdapters.TableAdapterManager()
        Me.SellerApplicationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SellerApplicationDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PicProof = New System.Windows.Forms.PictureBox()
        Me.PicIC = New System.Windows.Forms.PictureBox()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.btnDeny = New System.Windows.Forms.Button()
        Me.lblApplicationID = New System.Windows.Forms.Label()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.UserInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserInfoTableAdapter = New Otrala_2._0.OtralaDBDataSetTableAdapters.UserInfoTableAdapter()
        lblProof = New System.Windows.Forms.Label()
        lblSeller = New System.Windows.Forms.Label()
        ApplicationIDLabel = New System.Windows.Forms.Label()
        UserIDLabel = New System.Windows.Forms.Label()
        UserNameLabel = New System.Windows.Forms.Label()
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SellerApplicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SellerApplicationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SellerApplicationBindingNavigator.SuspendLayout()
        CType(Me.SellerApplicationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicProof, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicIC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProof
        '
        lblProof.AutoSize = True
        lblProof.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblProof.Location = New System.Drawing.Point(434, 85)
        lblProof.Name = "lblProof"
        lblProof.Size = New System.Drawing.Size(212, 25)
        lblProof.TabIndex = 39
        lblProof.Text = "Seller Proof of Agency:"
        '
        'lblSeller
        '
        lblSeller.AutoSize = True
        lblSeller.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblSeller.Location = New System.Drawing.Point(125, 85)
        lblSeller.Name = "lblSeller"
        lblSeller.Size = New System.Drawing.Size(93, 25)
        lblSeller.TabIndex = 38
        lblSeller.Text = "Seller IC:"
        '
        'ApplicationIDLabel
        '
        ApplicationIDLabel.AutoSize = True
        ApplicationIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApplicationIDLabel.Location = New System.Drawing.Point(675, 510)
        ApplicationIDLabel.Name = "ApplicationIDLabel"
        ApplicationIDLabel.Size = New System.Drawing.Size(138, 25)
        ApplicationIDLabel.TabIndex = 42
        ApplicationIDLabel.Text = "Application ID:"
        '
        'UserIDLabel
        '
        UserIDLabel.AutoSize = True
        UserIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UserIDLabel.Location = New System.Drawing.Point(675, 561)
        UserIDLabel.Name = "UserIDLabel"
        UserIDLabel.Size = New System.Drawing.Size(83, 25)
        UserIDLabel.TabIndex = 44
        UserIDLabel.Text = "User ID:"
        '
        'UserNameLabel
        '
        UserNameLabel.AutoSize = True
        UserNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UserNameLabel.Location = New System.Drawing.Point(675, 613)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(116, 25)
        UserNameLabel.TabIndex = 47
        UserNameLabel.Text = "User Name:"
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
        Me.SellerApplicationBindingNavigator.AddNewItem = Nothing
        Me.SellerApplicationBindingNavigator.AutoSize = False
        Me.SellerApplicationBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SellerApplicationBindingNavigator.BindingSource = Me.SellerApplicationBindingSource
        Me.SellerApplicationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SellerApplicationBindingNavigator.DeleteItem = Nothing
        Me.SellerApplicationBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SellerApplicationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 37)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'SellerApplicationDataGridView
        '
        Me.SellerApplicationDataGridView.AutoGenerateColumns = False
        Me.SellerApplicationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SellerApplicationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewImageColumn1, Me.DataGridViewImageColumn2})
        Me.SellerApplicationDataGridView.DataSource = Me.SellerApplicationBindingSource
        Me.SellerApplicationDataGridView.Location = New System.Drawing.Point(781, 127)
        Me.SellerApplicationDataGridView.Name = "SellerApplicationDataGridView"
        Me.SellerApplicationDataGridView.RowHeadersWidth = 51
        Me.SellerApplicationDataGridView.RowTemplate.Height = 24
        Me.SellerApplicationDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.SellerApplicationDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ApplicationID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ApplicationID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "UserID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "UserID"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
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
        'PicProof
        '
        Me.PicProof.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicProof.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.SellerApplicationBindingSource, "ProofOfAgency", True))
        Me.PicProof.Location = New System.Drawing.Point(380, 127)
        Me.PicProof.Name = "PicProof"
        Me.PicProof.Size = New System.Drawing.Size(332, 305)
        Me.PicProof.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicProof.TabIndex = 37
        Me.PicProof.TabStop = False
        '
        'PicIC
        '
        Me.PicIC.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicIC.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.SellerApplicationBindingSource, "ICPic", True))
        Me.PicIC.Location = New System.Drawing.Point(33, 127)
        Me.PicIC.Name = "PicIC"
        Me.PicIC.Size = New System.Drawing.Size(304, 305)
        Me.PicIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicIC.TabIndex = 36
        Me.PicIC.TabStop = False
        '
        'btnApprove
        '
        Me.btnApprove.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnApprove.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApprove.ForeColor = System.Drawing.Color.White
        Me.btnApprove.Location = New System.Drawing.Point(48, 531)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(213, 85)
        Me.btnApprove.TabIndex = 40
        Me.btnApprove.Text = "Approve Seller Application"
        Me.btnApprove.UseVisualStyleBackColor = False
        '
        'btnDeny
        '
        Me.btnDeny.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnDeny.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeny.ForeColor = System.Drawing.Color.White
        Me.btnDeny.Location = New System.Drawing.Point(267, 531)
        Me.btnDeny.Name = "btnDeny"
        Me.btnDeny.Size = New System.Drawing.Size(213, 85)
        Me.btnDeny.TabIndex = 41
        Me.btnDeny.Text = "Deny Seller Application"
        Me.btnDeny.UseVisualStyleBackColor = False
        '
        'lblApplicationID
        '
        Me.lblApplicationID.AutoSize = True
        Me.lblApplicationID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SellerApplicationBindingSource, "ApplicationID", True))
        Me.lblApplicationID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApplicationID.Location = New System.Drawing.Point(834, 510)
        Me.lblApplicationID.Name = "lblApplicationID"
        Me.lblApplicationID.Size = New System.Drawing.Size(156, 25)
        Me.lblApplicationID.TabIndex = 45
        Me.lblApplicationID.Text = "<Application ID>"
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SellerApplicationBindingSource, "UserID", True))
        Me.lblUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(834, 561)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(101, 25)
        Me.lblUserID.TabIndex = 46
        Me.lblUserID.Text = "<User ID>"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(834, 613)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(134, 25)
        Me.lblUserName.TabIndex = 48
        Me.lblUserName.Text = "<User Name>"
        '
        'UserInfoTableAdapter
        '
        Me.UserInfoTableAdapter.ClearBeforeFill = True
        '
        'Seller_Approval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(UserNameLabel)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.lblApplicationID)
        Me.Controls.Add(ApplicationIDLabel)
        Me.Controls.Add(UserIDLabel)
        Me.Controls.Add(Me.btnDeny)
        Me.Controls.Add(Me.btnApprove)
        Me.Controls.Add(lblProof)
        Me.Controls.Add(lblSeller)
        Me.Controls.Add(Me.PicProof)
        Me.Controls.Add(Me.PicIC)
        Me.Controls.Add(Me.SellerApplicationDataGridView)
        Me.Controls.Add(Me.SellerApplicationBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Seller_Approval"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seller_Approval"
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SellerApplicationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SellerApplicationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SellerApplicationBindingNavigator.ResumeLayout(False)
        Me.SellerApplicationBindingNavigator.PerformLayout()
        CType(Me.SellerApplicationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicProof, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicIC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OtralaDBDataSet As OtralaDBDataSet
    Friend WithEvents SellerApplicationBindingSource As BindingSource
    Friend WithEvents SellerApplicationTableAdapter As OtralaDBDataSetTableAdapters.SellerApplicationTableAdapter
    Friend WithEvents TableAdapterManager As OtralaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SellerApplicationBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents SellerApplicationDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents PicProof As PictureBox
    Friend WithEvents PicIC As PictureBox
    Friend WithEvents btnApprove As Button
    Friend WithEvents btnDeny As Button
    Friend WithEvents lblApplicationID As Label
    Friend WithEvents lblUserID As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents UserInfoBindingSource As BindingSource
    Friend WithEvents UserInfoTableAdapter As OtralaDBDataSetTableAdapters.UserInfoTableAdapter
End Class
