Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Globalization
Module ModuleConnection
    Public connection As MySqlConnection

    Public Sub conn()
        Try
            connection = New MySqlConnection
            connection.ConnectionString = "server=127.0.0.1;" _
            & "uid=root;" _
            & "pwd=s3rv3r;" _
            & "port=3306;" _
            & "database=vscyrm;"

            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub RunSql(ByVal sql As String)
        Dim cmd As New MySqlCommand
        conn()
        Try
            cmd.Connection = connection
            cmd.CommandType = Data.CommandType.Text
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            connection.Close()
            MsgBox("La Informacion ha sido Actualizada")
        Catch ex As Exception
            MsgBox("Fallo cuando se intento Actualizar Data")

        End Try
    End Sub

End Module
