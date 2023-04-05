<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPeminjaman
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPeminjaman))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.NoPeminjamanTxt = New System.Windows.Forms.TextBox()
        Me.KdBukuTxt = New System.Windows.Forms.TextBox()
        Me.JdBukuTxt = New System.Windows.Forms.TextBox()
        Me.KategoriTxt = New System.Windows.Forms.TextBox()
        Me.RakTxt = New System.Windows.Forms.TextBox()
        Me.KdPeminjam = New System.Windows.Forms.TextBox()
        Me.NoKtpTxt = New System.Windows.Forms.TextBox()
        Me.NmPeminjamTxt = New System.Windows.Forms.TextBox()
        Me.AlmTxt = New System.Windows.Forms.TextBox()
        Me.TeleponTxt = New System.Windows.Forms.TextBox()
        Me.LamaTxt = New System.Windows.Forms.TextBox()
        Me.KdPeminjamBtn = New System.Windows.Forms.Button()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.TglPinjamDP = New System.Windows.Forms.DateTimePicker()
        Me.TglKembaliDP = New System.Windows.Forms.DateTimePicker()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.KdBukuBtn = New System.Windows.Forms.Button()
        Me.FotoPic = New System.Windows.Forms.PictureBox()
        CType(Me.FotoPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Peminjaman"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Buku"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Judul Buku"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Kategori"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Rak"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Kode Peminjam"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "No. KTP"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 212)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Nama Peminjam"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 236)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Alamat"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 260)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Telepon"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 305)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Tgl Pinjam"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 331)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Tgl Kembali"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 354)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Lama Pinjam (Hari)"
        '
        'NoPeminjamanTxt
        '
        Me.NoPeminjamanTxt.Location = New System.Drawing.Point(120, 11)
        Me.NoPeminjamanTxt.Name = "NoPeminjamanTxt"
        Me.NoPeminjamanTxt.Size = New System.Drawing.Size(116, 20)
        Me.NoPeminjamanTxt.TabIndex = 13
        '
        'KdBukuTxt
        '
        Me.KdBukuTxt.BackColor = System.Drawing.SystemColors.Info
        Me.KdBukuTxt.Location = New System.Drawing.Point(120, 48)
        Me.KdBukuTxt.Name = "KdBukuTxt"
        Me.KdBukuTxt.Size = New System.Drawing.Size(116, 20)
        Me.KdBukuTxt.TabIndex = 14
        '
        'JdBukuTxt
        '
        Me.JdBukuTxt.Enabled = False
        Me.JdBukuTxt.Location = New System.Drawing.Point(120, 72)
        Me.JdBukuTxt.Name = "JdBukuTxt"
        Me.JdBukuTxt.Size = New System.Drawing.Size(210, 20)
        Me.JdBukuTxt.TabIndex = 15
        '
        'KategoriTxt
        '
        Me.KategoriTxt.Enabled = False
        Me.KategoriTxt.Location = New System.Drawing.Point(120, 96)
        Me.KategoriTxt.Name = "KategoriTxt"
        Me.KategoriTxt.Size = New System.Drawing.Size(116, 20)
        Me.KategoriTxt.TabIndex = 16
        '
        'RakTxt
        '
        Me.RakTxt.Enabled = False
        Me.RakTxt.Location = New System.Drawing.Point(120, 120)
        Me.RakTxt.Name = "RakTxt"
        Me.RakTxt.Size = New System.Drawing.Size(116, 20)
        Me.RakTxt.TabIndex = 17
        '
        'KdPeminjam
        '
        Me.KdPeminjam.BackColor = System.Drawing.SystemColors.Info
        Me.KdPeminjam.Location = New System.Drawing.Point(120, 161)
        Me.KdPeminjam.Name = "KdPeminjam"
        Me.KdPeminjam.Size = New System.Drawing.Size(116, 20)
        Me.KdPeminjam.TabIndex = 18
        '
        'NoKtpTxt
        '
        Me.NoKtpTxt.Enabled = False
        Me.NoKtpTxt.Location = New System.Drawing.Point(120, 185)
        Me.NoKtpTxt.Name = "NoKtpTxt"
        Me.NoKtpTxt.Size = New System.Drawing.Size(116, 20)
        Me.NoKtpTxt.TabIndex = 19
        '
        'NmPeminjamTxt
        '
        Me.NmPeminjamTxt.Enabled = False
        Me.NmPeminjamTxt.Location = New System.Drawing.Point(120, 209)
        Me.NmPeminjamTxt.Name = "NmPeminjamTxt"
        Me.NmPeminjamTxt.Size = New System.Drawing.Size(210, 20)
        Me.NmPeminjamTxt.TabIndex = 20
        '
        'AlmTxt
        '
        Me.AlmTxt.Enabled = False
        Me.AlmTxt.Location = New System.Drawing.Point(120, 233)
        Me.AlmTxt.Name = "AlmTxt"
        Me.AlmTxt.Size = New System.Drawing.Size(210, 20)
        Me.AlmTxt.TabIndex = 21
        '
        'TeleponTxt
        '
        Me.TeleponTxt.Enabled = False
        Me.TeleponTxt.Location = New System.Drawing.Point(120, 257)
        Me.TeleponTxt.Name = "TeleponTxt"
        Me.TeleponTxt.Size = New System.Drawing.Size(116, 20)
        Me.TeleponTxt.TabIndex = 22
        '
        'LamaTxt
        '
        Me.LamaTxt.Enabled = False
        Me.LamaTxt.Location = New System.Drawing.Point(120, 351)
        Me.LamaTxt.Name = "LamaTxt"
        Me.LamaTxt.Size = New System.Drawing.Size(100, 20)
        Me.LamaTxt.TabIndex = 23
        '
        'KdPeminjamBtn
        '
        Me.KdPeminjamBtn.BackgroundImage = CType(resources.GetObject("KdPeminjamBtn.BackgroundImage"), System.Drawing.Image)
        Me.KdPeminjamBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.KdPeminjamBtn.Location = New System.Drawing.Point(242, 158)
        Me.KdPeminjamBtn.Name = "KdPeminjamBtn"
        Me.KdPeminjamBtn.Size = New System.Drawing.Size(24, 24)
        Me.KdPeminjamBtn.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.KdPeminjamBtn, "Kode Peminjam")
        Me.KdPeminjamBtn.UseVisualStyleBackColor = True
        '
        'OkBtn
        '
        Me.OkBtn.Image = Global.Perpustakaan.My.Resources.Resources.checkmark
        Me.OkBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OkBtn.Location = New System.Drawing.Point(372, 289)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(75, 39)
        Me.OkBtn.TabIndex = 26
        Me.OkBtn.Text = "Ok"
        Me.OkBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'BtnTutup
        '
        Me.BtnTutup.Image = Global.Perpustakaan.My.Resources.Resources.previous
        Me.BtnTutup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTutup.Location = New System.Drawing.Point(373, 334)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(75, 39)
        Me.BtnTutup.TabIndex = 27
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'TglPinjamDP
        '
        Me.TglPinjamDP.CustomFormat = "dd/MM/yyyy"
        Me.TglPinjamDP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TglPinjamDP.Location = New System.Drawing.Point(120, 299)
        Me.TglPinjamDP.Name = "TglPinjamDP"
        Me.TglPinjamDP.Size = New System.Drawing.Size(116, 20)
        Me.TglPinjamDP.TabIndex = 28
        '
        'TglKembaliDP
        '
        Me.TglKembaliDP.CustomFormat = "dd/MM/yyyy"
        Me.TglKembaliDP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TglKembaliDP.Location = New System.Drawing.Point(120, 325)
        Me.TglKembaliDP.Name = "TglKembaliDP"
        Me.TglKembaliDP.Size = New System.Drawing.Size(116, 20)
        Me.TglKembaliDP.TabIndex = 29
        '
        'KdBukuBtn
        '
        Me.KdBukuBtn.BackgroundImage = CType(resources.GetObject("KdBukuBtn.BackgroundImage"), System.Drawing.Image)
        Me.KdBukuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.KdBukuBtn.Location = New System.Drawing.Point(242, 46)
        Me.KdBukuBtn.Name = "KdBukuBtn"
        Me.KdBukuBtn.Size = New System.Drawing.Size(24, 24)
        Me.KdBukuBtn.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.KdBukuBtn, "Kode Buku")
        Me.KdBukuBtn.UseVisualStyleBackColor = True
        '
        'FotoPic
        '
        Me.FotoPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FotoPic.Location = New System.Drawing.Point(336, 48)
        Me.FotoPic.Name = "FotoPic"
        Me.FotoPic.Size = New System.Drawing.Size(111, 133)
        Me.FotoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FotoPic.TabIndex = 30
        Me.FotoPic.TabStop = False
        '
        'FrmPeminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 385)
        Me.ControlBox = False
        Me.Controls.Add(Me.FotoPic)
        Me.Controls.Add(Me.TglKembaliDP)
        Me.Controls.Add(Me.TglPinjamDP)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.KdPeminjamBtn)
        Me.Controls.Add(Me.KdBukuBtn)
        Me.Controls.Add(Me.LamaTxt)
        Me.Controls.Add(Me.TeleponTxt)
        Me.Controls.Add(Me.AlmTxt)
        Me.Controls.Add(Me.NmPeminjamTxt)
        Me.Controls.Add(Me.NoKtpTxt)
        Me.Controls.Add(Me.KdPeminjam)
        Me.Controls.Add(Me.RakTxt)
        Me.Controls.Add(Me.KategoriTxt)
        Me.Controls.Add(Me.JdBukuTxt)
        Me.Controls.Add(Me.KdBukuTxt)
        Me.Controls.Add(Me.NoPeminjamanTxt)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "FrmPeminjaman"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Peminjaman Buku"
        CType(Me.FotoPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents NoPeminjamanTxt As System.Windows.Forms.TextBox
    Friend WithEvents KdBukuTxt As System.Windows.Forms.TextBox
    Friend WithEvents JdBukuTxt As System.Windows.Forms.TextBox
    Friend WithEvents KategoriTxt As System.Windows.Forms.TextBox
    Friend WithEvents RakTxt As System.Windows.Forms.TextBox
    Friend WithEvents KdPeminjam As System.Windows.Forms.TextBox
    Friend WithEvents NoKtpTxt As System.Windows.Forms.TextBox
    Friend WithEvents NmPeminjamTxt As System.Windows.Forms.TextBox
    Friend WithEvents AlmTxt As System.Windows.Forms.TextBox
    Friend WithEvents TeleponTxt As System.Windows.Forms.TextBox
    Friend WithEvents LamaTxt As System.Windows.Forms.TextBox
    Friend WithEvents KdBukuBtn As System.Windows.Forms.Button
    Friend WithEvents KdPeminjamBtn As System.Windows.Forms.Button
    Friend WithEvents OkBtn As System.Windows.Forms.Button
    Friend WithEvents BtnTutup As System.Windows.Forms.Button
    Friend WithEvents TglPinjamDP As System.Windows.Forms.DateTimePicker
    Friend WithEvents TglKembaliDP As System.Windows.Forms.DateTimePicker
    Friend WithEvents FotoPic As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
