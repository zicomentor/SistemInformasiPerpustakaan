<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmKunjungan
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodePengunjungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaPengunjungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeleponDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglKunjungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TujuanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblKunjunganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PerpustakaanDataSet = New Perpustakaan.PerpustakaanDataSet()
        Me.TblKunjunganTableAdapter = New Perpustakaan.PerpustakaanDataSetTableAdapters.TblKunjunganTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblKunjunganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerpustakaanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoDataGridViewTextBoxColumn, Me.KodePengunjungDataGridViewTextBoxColumn, Me.NamaPengunjungDataGridViewTextBoxColumn, Me.TeleponDataGridViewTextBoxColumn, Me.TglKunjungDataGridViewTextBoxColumn, Me.TujuanDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblKunjunganBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(31, 238)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(724, 311)
        Me.DataGridView1.TabIndex = 0
        '
        'NoDataGridViewTextBoxColumn
        '
        Me.NoDataGridViewTextBoxColumn.DataPropertyName = "No"
        Me.NoDataGridViewTextBoxColumn.FillWeight = 30.0!
        Me.NoDataGridViewTextBoxColumn.HeaderText = "No."
        Me.NoDataGridViewTextBoxColumn.Name = "NoDataGridViewTextBoxColumn"
        Me.NoDataGridViewTextBoxColumn.Width = 30
        '
        'KodePengunjungDataGridViewTextBoxColumn
        '
        Me.KodePengunjungDataGridViewTextBoxColumn.DataPropertyName = "Kode_Pengunjung"
        Me.KodePengunjungDataGridViewTextBoxColumn.HeaderText = "Kode Pengunjung"
        Me.KodePengunjungDataGridViewTextBoxColumn.Name = "KodePengunjungDataGridViewTextBoxColumn"
        '
        'NamaPengunjungDataGridViewTextBoxColumn
        '
        Me.NamaPengunjungDataGridViewTextBoxColumn.DataPropertyName = "Nama_Pengunjung"
        Me.NamaPengunjungDataGridViewTextBoxColumn.FillWeight = 150.0!
        Me.NamaPengunjungDataGridViewTextBoxColumn.HeaderText = "Nama Pengunjung"
        Me.NamaPengunjungDataGridViewTextBoxColumn.Name = "NamaPengunjungDataGridViewTextBoxColumn"
        Me.NamaPengunjungDataGridViewTextBoxColumn.Width = 150
        '
        'TeleponDataGridViewTextBoxColumn
        '
        Me.TeleponDataGridViewTextBoxColumn.DataPropertyName = "Telepon"
        Me.TeleponDataGridViewTextBoxColumn.HeaderText = "Telepon"
        Me.TeleponDataGridViewTextBoxColumn.Name = "TeleponDataGridViewTextBoxColumn"
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
        Me.TujuanDataGridViewTextBoxColumn.FillWeight = 300.0!
        Me.TujuanDataGridViewTextBoxColumn.HeaderText = "Tujuan"
        Me.TujuanDataGridViewTextBoxColumn.Name = "TujuanDataGridViewTextBoxColumn"
        Me.TujuanDataGridViewTextBoxColumn.Width = 300
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
        'TblKunjunganTableAdapter
        '
        Me.TblKunjunganTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Image = Global.Perpustakaan.My.Resources.Resources.previous
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(51, 186)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 34)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Kembali"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Perpustakaan.My.Resources.Resources.delete
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(142, 186)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 34)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Hapus"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmKunjungan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.Kun
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "FrmKunjungan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kunjungan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblKunjunganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerpustakaanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PerpustakaanDataSet As Perpustakaan.PerpustakaanDataSet
    Friend WithEvents TblKunjunganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblKunjunganTableAdapter As Perpustakaan.PerpustakaanDataSetTableAdapters.TblKunjunganTableAdapter
    Friend WithEvents NoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodePengunjungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaPengunjungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TeleponDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TglKunjungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TujuanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
