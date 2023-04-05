<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Setting_Buku
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
        Me.BtnRak = New System.Windows.Forms.Button()
        Me.BtnKategori = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnRak
        '
        Me.BtnRak.Image = Global.Perpustakaan.My.Resources.Resources.folder
        Me.BtnRak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRak.Location = New System.Drawing.Point(77, 75)
        Me.BtnRak.Name = "BtnRak"
        Me.BtnRak.Size = New System.Drawing.Size(134, 44)
        Me.BtnRak.TabIndex = 23
        Me.BtnRak.Text = "Tambah Rak"
        Me.BtnRak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRak.UseVisualStyleBackColor = True
        '
        'BtnKategori
        '
        Me.BtnKategori.Image = Global.Perpustakaan.My.Resources.Resources.tag
        Me.BtnKategori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKategori.Location = New System.Drawing.Point(77, 125)
        Me.BtnKategori.Name = "BtnKategori"
        Me.BtnKategori.Size = New System.Drawing.Size(134, 46)
        Me.BtnKategori.TabIndex = 22
        Me.BtnKategori.Text = "Tambah Kategori"
        Me.BtnKategori.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnKategori.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.Perpustakaan.My.Resources.Resources.previous
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(197, 216)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 33)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Back"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Setting_Buku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnRak)
        Me.Controls.Add(Me.BtnKategori)
        Me.MaximumSize = New System.Drawing.Size(300, 300)
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "Setting_Buku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting Buku"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnRak As System.Windows.Forms.Button
    Friend WithEvents BtnKategori As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
