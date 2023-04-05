<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPeminjam
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.KdPeminjamTxt = New System.Windows.Forms.TextBox()
        Me.NoKTPTxt = New System.Windows.Forms.TextBox()
        Me.NmPeminjamTxt = New System.Windows.Forms.TextBox()
        Me.AlmTxt = New System.Windows.Forms.TextBox()
        Me.TeleponTxt = New System.Windows.Forms.TextBox()
        Me.DGPeminjam = New System.Windows.Forms.DataGridView()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnTutup = New System.Windows.Forms.Button()
        CType(Me.DGPeminjam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(89, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Peminjam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(89, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No. KTP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(89, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Peminjam"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(89, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(89, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Telepon"
        '
        'KdPeminjamTxt
        '
        Me.KdPeminjamTxt.Location = New System.Drawing.Point(188, 141)
        Me.KdPeminjamTxt.Name = "KdPeminjamTxt"
        Me.KdPeminjamTxt.Size = New System.Drawing.Size(141, 20)
        Me.KdPeminjamTxt.TabIndex = 5
        '
        'NoKTPTxt
        '
        Me.NoKTPTxt.Location = New System.Drawing.Point(188, 167)
        Me.NoKTPTxt.Name = "NoKTPTxt"
        Me.NoKTPTxt.Size = New System.Drawing.Size(141, 20)
        Me.NoKTPTxt.TabIndex = 6
        '
        'NmPeminjamTxt
        '
        Me.NmPeminjamTxt.Location = New System.Drawing.Point(188, 193)
        Me.NmPeminjamTxt.Name = "NmPeminjamTxt"
        Me.NmPeminjamTxt.Size = New System.Drawing.Size(222, 20)
        Me.NmPeminjamTxt.TabIndex = 7
        '
        'AlmTxt
        '
        Me.AlmTxt.Location = New System.Drawing.Point(188, 219)
        Me.AlmTxt.Multiline = True
        Me.AlmTxt.Name = "AlmTxt"
        Me.AlmTxt.Size = New System.Drawing.Size(222, 60)
        Me.AlmTxt.TabIndex = 8
        '
        'TeleponTxt
        '
        Me.TeleponTxt.Location = New System.Drawing.Point(188, 285)
        Me.TeleponTxt.Name = "TeleponTxt"
        Me.TeleponTxt.Size = New System.Drawing.Size(100, 20)
        Me.TeleponTxt.TabIndex = 9
        '
        'DGPeminjam
        '
        Me.DGPeminjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPeminjam.Location = New System.Drawing.Point(92, 311)
        Me.DGPeminjam.Name = "DGPeminjam"
        Me.DGPeminjam.ReadOnly = True
        Me.DGPeminjam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGPeminjam.Size = New System.Drawing.Size(550, 196)
        Me.DGPeminjam.TabIndex = 10
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Image = Global.Perpustakaan.My.Resources.Resources.save
        Me.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSimpan.Location = New System.Drawing.Point(92, 513)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 34)
        Me.BtnSimpan.TabIndex = 11
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnUbah
        '
        Me.BtnUbah.Image = Global.Perpustakaan.My.Resources.Resources.edit
        Me.BtnUbah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUbah.Location = New System.Drawing.Point(173, 513)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(75, 34)
        Me.BtnUbah.TabIndex = 12
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUbah.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Image = Global.Perpustakaan.My.Resources.Resources.delete
        Me.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHapus.Location = New System.Drawing.Point(254, 513)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 34)
        Me.BtnHapus.TabIndex = 13
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Image = Global.Perpustakaan.My.Resources.Resources.repeat
        Me.BtnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBatal.Location = New System.Drawing.Point(335, 513)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(75, 34)
        Me.BtnBatal.TabIndex = 14
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnTutup
        '
        Me.BtnTutup.Image = Global.Perpustakaan.My.Resources.Resources.previous
        Me.BtnTutup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTutup.Location = New System.Drawing.Point(567, 513)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(75, 34)
        Me.BtnTutup.TabIndex = 15
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'FrmPeminjam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.Daf_mem
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.DGPeminjam)
        Me.Controls.Add(Me.TeleponTxt)
        Me.Controls.Add(Me.AlmTxt)
        Me.Controls.Add(Me.NmPeminjamTxt)
        Me.Controls.Add(Me.NoKTPTxt)
        Me.Controls.Add(Me.KdPeminjamTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "FrmPeminjam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Member"
        CType(Me.DGPeminjam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents KdPeminjamTxt As System.Windows.Forms.TextBox
    Friend WithEvents NoKTPTxt As System.Windows.Forms.TextBox
    Friend WithEvents NmPeminjamTxt As System.Windows.Forms.TextBox
    Friend WithEvents AlmTxt As System.Windows.Forms.TextBox
    Friend WithEvents TeleponTxt As System.Windows.Forms.TextBox
    Friend WithEvents DGPeminjam As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents BtnUbah As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents BtnTutup As System.Windows.Forms.Button
End Class
