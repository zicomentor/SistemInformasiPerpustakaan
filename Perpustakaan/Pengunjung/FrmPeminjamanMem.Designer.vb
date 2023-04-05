<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPeminjamanMem
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
        Me.PerpustakaanDataSet = New Perpustakaan.PerpustakaanDataSet()
        Me.TblKunjunganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblKunjunganTableAdapter = New Perpustakaan.PerpustakaanDataSetTableAdapters.TblKunjunganTableAdapter()
        Me.TblPeminjamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblPeminjamTableAdapter = New Perpustakaan.PerpustakaanDataSetTableAdapters.TblPeminjamTableAdapter()
        Me.QryPeminjamanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QryPeminjamanTableAdapter = New Perpustakaan.PerpustakaanDataSetTableAdapters.QryPeminjamanTableAdapter()
        Me.QryPeminjamanBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DGPeminjaman = New System.Windows.Forms.DataGridView()
        CType(Me.PerpustakaanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblKunjunganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPeminjamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QryPeminjamanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QryPeminjamanBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGPeminjaman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PerpustakaanDataSet
        '
        Me.PerpustakaanDataSet.DataSetName = "PerpustakaanDataSet"
        Me.PerpustakaanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblKunjunganBindingSource
        '
        Me.TblKunjunganBindingSource.DataMember = "TblKunjungan"
        Me.TblKunjunganBindingSource.DataSource = Me.PerpustakaanDataSet
        '
        'TblKunjunganTableAdapter
        '
        Me.TblKunjunganTableAdapter.ClearBeforeFill = True
        '
        'TblPeminjamBindingSource
        '
        Me.TblPeminjamBindingSource.DataMember = "TblPeminjam"
        Me.TblPeminjamBindingSource.DataSource = Me.PerpustakaanDataSet
        '
        'TblPeminjamTableAdapter
        '
        Me.TblPeminjamTableAdapter.ClearBeforeFill = True
        '
        'QryPeminjamanBindingSource
        '
        Me.QryPeminjamanBindingSource.DataMember = "QryPeminjaman"
        Me.QryPeminjamanBindingSource.DataSource = Me.PerpustakaanDataSet
        '
        'QryPeminjamanTableAdapter
        '
        Me.QryPeminjamanTableAdapter.ClearBeforeFill = True
        '
        'QryPeminjamanBindingSource1
        '
        Me.QryPeminjamanBindingSource1.DataMember = "QryPeminjaman"
        Me.QryPeminjamanBindingSource1.DataSource = Me.PerpustakaanDataSet
        '
        'Button1
        '
        Me.Button1.Image = Global.Perpustakaan.My.Resources.Resources.previous
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(51, 186)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 34)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Kembali"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DGPeminjaman
        '
        Me.DGPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPeminjaman.Location = New System.Drawing.Point(31, 238)
        Me.DGPeminjaman.Name = "DGPeminjaman"
        Me.DGPeminjaman.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGPeminjaman.Size = New System.Drawing.Size(724, 311)
        Me.DGPeminjaman.TabIndex = 35
        '
        'FrmPeminjamanMem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.peminjaman
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.DGPeminjaman)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "FrmPeminjamanMem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Peminjaman"
        CType(Me.PerpustakaanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblKunjunganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPeminjamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QryPeminjamanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QryPeminjamanBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGPeminjaman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PerpustakaanDataSet As Perpustakaan.PerpustakaanDataSet
    Friend WithEvents TblKunjunganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblKunjunganTableAdapter As Perpustakaan.PerpustakaanDataSetTableAdapters.TblKunjunganTableAdapter
    Friend WithEvents TblPeminjamBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPeminjamTableAdapter As Perpustakaan.PerpustakaanDataSetTableAdapters.TblPeminjamTableAdapter
    Friend WithEvents QryPeminjamanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QryPeminjamanTableAdapter As Perpustakaan.PerpustakaanDataSetTableAdapters.QryPeminjamanTableAdapter
    Friend WithEvents QryPeminjamanBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DGPeminjaman As System.Windows.Forms.DataGridView
End Class
