<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pembelian_produk
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
        btnBayar = New Button()
        btnKembali = New Button()
        dgvProduk = New DataGridView()
        PictureBox1 = New PictureBox()
        lblHarga = New Label()
        Cari = New Button()
        txtJumlah = New Label()
        lblProduk = New Label()
        txtCari = New TextBox()
        JumlahPembelian = New NumericUpDown()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        BtnReset = New Button()
        Label5 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        CType(dgvProduk, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(JumlahPembelian, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnBayar
        ' 
        btnBayar.BackColor = Color.SteelBlue
        btnBayar.Font = New Font("Arial", 10F)
        btnBayar.ForeColor = Color.White
        btnBayar.Location = New Point(382, 604)
        btnBayar.Margin = New Padding(4, 5, 4, 5)
        btnBayar.Name = "btnBayar"
        btnBayar.Size = New Size(232, 40)
        btnBayar.TabIndex = 8
        btnBayar.Text = "Bayar"
        btnBayar.UseVisualStyleBackColor = False
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.SteelBlue
        btnKembali.Font = New Font("Arial", 10F)
        btnKembali.ForeColor = Color.White
        btnKembali.Location = New Point(105, 604)
        btnKembali.Margin = New Padding(4, 5, 4, 5)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(230, 40)
        btnKembali.TabIndex = 6
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' dgvProduk
        ' 
        dgvProduk.BackgroundColor = Color.White
        dgvProduk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProduk.Location = New Point(105, 202)
        dgvProduk.Margin = New Padding(4, 5, 4, 5)
        dgvProduk.Name = "dgvProduk"
        dgvProduk.RowHeadersWidth = 62
        dgvProduk.Size = New Size(509, 261)
        dgvProduk.TabIndex = 9
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(622, 202)
        PictureBox1.Margin = New Padding(4, 5, 4, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(335, 317)
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' lblHarga
        ' 
        lblHarga.AutoSize = True
        lblHarga.BackColor = Color.White
        lblHarga.Font = New Font("Arial", 10F)
        lblHarga.Location = New Point(302, 540)
        lblHarga.Margin = New Padding(4, 0, 4, 0)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(111, 23)
        lblHarga.TabIndex = 18
        lblHarga.Text = "Total Harga"
        ' 
        ' Cari
        ' 
        Cari.BackColor = Color.SteelBlue
        Cari.Font = New Font("Arial", 10F)
        Cari.ForeColor = Color.White
        Cari.Location = New Point(732, 153)
        Cari.Margin = New Padding(4, 5, 4, 5)
        Cari.Name = "Cari"
        Cari.Size = New Size(110, 36)
        Cari.TabIndex = 17
        Cari.Text = "Cari"
        Cari.UseVisualStyleBackColor = False
        ' 
        ' txtJumlah
        ' 
        txtJumlah.AutoSize = True
        txtJumlah.Location = New Point(730, 552)
        txtJumlah.Margin = New Padding(4, 0, 4, 0)
        txtJumlah.Name = "txtJumlah"
        txtJumlah.Size = New Size(0, 25)
        txtJumlah.TabIndex = 22
        ' 
        ' lblProduk
        ' 
        lblProduk.AutoSize = True
        lblProduk.BackColor = Color.White
        lblProduk.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblProduk.Location = New Point(622, 524)
        lblProduk.Margin = New Padding(4, 0, 4, 0)
        lblProduk.Name = "lblProduk"
        lblProduk.Size = New Size(82, 23)
        lblProduk.TabIndex = 23
        lblProduk.Text = "Gambar"
        ' 
        ' txtCari
        ' 
        txtCari.BorderStyle = BorderStyle.FixedSingle
        txtCari.Location = New Point(105, 156)
        txtCari.Margin = New Padding(4, 5, 4, 5)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(619, 31)
        txtCari.TabIndex = 24
        ' 
        ' JumlahPembelian
        ' 
        JumlahPembelian.Location = New Point(247, 488)
        JumlahPembelian.Margin = New Padding(4, 5, 4, 5)
        JumlahPembelian.Name = "JumlahPembelian"
        JumlahPembelian.Size = New Size(207, 31)
        JumlahPembelian.TabIndex = 25
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Arial", 10F)
        Label1.Location = New Point(105, 540)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 23)
        Label1.TabIndex = 26
        Label1.Text = "Total Harga"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Arial", 10F)
        Label2.Location = New Point(223, 540)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(22, 23)
        Label2.TabIndex = 27
        Label2.Text = "="
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Arial", 10F)
        Label3.Location = New Point(253, 540)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 23)
        Label3.TabIndex = 28
        Label3.Text = "Rp."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(105, 491)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(139, 23)
        Label4.TabIndex = 29
        Label4.Text = "Jumlah Produk"
        ' 
        ' BtnReset
        ' 
        BtnReset.BackColor = Color.SteelBlue
        BtnReset.Font = New Font("Arial", 10F)
        BtnReset.ForeColor = Color.White
        BtnReset.Location = New Point(847, 153)
        BtnReset.Margin = New Padding(4, 5, 4, 5)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(110, 36)
        BtnReset.TabIndex = 30
        BtnReset.Text = "Reset"
        BtnReset.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(316, 39)
        Label5.Name = "Label5"
        Label5.Size = New Size(438, 46)
        Label5.TabIndex = 31
        Label5.Text = "PEMBELIAN PRODUK"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.White
        FlowLayoutPanel1.Location = New Point(61, 119)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(946, 575)
        FlowLayoutPanel1.TabIndex = 32
        ' 
        ' pembelian_produk
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(1063, 785)
        Controls.Add(lblProduk)
        Controls.Add(BtnReset)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(JumlahPembelian)
        Controls.Add(txtCari)
        Controls.Add(txtJumlah)
        Controls.Add(Cari)
        Controls.Add(PictureBox1)
        Controls.Add(dgvProduk)
        Controls.Add(btnBayar)
        Controls.Add(btnKembali)
        Controls.Add(Label3)
        Controls.Add(lblHarga)
        Controls.Add(FlowLayoutPanel1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "pembelian_produk"
        Text = "pembelian_produk"
        CType(dgvProduk, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(JumlahPembelian, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBayar As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents dgvProduk As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblHarga As Label
    Friend WithEvents Cari As Button
    Friend WithEvents txtJumlah As Label
    Friend WithEvents lblProduk As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents JumlahPembelian As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnReset As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
