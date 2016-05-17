Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Koneksi
    Protected SQL As String
    Protected Cn As New MySqlConnection
    Protected Cmd As New MySql.Data.MySqlClient.MySqlCommand
    Protected Da As New MySql.Data.MySqlClient.MySqlDataAdapter
    Protected Ds As New DataSet
    Protected Dt As DataTable
    Public Function OpenConn() As Boolean
        Try
            Cn = New MySqlConnection("server=localhost;" &
                                     "user id=root;" &
                                     "password=administrator;" &
                                     "database=dbspkbpbd;" &
                                     "character set=utf8;")
            Cn.Open()
        Catch ex As Exception

        End Try
        If Cn.State <> ConnectionState.Open Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Sub CloseConn()
        If Not IsNothing(Cn) Then
            Cn.Close()
            Cn = Nothing
        End If
    End Sub
    Public Function ExecuteQuery(ByVal Query As String) As DataTable
        Try
            If Not OpenConn() Then
                Return Nothing
                Exit Function
            End If
            Cmd = New MySql.Data.MySqlClient.MySqlCommand(Query, Cn)
            Da = New MySql.Data.MySqlClient.MySqlDataAdapter
            Da.SelectCommand = Cmd
            Ds = New Data.DataSet
            Da.Fill(Ds)
            Dt = Ds.Tables(0)
            Return Dt
            Dt = Nothing
            Ds = Nothing
            Da = Nothing
            Cmd = Nothing
            CloseConn()
        Catch ex As Exception
            MsgBox("Terjadi Keasalahan dalam Pemanggilan Data : ", vbInformation)
        End Try
    End Function
    Public Sub ExecuteNonQuery(ByVal Query As String)
        If Not OpenConn() Then
            Exit Sub
        End If
        Cmd = New MySql.Data.MySqlClient.MySqlCommand
        Cmd.Connection = Cn
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = Query
        Cmd.ExecuteNonQuery()
        Cmd = Nothing
        CloseConn()
    End Sub
End Class
