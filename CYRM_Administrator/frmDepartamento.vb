Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class frmDepartamento
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim frmRegDpto As New InterfazDepartamento
        frmRegDpto.ShowDialog()
    End Sub
    Sub LoadDepartamento()
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        Dim sql As String
        Try
            conn()
            sql = "SELECT  coddpto As Codigo, "
            sql = sql & "   departamento as Descripcion"
            sql = sql & " FROM departamento "

            da = New MySqlDataAdapter(sql, connection)
            dt = New DataTable
            da.Fill(dt)
            dgvDepartamento.DataSource = dt
            connection.Close()
            da.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmDepartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDepartamento()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim row As Integer
        Dim codigo As String
        Dim descripcion As String
        Dim SqlUpdate As String
        Try
            ' Get Value al Hacer Click en DataGridView
            row = dgvDepartamento.CurrentRow.Index

            codigo = dgvDepartamento(0, row).Value
            descripcion = dgvDepartamento(1, row).Value

            ' Update Sql

            SqlUpdate = " UPDATE departamento SET "
            SqlUpdate = SqlUpdate & " departamento = '" & descripcion & "'"
            SqlUpdate = SqlUpdate & " WHERE  coddpto = '" & codigo & "'"
            RunSql(SqlUpdate)
            LoadDepartamento()
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
            row = dgvDepartamento.CurrentRow.Index

            codigo = dgvDepartamento(0, row).Value

            Dim message As String
            message = MsgBox("¿ Esta seguro de borrar este registro ? ", vbYesNo + vbInformation, "Aviso")
            If message = vbNo Then
                Exit Sub
            End If
            SqlDelete = "DELETE FROM  departamento WHERE coddpto = '" & codigo & "'"
            RunSql(SqlDelete)
            LoadDepartamento()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class