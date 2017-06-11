Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class frmCargos
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    Sub LoadCargos()
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        Dim sql As String

        Try
            conn()
            sql = "SELECT  codigo, "
            sql = sql & "   Descripcion "
            sql = sql & " FROM cargos "

            da = New MySqlDataAdapter(sql, connection)
            dt = New DataTable
            da.Fill(dt)
            dgvCargos.DataSource = dt
            connection.Close()
            da.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmCargos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCargos()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim row As Integer
        Dim codigo As String
        Dim descripcion As String
        Dim SqlUpdate As String
        Try
            ' Get Value al Hacer Click en DataGridView
            row = dgvCargos.CurrentRow.Index

            codigo = dgvCargos(0, row).Value
            descripcion = dgvCargos(1, row).Value

            ' Update Sql

            SqlUpdate = " UPDATE cargos SET "
            SqlUpdate = SqlUpdate & " descripcion = '" & descripcion & "'"
            SqlUpdate = SqlUpdate & " WHERE  codigo = '" & codigo & "'"
            RunSql(SqlUpdate)
            LoadCargos()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim SqlDelete As String
        Dim row As Integer
        Dim codigo As String

        Try
            ' Get Value al Hacer Click en DataGridView
            row = dgvCargos.CurrentRow.Index
            codigo = dgvCargos(0, row).Value

            Dim message As String
            message = MsgBox("¿ Esta seguro de borrar este registro ? ", vbYesNo + vbInformation, "Aviso")
            If message = vbNo Then
                Exit Sub
            End If
            SqlDelete = "DELETE FROM  cargos WHERE codigo = '" & codigo & "'"
            RunSql(SqlDelete)
            LoadCargos()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim frmRegCargo As New InterfazCargos
        frmRegCargo.ShowDialog()
    End Sub
End Class