Imports System.IO
Imports MySql.Data.MySqlClient
Public Class analisaPemohon

    Private Sub analisaPemohon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vha.ReadOnly = True
        vstat.ReadOnly = True
        vkj.Minimum = 10
        vkj.Maximum = 100
        vkr.Minimum = 30
        vkr.Maximum = 100
        vss.Minimum = 20
        vss.Maximum = 100
        vtb.Minimum = 30
        vtb.Maximum = 100
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim con As New MySqlConnection
            Dim cmd As New MySqlCommand
            Dim sql As String
            con = New MySqlConnection("server=localhost;" &
                                     "user id=root;" &
                                     "password=;" &
                                     "database=dbspkbpbd;" &
                                     "character set=utf8;")
            con.Open()
            cmd.Connection = con
            sql = "SELECT nama FROM pemohon WHERE nik = '" & vnik.Text & "'"
            cmd.CommandText = sql
            Dim lrd As MySqlDataReader = cmd.ExecuteReader
            If lrd.HasRows Then
                While lrd.Read()
                    vnamap.Text = lrd.Item("nama")
                End While
            Else
                MsgBox("Data Pemohon tidak ditemukan!", vbInformation, "Pemberitahuan")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kj, kr, ss, tb, mkj, mkr, mss, mtb, ha As Double
        kj = Val(vkj.Text)
        kr = Val(vkr.Text)
        ss = Val(vss.Text)
        tb = Val(vtb.Text)
        mkj = kj / 100
        mkr = kr / 100
        mss = ss / 100
        mtb = tb / 100
        ha = (mkj * 40) + (mkr * 30) + (mss * 15) + (mtb * 15)
        vha.Text = ha
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If vid.Text = "" Or vid.Text.Length = 0 Then
            Try
                Dim sql As String
                Dim proses As New Koneksi
                sql = "INSERT INTO analisa VALUES (NULL, '" & vnik.Text & "'," &
                                                    "'" & vnip.Text & "'," &
                                                    "'" & Val(vkj.Text) & "'," &
                                                    "'" & Val(vkr.Text) & "'," &
                                                    "'" & Val(vss.Text) & "'," &
                                                    "'" & Val(vtb.Text) & "'," &
                                                    "'" & vha.Text & "'," &
                                                    "'" & vstat.Text & "')"
                proses.ExecuteNonQuery(sql)
                vid.ReadOnly = False
                vid.Text = ""
                vnik.Text = ""
                vnamap.Text = ""
                vnip.Text = ""
                vnamas.Text = ""
                vkj.Value = 10
                vkr.Value = 30
                vss.Value = 20
                vtb.Value = 30
                vha.Text = ""
                vstat.Text = ""
                MsgBox("Data berhasil disimpan", vbInformation, "Pemberitahuan")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            Try
                Dim sql As String
                Dim proses As New Koneksi
                sql = "update analisa set kj = '" & Val(vkj.Text) & "'," &
                                                        "nik = '" & vnik.Text & "'," &
                                                        "nip = '" & vnip.Text & "'," &
                                                        "kr = '" & Val(vkr.Text) & "'," &
                                                        "ss = '" & Val(vss.Text) & "'," &
                                                        "tb = '" & Val(vtb.Text) & "'," &
                                                        "ha = '" & vha.Text & "'," &
                                                        "stat = '" & vstat.Text & "' " &
                                                "where id = '" & vid.Text & "'"
                proses.ExecuteNonQuery(sql)
                vid.ReadOnly = False
                vid.Text = ""
                vnik.Text = ""
                vnamap.Text = ""
                vnip.Text = ""
                vnamas.Text = ""
                vkj.Value = 10
                vkr.Value = 30
                vss.Value = 20
                vtb.Value = 30
                vha.Text = ""
                vstat.Text = ""
                MsgBox("data berhasil disimpan", vbInformation, "pemberitahuan")
            Catch ex As Exception
                MsgBox("Maaf Terjadi Kesalahan, Silahkan Cek Lagi NIK Pemohon!", vbInformation, "Peringatan")
            End Try
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim con As New MySqlConnection
            Dim cmd As New MySqlCommand
            Dim sql As String
            con = New MySqlConnection("server=localhost;" &
                                     "user id=root;" &
                                     "password=;" &
                                     "database=dbspkbpbd;" &
                                     "character set=utf8;")
            con.Open()
            cmd.Connection = con
            sql = "SELECT nama FROM surveyor WHERE nip = '" & vnip.Text & "'"
            cmd.CommandText = sql
            Dim lrd As MySqlDataReader = cmd.ExecuteReader
            If lrd.HasRows Then
                While lrd.Read()
                    vnamas.Text = lrd.Item("nama")
                End While
            Else
                MsgBox("Data Surveyor tidak ditemukan!", vbInformation, "Pemberitahuan")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Dim con As New MySqlConnection
            Dim cmd As New MySqlCommand
            Dim sql As String
            con = New MySqlConnection("server=localhost;" &
                                     "user id=root;" &
                                     "password=;" &
                                     "database=dbspkbpbd;" &
                                     "character set=utf8;")
            con.Open()
            cmd.Connection = con
            sql = "SELECT pemohon.nik, pemohon.nama AS namap, surveyor.nip, surveyor.nama AS namas,analisa.id," &
                    "analisa.kj, analisa.kr, analisa.ss, analisa.tb, analisa.ha, analisa.stat " &
                    "FROM pemohon, surveyor, analisa " &
                    "WHERE pemohon.nik = analisa.nik " &
                    "AND surveyor.nip = analisa.nip " &
                    "AND analisa.id = '" & vid.Text & "'"
            cmd.CommandText = sql
            Dim lrd As MySqlDataReader = cmd.ExecuteReader
            If lrd.HasRows Then
                While lrd.Read()
                    vnik.Text = lrd.Item("nik")
                    vnamap.Text = lrd.Item("namap")
                    vnip.Text = lrd.Item("nip")
                    vnamas.Text = lrd.Item("namas")
                    vkj.Value = lrd.Item("kj")
                    vkr.Value = lrd.Item("kr")
                    vss.Value = lrd.Item("ss")
                    vtb.Value = lrd.Item("tb")
                    vha.Text = lrd.Item("ha")
                    vstat.Text = lrd.Item("stat")
                    vid.ReadOnly = True
                End While
            Else
                MsgBox("Data Surveyor tidak ditemukan!", vbInformation, "Pemberitahuan")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub vha_TextChanged(sender As Object, e As EventArgs) Handles vha.TextChanged
        If Val(vha.Text) >= 0 And Val(vha.Text) <= 40 Then
            vstat.Text = "DITOLAK"
        ElseIf Val(vha.Text) >= 41 And Val(vha.Text) <= 70 Then
            vstat.Text = "DIPERTIMBANGKAN"
        ElseIf Val(vha.Text) >= 71 And Val(vha.Text) <= 100 Then
            vstat.Text = "DITERIMA"
        Else
            vstat.Text = ""
        End If

    End Sub

    Private Sub vstat_TextChanged(sender As Object, e As EventArgs) Handles vstat.TextChanged

    End Sub
End Class