Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class frmExpImpData
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        Dim sql As String
        Try
            sql = " SELECT marcajes.cedula, "
            sql = sql & "  marcajes.fecha, marcajes.hora_asignada,marcajes.hora_capturada, marcajes.jornada "
            sql = sql & " FROM marcajes "
            sql = sql & " WHERE marcajes.fecha "
            sql = sql & " BETWEEN '" & DateValue(dtpFechaInicial.Value).ToString("yyyy-MM-dd") & "'"
            sql = sql & " AND '" & DateValue(dtpFechaFin.Value).ToString("yyyy-MM-dd") & "'"
            sql = sql & " ORDER BY marcajes.cedula, Right(marcajes.jornada, 2)"
            conn()

            da = New MySqlDataAdapter(sql, connection)
            dt = New DataTable
            da.Fill(dt)
            dgvData.DataSource = dt
            connection.Close()
            da.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub LoadMarcajes()
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        Dim sql As String
        Try
            conn()
            sql = " SELECT marcajes.cedula, "
            sql = sql & "  marcajes.fecha, marcajes.hora_asignada,marcajes.hora_capturada, marcajes.jornada "
            sql = sql & " FROM marcajes "
            sql = sql & " WHERE marcajes.fecha "
            sql = sql & " BETWEEN '" & DateValue(dtpFechaInicial.Value).ToString("yyyy-MM-dd") & "'"
            sql = sql & " AND '" & DateValue(dtpFechaFin.Value).ToString("yyyy-MM-dd") & "'"
            sql = sql & " ORDER BY marcajes.cedula, Right(marcajes.jornada, 2)"
            da = New MySqlDataAdapter(sql, connection)
            dt = New DataTable
            da.Fill(dt)
            dgvData.DataSource = dt
            connection.Close()
            da.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmExpImpData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMarcajes()
    End Sub

    Private Sub btnExportar_Click_1(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            SaveFileDialog1.FileName = "Exp_" + DateValue(dtpFechaInicial.Value).ToString("yyyy-MM-dd") + "_" + DateValue(dtpFechaFin.Value).ToString("yyyy-MM-dd")
            SaveFileDialog1.DefaultExt = ".csv" 'EVITA TENER QUE ESCRIBIR LA EXTENSION AL GUARDAR

            If SaveFileDialog1.ShowDialog Then

                'GUARDA EL VALOR DE LA CABECERA (COLUMNAS)
                Dim COLUMNAS As Integer = dgvData.Columns.Count
                Dim CABECERA As String = String.Empty
                For I = 0 To COLUMNAS - 2 'RECORRE LA CABECERA
                    CABECERA += dgvData.Columns(I).Name & "," 'AÑADE LA COMA PARA LOS CAMPOS
                Next
                CABECERA += dgvData.Columns(COLUMNAS - 1).Name & vbCrLf 'AÑADE EL SALTO DE LINEA CUANDO SE HA COMPLETADO EL REGISTRO
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, CABECERA, False) 'GUARDA EL REGISTRO CABECERA

                'GUARDA EL RESTO DE VALORES (FILAS)
                Dim FILAS As Integer = dgvData.Rows.Count
                Dim TEXTO As String = String.Empty

                'RECORRE FILAS X COLUMNAS
                For I = 0 To FILAS - 2
                    For J = 0 To COLUMNAS - 2
                        TEXTO += dgvData.Item(J, I).Value & "," 'AÑADE LA , PARA LOS CAMPOS
                    Next
                    TEXTO += dgvData.Item(COLUMNAS - 1, I).Value & vbCrLf 'AÑADE EL SALTO DE LINEA CUANDO SE HA COMPLETADO CADA REGISTRO
                Next
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TEXTO, True) 'GUARDA LOS REGSITROS
                MsgBox("Se Completo la Exportacion !!", vbOKOnly + vbInformation, "Informacion")
                dgvData.Columns.Clear() 'LIMPIA DE RESULTADOS ANTERIORES

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class