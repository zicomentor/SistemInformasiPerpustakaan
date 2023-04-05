Imports System.Data
Imports System.Data.OleDb
Public Class FrmBuku
    Sub Data_Record()
        Try
            'memanggil koneksi database
            Call Koneksi()
            'mengambil data dari tabel buku
            Tabel = New Data.OleDb.OleDbDataAdapter("select * from TblBuku", Database)
            'inisialisasi DataSet
            Data = New DataSet
            'memasukkan data tabel ke DataSet
            Tabel.Fill(Data)
            Record.DataSource = Data
            Record.DataMember = Data.Tables(0).ToString()
            DGBuku.DataSource = Record
            DGBuku.Columns(1).Width = 300
            DGBuku.Columns(5).Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Sub Atur()
        BtnSimpan.Enabled = True
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
        BtnBatal.Enabled = False
        KdBukuTxt.Text = ""
        JdBukuTxt.Text = ""
        KategoriCmb.Text = ""
        RakCmb.Text = ""
        StockTxt.Text = ""
        KdBukuTxt.Enabled = True
        KdBukuTxt.Focus()
        Call Koneksi()
        Call Data_Record()
    End Sub

    Sub Data_Kategori()
        Call Koneksi()

        Tabel = New Data.OleDb.OleDbDataAdapter("select * from TblKategori", Database)
        Data = New DataSet
        Tabel.Fill(Data)
        Record.DataSource = Data
        Record.DataMember = Data.Tables(0).ToString()

        Try
            Dim a As DataRow
            KategoriCmb.Items.Clear()
            For Each a In Data.Tables(0).Rows
                KategoriCmb.Items.Add(a.Item(0))
            Next a
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Sub Data_Rak()
        Tabel = New Data.OleDb.OleDbDataAdapter("select * from TblRak", Database)
        Data = New DataSet
        Tabel.Fill(Data)
        Record.DataSource = Data
        Record.DataMember = Data.Tables(0).ToString()

        Try
            Dim a As DataRow
            RakCmb.Items.Clear()
            For Each a In Data.Tables(0).Rows
                RakCmb.Items.Add(a.Item(0))
            Next a
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub FrmBuku_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call Data_Kategori()
        Call Data_Rak()
        Call Atur()
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        Try
            Call Koneksi()
            DML.Connection = Database
            DML.CommandType = CommandType.Text
            DML.CommandText = "insert into TblBuku values('" & KdBukuTxt.Text & "','" & JdBukuTxt.Text & "','" _
                & KategoriCmb.Text & "','" & RakCmb.Text & "','" & StockTxt.Text & "','" & FotoTxt.Text & "')"
            DML.ExecuteNonQuery()
            MsgBox("data telah disimpan")
            Call Atur()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        Try
            Call Koneksi()
            DML.Connection = Database
            DML.CommandType = CommandType.Text
            DML.CommandText = "update TblBuku set Judul_Buku='" & JdBukuTxt.Text & _
                ", Kategori='" & KategoriCmb.Text & "', Rak='" & RakCmb.Text & _
                ", Stock='" & StockTxt.Text & "', Foto='" & FotoTxt.Text & _
                "' where Kode_Buku='" & KdBukuTxt.Text & "'"
            DML.ExecuteNonQuery()
            MsgBox("Data telah diubah")
            Call Atur()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        Try
            Call Koneksi()
            DML.Connection = Database
            DML.CommandType = CommandType.Text
            DML.CommandText = "delete from TblBuku where Kode_Buku='" & KdBukuTxt.Text & "'"
            DML.ExecuteNonQuery()
            MsgBox("data telah dihapus")
            Call Atur()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        Call Atur()
    End Sub

    Private Sub DGBuku_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGBuku.CellContentClick
        Try
            KdBukuTxt.Text = DGBuku.SelectedCells(0).Value
            JdBukuTxt.Text = DGBuku.SelectedCells(1).Value
            KategoriCmb.Text = DGBuku.SelectedCells(2).Value
            RakCmb.Text = DGBuku.SelectedCells(3).Value
            StockTxt.Text = DGBuku.SelectedCells(4).Value
            FotoTxt.Text = DGBuku.SelectedCells(5).Value
            KdBukuTxt.Enabled = False
            BtnSimpan.Enabled = False
            BtnUbah.Enabled = True
            BtnHapus.Enabled = True
            BtnBatal.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtnAmbilFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAmbilFoto.Click
        OFDFoto.Filter = "JPG|*.jpg|Bitmap|*.bmp"
        OFDFoto.RestoreDirectory = True
        OFDFoto.ShowDialog()
        If OFDFoto.FileName = "" Then
            Exit Sub
        Else
            'belum ada proses upload file gambar ke folder tertentu
            FotoTxt.Text = OFDFoto.FileName
            On Error Resume Next
            FotoPic.ImageLocation = FotoTxt.Text
        End If
    End Sub

    Private Sub BtnHapusFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapusFoto.Click
        FotoPic.Image = Nothing
        FotoTxt.Text = ""
    End Sub

    Private Sub BtnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTutup.Click
        Me.Hide()
        FrmMenuUtama.Show()
    End Sub

End Class
