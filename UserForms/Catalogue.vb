﻿Public Class Catalogue

    Dim CatalogueIndex As Long = 1 ' Index of catalogue items.
    Dim CatalogueYIndex As Integer = 0 ' Start displaying catalogues from which row.

    Dim CatalogueList As New List(Of Package)

    Function Shuffle(Of T)(list As IEnumerable(Of T)) As List(Of T)
        Dim r = New Random
        Dim shuffled = list.ToList
        For index = 0 To shuffled.Count - 1
            Dim randomIndex = r.Next(index, shuffled.Count)
            If index <> randomIndex Then
                Dim temp = shuffled(index)
                shuffled(index) = shuffled(randomIndex)
                shuffled(randomIndex) = temp
            End If
        Next
        Return shuffled
    End Function

    Private Sub GenerateCatalogue(CatalogueItems As List(Of Package))
        CatalogueIndex = 1
        CatalogueYIndex = 0
        ' Count will determine how many catalogues to generate.
        ' Change to how many database logs we have after we make the database.

        Const Dx As Integer = 505 ' Distance between catalogues in the same row.
        Const Dy As Integer = 363 ' Distance between catalogues between rows.

        ' Lines below with ** need to be substituted with database calling (added so we remember later lol)

        For Each CatalogueItem In CatalogueItems
            Dim NewLblTitle As New Label
            With NewLblTitle
                .Location = New System.Drawing.Point(175, 29)
                .Name = "LblTitleCatalogue" & CatalogueIndex
                .Size = New System.Drawing.Size(236, 48)
                .TabIndex = 13
                .Text = CatalogueItem.PackageName
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
                .Text = CatalogueItem.SellerName
                .TextAlign = System.Drawing.ContentAlignment.MiddleRight
            End With

            Dim NewLblDesc As New Label
            With NewLblDesc
                .Location = New System.Drawing.Point(175, 151)
                .Name = "LblDescCatalogue" & CatalogueIndex
                .Size = New System.Drawing.Size(236, 117)
                .TabIndex = 13
                .Text = CatalogueItem.Description
            End With

            Dim NewLblDuration As New Label
            With NewLblDuration
                .Location = New System.Drawing.Point(175, 77)
                .Name = "LblDurationCatalogue" & CatalogueIndex
                .Size = New System.Drawing.Size(107, 59)
                .TabIndex = 13
                If CatalogueItem.Duration > 2 Then
                    .Text = CatalogueItem.Duration & " DAYS " & System.Environment.NewLine & CInt(CatalogueItem.Duration) - 1 & " NIGHTS"
                ElseIf CatalogueItem.Duration > 1 Then
                    .Text = CatalogueItem.Duration & " DAYS " & System.Environment.NewLine & CInt(CatalogueItem.Duration) - 1 & " NIGHT"
                Else
                    .Text = CatalogueItem.Duration & " DAY "
                End If
            End With

            Dim NewLblPrice As New Label
            With NewLblPrice
                .Location = New System.Drawing.Point(17, 210)
                .Name = "LblPriceCatalogue" & CatalogueIndex
                .Size = New System.Drawing.Size(152, 24)
                .TabIndex = 13
                .Text = CatalogueItem.Price.ToString("C")
            End With

            Dim NewLblPax As New Label
            With NewLblPax
                .Location = New System.Drawing.Point(17, 244)
                .Name = "LblPaxCatalogue" & CatalogueIndex
                .Size = New System.Drawing.Size(152, 24)
                .TabIndex = 13
                .Text = CatalogueItem.Pax & " Person"
            End With

            Dim NewPicBox As New PictureBox
            With NewPicBox
                .Image = CatalogueItem.Picture
                .Location = New System.Drawing.Point(17, 29)
                .Name = "PictureBox" & CatalogueIndex
                .Size = New System.Drawing.Size(140, 140)
                .SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
                .TabIndex = 0
                .TabStop = False
            End With

            Dim NewCatIndex As New Label
            With NewCatIndex
                .Text = CatalogueIndex - 1
                .Visible = False
            End With

            Dim NewGrpBox As New GroupBox
            With NewGrpBox
                .BackColor = System.Drawing.SystemColors.Window
                .Size = New System.Drawing.Size(435, 306)
                .Location = New System.Drawing.Point(58, 56)
                .Name = "GrpBoxCatalogue" & CatalogueIndex
                .Controls.Add(NewLblDesc)
                .Controls.Add(NewLblDuration)
                .Controls.Add(NewLblPax)
                .Controls.Add(NewLblPrice)
                .Controls.Add(NewLblSeller)
                .Controls.Add(NewLblTitle)
                .Controls.Add(NewPicBox)
                .Controls.Add(NewCatIndex)
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

            CatalogueIndex += 1

        Next
    End Sub

    Overrides Sub AddFormLoad()
        'TODO: This line of code loads data into the 'OtralaDBDataSet.Package' table. You can move, or remove it, as needed.
        Me.PackageTableAdapter.Fill(Me.OtralaDBDataSet.Package)
        OpenRecommendations()
    End Sub

    Private Sub OpenRecommendations() Handles BtnRecommendation.Click
        PnlCatalogue.Controls.Clear()

        Dim CatalogueData As DataTable = OtralaDBDataSet.Package.Copy()

        CatalogueList.Clear()

        For Each Row In CatalogueData.Rows
            Dim NewPackage As New Package
            With NewPackage
                .SellerID = Row("UserID")
                .PackageID = Row("PackageID")
                .PackageName = Row("PackageName")
                .Price = Row("Price")
                .Description = Row("Description")
                .State = Row("State")
                .Location = Row("Destination")
                .Pax = Row("Pax")
                .Duration = Row("Duration")
                .SellerName = Row("SellerName")
                .Picture = ImageFromData(Row("Picture"))
            End With

            CatalogueList.Add(NewPackage)
        Next

        Dim ShuffledCatalogue As List(Of Package) = Shuffle(CatalogueList)
        CatalogueList.Clear()
        For Each Package In ShuffledCatalogue
            CatalogueList.Add(Package)
        Next

        GenerateCatalogue(ShuffledCatalogue)
    End Sub

    Private Sub OpenWishlist() Handles BtnWishlist.Click

        If Not User.LoggedIn Then
            MsgBox("You need to be signed in to have a wishlist")
            Exit Sub
        End If

        PnlCatalogue.Controls.Clear()
        CatalogueList.Clear()

        Dim StrMyWishlist As String = LstIntToStr(User.Wishlist)

        If User.Wishlist.Count = 0 Then
            Dim no_result As New Label
            With no_result
                .Name = "lblNoResult"
                .Location = New System.Drawing.Point(PnlCatalogue.Width / 2 - 400, PnlCatalogue.Height / 2 - 100)
                .Text = "Oops, it looks like you don't have any items in your wishlist yet."
                .Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
                .Size = New System.Drawing.Size(800, 300)
                .TextAlign = ContentAlignment.TopLeft
            End With

            PnlCatalogue.Controls.Add(no_result)

            Exit Sub
        End If

        Dim CatalogueData As DataRow() = OtralaDBDataSet.Package.Select("PackageID IN (" & StrMyWishlist.Replace(",", ", ") & ")")

        For Each Row In CatalogueData
            Dim NewPackage As New Package
            With NewPackage
                .SellerID = Row("UserID")
                .PackageID = Row("PackageID")
                .PackageName = Row("PackageName")
                .Price = Row("Price")
                .Description = Row("Description")
                .State = Row("State")
                .Location = Row("Destination")
                .Pax = Row("Pax")
                .Duration = Row("Duration")
                .SellerName = Row("SellerName")
                .Picture = ImageFromData(Row("Picture"))
            End With

            CatalogueList.Add(NewPackage)
        Next

        GenerateCatalogue(CatalogueList)

    End Sub
    Private Function GetIndex(Name As String)
        Dim House As Short = 0
        Dim Index As Short = 0
        For Each Letter In Name.Reverse
            If IsNumeric(Letter) Then
                Index += Val(Letter) * (10 ^ House)
            End If
        Next
        Return Index
    End Function

    Private Sub Catalogue_Click(sender As Object, e As EventArgs)

        Dim SenderIndex As Short = GetIndex(sender.Name)
        Dim PackageViewForm As New Package_Viewer With {
            .Package = CatalogueList(SenderIndex - 1)
        }
        PackageViewForm.Owner = "Catalogue"
        PackageViewForm.ShowDialog()
    End Sub

    Private Sub OpenRequest() Handles BtnRequest.Click
        If Not User.LoggedIn Then
            MsgBox("You need to be signed in to submit a request")
            Exit Sub
        End If

        Request.Show()
        Request.FormLoad()
        Me.Hide()

    End Sub

    Private Sub CloseAll(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

End Class
