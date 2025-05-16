Imports MySql.Data.MySqlClient

Public Class pembelian_produk
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim ds As DataSet

    Dim selectedIdProduk As Integer = 0
    Dim selectedHarga As Integer = 0

    Public Sub koneksi()
        conn = New MySqlConnection("server=localhost;userid=root;password=;database=toko_batik")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Private Sub pembelian_produk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        da = New MySqlDataAdapter("SELECT id, nama_produk, harga, stok FROM produk", conn)
        ds = New DataSet()
        da.Fill(ds, "produk")
        dgvProduk.DataSource = ds.Tables("produk")
        dgvProduk.Columns("id").Visible = False
    End Sub

    Private Sub dgvProduk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduk.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvProduk.Rows(e.RowIndex)
            selectedIdProduk = Convert.ToInt32(row.Cells("id").Value)
            lblProduk.Text = row.Cells("nama_produk").Value.ToString
            selectedHarga = Convert.ToInt32(row.Cells("harga").Value)
            lblHarga.Text = selectedHarga.ToString("N0")

            ' Tampilkan gambar produk
            Try
                koneksi()
                cmd = New MySqlCommand("SELECT gambar FROM produk WHERE id = @id", conn)
                cmd.Parameters.AddWithValue("@id", selectedIdProduk)
                Dim gambarFileName = cmd.ExecuteScalar.ToString

                Dim lokasi = Application.StartupPath & "\gambar\" & gambarFileName

                If IO.File.Exists(lokasi) Then
                    PictureBox1.Image = Image.FromFile(lokasi)
                Else
                    PictureBox1.Image = Nothing
                End If
            Catch ex As Exception
                MsgBox("Gagal memuat gambar: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub JumlahPembelian_TextChanged(sender As Object, e As EventArgs) Handles JumlahPembelian.TextChanged
        If Integer.TryParse(JumlahPembelian.Text, Nothing) AndAlso selectedHarga > 0 Then
            Dim jumlah As Integer = Convert.ToInt32(JumlahPembelian.Text)
            Dim total As Integer = selectedHarga * jumlah
            lblHarga.Text = total.ToString("N0")
        Else
            lblHarga.Text = selectedHarga.ToString("N0")
        End If
    End Sub

    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        If selectedIdProduk = 0 Then
            MsgBox("Pilih produk dan masukkan jumlah.")
            Return
        End If

        Dim jumlah As Integer
        If Not Integer.TryParse(JumlahPembelian.Text, jumlah) OrElse jumlah <= 0 Then
            MsgBox("Masukkan jumlah pembelian yang valid.")
            Return
        End If

        Dim subtotal = selectedHarga * jumlah

        koneksi()
        Dim trans = conn.BeginTransaction

        Try
            ' Cek stok
            cmd = New MySqlCommand("SELECT stok FROM produk WHERE id = @id_produk", conn, trans)
            cmd.Parameters.AddWithValue("@id_produk", selectedIdProduk)
            Dim stokSaatIni = Convert.ToInt32(cmd.ExecuteScalar)

            If stokSaatIni < jumlah Then
                MsgBox("Stok tidak mencukupi.")
                trans.Rollback()
                Return
            End If

            ' Insert transaksi (pakai LoggedInUserId dari modul)
            cmd = New MySqlCommand("INSERT INTO transaksi (id_pengguna, tanggal, total) VALUES (@id, @tgl, @total)", conn, trans)
            cmd.Parameters.AddWithValue("@id", LoggedInUserId)
            cmd.Parameters.AddWithValue("@tgl", Date.Now)
            cmd.Parameters.AddWithValue("@total", subtotal)
            cmd.ExecuteNonQuery()

            Dim idTransaksi As Integer = cmd.LastInsertedId

            ' Insert detail_transaksi
            cmd = New MySqlCommand("INSERT INTO detail_transaksi (id_transaksi, id_produk, jumlah, subtotal) VALUES (@id_trx, @id_produk, @jumlah, @subtotal)", conn, trans)
            cmd.Parameters.AddWithValue("@id_trx", idTransaksi)
            cmd.Parameters.AddWithValue("@id_produk", selectedIdProduk)
            cmd.Parameters.AddWithValue("@jumlah", jumlah)
            cmd.Parameters.AddWithValue("@subtotal", subtotal)
            cmd.ExecuteNonQuery()

            ' Update stok
            cmd = New MySqlCommand("UPDATE produk SET stok = stok - @jumlah WHERE id = @id_produk", conn, trans)
            cmd.Parameters.AddWithValue("@jumlah", jumlah)
            cmd.Parameters.AddWithValue("@id_produk", selectedIdProduk)
            cmd.ExecuteNonQuery()

            trans.Commit()
            MsgBox("Transaksi berhasil!")

            ' Reset form
            selectedIdProduk = 0
            selectedHarga = 0
            JumlahPembelian.Text = ""
            lblProduk.Text = "-"
            lblHarga.Text = "-"
            PictureBox1.Image = Nothing

            ' Refresh DataGridView
            Dim da As New MySqlDataAdapter("SELECT id, nama_produk, harga, stok FROM produk", conn)
            Dim dt As New DataTable
            da.Fill(dt)
            dgvProduk.DataSource = dt

        Catch ex As Exception
            trans.Rollback()
            MsgBox("Transaksi gagal: " & ex.Message)
        End Try
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        menu_utama_pelanggan.Show()
        Hide()
    End Sub

    Private Sub Cari_Click(sender As Object, e As EventArgs) Handles Cari.Click
        koneksi()
        Dim keyword = txtCari.Text.Trim
        da = New MySqlDataAdapter("SELECT id, nama_produk, harga, stok FROM produk WHERE nama_produk LIKE @keyword", conn)
        da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
        ds = New DataSet
        da.Fill(ds, "produk")
        dgvProduk.DataSource = ds.Tables("produk")
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        koneksi()
        da = New MySqlDataAdapter("SELECT id, nama_produk, harga, stok FROM produk", conn)
        ds = New DataSet
        da.Fill(ds, "produk")
        dgvProduk.DataSource = ds.Tables("produk")

        txtCari.Text = ""
        selectedIdProduk = 0
        selectedHarga = 0
        JumlahPembelian.Text = ""
        lblProduk.Text = "-"
        lblHarga.Text = "-"
        PictureBox1.Image = Nothing
    End Sub
End Class
