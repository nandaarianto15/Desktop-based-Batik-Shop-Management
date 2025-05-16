<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class riwayat_transaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnKembali = New Button()
        dgvRiwayat = New DataGridView()
        dtpRiwayat = New DateTimePicker()
        btnRefresh = New Button()
        btnFilter = New Button()
        Label1 = New Label()
        CType(dgvRiwayat, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.SteelBlue
        btnKembali.Font = New Font("Arial", 10F)
        btnKembali.ForeColor = Color.White
        btnKembali.Location = New Point(58, 442)
        btnKembali.Margin = New Padding(4, 5, 4, 5)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(107, 38)
        btnKembali.TabIndex = 0
        btnKembali.Text = "kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' dgvRiwayat
        ' 
        dgvRiwayat.BackgroundColor = Color.White
        dgvRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRiwayat.Location = New Point(58, 167)
        dgvRiwayat.Margin = New Padding(4, 5, 4, 5)
        dgvRiwayat.Name = "dgvRiwayat"
        dgvRiwayat.RowHeadersWidth = 62
        dgvRiwayat.Size = New Size(815, 250)
        dgvRiwayat.TabIndex = 1
        ' 
        ' dtpRiwayat
        ' 
        dtpRiwayat.Location = New Point(58, 125)
        dtpRiwayat.Margin = New Padding(4, 5, 4, 5)
        dtpRiwayat.Name = "dtpRiwayat"
        dtpRiwayat.Size = New Size(565, 31)
        dtpRiwayat.TabIndex = 2
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.SteelBlue
        btnRefresh.Font = New Font("Arial", 10F)
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(749, 122)
        btnRefresh.Margin = New Padding(4, 5, 4, 5)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(122, 34)
        btnRefresh.TabIndex = 3
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnFilter
        ' 
        btnFilter.BackColor = Color.SteelBlue
        btnFilter.Font = New Font("Arial", 10F)
        btnFilter.ForeColor = Color.White
        btnFilter.Location = New Point(630, 122)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(112, 34)
        btnFilter.TabIndex = 4
        btnFilter.Text = "Filter"
        btnFilter.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SteelBlue
        Label1.Location = New Point(249, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(429, 46)
        Label1.TabIndex = 5
        Label1.Text = "RIWAYAT TRANSAKSI"
        ' 
        ' riwayat_transaksi
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(926, 545)
        Controls.Add(Label1)
        Controls.Add(btnFilter)
        Controls.Add(btnRefresh)
        Controls.Add(dtpRiwayat)
        Controls.Add(dgvRiwayat)
        Controls.Add(btnKembali)
        Margin = New Padding(4, 5, 4, 5)
        Name = "riwayat_transaksi"
        Text = "riwayat_transaksi"
        CType(dgvRiwayat, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnKembali As Button
    Friend WithEvents dgvRiwayat As DataGridView
    Friend WithEvents dtpRiwayat As DateTimePicker
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnFilter As Button
    Friend WithEvents Label1 As Label
End Class
