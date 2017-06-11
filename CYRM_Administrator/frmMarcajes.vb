Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class frmMarcajes
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmMarcajes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMarcajes()
    End Sub
    Sub LoadMarcajes()
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        Dim sql As String
        Try
            conn()
            sql = " SELECT  marcajes.cedula, "
            sql = sql & " CONCAT(empleado.nombre,' ',empleado.apellido) AS Empleado, "
            sql = sql & " marcajes.fecha,"
            sql = sql & " marcajes.hora_asignada,"
            sql = sql & " marcajes.hora_capturada,"
            sql = sql & " f_DifHora(marcajes.hora_asignada, marcajes.hora_capturada) As Diferencia, "
            sql = sql & " Right(marcajes.jornada, 2)As CodJor, "
            sql = sql & " f_JornadaChar(marcajes.jornada) As Jornada "
            sql = sql & " FROM empleado "
            sql = sql & " INNER JOIN marcajes ON empleado.cedula = marcajes.cedula "
            sql = sql & " WHERE marcajes.fecha "
            sql = sql & " BETWEEN '" & DateValue(dtpFechaInicial.Value).ToString("yyyy-MM-dd") & "'"
            sql = sql & " AND '" & DateValue(dtpFechaFin.Value).ToString("yyyy-MM-dd") & "'"
            sql = sql & " ORDER BY marcajes.fecha , marcajes.cedula, Right(marcajes.jornada, 2)"

            da = New MySqlDataAdapter(sql, connection)
            dt = New DataTable
            da.Fill(dt)
            dgvMarcajes.DataSource = dt
            connection.Close()
            da.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        Dim sql As String
        Try
            conn()
            sql = " SELECT  marcajes.cedula, "
            sql = sql & " CONCAT(empleado.nombre,' ',empleado.apellido) AS Empleado, "
            sql = sql & " marcajes.fecha,"
            sql = sql & " marcajes.hora_asignada,"
            sql = sql & " marcajes.hora_capturada,"
            sql = sql & " f_DifHora(marcajes.hora_asignada, marcajes.hora_capturada) As Diferencia, "
            sql = sql & " f_DifHora(marcajes.hora_asignada, marcajes.hora_capturada) As Diferencia, "
            sql = sql & " Right(marcajes.jornada, 2)As CodJor, "
            sql = sql & " f_JornadaChar(marcajes.jornada) As Jornada "
            sql = sql & " FROM empleado "
            sql = sql & " INNER JOIN marcajes ON empleado.cedula = marcajes.cedula "
            sql = sql & " WHERE marcajes.fecha "
            sql = sql & " BETWEEN '" & DateValue(dtpFechaInicial.Value).ToString("yyyy-MM-dd") & "'"
            sql = sql & " AND '" & DateValue(dtpFechaFin.Value).ToString("yyyy-MM-dd") & "'"
            sql = sql & " ORDER BY  marcajes.fecha, Right(marcajes.jornada, 2),marcajes.cedula"

            If ckbTodos.Checked = False Then
                If Len(Trim(txtCedula.Text)) > 0 Then
                    sql = " SELECT  marcajes.cedula, "
                    sql = sql & " CONCAT(empleado.nombre,' ',empleado.apellido) AS Empleado, "
                    sql = sql & " marcajes.fecha,"
                    sql = sql & " marcajes.hora_asignada,"
                    sql = sql & " marcajes.hora_capturada,"
                    sql = sql & " f_DifHora(marcajes.hora_asignada, marcajes.hora_capturada) As Diferencia, "
                    sql = sql & " Right(marcajes.jornada, 2)As CodJor, "
                    sql = sql & " f_JornadaChar(marcajes.jornada) As Jornada "
                    sql = sql & " FROM empleado "
                    sql = sql & " INNER JOIN marcajes ON empleado.cedula = marcajes.cedula "
                    sql = sql & " WHERE marcajes.fecha "
                    sql = sql & " BETWEEN '" & DateValue(dtpFechaInicial.Value).ToString("yyyy-MM-dd") & "'"
                    sql = sql & " AND '" & DateValue(dtpFechaFin.Value).ToString("yyyy-MM-dd") & "'"
                    sql = sql & " AND marcajes.Cedula = '" & txtCedula.Text & "'"
                    sql = sql & " ORDER BY  marcajes.fecha, Right(marcajes.jornada, 2),marcajes.cedula"

                Else
                    MsgBox("Ingrese Cedula a Buscar", vbYes + vbInformation, "Informacion")
                End If
            End If

            da = New MySqlDataAdapter(sql, connection)
            dt = New DataTable
            da.Fill(dt)
            dgvMarcajes.DataSource = dt
            connection.Close()
            da.Dispose()
            If dgvMarcajes.RowCount = 0 Then
                MsgBox("No se Encontro informacion para mostrar", vbYes + vbInformation, "Informacion")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ckbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles ckbTodos.CheckedChanged
        txtCedula.Text = ""
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim Reporte As New frmReports
        Dim ds As Data.DataSet
        Dim da As MySqlDataAdapter
        Dim sql As String
        Try
            conn()
            sql = " set lc_time_names = 'es_VE'; "
            sql = sql & " SELECT  marcajes.cedula, "
            sql = sql & " CONCAT(empleado.nombre,' ',empleado.apellido) AS Empleado, "
            sql = sql & " marcajes.fecha  AS Fecha,"
            ' sql = sql & " CONCAT(dayname(marcajes.fecha) ,' - ', DATE_FORMAT(marcajes.fecha, '%d')) AS Dia,"
            sql = sql & " dayname(marcajes.fecha) as Dia,"
            sql = sql & " f_JornadaChar(marcajes.jornada) As Jornada ,"
            sql = sql & " marcajes.hora_asignada,"
            sql = sql & " marcajes.hora_capturada,"
            sql = sql & " f_DifHora(marcajes.hora_asignada, marcajes.hora_capturada) As Diferencia, "
            sql = sql & " cargos.Descripcion As Cargo"
            sql = sql & " FROM empleado "
            sql = sql & " INNER JOIN marcajes ON empleado.cedula = marcajes.cedula "
            sql = sql & " Left Join cargos ON empleado.cargo = cargos.codigo WHERE empleado.cedula = marcajes.cedula "
            sql = sql & " AND marcajes.fecha "
            sql = sql & " BETWEEN '" & DateValue(dtpFechaInicial.Value).ToString("yyyy-MM-dd") & "'"
            sql = sql & " AND '" & DateValue(dtpFechaFin.Value).ToString("yyyy-MM-dd") & "'"
            sql = sql & " ORDER BY  month(marcajes.fecha), date(marcajes.fecha),marcajes.cedula, Right(marcajes.jornada, 2)"

            If ckbTodos.Checked = False Then
                If Len(Trim(txtCedula.Text)) > 0 Then
                    sql = " SELECT  marcajes.cedula, "
                    sql = sql & " CONCAT(empleado.nombre,' ',empleado.apellido) AS Empleado, "
                    sql = sql & " marcajes.fecha  AS Fecha,"
                    ' sql = sql & " CONCAT(dayname(marcajes.fecha) ,' - ', DATE_FORMAT(marcajes.fecha, '%d')) AS Dia,"
                    sql = sql & " dayname(marcajes.fecha) as Dia,"
                    sql = sql & " f_JornadaChar(marcajes.jornada) As Jornada ,"
                    sql = sql & " marcajes.hora_asignada,"
                    sql = sql & " marcajes.hora_capturada,"
                    sql = sql & " f_DifHora(marcajes.hora_asignada, marcajes.hora_capturada) As Diferencia, "
                    sql = sql & " cargos.Descripcion As Cargo "
                    sql = sql & " FROM empleado "
                    sql = sql & " INNER JOIN marcajes ON empleado.cedula = marcajes.cedula "
                    sql = sql & " LEFT JOIN cargos ON empleado.cargo = cargos.codigo AND  empleado.cedula = marcajes.cedula "
                    sql = sql & " WHERE marcajes.fecha  BETWEEN '" & DateValue(dtpFechaInicial.Value).ToString("yyyy-MM-dd") & "'"
                    sql = sql & " AND '" & DateValue(dtpFechaFin.Value).ToString("yyyy-MM-dd") & "'"
                    sql = sql & " AND marcajes.Cedula = '" & txtCedula.Text & "'"
                    sql = sql & " ORDER  month(marcajes.fecha), date(marcajes.fecha),marcajes.cedula, Right(marcajes.jornada, 2)"

                Else
                    MsgBox("Ingrese Cedula a Buscar", vbYes + vbInformation, "Informacion")
                End If
            End If

            da = New MySqlDataAdapter(sql, connection)
            ds = New Data.DataSet

            da.Fill(ds)

            connection.Close()
            da.Dispose()

            Reporte.ReportViewerVista.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            Reporte.ReportViewerVista.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\rptMarcajes.rdlc"

            Reporte.ReportViewerVista.LocalReport.DataSources.Clear()
            Reporte.ReportViewerVista.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))

            Reporte.ReportViewerVista.DocumentMapCollapsed = True
            Reporte.ReportViewerVista.RefreshReport()
            Reporte.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class