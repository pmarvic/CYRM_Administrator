Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports Microsoft.Reporting.WinForms

Public Class frmEmpleados
    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmpleados()
    End Sub
    Sub LoadEmpleados()
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        Dim sql As String

        Try
            conn()
            sql = "SELECT cedula, "
            sql = sql & " nombre, "
            sql = sql & " apellido,"
            sql = sql & " sexo,"
            sql = sql & " turno,"
            sql = sql & " fecha_nac,"
            sql = sql & " Fecha_ingreso,"
            sql = sql & " cargo as Cargo,"
            sql = sql & " dpto As Area, "
            sql = sql & " status As Estado "
            sql = sql & " FROM "
            sql = sql & " empleado "

            da = New MySqlDataAdapter(sql, connection)
            dt = New DataTable
            da.Fill(dt)
            dgvEmpleados.DataSource = dt
            connection.Close()
            da.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim frmRegEmp As New InterfazEmpleados
        frmRegEmp.ShowDialog()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim row As Integer
        Dim codigo As String ' es la Cedula
        Dim nombre As String
        Dim apellido As String
        Dim Sexo As String
        Dim Turno As String
        Dim FechaNac As String
        Dim FechaIng As String
        Dim Cargo As String
        Dim Area As String
        Dim Estado As String
        Dim SqlUpdate As String

        Try
            ' Get Value al Hacer Click en DataGridView
            row = dgvEmpleados.CurrentRow.Index

            codigo = dgvEmpleados(0, row).Value
            nombre = dgvEmpleados(1, row).Value
            apellido = dgvEmpleados(2, row).Value
            Sexo = dgvEmpleados(3, row).Value
            Turno = dgvEmpleados(4, row).Value
            FechaNac = dgvEmpleados(5, row).Value
            FechaIng = dgvEmpleados(6, row).Value
            Cargo = dgvEmpleados(7, row).Value
            Area = dgvEmpleados(8, row).Value
            Estado = dgvEmpleados(9, row).Value

            ' Update Sql

            SqlUpdate = " UPDATE empleado SET "
            SqlUpdate = SqlUpdate & " nombre = '" & nombre & "',"
            SqlUpdate = SqlUpdate & " apellido = '" & apellido & "',"
            SqlUpdate = SqlUpdate & " Sexo = '" & Sexo & "',"
            SqlUpdate = SqlUpdate & " turno = '" & Turno & "',"
            SqlUpdate = SqlUpdate & " fecha_nac = '" & DateValue(FechaNac).ToString("yyyy-MM-dd") & "',"
            SqlUpdate = SqlUpdate & " fecha_ingreso = '" & DateValue(FechaIng).ToString("yyyy-MM-dd") & "',"
            SqlUpdate = SqlUpdate & " cargo = '" & Cargo & "',"
            SqlUpdate = SqlUpdate & " dpto = '" & Area & "',"
            SqlUpdate = SqlUpdate & " status = '" & Estado & "'"
            SqlUpdate = SqlUpdate & " WHERE  cedula = '" & codigo & "'"

            RunSql(SqlUpdate)
            LoadEmpleados()
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
            row = dgvEmpleados.CurrentRow.Index
            codigo = dgvEmpleados(0, row).Value

            Dim message As String
            message = MsgBox("¿ Esta seguro de borrar este registro ? ", vbYesNo + vbInformation, "Aviso")
            If message = vbNo Then
                Exit Sub
            End If
            SqlDelete = "DELETE FROM  empleado WHERE cedula = '" & codigo & "'"
            RunSql(SqlDelete)
            LoadEmpleados()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim Reporte As New frmReports
        Dim ds As Data.DataSet
        Dim da As MySqlDataAdapter
        Dim sql As String
        Try
            conn()
            sql = "SELECT "
            sql = sql & " cedula as Cedula,"
            sql = sql & " nombre as Nombre,"
            sql = sql & " apellido as Apellido,"
            sql = sql & " fecha_nac as Fecha_Nac,"
            sql = sql & " f_age(fecha_nac) as Edad,"
            sql = sql & " Fecha_ingreso as Fecha_Ingreso,"
            sql = sql & " f_Anos(Fecha_ingreso) as Anos_Trabajo,"
            sql = sql & " departamento.departamento as Area,"
            sql = sql & " cargos.Descripcion As Departamento ,"
            sql = sql & " empleado.Sexo As Sexo "
            sql = sql & " FROM	empleado "
            sql = sql & " INNER JOIN departamento ON empleado.dpto = departamento.coddpto "
            sql = sql & " INNER JOIN cargos ON empleado.cargo = cargos.codigo"
            sql = sql & " WHERE status ='A' "
            sql = sql & " ORDER BY cargos.Descripcion"

            da = New MySqlDataAdapter(sql, connection)
            'dt = New DataTable
            ds = New Data.DataSet

            da.Fill(ds)

            connection.Close()
            da.Dispose()

            Reporte.ReportViewerVista.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            Reporte.ReportViewerVista.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\rptEmpleados.rdlc"

            Reporte.ReportViewerVista.LocalReport.DataSources.Clear()
            Reporte.ReportViewerVista.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))

            Reporte.ReportViewerVista.DocumentMapCollapsed = True
            Reporte.ReportViewerVista.RefreshReport()
            Reporte.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        LoadEmpleados()
    End Sub
End Class