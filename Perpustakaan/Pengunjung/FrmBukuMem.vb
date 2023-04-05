Imports System.Data
Imports System.Data.OleDb
Public Class FrmBukuMem

    Private Sub FrmBukuMem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PerpustakaanDataSet.TblBuku' table. You can move, or remove it, as needed.
        Me.TblBukuTableAdapter.Fill(Me.PerpustakaanDataSet.TblBuku)

    End Sub

    Private Sub Cari_kode_Click(sender As Object, e As EventArgs) Handles Cari_kode.Click
        Dim Cari = InputBox("Cari melalui kode buku", "Masukan Kode Buku")
        Kode_buku.Text = Cari
    End Sub

    Private Sub Kode_buku_TextChanged(sender As Object, e As EventArgs) Handles Kode_buku.TextChanged
        Try
            Call Koneksi()
            DML.Connection = Database
            DML.CommandType = CommandType.Text
            DML.CommandText = "select * from TblBuku where Kode_buku='" & Kode_buku.Text & "'"
            Cari = DML.ExecuteReader
            If Cari.HasRows = True Then
                Cari.Read()
                Judul_buku.Text = Cari("Judul_buku")
                Kategori.Text = Cari("Kategori")
                Rak.Text = Cari("Rak")
                Stock.Text = Cari("Stock")
                FotoPic.ImageLocation = Cari("Foto")
            Else
                Judul_buku.Text = ""
                Kategori.Text = ""
                Rak.Text = ""
                Stock.Text = ""
                FotoPic.ImageLocation = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub Judul_buku_TextChanged(sender As Object, e As EventArgs) Handles Judul_buku.TextChanged
        Try
            Call Koneksi()
            DML.Connection = Database
            DML.CommandType = CommandType.Text
            DML.CommandText = "select * from TblBuku where Judul_buku='" & Judul_buku.Text & "'"
            Cari = DML.ExecuteReader
            If Cari.HasRows = True Then
                Cari.Read()
                Kode_buku.Text = Cari("Kode_buku")
                Kategori.Text = Cari("Kategori")
                Rak.Text = Cari("Rak")
                Stock.Text = Cari("Stock")
                FotoPic.ImageLocation = Cari("Foto")
            Else
                Kode_buku.Text = ""
                Kategori.Text = ""
                Rak.Text = ""
                Stock.Text = ""
                FotoPic.ImageLocation = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        FrmMenuUtamaMem.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.DataSource = Me.PerpustakaanDataSet.TblBuku.Select("Judul_buku like'" & TextBox1.Text & "%" & "'")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DataGridView1.DataSource = Me.PerpustakaanDataSet.TblBuku.Select("Kategori like'" & TextBox2.Text & "%" & "'")
    End Sub
End Class