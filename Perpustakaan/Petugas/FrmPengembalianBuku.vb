Imports System.Data
Imports System.Data.OleDb
Public Class FrmPengembalianBuku
    Sub Stok()
        Call Koneksi()
        DML.Connection = Database
        DML.CommandType = CommandType.Text
        DML.CommandText = "update TblBuku set Stock=Stock-1 where Kode_Buku='" & KdBukuTxt.Text & "'"
    End Sub
    Sub Hitung_Telat()
        Dim TelatHari As Long
        TelatHari = DateDiff(DateInterval.Day, TglKembaliDP.Value, TglPengembalianDP.Value)
        If TelatHari >= 1 Then
            TelatTxt.Text = "" & TelatHari & " Hari"
            TextBox1.Text = "Rp " & "" & TelatHari * 100
        Else
            TelatTxt.Text = "Tidak"
            TextBox1.Text = "Rp 0"
        End If
    End Sub

    Private Sub FrmPengembalianBuku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TglPengembalianDP.Value = Format(Now, "dd/MM/yyyy")
    End Sub

    Private Sub NoPeminjamanBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoPeminjamanBtn.Click
        Dim No_Peminjaman = InputBox("Masukkan nomor peminjaman", "Input nomor transaksi peminjaman")
        NoPeminjamanTxt.Text = No_Peminjaman
    End Sub

    Private Sub NoPeminjamanTxt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NoPeminjamanTxt.TextChanged
        Try
            Call Koneksi()
            DML.Connection = Database
            DML.CommandType = CommandType.Text
            DML.CommandText = "select * from QryPeminjaman where No_Peminjaman='" & NoPeminjamanTxt.Text & _
                "' and Status='Pinjam'"
            Cari = DML.ExecuteReader
            If Cari.HasRows = True Then
                Cari.Read()
                KdBukuTxt.Text = Cari("Kode_Buku")
                JdBukuTxt.Text = Cari("Judul_Buku")
                FotoPic.ImageLocation = Cari("Foto")
                NoKtpTxt.Text = Cari("No_KTP")
                KdPeminjamTxt.Text = Cari("Kode_Peminjam")
                NmPeminjamTxt.Text = Cari("Nama_Peminjam")
                AlmTxt.Text = Cari("Alamat")
                TeleponTxt.Text = Cari("Telepon")
                TglPinjamDP.Value = Cari("Tgl_Pinjam")
                TglKembaliDP.Value = Cari("Tgl_Kembali")
                Call Hitung_Telat()
            Else
                KdBukuTxt.Text = ""
                JdBukuTxt.Text = ""
                FotoPic.ImageLocation = ""
                NoKtpTxt.Text = ""
                KdPeminjamTxt.Text = ""
                NmPeminjamTxt.Text = ""
                AlmTxt.Text = ""
                TeleponTxt.Text = ""
                TglPengembalianDP.Value = Format(Now, "dd/MM/yyyy")
                TelatTxt.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub OkBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkBtn.Click
        Try
            Call Koneksi()
            DML.Connection = Database
            DML.CommandType = CommandType.Text
            DML.CommandText = "update TblPeminjaman set Status='Kembali' where No_Peminjaman='" & NoPeminjamanTxt.Text & "'"
            DML.ExecuteNonQuery()
            MsgBox("data telah diproses")
            Me.Close()
            FrmDataPeminjaman.Atur()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub TglPengembalianDP_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TglPengembalianDP.ValueChanged
        Call Hitung_Telat()
    End Sub

    Private Sub BtnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub

End Class