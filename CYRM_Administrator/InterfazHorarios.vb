Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class InterfazHorarios
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
        SqlInsert = "INSERT INTO turno_complejo ( "
        SqlInsert = SqlInsert & " codigo, "
        SqlInsert = SqlInsert & " lun11,"
        SqlInsert = SqlInsert & " lun12,"
        SqlInsert = SqlInsert & " lun21,"
        SqlInsert = SqlInsert & " lun22,"
        SqlInsert = SqlInsert & " mar11,"
        SqlInsert = SqlInsert & " mar12,"
        SqlInsert = SqlInsert & " mar21,"
        SqlInsert = SqlInsert & " mar22,"
        SqlInsert = SqlInsert & " mie11,"
        SqlInsert = SqlInsert & " mie12,"
        SqlInsert = SqlInsert & " mie21,"
        SqlInsert = SqlInsert & " mie22,"
        SqlInsert = SqlInsert & " jue11,"
        SqlInsert = SqlInsert & " jue12,"
        SqlInsert = SqlInsert & " jue21,"
        SqlInsert = SqlInsert & " jue22,"
        SqlInsert = SqlInsert & " vie11,"
        SqlInsert = SqlInsert & " vie12,"
        SqlInsert = SqlInsert & " vie21,"
        SqlInsert = SqlInsert & " vie22,"
        SqlInsert = SqlInsert & " sab11,"
        SqlInsert = SqlInsert & " sab12,"
        SqlInsert = SqlInsert & " sab21,"
        SqlInsert = SqlInsert & " sab22,"
        SqlInsert = SqlInsert & " dom11,"
        SqlInsert = SqlInsert & " dom12,"
        SqlInsert = SqlInsert & " dom21,"
        SqlInsert = SqlInsert & " dom22"
        SqlInsert = SqlInsert & " )"
        SqlInsert = SqlInsert & " 	VALUES"
        SqlInsert = SqlInsert & "   ("
        SqlInsert = SqlInsert & " '" & txtCodHor.Text & "', "
        SqlInsert = SqlInsert & " '" & txtLUN11.Text & "', "
        SqlInsert = SqlInsert & " '" & txtLUN12.Text & "', "
        SqlInsert = SqlInsert & " '" & txtLUN21.Text & "', "
        SqlInsert = SqlInsert & " '" & txtLUN22.Text & "', "
        SqlInsert = SqlInsert & " '" & txtMAR11.Text & "', "
        SqlInsert = SqlInsert & " '" & txtMAR12.Text & "', "
        SqlInsert = SqlInsert & " '" & txtMAR21.Text & "', "
        SqlInsert = SqlInsert & " '" & txtMAR22.Text & "', "
        SqlInsert = SqlInsert & " '" & txtMIE11.Text & "', "
        SqlInsert = SqlInsert & " '" & txtMIE12.Text & "', "
        SqlInsert = SqlInsert & " '" & txtMIE21.Text & "', "
        SqlInsert = SqlInsert & " '" & txtMIE22.Text & "', "
        SqlInsert = SqlInsert & " '" & txtJUE11.Text & "', "
        SqlInsert = SqlInsert & " '" & txtJUE12.Text & "', "
        SqlInsert = SqlInsert & " '" & txtJUE21.Text & "', "
        SqlInsert = SqlInsert & " '" & txtJUE22.Text & "', "
        SqlInsert = SqlInsert & " '" & txtVIE11.Text & "', "
        SqlInsert = SqlInsert & " '" & txtVIE12.Text & "',"
        SqlInsert = SqlInsert & " '" & txtVIE21.Text & "', "
        SqlInsert = SqlInsert & " '" & txtVIE22.Text & "', "
        SqlInsert = SqlInsert & " '" & txtSAB11.Text & "', "
        SqlInsert = SqlInsert & " '" & txtSAB12.Text & "', "
        SqlInsert = SqlInsert & " '" & txtSAB21.Text & "', "
        SqlInsert = SqlInsert & " '" & txtSAB22.Text & "', "
        SqlInsert = SqlInsert & " '" & txtDOM11.Text & "', "
        SqlInsert = SqlInsert & " '" & txtDOM12.Text & "', "
        SqlInsert = SqlInsert & " '" & txtDOM21.Text & "', "
        SqlInsert = SqlInsert & " '" & txtDOM22.Text & "' "
        SqlInsert = SqlInsert & " )"
        RunSql(SqlInsert)
        limpiarfrm()
        Me.Close()

    End Sub

    Sub limpiarfrm()
        txtCodHor.Text = ""
        txtLUN11.Text = "00:00"
        txtLUN12.Text = "00:00"
        txtLUN21.Text = "00:00"
        txtLUN22.Text = "00:00"
        txtMAR11.Text = "00:00"
        txtMAR12.Text = "00:00"
        txtMAR21.Text = "00:00"
        txtMAR22.Text = "00:00"
        txtMIE11.Text = "00:00"
        txtMIE12.Text = "00:00"
        txtMIE21.Text = "00:00"
        txtMIE22.Text = "00:00"
        txtJUE11.Text = "00:00"
        txtJUE12.Text = "00:00"
        txtJUE21.Text = "00:00"
        txtJUE22.Text = "00:00"
        txtVIE11.Text = "00:00"
        txtVIE12.Text = "00:00"
        txtVIE21.Text = "00:00"
        txtVIE22.Text = "00:00"
        txtSAB11.Text = "00:00"
        txtSAB12.Text = "00:00"
        txtSAB21.Text = "00:00"
        txtSAB22.Text = "00:00"
        txtDOM11.Text = "00:00"
        txtDOM12.Text = "00:00"
        txtDOM21.Text = "00:00"
        txtDOM22.Text = "00:00"
    End Sub
End Class