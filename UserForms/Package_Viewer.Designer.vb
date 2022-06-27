<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Package_Viewer
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
        Me.pctTravelPic = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tableDetails = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblLocationValue = New System.Windows.Forms.Label()
        Me.lblStateValue = New System.Windows.Forms.Label()
        Me.lblPax = New System.Windows.Forms.Label()
        Me.lblPaxValue = New System.Windows.Forms.Label()
        Me.lblDescriptionValue = New System.Windows.Forms.Label()
        Me.lblDurationValue = New System.Windows.Forms.Label()
        Me.lblTourOperator = New System.Windows.Forms.Label()
        Me.lblTourOperatorValue = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.btnWishlist = New System.Windows.Forms.Button()
        Me.after_load = New System.Windows.Forms.Timer(Me.components)
        Me.btnSeller = New System.Windows.Forms.Button()
        Me.pctSeller = New System.Windows.Forms.PictureBox()
        Me.blocking_panel = New System.Windows.Forms.Panel()
        CType(Me.pctTravelPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.tableDetails.SuspendLayout()
        CType(Me.pctSeller, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctTravelPic
        '
        Me.pctTravelPic.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pctTravelPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctTravelPic.Location = New System.Drawing.Point(12, 12)
        Me.pctTravelPic.Name = "pctTravelPic"
        Me.pctTravelPic.Size = New System.Drawing.Size(600, 600)
        Me.pctTravelPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctTravelPic.TabIndex = 0
        Me.pctTravelPic.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(618, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(603, 116)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Title"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDescription.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDescription.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescription.Location = New System.Drawing.Point(3, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Padding = New System.Windows.Forms.Padding(5)
        Me.lblDescription.Size = New System.Drawing.Size(164, 33)
        Me.lblDescription.TabIndex = 2
        Me.lblDescription.Text = "Description"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.tableDetails)
        Me.Panel1.Location = New System.Drawing.Point(618, 273)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel1.Size = New System.Drawing.Size(603, 339)
        Me.Panel1.TabIndex = 3
        '
        'tableDetails
        '
        Me.tableDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tableDetails.ColumnCount = 2
        Me.tableDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.6796!))
        Me.tableDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.3204!))
        Me.tableDetails.Controls.Add(Me.lblDuration, 0, 4)
        Me.tableDetails.Controls.Add(Me.lblDescription, 0, 0)
        Me.tableDetails.Controls.Add(Me.lblLocation, 0, 1)
        Me.tableDetails.Controls.Add(Me.lblState, 0, 2)
        Me.tableDetails.Controls.Add(Me.lblLocationValue, 1, 1)
        Me.tableDetails.Controls.Add(Me.lblStateValue, 1, 2)
        Me.tableDetails.Controls.Add(Me.lblPax, 0, 3)
        Me.tableDetails.Controls.Add(Me.lblPaxValue, 1, 3)
        Me.tableDetails.Controls.Add(Me.lblDescriptionValue, 1, 0)
        Me.tableDetails.Controls.Add(Me.lblDurationValue, 1, 4)
        Me.tableDetails.Controls.Add(Me.lblTourOperator, 0, 5)
        Me.tableDetails.Controls.Add(Me.lblTourOperatorValue, 1, 5)
        Me.tableDetails.Location = New System.Drawing.Point(11, 25)
        Me.tableDetails.Name = "tableDetails"
        Me.tableDetails.RowCount = 6
        Me.tableDetails.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableDetails.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableDetails.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableDetails.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableDetails.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableDetails.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableDetails.Size = New System.Drawing.Size(573, 234)
        Me.tableDetails.TabIndex = 5
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblDuration.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDuration.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDuration.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDuration.Location = New System.Drawing.Point(3, 132)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Padding = New System.Windows.Forms.Padding(5)
        Me.lblDuration.Size = New System.Drawing.Size(164, 33)
        Me.lblDuration.TabIndex = 12
        Me.lblDuration.Text = "Duration"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblLocation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLocation.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLocation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLocation.Location = New System.Drawing.Point(3, 33)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Padding = New System.Windows.Forms.Padding(5)
        Me.lblLocation.Size = New System.Drawing.Size(164, 33)
        Me.lblLocation.TabIndex = 4
        Me.lblLocation.Text = "Location"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblState.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblState.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblState.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblState.Location = New System.Drawing.Point(3, 66)
        Me.lblState.Name = "lblState"
        Me.lblState.Padding = New System.Windows.Forms.Padding(5)
        Me.lblState.Size = New System.Drawing.Size(164, 33)
        Me.lblState.TabIndex = 5
        Me.lblState.Text = "State"
        '
        'lblLocationValue
        '
        Me.lblLocationValue.AutoSize = True
        Me.lblLocationValue.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLocationValue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLocationValue.Location = New System.Drawing.Point(173, 33)
        Me.lblLocationValue.Name = "lblLocationValue"
        Me.lblLocationValue.Padding = New System.Windows.Forms.Padding(5)
        Me.lblLocationValue.Size = New System.Drawing.Size(48, 33)
        Me.lblLocationValue.TabIndex = 7
        Me.lblLocationValue.Text = "null"
        '
        'lblStateValue
        '
        Me.lblStateValue.AutoSize = True
        Me.lblStateValue.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblStateValue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStateValue.Location = New System.Drawing.Point(173, 66)
        Me.lblStateValue.Name = "lblStateValue"
        Me.lblStateValue.Padding = New System.Windows.Forms.Padding(5)
        Me.lblStateValue.Size = New System.Drawing.Size(48, 33)
        Me.lblStateValue.TabIndex = 8
        Me.lblStateValue.Text = "null"
        '
        'lblPax
        '
        Me.lblPax.AutoSize = True
        Me.lblPax.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblPax.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPax.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPax.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPax.Location = New System.Drawing.Point(3, 99)
        Me.lblPax.Name = "lblPax"
        Me.lblPax.Padding = New System.Windows.Forms.Padding(5)
        Me.lblPax.Size = New System.Drawing.Size(164, 33)
        Me.lblPax.TabIndex = 9
        Me.lblPax.Text = "Pax"
        '
        'lblPaxValue
        '
        Me.lblPaxValue.AutoSize = True
        Me.lblPaxValue.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPaxValue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPaxValue.Location = New System.Drawing.Point(173, 99)
        Me.lblPaxValue.Name = "lblPaxValue"
        Me.lblPaxValue.Padding = New System.Windows.Forms.Padding(5)
        Me.lblPaxValue.Size = New System.Drawing.Size(48, 33)
        Me.lblPaxValue.TabIndex = 13
        Me.lblPaxValue.Text = "null"
        '
        'lblDescriptionValue
        '
        Me.lblDescriptionValue.AutoSize = True
        Me.lblDescriptionValue.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDescriptionValue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescriptionValue.Location = New System.Drawing.Point(173, 0)
        Me.lblDescriptionValue.Name = "lblDescriptionValue"
        Me.lblDescriptionValue.Padding = New System.Windows.Forms.Padding(5)
        Me.lblDescriptionValue.Size = New System.Drawing.Size(48, 33)
        Me.lblDescriptionValue.TabIndex = 6
        Me.lblDescriptionValue.Text = "null"
        '
        'lblDurationValue
        '
        Me.lblDurationValue.AutoSize = True
        Me.lblDurationValue.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDurationValue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDurationValue.Location = New System.Drawing.Point(173, 132)
        Me.lblDurationValue.Name = "lblDurationValue"
        Me.lblDurationValue.Padding = New System.Windows.Forms.Padding(5)
        Me.lblDurationValue.Size = New System.Drawing.Size(48, 33)
        Me.lblDurationValue.TabIndex = 11
        Me.lblDurationValue.Text = "null"
        '
        'lblTourOperator
        '
        Me.lblTourOperator.AutoSize = True
        Me.lblTourOperator.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblTourOperator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTourOperator.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTourOperator.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTourOperator.Location = New System.Drawing.Point(3, 165)
        Me.lblTourOperator.Name = "lblTourOperator"
        Me.lblTourOperator.Padding = New System.Windows.Forms.Padding(5)
        Me.lblTourOperator.Size = New System.Drawing.Size(164, 69)
        Me.lblTourOperator.TabIndex = 10
        Me.lblTourOperator.Text = "Tour Operator"
        '
        'lblTourOperatorValue
        '
        Me.lblTourOperatorValue.AutoSize = True
        Me.lblTourOperatorValue.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTourOperatorValue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTourOperatorValue.Location = New System.Drawing.Point(173, 165)
        Me.lblTourOperatorValue.Name = "lblTourOperatorValue"
        Me.lblTourOperatorValue.Padding = New System.Windows.Forms.Padding(5)
        Me.lblTourOperatorValue.Size = New System.Drawing.Size(48, 33)
        Me.lblTourOperatorValue.TabIndex = 14
        Me.lblTourOperatorValue.Text = "null"
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblPrice.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.lblPrice.Location = New System.Drawing.Point(618, 146)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(603, 105)
        Me.lblPrice.TabIndex = 4
        Me.lblPrice.Text = "RM price"
        '
        'btnBook
        '
        Me.btnBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBook.Font = New System.Drawing.Font("Arial Black", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBook.Location = New System.Drawing.Point(893, 702)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(328, 108)
        Me.btnBook.TabIndex = 5
        Me.btnBook.Text = "Book this Trip"
        Me.btnBook.UseVisualStyleBackColor = False
        '
        'btnWishlist
        '
        Me.btnWishlist.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnWishlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWishlist.Font = New System.Drawing.Font("Arial Black", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnWishlist.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnWishlist.Location = New System.Drawing.Point(559, 702)
        Me.btnWishlist.Name = "btnWishlist"
        Me.btnWishlist.Size = New System.Drawing.Size(328, 108)
        Me.btnWishlist.TabIndex = 7
        Me.btnWishlist.Text = "Add to Wishlist"
        Me.btnWishlist.UseVisualStyleBackColor = False
        '
        'after_load
        '
        Me.after_load.Enabled = True
        Me.after_load.Interval = 1
        '
        'btnSeller
        '
        Me.btnSeller.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnSeller.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeller.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSeller.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSeller.Location = New System.Drawing.Point(126, 702)
        Me.btnSeller.Name = "btnSeller"
        Me.btnSeller.Size = New System.Drawing.Size(251, 108)
        Me.btnSeller.TabIndex = 8
        Me.btnSeller.Text = "More From seller_name"
        Me.btnSeller.UseVisualStyleBackColor = False
        '
        'pctSeller
        '
        Me.pctSeller.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pctSeller.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctSeller.Location = New System.Drawing.Point(12, 702)
        Me.pctSeller.Name = "pctSeller"
        Me.pctSeller.Size = New System.Drawing.Size(108, 108)
        Me.pctSeller.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctSeller.TabIndex = 9
        Me.pctSeller.TabStop = False
        '
        'blocking_panel
        '
        Me.blocking_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.blocking_panel.Location = New System.Drawing.Point(1, 837)
        Me.blocking_panel.Name = "blocking_panel"
        Me.blocking_panel.Size = New System.Drawing.Size(1240, 28)
        Me.blocking_panel.TabIndex = 10
        '
        'Package_Viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.blocking_panel)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pctSeller)
        Me.Controls.Add(Me.btnSeller)
        Me.Controls.Add(Me.btnBook)
        Me.Controls.Add(Me.btnWishlist)
        Me.Controls.Add(Me.pctTravelPic)
        Me.Name = "Package_Viewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Package Name"
        CType(Me.pctTravelPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.tableDetails.ResumeLayout(False)
        Me.tableDetails.PerformLayout()
        CType(Me.pctSeller, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pctTravelPic As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tableDetails As TableLayoutPanel
    Friend WithEvents lblLocation As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblTourOperatorValue As Label
    Friend WithEvents lblDuration As Label
    Friend WithEvents lblDurationValue As Label
    Friend WithEvents lblTourOperator As Label
    Friend WithEvents lblLocationValue As Label
    Friend WithEvents lblStateValue As Label
    Friend WithEvents lblPax As Label
    Friend WithEvents lblPaxValue As Label
    Friend WithEvents lblDescriptionValue As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents btnBook As Button
    Friend WithEvents btnWishlist As Button
    Friend WithEvents after_load As Timer
    Friend WithEvents btnSeller As Button
    Friend WithEvents pctSeller As PictureBox
    Friend WithEvents blocking_panel As Panel
End Class
