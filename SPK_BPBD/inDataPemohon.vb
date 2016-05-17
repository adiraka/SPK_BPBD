Imports System.IO
Imports MySql.Data.MySqlClient

Public Class inDataPemohon
    Dim sql As String
    Dim proses As New Koneksi
    Dim tabel As DataTable
    Private Sub inDataPemohon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Try
            tabel = proses.ExecuteQuery("select * from user_akun")
            Me.DataGridView1.DataSource = tabel
            With Me.DataGridView1
                .Columns(0).HeaderText = "ID"
                .Columns(1).HeaderText = "Username"
                .Columns(2).HeaderText = "Password"
                .Columns(3).HeaderText = "Role"
                .Columns(4).HeaderText = "Status"
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub bSimpan_Click(sender As Object, e As EventArgs) Handles bSimpan.Click
        'Dim fStream As FileStream
        'Dim myPath As String = AppDomain.CurrentDomain.BaseDirectory()
        'Dim foto As String = myPath & "img\foto\"
        'PictureBox1.Image = Image.FromFile(foto & "zxc.png")
    End Sub

    Private Sub bBatal_Click(sender As Object, e As EventArgs) Handles bBatal.Click
        Me.Close()
    End Sub
End Class