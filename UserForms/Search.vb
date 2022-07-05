Public Class Search

    Dim CatalogueIndex As Long = 1 ' Index of catalogue items.
    Dim CatalogueYIndex As Integer = 0 ' Start displaying catalogues from which row.
    Dim CatalogueList As New List(Of Package)
    Dim DisplayList As New List(Of Package)

    Private Sub SearchBox_Search(sender As Object, e As KeyPressEventArgs) Handles SearchBox.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            SearchButton.PerformClick()
        End If
    End Sub

    Private Sub Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboState.SelectedIndex = 0
        cboPrice.SelectedIndex = 0
        cboPax.SelectedIndex = 0
        cboDuration.SelectedIndex = 0
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim bool_SearchUsingState As Boolean
        Dim bool_SearchUsingPrice As Boolean
        Dim bool_SearchUsingPax As Boolean
        Dim bool_SearchUsingDuration As Boolean
        Dim bool_SearchUsingText As Boolean
        Dim con_state As String = ""
        Dim con_price_lower As Integer
        Dim con_price_higher As Integer
        Dim con_pax As Integer
        Dim bool_pax_more_than_10 As Boolean
        Dim con_duration As Integer
        Dim bool_duration_more_than_10 As Boolean
        Dim con_text() As String = SearchBox.Text.Split()
        CatalogueList.Clear()
        DisplayList.Clear()
        PnlCatalogue.Controls.Clear()

        ' Get items if user is searching using those items (state, price, pax, duration)
        If cboState.SelectedIndex <> 0 Then
            con_state = cboState.SelectedItem
            bool_SearchUsingState = True
        End If

        If cboPrice.SelectedIndex <> 0 Then
            con_price_lower = determine_price(cboPrice.SelectedIndex)(0)
            con_price_higher = determine_price(cboPrice.SelectedIndex)(1)
            bool_SearchUsingPrice = True
        End If

        If cboPax.SelectedIndex <> 0 Then
            If cboPax.SelectedIndex <> 10 Then
                con_pax = cboPax.SelectedItem
                bool_pax_more_than_10 = False
            Else
                bool_pax_more_than_10 = True
            End If
            bool_SearchUsingPax = True
        End If

        If cboDuration.SelectedIndex <> 0 Then
            If cboDuration.SelectedIndex <> 10 Then
                con_duration = cboDuration.SelectedItem
                bool_duration_more_than_10 = False
            Else
                bool_duration_more_than_10 = True
            End If
            bool_SearchUsingDuration = True
        End If

        If con_text.Length > 0 Then
            bool_SearchUsingText = True
        End If

        ' Get the collection of packages from database
        get_all_package_records()

        ' Determine the packages that is correct and add them to another list of package that will be displayed
        For Each package In CatalogueList
            Dim bool_correct_state As Boolean = False
            Dim bool_correct_price As Boolean = False
            Dim bool_correct_pax As Boolean = False
            Dim bool_correct_duration As Boolean = False
            Dim bool_correct_text As Boolean = False

            If bool_SearchUsingState And package.State = con_state Then
                bool_correct_state = True
            ElseIf Not bool_SearchUsingState Then
                bool_correct_state = True
            End If

            If bool_SearchUsingPrice And package.Price >= con_price_lower And package.Price <= con_price_higher Then
                bool_correct_price = True
            ElseIf Not bool_SearchUsingPrice Then
                bool_correct_price = True
            End If

            If bool_SearchUsingPax And package.Pax = con_pax Then
                bool_correct_pax = True
            ElseIf bool_SearchUsingPax And bool_pax_more_than_10 And package.Pax >= 10 Then
                bool_correct_pax = True
            ElseIf Not bool_SearchUsingPax Then
                bool_correct_pax = True
            End If

            If bool_SearchUsingDuration And package.Duration = con_duration Then
                bool_correct_duration = True
            ElseIf bool_SearchUsingDuration And bool_duration_more_than_10 And package.Duration >= 10 Then
                bool_correct_duration = True
            ElseIf Not bool_SearchUsingDuration Then
                bool_correct_duration = True
            End If

            For Each search_term In con_text
                For Each package_name In package.PackageName.Split()
                    If UCase(package_name) Like "*" & UCase(search_term) & "*" Then
                        bool_correct_text = True
                    End If
                Next
                For Each description_content In package.Description.Split
                    If UCase(description_content) Like "*" & UCase(search_term) & "*" Then
                        bool_correct_text = True
                    End If
                Next
            Next

            If bool_correct_state And bool_correct_price And bool_correct_pax And bool_correct_duration And bool_correct_text Then
                DisplayList.Add(package)
            End If

        Next

        If DisplayList.Count <> 0 Then
            GenerateCatalogue(DisplayList)
        Else
            Dim no_result As New Label
            With no_result
                .Name = "lblNoResult"
                .Location = New System.Drawing.Point(PnlCatalogue.Width / 2 - 400, PnlCatalogue.Height / 2 - 100)
                .Text = "Oops, it looks like we don't have that sort of package currently."
                .Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
                .Size = New System.Drawing.Size(800, 300)
                .TextAlign = ContentAlignment.TopLeft
            End With

            PnlCatalogue.Controls.Add(no_result)
        End If

    End Sub

    ' Determine the price range based on selectedindex of combobox
    Private Function determine_price(i As Integer)
        Select Case i
            Case 1
                Return {0, 500}
            Case 2
                Return {500, 1000}
            Case 3
                Return {1000, 1500}
            Case 4
                Return {1500, 2000}
            Case 5
                Return {2000, 2500}
            Case 6
                Return {2500, 9999999}
        End Select
    End Function

    ' Get a copy of the database package record
    Sub get_all_package_records()
        Me.PackageTableAdapter.Fill(Me.OtralaDBDataSet.Package)

        Dim CatalogueData As DataTable = OtralaDBDataSet.Package.Copy()

        For Each Row In CatalogueData.Rows
            Dim NewPackage As New Package
            With NewPackage
                .SellerID = Row("UserID")
                .PackageID = Row("PackageID")
                .SellerName = "Temp"
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
    End Sub

    ' Same code as Catalogue.vb here
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
                ' DO NOT CHANGE THE ORDER OF THE CONTROLS BELOW (code will 100% break)
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

    ' Clicking on a catalogue (this part is different because using index doesnt work)
    Private Sub Catalogue_Click(sender As Object, e As EventArgs)
        Dim selected_package As Package = Nothing

        ' Get the groupbox
        If TypeOf sender IsNot GroupBox Then
            sender = sender.Parent
        End If

        ' Find the package with the same name as groupbox
        For Each package In CatalogueList
            If package.PackageName = sender.Controls.Item(5).Text Then
                selected_package = package
            End If
        Next

        ' Display the package using package viewer
        Dim PackageViewForm As New Package_Viewer With {
            .Package = selected_package
        }

        PackageViewForm.ShowDialog()
    End Sub

End Class
