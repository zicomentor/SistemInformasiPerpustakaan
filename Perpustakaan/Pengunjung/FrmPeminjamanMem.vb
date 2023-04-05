Public Class FrmPeminjamanMem
    Sub Data_Record()
        Try
            Call Koneksi()
            Tabel = New Data.OleDb.OleDbDataAdapter("select * from QryPeminjaman where Status='Pinjam'", Database)
            Data = New DataSet
            Tabel.Fill(Data)
            Record_Peminjaman.DataSource = Data
            Record_Peminjaman.DataMember = Data.Tables(0).ToString()
            DGPeminjaman.DataSource = Record_Peminjaman
            DGPeminjaman.Columns(1).Visible = False
            DGPeminjaman.Columns(2).Width = 175
            DGPeminjaman.Columns(3).Visible = False
            DGPeminjaman.Columns(4).Visible = False
            DGPeminjaman.Columns(5).Visible = False
            DGPeminjaman.Columns(6).Visible = False
            DGPeminjaman.Columns(7).Width = 175
            DGPeminjaman.Columns(8).Visible = False
            DGPeminjaman.Columns(9).Visible = False
            DGPeminjaman.Columns(12).Width = 175
            DGPeminjaman.Columns(13).Visible = False
            DGPeminjaman.Columns(14).Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub FrmPeminjamanMem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PerpustakaanDataSet.QryPeminjaman' table. You can move, or remove it, as needed.
        Me.QryPeminjamanTableAdapter.Fill(Me.PerpustakaanDataSet.QryPeminjaman)
        Call Data_Record()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        FrmMenuUtamaMem.Show()
    End Sub

End Class