Imports System.Data
Imports System.Data.OleDb

Public Class FrmDataPeminjaman
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

    Sub Atur()
        BtnPeminjaman.Enabled = True
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
        BtnBatal.Enabled = False
        Call Koneksi()
        Call Data_Record()
    End Sub

    Private Sub FrmDataPeminjaman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PerpustakaanDataSet.TblPeminjaman' table. You can move, or remove it, as needed.
        Me.TblPeminjamanTableAdapter.Fill(Me.PerpustakaanDataSet.TblPeminjaman)
        Call Atur()
    End Sub

    Private Sub BtnPeminjaman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPeminjaman.Click
        FrmPeminjaman.Text = "Ok"
        FrmPeminjaman.ShowDialog()
    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        FrmPeminjaman.OkBtn.Text = "Ubah"
        FrmPeminjaman.NoPeminjamanTxt.Text = DGPeminjaman.SelectedCells(0).Value
        FrmPeminjaman.ShowDialog()
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        FrmPeminjaman.OkBtn.Text = "Hapus"
        FrmPeminjaman.NoPeminjamanTxt.Text = DGPeminjaman.SelectedCells(0).Value
        FrmPeminjaman.ShowDialog()
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        FrmPeminjaman.OkBtn.Text = "Ok"
        FrmPeminjaman.NoPeminjamanTxt.Text = DGPeminjaman.SelectedCells(0).Value
        Call Atur()
    End Sub

    Private Sub BtnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTutup.Click
        Me.Hide()
        FrmMenuUtama.Show()
    End Sub

    Private Sub DGPeminjaman_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGPeminjaman.CellContentClick
        Try
            FrmPeminjaman.NoPeminjamanTxt.Text = DGPeminjaman.SelectedCells(0).Value
            FrmPeminjaman.KdBukuTxt.Text = DGPeminjaman.SelectedCells(1).Value
            FrmPeminjaman.KdPeminjam.Text = DGPeminjaman.SelectedCells(5).Value
            FrmPeminjaman.TglPinjamDP.Value = DGPeminjaman.SelectedCells(10).Value
            FrmPeminjaman.TglKembaliDP.Value = DGPeminjaman.SelectedCells(11).Value
            FrmPeminjaman.LamaTxt.Text = DGPeminjaman.SelectedCells(12).Value
            BtnUbah.Enabled = True
            BtnHapus.Enabled = True
            BtnBatal.Enabled = True
            BtnPeminjaman.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmPengembalianBuku.ShowDialog()
    End Sub
End Class