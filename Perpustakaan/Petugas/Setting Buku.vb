Public Class Setting_Buku

    Private Sub BtnRak_Click(sender As Object, e As EventArgs) Handles BtnRak.Click
        Me.Hide()
        FrmRak.ShowDialog()
    End Sub

    Private Sub BtnKategori_Click(sender As Object, e As EventArgs) Handles BtnKategori.Click
        Me.Hide()
        FrmKategori.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class