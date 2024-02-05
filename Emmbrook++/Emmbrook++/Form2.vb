Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form2 As Form = Application.OpenForms("Form2")
        If form2 IsNot Nothing Then
            Form1.Enabled = True
            form2.Close()
        End If

    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Enabled = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim url As String = "https://chathamhung.github.io/download/emmbrookplusplus.html"

        ' Use Process.Start to launch the default web browser and access the specified URL
        Try
            Process.Start(New ProcessStartInfo With {
        .FileName = url,
        .UseShellExecute = True
    })
        Catch ex As Exception
            ' Handle exceptions (if any)
            MessageBox.Show("Unable to open webpage: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class