<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kelola_data_produk
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
        btnTambah = New Button()
        ofdGambar = New OpenFileDialog()
        btnReset = New Button()
        txtCari = New TextBox()
        btnCari = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtHarga = New TextBox()
        txtStok = New TextBox()
        txtUkuran = New TextBox()
        txtNama = New TextBox()
        dgvProduk = New DataGridView()
        btnKembali = New Button()
        btnHapus = New Button()
        btnEdit = New Button()
        Label6 = New Label()
        picProduk = New PictureBox()
        btnGambar = New Button()
        btnBrowse = New Button()
        Label7 = New Label()
        Panel1 = New Panel()
        Label8 = New Label()
        CType(dgvProduk, ComponentModel.ISupportInitialize).BeginInit()
        CType(picProduk, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.SteelBlue
        btnTambah.Font = New Font("Arial", 10F)
        btnTambah.ForeColor = Color.White
        btnTambah.Location = New Point(35, 645)
        btnTambah.Margin = New Padding(4, 5, 4, 5)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(147, 38)
        btnTambah.TabIndex = 0
        btnTambah.Text = "Tambah Data"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' ofdGambar
        ' 
        ofdGambar.FileName = "OpenFileDialog1"
        ' 
        ' btnReset
        ' 
        btnReset.Font = New Font("Arial", 10F)
        btnReset.Location = New Point(1157, 124)
        btnReset.Margin = New Padding(4, 5, 4, 5)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(107, 35)
        btnReset.TabIndex = 58
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(644, 126)
        txtCari.Margin = New Padding(4, 5, 4, 5)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(384, 31)
        txtCari.TabIndex = 55
        ' 
        ' btnCari
        ' 
        btnCari.Font = New Font("Arial", 10F)
        btnCari.Location = New Point(1036, 124)
        btnCari.Margin = New Padding(4, 5, 4, 5)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(113, 35)
        btnCari.TabIndex = 53
        btnCari.Text = "Cari"
        btnCari.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 10F, FontStyle.Bold)
        Label4.ForeColor = Color.SteelBlue
        Label4.Location = New Point(35, 180)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 24)
        Label4.TabIndex = 50
        Label4.Text = "Harga"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 10F, FontStyle.Bold)
        Label3.ForeColor = Color.SteelBlue
        Label3.Location = New Point(35, 101)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 24)
        Label3.TabIndex = 49
        Label3.Text = "Stok"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 10F, FontStyle.Bold)
        Label2.ForeColor = Color.SteelBlue
        Label2.Location = New Point(35, 25)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 24)
        Label2.TabIndex = 48
        Label2.Text = "Nama"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(19, 220)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 25)
        Label1.TabIndex = 47
        ' 
        ' txtHarga
        ' 
        txtHarga.BorderStyle = BorderStyle.FixedSingle
        txtHarga.Location = New Point(35, 210)
        txtHarga.Margin = New Padding(4, 5, 4, 5)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(485, 31)
        txtHarga.TabIndex = 46
        ' 
        ' txtStok
        ' 
        txtStok.BorderStyle = BorderStyle.FixedSingle
        txtStok.Location = New Point(35, 131)
        txtStok.Margin = New Padding(4, 5, 4, 5)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(485, 31)
        txtStok.TabIndex = 45
        ' 
        ' txtUkuran
        ' 
        txtUkuran.BorderStyle = BorderStyle.FixedSingle
        txtUkuran.Location = New Point(35, 293)
        txtUkuran.Margin = New Padding(4, 5, 4, 5)
        txtUkuran.Multiline = True
        txtUkuran.Name = "txtUkuran"
        txtUkuran.Size = New Size(485, 36)
        txtUkuran.TabIndex = 44
        ' 
        ' txtNama
        ' 
        txtNama.BorderStyle = BorderStyle.FixedSingle
        txtNama.Location = New Point(35, 55)
        txtNama.Margin = New Padding(4, 5, 4, 5)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(485, 31)
        txtNama.TabIndex = 43
        ' 
        ' dgvProduk
        ' 
        dgvProduk.BackgroundColor = Color.White
        dgvProduk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProduk.Location = New Point(644, 173)
        dgvProduk.Margin = New Padding(4, 5, 4, 5)
        dgvProduk.Name = "dgvProduk"
        dgvProduk.RowHeadersWidth = 62
        dgvProduk.Size = New Size(620, 278)
        dgvProduk.TabIndex = 42
        ' 
        ' btnKembali
        ' 
        btnKembali.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnKembali.Location = New Point(644, 482)
        btnKembali.Margin = New Padding(4, 5, 4, 5)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(107, 38)
        btnKembali.TabIndex = 41
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.SteelBlue
        btnHapus.Font = New Font("Arial", 10F)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(380, 645)
        btnHapus.Margin = New Padding(4, 5, 4, 5)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(140, 38)
        btnHapus.TabIndex = 40
        btnHapus.Text = "Hapus Data"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.SteelBlue
        btnEdit.Font = New Font("Arial", 10F)
        btnEdit.ForeColor = Color.White
        btnEdit.Location = New Point(212, 645)
        btnEdit.Margin = New Padding(4, 5, 4, 5)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(137, 38)
        btnEdit.TabIndex = 39
        btnEdit.Text = "Ubah Data"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 10F, FontStyle.Bold)
        Label6.ForeColor = Color.SteelBlue
        Label6.Location = New Point(35, 263)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 24)
        Label6.TabIndex = 59
        Label6.Text = "Ukuran"
        ' 
        ' picProduk
        ' 
        picProduk.Location = New Point(35, 376)
        picProduk.Margin = New Padding(4, 5, 4, 5)
        picProduk.Name = "picProduk"
        picProduk.Size = New Size(485, 176)
        picProduk.TabIndex = 60
        picProduk.TabStop = False
        ' 
        ' btnGambar
        ' 
        btnGambar.BackColor = Color.White
        btnGambar.Font = New Font("Arial", 10F)
        btnGambar.ForeColor = Color.Black
        btnGambar.Location = New Point(35, 562)
        btnGambar.Margin = New Padding(4, 5, 4, 5)
        btnGambar.Name = "btnGambar"
        btnGambar.Size = New Size(147, 38)
        btnGambar.TabIndex = 61
        btnGambar.Text = "Ubah Gambar"
        btnGambar.UseVisualStyleBackColor = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.White
        btnBrowse.Font = New Font("Arial", 10F)
        btnBrowse.ForeColor = Color.Black
        btnBrowse.Location = New Point(200, 562)
        btnBrowse.Margin = New Padding(4, 5, 4, 5)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(116, 38)
        btnBrowse.TabIndex = 62
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(505, 37)
        Label7.Name = "Label7"
        Label7.Size = New Size(305, 46)
        Label7.TabIndex = 63
        Label7.Text = "DATA PRODUK"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtNama)
        Panel1.Controls.Add(btnBrowse)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(btnGambar)
        Panel1.Controls.Add(txtStok)
        Panel1.Controls.Add(picProduk)
        Panel1.Controls.Add(btnHapus)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(btnEdit)
        Panel1.Controls.Add(btnTambah)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(txtHarga)
        Panel1.Controls.Add(txtUkuran)
        Panel1.Location = New Point(49, 118)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(563, 722)
        Panel1.TabIndex = 64
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.SteelBlue
        Label8.Location = New Point(35, 347)
        Label8.Name = "Label8"
        Label8.Size = New Size(85, 24)
        Label8.TabIndex = 63
        Label8.Text = "Gambar"
        ' 
        ' kelola_data_produk
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(1317, 893)
        Controls.Add(Panel1)
        Controls.Add(Label7)
        Controls.Add(btnReset)
        Controls.Add(txtCari)
        Controls.Add(btnCari)
        Controls.Add(Label1)
        Controls.Add(dgvProduk)
        Controls.Add(btnKembali)
        Margin = New Padding(4, 5, 4, 5)
        Name = "kelola_data_produk"
        Text = "kelola_data_produk"
        CType(dgvProduk, ComponentModel.ISupportInitialize).EndInit()
        CType(picProduk, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTambah As Button
    Friend WithEvents ofdGambar As OpenFileDialog
    Friend WithEvents btnReset As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnCari As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents txtUkuran As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents dgvProduk As DataGridView
    Friend WithEvents btnKembali As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents picProduk As PictureBox
    Friend WithEvents btnGambar As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
End Class
