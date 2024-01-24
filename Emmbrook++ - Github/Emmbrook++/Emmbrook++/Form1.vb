Imports System.Reflection
Imports Microsoft.Win32
Imports System.Diagnostics
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' If User click "Run" Button, Set the taskbar.

        Dim regPath1 As String = "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced"
        ProgressBar1.Value += "20"
        Dim regPath2 As String = "Software\Microsoft\Windows\CurrentVersion\Search"
        ProgressBar1.Value += "20"

        If CheckBox1.Checked Then
            Registry.SetValue("HKEY_CURRENT_USER\" & regPath1, "TaskbarSmallIcons", 1, RegistryValueKind.DWord)
        Else
            Registry.SetValue("HKEY_CURRENT_USER\" & regPath1, "TaskbarSmallIcons", 0, RegistryValueKind.DWord)
        End If

        ProgressBar1.Value += "20"
        If CheckBox2.Checked Then
            Registry.SetValue("HKEY_CURRENT_USER\" & regPath2, "SearchboxTaskbarMode", 1, RegistryValueKind.DWord)
        Else
            Registry.SetValue("HKEY_CURRENT_USER\" & regPath2, "SearchboxTaskbarMode", 0, RegistryValueKind.DWord)
        End If

        ProgressBar1.Value += "10"
        If CheckBox3.Checked Then
            Registry.SetValue("HKEY_CURRENT_USER\" & regPath1, "TaskbarGlomLevel", 1, RegistryValueKind.DWord)
        Else
            Registry.SetValue("HKEY_CURRENT_USER\" & regPath1, "TaskbarGlomLevel", 0, RegistryValueKind.DWord)
        End If

        ProgressBar1.Value += "10"
        If CheckBox4.Checked Then
            Registry.SetValue("HKEY_CURRENT_USER\" & regPath1, "ShowTaskViewButton", 1, RegistryValueKind.DWord)
        Else
            Registry.SetValue("HKEY_CURRENT_USER\" & regPath1, "ShowTaskViewButton", 0, RegistryValueKind.DWord)
        End If

        ProgressBar1.Value += "10"
        Dim explorerProcesses() As Process = Process.GetProcessesByName("explorer")
        ProgressBar1.Value += "5"
        For Each explorerProcess As Process In explorerProcesses
            explorerProcess.Kill()
        Next
        ProgressBar1.Value += "5"
        ProgressBar1.Value = "100"
        MessageBox.Show("Operation Completed!", "Emmbrook++", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ProgressBar1.Value = "0"
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' Open About Windows
        Dim Form2 As New Form2()
        Form2.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Exit Emmbrook++
        Application.Exit()
    End Sub

    Private Sub HowToUseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToUseToolStripMenuItem.Click
        ' This is open old web
        Dim url As String = "https://sites.google.com/view/alltool/#h.dkrfsq1eypqe"

        ' Use Process.Start to launch the default web browser and access the specified URL
        Try
            Process.Start(New ProcessStartInfo With {
        .FileName = url,
        .UseShellExecute = True
    })
        Catch ex As Exception
            ' Handle exceptions
            MessageBox.Show("Unable to open webpage: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
