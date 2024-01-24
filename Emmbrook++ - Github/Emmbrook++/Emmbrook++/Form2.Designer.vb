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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        Label1 = New Label()
        TextBox1 = New TextBox()
        GroupBox4 = New GroupBox()
        TextBox2 = New TextBox()
        GroupBox3 = New GroupBox()
        Button2 = New Button()
        Button1 = New Button()
        LinkLabel1 = New LinkLabel()
        GroupBox4.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(7, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(228, 37)
        Label1.TabIndex = 1
        Label1.Text = "Emmbrook++ 3.0"
        ' 
        ' TextBox1
        ' 
        TextBox1.AccessibleDescription = ""
        TextBox1.AccessibleName = ""
        TextBox1.Location = New Point(6, 22)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(363, 173)
        TextBox1.TabIndex = 0
        TextBox1.Text = "1. Update About Window." & vbCrLf & "2. Added Show Task View Button." & vbCrLf & "3. Added How to Use." & vbCrLf & "4. Added Exit."
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(TextBox1)
        GroupBox4.Location = New Point(12, 49)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(375, 201)
        GroupBox4.TabIndex = 6
        GroupBox4.TabStop = False
        GroupBox4.Text = "What's New?"
        ' 
        ' TextBox2
        ' 
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
        GroupBox3.Controls.Add(TextBox2)
        GroupBox3.Location = New Point(12, 256)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(375, 119)
        GroupBox3.TabIndex = 5
        GroupBox3.TabStop = False
        GroupBox3.Text = "What is Emmbrook++?"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(12, 381)
        Button2.Name = "Button2"
        Button2.Size = New Size(129, 23)
        Button2.TabIndex = 4
        Button2.Text = "Open System About"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(312, 381)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 7
        Button1.Text = "OK"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(147, 385)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(131, 15)
        LinkLabel1.TabIndex = 9
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Open Official Website"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(399, 416)
        Controls.Add(Label1)
        Controls.Add(LinkLabel1)
        Controls.Add(Button1)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(Button2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form2"
        ShowIcon = False
        ShowInTaskbar = False
        SizeGripStyle = SizeGripStyle.Hide
        Text = "About"
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
