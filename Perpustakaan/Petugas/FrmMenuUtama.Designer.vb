<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuUtama
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
        Me.BtnPeminjaman = New System.Windows.Forms.Button()
        Me.BtnPeminjam = New System.Windows.Forms.Button()
        Me.BtnBuku = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Username = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnPeminjaman
        '
        Me.BtnPeminjaman.Image = Global.Perpustakaan.My.Resources.Resources.shopping_cart
        Me.BtnPeminjaman.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPeminjaman.Location = New System.Drawing.Point(371, 315)
        Me.BtnPeminjaman.Name = "BtnPeminjaman"
        Me.BtnPeminjaman.Size = New System.Drawing.Size(111, 35)
        Me.BtnPeminjaman.TabIndex = 9
        Me.BtnPeminjaman.Text = "Peminjaman"
        Me.BtnPeminjaman.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPeminjaman.UseVisualStyleBackColor = True
        '
        'BtnPeminjam
        '
        Me.BtnPeminjam.Image = Global.Perpustakaan.My.Resources.Resources.user
        Me.BtnPeminjam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPeminjam.Location = New System.Drawing.Point(165, 249)
        Me.BtnPeminjam.Name = "BtnPeminjam"
        Me.BtnPeminjam.Size = New System.Drawing.Size(111, 35)
        Me.BtnPeminjam.TabIndex = 8
        Me.BtnPeminjam.Text = "Member"
        Me.BtnPeminjam.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPeminjam.UseVisualStyleBackColor = True
        '
        'BtnBuku
        '
        Me.BtnBuku.Image = Global.Perpustakaan.My.Resources.Resources.book
        Me.BtnBuku.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuku.Location = New System.Drawing.Point(371, 249)
        Me.BtnBuku.Name = "BtnBuku"
        Me.BtnBuku.Size = New System.Drawing.Size(111, 35)
        Me.BtnBuku.TabIndex = 5
        Me.BtnBuku.Text = "Buku"
        Me.BtnBuku.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuku.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Perpustakaan.My.Resources.Resources.speech_bubble
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(165, 315)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 35)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Kunjungan"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.shut_down
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(58, 481)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 32)
        Me.Button1.TabIndex = 15
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.BackColor = System.Drawing.Color.Transparent
        Me.Username.Font = New System.Drawing.Font("Freestyle Script", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.Location = New System.Drawing.Point(279, 104)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(153, 58)
        Me.Username.TabIndex = 16
        Me.Username.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Freestyle Script", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 58)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Selamat Datang"
        '
        'Button4
        '
        Me.Button4.Image = Global.Perpustakaan.My.Resources.Resources.settings
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(482, 249)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(34, 35)
        Me.Button4.TabIndex = 18
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'FrmMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.Area_Petugas
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnPeminjaman)
        Me.Controls.Add(Me.BtnPeminjam)
        Me.Controls.Add(Me.BtnBuku)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "FrmMenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Utama"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnBuku As System.Windows.Forms.Button
    Friend WithEvents BtnPeminjam As System.Windows.Forms.Button
    Friend WithEvents BtnPeminjaman As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Username As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
