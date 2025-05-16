<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_utama_pelanggan
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
        btnBeli = New Button()
        btnRiwayat = New Button()
        btnLogout = New Button()
        lblSelamat = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnBeli
        ' 
        btnBeli.BackColor = Color.White
        btnBeli.Font = New Font("Arial", 10F, FontStyle.Bold)
        btnBeli.ForeColor = Color.Black
        btnBeli.Location = New Point(79, 162)
        btnBeli.Margin = New Padding(4, 5, 4, 5)
        btnBeli.Name = "btnBeli"
        btnBeli.Size = New Size(378, 50)
        btnBeli.TabIndex = 0
        btnBeli.Text = "Lihat dan Beli "
        btnBeli.UseVisualStyleBackColor = False
        ' 
        ' btnRiwayat
        ' 
        btnRiwayat.BackColor = Color.SteelBlue
        btnRiwayat.Font = New Font("Arial", 10F, FontStyle.Bold)
        btnRiwayat.ForeColor = Color.White
        btnRiwayat.Location = New Point(79, 222)
        btnRiwayat.Margin = New Padding(4, 5, 4, 5)
        btnRiwayat.Name = "btnRiwayat"
        btnRiwayat.Size = New Size(378, 50)
        btnRiwayat.TabIndex = 1
        btnRiwayat.Text = "Riwayat Transaksi"
        btnRiwayat.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.White
        btnLogout.Font = New Font("Arial", 10F, FontStyle.Bold)
        btnLogout.ForeColor = Color.Black
        btnLogout.Location = New Point(79, 282)
        btnLogout.Margin = New Padding(4, 5, 4, 5)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(378, 50)
        btnLogout.TabIndex = 2
        btnLogout.Text = "Kembali"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' lblSelamat
        ' 
        lblSelamat.AutoSize = True
        lblSelamat.BackColor = Color.Transparent
        lblSelamat.Font = New Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSelamat.ForeColor = Color.SteelBlue
        lblSelamat.Location = New Point(79, 59)
        lblSelamat.Margin = New Padding(4, 0, 4, 0)
        lblSelamat.Name = "lblSelamat"
        lblSelamat.Size = New Size(378, 46)
        lblSelamat.TabIndex = 3
        lblSelamat.Text = "SELAMAT DATANG"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SteelBlue
        Label1.Location = New Point(176, 118)
        Label1.Name = "Label1"
        Label1.Size = New Size(179, 27)
        Label1.TabIndex = 4
        Label1.Text = "- Menu Utama -"
        ' 
        ' menu_utama_pelanggan
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(537, 425)
        Controls.Add(Label1)
        Controls.Add(lblSelamat)
        Controls.Add(btnLogout)
        Controls.Add(btnRiwayat)
        Controls.Add(btnBeli)
        Margin = New Padding(4, 5, 4, 5)
        Name = "menu_utama_pelanggan"
        Text = "menu_utama_pelanggan"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBeli As Button
    Friend WithEvents btnRiwayat As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblSelamat As Label
    Friend WithEvents Label1 As Label
End Class
