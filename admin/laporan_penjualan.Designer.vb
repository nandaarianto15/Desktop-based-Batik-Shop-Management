<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class laporan_penjualan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(laporan_penjualan))
        txtCari = New TextBox()
        BtnCari = New Button()
        lblTotal = New Label()
        dgvLaporan = New DataGridView()
        btnTampilkan = New Button()
        dtDari = New DateTimePicker()
        btnKembali = New Button()
        dtSampai = New DateTimePicker()
        menuStripLaporan = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        CetakLaporanToolStripMenuItem = New ToolStripMenuItem()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Label1 = New Label()
        CType(dgvLaporan, ComponentModel.ISupportInitialize).BeginInit()
        menuStripLaporan.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtCari
        ' 
        txtCari.BorderStyle = BorderStyle.FixedSingle
        txtCari.Location = New Point(57, 207)
        txtCari.Margin = New Padding(4, 5, 4, 5)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(631, 31)
        txtCari.TabIndex = 54
        ' 
        ' BtnCari
        ' 
        BtnCari.BackColor = Color.SteelBlue
        BtnCari.Font = New Font("Arial", 10F)
        BtnCari.ForeColor = Color.White
        BtnCari.Location = New Point(705, 202)
        BtnCari.Margin = New Padding(4, 5, 4, 5)
        BtnCari.Name = "BtnCari"
        BtnCari.Size = New Size(91, 36)
        BtnCari.TabIndex = 52
        BtnCari.Text = "Cari"
        BtnCari.UseVisualStyleBackColor = False
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(57, 520)
        lblTotal.Margin = New Padding(4, 0, 4, 0)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(76, 29)
        lblTotal.TabIndex = 46
        lblTotal.Text = "Label"
        ' 
        ' dgvLaporan
        ' 
        dgvLaporan.BackgroundColor = Color.White
        dgvLaporan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLaporan.Location = New Point(57, 254)
        dgvLaporan.Margin = New Padding(4, 5, 4, 5)
        dgvLaporan.Name = "dgvLaporan"
        dgvLaporan.RowHeadersWidth = 62
        dgvLaporan.Size = New Size(739, 250)
        dgvLaporan.TabIndex = 41
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.BackColor = Color.SteelBlue
        btnTampilkan.Font = New Font("Arial", 10F)
        btnTampilkan.ForeColor = Color.White
        btnTampilkan.Location = New Point(705, 153)
        btnTampilkan.Margin = New Padding(4, 5, 4, 5)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New Size(91, 36)
        btnTampilkan.TabIndex = 38
        btnTampilkan.Text = "Filter"
        btnTampilkan.UseVisualStyleBackColor = False
        ' 
        ' dtDari
        ' 
        dtDari.Location = New Point(57, 155)
        dtDari.Margin = New Padding(4, 5, 4, 5)
        dtDari.Name = "dtDari"
        dtDari.Size = New Size(306, 31)
        dtDari.TabIndex = 57
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.SteelBlue
        btnKembali.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnKembali.ForeColor = Color.White
        btnKembali.Location = New Point(57, 578)
        btnKembali.Margin = New Padding(4, 5, 4, 5)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(118, 45)
        btnKembali.TabIndex = 61
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' dtSampai
        ' 
        dtSampai.Location = New Point(382, 155)
        dtSampai.Margin = New Padding(4, 5, 4, 5)
        dtSampai.Name = "dtSampai"
        dtSampai.Size = New Size(306, 31)
        dtSampai.TabIndex = 62
        ' 
        ' menuStripLaporan
        ' 
        menuStripLaporan.BackColor = Color.SteelBlue
        menuStripLaporan.ImageScalingSize = New Size(24, 24)
        menuStripLaporan.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem})
        menuStripLaporan.Location = New Point(0, 0)
        menuStripLaporan.Name = "menuStripLaporan"
        menuStripLaporan.Size = New Size(886, 33)
        menuStripLaporan.TabIndex = 63
        menuStripLaporan.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CetakLaporanToolStripMenuItem})
        FileToolStripMenuItem.ForeColor = Color.White
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(54, 29)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' CetakLaporanToolStripMenuItem
        ' 
        CetakLaporanToolStripMenuItem.Name = "CetakLaporanToolStripMenuItem"
        CetakLaporanToolStripMenuItem.Size = New Size(227, 34)
        CetakLaporanToolStripMenuItem.Text = "Cetak Laporan"
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SteelBlue
        Label1.Location = New Point(211, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(466, 46)
        Label1.TabIndex = 64
        Label1.Text = "LAPORAN PENJUALAN"
        ' 
        ' laporan_penjualan
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(886, 671)
        Controls.Add(Label1)
        Controls.Add(dtSampai)
        Controls.Add(btnKembali)
        Controls.Add(dtDari)
        Controls.Add(txtCari)
        Controls.Add(BtnCari)
        Controls.Add(lblTotal)
        Controls.Add(dgvLaporan)
        Controls.Add(btnTampilkan)
        Controls.Add(menuStripLaporan)
        MainMenuStrip = menuStripLaporan
        Margin = New Padding(4, 5, 4, 5)
        Name = "laporan_penjualan"
        Text = "laporan_penjualan"
        CType(dgvLaporan, ComponentModel.ISupportInitialize).EndInit()
        menuStripLaporan.ResumeLayout(False)
        menuStripLaporan.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtCari As TextBox
    Friend WithEvents BtnCari As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents dgvLaporan As DataGridView
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents dtDari As DateTimePicker
    Friend WithEvents btnKembali As Button
    Friend WithEvents dtSampai As DateTimePicker
    Friend WithEvents menuStripLaporan As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CetakLaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label1 As Label
End Class
