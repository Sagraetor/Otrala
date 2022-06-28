Module OtralAPI
    Structure UserInfo
        Dim UserID As Integer
        Dim Name As String
        Dim Age As Short
        Dim Seller As Boolean
        Dim Address As String
        Dim Email As String
        Dim PhoneNumber As String
    End Structure

    Public User As New UserInfo
    Public Function Encrypt(Info As String)
        Dim Encrypted As New List(Of Integer)
        Dim Key As New List(Of Integer)
        Randomize()
        For Each i In Info
            Dim AscWi As Integer = AscW(i)
            Dim CurrKey As Integer = CInt(Int(50 * Rnd() + 1))
            Key.Add(CurrKey)
            Encrypted.Add(AscWi + CurrKey)
        Next

        Return (Encrypted, Key)
    End Function

    Public Function Decrypt(Info As List(Of Integer), Key As List(Of Integer))
        Dim Decrypted As String = ""

        For i = 0 To (Info.Count - 1)
            Decrypted += ChrW(Info(i) - Key(i))
        Next
        Return Decrypted
    End Function
End Module
