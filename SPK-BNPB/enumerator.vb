Imports System.IO
Imports MySql.Data.MySqlClient
Public Class enumerator
    Dim sql As String
    Dim sql2 As String
    Dim proses As New Koneksi
    Dim tabel As DataTable
    Private Sub enumerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vtgl.Format = DateTimePickerFormat.Custom
        vtgl.CustomFormat = "yyyy-MM-dd"
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim empty =
            Me.Controls.OfType(Of TextBox)().Where(Function(txt) txt.Text.Length = 0)
        If empty.Any Then
            MsgBox("Data Surveyor tidak boleh kosong...", vbInformation)
        Else
            Try
                sql = "INSERT INTO surveyor VALUES('" & vnip.Text & "'," &
                                                    "'" & vnama.Text & "'," &
                                                    "'" & vtmp.Text & "'," &
                                                    "'" & vtgl.Text & "'," &
                                                    "'" & vjekel.Text & "'," &
                                                    "'" & valamat.Text & "'," &
                                                    "'" & vtelp.Text & "'" &
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
            sql = "SELECT * FROM surveyor WHERE nip = '" & vnip.Text & "'"
            cmd.CommandText = sql
            Dim lrd As MySqlDataReader = cmd.ExecuteReader
            If lrd.HasRows Then
                While lrd.Read()
                    vnama.Text = lrd.Item("nama")
                    vtmp.Text = lrd.Item("tempat_lahir")
                    vtgl.Text = lrd.Item("tanggal_lahir")
                    vjekel.SelectedItem = lrd.Item("jekel")
                    valamat.Text = lrd.Item("alamat")
                    vtelp.Text = lrd.Item("telepon")
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Select Case MsgBox("Apakah anda yakin ingin mengubah data ini?", MsgBoxStyle.YesNo, "Peringatan")
                Case MsgBoxResult.Yes
                    sql = "UPDATE surveyor SET nama = '" & vnama.Text & "'," &
                                                "tempat_lahir = '" & vtmp.Text & "'," &
                                                "tanggal_lahir = '" & vtgl.Text & "'," &
                                                "jekel = '" & vjekel.SelectedItem & "'," &
                                                "alamat = '" & valamat.Text & "'," &
                                                "telepon = '" & vtelp.Text & "'" &
                                        "WHERE nip = '" & vnip.Text & "'"
                    proses.ExecuteNonQuery(sql)
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
                    sql = "DELETE FROM surveyor WHERE nip = '" & vnip.Text & "'"
                    proses.ExecuteNonQuery(sql)
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

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
End Class