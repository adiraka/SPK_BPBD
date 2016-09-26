Imports System.IO
Imports MySql.Data.MySqlClient
Public Class admin
    Dim sql As String
    Dim sql2 As String
    Dim proses As New Koneksi
    Dim tabel As DataTable
    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vtgl.Format = DateTimePickerFormat.Custom
        vtgl.CustomFormat = "yyyy-MM-dd"
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim empty =
            Me.Controls.OfType(Of TextBox)().Where(Function(txt) txt.Text.Length = 0)
            If empty.Any Then
                MsgBox("Data Admin tidak boleh kosong...", vbInformation)
            Else
                Try
                    sql = "INSERT INTO user_akun VALUES('" & vnip.Text & "'," &
                                                        "'" & vuser.Text & "'," &
                                                        "'" & vpass.Text & "'," &
                                                        "'admin'," &
                                                        "'1'" &
                                                        ")"
                    sql2 = "INSERT INTO user_info VALUES('" & vnip.Text & "'," &
                                                    "'" & vnama.Text & "'," &
                                                    "'" & vtmp.Text & "'," &
                                                    "'" & vtgl.Text & "'," &
                                                    "'" & vjekel.Text & "'," &
                                                    "'" & valamat.Text & "'," &
                                                    "'" & vagama.Text & "'," &
                                                    "'" & vtelepon.Text & "'," &
                                                    "'" & vjabatan.Text & "'" &
                                                    ")"
                    proses.ExecuteNonQuery(sql & ";" & sql2)
                    Dim a As Control
                    For Each a In Me.Controls
                        If TypeOf a Is TextBox Or TypeOf a Is ComboBox Then
                            a.Text = Nothing
                        End If
                    Next
                    valamat.Text = Nothing
                    MsgBox("Data berhasil disimpan", vbInformation)
                Catch ex As Exception
                    MsgBox("Telah terjadi kesalahan dalam pengisian data..." + ex.Message, vbInformation)
                End Try
            End If
        Catch ex As Exception

        End Try
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
            sql = "SELECT user_akun.nip, user_akun.username, user_akun.password, user_info.nama, user_info.tmp_lhr, user_info.tgl_lhr," &
                    "user_info.tgl_lhr, user_info.jekel, user_info.alamat, user_info.agama, user_info.telepon, user_info.jabatan " &
                    "FROM user_akun, user_info " &
                    "WHERE user_akun.nip = user_info.nip " &
                    "AND user_akun.nip = '" & vnip.Text & "'"
            cmd.CommandText = sql
            Dim lrd As MySqlDataReader = cmd.ExecuteReader
            If lrd.HasRows Then
                While lrd.Read()
                    vnama.Text = lrd.Item("nama")
                    vuser.Text = lrd.Item("username")
                    vpass.Text = lrd.Item("password")
                    vnama.Text = lrd.Item("nama")
                    vtmp.Text = lrd.Item("tmp_lhr")
                    vtgl.Text = lrd.Item("tgl_lhr")
                    vjekel.SelectedItem = lrd.Item("jekel")
                    valamat.Text = lrd.Item("alamat")
                    vagama.SelectedItem = lrd.Item("agama")
                    vtelepon.Text = lrd.Item("telepon")
                    vjabatan.Text = lrd.Item("jabatan")
                    vnip.ReadOnly = True
                    Button1.Enabled = False
                    Button2.Enabled = True
                    Button3.Enabled = True
                    Button4.Text = "BATAL"
                End While
            Else
                MsgBox("Data Surveyor tidak ditemukan!", vbInformation, "Pemberitahuan")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a As Control
        For Each a In Me.Controls
            If TypeOf a Is TextBox Or TypeOf a Is ComboBox Then
                a.Text = Nothing
            End If
        Next
        valamat.Text = Nothing
        vnip.ReadOnly = False
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Text = "RESET"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Select Case MsgBox("Apakah anda yakin ingin mengubah data ini?", MsgBoxStyle.YesNo, "Peringatan")
                Case MsgBoxResult.Yes
                    sql = "UPDATE user_akun SET username = '" & vuser.Text & "'," &
                                                "password = '" & vpass.Text & "' " &
                                            "WHERE nip = '" & vnip.Text & "'"
                    sql2 = "UPDATE user_info SET nama = '" & vnama.Text & "'," &
                                                "tmp_lhr = '" & vtmp.Text & "'," &
                                                "tgl_lhr = '" & vtgl.Text & "'," &
                                                "jekel = '" & vjekel.SelectedItem & "'," &
                                                "alamat = '" & valamat.Text & "'," &
                                                "agama = '" & vagama.Text & "'," &
                                                "telepon = '" & vtelepon.Text & "'," &
                                                "jabatan = '" & vjabatan.Text & "' " &
                                        "WHERE nip = '" & vnip.Text & "'"
                    proses.ExecuteNonQuery(sql & ";" & sql2)
                    Dim a As Control
                    For Each a In Me.Controls
                        If TypeOf a Is TextBox Or TypeOf a Is ComboBox Then
                            a.Text = Nothing
                        End If
                    Next
                    valamat.Text = Nothing
                    vnip.ReadOnly = False
                    Button1.Enabled = True
                    Button2.Enabled = False
                    Button3.Enabled = False
                    MsgBox("Data berhasil diubah", vbInformation, "Pemberitahuan")
                Case MsgBoxResult.No
                    Return
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Select Case MsgBox("Apakah anda yakin ingin menghapus data ini?", MsgBoxStyle.YesNo, "Peringatan")
                Case MsgBoxResult.Yes
                    sql = "DELETE FROM user_akun WHERE nip = '" & vnip.Text & "'"
                    sql2 = "DELETE FROM user_info WHERE nip = '" & vnip.Text & "'"
                    proses.ExecuteNonQuery(sql & ";" & sql2)
                    Dim a As Control
                    For Each a In Me.Controls
                        If TypeOf a Is TextBox Or TypeOf a Is ComboBox Then
                            a.Text = Nothing
                        End If
                    Next
                    valamat.Text = Nothing
                    vnip.ReadOnly = False
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class