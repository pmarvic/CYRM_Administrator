Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class frmAsistencias
    Private Sub ckbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles ckbTodos.CheckedChanged
        txtCedula.Text = ""
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        Dim sql As String
        Try
            conn()
            sql = " SELECT empleado.cedula,"
            sql = sql & " CONCAT(empleado.nombre,' ' ,empleado.apellido ) AS Empleado,"
            sql = sql & " cargos.Descripcion As Cargo,"
            sql = sql & " departamento.departamento As Area,"
            sql = sql & " YEAR(marcajes.fecha) AS Ano,"
            sql = sql & " MONTH(marcajes.fecha) AS Mes,"
            sql = sql & " marcajes.fecha AS Fecha_Asistencia,"
            sql = sql & " f_NumRec(marcajes.cedula,marcajes.fecha)As Num_Asistencias "
            sql = sql & " FROM empleado "
            sql = sql & " INNER JOIN marcajes ON empleado.cedula = marcajes.cedula "
            sql = sql & " INNER JOIN cargos ON empleado.cargo = cargos.codigo "
            sql = sql & " INNER JOIN departamento ON empleado.dpto = departamento.coddpto "
            sql = sql & " WHERE marcajes.fecha "
            sql = sql & " BETWEEN '" & DateValue(dtpFechaInicial.Value).ToString("yyyy-MM-dd") & "'"
            sql = sql & " AND '" & DateValue(dtpFechaFin.Value).ToString("yyyy-MM-dd") & "'"
            sql = sql & " GROUP BY empleado.cedula , marcajes.fecha "
            sql = sql & " ORDER BY marcajes.fecha , empleado.cedula "

            If ckbTodos.Checked = False Then
                If Len(Trim(txtCedula.Text)) > 0 Then
                    sql = " SELECT empleado.cedula,"
                    sql = sql & " CONCAT(empleado.nombre,' ' ,empleado.apellido ) AS Empleado,"
                    sql = sql & " cargos.Descripcion As Cargo,"
                    sql = sql & " departamento.departamento As Area,"
                    sql = sql & " YEAR(marcajes.fecha) AS Ano,"
                    sql = sql & " MONTH(marcajes.fecha) AS Mes,"
                    sql = sql & " marcajes.fecha AS Fecha_Asistencia,"
                    sql = sql & " f_NumRec(marcajes.cedula,marcajes.fecha)As Num_Asistencias "
                    sql = sql & " FROM empleado "
                    sql = sql & " INNER JOIN marcajes ON empleado.cedula = marcajes.cedula "
                    sql = sql & " INNER JOIN cargos ON empleado.cargo = cargos.codigo "
                    sql = sql & " INNER JOIN departamento ON empleado.dpto = departamento.coddpto "
                    sql = sql & " WHERE marcajes.fecha "
                    sql = sql & " BETWEEN '" & DateValue(dtpFechaInicial.Value).ToString("yyyy-MM-dd") & "'"
                    sql = sql & " AND '" & DateValue(dtpFechaFin.Value).ToString("yyyy-MM-dd") & "'"
                    sql = sql & " AND marcajes.Cedula = '" & txtCedula.Text & "'"
                    sql = sql & " GROUP BY empleado.cedula , marcajes.fecha "
                    sql = sql & " ORDER BY marcajes.fecha , empleado.cedula "
                Else
                    MsgBox("Ingrese Cedula a Buscar", vbYes + vbInformation, "Informacion")

                End If
            End If

            da = New MySqlDataAdapter(sql, connection)
            dt = New DataTable
            da.Fill(dt)
            dgvAsistencias.DataSource = dt
            connection.Close()
            da.Dispose()
            If dgvAsistencias.RowCount = 0 Then
                MsgBox("No se Encontro informacion para mostrar", vbYes + vbInformation, "Informacion")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    Sub LoadASistencia()
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        Dim sql As String
        Try
            conn()
            sql = " SELECT empleado.cedula,"
            sql = sql & " CONCAT(empleado.nombre,' ' ,empleado.apellido ) AS Empleado,"
            sql = sql & " cargos.Descripcion As Cargo,"
            sql = sql & " departamento.departamento As Area,"
            sql = sql & " YEAR(marcajes.fecha) AS Ano,"
            sql = sql & " MONTH(marcajes.fecha) AS Mes,"
            sql = sql & " marcajes.fecha AS Fecha_Asistencia,"
            sql = sql & " f_NumRec(marcajes.cedula,marcajes.fecha)As Num_Asistencias "
            sql = sql & " FROM empleado "
            sql = sql & " INNER JOIN marcajes ON empleado.cedula = marcajes.cedula "
            sql = sql & " INNER JOIN cargos ON empleado.cargo = cargos.codigo "
            sql = sql & " INNER JOIN departamento ON empleado.dpto = departamento.coddpto "
            sql = sql & " WHERE marcajes.fecha "
            sql = sql & " BETWEEN '" & DateValue(dtpFechaInicial.Value).ToString("yyyy-MM-dd") & "'"
            sql = sql & " AND '" & DateValue(dtpFechaFin.Value).ToString("yyyy-MM-dd") & "'"
            sql = sql & " GROUP BY empleado.cedula , marcajes.fecha "
            sql = sql & " ORDER BY marcajes.fecha , empleado.cedula "

            da = New MySqlDataAdapter(sql, connection)
            dt = New DataTable
            da.Fill(dt)
            dgvAsistencias.DataSource = dt
            connection.Close()
            da.Dispose()
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
            sql = " SELECT empleado.cedula,"
            sql = sql & " CONCAT(empleado.nombre,' ' ,empleado.apellido ) AS Empleado,"
            sql = sql & " cargos.Descripcion As Cargo,"
            sql = sql & " departamento.departamento As Area,"
            sql = sql & " YEAR(marcajes.fecha) AS Ano,"
            sql = sql & " MONTH(marcajes.fecha) AS Mes,"
            sql = sql & " marcajes.fecha AS Fecha_Asistencia,"
            sql = sql & " f_NumRec(marcajes.cedula,marcajes.fecha)As Num_Asistencias "
            sql = sql & " FROM empleado "
            sql = sql & " INNER JOIN marcajes ON empleado.cedula = marcajes.cedula "
            sql = sql & " INNER JOIN cargos ON empleado.cargo = cargos.codigo "
            sql = sql & " INNER JOIN departamento ON empleado.dpto = departamento.coddpto "
            sql = sql & " WHERE marcajes.fecha "
            sql = sql & " BETWEEN '" & DateValue(dtpFechaInicial.Value).ToString("yyyy-MM-dd") & "'"
            sql = sql & " AND '" & DateValue(dtpFechaFin.Value).ToString("yyyy-MM-dd") & "'"
            sql = sql & " GROUP BY empleado.cedula , marcajes.fecha "
            sql = sql & " ORDER BY marcajes.fecha , empleado.cedula "

            If ckbTodos.Checked = False Then
                If Len(Trim(txtCedula.Text)) > 0 Then
                    sql = " SELECT empleado.cedula,"
                    sql = sql & " CONCAT(empleado.nombre,' ' ,empleado.apellido ) AS Empleado,"
                    sql = sql & " cargos.Descripcion As Cargo,"
                    sql = sql & " departamento.departamento As Area,"
                    sql = sql & " YEAR(marcajes.fecha) AS Ano,"
                    sql = sql & " MONTH(marcajes.fecha) AS Mes,"
                    sql = sql & " marcajes.fecha AS Fecha_Asistencia,"
                    sql = sql & " f_NumRec(marcajes.cedula,marcajes.fecha)As Num_Asistencias "
                    sql = sql & " FROM empleado "
                    sql = sql & " INNER JOIN marcajes ON empleado.cedula = marcajes.cedula "
                    sql = sql & " INNER JOIN cargos ON empleado.cargo = cargos.codigo "
                    sql = sql & " INNER JOIN departamento ON empleado.dpto = departamento.coddpto "
                    sql = sql & " WHERE marcajes.fecha "
                    sql = sql & " BETWEEN '" & DateValue(dtpFechaInicial.Value).ToString("yyyy-MM-dd") & "'"
                    sql = sql & " AND '" & DateValue(dtpFechaFin.Value).ToString("yyyy-MM-dd") & "'"
                    sql = sql & " AND marcajes.Cedula = '" & txtCedula.Text & "'"
                    sql = sql & " GROUP BY empleado.cedula , marcajes.fecha "
                    sql = sql & " ORDER BY marcajes.fecha , empleado.cedula "
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
            Reporte.ReportViewerVista.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\rptAsistencias.rdlc"

            Reporte.ReportViewerVista.LocalReport.DataSources.Clear()
            Reporte.ReportViewerVista.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))

            Reporte.ReportViewerVista.DocumentMapCollapsed = True
            Reporte.ReportViewerVista.RefreshReport()
            Reporte.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmAsistencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadASistencia()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub CompletarGrid() 'No Funciono Investigar
        Dim Cedula As String
        Dim Fecha As String
        Try
            dgvAsistencias.ReadOnly = False
            dgvAsistencias.EditMode = True
            For Each row As DataGridViewRow In dgvAsistencias.Rows
                Cedula = row.Cells(0).Value
                Fecha = row.Cells(6).Value
                Debug.Print(BuscarHoras(Cedula, Fecha))
                dgvAsistencias.Rows.Add(BuscarHoras(Cedula, Fecha))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dt As New DataTable
        Dim Reporte As New frmReports


        Try
            With dt
                .Columns.Add("Cedula")
                .Columns.Add("Empleado")
                .Columns.Add("Cargo")
                .Columns.Add("Area")
                .Columns.Add("Ano")
                .Columns.Add("Mes")
                .Columns.Add("Fecha_Asistencia")
                .Columns.Add("Num_Asistencias")
                .Columns.Add("Horas_Trabajadas")
            End With
            For Each row As DataGridViewRow In dgvAsistencias.Rows
                dt.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, DateValue(row.Cells(6).Value).ToString("yyyy-MM-dd"), row.Cells(7).Value, BuscarHoras(row.Cells(0).Value, row.Cells(6).Value))
            Next


            Reporte.ReportViewerVista.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            Reporte.ReportViewerVista.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\rptAsistencias.rdlc"

            Reporte.ReportViewerVista.LocalReport.DataSources.Clear()
            Reporte.ReportViewerVista.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))

            Reporte.ReportViewerVista.DocumentMapCollapsed = True
            Reporte.ReportViewerVista.RefreshReport()
            Reporte.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub



    ' el problema consiste en que si no pongo este codigo al hacer click en un checkbox de la grilla este no cambiara a true hasta que otro checkbox
    ' sea clickeado o se haga click en la celda de la grilla

    Friend Function BuscarHoras(Cedula As String, Dia As String) As String
        Dim Sql As String
        Dim Hora_J11 As String = "00:00"
        Dim Hora_J12 As String = "00:00"
        Dim Hora_J21 As String = "00:00"
        Dim Hora_J22 As String = "00:00"
        Dim Hora_Jornada_Uno As String
        Dim Hora_Jornada_Dos As String

        Sql = " SELECT marcajes.hora_capturada As Hora, "
        Sql = Sql & "RIGHT(marcajes.jornada,2)As Jornada"
        Sql = Sql & " FROM marcajes "
        Sql = Sql & " WHERE marcajes.cedula ='" & Cedula & "' AND marcajes.fecha = '" & DateValue(Dia).ToString("yyyy-MM-dd") & "'"
        BuscarHoras = "00:00"
        Try
            conn()

            Dim oComando As New MySqlCommand(Sql, connection)
            Dim oDataReader As MySqlDataReader

            oDataReader = oComando.ExecuteReader()
            Do While oDataReader.Read()

                Select Case oDataReader("Jornada").ToString
                    Case "11"
                        Hora_J11 = TimeValue(oDataReader("Hora")).ToString("H:mm")
                    Case "12"
                        Hora_J12 = TimeValue(oDataReader("Hora")).ToString("H:mm")
                    Case "21"
                        Hora_J21 = TimeValue(oDataReader("Hora")).ToString("H:mm")
                    Case "22"
                        Hora_J22 = TimeValue(oDataReader("Hora")).ToString("H:mm")
                End Select
                '  oDataReader.NextResult()
            Loop
            Debug.Print(Hora_J11)
            Debug.Print(Hora_J12)
            Debug.Print(Hora_J21)
            Debug.Print(Hora_J22)

            Hora_Jornada_Uno = TimeValue(DifHoras(Hora_J11, Hora_J12)).ToString("H:mm")
            Hora_Jornada_Dos = TimeValue(DifHoras(Hora_J21, Hora_J22)).ToString("H:mm")


            BuscarHoras = Hora_Jornada_Uno + " - " + Hora_Jornada_Dos
            oDataReader.Close()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return BuscarHoras
    End Function
    Friend Function DifHoras(Hora_I As Object, Hora_F As Object) As String
        Dim Sql As String
        Dim oDataReader As MySqlDataReader

        DifHoras = "00:00"
        Try
            Sql = " SELECT  f_DifHora_Asis('" & TimeValue(Hora_F).ToString("H:mm") & "','" & TimeValue(Hora_I).ToString("H:mm") & "') As Horas "
            Debug.Print(Sql)
            conn()
            Dim oComando As New MySqlCommand(Sql, connection)
            oDataReader = oComando.ExecuteReader()
            While oDataReader.Read()
                DifHoras = oDataReader("Horas")
            End While
            oDataReader.Close()
            connection.Close()
            Return DifHoras
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return DifHoras
    End Function
End Class