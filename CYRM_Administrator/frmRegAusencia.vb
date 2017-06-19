Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class frmRegAusencia
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmRegAusencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarMotivos()
    End Sub
    Sub CargarMotivos()
        conn()
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        Dim sql As String

        sql = "SELECT id ,codAusencia,DesAusencia"
        sql = sql & " FROM tiposausencias "

        da = New MySqlDataAdapter(sql, connection)
        dt = New DataTable
        da.Fill(dt)
        cmbMotivo.Refresh()
        cmbMotivo.DataSource = dt
        cmbMotivo.DisplayMember = "DesAusencia"
        cmbMotivo.ValueMember = "id"
        connection.Close()
        da.Dispose()
    End Sub
End Class