Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class laporan_penjualan
    Dim conn As MySqlConnection
    Dim da As MySqlDataAdapter
    Dim ds As DataSet

    ' Koneksi ke database
    Public Sub koneksi()
        conn = New MySqlConnection("server=localhost;userid=root;password=;database=toko_batik")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    ' Saat form dimuat
    Private Sub laporan_penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtDari.Value = Date.Now.AddMonths(-1)
        dtSampai.Value = Date.Now
        dtSampai.MaxDate = Date.Today
        dtDari.MaxDate = Date.Today
        TampilkanLaporan()
    End Sub

    ' Tampilkan laporan
    Private Sub TampilkanLaporan()
        koneksi()

        Dim dari As Date = dtDari.Value.Date
        Dim sampai As Date = dtSampai.Value.Date.AddDays(1).AddSeconds(-1)

        Dim query As String = "SELECT t.id, t.tanggal, p.nama_produk, d.jumlah, d.subtotal
                           FROM transaksi t
                           JOIN detail_transaksi d ON t.id = d.id_transaksi
                           JOIN produk p ON d.id_produk = p.id
                           WHERE t.tanggal BETWEEN @dari AND @sampai"

        da = New MySqlDataAdapter(query, conn)
        da.SelectCommand.Parameters.AddWithValue("@dari", dari)
        da.SelectCommand.Parameters.AddWithValue("@sampai", sampai)

        ds = New DataSet()
        da.Fill(ds, "laporan")
        dgvLaporan.DataSource = ds.Tables("laporan")
        dgvLaporan.Columns("id").HeaderText = "ID Transaksi"
        dgvLaporan.Columns("tanggal").HeaderText = "Tanggal"
        dgvLaporan.Columns("nama_produk").HeaderText = "Nama Produk"
        dgvLaporan.Columns("jumlah").HeaderText = "Jumlah"
        dgvLaporan.Columns("subtotal").HeaderText = "Subtotal"


        ' Hitung total
        Dim total As Integer = 0
        For Each row As DataRow In ds.Tables("laporan").Rows
            total += Val(row("subtotal"))
        Next
        lblTotal.Text = "Total Pendapatan: Rp " & total.ToString("N0")
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        koneksi()
        Dim keyword As String = txtCari.Text.Trim()

        Dim query As String = "SELECT t.id, t.tanggal, p.nama_produk, d.jumlah, d.subtotal " &
                          "FROM transaksi t " &
                          "JOIN detail_transaksi d ON t.id = d.id_transaksi " &
                          "JOIN produk p ON d.id_produk = p.id " &
                          "WHERE p.nama_produk LIKE @keyword OR t.tanggal LIKE @keyword"

        da = New MySqlDataAdapter(query, conn)
        da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")

        ds = New DataSet()
        da.Fill(ds, "laporan")
        dgvLaporan.DataSource = ds.Tables("laporan")
        dgvLaporan.Columns("id").HeaderText = "ID Transaksi"
        dgvLaporan.Columns("tanggal").HeaderText = "Tanggal"
        dgvLaporan.Columns("nama_produk").HeaderText = "Nama Produk"
        dgvLaporan.Columns("jumlah").HeaderText = "Jumlah"
        dgvLaporan.Columns("subtotal").HeaderText = "Subtotal"


        Dim total As Integer = 0
        For Each row As DataRow In ds.Tables("laporan").Rows
            total += Val(row("subtotal"))
        Next
        lblTotal.Text = "Total Pendapatan: Rp " & total.ToString("N0")
    End Sub


    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        TampilkanLaporan()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        menu_utama_admin.Show()
        Me.Hide()
    End Sub



    Private Sub CetakLaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CetakLaporanToolStripMenuItem.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Width = 1000
        PrintPreviewDialog1.Height = 800
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Arial", 10)
        Dim brush As New SolidBrush(Color.Black)
        Dim leftMargin As Integer = e.MarginBounds.Left
        Dim rightMargin As Integer = e.MarginBounds.Right
        Dim topMargin As Integer = e.MarginBounds.Top
        Dim pageWidth As Integer = e.MarginBounds.Width
        Dim y As Integer = topMargin

        Dim title As String = "LAPORAN PENJUALAN"
        Dim titleFont As New Font("Arial", 16, FontStyle.Bold)
        Dim titleSize As SizeF = e.Graphics.MeasureString(title, titleFont)
        Dim titleX As Single = leftMargin + (pageWidth - titleSize.Width) / 2

        e.Graphics.DrawString(title, titleFont, brush, titleX, y)
        y += CInt(titleSize.Height + 10)

        e.Graphics.DrawLine(New Pen(Color.Black, 2), leftMargin, y, rightMargin, y)
        y += 20

        Dim colWidths As Integer() = {70, 110, 270, 90, 110}
        Dim headers As String() = {"ID", "Tanggal", "Nama Produk", "Jumlah", "Subtotal"}
        Dim xPos As Integer = leftMargin
        Dim headerHeight As Integer = 30
        Dim headerFont As New Font("Arial", 10, FontStyle.Bold)
        Dim headerBrush As New SolidBrush(Color.White)
        Dim headerBack As New SolidBrush(Color.Gray)

        For i As Integer = 0 To headers.Length - 1
            Dim cellRect As New Rectangle(xPos, y, colWidths(i), headerHeight)
            e.Graphics.FillRectangle(headerBack, cellRect)
            e.Graphics.DrawRectangle(Pens.Black, cellRect)
            e.Graphics.DrawString(headers(i), headerFont, headerBrush, cellRect, New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
            xPos += colWidths(i)
        Next
        y += headerHeight

        For Each row As DataGridViewRow In dgvLaporan.Rows
            If Not row.IsNewRow Then
                xPos = leftMargin
                Dim cellHeight As Integer = 25
                Dim values As String() = {
                    row.Cells("id").Value.ToString(),
                    CDate(row.Cells("tanggal").Value).ToString("dd/MM/yyyy"),
                    row.Cells("nama_produk").Value.ToString(),
                    row.Cells("jumlah").Value.ToString(),
                    Val(row.Cells("subtotal").Value).ToString("N0")
                }

                For i As Integer = 0 To values.Length - 1
                    Dim cellRect As New Rectangle(xPos, y, colWidths(i), cellHeight)
                    e.Graphics.DrawRectangle(Pens.Black, cellRect)
                    e.Graphics.DrawString(values(i), font, brush, cellRect, New StringFormat With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Center})
                    xPos += colWidths(i)
                Next
                y += cellHeight
            End If
        Next

        y += 20
        e.Graphics.DrawString(lblTotal.Text, New Font("Arial", 12, FontStyle.Bold), brush, leftMargin, y)
    End Sub
End Class
