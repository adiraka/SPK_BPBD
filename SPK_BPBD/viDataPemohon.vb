Imports System.IO
Imports MySql.Data.MySqlClient

Public Class viDataPemohon
    Dim sql As String
    Dim proses As New Koneksi
    Dim tabel As DataTable
    Private Sub viDataPemohon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            tabel = proses.ExecuteQuery("select * from pemohon")
            Me.DataGridView1.DataSource = tabel
            With Me.DataGridView1
                .Columns(0).HeaderText = "NIK"
                .Columns(1).HeaderText = "NAMA"
                .Columns(2).HeaderText = "TEMPAT LAHIR"
                .Columns(3).HeaderText = "TANGGAL LAHIR"
                .Columns(4).HeaderText = "JENIS KELAMIN"
                .Columns(5).HeaderText = "ALAMAT"
                .Columns(6).HeaderText = "RT"
                .Columns(7).HeaderText = "RW"
                .Columns(8).HeaderText = "KELURAHAN"
                .Columns(9).HeaderText = "KECAMATAN"
                .Columns(10).HeaderText = "AGAMA"
                .Columns(11).HeaderText = "GOLONGAN DARAH"
                .Columns(12).HeaderText = "STATUS PERNIKAHAN"
                .Columns(13).HeaderText = "PEKERJAAN"
                .Columns(14).HeaderText = "KEWARGANEGARAAN"
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button4.Click, Button5.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim NewMDIChild As New inDataPemohon()
        NewMDIChild.MdiParent = main
        NewMDIChild.Show()
    End Sub
End Class