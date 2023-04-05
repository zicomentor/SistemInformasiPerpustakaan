<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kunjungan
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
        Me.KdPeminjam = New System.Windows.Forms.TextBox()
        Me.TblKunjunganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PerpustakaanDataSet = New Perpustakaan.PerpustakaanDataSet()
        Me.NmPeminjamTxt = New System.Windows.Forms.TextBox()
        Me.TeleponTxt = New System.Windows.Forms.TextBox()
        Me.Tujuan = New System.Windows.Forms.TextBox()
        Me.Cari_id = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodePengunjungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaPengunjungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeleponDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglKunjungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TujuanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Back = New System.Windows.Forms.Button()
        Me.TblKategoriBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblKategoriTableAdapter = New Perpustakaan.PerpustakaanDataSetTableAdapters.TblKategoriTableAdapter()
        Me.TblKunjunganTableAdapter = New Perpustakaan.PerpustakaanDataSetTableAdapters.TblKunjunganTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.TblKunjunganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerpustakaanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblKategoriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KdPeminjam
        '
        Me.KdPeminjam.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblKunjunganBindingSource, "Kode_Pengunjung", True))
        Me.KdPeminjam.Enabled = False
        Me.KdPeminjam.Location = New System.Drawing.Point(102, 258)
        Me.KdPeminjam.Name = "KdPeminjam"
        Me.KdPeminjam.Size = New System.Drawing.Size(100, 20)
        Me.KdPeminjam.TabIndex = 0
        '
        'TblKunjunganBindingSource
        '
        Me.TblKunjunganBindingSource.DataMember = "TblKunjungan"
        Me.TblKunjunganBindingSource.DataSource = Me.PerpustakaanDataSet
        '
        'PerpustakaanDataSet
        '
        Me.PerpustakaanDataSet.DataSetName = "PerpustakaanDataSet"
        Me.PerpustakaanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NmPeminjamTxt
        '
        Me.NmPeminjamTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblKunjunganBindingSource, "Nama_Pengunjung", True))
        Me.NmPeminjamTxt.Location = New System.Drawing.Point(102, 302)
        Me.NmPeminjamTxt.Name = "NmPeminjamTxt"
        Me.NmPeminjamTxt.Size = New System.Drawing.Size(100, 20)
        Me.NmPeminjamTxt.TabIndex = 1
        '
        'TeleponTxt
        '
        Me.TeleponTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblKunjunganBindingSource, "Telepon", True))
        Me.TeleponTxt.Location = New System.Drawing.Point(251, 302)
        Me.TeleponTxt.Name = "TeleponTxt"
        Me.TeleponTxt.Size = New System.Drawing.Size(100, 20)
        Me.TeleponTxt.TabIndex = 2
        '
        'Tujuan
        '
        Me.Tujuan.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblKunjunganBindingSource, "Tujuan", True))
        Me.Tujuan.Location = New System.Drawing.Point(381, 256)
        Me.Tujuan.Multiline = True
        Me.Tujuan.Name = "Tujuan"
        Me.Tujuan.Size = New System.Drawing.Size(147, 76)
        Me.Tujuan.TabIndex = 5
        '
        'Cari_id
        '
        Me.Cari_id.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.search
        Me.Cari_id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cari_id.Location = New System.Drawing.Point(198, 256)
        Me.Cari_id.Name = "Cari_id"
        Me.Cari_id.Size = New System.Drawing.Size(24, 24)
        Me.Cari_id.TabIndex = 6
        Me.Cari_id.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Enabled = False
        Me.Save.Image = Global.Perpustakaan.My.Resources.Resources._next
        Me.Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Save.Location = New System.Drawing.Point(559, 251)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(111, 35)
        Me.Save.TabIndex = 7
        Me.Save.Text = "Save"
        Me.Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Save.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoDataGridViewTextBoxColumn, Me.KodePengunjungDataGridViewTextBoxColumn, Me.NamaPengunjungDataGridViewTextBoxColumn, Me.TeleponDataGridViewTextBoxColumn, Me.TglKunjungDataGridViewTextBoxColumn, Me.TujuanDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblKunjunganBindingSource
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.Location = New System.Drawing.Point(85, 346)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(603, 190)
        Me.DataGridView1.TabIndex = 8
        '
        'NoDataGridViewTextBoxColumn
        '
        Me.NoDataGridViewTextBoxColumn.DataPropertyName = "No"
        Me.NoDataGridViewTextBoxColumn.FillWeight = 30.0!
        Me.NoDataGridViewTextBoxColumn.HeaderText = "No"
        Me.NoDataGridViewTextBoxColumn.MaxInputLength = 4
        Me.NoDataGridViewTextBoxColumn.Name = "NoDataGridViewTextBoxColumn"
        Me.NoDataGridViewTextBoxColumn.Width = 30
        '
        'KodePengunjungDataGridViewTextBoxColumn
        '
        Me.KodePengunjungDataGridViewTextBoxColumn.DataPropertyName = "Kode_Pengunjung"
        Me.KodePengunjungDataGridViewTextBoxColumn.FillWeight = 80.0!
        Me.KodePengunjungDataGridViewTextBoxColumn.HeaderText = "Kode Member"
        Me.KodePengunjungDataGridViewTextBoxColumn.MaxInputLength = 26
        Me.KodePengunjungDataGridViewTextBoxColumn.MinimumWidth = 3
        Me.KodePengunjungDataGridViewTextBoxColumn.Name = "KodePengunjungDataGridViewTextBoxColumn"
        Me.KodePengunjungDataGridViewTextBoxColumn.Visible = False
        Me.KodePengunjungDataGridViewTextBoxColumn.Width = 80
        '
        'NamaPengunjungDataGridViewTextBoxColumn
        '
        Me.NamaPengunjungDataGridViewTextBoxColumn.DataPropertyName = "Nama_Pengunjung"
        Me.NamaPengunjungDataGridViewTextBoxColumn.FillWeight = 180.0!
        Me.NamaPengunjungDataGridViewTextBoxColumn.HeaderText = "Nama Pengunjung"
        Me.NamaPengunjungDataGridViewTextBoxColumn.MaxInputLength = 30
        Me.NamaPengunjungDataGridViewTextBoxColumn.MinimumWidth = 3
        Me.NamaPengunjungDataGridViewTextBoxColumn.Name = "NamaPengunjungDataGridViewTextBoxColumn"
        Me.NamaPengunjungDataGridViewTextBoxColumn.Width = 180
        '
        'TeleponDataGridViewTextBoxColumn
        '
        Me.TeleponDataGridViewTextBoxColumn.DataPropertyName = "Telepon"
        Me.TeleponDataGridViewTextBoxColumn.HeaderText = "Telepon"
        Me.TeleponDataGridViewTextBoxColumn.Name = "TeleponDataGridViewTextBoxColumn"
        Me.TeleponDataGridViewTextBoxColumn.Visible = False
        '
        'TglKunjungDataGridViewTextBoxColumn
        '
        Me.TglKunjungDataGridViewTextBoxColumn.DataPropertyName = "Tgl_Kunjung"
        Me.TglKunjungDataGridViewTextBoxColumn.HeaderText = "Tanggal Kunjung"
        Me.TglKunjungDataGridViewTextBoxColumn.Name = "TglKunjungDataGridViewTextBoxColumn"
        '
        'TujuanDataGridViewTextBoxColumn
        '
        Me.TujuanDataGridViewTextBoxColumn.DataPropertyName = "Tujuan"
        Me.TujuanDataGridViewTextBoxColumn.FillWeight = 250.0!
        Me.TujuanDataGridViewTextBoxColumn.HeaderText = "Tujuan"
        Me.TujuanDataGridViewTextBoxColumn.Name = "TujuanDataGridViewTextBoxColumn"
        Me.TujuanDataGridViewTextBoxColumn.Width = 250
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(103, 242)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "ID Member"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(103, 286)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(255, 286)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Nomer Telp."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(255, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Tanggal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(384, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Tujuan"
        '
        'Back
        '
        Me.Back.Image = Global.Perpustakaan.My.Resources.Resources.previous
        Me.Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Back.Location = New System.Drawing.Point(559, 294)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(111, 35)
        Me.Back.TabIndex = 15
        Me.Back.Text = "Kembali"
        Me.Back.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Back.UseVisualStyleBackColor = True
        '
        'TblKategoriBindingSource
        '
        Me.TblKategoriBindingSource.DataMember = "TblKategori"
        Me.TblKategoriBindingSource.DataSource = Me.PerpustakaanDataSet
        '
        'TblKategoriTableAdapter
        '
        Me.TblKategoriTableAdapter.ClearBeforeFill = True
        '
        'TblKunjunganTableAdapter
        '
        Me.TblKunjunganTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblKunjunganBindingSource, "Tgl_Kunjung", True))
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(251, 259)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 16
        Me.TextBox1.Text = "Tanggal"
        '
        'Kunjungan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.ruang_bacaperpus
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Cari_id)
        Me.Controls.Add(Me.Tujuan)
        Me.Controls.Add(Me.TeleponTxt)
        Me.Controls.Add(Me.NmPeminjamTxt)
        Me.Controls.Add(Me.KdPeminjam)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "Kunjungan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selamat Datang"
        CType(Me.TblKunjunganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerpustakaanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblKategoriBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KdPeminjam As System.Windows.Forms.TextBox
    Friend WithEvents NmPeminjamTxt As System.Windows.Forms.TextBox
    Friend WithEvents TeleponTxt As System.Windows.Forms.TextBox
    Friend WithEvents Tujuan As System.Windows.Forms.TextBox
    Friend WithEvents Cari_id As System.Windows.Forms.Button
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PerpustakaanDataSet As Perpustakaan.PerpustakaanDataSet
    Friend WithEvents TblKategoriBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblKategoriTableAdapter As Perpustakaan.PerpustakaanDataSetTableAdapters.TblKategoriTableAdapter
    Friend WithEvents TblKunjunganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblKunjunganTableAdapter As Perpustakaan.PerpustakaanDataSetTableAdapters.TblKunjunganTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents NoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodePengunjungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaPengunjungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TeleponDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TglKunjungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TujuanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
