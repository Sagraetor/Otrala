Public Class Package
    Private seller_id As String
    Private package_id As String
    Private str_seller_name As String
    Private str_name As String
    Private str_price As String
    Private str_description As String
    Private str_state As String
    Private str_location As String
    Private str_pax As String
    Private str_duration As String
    Private img_picture As Image
    Private int_index As Integer

    Public Sub Empty()
        seller_id = Nothing
        package_id = Nothing
        str_seller_name = Nothing
        str_name = Nothing
        str_price = Nothing
        str_description = Nothing
        str_state = Nothing
        str_location = Nothing
        str_pax = Nothing
        str_duration = Nothing
        img_picture = Nothing
        int_index = Nothing
    End Sub

    Public Property SellerID() As String
        Get
            Return seller_id
        End Get
        Set(ByVal value As String)
            seller_id = value
        End Set
    End Property
    Public Property PackageID() As String
        Get
            Return package_id
        End Get
        Set(ByVal value As String)
            package_id = value
        End Set
    End Property
    Public Property SellerName() As String
        Get
            Return str_seller_name
        End Get
        Set(ByVal value As String)
            str_seller_name = value
        End Set
    End Property
    Public Property Name() As String
        Get
            Return str_name
        End Get
        Set(ByVal value As String)
            str_name = value
        End Set
    End Property
    Public Property Price() As String
        Get
            Return str_price
        End Get
        Set(ByVal value As String)
            str_price = value
        End Set
    End Property
    Public Property Description() As String
        Get
            Return str_description
        End Get
        Set(ByVal value As String)
            str_description = value
        End Set
    End Property
    Public Property State() As String
        Get
            Return str_state
        End Get
        Set(ByVal value As String)
            str_state = value
        End Set
    End Property
    Public Property Location() As String
        Get
            Return str_location
        End Get
        Set(ByVal value As String)
            str_location = value
        End Set
    End Property
    Public Property Pax() As String
        Get
            Return str_pax
        End Get
        Set(ByVal value As String)
            str_pax = value
        End Set
    End Property
    Public Property Duration() As String
        Get
            Return str_duration
        End Get
        Set(ByVal value As String)
            str_duration = value
        End Set
    End Property
    Public Property Image() As Image
        Get
            Return img_picture
        End Get
        Set(ByVal value As Image)
            img_picture = value
        End Set
    End Property
    Public Property Index() As String
        Get
            Return int_index
        End Get
        Set(ByVal value As String)
            int_index = value
        End Set
    End Property
End Class

