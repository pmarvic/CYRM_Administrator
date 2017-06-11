Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class InterfazCargos
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        limpiarfrm()
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim SqlInsert As String
        Dim message As String
        message = MsgBox("¿Esta Seguro de agregar la nueva informacion ?", vbYesNo + vbInformation, "Informacion")
        If message = vbNo Then
            Exit Sub
        End If
        SqlInsert = "INSERT INTO cargos ( "
        SqlInsert = SqlInsert & " codigo, "
        SqlInsert = SqlInsert & " descripcion"
        SqlInsert = SqlInsert & " )"
        SqlInsert = SqlInsert & " 	VALUES"
        SqlInsert = SqlInsert & "   ("
        SqlInsert = SqlInsert & " '" & txtCodigo.Text & "', "
        SqlInsert = SqlInsert & " '" & UCase(txtDescripcion.Text) & "' "
        SqlInsert = SqlInsert & " )"
        RunSql(SqlInsert)
        limpiarfrm()
        Me.Close()
    End Sub
    Sub limpiarfrm()
        txtCodigo.Text = ""
        txtDescripcion.Text = ""
    End Sub

    Private Sub InterfazCargos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class