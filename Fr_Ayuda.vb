Public Class Fr_Ayuda
    Private Sub Fr_Ayuda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Texto de ayuda organizado con saltos de línea para mayor claridad
        Txtb_textogeneral.Text =
            "Este programa es un monitor de batería que te permite conocer el nivel de carga y si el cargador está conectado." & vbCrLf & vbCrLf &
            "🔹 **Funciones principales:**" & vbCrLf &
            "   - **F1** → Muestra esta ventana de ayuda." & vbCrLf &
            "   - **F5** → Recarga la información de la batería." & vbCrLf &
            "   - **Botón 'Actualizar'** → Consulta el estado actual de la batería y el cargador." & vbCrLf &
            "   - **Minimizar** → Oculta la ventana en el área de notificación junto al ícono de la batería." & vbCrLf & vbCrLf &
            "🔹 **Desarrollado por:** Ing. Eliasib Cadena Méndez" & vbCrLf &
            "📧 **Contacto:** " & "ingenieroeliasibcadena@gmail.com"

        ' Asegurar que el control de texto esté en modo solo lectura (opcional)
        Txtb_textogeneral.ReadOnly = True
    End Sub
    Private Sub Btn_EnviarCorreo_Click(sender As Object, e As EventArgs) Handles Btn_EnviarCorreo.Click
        Try
            ' Dirección de correo y asunto
            Dim correo As String = "ingenieroeliasibcadena@gmail.com"
            Dim asunto As String = "Consulta sobre el monitor de batería"
            Dim cuerpo As String = "Hola, quisiera obtener más información sobre su software."

            ' Construir el enlace mailto
            Dim mailtoLink As String = $"mailto:{correo}?subject={Uri.EscapeDataString(asunto)}&body={Uri.EscapeDataString(cuerpo)}"

            ' Crear un nuevo proceso para abrir el cliente de correo predeterminado
            Dim psi As New ProcessStartInfo With {
                .FileName = mailtoLink,
                .UseShellExecute = True
            }
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("No se pudo abrir el cliente de correo. Verifique su configuración.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Close()
    End Sub


End Class
