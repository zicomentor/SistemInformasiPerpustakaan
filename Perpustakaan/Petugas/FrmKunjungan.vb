Public Class FrmKunjungan

    Private Sub FrmKunjungan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PerpustakaanDataSet.TblKunjungan' table. You can move, or remove it, as needed.
        Me.TblKunjunganTableAdapter.Fill(Me.PerpustakaanDataSet.TblKunjungan)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        FrmMenuUtama.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Validate()
        Me.TblKunjunganBindingSource.RemoveCurrent()
    End Sub
End Class