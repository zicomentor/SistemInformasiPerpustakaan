<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPengembalianBuku
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.NoPeminjamanTxt = New System.Windows.Forms.TextBox()
        Me.KdPeminjamTxt = New System.Windows.Forms.TextBox()
        Me.NoKtpTxt = New System.Windows.Forms.TextBox()
        Me.NmPeminjamTxt = New System.Windows.Forms.TextBox()
        Me.AlmTxt = New System.Windows.Forms.TextBox()
        Me.TeleponTxt = New System.Windows.Forms.TextBox()
        Me.KdBukuTxt = New System.Windows.Forms.TextBox()
        Me.JdBukuTxt = New System.Windows.Forms.TextBox()
        Me.TelatTxt = New System.Windows.Forms.TextBox()
        Me.TglPinjamDP = New System.Windows.Forms.DateTimePicker()
        Me.TglKembaliDP = New System.Windows.Forms.DateTimePicker()
        Me.TglPengembalianDP = New System.Windows.Forms.DateTimePicker()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.FotoPic = New System.Windows.Forms.PictureBox()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.NoPeminjamanBtn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.FotoPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Peminjaman"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Peminjam"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No. KTP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama Peminjam"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Alamat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Telepon"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Kode Buku"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Judul Buku"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 284)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Tgl Peminjaman"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 310)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Tgl Harus Kembali"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 352)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Tgl Pengembalian"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 375)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Telat dan Denda"
        '
        'NoPeminjamanTxt
        '
        Me.NoPeminjamanTxt.BackColor = System.Drawing.SystemColors.Info
        Me.NoPeminjamanTxt.Location = New System.Drawing.Point(114, 12)
        Me.NoPeminjamanTxt.Name = "NoPeminjamanTxt"
        Me.NoPeminjamanTxt.Size = New System.Drawing.Size(129, 20)
        Me.NoPeminjamanTxt.TabIndex = 12
        '
        'KdPeminjamTxt
        '
        Me.KdPeminjamTxt.Enabled = False
        Me.KdPeminjamTxt.Location = New System.Drawing.Point(114, 50)
        Me.KdPeminjamTxt.Name = "KdPeminjamTxt"
        Me.KdPeminjamTxt.Size = New System.Drawing.Size(129, 20)
        Me.KdPeminjamTxt.TabIndex = 13
        '
        'NoKtpTxt
        '
        Me.NoKtpTxt.Enabled = False
        Me.NoKtpTxt.Location = New System.Drawing.Point(114, 76)
        Me.NoKtpTxt.Name = "NoKtpTxt"
        Me.NoKtpTxt.Size = New System.Drawing.Size(129, 20)
        Me.NoKtpTxt.TabIndex = 14
        '
        'NmPeminjamTxt
        '
        Me.NmPeminjamTxt.Enabled = False
        Me.NmPeminjamTxt.Location = New System.Drawing.Point(114, 102)
        Me.NmPeminjamTxt.Name = "NmPeminjamTxt"
        Me.NmPeminjamTxt.Size = New System.Drawing.Size(214, 20)
        Me.NmPeminjamTxt.TabIndex = 15
        '
        'AlmTxt
        '
        Me.AlmTxt.Enabled = False
        Me.AlmTxt.Location = New System.Drawing.Point(114, 128)
        Me.AlmTxt.Multiline = True
        Me.AlmTxt.Name = "AlmTxt"
        Me.AlmTxt.Size = New System.Drawing.Size(214, 50)
        Me.AlmTxt.TabIndex = 16
        '
        'TeleponTxt
        '
        Me.TeleponTxt.Enabled = False
        Me.TeleponTxt.Location = New System.Drawing.Point(114, 184)
        Me.TeleponTxt.Name = "TeleponTxt"
        Me.TeleponTxt.Size = New System.Drawing.Size(129, 20)
        Me.TeleponTxt.TabIndex = 17
        '
        'KdBukuTxt
        '
        Me.KdBukuTxt.Enabled = False
        Me.KdBukuTxt.Location = New System.Drawing.Point(114, 226)
        Me.KdBukuTxt.Name = "KdBukuTxt"
        Me.KdBukuTxt.Size = New System.Drawing.Size(129, 20)
        Me.KdBukuTxt.TabIndex = 18
        '
        'JdBukuTxt
        '
        Me.JdBukuTxt.Enabled = False
        Me.JdBukuTxt.Location = New System.Drawing.Point(114, 252)
        Me.JdBukuTxt.Name = "JdBukuTxt"
        Me.JdBukuTxt.Size = New System.Drawing.Size(214, 20)
        Me.JdBukuTxt.TabIndex = 19
        '
        'TelatTxt
        '
        Me.TelatTxt.Enabled = False
        Me.TelatTxt.Location = New System.Drawing.Point(114, 372)
        Me.TelatTxt.Name = "TelatTxt"
        Me.TelatTxt.Size = New System.Drawing.Size(96, 20)
        Me.TelatTxt.TabIndex = 20
        '
        'TglPinjamDP
        '
        Me.TglPinjamDP.CustomFormat = "dd/MM/yyyy"
        Me.TglPinjamDP.Enabled = False
        Me.TglPinjamDP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TglPinjamDP.Location = New System.Drawing.Point(114, 278)
        Me.TglPinjamDP.Name = "TglPinjamDP"
        Me.TglPinjamDP.Size = New System.Drawing.Size(129, 20)
        Me.TglPinjamDP.TabIndex = 21
        '
        'TglKembaliDP
        '
        Me.TglKembaliDP.CustomFormat = "dd/MM/yyyy"
        Me.TglKembaliDP.Enabled = False
        Me.TglKembaliDP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TglKembaliDP.Location = New System.Drawing.Point(114, 304)
        Me.TglKembaliDP.Name = "TglKembaliDP"
        Me.TglKembaliDP.Size = New System.Drawing.Size(129, 20)
        Me.TglKembaliDP.TabIndex = 22
        '
        'TglPengembalianDP
        '
        Me.TglPengembalianDP.CustomFormat = "dd/MM/yyyy"
        Me.TglPengembalianDP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TglPengembalianDP.Location = New System.Drawing.Point(114, 346)
        Me.TglPengembalianDP.Name = "TglPengembalianDP"
        Me.TglPengembalianDP.Size = New System.Drawing.Size(129, 20)
        Me.TglPengembalianDP.TabIndex = 23
        '
        'BtnTutup
        '
        Me.BtnTutup.Image = Global.Perpustakaan.My.Resources.Resources.previous
        Me.BtnTutup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTutup.Location = New System.Drawing.Point(365, 356)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(85, 35)
        Me.BtnTutup.TabIndex = 26
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'FotoPic
        '
        Me.FotoPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FotoPic.Location = New System.Drawing.Point(350, 198)
        Me.FotoPic.Name = "FotoPic"
        Me.FotoPic.Size = New System.Drawing.Size(100, 109)
        Me.FotoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FotoPic.TabIndex = 27
        Me.FotoPic.TabStop = False
        '
        'OkBtn
        '
        Me.OkBtn.Image = Global.Perpustakaan.My.Resources.Resources.checkmark
        Me.OkBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OkBtn.Location = New System.Drawing.Point(365, 315)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(85, 35)
        Me.OkBtn.TabIndex = 25
        Me.OkBtn.Text = "OK"
        Me.OkBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'NoPeminjamanBtn
        '
        Me.NoPeminjamanBtn.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.search
        Me.NoPeminjamanBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NoPeminjamanBtn.Location = New System.Drawing.Point(251, 9)
        Me.NoPeminjamanBtn.Name = "NoPeminjamanBtn"
        Me.NoPeminjamanBtn.Size = New System.Drawing.Size(24, 24)
        Me.NoPeminjamanBtn.TabIndex = 24
        Me.NoPeminjamanBtn.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(216, 372)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(112, 20)
        Me.TextBox1.TabIndex = 28
        '
        'FrmPengembalianBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 420)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.FotoPic)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.NoPeminjamanBtn)
        Me.Controls.Add(Me.TglPengembalianDP)
        Me.Controls.Add(Me.TglKembaliDP)
        Me.Controls.Add(Me.TglPinjamDP)
        Me.Controls.Add(Me.TelatTxt)
        Me.Controls.Add(Me.JdBukuTxt)
        Me.Controls.Add(Me.KdBukuTxt)
        Me.Controls.Add(Me.TeleponTxt)
        Me.Controls.Add(Me.AlmTxt)
        Me.Controls.Add(Me.NmPeminjamTxt)
        Me.Controls.Add(Me.NoKtpTxt)
        Me.Controls.Add(Me.KdPeminjamTxt)
        Me.Controls.Add(Me.NoPeminjamanTxt)
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
        Me.MaximizeBox = False
        Me.Name = "FrmPengembalianBuku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pengembalian Buku"
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
    Friend WithEvents NoPeminjamanTxt As System.Windows.Forms.TextBox
    Friend WithEvents KdPeminjamTxt As System.Windows.Forms.TextBox
    Friend WithEvents NoKtpTxt As System.Windows.Forms.TextBox
    Friend WithEvents NmPeminjamTxt As System.Windows.Forms.TextBox
    Friend WithEvents AlmTxt As System.Windows.Forms.TextBox
    Friend WithEvents TeleponTxt As System.Windows.Forms.TextBox
    Friend WithEvents KdBukuTxt As System.Windows.Forms.TextBox
    Friend WithEvents JdBukuTxt As System.Windows.Forms.TextBox
    Friend WithEvents TelatTxt As System.Windows.Forms.TextBox
    Friend WithEvents TglPinjamDP As System.Windows.Forms.DateTimePicker
    Friend WithEvents TglKembaliDP As System.Windows.Forms.DateTimePicker
    Friend WithEvents TglPengembalianDP As System.Windows.Forms.DateTimePicker
    Friend WithEvents NoPeminjamanBtn As System.Windows.Forms.Button
    Friend WithEvents OkBtn As System.Windows.Forms.Button
    Friend WithEvents BtnTutup As System.Windows.Forms.Button
    Friend WithEvents FotoPic As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
