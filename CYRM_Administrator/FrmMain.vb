Public Class frmMain
    Dim oReport As Boolean
    Dim oExport As Boolean
    Dim oAdmin As Boolean

    Private Sub HorariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorariosToolStripMenuItem.Click
        Dim objHorario As New frmHorarios
        If oAdmin Then
            objHorario.ShowDialog()
        Else
            MsgBox("Requiere Autorizacion", vbOKOnly + vbInformation, "Administrador")
        End If
    End Sub

    Private Sub CargosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargosToolStripMenuItem.Click
        Dim objCargos As New frmCargos
        If oAdmin Then
            objCargos.ShowDialog()
        Else
            MsgBox("Requiere Autorizacion", vbOKOnly + vbInformation, "Administrador")
        End If

    End Sub

    Private Sub DepartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartamentoToolStripMenuItem.Click
        Dim ObjDepartamento As New frmDepartamento
        If oAdmin Then
            ObjDepartamento.ShowDialog()
        Else
            MsgBox("Requiere Autorizacion", vbOKOnly + vbInformation, "Administrador")
        End If


    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Dim ObjEmpleado As New frmEmpleados
        If oAdmin Then
            ObjEmpleado.ShowDialog()
        Else
            MsgBox("Requiere Autorizacion", vbOKOnly + vbInformation, "Administrador")
        End If


    End Sub

    Private Sub MarcajesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcajesToolStripMenuItem.Click
        Dim ObjMarcajes As New frmMarcajes
        If oReport Then
            ObjMarcajes.ShowDialog()
        Else
            MsgBox("Requiere Autorizacion", vbOKOnly + vbInformation, "Administrador")
        End If


    End Sub

    Private Sub AsistenciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsistenciasToolStripMenuItem.Click
        Dim ObjAsistencia As New frmAsistencias
        If oAdmin Then
            ObjAsistencia.ShowDialog()
        Else
            MsgBox("Requiere Autorizacion", vbOKOnly + vbInformation, "Administrador")
        End If


    End Sub

    Private Sub RegistrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrosToolStripMenuItem.Click
        Dim oExporImpor As New frmExpImpData
        If oExport Then
            oExporImpor.ShowDialog()
        Else
            MsgBox("Requiere Autorizacion", vbOKOnly + vbInformation, "Administrador")
        End If
    End Sub
    Public Sub Permisos(pReport As String, pExport As String, pAdmin As String)
        oReport = IIf(pReport = True, True, False)
        oExport = IIf(pExport = True, True, False)
        oAdmin = IIf(pAdmin = True, True, False)
    End Sub

    Private Sub SeguridadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeguridadToolStripMenuItem.Click
        Dim oSegurity As New frmSeguridad
        If oAdmin Then
            oSegurity.ShowDialog()
        Else
            MsgBox("Requiere Autorizacion", vbOKOnly + vbInformation, "Administrador")
        End If
    End Sub
End Class
