Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports Microsoft.VisualBasic.Logging
Imports MySql.Data.MySqlClient

Public Class regist
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or TextBox1.Text = "" Or TextBox7.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Data tidak boleh kosong!")
            Exit Sub
        End If
        koneksi()
        cmd = New MySqlCommand("INSERT INTO pengguna (nama, username, password, level) VALUES (@nama, @username, @password, @level)", conn)
        cmd.Parameters.AddWithValue("@nama", TextBox2.Text)
        cmd.Parameters.AddWithValue("@username", TextBox1.Text)
        cmd.Parameters.AddWithValue("@password", TextBox7.Text)
        cmd.Parameters.AddWithValue("@level", ComboBox1.Text)
        cmd.ExecuteNonQuery()
        MsgBox("Registrasi berhasil!")

        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub regist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("admin")
        ComboBox1.Items.Add("pelanggan")
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub checkPassword_CheckedChanged(sender As Object, e As EventArgs) Handles checkPassword.CheckedChanged
        If checkPassword.Checked Then
            TextBox7.UseSystemPasswordChar = False
        Else
            TextBox7.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class
