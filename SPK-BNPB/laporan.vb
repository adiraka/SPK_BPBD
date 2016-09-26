Imports System.IO
Imports MySql.Data.MySqlClient
Public Class laporan
    Dim sql As String
    Dim proses As New Koneksi
    Dim tabel As DataTable

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If vcari.Text = "Data Pemohon" Then
            Try
                sql = "SELECT * FROM pemohon"
                tabel = proses.ExecuteQuery(sql)
                Me.tbview.DataSource = tabel
                With Me.tbview
                    .Columns(0).HeaderText = "NIK"
                    .Columns(1).HeaderText = "Nama"
                    .Columns(2).HeaderText = "Tmpt Lahir"
                    .Columns(3).HeaderText = "Tgl Lahir"
                    .Columns(4).HeaderText = "Jenis Kelamin"
                    .Columns(5).HeaderText = "Alamat"
                    .Columns(6).HeaderText = "RT"
                    .Columns(7).HeaderText = "RW"
                    .Columns(8).HeaderText = "Kelurahan/Desa"
                    .Columns(9).HeaderText = "Kecamatan"
                    .Columns(10).HeaderText = "Agama"
                    .Columns(11).HeaderText = "Gol Darah"
                    .Columns(12).HeaderText = "Stat Perkawinan"
                    .Columns(13).HeaderText = "Pekerjaan"
                    .Columns(14).HeaderText = "Kewarganegaraan"
                End With
                Label2.Text = "LAPORAN DATA PEMOHON"
            Catch ex As Exception

            End Try
        ElseIf vcari.Text = "Data Analisa" Then
            Try
                sql = "SELECT analisa.id, pemohon.nik, pemohon.nama AS namap, surveyor.nip, surveyor.nama AS namas," &
                        "analisa.kj, analisa.kr, analisa.ss, analisa.tb, analisa.ha, analisa.stat " &
                        "FROM pemohon, surveyor, analisa " &
                        "WHERE pemohon.nik = analisa.nik " &
                        "AND surveyor.nip = analisa.nip "
                tabel = proses.ExecuteQuery(sql)
                Me.tbview.DataSource = tabel
                With Me.tbview
                    .Columns(0).HeaderText = "ID Analisa"
                    .Columns(1).HeaderText = "NIK Pemohon"
                    .Columns(2).HeaderText = "Nama Pemohon"
                    .Columns(3).HeaderText = "NIP Surveyor"
                    .Columns(4).HeaderText = "Nama Surveyor"
                    .Columns(5).HeaderText = "Korban Jiwa"
                    .Columns(6).HeaderText = "Kerusakan"
                    .Columns(7).HeaderText = "Status Sosial"
                    .Columns(8).HeaderText = "Tipe Bangunan"
                    .Columns(9).HeaderText = "Hasil Analisa"
                    .Columns(10).HeaderText = "Keterangan"
                End With
                Label2.Text = "LAPORAN DATA ANALISA"
            Catch ex As Exception

            End Try
        ElseIf vcari.Text = "Data Surveyor" Then
            Try
                sql = "SELECT * FROM surveyor"
                tabel = proses.ExecuteQuery(sql)
                Me.tbview.DataSource = tabel
                With Me.tbview
                    .Columns(0).HeaderText = "NIP"
                    .Columns(1).HeaderText = "Nama"
                    .Columns(2).HeaderText = "Tempat Lahir"
                    .Columns(3).HeaderText = "Tanggal Lahir"
                    .Columns(4).HeaderText = "Jenis Kelamin"
                    .Columns(5).HeaderText = "Alamat"
                    .Columns(6).HeaderText = "Telepon"
                End With
                Label2.Text = "LAPORAN DATA SURVEYOR"
            Catch ex As Exception

            End Try
        ElseIf vcari.Text = "Data Admin" Then
            Try
                sql = "SELECT user_akun.nip, user_akun.username, user_info.nama, user_info.tmp_lhr, user_info.tgl_lhr," &
                        "user_info.tgl_lhr, user_info.jekel, user_info.alamat, user_info.agama, user_info.telepon, user_info.jabatan " &
                        "FROM user_akun, user_info " &
                        "WHERE user_akun.nip = user_info.nip "
                tabel = proses.ExecuteQuery(sql)
                Me.tbview.DataSource = tabel
                With Me.tbview
                    .Columns(0).HeaderText = "NIP"
                    .Columns(1).HeaderText = "Username"
                    .Columns(3).HeaderText = "Nama"
                    .Columns(4).HeaderText = "Tmp Lahir"
                    .Columns(5).HeaderText = "Tgl Lahir"
                    .Columns(6).HeaderText = "Jns Kelamin"
                    .Columns(7).HeaderText = "Alamat"
                    .Columns(8).HeaderText = "Agama"
                    .Columns(9).HeaderText = "Telepon"
                    .Columns(10).HeaderText = "Jabatan"
                End With
                Label2.Text = "LAPORAN DATA ADMIN"
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If vcari.Text = "Data Pemohon" Then
            laporanPemohon.Show()
        ElseIf vcari.Text = "Data Analisa" Then
            laporanAnalisa.Show()
        ElseIf vcari.Text = "Data Surveyor" Then
            laporanSurveyor.Show()
        ElseIf vcari.Text = "Data Admin" Then
            laporanAdmin.Show()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class