Imports MySql.Data.MySqlClient

Public Class riwayat_transaksi
    Dim FormIdPengguna As Integer
    Dim conn As MySqlConnection
    Dim da As MySqlDataAdapter
    Dim ds As DataSet

    Public Sub koneksi()
        conn = New MySqlConnection("server=localhost;userid=root;password=;database=toko_batik")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Private Sub riwayat_transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormIdPengguna = LoggedInUserId
        dtpRiwayat.Value = Date.Now
        dtpRiwayat.MaxDate = Date.Today
        TampilRiwayat()
    End Sub

    Private Sub TampilRiwayat()
        Try
            koneksi()
            da = New MySqlDataAdapter("
                SELECT t.id AS 'ID Transaksi', t.tanggal AS 'Tanggal', 
                       p.nama_produk AS 'Produk', d.jumlah AS 'Jumlah', 
                       d.subtotal AS 'Subtotal'
                FROM transaksi t
                JOIN detail_transaksi d ON t.id = d.id_transaksi
                JOIN produk p ON d.id_produk = p.id
                WHERE t.id_pengguna = @id_pengguna", conn)

            da.SelectCommand.Parameters.AddWithValue("@id_pengguna", FormIdPengguna)

            ds = New DataSet()
            da.Fill(ds, "riwayat")
            dgvRiwayat.DataSource = ds.Tables("riwayat")

        Catch ex As Exception
            MessageBox.Show("Gagal memuat riwayat transaksi: " & ex.Message)
        Finally
            If conn IsNot Nothing Then conn.Close()
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        TampilRiwayat()
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Try
            koneksi()
            Dim tanggalFilter As String = dtpRiwayat.Value.ToString("yyyy-MM-dd")

            da = New MySqlDataAdapter("
                SELECT t.id AS 'ID Transaksi', t.tanggal AS 'Tanggal', 
                       p.nama_produk AS 'Produk', d.jumlah AS 'Jumlah', 
                       d.subtotal AS 'Subtotal'
                FROM transaksi t
                JOIN detail_transaksi d ON t.id = d.id_transaksi
                JOIN produk p ON d.id_produk = p.id
                WHERE t.id_pengguna = @id_pengguna 
                  AND DATE(t.tanggal) = @tanggal", conn)

            da.SelectCommand.Parameters.AddWithValue("@id_pengguna", FormIdPengguna)
            da.SelectCommand.Parameters.AddWithValue("@tanggal", tanggalFilter)

            ds = New DataSet()
            da.Fill(ds, "riwayat")
            dgvRiwayat.DataSource = ds.Tables("riwayat")

        Catch ex As Exception
            MessageBox.Show("Gagal memfilter data: " & ex.Message)
        Finally
            If conn IsNot Nothing Then conn.Close()
        End Try
    End Sub

    Private Sub dgvRiwayat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRiwayat.CellContentClick
        ' Kosong (jika tidak dibutuhkan)
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        menu_utama_pelanggan.Show()
        Me.Hide()
    End Sub
End Class
