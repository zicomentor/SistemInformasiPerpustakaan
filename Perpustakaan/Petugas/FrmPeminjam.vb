Imports System.Data
Imports System.Data.OleDb
Public Class FrmPeminjam
    Sub Data_Record()
        Try
            Call Koneksi()
            Tabel = New Data.OleDb.OleDbDataAdapter("select * from TblPeminjam", Database)
            Data = New DataSet
            Tabel.Fill(Data)
            Record.DataSource = Data
            Record.DataMember = Data.Tables(0).ToString()
            DGPeminjam.DataSource = Record
            DGPeminjam.Columns(0).Visible = False
            DGPeminjam.Columns(3).Width = 200

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Sub Atur()
        BtnSimpan.Enabled = True
        BtnHapus.Enabled = False
        BtnUbah.Enabled = False
        BtnBatal.Enabled = False
        KdPeminjamTxt.Text = ""
        NoKTPTxt.Text = ""
        NmPeminjamTxt.Text = ""
        AlmTxt.Text = ""
        TeleponTxt.Text = ""
        KdPeminjamTxt.Focus()
        Call Kode_Peminjam()
        Call Koneksi()
        Call Data_Record()
    End Sub

    Sub Kode_Peminjam()
        Tabel = New Data.OleDb.OleDbDataAdapter("select * from TblPeminjam order by No asc", Database)
        Data = New DataSet
        Tabel.Fill(Data)
        Record.DataSource = Data
        Record.DataMember = Data.Tables(0).ToString()

        Try
            Dim A As DataRow
            Dim B As Integer = 0
            KdPeminjamTxt.Text = ""
            For Each A In Data.Tables(0).Rows
                KdPeminjamTxt.Text = A.Item(0) + 1
                B = B + 1
            Next A

            Select Case B
                Case Is = 0
                    KdPeminjamTxt.Text = "MPU1"
                Case Is > 0
                    KdPeminjamTxt.Text = "MPU" & "" & KdPeminjamTxt.Text
            End Select
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub FrmPeminjam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Atur()
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        Try
            Call Koneksi()
            DML.Connection = Database
            DML.CommandType = CommandType.Text
            DML.CommandText = "insert into TblPeminjam(Kode_Peminjam,No_KTP,Nama_Peminjam,Alamat,Telepon)" & _
                "values('" & KdPeminjamTxt.Text & "','" & NoKTPTxt.Text & "','" & NmPeminjamTxt.Text & _
                "','" & AlmTxt.Text & "','" & TeleponTxt.Text & "')"
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
            DML.CommandText = "update TblPeminjam set No_KTP='" & NoKTPTxt.Text & _
                "',Nama_Peminjam='" & NmPeminjamTxt.Text & "',Alamat='" & AlmTxt.Text & _
                "',Telepon='" & TeleponTxt.Text & "' where Kode_Peminjam='" & KdPeminjamTxt.Text & "'"
            DML.ExecuteNonQuery()
            MsgBox("data telah diubah")
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
            DML.CommandText = "delete from TblPeminjam where Kode_Peminjam='" & KdPeminjamTxt.Text & "'"
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

    Private Sub BtnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTutup.Click
        Me.Hide()
        FrmMenuUtama.Show()
    End Sub

    Private Sub DGPeminjam_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGPeminjam.CellContentClick
        Try
            KdPeminjamTxt.Text = DGPeminjam.SelectedCells(1).Value
            NoKTPTxt.Text = DGPeminjam.SelectedCells(2).Value
            NmPeminjamTxt.Text = DGPeminjam.SelectedCells(3).Value
            AlmTxt.Text = DGPeminjam.SelectedCells(4).Value
            TeleponTxt.Text = DGPeminjam.SelectedCells(5).Value
            BtnSimpan.Enabled = False
            BtnUbah.Enabled = True
            BtnHapus.Enabled = True
            BtnBatal.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
End Class