<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDataPeminjaman
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
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.DGPeminjaman = New System.Windows.Forms.DataGridView()
        Me.BtnPeminjaman = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TblPeminjamanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PerpustakaanDataSet = New Perpustakaan.PerpustakaanDataSet()
        Me.TblPeminjamanTableAdapter = New Perpustakaan.PerpustakaanDataSetTableAdapters.TblPeminjamanTableAdapter()
        Me.NoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoPeminjamanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodeBukuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodePeminjamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglPinjamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglKembaliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LamaPinjamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGPeminjaman, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPeminjamanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerpustakaanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnUbah
        '
        Me.BtnUbah.Image = Global.Perpustakaan.My.Resources.Resources.edit
        Me.BtnUbah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUbah.Location = New System.Drawing.Point(389, 496)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(75, 35)
        Me.BtnUbah.TabIndex = 1
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUbah.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Image = Global.Perpustakaan.My.Resources.Resources.delete
        Me.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHapus.Location = New System.Drawing.Point(470, 496)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 35)
        Me.BtnHapus.TabIndex = 2
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Image = Global.Perpustakaan.My.Resources.Resources.repeat
        Me.BtnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBatal.Location = New System.Drawing.Point(551, 496)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(75, 35)
        Me.BtnBatal.TabIndex = 3
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnTutup
        '
        Me.BtnTutup.Image = Global.Perpustakaan.My.Resources.Resources.previous
        Me.BtnTutup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTutup.Location = New System.Drawing.Point(681, 496)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(75, 35)
        Me.BtnTutup.TabIndex = 4
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'DGPeminjaman
        '
        Me.DGPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPeminjaman.Location = New System.Drawing.Point(32, 159)
        Me.DGPeminjaman.Name = "DGPeminjaman"
        Me.DGPeminjaman.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGPeminjaman.Size = New System.Drawing.Size(724, 331)
        Me.DGPeminjaman.TabIndex = 5
        '
        'BtnPeminjaman
        '
        Me.BtnPeminjaman.Image = Global.Perpustakaan.My.Resources.Resources.Log_out
        Me.BtnPeminjaman.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPeminjaman.Location = New System.Drawing.Point(31, 496)
        Me.BtnPeminjaman.Name = "BtnPeminjaman"
        Me.BtnPeminjaman.Size = New System.Drawing.Size(151, 35)
        Me.BtnPeminjaman.TabIndex = 0
        Me.BtnPeminjaman.Text = "Transaksi Peminjaman"
        Me.BtnPeminjaman.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPeminjaman.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.Perpustakaan.My.Resources.Resources.zoom_in
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(188, 496)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 35)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Transaksi Pengembalian"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoDataGridViewTextBoxColumn, Me.NoPeminjamanDataGridViewTextBoxColumn, Me.KodeBukuDataGridViewTextBoxColumn, Me.KodePeminjamDataGridViewTextBoxColumn, Me.TglPinjamDataGridViewTextBoxColumn, Me.TglKembaliDataGridViewTextBoxColumn, Me.LamaPinjamDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblPeminjamanBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(32, 159)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(724, 331)
        Me.DataGridView1.TabIndex = 7
        '
        'TblPeminjamanBindingSource
        '
        Me.TblPeminjamanBindingSource.DataMember = "TblPeminjaman"
        Me.TblPeminjamanBindingSource.DataSource = Me.PerpustakaanDataSet
        '
        'PerpustakaanDataSet
        '
        Me.PerpustakaanDataSet.DataSetName = "PerpustakaanDataSet"
        Me.PerpustakaanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblPeminjamanTableAdapter
        '
        Me.TblPeminjamanTableAdapter.ClearBeforeFill = True
        '
        'NoDataGridViewTextBoxColumn
        '
        Me.NoDataGridViewTextBoxColumn.DataPropertyName = "No"
        Me.NoDataGridViewTextBoxColumn.FillWeight = 30.0!
        Me.NoDataGridViewTextBoxColumn.HeaderText = "No"
        Me.NoDataGridViewTextBoxColumn.Name = "NoDataGridViewTextBoxColumn"
        Me.NoDataGridViewTextBoxColumn.Width = 30
        '
        'NoPeminjamanDataGridViewTextBoxColumn
        '
        Me.NoPeminjamanDataGridViewTextBoxColumn.DataPropertyName = "No_Peminjaman"
        Me.NoPeminjamanDataGridViewTextBoxColumn.HeaderText = "No Peminjaman"
        Me.NoPeminjamanDataGridViewTextBoxColumn.Name = "NoPeminjamanDataGridViewTextBoxColumn"
        '
        'KodeBukuDataGridViewTextBoxColumn
        '
        Me.KodeBukuDataGridViewTextBoxColumn.DataPropertyName = "Kode_Buku"
        Me.KodeBukuDataGridViewTextBoxColumn.HeaderText = "Kode Buku"
        Me.KodeBukuDataGridViewTextBoxColumn.Name = "KodeBukuDataGridViewTextBoxColumn"
        '
        'KodePeminjamDataGridViewTextBoxColumn
        '
        Me.KodePeminjamDataGridViewTextBoxColumn.DataPropertyName = "Kode_Peminjam"
        Me.KodePeminjamDataGridViewTextBoxColumn.HeaderText = "Kode Peminjam"
        Me.KodePeminjamDataGridViewTextBoxColumn.Name = "KodePeminjamDataGridViewTextBoxColumn"
        '
        'TglPinjamDataGridViewTextBoxColumn
        '
        Me.TglPinjamDataGridViewTextBoxColumn.DataPropertyName = "Tgl_Pinjam"
        Me.TglPinjamDataGridViewTextBoxColumn.HeaderText = "Tgl Pinjam"
        Me.TglPinjamDataGridViewTextBoxColumn.Name = "TglPinjamDataGridViewTextBoxColumn"
        '
        'TglKembaliDataGridViewTextBoxColumn
        '
        Me.TglKembaliDataGridViewTextBoxColumn.DataPropertyName = "Tgl_Kembali"
        Me.TglKembaliDataGridViewTextBoxColumn.HeaderText = "Tgl Kembali"
        Me.TglKembaliDataGridViewTextBoxColumn.Name = "TglKembaliDataGridViewTextBoxColumn"
        '
        'LamaPinjamDataGridViewTextBoxColumn
        '
        Me.LamaPinjamDataGridViewTextBoxColumn.DataPropertyName = "Lama_Pinjam"
        Me.LamaPinjamDataGridViewTextBoxColumn.HeaderText = "Lama Pinjam"
        Me.LamaPinjamDataGridViewTextBoxColumn.Name = "LamaPinjamDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'FrmDataPeminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.peminjaman
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DGPeminjaman)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.BtnPeminjaman)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "FrmDataPeminjaman"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Peminjaman"
        CType(Me.DGPeminjaman, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPeminjamanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerpustakaanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnPeminjaman As System.Windows.Forms.Button
    Friend WithEvents BtnUbah As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents BtnTutup As System.Windows.Forms.Button
    Friend WithEvents DGPeminjaman As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PerpustakaanDataSet As Perpustakaan.PerpustakaanDataSet
    Friend WithEvents TblPeminjamanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPeminjamanTableAdapter As Perpustakaan.PerpustakaanDataSetTableAdapters.TblPeminjamanTableAdapter
    Friend WithEvents NoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoPeminjamanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodeBukuDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodePeminjamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TglPinjamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TglKembaliDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LamaPinjamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
