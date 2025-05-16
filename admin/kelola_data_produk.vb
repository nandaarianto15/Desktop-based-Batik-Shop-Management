Imports MySql.Data.MySqlClient
Imports System.IO

Public Class kelola_data_produk
    Dim idProduk As Integer
    Dim gambarPath As String = ""

    Private Sub kelola_data_produk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilProduk()

        ' Buat folder gambar jika belum ada
        Dim folderGambar As String = Application.StartupPath & "\gambar\"
        If Not Directory.Exists(folderGambar) Then
            Directory.CreateDirectory(folderGambar)
        End If
    End Sub

    Sub TampilProduk()
        koneksi()
        da = New MySqlDataAdapter("SELECT * FROM produk", conn)
        ds = New DataSet()
        da.Fill(ds, "produk")
        dgvProduk.DataSource = ds.Tables("produk")
        dgvProduk.Columns("gambar").Visible = False
    End Sub

    Private Sub dgvProduk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduk.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvProduk.Rows(e.RowIndex)
            idProduk = row.Cells("id").Value
            txtNama.Text = row.Cells("nama_produk").Value
            txtHarga.Text = row.Cells("harga").Value
            txtStok.Text = row.Cells("stok").Value
            gambarPath = row.Cells("gambar").Value.ToString()

            Dim lokasi As String = Application.StartupPath & "\gambar\" & gambarPath
            If File.Exists(lokasi) Then
                picProduk.Image = Image.FromFile(lokasi)
            Else
                picProduk.Image = Nothing
            End If
        End If
    End Sub

    Private Sub UploadGambar()
        ofdGambar.Filter = "Image Files|*.jpg;*.jpeg;*.png;"
        If ofdGambar.ShowDialog() = DialogResult.OK Then
            gambarPath = Path.GetFileName(ofdGambar.FileName)
            picProduk.Image = Image.FromFile(ofdGambar.FileName)

            Dim folderGambar As String = Application.StartupPath & "\gambar\"
            If Not Directory.Exists(folderGambar) Then
                Directory.CreateDirectory(folderGambar)
            End If

            File.Copy(ofdGambar.FileName, folderGambar & gambarPath, True)
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        UploadGambar()
    End Sub

    Private Sub btnGambar_Click(sender As Object, e As EventArgs) Handles btnGambar.Click
        UploadGambar()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If gambarPath = "" Then
            MsgBox("Silakan pilih gambar terlebih dahulu.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        koneksi()
        cmd = New MySqlCommand("INSERT INTO produk (nama_produk, harga, stok, gambar, ukuran) VALUES (@nama, @harga, @stok, @gambar, @ukuran)", conn)
        cmd.Parameters.AddWithValue("@nama", txtNama.Text)
        cmd.Parameters.AddWithValue("@harga", txtHarga.Text)
        cmd.Parameters.AddWithValue("@stok", txtStok.Text)
        cmd.Parameters.AddWithValue("@gambar", gambarPath)
        cmd.Parameters.AddWithValue("@ukuran", txtUkuran.Text)
        cmd.ExecuteNonQuery()
        TampilProduk()
        MsgBox("Produk berhasil ditambahkan.")
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If gambarPath = "" Then
            MsgBox("Silakan pilih gambar terlebih dahulu.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        koneksi()
        cmd = New MySqlCommand("UPDATE produk SET nama_produk=@nama, harga=@harga, stok=@stok, gambar=@gambar, ukuran=@ukuran WHERE id=@id", conn)
        cmd.Parameters.AddWithValue("@nama", txtNama.Text)
        cmd.Parameters.AddWithValue("@harga", txtHarga.Text)
        cmd.Parameters.AddWithValue("@stok", txtStok.Text)
        cmd.Parameters.AddWithValue("@gambar", gambarPath)
        cmd.Parameters.AddWithValue("@ukuran", txtUkuran.Text)
        cmd.Parameters.AddWithValue("@id", idProduk)
        cmd.ExecuteNonQuery()
        TampilProduk()
        MsgBox("Produk berhasil diubah.")
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MessageBox.Show("Yakin ingin menghapus produk ini?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            koneksi()
            cmd = New MySqlCommand("DELETE FROM produk WHERE id=@id", conn)
            cmd.Parameters.AddWithValue("@id", idProduk)
            cmd.ExecuteNonQuery()
            TampilProduk()
            MsgBox("Produk berhasil dihapus.")
        End If
    End Sub
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        menu_utama_admin.Show()
        Me.Hide()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        TampilProduk()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        koneksi()
        Dim keyword As String = txtCari.Text.Trim()
        da = New MySqlDataAdapter("SELECT * FROM produk WHERE nama_produk LIKE @keyword", conn)
        da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
        ds = New DataSet()
        da.Fill(ds, "produk")
        dgvProduk.DataSource = ds.Tables("produk")
    End Sub

    Private Sub dgvProduk_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduk.CellContentClick

    End Sub
End Class
