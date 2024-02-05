Imports System.Reflection
Imports Microsoft.Win32
Imports System.Diagnostics
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Run()
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

    Private Sub Run()
        ' If User click "Run" Button, Set the taskbar.

        ProgressBar1.Value += "10"
        If CheckBox1.Checked Then
            Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "TaskbarSmallIcons", 1, RegistryValueKind.DWord)
        Else
            Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "TaskbarSmallIcons", 0, RegistryValueKind.DWord)
        End If

        ProgressBar1.Value += "10"
        If CheckBox2.Checked Then
            Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Search", "SearchboxTaskbarMode", 1, RegistryValueKind.DWord)
        Else
            Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Search", "SearchboxTaskbarMode", 0, RegistryValueKind.DWord)
        End If

        ProgressBar1.Value += "10"
        If CheckBox3.Checked Then
            Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "TaskbarGlomLevel", 1, RegistryValueKind.DWord)
        Else
            Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "TaskbarGlomLevel", 0, RegistryValueKind.DWord)
        End If

        ProgressBar1.Value += "10"
        If CheckBox4.Checked Then
            Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowTaskViewButton", 1, RegistryValueKind.DWord)
        Else
            Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowTaskViewButton", 0, RegistryValueKind.DWord)
        End If

        ProgressBar1.Value += "10"
        If ComboBox1.SelectedItem = "Quick access" Then
            Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "LaunchTo", 0, RegistryValueKind.DWord)
        ElseIf ComboBox1.SelectedItem = "This PC" Then
            Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "LaunchTo", 1, RegistryValueKind.DWord)
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

    Private Sub RunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunToolStripMenuItem.Click
        Run()
    End Sub
End Class
