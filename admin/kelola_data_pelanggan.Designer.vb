<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kelola_data_pelanggan
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
        btnEdit = New Button()
        btnHapus = New Button()
        btnKembali = New Button()
        dgvPelanggan = New DataGridView()
        txtUsername = New TextBox()
        txtNama = New TextBox()
        txtPassword = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnCari = New Button()
        txtCari = New TextBox()
        BtnReset = New Button()
        Label4 = New Label()
        Panel1 = New Panel()
        CType(dgvPelanggan, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.SteelBlue
        btnEdit.Font = New Font("Arial", 10F)
        btnEdit.ForeColor = Color.White
        btnEdit.Location = New Point(33, 265)
        btnEdit.Margin = New Padding(4, 5, 4, 5)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(141, 38)
        btnEdit.TabIndex = 19
        btnEdit.Text = "Ubah Data"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.SteelBlue
        btnHapus.Font = New Font("Arial", 10F)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(182, 265)
        btnHapus.Margin = New Padding(4, 5, 4, 5)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(135, 38)
        btnHapus.TabIndex = 20
        btnHapus.Text = "Hapus Data"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnKembali
        ' 
        btnKembali.Font = New Font("Arial", 10F)
        btnKembali.Location = New Point(46, 508)
        btnKembali.Margin = New Padding(4, 5, 4, 5)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(107, 38)
        btnKembali.TabIndex = 21
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' dgvPelanggan
        ' 
        dgvPelanggan.BackgroundColor = Color.White
        dgvPelanggan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPelanggan.Location = New Point(456, 193)
        dgvPelanggan.Margin = New Padding(4, 5, 4, 5)
        dgvPelanggan.Name = "dgvPelanggan"
        dgvPelanggan.RowHeadersWidth = 62
        dgvPelanggan.Size = New Size(517, 292)
        dgvPelanggan.TabIndex = 22
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Location = New Point(33, 130)
        txtUsername.Margin = New Padding(4, 5, 4, 5)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(284, 31)
        txtUsername.TabIndex = 23
        ' 
        ' txtNama
        ' 
        txtNama.BorderStyle = BorderStyle.FixedSingle
        txtNama.Location = New Point(33, 55)
        txtNama.Margin = New Padding(4, 5, 4, 5)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(284, 31)
        txtNama.TabIndex = 25
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Location = New Point(33, 207)
        txtPassword.Margin = New Padding(4, 5, 4, 5)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(284, 31)
        txtPassword.TabIndex = 26
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 10F, FontStyle.Bold)
        Label1.ForeColor = Color.SteelBlue
        Label1.Location = New Point(33, 101)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 24)
        Label1.TabIndex = 27
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 10F, FontStyle.Bold)
        Label2.ForeColor = Color.SteelBlue
        Label2.Location = New Point(33, 26)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 24)
        Label2.TabIndex = 28
        Label2.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 10F, FontStyle.Bold)
        Label3.ForeColor = Color.SteelBlue
        Label3.Location = New Point(33, 178)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 24)
        Label3.TabIndex = 29
        Label3.Text = "Kata Sandi"
        ' 
        ' btnCari
        ' 
        btnCari.Font = New Font("Arial", 10F)
        btnCari.Location = New Point(745, 136)
        btnCari.Margin = New Padding(4, 5, 4, 5)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(113, 34)
        btnCari.TabIndex = 33
        btnCari.Text = "Cari"
        btnCari.UseVisualStyleBackColor = True
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(456, 138)
        txtCari.Margin = New Padding(4, 5, 4, 5)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(281, 31)
        txtCari.TabIndex = 35
        ' 
        ' BtnReset
        ' 
        BtnReset.Font = New Font("Arial", 10F)
        BtnReset.Location = New Point(866, 135)
        BtnReset.Margin = New Padding(4, 5, 4, 5)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(107, 34)
        BtnReset.TabIndex = 36
        BtnReset.Text = "Reset"
        BtnReset.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(360, 52)
        Label4.Name = "Label4"
        Label4.Size = New Size(361, 46)
        Label4.TabIndex = 37
        Label4.Text = "DATA PENGGUNA"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtPassword)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtNama)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtUsername)
        Panel1.Controls.Add(btnEdit)
        Panel1.Controls.Add(btnHapus)
        Panel1.Location = New Point(46, 138)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(360, 347)
        Panel1.TabIndex = 38
        ' 
        ' kelola_data_pelanggan
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(1051, 638)
        Controls.Add(Label4)
        Controls.Add(BtnReset)
        Controls.Add(txtCari)
        Controls.Add(btnCari)
        Controls.Add(dgvPelanggan)
        Controls.Add(btnKembali)
        Controls.Add(Panel1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "kelola_data_pelanggan"
        Text = "kelola_data_pelanggan"
        CType(dgvPelanggan, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents dgvPelanggan As DataGridView
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCari As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents BtnReset As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
End Class
