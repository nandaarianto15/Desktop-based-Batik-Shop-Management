<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Label2 = New Label()
        Label1 = New Label()
        LinkLabel1 = New LinkLabel()
        Label3 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Button2 = New Button()
        checkPassword = New CheckBox()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(33, 154)
        TextBox2.Margin = New Padding(4, 5, 4, 5)
        TextBox2.MaxLength = 8
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(319, 31)
        TextBox2.TabIndex = 20
        TextBox2.UseSystemPasswordChar = True
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(33, 72)
        TextBox1.Margin = New Padding(4, 5, 4, 5)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(348, 31)
        TextBox1.TabIndex = 19
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.SteelBlue
        Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Button1.FlatAppearance.BorderSize = 0
        Button1.Font = New Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(33, 234)
        Button1.Margin = New Padding(4, 5, 4, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(156, 48)
        Button1.TabIndex = 16
        Button1.Text = "Masuk"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.SteelBlue
        Label2.Location = New Point(33, 121)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 24)
        Label2.TabIndex = 15
        Label2.Text = "Kata Sandi"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SteelBlue
        Label1.Location = New Point(33, 39)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 24)
        Label1.TabIndex = 14
        Label1.Text = "Username"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(33, 193)
        LinkLabel1.Margin = New Padding(4, 0, 4, 0)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(173, 25)
        LinkLabel1.TabIndex = 21
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Belum Punya Akun ?"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 26F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(314, 48)
        Label3.Name = "Label3"
        Label3.Size = New Size(190, 61)
        Label3.TabIndex = 22
        Label3.Text = "LOGIN"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Location = New Point(-8, 292)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(848, 323)
        Panel1.TabIndex = 23
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(checkPassword)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(LinkLabel1)
        Panel2.Controls.Add(Button1)
        Panel2.Location = New Point(201, 151)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(420, 327)
        Panel2.TabIndex = 24
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SteelBlue
        Button2.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Button2.FlatAppearance.BorderSize = 0
        Button2.Font = New Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(225, 234)
        Button2.Margin = New Padding(4, 5, 4, 5)
        Button2.Name = "Button2"
        Button2.Size = New Size(156, 48)
        Button2.TabIndex = 23
        Button2.Text = "Keluar"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' checkPassword
        ' 
        checkPassword.AutoSize = True
        checkPassword.Location = New Point(359, 159)
        checkPassword.Name = "checkPassword"
        checkPassword.Size = New Size(22, 21)
        checkPassword.TabIndex = 22
        checkPassword.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(839, 609)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form1"
        Text = "Form1"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents checkPassword As CheckBox
    Friend WithEvents Button2 As Button

End Class
