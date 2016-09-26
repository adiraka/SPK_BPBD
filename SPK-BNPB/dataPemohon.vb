Imports System.IO
Imports MySql.Data.MySqlClient
Public Class dataPemohon
    Dim sql As String
    Dim sql2 As String
    Dim proses As New Koneksi
    Dim tabel As DataTable
    Private Sub dataPemohon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Enabled = False
        Button3.Enabled = False
        vtgllhr.Format = DateTimePickerFormat.Custom
        vtgllhr.CustomFormat = "yyyy-MM-dd"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim empty =
            Me.Controls.OfType(Of TextBox)().Where(Function(txt) txt.Text.Length = 0)
        If empty.Any Then
            MsgBox("Data pemohon tidak boleh kosong...", vbInformation)
        Else
            Try
                sql = "INSERT INTO pemohon VALUES('" & vnik.Text & "'," &
                                                    "'" & vnama.Text & "'," &
                                                    "'" & vtmpt.Text & "'," &
                                                    "'" & vtgllhr.Text & "'," &
                                                    "'" & vjekel.Text & "'," &
                                                    "'" & valamat.Text & "'," &
                                                    "'" & vrt.Text & "'," &
                                                    "'" & vrw.Text & "'," &
                                                    "'" & vkel.Text & "'," &
                                                    "'" & vkec.Text & "'," &
                                                    "'" & vagama.Text & "'," &
                                                    "'" & vgoldar.Text & "'," &
                                                    "'" & vstat.Text & "'," &
                                                    "'" & vpekerjaan.Text & "'," &
                                                    "'" & vkwn.Text & "'" &
                                                    ")"
                proses.ExecuteNonQuery(sql)
                Dim a As Control
                For Each a In Me.Controls
                    If TypeOf a Is TextBox Or TypeOf a Is ComboBox Then
                        a.Text = Nothing
                    End If
                Next
                valamat.Text = Nothing
                MsgBox("Data berhasil disimpan", vbInformation)
            Catch ex As Exception
                MsgBox("Telah terjadi kesalahan dalam pengisian data..." + ex.ToString, vbInformation)
            End Try
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim con As New MySqlConnection
            Dim cmd As New MySqlCommand
            con = New MySqlConnection("server=localhost;" &
                                     "user id=root;" &
                                     "password=;" &
                                     "database=dbspkbpbd;" &
                                     "character set=utf8;")
            con.Open()
            cmd.Connection = con
            sql = "SELECT * FROM pemohon WHERE nik = '" & vnik.Text & "'"
            cmd.CommandText = sql
            Dim lrd As MySqlDataReader = cmd.ExecuteReader
            If lrd.HasRows Then
                While lrd.Read()
                    vnama.Text = lrd.Item("nama")
                    vtmpt.Text = lrd.Item("tempat_lahir")
                    vtgllhr.Text = lrd.Item("tgl_lahir")
                    vjekel.SelectedText = lrd.Item("jekel")
                    valamat.Text = lrd.Item("alamat")
                    vrt.Text = lrd.Item("rt")
                    vrw.Text = lrd.Item("rw")
                    vkec.Text = lrd.Item("kec")
                    vkel.Text = lrd.Item("kel")
                    vagama.Text = lrd.Item("agama")
                    vgoldar.Text = lrd.Item("goldar")
                    vstat.Text = lrd.Item("status")
                    vpekerjaan.Text = lrd.Item("pekerjaan")
                    vkwn.Text = lrd.Item("kewarganegaraan")
                    vnik.ReadOnly = True
                    Button1.Enabled = False
                    Button2.Enabled = True
                    Button3.Enabled = True
                    Button4.Text = "BATAL"
                End While
            Else
                MsgBox("Data Pemohon tidak ditemukan!", vbInformation, "Pemberitahuan")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Select Case MsgBox("Apakah anda yakin ingin mengubah data ini?", MsgBoxStyle.YesNo, "Peringatan")
                Case MsgBoxResult.Yes
                    sql = "UPDATE pemohon SET nama = '" & vnama.Text & "'," &
                                                "tempat_lahir = '" & vtmpt.Text & "'," &
                                                "tgl_lahir = '" & vtgllhr.Text & "'," &
                                                "jekel = '" & vjekel.Text & "'," &
                                                "alamat = '" & valamat.Text & "'," &
                                                "rt = '" & vrt.Text & "'," &
                                                "rw = '" & vrw.Text & "'," &
                                                "kel = '" & vkel.Text & "'," &
                                                "kec = '" & vkec.Text & "'," &
                                                "agama = '" & vagama.Text & "'," &
                                                "goldar = '" & vgoldar.Text & "'," &
                                                "status = '" & vstat.Text & "'," &
                                                "pekerjaan = '" & vpekerjaan.Text & "'," &
                                                "kewarganegaraan = '" & vkwn.Text & "'" &
                                        "WHERE nik = '" & vnik.Text & "'"
                    proses.ExecuteNonQuery(sql)
                    Dim a As Control
                    For Each a In Me.Controls
                        If TypeOf a Is TextBox Or TypeOf a Is ComboBox Then
                            a.Text = Nothing
                        End If
                    Next
                    valamat.Text = Nothing
                    vnik.ReadOnly = False
                    Button1.Enabled = True
                    Button2.Enabled = False
                    Button3.Enabled = False
                    MsgBox("Data berhasil diubah", vbInformation, "Pemberitahuan")
                Case MsgBoxResult.No
                    Return
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Select Case MsgBox("Apakah anda yakin ingin menghapus data ini?", MsgBoxStyle.YesNo, "Peringatan")
                Case MsgBoxResult.Yes
                    sql = "DELETE FROM pemohon WHERE nik = '" & vnik.Text & "'"
                    proses.ExecuteNonQuery(sql)
                    Dim a As Control
                    For Each a In Me.Controls
                        If TypeOf a Is TextBox Or TypeOf a Is ComboBox Then
                            a.Text = Nothing
                        End If
                    Next
                    valamat.Text = Nothing
                    vnik.ReadOnly = False
                    Button1.Enabled = True
                    Button2.Enabled = False
                    Button3.Enabled = False
                    MsgBox("Data berhasil dihapus", vbInformation)
                Case MsgBoxResult.No
                    Return
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a As Control
        For Each a In Me.Controls
            If TypeOf a Is TextBox Or TypeOf a Is ComboBox Then
                a.Text = Nothing
            End If
        Next
        valamat.Text = Nothing
        vnik.ReadOnly = False
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Text = "RESET"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
End Class