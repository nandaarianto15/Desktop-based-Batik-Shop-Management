Imports MySql.Data.MySqlClient

Module modul_koneksi
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet

    Public LoggedInUserId As Integer

    Public Sub koneksi()
        Try
            Dim strConn As String = "server=localhost;user id=root;password=;database=toko_batik"
            conn = New MySqlConnection(strConn)
            conn.Open()
        Catch ex As Exception
            MsgBox("Koneksi gagal: " & ex.Message)
        End Try
    End Sub
End Module
