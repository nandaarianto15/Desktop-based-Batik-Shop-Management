Imports Microsoft.VisualBasic.Logging

Public Class menu_utama_pelanggan
    Public Shared namaPengguna As String

    Private Sub menu_utama_pelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSelamat.Text = "Selamat Datang, " & namaPengguna & "!"
    End Sub

    Private Sub btnBeli_Click(sender As Object, e As EventArgs) Handles btnBeli.Click
        pembelian_produk.Show()
        Me.Hide()
    End Sub

    Private Sub btnRiwayat_Click(sender As Object, e As EventArgs) Handles btnRiwayat.Click
        riwayat_transaksi.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Form1.Show()
        Me.Hide()
    End Sub

End Class
