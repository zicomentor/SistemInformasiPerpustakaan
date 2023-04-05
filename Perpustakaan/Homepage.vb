Public Class Homepage

    Private Sub Login_Petugas_Click(sender As Object, e As EventArgs) Handles Login_Petugas.Click
        Me.Login_Petugas.Visible = False
        Me.admin.Visible = True
        Me.karyawan.Visible = True
    End Sub

    Private Sub admin_Click(sender As Object, e As EventArgs) Handles admin.Click
        Login_admin.Show()
        Login_admin.TopMost = True
        Me.TopMost = False
        Me.Enabled = False
    End Sub

    Private Sub Login_pengunjung_Click(sender As Object, e As EventArgs) Handles Login_pengunjung.Click
        Kunjungan.Show()
        Me.Hide()
        Kunjungan.TblKunjunganBindingSource.AddNew()
    End Sub

    Private Sub karyawan_Click(sender As Object, e As EventArgs) Handles karyawan.Click
        Login_karyawan.Show()
        Login_karyawan.TopMost = True
        Me.TopMost = False
        Me.Enabled = False
    End Sub
End Class