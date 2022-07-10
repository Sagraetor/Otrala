Public Class Seller_Approval
    Private Sub SellerApplicationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SellerApplicationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OtralaDBDataSet)

    End Sub

    Private Sub Seller_Approval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OtralaDBDataSet.SellerApplication' table. You can move, or remove it, as needed.
        Me.SellerApplicationTableAdapter.Fill(Me.OtralaDBDataSet.SellerApplication)
        Me.UserInfoTableAdapter.Fill(Me.OtralaDBDataSet.UserInfo)
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        Dim found As Boolean = False
        Dim SellerApplication As DataTable = OtralaDBDataSet.SellerApplication.Copy()
        Dim UserInfo As DataTable = OtralaDBDataSet.UserInfo.Copy()
        Dim info_user_id() As String = {}

        For Each Row In UserInfo.Rows
            ReDim Preserve info_user_id(info_user_id.Length)
            info_user_id(info_user_id.Length - 1) = Row("UserID")
        Next

        For i = 0 To info_user_id.Length - 1
            If found Then
                Exit For
            End If
            For Each row In SellerApplication.Rows
                If found Then
                    Exit For
                End If
                If CType(SellerApplicationBindingSource.Current("UserID"), String) = info_user_id(i) Then

                    Dim find_record As EnumerableRowCollection(Of OtralaDBDataSet.UserInfoRow)
                    find_record = From g In OtralaDBDataSet.UserInfo
                                  Where g.UserID = info_user_id(i)
                                  Select g

                    UserInfoBindingSource.DataSource = find_record.AsDataView
                    UserInfoBindingSource.Current("Seller") = True
                    SellerApplicationBindingSource.Remove(SellerApplicationBindingSource.Current)

                    Me.Validate()
                    Me.UserInfoBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.OtralaDBDataSet)
                    Me.UserInfoTableAdapter.Update(Me.OtralaDBDataSet)
                    Me.UserInfoTableAdapter.Fill(Me.OtralaDBDataSet.UserInfo)

                    MsgBox("Approved " & UserInfoBindingSource.Current("RealName") & " as a Seller")

                    found = True
                End If
            Next
        Next


    End Sub

    Private Sub changing_position(sender As Object, e As EventArgs) Handles SellerApplicationBindingSource.CurrentChanged, lblApplicationID.TextChanged, Me.Load

        If lblUserID.Text = "" Then
            lblUserName.Text = ""
            Exit Sub
        End If

        Dim found As Boolean = False
        Dim SellerApplication As DataTable = OtralaDBDataSet.SellerApplication.Copy()
        Dim UserInfo As DataTable = OtralaDBDataSet.UserInfo.Copy()
        Dim info_user_id() As String = {}
        Dim info_user_name() As String = {}
        Dim username_found As String = Nothing

        For Each Row In UserInfo.Rows
            ReDim Preserve info_user_id(info_user_id.Length)
            ReDim Preserve info_user_name(info_user_name.Length)
            info_user_id(info_user_id.Length - 1) = Row("UserID")
            info_user_name(info_user_name.Length - 1) = Row("RealName")
        Next

        For i = 0 To info_user_id.Length - 1
            If found Then
                Exit For
            End If
            For Each row In SellerApplication.Rows
                If found Then
                    Exit For
                End If
                If CType(SellerApplicationBindingSource.Current("UserID"), String) = info_user_id(i) Then
                    username_found = info_user_name(i)
                    found = True
                End If
            Next
        Next

        lblUserName.Text = username_found

    End Sub

End Class