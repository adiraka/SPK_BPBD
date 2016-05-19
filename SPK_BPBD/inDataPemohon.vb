Imports System.IO
Imports MySql.Data.MySqlClient

Public Class inDataPemohon
    Dim sql As String
    Dim proses As New Koneksi
    Dim tabel As DataTable
    Private Sub inDataPemohon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vtgllhr.Format = DateTimePickerFormat.Custom
        vtgllhr.CustomFormat = "yyyy-MM-dd"
    End Sub

    Private Sub bSimpan_Click(sender As Object, e As EventArgs) Handles bSimpan.Click
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
                                                    "'" & vkwn.Text & "'," &
                                                    "''" &
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
                MsgBox("Telah terjadi kesalahan dalam pengisian data...", vbInformation)
            End Try
        End If

        'Dim fStream As FileStream
        'Dim myPath As String = AppDomain.CurrentDomain.BaseDirectory()
        'Dim foto As String = myPath & "img\foto\"
        'PictureBox1.Image = Image.FromFile(foto & "zxc.png")
    End Sub

    Private Sub bBatal_Click(sender As Object, e As EventArgs) Handles bBatal.Click
        Me.Close()
    End Sub

    Private Sub bData_Click(sender As Object, e As EventArgs) Handles bData.Click
        Dim NewMDIChild As New viDataPemohon()
        NewMDIChild.MdiParent = main
        NewMDIChild.Show()
    End Sub
End Class