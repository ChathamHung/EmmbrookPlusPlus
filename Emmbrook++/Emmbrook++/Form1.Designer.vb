<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        ProgressBar1 = New ProgressBar()
        Button1 = New Button()
        TabPage1 = New TabPage()
        GroupBox5 = New GroupBox()
        CheckBox4 = New CheckBox()
        GroupBox2 = New GroupBox()
        CheckBox2 = New CheckBox()
        GroupBox1 = New GroupBox()
        CheckBox3 = New CheckBox()
        CheckBox1 = New CheckBox()
        TabControl1 = New TabControl()
        TabPage2 = New TabPage()
        GroupBox3 = New GroupBox()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        MenuStrip1 = New MenuStrip()
        EmmbrookToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        RunToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        TabPage1.SuspendLayout()
        GroupBox5.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage2.SuspendLayout()
        GroupBox3.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ProgressBar1.Location = New Point(11, 366)
        ProgressBar1.Margin = New Padding(2)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(256, 26)
        ProgressBar1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(271, 366)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 26)
        Button1.TabIndex = 1
        Button1.Text = "Run (Ctrl+R)"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(GroupBox5)
        TabPage1.Controls.Add(GroupBox2)
        TabPage1.Controls.Add(GroupBox1)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(344, 306)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Taskbar"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        GroupBox5.Controls.Add(CheckBox4)
        GroupBox5.Location = New Point(166, 167)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(172, 133)
        GroupBox5.TabIndex = 5
        GroupBox5.TabStop = False
        GroupBox5.Text = "Other"
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(6, 21)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(153, 19)
        CheckBox4.TabIndex = 0
        CheckBox4.Text = "Show Task View Button"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox2.Controls.Add(CheckBox2)
        GroupBox2.Location = New Point(166, 6)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(172, 155)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "Search"
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(6, 21)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(88, 19)
        CheckBox2.TabIndex = 0
        CheckBox2.Text = "Search Box"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(CheckBox3)
        GroupBox1.Controls.Add(CheckBox1)
        GroupBox1.Location = New Point(6, 6)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(154, 294)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Taskbar"
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(5, 45)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(135, 19)
        CheckBox3.TabIndex = 3
        CheckBox3.Text = "Taskbar Glom Level"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(5, 21)
        CheckBox1.Margin = New Padding(2)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(105, 19)
        CheckBox1.TabIndex = 2
        CheckBox1.Text = "Small Taskbar"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' TabControl1
        ' 
        TabControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(12, 27)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(352, 334)
        TabControl1.TabIndex = 3
        TabControl1.Tag = ""
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(GroupBox3)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(344, 306)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Explorer"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox3.Controls.Add(ComboBox1)
        GroupBox3.Controls.Add(Label1)
        GroupBox3.Location = New Point(6, 6)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(332, 294)
        GroupBox3.TabIndex = 4
        GroupBox3.TabStop = False
        GroupBox3.Text = "Explorer"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Quick access", "This PC"})
        ComboBox1.Location = New Point(139, 16)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(106, 23)
        ComboBox1.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 15)
        Label1.TabIndex = 0
        Label1.Text = "Open File Explorer to: "
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {EmmbrookToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(376, 24)
        MenuStrip1.TabIndex = 4
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' EmmbrookToolStripMenuItem
        ' 
        EmmbrookToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExitToolStripMenuItem, RunToolStripMenuItem})
        EmmbrookToolStripMenuItem.Name = "EmmbrookToolStripMenuItem"
        EmmbrookToolStripMenuItem.ShortcutKeys = Keys.Alt Or Keys.E
        EmmbrookToolStripMenuItem.Size = New Size(118, 20)
        EmmbrookToolStripMenuItem.Text = "Emmbrook++ (E)"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Image = My.Resources.Resources._Exit
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.ShortcutKeys = Keys.Alt Or Keys.F4
        ExitToolStripMenuItem.Size = New Size(139, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' RunToolStripMenuItem
        ' 
        RunToolStripMenuItem.Image = My.Resources.Resources.Run
        RunToolStripMenuItem.Name = "RunToolStripMenuItem"
        RunToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.R
        RunToolStripMenuItem.Size = New Size(139, 22)
        RunToolStripMenuItem.Text = "Run"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.ShortcutKeys = Keys.Alt Or Keys.H
        HelpToolStripMenuItem.Size = New Size(66, 20)
        HelpToolStripMenuItem.Text = "Help (H)"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Image = My.Resources.Resources.Adout
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(109, 22)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(376, 403)
        Controls.Add(TabControl1)
        Controls.Add(Button1)
        Controls.Add(ProgressBar1)
        Controls.Add(MenuStrip1)
        Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(2)
        MinimumSize = New Size(392, 442)
        Name = "Form1"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Emmbrook++"
        TabPage1.ResumeLayout(False)
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button1 As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmmbrookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RunToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
End Class
