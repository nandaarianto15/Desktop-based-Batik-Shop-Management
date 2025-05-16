Imports MySql.Data.MySqlClient

Public Class kelola_data_pelanggan
    Dim idPengguna As Integer

    Private Sub kelola_data_pelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilPelanggan()
    End Sub

    Sub TampilPelanggan()
        koneksi()
        da = New MySqlDataAdapter("SELECT * FROM pengguna WHERE level='pelanggan'", conn)
        ds = New DataSet()
        da.Fill(ds, "pelanggan")
        dgvPelanggan.DataSource = ds.Tables("pelanggan")
        dgvPelanggan.Columns("id").HeaderText = "ID Pelanggan"
        dgvPelanggan.Columns("nama").HeaderText = "Nama"
        dgvPelanggan.Columns("username").HeaderText = "Username"
        dgvPelanggan.Columns("password").HeaderText = "Kata Sandi"
        dgvPelanggan.Columns("level").Visible = False
    End Sub

    Private Sub dgvPelanggan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPelanggan.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvPelanggan.Rows(e.RowIndex)
            idPengguna = row.Cells("id").Value
            txtNama.Text = row.Cells("nama").Value.ToString()
            txtUsername.Text = row.Cells("username").Value.ToString()
            txtPassword.Text = row.Cells("password").Value.ToString()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        koneksi()
        cmd = New MySqlCommand("UPDATE pengguna SET nama=@nama, username=@username, password=@password WHERE id=@id", conn)
        cmd.Parameters.AddWithValue("@nama", txtNama.Text)
        cmd.Parameters.AddWithValue("@username", txtUsername.Text)
        cmd.Parameters.AddWithValue("@password", txtPassword.Text)
        cmd.Parameters.AddWithValue("@id", idPengguna)
        cmd.ExecuteNonQuery()
        TampilPelanggan()
        MsgBox("Data pelanggan berhasil diperbarui!")
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        koneksi()
        cmd = New MySqlCommand("DELETE FROM pengguna WHERE id=@id", conn)
        cmd.Parameters.AddWithValue("@id", idPengguna)
        cmd.ExecuteNonQuery()
        TampilPelanggan()
        MsgBox("Data pelanggan berhasil dihapus!")
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        menu_utama_admin.Show()
        Me.Hide()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        koneksi()
        Dim keyword As String = txtCari.Text.Trim()
        da = New MySqlDataAdapter("SELECT * FROM pengguna WHERE nama LIKE @keyword", conn)
        da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
        ds = New DataSet()
        da.Fill(ds, "pengguna")
        dgvPelanggan.DataSource = ds.Tables("pengguna")

        dgvPelanggan.Columns("id").HeaderText = "ID Pengguna"
        dgvPelanggan.Columns("nama").HeaderText = "Nama"
        dgvPelanggan.Columns("username").HeaderText = "Username"
        dgvPelanggan.Columns("password").HeaderText = "Kata Sandi"
        dgvPelanggan.Columns("level").Visible = False
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TampilPelanggan()
    End Sub
End Class
