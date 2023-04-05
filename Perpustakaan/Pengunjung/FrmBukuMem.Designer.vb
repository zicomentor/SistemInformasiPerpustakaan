<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBukuMem
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBukuMem))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.KodeBukuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KategoriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RakDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FotoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblBukuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PerpustakaanDataSet = New Perpustakaan.PerpustakaanDataSet()
        Me.TblBukuTableAdapter = New Perpustakaan.PerpustakaanDataSetTableAdapters.TblBukuTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cari_kode = New System.Windows.Forms.Button()
        Me.Rak = New System.Windows.Forms.TextBox()
        Me.Judul_buku = New System.Windows.Forms.TextBox()
        Me.Kode_buku = New System.Windows.Forms.TextBox()
        Me.Kategori = New System.Windows.Forms.TextBox()
        Me.Stock = New System.Windows.Forms.TextBox()
        Me.FotoPic = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBukuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerpustakaanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FotoPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeBukuDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.KategoriDataGridViewTextBoxColumn, Me.RakDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn, Me.FotoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblBukuBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(49, 238)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(544, 311)
        Me.DataGridView1.TabIndex = 0
        '
        'KodeBukuDataGridViewTextBoxColumn
        '
        Me.KodeBukuDataGridViewTextBoxColumn.DataPropertyName = "Kode_Buku"
        Me.KodeBukuDataGridViewTextBoxColumn.HeaderText = "Kode Buku"
        Me.KodeBukuDataGridViewTextBoxColumn.Name = "KodeBukuDataGridViewTextBoxColumn"
        Me.KodeBukuDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Judul_Buku"
        Me.DataGridViewTextBoxColumn1.FillWeight = 200.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Judul Buku"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'KategoriDataGridViewTextBoxColumn
        '
        Me.KategoriDataGridViewTextBoxColumn.DataPropertyName = "Kategori"
        Me.KategoriDataGridViewTextBoxColumn.HeaderText = "Kategori"
        Me.KategoriDataGridViewTextBoxColumn.Name = "KategoriDataGridViewTextBoxColumn"
        Me.KategoriDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RakDataGridViewTextBoxColumn
        '
        Me.RakDataGridViewTextBoxColumn.DataPropertyName = "Rak"
        Me.RakDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.RakDataGridViewTextBoxColumn.HeaderText = "Rak"
        Me.RakDataGridViewTextBoxColumn.Name = "RakDataGridViewTextBoxColumn"
        Me.RakDataGridViewTextBoxColumn.ReadOnly = True
        Me.RakDataGridViewTextBoxColumn.Width = 50
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "Stock"
        Me.StockDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        Me.StockDataGridViewTextBoxColumn.ReadOnly = True
        Me.StockDataGridViewTextBoxColumn.Width = 50
        '
        'FotoDataGridViewTextBoxColumn
        '
        Me.FotoDataGridViewTextBoxColumn.DataPropertyName = "Foto"
        Me.FotoDataGridViewTextBoxColumn.HeaderText = "Foto"
        Me.FotoDataGridViewTextBoxColumn.Name = "FotoDataGridViewTextBoxColumn"
        Me.FotoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FotoDataGridViewTextBoxColumn.Visible = False
        '
        'TblBukuBindingSource
        '
        Me.TblBukuBindingSource.DataMember = "TblBuku"
        Me.TblBukuBindingSource.DataSource = Me.PerpustakaanDataSet
        '
        'PerpustakaanDataSet
        '
        Me.PerpustakaanDataSet.DataSetName = "PerpustakaanDataSet"
        Me.PerpustakaanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblBukuTableAdapter
        '
        Me.TblBukuTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(639, 324)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Kategori"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(639, 365)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Rak"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(636, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Cari Kode Buku"
        '
        'Cari_kode
        '
        Me.Cari_kode.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.book
        Me.Cari_kode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cari_kode.Location = New System.Drawing.Point(731, 252)
        Me.Cari_kode.Name = "Cari_kode"
        Me.Cari_kode.Size = New System.Drawing.Size(24, 24)
        Me.Cari_kode.TabIndex = 17
        Me.Cari_kode.UseVisualStyleBackColor = True
        '
        'Rak
        '
        Me.Rak.Enabled = False
        Me.Rak.Location = New System.Drawing.Point(635, 381)
        Me.Rak.Name = "Rak"
        Me.Rak.Size = New System.Drawing.Size(50, 20)
        Me.Rak.TabIndex = 16
        '
        'Judul_buku
        '
        Me.Judul_buku.Enabled = False
        Me.Judul_buku.Location = New System.Drawing.Point(635, 298)
        Me.Judul_buku.Name = "Judul_buku"
        Me.Judul_buku.Size = New System.Drawing.Size(100, 20)
        Me.Judul_buku.TabIndex = 15
        '
        'Kode_buku
        '
        Me.Kode_buku.Enabled = False
        Me.Kode_buku.Location = New System.Drawing.Point(635, 254)
        Me.Kode_buku.Name = "Kode_buku"
        Me.Kode_buku.Size = New System.Drawing.Size(100, 20)
        Me.Kode_buku.TabIndex = 14
        '
        'Kategori
        '
        Me.Kategori.Enabled = False
        Me.Kategori.Location = New System.Drawing.Point(635, 342)
        Me.Kategori.Name = "Kategori"
        Me.Kategori.Size = New System.Drawing.Size(100, 20)
        Me.Kategori.TabIndex = 24
        '
        'Stock
        '
        Me.Stock.Enabled = False
        Me.Stock.Location = New System.Drawing.Point(685, 381)
        Me.Stock.Name = "Stock"
        Me.Stock.Size = New System.Drawing.Size(50, 20)
        Me.Stock.TabIndex = 25
        '
        'FotoPic
        '
        Me.FotoPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FotoPic.Enabled = False
        Me.FotoPic.Location = New System.Drawing.Point(635, 416)
        Me.FotoPic.Name = "FotoPic"
        Me.FotoPic.Size = New System.Drawing.Size(111, 133)
        Me.FotoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FotoPic.TabIndex = 31
        Me.FotoPic.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(687, 366)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Stock"
        '
        'Button1
        '
        Me.Button1.Image = Global.Perpustakaan.My.Resources.Resources.previous
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(49, 186)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 34)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Kembali"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(278, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Cari Judul Buku"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(375, 195)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 24)
        Me.Button2.TabIndex = 35
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(277, 198)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(433, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Cari Kategori Buku"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(529, 198)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 24)
        Me.Button3.TabIndex = 38
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(431, 200)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(639, 280)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Judul"
        '
        'FrmBukuMem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.Dir_bookk
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.FotoPic)
        Me.Controls.Add(Me.Stock)
        Me.Controls.Add(Me.Kategori)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cari_kode)
        Me.Controls.Add(Me.Rak)
        Me.Controls.Add(Me.Judul_buku)
        Me.Controls.Add(Me.Kode_buku)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "FrmBukuMem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buku"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBukuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerpustakaanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FotoPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PerpustakaanDataSet As Perpustakaan.PerpustakaanDataSet
    Friend WithEvents TblBukuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblBukuTableAdapter As Perpustakaan.PerpustakaanDataSetTableAdapters.TblBukuTableAdapter
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cari_kode As System.Windows.Forms.Button
    Friend WithEvents Rak As System.Windows.Forms.TextBox
    Friend WithEvents Judul_buku As System.Windows.Forms.TextBox
    Friend WithEvents Kode_buku As System.Windows.Forms.TextBox
    Friend WithEvents Kategori As System.Windows.Forms.TextBox
    Friend WithEvents Stock As System.Windows.Forms.TextBox
    Friend WithEvents FotoPic As System.Windows.Forms.PictureBox
    Friend WithEvents JudulBukuDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents KodeBukuDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KategoriDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RakDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FotoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
