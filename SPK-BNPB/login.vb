Imports MySql.Data.MySqlClient
Public Class login

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vuname.AutoSize = False
        vuname.Height = 30
        vpass.AutoSize = False
        vpass.Height = 30
    End Sub

    Private Sub blogin_Click(sender As Object, e As EventArgs) Handles blogin.Click
        Dim conn As MySqlConnection

        conn = New MySqlConnection

        conn.ConnectionString = "server=localhost; uid=root; password=; database=dbspkbpbd;"

        Try
            conn.Open()
        Catch myerror As MySqlException
            MsgBox("Kesalahan dalam koneksi" + myerror.Message)
        End Try

        Dim myAdapter As New MySqlDataAdapter

        Dim sqlQuery = "SELECT * FROM user_akun WHERE username = '" + vuname.Text + "' AND password = '" + vpass.Text + "'"

        Dim myCommand As New MySqlCommand

        myCommand.Connection = conn
        myCommand.CommandText = sqlQuery
        myAdapter.SelectCommand = myCommand

        Dim myData As MySqlDataReader

        myData = myCommand.ExecuteReader()

        If myData.HasRows = 0 Then
            MsgBox("Username dan Password Salah!", MsgBoxStyle.Exclamation, "Error Login")
        Else
            MsgBox("Selamat Datang " + vuname.Text + "!", MsgBoxStyle.Information, "Successfull Login")
            main.Show()
            Me.Hide()
        End If
    End Sub
End Class
