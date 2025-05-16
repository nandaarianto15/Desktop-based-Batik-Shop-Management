Imports Microsoft.VisualBasic.Logging

Public Class menu_utama_admin
    Private Sub menu_utama_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSelamat.Text = "Selamat Datang, Admin!"
    End Sub

    Private Sub btnProduk_Click(sender As Object, e As EventArgs) Handles btnProduk.Click
        kelola_data_produk.Show()
        Me.Hide()
    End Sub

    Private Sub btnPelanggan_Click(sender As Object, e As EventArgs) Handles btnPelanggan.Click
        kelola_data_pelanggan.Show()
        Me.Hide()
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        laporan_penjualan.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Form1.Show()
        Me.Hide()
    End Sub

End Class
