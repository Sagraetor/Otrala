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
        Me.PnlCatalogue = New System.Windows.Forms.Panel()
        Me.PackageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OtralaDBDataSet = New Otrala_2._0.OtralaDBDataSet()
        Me.PackageTableAdapter = New Otrala_2._0.OtralaDBDataSetTableAdapters.PackageTableAdapter()
        Me.BtnWishlist = New System.Windows.Forms.Button()
        Me.BtnRecommendation = New System.Windows.Forms.Button()
        Me.BtnRequest = New System.Windows.Forms.Button()
        CType(Me.PackageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlCatalogue
        '
        Me.PnlCatalogue.AutoScroll = True
        Me.PnlCatalogue.Location = New System.Drawing.Point(186, 110)
        Me.PnlCatalogue.Name = "PnlCatalogue"
        Me.PnlCatalogue.Size = New System.Drawing.Size(1076, 563)
        Me.PnlCatalogue.TabIndex = 13
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
        'BtnWishlist
        '
        Me.BtnWishlist.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnWishlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnWishlist.Location = New System.Drawing.Point(0, 166)
        Me.BtnWishlist.Name = "BtnWishlist"
        Me.BtnWishlist.Size = New System.Drawing.Size(186, 50)
        Me.BtnWishlist.TabIndex = 5
        Me.BtnWishlist.Text = "My Wishlist"
        Me.BtnWishlist.UseVisualStyleBackColor = False
        '
        'BtnRecommendation
        '
        Me.BtnRecommendation.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnRecommendation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRecommendation.Location = New System.Drawing.Point(0, 110)
        Me.BtnRecommendation.Name = "BtnRecommendation"
        Me.BtnRecommendation.Size = New System.Drawing.Size(186, 50)
        Me.BtnRecommendation.TabIndex = 5
        Me.BtnRecommendation.Text = "Recommendations"
        Me.BtnRecommendation.UseVisualStyleBackColor = False
        '
        'BtnRequest
        '
        Me.BtnRequest.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRequest.Location = New System.Drawing.Point(0, 222)
        Me.BtnRequest.Name = "BtnRequest"
        Me.BtnRequest.Size = New System.Drawing.Size(186, 50)
        Me.BtnRequest.TabIndex = 5
        Me.BtnRequest.Text = "My Requests"
        Me.BtnRequest.UseVisualStyleBackColor = False
        '
        'Catalogue
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.BtnRecommendation)
        Me.Controls.Add(Me.BtnRequest)
        Me.Controls.Add(Me.BtnWishlist)
        Me.Controls.Add(Me.PnlCatalogue)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "Catalogue"
        Me.Controls.SetChildIndex(Me.PnlCatalogue, 0)
        Me.Controls.SetChildIndex(Me.BtnWishlist, 0)
        Me.Controls.SetChildIndex(Me.BtnRequest, 0)
        Me.Controls.SetChildIndex(Me.BtnRecommendation, 0)
        CType(Me.PackageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OtralaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlCatalogue As Panel
    Friend WithEvents PackageBindingSource As BindingSource
    Friend WithEvents OtralaDBDataSet As OtralaDBDataSet
    Friend WithEvents PackageTableAdapter As OtralaDBDataSetTableAdapters.PackageTableAdapter
    Friend WithEvents BtnWishlist As Button
    Friend WithEvents BtnRecommendation As Button
    Friend WithEvents BtnRequest As Button
End Class
