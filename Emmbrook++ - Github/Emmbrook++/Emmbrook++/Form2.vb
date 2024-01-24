Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form2 As Form = Application.OpenForms("Form2")
        If form2 IsNot Nothing Then
            Form1.Enabled = True
            form2.Close()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("winver")
    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Enabled = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim url As String = "https://sites.google.com/view/alltool/"

        ' 使用 Process.Start 启动默认的 Web 浏览器并访问指定的 URL
        Try
            Process.Start(New ProcessStartInfo With {
        .FileName = url,
        .UseShellExecute = True
    })
        Catch ex As Exception
            ' 处理异常（如果有的话）
            MessageBox.Show("Unable to open webpage: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class