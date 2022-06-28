Public Class Catalogue
    Dim CatalogueIndex As Long = 1 ' Index of catalogue items.
    Dim CatalogueYIndex As Integer = 0 ' Start displaying catalogues from which row.

    Private Sub GenerateCatalogue(Count As Integer)
        ' Count will determine how many catalogues to generate.
        ' Change to how many database logs we have after we make the database.

        Const Dx As Integer = 505 ' Distance between catalogues in the same row.
        Const Dy As Integer = 363 ' Distance between catalogues between rows.

        ' Lines below with ** need to be substituted with database calling (added so we remember later lol)

        For CatalogueIndex = CatalogueIndex To CatalogueIndex + Count - 1
            Dim NewLblTitle As New Label
            With NewLblTitle
                .Location = New System.Drawing.Point(175, 29)
                .Name = "LblTitleCatalogue" & CatalogueIndex
                .Size = New System.Drawing.Size(236, 48)
                .TabIndex = 13
                .Text = "Trip to KUALA LUMPUR" ' **
            End With

            Dim NewLblSeller As New Label
            With NewLblSeller
                .BackColor = System.Drawing.SystemColors.Window
                .Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
                .ForeColor = System.Drawing.SystemColors.ControlDark
                .Location = New System.Drawing.Point(175, 280)
                .Name = "LblSellerCatalogue" & CatalogueIndex
                .Size = New System.Drawing.Size(254, 23)
                .TabIndex = 13
                .Text = "Irfan Haziq and CO" ' **
                .TextAlign = System.Drawing.ContentAlignment.MiddleRight
            End With

            Dim NewLblDesc As New Label
            With NewLblDesc
                .Location = New System.Drawing.Point(175, 151)
                .Name = "LblDescCatalogue" & CatalogueIndex
                .Size = New System.Drawing.Size(236, 117)
                .TabIndex = 13
                .Text = "Desc Goes Here" ' **
            End With

            Dim NewLblDuration As New Label
            With NewLblDuration
                .Location = New System.Drawing.Point(175, 77)
                .Name = "LblDurationCatalogue" & CatalogueIndex
                .Size = New System.Drawing.Size(107, 59)
                .TabIndex = 13
                .Text = "5 NIGHTS 4 DAYS" ' **
            End With

            Dim NewLblPrice As New Label
            With NewLblPrice
                .Location = New System.Drawing.Point(17, 210)
                .Name = "LblPriceCatalogue" & CatalogueIndex
                .Size = New System.Drawing.Size(152, 24)
                .TabIndex = 13
                .Text = "RM1000.00" ' **
            End With

            Dim NewLblPax As New Label
            With NewLblPax
                .Location = New System.Drawing.Point(17, 244)
                .Name = "LblPaxCatalogue" & CatalogueIndex
                .Size = New System.Drawing.Size(152, 24)
                .TabIndex = 13
                .Text = "5 Person" ' **
            End With

            Dim NewPicBox As New PictureBox
            With NewPicBox
                .Image = Nothing ' **
                .Location = New System.Drawing.Point(17, 29)
                .Name = "PictureBox" & CatalogueIndex
                .Size = New System.Drawing.Size(140, 140)
                .SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
                .TabIndex = 0
                .TabStop = False
            End With


            Dim NewGrpBox As New GroupBox
            With NewGrpBox
                .BackColor = System.Drawing.SystemColors.Window
                .Size = New System.Drawing.Size(435, 306)
                .Location = New System.Drawing.Point(58, 56)
                .Name = "GrpBoxCatalogue" & CatalogueIndex
                ' DO NOT CHANGE THE ORDER OF THE CONTROLS BELOW (code will 100% break)
                .Controls.Add(NewLblDesc)
                .Controls.Add(NewLblDuration)
                .Controls.Add(NewLblPax)
                .Controls.Add(NewLblPrice)
                .Controls.Add(NewLblSeller)
                .Controls.Add(NewLblTitle)
                .Controls.Add(NewPicBox)
            End With

            PnlCatalogue.Controls.Add(NewGrpBox)
            NewGrpBox.Top += Dy * CatalogueYIndex

            ' Connect each control to Catalogue_Click.
            AddHandler NewLblTitle.Click, AddressOf Catalogue_Click
            AddHandler NewLblSeller.Click, AddressOf Catalogue_Click
            AddHandler NewLblDesc.Click, AddressOf Catalogue_Click
            AddHandler NewLblDuration.Click, AddressOf Catalogue_Click
            AddHandler NewLblPrice.Click, AddressOf Catalogue_Click
            AddHandler NewLblPax.Click, AddressOf Catalogue_Click
            AddHandler NewPicBox.Click, AddressOf Catalogue_Click
            AddHandler NewGrpBox.Click, AddressOf Catalogue_Click

            If CatalogueIndex Mod 2 = 0 Then
                NewGrpBox.Left += Dx
                CatalogueYIndex += 1
            End If

        Next
    End Sub

    Private Sub LoadForm() Handles Me.Load
        GenerateCatalogue(10)
    End Sub

    Private Sub DoneScroll() Handles PnlCatalogue.Scroll

    End Sub

    ' Code to view package details. (start)

    Shared package As New Package
    Private Sub Catalogue_Click(sender As Object, e As EventArgs)

        Dim retrieved As Object

        If sender.GetType <> GetType(GroupBox) Then
            retrieved = sender.Parent
        Else
            retrieved = sender
        End If

        ' Based on order they are added on top, DO NOT CHANGE THE ORDER.
        ' Changing order will break the code.
        ' Maybe will change to fetch straight from database.
        Dim description As Object = retrieved.Controls.Item(0)  ' description
        Dim duration As Object = retrieved.Controls.Item(1)     ' duration
        Dim pax As Object = retrieved.Controls.Item(2)          ' pax
        Dim price As Object = retrieved.Controls.Item(3)        ' price
        Dim sellername As Object = retrieved.Controls.Item(4)   ' seller
        Dim packagename As Object = retrieved.Controls.Item(5)  ' package title
        Dim picbox As Object = retrieved.Controls.Item(6)       ' picture box

        With package
            ' Fill up package class with info values.
            .Name = packagename.Text
            .Price = price.Text
            .Description = description.Text
            .SellerID = "" ' need values (maybe from database?)
            .State = "" ' need values (maybe from database?)
            .Location = "" ' need values (maybe from database?)
            .Pax = pax.Text
            .Duration = duration.Text
            .SellerName = sellername.Text
            .Image = picbox.Image
        End With

        Package_Viewer.ShowDialog()
    End Sub
    Function send_package()
        ' Sends package info to other forms.
        Return package
    End Function

    Private Sub DoneScroll(sender As Object, e As ScrollEventArgs) Handles PnlCatalogue.Scroll

    End Sub

    ' Code to view package details. (end)


    ' What to Add Next:
    ' add an invisible label with index (use this to access database) (can wait until database is made)
End Class
