Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class frmSeguridad
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim frmRegUser As New InterfazSeguridad
        frmRegUser.ShowDialog()
    End Sub
    Sub LoadUsuarios()
        conn()
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        Dim sql As String

        sql = "SELECT usuarios.user As Usuario ,"
        sql = sql & " usuarios.pass as Contraseña ,"
        sql = sql & " usuarios.report as Reportes,"
        sql = sql & " usuarios.exportar as Exportar,"
        sql = sql & " usuarios.admin as Administrar,"
        sql = sql & " usuarios.importar as Importar ,"
        sql = sql & " usuarios.novedad as Novedad "
        sql = sql & " FROM usuarios "

        da = New MySqlDataAdapter(sql, connection)
        dt = New DataTable
        da.Fill(dt)
        dgvSeguridad.DataSource = dt
        connection.Close()
        da.Dispose()

    End Sub

    Private Sub frmSeguridad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsuarios()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim row As Integer
        Dim codigo As String
        Dim clave As String
        Dim Report As String
        Dim Export As String
        Dim Import As String
        Dim Novedad As String
        Dim Admin As String

        Dim SqlUpdate As String

        ' Get Value al Hacer Click en DataGridView
        row = dgvSeguridad.CurrentRow.Index

        codigo = dgvSeguridad(0, row).Value
        Clave = dgvSeguridad(1, row).Value
        Report = dgvSeguridad(2, row).Value
        Export = dgvSeguridad(3, row).Value
        Import = dgvSeguridad(3, row).Value
        Novedad = dgvSeguridad(3, row).Value
        Admin = dgvSeguridad(4, row).Value
        ' Update Sql

        SqlUpdate = " UPDATE usuarios SET "
        SqlUpdate = SqlUpdate & " pass = '" & clave & "',"
        SqlUpdate = SqlUpdate & " report = '" & Report & "',"
        SqlUpdate = SqlUpdate & " exportar = '" & Export & "',"
        SqlUpdate = SqlUpdate & " admin = '" & Admin & "',"
        SqlUpdate = SqlUpdate & " importar = '" & Import & "',"
        SqlUpdate = SqlUpdate & " novedad = '" & Novedad & "'"
        SqlUpdate = SqlUpdate & " WHERE  user = '" & codigo & "'"
        RunSql(SqlUpdate)
        LoadUsuarios()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim SqlDelete As String
        Dim row As Integer
        Dim codigo As String

        ' Get Value al Hacer Click en DataGridView
        row = dgvSeguridad.CurrentRow.Index

        codigo = dgvSeguridad(0, row).Value

        Dim message As String
        message = MsgBox("¿ Esta seguro de borrar este registro ? ", vbYesNo + vbInformation, "Aviso")
        If message = vbNo Then
            Exit Sub
        End If
        SqlDelete = "DELETE FROM  usuarios WHERE user = '" & codigo & "'"
        RunSql(SqlDelete)
        LoadUsuarios()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        LoadUsuarios()
    End Sub
End Class