Imports MySql.Data.MySqlClient

Public Class login
    Private Sub blogin_Click(sender As Object, e As EventArgs) Handles blogin.Click

        Dim conn As MySqlConnection

        conn = New MySqlConnection

        conn.ConnectionString = "server=localhost; uid=root; password=administrator; database=dbspkbpbd;"

        Try
            conn.Open()
        Catch myerror As MySqlException
            MsgBox("Kesalahan dalam koneksi")
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