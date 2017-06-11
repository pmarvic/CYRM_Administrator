Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class InterfazDepartamento
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        limpiarfrm()
        Me.Close()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim SqlInsert As String
        Dim message As String
        message = MsgBox("¿Esta Seguro de agregar la nueva informacion ?", vbYesNo + vbInformation, "Informacion")
        If message = vbNo Then
            Exit Sub
        End If
        SqlInsert = "INSERT INTO departamento ( "
        SqlInsert = SqlInsert & " coddpto, "
        SqlInsert = SqlInsert & " departamento"
        SqlInsert = SqlInsert & " )"
        SqlInsert = SqlInsert & " 	VALUES"
        SqlInsert = SqlInsert & "   ("
        SqlInsert = SqlInsert & " '" & txtcodigo.Text & "', "
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
End Class