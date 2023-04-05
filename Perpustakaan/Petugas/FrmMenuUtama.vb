Public Class FrmMenuUtama

    Private Sub FrmMenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
    End Sub

    Private Sub BtnBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuku.Click
        FrmBuku.Show()
        Me.Hide()
    End Sub

    Private Sub BtnPeminjam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPeminjam.Click
        FrmPeminjam.Show()
    End Sub

    Private Sub BtnPeminjaman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPeminjaman.Click
        FrmDataPeminjaman.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Homepage.Show()
        Homepage.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        FrmKunjungan.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Setting_Buku.ShowDialog()
    End Sub
End Class