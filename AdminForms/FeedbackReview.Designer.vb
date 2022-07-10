<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FeedbackReview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FeedbackReview))
        Me.OtralaDBDataSet = New Otrala_2._0.OtralaDBDataSet()
        Me.FeedbackBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FeedbackTableAdapter = New Otrala_2._0.OtralaDBDataSetTableAdapters.FeedbackTableAdapter()
        Me.TableAdapterManager = New Otrala_2._0.OtralaDBDataSetTableAdapters.TableAdapterManager()
        Me.FeedbackBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSentBy = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.FeedbackDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.CBType = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UserInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserInfoTableAdapter = New Otrala_2._0.OtralaDBDataSetTableAdapters.UserInfoTableAdapter()
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FeedbackBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FeedbackBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FeedbackBindingNavigator.SuspendLayout()
        CType(Me.FeedbackDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OtralaDBDataSet
        '
        Me.OtralaDBDataSet.DataSetName = "OtralaDBDataSet"
        Me.OtralaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FeedbackBindingSource
        '
        Me.FeedbackBindingSource.DataMember = "Feedback"
        Me.FeedbackBindingSource.DataSource = Me.OtralaDBDataSet
        '
        'FeedbackTableAdapter
        '
        Me.FeedbackTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookingTableAdapter = Nothing
        Me.TableAdapterManager.FeedbackTableAdapter = Me.FeedbackTableAdapter
        Me.TableAdapterManager.LoginInfoTableAdapter = Nothing
        Me.TableAdapterManager.PackageTableAdapter = Nothing
        Me.TableAdapterManager.RequestAnswerTableAdapter = Nothing
        Me.TableAdapterManager.RequestTableAdapter = Nothing
        Me.TableAdapterManager.SellerApplicationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Otrala_2._0.OtralaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserInfoTableAdapter = Nothing
        '
        'FeedbackBindingNavigator
        '
        Me.FeedbackBindingNavigator.AddNewItem = Nothing
        Me.FeedbackBindingNavigator.AutoSize = False
        Me.FeedbackBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FeedbackBindingNavigator.BindingSource = Me.FeedbackBindingSource
        Me.FeedbackBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FeedbackBindingNavigator.DeleteItem = Nothing
        Me.FeedbackBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FeedbackBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.FeedbackBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FeedbackBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FeedbackBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FeedbackBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FeedbackBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FeedbackBindingNavigator.Name = "FeedbackBindingNavigator"
        Me.FeedbackBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FeedbackBindingNavigator.Size = New System.Drawing.Size(1282, 40)
        Me.FeedbackBindingNavigator.TabIndex = 1
        Me.FeedbackBindingNavigator.Text = "BindingNavigator1"
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
        'lblTitle
        '
        Me.lblTitle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FeedbackBindingSource, "Title", True))
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(25, 277)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(571, 23)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "<Title>"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FeedbackBindingSource, "FeedbackID", True))
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(165, 343)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(147, 25)
        Me.lblID.TabIndex = 3
        Me.lblID.Text = "<Feedback ID>"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(349, 343)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Tag = ""
        Me.Label3.Text = "Type :"
        '
        'lblSentBy
        '
        Me.lblSentBy.AutoSize = True
        Me.lblSentBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSentBy.Location = New System.Drawing.Point(30, 406)
        Me.lblSentBy.Name = "lblSentBy"
        Me.lblSentBy.Size = New System.Drawing.Size(222, 25)
        Me.lblSentBy.TabIndex = 5
        Me.lblSentBy.Text = "<Sent by User on Date>"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 343)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "FeedbackID :"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FeedbackBindingSource, "Type", True))
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(423, 343)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(173, 25)
        Me.lblType.TabIndex = 7
        Me.lblType.Text = "<Feedback Type>"
        '
        'lblDescription
        '
        Me.lblDescription.AllowDrop = True
        Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescription.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FeedbackBindingSource, "Description", True))
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(30, 476)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(566, 173)
        Me.lblDescription.TabIndex = 8
        Me.lblDescription.Text = "<Description>"
        '
        'FeedbackDataGridView
        '
        Me.FeedbackDataGridView.AutoGenerateColumns = False
        Me.FeedbackDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FeedbackDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Type, Me.DataGridViewTextBoxColumn4})
        Me.FeedbackDataGridView.DataSource = Me.FeedbackBindingSource
        Me.FeedbackDataGridView.Location = New System.Drawing.Point(717, 75)
        Me.FeedbackDataGridView.Name = "FeedbackDataGridView"
        Me.FeedbackDataGridView.RowHeadersWidth = 51
        Me.FeedbackDataGridView.RowTemplate.Height = 24
        Me.FeedbackDataGridView.Size = New System.Drawing.Size(553, 574)
        Me.FeedbackDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "FeedbackID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'Type
        '
        Me.Type.DataPropertyName = "Type"
        Me.Type.HeaderText = "Type"
        Me.Type.MinimumWidth = 6
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        Me.Type.Width = 90
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "UserID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "UserID"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 60
        '
        'txtFind
        '
        Me.txtFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFind.Location = New System.Drawing.Point(232, 75)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(279, 30)
        Me.txtFind.TabIndex = 9
        '
        'CBType
        '
        Me.CBType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBType.FormattingEnabled = True
        Me.CBType.Items.AddRange(New Object() {"Request", "Question", "Problem"})
        Me.CBType.Location = New System.Drawing.Point(232, 136)
        Me.CBType.Name = "CBType"
        Me.CBType.Size = New System.Drawing.Size(204, 33)
        Me.CBType.TabIndex = 20
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = Global.Otrala_2._0.My.Resources.Resources.Search_Icon
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSearch.Location = New System.Drawing.Point(534, 75)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(94, 94)
        Me.btnSearch.TabIndex = 21
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 25)
        Me.Label2.TabIndex = 22
        Me.Label2.Tag = ""
        Me.Label2.Text = "Feedback Type :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 25)
        Me.Label4.TabIndex = 23
        Me.Label4.Tag = ""
        Me.Label4.Text = "Search Term :"
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
        'FeedbackReview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1282, 694)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.CBType)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.FeedbackDataGridView)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSentBy)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.FeedbackBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FeedbackReview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Feedback/Review"
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FeedbackBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FeedbackBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FeedbackBindingNavigator.ResumeLayout(False)
        Me.FeedbackBindingNavigator.PerformLayout()
        CType(Me.FeedbackDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OtralaDBDataSet As OtralaDBDataSet
    Friend WithEvents FeedbackBindingSource As BindingSource
    Friend WithEvents FeedbackTableAdapter As OtralaDBDataSetTableAdapters.FeedbackTableAdapter
    Friend WithEvents TableAdapterManager As OtralaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FeedbackBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblID As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSentBy As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents FeedbackDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents txtFind As TextBox
    Friend WithEvents CBType As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents UserInfoBindingSource As BindingSource
    Friend WithEvents UserInfoTableAdapter As OtralaDBDataSetTableAdapters.UserInfoTableAdapter
End Class
