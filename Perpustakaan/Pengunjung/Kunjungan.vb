Imports System.Data
Imports System.Data.OleDb
Public Class Kunjungan

    Private Sub Cari_id_Click(sender As Object, e As EventArgs) Handles Cari_id.Click
        Dim Kode_Peminjam = InputBox("Bila Kamu adalah member perpustakaan masukan ID Membermu!", "Id Member")
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
                NmPeminjamTxt.Text = Cari("Nama_Peminjam")
                TeleponTxt.Text = Cari("Telepon")
                FrmMenuUtamaMem.Button4.Enabled = True
            Else
                NmPeminjamTxt.Text = ""
                TeleponTxt.Text = ""
                KdPeminjam.Text = ""
                FrmMenuUtamaMem.Button4.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub Kunjungan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PerpustakaanDataSet.TblKunjungan' table. You can move, or remove it, as needed.
        Me.TblKunjunganTableAdapter.Fill(Me.PerpustakaanDataSet.TblKunjungan)
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        If NmPeminjamTxt.Text = "" Then
            MessageBox.Show("Nama wajib diisi !!!", "Peringatan!")
        ElseIf TeleponTxt.Text = "" Then
            MessageBox.Show("Nomer Telephone wajib diisi !!!", "Peringatan!")
        ElseIf Tujuan.Text = "" Then
            MessageBox.Show("Tujuan wajib diisi !!!", "Peringatan!")
        Else
            Me.Hide()
            Me.Validate()
            Me.TblKunjunganBindingSource.EndEdit()
            Me.TblKunjunganTableAdapter.Update(Me.PerpustakaanDataSet.TblKunjungan)
            FrmMenuUtamaMem.Show()
            FrmMenuUtamaMem.Username.Text = NmPeminjamTxt.Text
        End If
    End Sub


    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Homepage.Show()
    End Sub

    Private Sub NmPeminjamTxt_TextChanged(sender As Object, e As EventArgs) Handles NmPeminjamTxt.TextChanged
        Me.Save.Enabled = True
        Me.TextBox1.Text = "" & Format(Now, "dd/MM/yy")
    End Sub

End Class