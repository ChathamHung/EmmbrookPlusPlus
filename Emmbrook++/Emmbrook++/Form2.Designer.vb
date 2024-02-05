<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        TextBox1 = New TextBox()
        GroupBox4 = New GroupBox()
        TextBox2 = New TextBox()
        GroupBox3 = New GroupBox()
        Button1 = New Button()
        LinkLabel1 = New LinkLabel()
        PictureBox1 = New PictureBox()
        GroupBox4.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.AccessibleDescription = ""
        TextBox1.AccessibleName = ""
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox1.Location = New Point(6, 22)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(363, 144)
        TextBox1.TabIndex = 0
        TextBox1.Text = "1. Change Logo" & vbCrLf & "2. Add shortcut keys" & vbCrLf & "3. Fixed some known bugs" & vbCrLf & "4. Add ""Run"" Button at Emmbrook++ Menu" & vbCrLf & "5. Add ""Explorer"" option" & vbCrLf & "6. Delete ""Open System About"" Button" & vbCrLf & "7. Set new URL" & vbCrLf & "8. Add more ICO"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox4.Controls.Add(TextBox1)
        GroupBox4.Location = New Point(12, 78)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(375, 172)
        GroupBox4.TabIndex = 6
        GroupBox4.TabStop = False
        GroupBox4.Text = "What's New?"
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox2.Location = New Point(6, 22)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(363, 91)
        TextBox2.TabIndex = 1
        TextBox2.Text = "Emmbrook++ is a software that can be used in schools computers, Because of the limitations of school computers, I developed this software to quickly set the task list! Wish you happy using it!"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox3.AutoSizeMode = AutoSizeMode.GrowAndShrink
        GroupBox3.Controls.Add(TextBox2)
        GroupBox3.Location = New Point(12, 256)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(375, 119)
        GroupBox3.TabIndex = 5
        GroupBox3.TabStop = False
        GroupBox3.Text = "What is Emmbrook++?"
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button1.Location = New Point(312, 381)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 7
        Button1.Text = "OK"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(12, 385)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(125, 15)
        LinkLabel1.TabIndex = 9
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Open Official Website"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.LOGO
        PictureBox1.Location = New Point(12, 9)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(375, 63)
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(399, 416)
        Controls.Add(PictureBox1)
        Controls.Add(LinkLabel1)
        Controls.Add(Button1)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        MinimumSize = New Size(415, 455)
        Name = "Form2"
        ShowInTaskbar = False
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "About"
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
End Class
