<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_utama_admin
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
        btnProduk = New Button()
        btnPelanggan = New Button()
        btnLogout = New Button()
        btnLaporan = New Button()
        lblSelamat = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnProduk
        ' 
        btnProduk.BackColor = Color.SteelBlue
        btnProduk.Font = New Font("Arial", 10F, FontStyle.Bold)
        btnProduk.ForeColor = Color.White
        btnProduk.Location = New Point(146, 163)
        btnProduk.Margin = New Padding(4, 5, 4, 5)
        btnProduk.Name = "btnProduk"
        btnProduk.Size = New Size(378, 55)
        btnProduk.TabIndex = 0
        btnProduk.Text = "Manajemen Data Produk"
        btnProduk.UseVisualStyleBackColor = False
        ' 
        ' btnPelanggan
        ' 
        btnPelanggan.Font = New Font("Arial", 10F, FontStyle.Bold)
        btnPelanggan.Location = New Point(146, 240)
        btnPelanggan.Margin = New Padding(4, 5, 4, 5)
        btnPelanggan.Name = "btnPelanggan"
        btnPelanggan.Size = New Size(378, 50)
        btnPelanggan.TabIndex = 1
        btnPelanggan.Text = "Manajemen Data Pelanggan"
        btnPelanggan.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Font = New Font("Arial", 10F, FontStyle.Bold)
        btnLogout.Location = New Point(146, 386)
        btnLogout.Margin = New Padding(4, 5, 4, 5)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(378, 48)
        btnLogout.TabIndex = 3
        btnLogout.Text = "Kembali"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnLaporan
        ' 
        btnLaporan.BackColor = Color.SteelBlue
        btnLaporan.Font = New Font("Arial", 10F, FontStyle.Bold)
        btnLaporan.ForeColor = Color.White
        btnLaporan.Location = New Point(146, 313)
        btnLaporan.Margin = New Padding(4, 5, 4, 5)
        btnLaporan.Name = "btnLaporan"
        btnLaporan.Size = New Size(378, 48)
        btnLaporan.TabIndex = 4
        btnLaporan.Text = "Laporan Penjualan"
        btnLaporan.UseVisualStyleBackColor = False
        ' 
        ' lblSelamat
        ' 
        lblSelamat.AutoSize = True
        lblSelamat.Font = New Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSelamat.ForeColor = Color.SteelBlue
        lblSelamat.Location = New Point(74, 54)
        lblSelamat.Margin = New Padding(4, 0, 4, 0)
        lblSelamat.Name = "lblSelamat"
        lblSelamat.Size = New Size(378, 46)
        lblSelamat.TabIndex = 5
        lblSelamat.Text = "SELAMAT DATANG"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SteelBlue
        Label1.Location = New Point(251, 114)
        Label1.Name = "Label1"
        Label1.Size = New Size(179, 27)
        Label1.TabIndex = 6
        Label1.Text = "- Menu Utama -"
        ' 
        ' menu_utama_admin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(647, 488)
        Controls.Add(Label1)
        Controls.Add(lblSelamat)
        Controls.Add(btnLaporan)
        Controls.Add(btnLogout)
        Controls.Add(btnPelanggan)
        Controls.Add(btnProduk)
        Margin = New Padding(4, 5, 4, 5)
        Name = "menu_utama_admin"
        Text = "menu_utama_admin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnProduk As Button
    Friend WithEvents btnPelanggan As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnLaporan As Button
    Friend WithEvents lblSelamat As Label
    Friend WithEvents Label1 As Label
End Class
