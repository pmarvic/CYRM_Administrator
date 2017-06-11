Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports Microsoft.Reporting.WinForms
Public Class frmHorarios
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        InterfazHorarios.ShowDialog()

    End Sub
    Sub LoadHorarios()
        conn()
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        Dim sql As String

        sql = "SELECT   turno_complejo.codigo, "
        sql = sql & "   turno_complejo.lun11,"
        sql = sql & "   turno_complejo.lun12,"
        sql = sql & "   turno_complejo.lun21,"
        sql = sql & "   turno_complejo.lun22,"
        sql = sql & "   turno_complejo.mar11,"
        sql = sql & "   turno_complejo.mar12,"
        sql = sql & "   turno_complejo.mar21,"
        sql = sql & "   turno_complejo.mar22,"
        sql = sql & " 	turno_complejo.mie11,"
        sql = sql & " 	turno_complejo.mie12,"
        sql = sql & " 	turno_complejo.mie21,"
        sql = sql & " 	turno_complejo.mie22,"
        sql = sql & " 	turno_complejo.jue11,"
        sql = sql & " 	turno_complejo.jue12,"
        sql = sql & " 	turno_complejo.jue21,"
        sql = sql & " 	turno_complejo.jue22,"
        sql = sql & " 	turno_complejo.vie11,"
        sql = sql & " 	turno_complejo.vie12,"
        sql = sql & " 	turno_complejo.vie21,"
        sql = sql & " 	turno_complejo.vie22,"
        sql = sql & " 	turno_complejo.sab11,"
        sql = sql & " 	turno_complejo.sab12,"
        sql = sql & " 	turno_complejo.sab21,"
        sql = sql & " 	turno_complejo.sab22,"
        sql = sql & " 	turno_complejo.dom11,"
        sql = sql & " 	turno_complejo.dom12,"
        sql = sql & " 	turno_complejo.dom21,"
        sql = sql & " 	turno_complejo.dom22"
        sql = sql & " FROM turno_complejo "

        da = New MySqlDataAdapter(sql, connection)
        dt = New DataTable
        da.Fill(dt)
        dgvHorarios.DataSource = dt
        connection.Close()
        da.Dispose()

    End Sub

    Private Sub frmHorarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadHorarios()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Dim row As Integer
        Dim codigo As String
        Dim lun11, lun12, lun21, lun22 As String
        Dim mar11, mar12, mar21, mar22 As String
        Dim mie11, mie12, mie21, mie22 As String
        Dim jue11, jue12, jue21, jue22 As String
        Dim vie11, vie12, vie21, vie22 As String
        Dim sab11, sab12, sab21, sab22 As String
        Dim dom11, dom12, dom21, dom22 As String
        Dim SqlUpdate As String

        ' Get Value al Hacer Click en DataGridView
        row = dgvHorarios.CurrentRow.Index

        codigo = dgvHorarios(0, row).Value
        lun11 = dgvHorarios(1, row).Value
        lun12 = dgvHorarios(2, row).Value
        lun21 = dgvHorarios(3, row).Value
        lun22 = dgvHorarios(4, row).Value

        mar11 = dgvHorarios(5, row).Value
        mar12 = dgvHorarios(6, row).Value
        mar21 = dgvHorarios(7, row).Value
        mar22 = dgvHorarios(8, row).Value

        mie11 = dgvHorarios(9, row).Value
        mie12 = dgvHorarios(10, row).Value
        mie21 = dgvHorarios(11, row).Value
        mie22 = dgvHorarios(12, row).Value

        jue11 = dgvHorarios(13, row).Value
        jue12 = dgvHorarios(14, row).Value
        jue21 = dgvHorarios(15, row).Value
        jue22 = dgvHorarios(16, row).Value

        vie11 = dgvHorarios(17, row).Value
        vie12 = dgvHorarios(18, row).Value
        vie21 = dgvHorarios(19, row).Value
        vie22 = dgvHorarios(20, row).Value

        sab11 = dgvHorarios(21, row).Value
        sab12 = dgvHorarios(22, row).Value
        sab21 = dgvHorarios(23, row).Value
        sab22 = dgvHorarios(24, row).Value

        dom11 = dgvHorarios(25, row).Value
        dom12 = dgvHorarios(26, row).Value
        dom21 = dgvHorarios(27, row).Value
        dom22 = dgvHorarios(28, row).Value


        ' Update Sql

        SqlUpdate = " UPDATE turno_complejo SET "
        SqlUpdate = SqlUpdate & " lun11 = '" & lun11 & "',"
        SqlUpdate = SqlUpdate & " lun12 = '" & lun12 & "',"
        SqlUpdate = SqlUpdate & " lun21 = '" & lun21 & "',"
        SqlUpdate = SqlUpdate & " lun22 = '" & lun22 & "',"
        SqlUpdate = SqlUpdate & " mar11 = '" & mar11 & "',"
        SqlUpdate = SqlUpdate & " mar12 = '" & mar12 & "',"
        SqlUpdate = SqlUpdate & " mar21 = '" & mar21 & "',"
        SqlUpdate = SqlUpdate & " mar22 = '" & mar22 & "',"
        SqlUpdate = SqlUpdate & " mie11 = '" & mie11 & "',"
        SqlUpdate = SqlUpdate & " mie12 = '" & mie12 & "',"
        SqlUpdate = SqlUpdate & " mie21 = '" & mie21 & "',"
        SqlUpdate = SqlUpdate & " mie22 = '" & mie22 & "',"
        SqlUpdate = SqlUpdate & " jue11 = '" & jue11 & "',"
        SqlUpdate = SqlUpdate & " jue12 = '" & jue12 & "',"
        SqlUpdate = SqlUpdate & " jue21 = '" & jue21 & "',"
        SqlUpdate = SqlUpdate & " jue22 = '" & jue22 & "',"
        SqlUpdate = SqlUpdate & " vie11 = '" & vie11 & "',"
        SqlUpdate = SqlUpdate & " vie12 = '" & vie12 & "',"
        SqlUpdate = SqlUpdate & " vie21 = '" & vie21 & "',"
        SqlUpdate = SqlUpdate & " vie22 = '" & vie22 & "',"
        SqlUpdate = SqlUpdate & " sab11 = '" & sab11 & "',"
        SqlUpdate = SqlUpdate & " sab12 = '" & sab12 & "',"
        SqlUpdate = SqlUpdate & " sab21 = '" & sab21 & "',"
        SqlUpdate = SqlUpdate & " sab22 = '" & sab22 & "',"
        SqlUpdate = SqlUpdate & " dom11 = '" & dom11 & "',"
        SqlUpdate = SqlUpdate & " dom12 = '" & dom12 & "',"
        SqlUpdate = SqlUpdate & " dom21 = '" & dom21 & "',"
        SqlUpdate = SqlUpdate & " dom22 = '" & dom22 & "'"
        SqlUpdate = SqlUpdate & " WHERE  codigo = '" & codigo & "'"
        RunSql(SqlUpdate)
        LoadHorarios()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim SqlDelete As String
        Dim row As Integer
        Dim codigo As String

        ' Get Value al Hacer Click en DataGridView
        row = dgvHorarios.CurrentRow.Index

        codigo = dgvHorarios(0, row).Value

        Dim message As String
        message = MsgBox("¿ Esta seguro de borrar este registro ? ", vbYesNo + vbInformation, "Aviso")
        If message = vbNo Then
            Exit Sub
        End If
        SqlDelete = "DELETE FROM  turno_complejo WHERE codigo = '" & codigo & "'"
        RunSql(SqlDelete)
        LoadHorarios()

    End Sub
    Private Sub dgvHorarios_GotFocus(sender As Object, e As EventArgs) Handles dgvHorarios.GotFocus
        LoadHorarios()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim Reporte As New frmReports
        Dim ds As Data.DataSet
        Dim da As MySqlDataAdapter
        Dim sql As String
        conn()
        sql = "SELECT   turno_complejo.codigo, "
        sql = sql & "   turno_complejo.lun11,"
        sql = sql & "   turno_complejo.lun12,"
        sql = sql & "   turno_complejo.lun21,"
        sql = sql & "   turno_complejo.lun22,"
        sql = sql & "   turno_complejo.mar11,"
        sql = sql & "   turno_complejo.mar12,"
        sql = sql & "   turno_complejo.mar21,"
        sql = sql & "   turno_complejo.mar22,"
        sql = sql & " 	turno_complejo.mie11,"
        sql = sql & " 	turno_complejo.mie12,"
        sql = sql & " 	turno_complejo.mie21,"
        sql = sql & " 	turno_complejo.mie22,"
        sql = sql & " 	turno_complejo.jue11,"
        sql = sql & " 	turno_complejo.jue12,"
        sql = sql & " 	turno_complejo.jue21,"
        sql = sql & " 	turno_complejo.jue22,"
        sql = sql & " 	turno_complejo.vie11,"
        sql = sql & " 	turno_complejo.vie12,"
        sql = sql & " 	turno_complejo.vie21,"
        sql = sql & " 	turno_complejo.vie22,"
        sql = sql & " 	turno_complejo.sab11,"
        sql = sql & " 	turno_complejo.sab12,"
        sql = sql & " 	turno_complejo.sab21,"
        sql = sql & " 	turno_complejo.sab22,"
        sql = sql & " 	turno_complejo.dom11,"
        sql = sql & " 	turno_complejo.dom12,"
        sql = sql & " 	turno_complejo.dom21,"
        sql = sql & " 	turno_complejo.dom22"
        sql = sql & " FROM turno_complejo "

        da = New MySqlDataAdapter(sql, connection)
        'dt = New DataTable
        ds = New Data.DataSet

        da.Fill(ds)

        connection.Close()
        da.Dispose()

        Reporte.ReportViewerVista.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        Reporte.ReportViewerVista.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\rptHorarios.rdlc"

        Reporte.ReportViewerVista.LocalReport.DataSources.Clear()
        Reporte.ReportViewerVista.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))

        Reporte.ReportViewerVista.DocumentMapCollapsed = True
        Reporte.ReportViewerVista.RefreshReport()
        Reporte.Show()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        LoadHorarios()
    End Sub
End Class