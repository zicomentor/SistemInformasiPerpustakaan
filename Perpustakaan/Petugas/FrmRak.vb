Imports System.Data
Imports System.Data.OleDb
Public Class FrmRak
    Sub Data_Record()
        Try
            Call Koneksi()
            Tabel = New Data.OleDb.OleDbDataAdapter("select * from TblRak", Database)
            Data = New DataSet
            Tabel.Fill(Data)
            Record.DataSource = Data
            Record.DataMember = Data.Tables(0).ToString()
            DGRak.DataSource = Record
            DGRak.Columns(0).Width = 300
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Sub Atur()
        BtnSimpan.Enabled = True
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
        BtnBatal.Enabled = False
        RakTxt.Text = ""
        RakTxt.Focus()
        Call Koneksi()
        Call Data_Record()
    End Sub

    Private Sub FrmRak_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Atur()
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If RakTxt.Text = "" Then RakTxt.Focus() : Exit Sub
        Try
            Call Koneksi()
            DML.Connection = Database
            DML.CommandType = CommandType.Text
            DML.CommandText = "insert into TblRak values('" & RakTxt.Text & "')"
            DML.ExecuteNonQuery()
            MsgBox("data telah disimpan")
            Call Atur()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        If RakTxt.Text = "" Then RakTxt.Focus() : Exit Sub
        Try
            Call Koneksi()
            DML.Connection = Database
            DML.CommandType = CommandType.Text
            DML.CommandText = "update TblRak set Rak='" & RakTxt.Text & _
                "' where Rak='" & DGRak.SelectedCells(0).Value & "'"
            DML.ExecuteNonQuery()
            MsgBox("data telah diubah")
            Call Atur()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If RakTxt.Text = "" Then RakTxt.Focus() : Exit Sub
        Try
            Call Koneksi()
            DML.Connection = Database
            DML.CommandType = CommandType.Text
            DML.CommandText = "delete from TblRak where Rak='" & RakTxt.Text & "'"
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
    End Sub

    Private Sub DGRak_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGRak.CellContentClick
        Try
            RakTxt.Text = DGRak.SelectedCells(0).Value
            BtnSimpan.Enabled = False
            BtnUbah.Enabled = True
            BtnHapus.Enabled = True
            BtnBatal.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
End Class