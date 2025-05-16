<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class regist
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Button2 = New Button()
        Button1 = New Button()
        Label2 = New Label()
        Label1 = New Label()
        TextBox7 = New TextBox()
        Label6 = New Label()
        LinkLabel1 = New LinkLabel()
        ComboBox1 = New ComboBox()
        Label3 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        checkPassword = New CheckBox()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(37, 70)
        TextBox2.Margin = New Padding(4, 5, 4, 5)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(309, 31)
        TextBox2.TabIndex = 20
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(37, 152)
        TextBox1.Margin = New Padding(4, 5, 4, 5)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(309, 31)
        TextBox1.TabIndex = 19
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SteelBlue
        Button2.Font = New Font("Arial", 8F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(37, 352)
        Button2.Margin = New Padding(4, 5, 4, 5)
        Button2.Name = "Button2"
        Button2.Size = New Size(140, 49)
        Button2.TabIndex = 17
        Button2.Text = "Kembali"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.SteelBlue
        Button1.Font = New Font("Arial", 8F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(208, 352)
        Button1.Margin = New Padding(4, 5, 4, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(138, 49)
        Button1.TabIndex = 16
        Button1.Text = "Daftar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.SteelBlue
        Label2.Location = New Point(37, 41)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 24)
        Label2.TabIndex = 15
        Label2.Text = "Nama"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SteelBlue
        Label1.Location = New Point(37, 123)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 24)
        Label1.TabIndex = 14
        Label1.Text = "Username"
        ' 
        ' TextBox7
        ' 
        TextBox7.BorderStyle = BorderStyle.FixedSingle
        TextBox7.Location = New Point(37, 239)
        TextBox7.Margin = New Padding(4, 5, 4, 5)
        TextBox7.MaxLength = 8
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(280, 31)
        TextBox7.TabIndex = 27
        TextBox7.UseSystemPasswordChar = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.SteelBlue
        Label6.Location = New Point(37, 210)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(112, 24)
        Label6.TabIndex = 26
        Label6.Text = "Kata Sandi"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(37, 417)
        LinkLabel1.Margin = New Padding(4, 0, 4, 0)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(174, 25)
        LinkLabel1.TabIndex = 28
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Sudah Punya Akun ?"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(37, 298)
        ComboBox1.Margin = New Padding(4, 5, 4, 5)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(309, 33)
        ComboBox1.TabIndex = 29
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 26F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(263, 41)
        Label3.Name = "Label3"
        Label3.Size = New Size(293, 61)
        Label3.TabIndex = 30
        Label3.Text = "REGISTER"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Location = New Point(-1, 350)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(804, 401)
        Panel1.TabIndex = 31
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(checkPassword)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(LinkLabel1)
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(TextBox7)
        Panel2.Controls.Add(Label6)
        Panel2.Location = New Point(195, 159)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(410, 485)
        Panel2.TabIndex = 32
        ' 
        ' checkPassword
        ' 
        checkPassword.AutoSize = True
        checkPassword.Location = New Point(324, 244)
        checkPassword.Name = "checkPassword"
        checkPassword.Size = New Size(22, 21)
        checkPassword.TabIndex = 30
        checkPassword.UseVisualStyleBackColor = True
        ' 
        ' regist
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(795, 750)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Margin = New Padding(4, 5, 4, 5)
        Name = "regist"
        Text = "regist"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents checkPassword As CheckBox
End Class
