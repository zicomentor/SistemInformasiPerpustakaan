<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Homepage
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
        Me.Login_pengunjung = New System.Windows.Forms.Button()
        Me.admin = New System.Windows.Forms.Button()
        Me.karyawan = New System.Windows.Forms.Button()
        Me.Login_Petugas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Login_pengunjung
        '
        Me.Login_pengunjung.Image = Global.Perpustakaan.My.Resources.Resources.user
        Me.Login_pengunjung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Login_pengunjung.Location = New System.Drawing.Point(110, 390)
        Me.Login_pengunjung.Name = "Login_pengunjung"
        Me.Login_pengunjung.Size = New System.Drawing.Size(132, 58)
        Me.Login_pengunjung.TabIndex = 0
        Me.Login_pengunjung.Text = "Pengunjung"
        Me.Login_pengunjung.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Login_pengunjung.UseVisualStyleBackColor = True
        '
        'admin
        '
        Me.admin.Image = Global.Perpustakaan.My.Resources.Resources.laptop__2_
        Me.admin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.admin.Location = New System.Drawing.Point(527, 355)
        Me.admin.Name = "admin"
        Me.admin.Size = New System.Drawing.Size(132, 58)
        Me.admin.TabIndex = 2
        Me.admin.Text = "Admin"
        Me.admin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.admin.UseVisualStyleBackColor = True
        Me.admin.Visible = False
        '
        'karyawan
        '
        Me.karyawan.Image = Global.Perpustakaan.My.Resources.Resources.book__1_
        Me.karyawan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.karyawan.Location = New System.Drawing.Point(527, 424)
        Me.karyawan.Name = "karyawan"
        Me.karyawan.Size = New System.Drawing.Size(132, 58)
        Me.karyawan.TabIndex = 3
        Me.karyawan.Text = "Karyawan"
        Me.karyawan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.karyawan.UseVisualStyleBackColor = True
        Me.karyawan.Visible = False
        '
        'Login_Petugas
        '
        Me.Login_Petugas.Image = Global.Perpustakaan.My.Resources.Resources.laptop__1_
        Me.Login_Petugas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Login_Petugas.Location = New System.Drawing.Point(527, 390)
        Me.Login_Petugas.Name = "Login_Petugas"
        Me.Login_Petugas.Size = New System.Drawing.Size(132, 58)
        Me.Login_Petugas.TabIndex = 1
        Me.Login_Petugas.Text = "Petugas"
        Me.Login_Petugas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Login_Petugas.UseVisualStyleBackColor = True
        '
        'Homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.Main
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Login_Petugas)
        Me.Controls.Add(Me.karyawan)
        Me.Controls.Add(Me.admin)
        Me.Controls.Add(Me.Login_pengunjung)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "Homepage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Homepage"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Login_pengunjung As System.Windows.Forms.Button
    Friend WithEvents admin As System.Windows.Forms.Button
    Friend WithEvents karyawan As System.Windows.Forms.Button
    Friend WithEvents Login_Petugas As System.Windows.Forms.Button
End Class
