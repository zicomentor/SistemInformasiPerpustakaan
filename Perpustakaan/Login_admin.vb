Imports System.Data.OleDb
Public Class Login_admin

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        CNN = New OleDbConnection(KSI)
        If CNN.State <> ConnectionState.Closed Then CNN.Close()
        CNN.Open()
        OLECMD = New OleDbCommand("SELECT * From TbAdmin  WHERE Username = '" & Username.Text & _
"' and Password = '" & Password.Text & "'", CNN)
        OLERDR = OLECMD.ExecuteReader
        If Username.Text = "" Then
            MessageBox.Show("Username wajib diisi !!!", "Peringatan!")
            Username.Focus()
            Exit Sub
        ElseIf Password.Text = "" Then
            MessageBox.Show("Password wajib diisi !!!", "Peringatan!")
            Password.Focus()
            Exit Sub
        End If
        If (OLERDR.Read()) Then
            Me.Hide()
            Homepage.Hide()
            FrmMenuUtama.Show()
            FrmKunjungan.DataGridView1.ReadOnly = False
            FrmKunjungan.Button2.Enabled = True
            FrmMenuUtama.Username.Text = Username.Text
            FrmMenuUtama.Button4.Enabled = True
            FrmDataPeminjaman.DataGridView1.Visible = True
            Username.Text = ""
            Password.Text = ""
            Username.Focus()
        Else
            MsgBox("Username & Password Anda Salah!", MsgBoxStyle.OkOnly, _
                   "Login gagal")
            Username.Text = ""
            Password.Text = ""
            Username.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Homepage.Enabled = True
        Homepage.TopMost = True
    End Sub

End Class