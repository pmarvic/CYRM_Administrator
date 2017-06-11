Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class LoginForm
    Dim oUser As String
    Dim oPass As String
    Dim swReport As Boolean
    Dim swExport As Boolean
    Dim swAdmin As Boolean

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        ' Validar unsarios y permisos
        Dim OPrincipal As New frmMain
        Try
            If ValidarUsuario(UsernameTextBox.Text, PasswordTextBox.Text) Then
                OPrincipal.Permisos(swReport, swExport, swAdmin)
                OPrincipal.ShowDialog()

                Me.Close()
            End If
            MsgBox("Error al Validar Acceso", vbOKOnly + vbExclamation, "Indentificacion Usuario")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Function ValidarUsuario(User As String, Clave As String) As Boolean
        Dim Sql As String
        Try
            conn()
            Sql = "SELECT usuarios.user, "
            Sql = Sql & " usuarios.pass, "
            Sql = Sql & " usuarios.report, "
            Sql = Sql & " usuarios.exportar, "
            Sql = Sql & " usuarios.admin "
            Sql = Sql & " FROM usuarios "
            Sql = Sql & " Where usuarios.user = '" & User & "'"

            ValidarUsuario = False

            Dim oComando As New MySqlCommand(Sql, connection)
            Dim oDataReader As MySqlDataReader

            oDataReader = oComando.ExecuteReader()

            While oDataReader.Read()
                If Clave = oDataReader("pass") Then
                    swReport = oDataReader("report")
                    swExport = oDataReader("exportar")
                    swAdmin = oDataReader("admin")
                    ValidarUsuario = True
                End If
            End While

            oDataReader.Close()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return ValidarUsuario
    End Function
End Class
