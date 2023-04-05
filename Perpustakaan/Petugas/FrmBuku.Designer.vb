<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuku
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
        Me.KdBukuTxt = New System.Windows.Forms.TextBox()
        Me.JdBukuTxt = New System.Windows.Forms.TextBox()
        Me.StockTxt = New System.Windows.Forms.TextBox()
        Me.FotoTxt = New System.Windows.Forms.TextBox()
        Me.KategoriCmb = New System.Windows.Forms.ComboBox()
        Me.RakCmb = New System.Windows.Forms.ComboBox()
        Me.OFDFoto = New System.Windows.Forms.OpenFileDialog()
        Me.DGBuku = New System.Windows.Forms.DataGridView()
        Me.BtnHapusFoto = New System.Windows.Forms.Button()
        Me.BtnAmbilFoto = New System.Windows.Forms.Button()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.FotoPic = New System.Windows.Forms.PictureBox()
        CType(Me.DGBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FotoPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(57, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Buku"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(57, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Judul Buku"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(57, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kategori"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(57, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Rak"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(57, 292)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Stock"
        '
        'KdBukuTxt
        '
        Me.KdBukuTxt.Location = New System.Drawing.Point(135, 183)
        Me.KdBukuTxt.Name = "KdBukuTxt"
        Me.KdBukuTxt.Size = New System.Drawing.Size(151, 20)
        Me.KdBukuTxt.TabIndex = 5
        '
        'JdBukuTxt
        '
        Me.JdBukuTxt.Location = New System.Drawing.Point(135, 209)
        Me.JdBukuTxt.Name = "JdBukuTxt"
        Me.JdBukuTxt.Size = New System.Drawing.Size(304, 20)
        Me.JdBukuTxt.TabIndex = 6
        '
        'StockTxt
        '
        Me.StockTxt.Location = New System.Drawing.Point(135, 289)
        Me.StockTxt.Name = "StockTxt"
        Me.StockTxt.Size = New System.Drawing.Size(91, 20)
        Me.StockTxt.TabIndex = 7
        '
        'FotoTxt
        '
        Me.FotoTxt.Location = New System.Drawing.Point(474, 279)
        Me.FotoTxt.Name = "FotoTxt"
        Me.FotoTxt.Size = New System.Drawing.Size(69, 20)
        Me.FotoTxt.TabIndex = 8
        Me.FotoTxt.Visible = False
        '
        'KategoriCmb
        '
        Me.KategoriCmb.FormattingEnabled = True
        Me.KategoriCmb.Location = New System.Drawing.Point(135, 235)
        Me.KategoriCmb.Name = "KategoriCmb"
        Me.KategoriCmb.Size = New System.Drawing.Size(151, 21)
        Me.KategoriCmb.TabIndex = 9
        '
        'RakCmb
        '
        Me.RakCmb.FormattingEnabled = True
        Me.RakCmb.Location = New System.Drawing.Point(135, 262)
        Me.RakCmb.Name = "RakCmb"
        Me.RakCmb.Size = New System.Drawing.Size(151, 21)
        Me.RakCmb.TabIndex = 10
        '
        'DGBuku
        '
        Me.DGBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBuku.Location = New System.Drawing.Point(60, 321)
        Me.DGBuku.Name = "DGBuku"
        Me.DGBuku.ReadOnly = True
        Me.DGBuku.RowHeadersVisible = False
        Me.DGBuku.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGBuku.Size = New System.Drawing.Size(558, 199)
        Me.DGBuku.TabIndex = 19
        '
        'BtnHapusFoto
        '
        Me.BtnHapusFoto.Image = Global.Perpustakaan.My.Resources.Resources.block
        Me.BtnHapusFoto.Location = New System.Drawing.Point(586, 224)
        Me.BtnHapusFoto.Name = "BtnHapusFoto"
        Me.BtnHapusFoto.Size = New System.Drawing.Size(33, 35)
        Me.BtnHapusFoto.TabIndex = 18
        Me.BtnHapusFoto.UseVisualStyleBackColor = True
        '
        'BtnAmbilFoto
        '
        Me.BtnAmbilFoto.Image = Global.Perpustakaan.My.Resources.Resources.photo
        Me.BtnAmbilFoto.Location = New System.Drawing.Point(586, 183)
        Me.BtnAmbilFoto.Name = "BtnAmbilFoto"
        Me.BtnAmbilFoto.Size = New System.Drawing.Size(33, 35)
        Me.BtnAmbilFoto.TabIndex = 17
        Me.BtnAmbilFoto.UseVisualStyleBackColor = True
        '
        'BtnTutup
        '
        Me.BtnTutup.Image = Global.Perpustakaan.My.Resources.Resources.previous
        Me.BtnTutup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTutup.Location = New System.Drawing.Point(657, 487)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(74, 33)
        Me.BtnTutup.TabIndex = 16
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Image = Global.Perpustakaan.My.Resources.Resources.repeat
        Me.BtnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBatal.Location = New System.Drawing.Point(657, 321)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(74, 33)
        Me.BtnBatal.TabIndex = 15
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Image = Global.Perpustakaan.My.Resources.Resources.delete
        Me.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHapus.Location = New System.Drawing.Point(657, 356)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(74, 33)
        Me.BtnHapus.TabIndex = 14
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnUbah
        '
        Me.BtnUbah.Image = Global.Perpustakaan.My.Resources.Resources.edit
        Me.BtnUbah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUbah.Location = New System.Drawing.Point(657, 390)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(74, 33)
        Me.BtnUbah.TabIndex = 13
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUbah.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Image = Global.Perpustakaan.My.Resources.Resources.save
        Me.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSimpan.Location = New System.Drawing.Point(657, 425)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(74, 33)
        Me.BtnSimpan.TabIndex = 12
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'FotoPic
        '
        Me.FotoPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FotoPic.Location = New System.Drawing.Point(457, 183)
        Me.FotoPic.Name = "FotoPic"
        Me.FotoPic.Size = New System.Drawing.Size(123, 126)
        Me.FotoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FotoPic.TabIndex = 11
        Me.FotoPic.TabStop = False
        '
        'FrmBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.Dir_bookk
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.DGBuku)
        Me.Controls.Add(Me.BtnHapusFoto)
        Me.Controls.Add(Me.BtnAmbilFoto)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.RakCmb)
        Me.Controls.Add(Me.KategoriCmb)
        Me.Controls.Add(Me.FotoTxt)
        Me.Controls.Add(Me.StockTxt)
        Me.Controls.Add(Me.JdBukuTxt)
        Me.Controls.Add(Me.KdBukuTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FotoPic)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "FrmBuku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buku"
        CType(Me.DGBuku, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FotoPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents KdBukuTxt As System.Windows.Forms.TextBox
    Friend WithEvents JdBukuTxt As System.Windows.Forms.TextBox
    Friend WithEvents StockTxt As System.Windows.Forms.TextBox
    Friend WithEvents FotoTxt As System.Windows.Forms.TextBox
    Friend WithEvents KategoriCmb As System.Windows.Forms.ComboBox
    Friend WithEvents RakCmb As System.Windows.Forms.ComboBox
    Friend WithEvents FotoPic As System.Windows.Forms.PictureBox
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents BtnUbah As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents BtnTutup As System.Windows.Forms.Button
    Friend WithEvents BtnAmbilFoto As System.Windows.Forms.Button
    Friend WithEvents BtnHapusFoto As System.Windows.Forms.Button
    Friend WithEvents OFDFoto As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DGBuku As System.Windows.Forms.DataGridView

End Class
