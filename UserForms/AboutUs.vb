Public Class AboutUs

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.LblProductName.Text = My.Application.Info.ProductName
        Me.LblVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.LblCopyright.Text = My.Application.Info.Copyright
        Me.LblCompanyName.Text = My.Application.Info.CompanyName
        Me.TextBoxDescription.Text = My.Application.Info.Description
    End Sub
    ' log out 
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs)
        Dim reply As MsgBoxResult = MsgBox("Thank you for using Otrala" + Environment.NewLine +
                                           "See you when we 'Travel Lagi'", MsgBoxStyle.OkCancel, "Exit")
        If reply = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub

End Class