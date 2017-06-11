Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class InterfazEmpleados
    Private Sub InterfazEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarArea()
        CargarCargo()
        CargarHorario()
    End Sub
    Sub CargarArea()
        conn()
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        Dim sql As String

        sql = "SELECT   CONCAT(coddpto , ' - ' , departamento ) AS Departamento ,coddpto "
        sql = sql & " FROM departamento "

        da = New MySqlDataAdapter(sql, connection)
        dt = New DataTable
        da.Fill(dt)
        cmbArea.Refresh()
        cmbArea.DataSource = dt
        cmbArea.DisplayMember = "Departamento"
        cmbArea.ValueMember = "coddpto"
        connection.Close()
        da.Dispose()
    End Sub
    Sub CargarCargo()
        conn()
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        Dim sql As String

        sql = "SELECT   CONCAT(codigo , ' - ' , descripcion ) AS Cargo ,codigo "
        sql = sql & " FROM cargos "

        da = New MySqlDataAdapter(sql, connection)
        dt = New DataTable
        da.Fill(dt)
        cmbCargo.Refresh()
        cmbCargo.DataSource = dt
        cmbCargo.DisplayMember = "Cargo"
        cmbCargo.ValueMember = "codigo"
        connection.Close()
        da.Dispose()
    End Sub
    Sub CargarHorario()
        conn()
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        Dim sql As String

        sql = "SELECT id ,codigo "
        sql = sql & " FROM turno_complejo "

        da = New MySqlDataAdapter(sql, connection)
        dt = New DataTable
        da.Fill(dt)
        cmbHorario.Refresh()
        cmbHorario.DataSource = dt
        cmbHorario.DisplayMember = "Codigo"
        cmbHorario.ValueMember = "id"
        connection.Close()
        da.Dispose()
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim SqlInsert As String
        Dim Sexo As String
        Dim message As String

        Sexo = IIf(rdbFemenino.Checked = True, "F", "M")
        message = MsgBox("¿Esta Seguro de agregar la nueva informacion ?", vbYesNo + vbInformation, "Informacion")
        If message = vbNo Then
            Exit Sub
        End If
        SqlInsert = "INSERT INTO empleado ( "
        SqlInsert = SqlInsert & " cedula, "
        SqlInsert = SqlInsert & " nombre,"
        SqlInsert = SqlInsert & " apellido,"
        SqlInsert = SqlInsert & " Sexo,"
        SqlInsert = SqlInsert & " turno,"
        SqlInsert = SqlInsert & " fecha_nac,"
        SqlInsert = SqlInsert & " fecha_ingreso,"
        SqlInsert = SqlInsert & " cargo,"
        SqlInsert = SqlInsert & " dpto,"
        SqlInsert = SqlInsert & " status"
        SqlInsert = SqlInsert & " )"
        SqlInsert = SqlInsert & " 	VALUES"
        SqlInsert = SqlInsert & "   ("
        SqlInsert = SqlInsert & " '" & txtCedula.Text & "', "
        SqlInsert = SqlInsert & " '" & UCase(txtNombre.Text) & "',"
        SqlInsert = SqlInsert & " '" & UCase(txtApellido.Text) & "',"
        SqlInsert = SqlInsert & " '" & Sexo & "',"
        SqlInsert = SqlInsert & " '" & cmbHorario.Text & "',"
        SqlInsert = SqlInsert & " '" & DateValue(dtpFechaNac.Value).ToString("yyyy-MM-dd") & "',"
        SqlInsert = SqlInsert & " '" & DateValue(dtpFechaIng.Value).ToString("yyyy-MM-dd") & "',"
        SqlInsert = SqlInsert & " '" & Microsoft.VisualBasic.Left(cmbCargo.Text, 2) & "',"
        SqlInsert = SqlInsert & " '" & Microsoft.VisualBasic.Left(cmbArea.Text, 2) & "',"
        SqlInsert = SqlInsert & " 'A'"
        SqlInsert = SqlInsert & " )"
        RunSql(SqlInsert)
        limpiarfrm()
        Me.Close()
    End Sub
    Sub limpiarfrm()
        txtCedula.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        dtpFechaIng.Value = Now
        dtpFechaNac.Value = Now
    End Sub
End Class