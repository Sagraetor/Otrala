Public Class ApplySeller
    Public ImgIC As Image
    Public ImgDocument As Image

    Private Sub UploadPic() Handles BtnUpload.Click
        Dim OpenPhoto As New OpenFileDialog

        OpenPhoto.Filter = ("Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png")

        OpenPhoto.ShowDialog()

        If OpenPhoto.FileNames.Count = 1 Then
            PicBoxSubmission.Image = Image.FromFile(OpenPhoto.FileName)
        Else
            MsgBox("Please choose only 1 picture")
        End If
    End Sub

    Private Sub Submit() Handles BtnSubmit.Click
        If PicBoxSubmission.Image Is Nothing Then
            MsgBox("Please enter a valid image")
            Exit Sub
        End If

        If ImgIC Is Nothing Then
            LblCommand.Text = "Next, please upload your proof of business"

            BtnUpload.Text = "Upload Proof of Business"

            ImgIC = PicBoxSubmission.Image

            PicBoxSubmission.Image = Nothing
        Else
            ImgDocument = PicBoxSubmission.Image

            MsgBox("Please wait for our admin to approve your application.", MsgBoxStyle.OkOnly, "Application Submitted Succesfully")

            Me.Close()
        End If
    End Sub

    Private Sub Cancel() Handles BtnCancel.Click
        ImgDocument = Nothing
        ImgIC = Nothing

        Me.Close()
    End Sub
End Class