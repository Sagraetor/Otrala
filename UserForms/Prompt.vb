Public Class Prompt
    Public Result As String

    Public Sub CheckPass(Prompt)
        LblNew.Text = Prompt
        Dim NewValueReceiver As New TextBox With {
            .Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)),
            .Location = New System.Drawing.Point(15, 46),
            .Size = New System.Drawing.Size(450, 30),
            .PasswordChar = "*"
            }
        If LblNew.Height > 33 Then
            NewValueReceiver.Top += ((Math.Ceiling((LblNew.Height / 33)) - 1) * 20)
        End If

        Panel1.Controls.Add(NewValueReceiver)
        AddHandler NewValueReceiver.KeyPress, AddressOf EnterInfo
    End Sub

    Public Sub Initialize(sender)
        'Changes sender.name into a suitable title
        Dim SenderName As String = sender.Name
        SenderName = SenderName.Replace("LblProfile", "")

        For Each Letter In SenderName
            If Letter = UCase(Letter) Then
                Dim temp As Short = SenderName.IndexOf(Letter)
                SenderName = SenderName.Insert(temp, " ")
            End If
        Next

        If SenderName.Contains("Ic") Then
            SenderName = SenderName.Replace("Ic", "IC")
        End If

        SenderName = SenderName.TrimStart(" ")

        LblNew.Text = SenderName & " :"

        'Display a field based on the field clicked
        If sender.Name = "LblProfileCountry" Then
            Dim NewValueReceiver As New ComboBox With {
            .Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)),
            .Location = New System.Drawing.Point(15, 35),
            .Size = sender.Size,
            .AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append,
            .AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource,
            .BackColor = System.Drawing.Color.White,
            .DropDownStyle = ComboBoxStyle.DropDownList
                }
            NewValueReceiver.Items.AddRange(New Object() {"Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua & Deps", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Central African Rep", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo", "Congo {Democratic Rep}", "Costa Rica", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland {Republic}", "Israel", "Italy", "Ivory Coast", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea North", "Korea South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar, {Burma}", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russian Federation", "Rwanda", "St Kitts & Nevis", "St Lucia", "Saint Vincent & the Grenadines", "Samoa", "San Marino", "Sao Tome & Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Swaziland", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad & Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe"})
            Panel1.Controls.Add(NewValueReceiver)
            AddHandler NewValueReceiver.DropDownClosed, AddressOf EnterInfo

        ElseIf sender.Name = "LblProfileAddress" Then
            Dim NewValueReceiver As New TextBox With {
            .Location = New System.Drawing.Point(15, 35),
            .Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)),
            .Multiline = True,
            .Size = New System.Drawing.Size(398, 123),
            .Text = sender.Text
            }

            Panel1.Controls.Add(NewValueReceiver)
            AddHandler NewValueReceiver.KeyDown, AddressOf EnterInfo

        ElseIf sender.Name = "LblProfileBirthday" Then
            Dim NewValueReceiver As New DateTimePicker With {
            .Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)),
            .Location = New System.Drawing.Point(15, 35),
            .Size = sender.Size,
            .CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(2, Byte), Integer)),
            .Value = DateAndTime.Now 'Convert.ToDateTime(sender.Text)
            }
            Panel1.Controls.Add(NewValueReceiver)
            AddHandler NewValueReceiver.CloseUp, AddressOf EnterInfo

        ElseIf sender.Name = "LblProfileGender" Then
            Dim NewValueReceiver As New ComboBox With {
                .Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)),
                .Location = New System.Drawing.Point(15, 46),
                .Size = sender.Size,
                .AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append,
                .AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource,
                .BackColor = System.Drawing.Color.White,
                .DropDownStyle = ComboBoxStyle.DropDownList
                    }
            NewValueReceiver.Items.AddRange(New Object() {"Male", "Female"})
            Panel1.Controls.Add(NewValueReceiver)
            AddHandler NewValueReceiver.DropDownClosed, AddressOf EnterInfo

        Else
            Dim NewValueReceiver As New TextBox With {
            .Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)),
            .Location = New System.Drawing.Point(15, 35),
            .Size = sender.Size
            }
            Panel1.Controls.Add(NewValueReceiver)
            AddHandler NewValueReceiver.KeyPress, AddressOf EnterInfo
        End If
    End Sub

    Public Sub EnterInfo(Sender As Object, e As EventArgs) Handles Me.LostFocus
        If TypeOf Sender Is TextBox AndAlso Sender.Multiline Then
            Dim KeyDownE As KeyEventArgs = CType(e, KeyEventArgs)

            If KeyDownE.KeyCode = Keys.Enter AndAlso KeyDownE.Modifiers = Nothing Then
                Result = Sender.Text
                Me.Close()
            End If

        ElseIf TypeOf Sender Is TextBox Then
            Dim KeyPressE As KeyPressEventArgs = CType(e, KeyPressEventArgs)

            If AscW(KeyPressE.KeyChar) = Keys.Enter Then
                Result = Sender.Text
                Me.Close()
            End If

        Else
            Result = Sender.Text
            Me.Close()
        End If
    End Sub

End Class