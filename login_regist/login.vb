Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles Button1.Click
        koneksi() ' Pastikan koneksi sudah terbuka

        If conn.State = ConnectionState.Open Then
            Try
                cmd = New MySqlCommand("SELECT * FROM pengguna WHERE username=@user AND password=@pass", conn)
                cmd.Parameters.AddWithValue("@user", TextBox1.Text)
                cmd.Parameters.AddWithValue("@pass", TextBox2.Text)

                dr = cmd.ExecuteReader

                If dr.Read Then
                    LoggedInUserId = dr("id")
                    MsgBox("Login Berhasil!")
                    If dr("level") = "admin" Then
                        menu_utama_admin.Show()
                    Else
                        menu_utama_pelanggan.Show()
                    End If
                    Hide()
                Else
                    MsgBox("Username atau password salah.")
                End If


            Catch ex As Exception
                MsgBox("Login error: " & ex.Message)
            Finally
                dr.Close()
                conn.Close()
            End Try
        Else
            MsgBox("Koneksi database belum terbuka.")
        End If
    End Sub


    Private Sub linkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        regist.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub checkPassword_CheckedChanged(sender As Object, e As EventArgs) Handles checkPassword.CheckedChanged
        If checkPassword.Checked Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class
