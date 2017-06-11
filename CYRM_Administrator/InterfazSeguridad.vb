Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class InterfazSeguridad
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        limpiarfrm()
        Me.Close()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim SqlInsert As String
        Dim message As String
        Try
            message = MsgBox("¿Esta Seguro de agregar la nueva informacion ?", vbYesNo + vbInformation, "Informacion")
            If message = vbNo Then
                Exit Sub
            End If
            SqlInsert = "INSERT INTO usuarios ( "
            SqlInsert = SqlInsert & " user, "
            SqlInsert = SqlInsert & " pass,"
            SqlInsert = SqlInsert & " report,"
            SqlInsert = SqlInsert & " exportar,"
            SqlInsert = SqlInsert & " admin"
            SqlInsert = SqlInsert & " )"
            SqlInsert = SqlInsert & " 	VALUES"
            SqlInsert = SqlInsert & "   ("
            SqlInsert = SqlInsert & " '" & UCase(txtUsuario.Text) & "', "
            SqlInsert = SqlInsert & " '" & UCase(txtContraseña.Text) & "',"
            SqlInsert = SqlInsert & " '" & IIf(chkReportes.Checked = True, 1, 0) & "',"
            SqlInsert = SqlInsert & " '" & IIf(chkExportar.Checked = True, 1, 0) & "',"
            SqlInsert = SqlInsert & " '" & IIf(chkAdministrar.Checked = True, 1, 0) & "' "
            SqlInsert = SqlInsert & " )"
            RunSql(SqlInsert)

            limpiarfrm()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub limpiarfrm()
        txtUsuario.Text = ""
        txtContraseña.Text = ""
    End Sub
End Class