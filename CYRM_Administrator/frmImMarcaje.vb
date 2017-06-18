Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class frmImMarcaje
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        Try
            If OpenFileDialog1.ShowDialog Then
                DataGridView1.Columns.Clear() 'LIMPIA DE RESULTADOS ANTERIORES
                'CABECERA
                Dim CABECERA As String = IO.File.ReadLines(OpenFileDialog1.FileName)(0) 'PRIMERA LINEA DEL ARCHIVO COMO CABECERA
                Dim COLUMNAS As String() = CABECERA.Split(",")
                DataGridView1.ColumnCount = COLUMNAS.Count
                For I = 0 To COLUMNAS.Count - 1
                    DataGridView1.Columns(I).Name = COLUMNAS(I)
                Next

                'RESTO DE FILAS
                For I = 1 To IO.File.ReadLines(OpenFileDialog1.FileName).Count - 1
                    Dim FILA As String() = IO.File.ReadLines(OpenFileDialog1.FileName)(I).Split(",")
                    DataGridView1.Rows.Add(FILA)
                Next
            End If
            MsgBox("Se Completo la Importacion !!", vbOKOnly + vbInformation, "Informacion")
        Catch ex As Exception
            Me.Close()
        End Try


    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim fila As DataGridViewRow = New DataGridViewRow()
        Dim SqlInsert As String
        Dim message As String

        Try

            Message = MsgBox("¿Esta Seguro de agregar la nueva informacion ?", vbYesNo + vbInformation, "Informacion")
            If message = vbNo Then
                Exit Sub
            End If
            For Each fila In DataGridView1.Rows
                SqlInsert = " INSERT INTO marcajes (id,cedula,fecha,hora_asignada,hora_capturada,jornada) VALUE ( 0,"
                SqlInsert = SqlInsert & "'" & fila.Cells("cedula").Value & "',"
                SqlInsert = SqlInsert & "'" & DateValue(fila.Cells("fecha").Value).ToString("yyyy-MM-dd") & "',"
                SqlInsert = SqlInsert & "'" & fila.Cells("hora_asignada").Value & "',"
                SqlInsert = SqlInsert & "'" & fila.Cells("hora_capturada").Value & "',"
                SqlInsert = SqlInsert & "'" & fila.Cells("jornada").Value & "')"
                RunInsert(SqlInsert)
            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        MsgBox("Se Completo los Registros han sido Importados !!", vbOKOnly + vbInformation, "Informacion")

        DataGridView1.Columns.Clear() 'LIMPIA DE RESULTADOS ANTERIORES
    End Sub
End Class