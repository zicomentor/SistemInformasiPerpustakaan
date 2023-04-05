Imports System.Data
Imports System.Data.OleDb
Public Class FrmPeminjaman
    Sub Stok()
        Call Koneksi()
        DML.Connection = Database
        DML.CommandType = CommandType.Text
        DML.CommandText = "update TblBuku set Stock=Stock-1 where Kode_Buku='" & KdBukuTxt.Text & "'"
    End Sub

    Sub No_Peminjaman()
        Tabel = New Data.OleDb.OleDbDataAdapter("select * from TblPeminjaman order by No Asc", Database)
        Data = New DataSet
        Tabel.Fill(Data)
        Record.DataSource = Data
        Record.DataMember = Data.Tables(0).ToString()
        Try
            Dim A As DataRow
            Dim B As Integer = 0
            NoPeminjamanTxt.Text = ""
            For Each A In Data.Tables(0).Rows
                NoPeminjamanTxt.Text = A.Item(0) + 1
                B = B + 1
            Next A

            Select Case B
                Case Is = 0
                    NoPeminjamanTxt.Text = "PPS/" & "" & Format(Now, "dd/MM/yy") & "/1"
                Case Is > 0
                    NoPeminjamanTxt.Text = "PPS/" & "" & Format(Now, "dd/MM/yy") & "/" & "" & NoPeminjamanTxt.Text
            End Select
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Sub Atur()
        Call Koneksi()
        If OkBtn.Text = "Ok" Then
            KdBukuTxt.Text = ""
            KdPeminjam.Text = ""
            LamaTxt.Text = ""
            TglPinjamDP.Value = Format(Now, "dd/MM/yyyy")
            TglKembaliDP.Value = Format(Now, "dd/MM/yyyy")
            Call No_Peminjaman()
        End If
    End Sub

    Sub Lama_Pinjam()
        Dim SelisihHari As Long
        SelisihHari = DateDiff(DateInterval.Day, TglPinjamDP.Value, TglKembaliDP.Value)
        LamaTxt.Text = "" & SelisihHari & " Hari"
    End Sub

    Private Sub FrmPeminjaman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Atur()
    End Sub

    Private Sub OkBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkBtn.Click
        Try
            Call Koneksi()
            DML.Connection = Database
            DML.CommandType = CommandType.Text
            Select Case OkBtn.Text
                Case "Ok"
                    DML.CommandText = "insert into TblPeminjaman(No_Peminjaman, Kode_Buku, Kode_Peminjam," & _
                        "Tgl_Pinjam, Tgl_Kembali, Lama_Pinjam, Status) values('" & NoPeminjamanTxt.Text & _
                        "','" & KdBukuTxt.Text & "','" & KdPeminjam.Text & "','" & TglPinjamDP.Value & _
                        "','" & TglKembaliDP.Value & "','" & LamaTxt.Text & "','Pinjam')"
                Case "Ubah"
                    DML.CommandText = "update TblPeminjaman set Kode_Buku='" & KdBukuTxt.Text & _
                        "', Kode_Peminjam='" & KdPeminjam.Text & "', Tgl_Pinjam='" & TglPinjamDP.Value & _
                        "', Tgl_Kembali='" & TglKembaliDP.Value & "', Lama_Pinjam='" & LamaTxt.Text & _
                        "' where No_Peminjaman='" & NoPeminjamanTxt.Text & "'"
                Case "Hapus"
                    DML.CommandText = "delete from TblPeminjaman where No_Peminjaman='" & NoPeminjamanTxt.Text & "'"
            End Select
            DML.ExecuteNonQuery()
            MsgBox("data telah diproses")

            Call FrmDataPeminjaman.Data_Record()
            KdBukuTxt.Text = ""
            KdPeminjam.Text = ""
            LamaTxt.Text = ""
            FotoPic.Image = Nothing
            TglPinjamDP.Value = Format(Now, "dd/MM/yyyy")
            TglKembaliDP.Value = Format(Now, "dd/MM/yyyy")
            Call No_Peminjaman()
            Call FrmDataPeminjaman.Atur()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub KdBukuBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KdBukuBtn.Click
        Dim Kode_Buku = InputBox("Masukkan kode buku", "Input buku yang dipinjam")
        KdBukuTxt.Text = Kode_Buku
    End Sub

    Private Sub KdBukuTxt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles KdBukuTxt.TextChanged
        Try
            Call Koneksi()
            DML.Connection = Database
            DML.CommandType = CommandType.Text
            DML.CommandText = "select * from TblBuku where Kode_Buku='" & KdBukuTxt.Text & "'"
            Cari = DML.ExecuteReader
            If Cari.HasRows = True Then
                Cari.Read()
                JdBukuTxt.Text = Cari("Judul_Buku")
                KategoriTxt.Text = Cari("Kategori")
                RakTxt.Text = Cari("Rak")
                FotoPic.ImageLocation = Cari("Foto")
            Else
                KdBukuTxt.Text = ""
                JdBukuTxt.Text = ""
                KategoriTxt.Text = ""
                RakTxt.Text = ""
                FotoPic.Image = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub KdPeminjamBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KdPeminjamBtn.Click
        Dim Kode_Peminjam = InputBox("Masukkan kode peminjam", "Input peminjam yang meminjam buku")
        KdPeminjam.Text = Kode_Peminjam
    End Sub

    Private Sub KdPeminjam_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles KdPeminjam.TextChanged
        Try
            Call Koneksi()
            DML.Connection = Database
            DML.CommandType = CommandType.Text
            DML.CommandText = "select * from TblPeminjam where Kode_Peminjam='" & KdPeminjam.Text & "'"
            Cari = DML.ExecuteReader
            If Cari.HasRows = True Then
                Cari.Read()
                NoKtpTxt.Text = Cari("No_KTP")
                NmPeminjamTxt.Text = Cari("Nama_Peminjam")
                AlmTxt.Text = Cari("Alamat")
                TeleponTxt.Text = Cari("Telepon")
            Else
                NoKtpTxt.Text = ""
                NmPeminjamTxt.Text = ""
                AlmTxt.Text = ""
                TeleponTxt.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub TglPinjamDP_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TglPinjamDP.ValueChanged
        Call Lama_Pinjam()
    End Sub

    Private Sub TglKembaliDP_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TglKembaliDP.ValueChanged
        Call Lama_Pinjam()
    End Sub

    Private Sub BtnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub

End Class