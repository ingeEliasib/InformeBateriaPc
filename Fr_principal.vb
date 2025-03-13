Public Class Fr_principal
    Private estadoCargador As String
    Private PorcentajeFullBateria As Integer = 0
    Private WithEvents timer As New Timer()
    Private primerConsulta As Boolean = True
    'Private WithEvents NotifyIcon1 As New NotifyIcon()
    Private Sub Fr_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Configurar NotifyIcon
        NotifyIcon1.Icon = Me.Icon ' Usa el icono del formulario o uno personalizado
        NotifyIcon1.Visible = False
        NotifyIcon1.Text = "Monitor de Batería"
        AddHandler NotifyIcon1.DoubleClick, AddressOf RestaurarVentana

        ' Mantener siempre encima
        Me.TopMost = True

        ' Iniciar con opacidad del 20%
        Me.Opacity = 0.3


        ' Configurar el temporizador para actualizar cada 1 minuto
        timer.Interval = 60000 ' 1 minuto en milisegundos

        timer.Start()

        If primerConsulta Then
            consultar_informacion()
            MsgBox($"Información actualizada correctamente, Nivel de Batería {PorcentajeFullBateria} % ,Estado de Cargador {estadoCargador}", MsgBoxStyle.Information, "Información")
            primerConsulta = False
        End If
    End Sub

    ' Manejo de opacidad cuando se hace clic en la ventana
    Private Sub Fr_principal_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.Opacity = 1.0 ' Opacidad al 100% cuando la ventana está activa
    End Sub

    ' Manejo de opacidad cuando se pierde el foco
    Private Sub Fr_principal_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Try
            Me.Opacity = 0.3 ' Opacidad al 20% cuando se pierde el foco
        Catch ex As Exception

        End Try

    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        consultar_informacion()

        If revisarestadoCargador() = "Conectado" Then
            If PorcentajeFullBateria >= 90 Then
                System.Media.SystemSounds.Exclamation.Play() ' 🔊 Reproduce un sonido de alerta
                MsgBox("La batería está completamente cargada", MsgBoxStyle.Information Or MsgBoxStyle.SystemModal, "Información")
            End If
        Else
            If PorcentajeFullBateria <= 10 Then
                System.Media.SystemSounds.Exclamation.Play() ' 🔊 Reproduce un sonido antes del mensaje
                MsgBox("Debe iniciar el proceso de Carga del Computador", MsgBoxStyle.Information Or MsgBoxStyle.SystemModal, "Información")
            End If
        End If
    End Sub


    Private Sub Btn_Salir_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click
        Dim respuesta As DialogResult
        respuesta = MessageBox.Show("¿Está seguro de que desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = DialogResult.Yes Then
            Me.Close()
        Else
            Me.WindowState = FormWindowState.Minimized
        End If
    End Sub

    Private Function revisarestadoCargador() As String
        If SystemInformation.PowerStatus.PowerLineStatus = PowerLineStatus.Online Then
            Return "Conectado"
        Else
            Return "Desconectado"
        End If
    End Function

    Private Sub Btn_ActualizarInformacion_Click(sender As Object, e As EventArgs) Handles Btn_ActualizarInformacion.Click
        consultar_informacion()
    End Sub

    Private Sub consultar_informacion()
        PorcentajeFullBateria = SystemInformation.PowerStatus.BatteryLifePercent * 100
        estadoCargador = revisarestadoCargador()

        Txb_DescripcionEstadoBateria.Text = $"Estado Actual de la Batería: {PorcentajeFullBateria} % {vbCrLf}" &
                                   $". Estado Actual del Cargador: {estadoCargador} {vbCrLf}" &
                                   $". Última Actualización: {DateTime.Now.ToString("dd 'de' MMMM '. hora: ' h:mm tt", New Globalization.CultureInfo("es-ES"))} {vbCrLf}" &
                                   ". Diseñado por: Ingeniero Eliasib Cadena M."
        Me.Txb_DescripcionEstadoBateria.Focus()

    End Sub


    ' Evento para minimizar la ventana y ocultarla de la barra de tareas
    Private Sub Fr_principal_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.ShowInTaskbar = False
            NotifyIcon1.Visible = True
            Me.Hide()
        End If
    End Sub

    ' Método para restaurar la ventana al hacer doble clic en el icono
    Private Sub RestaurarVentana(sender As Object, e As EventArgs)
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
        NotifyIcon1.Visible = False
    End Sub

    Private Sub Btn_Ayuda_Click(sender As Object, e As EventArgs) Handles Btn_Ayuda.Click
        Ayuda()
    End Sub

    Private Sub Fr_principal_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                Ayuda()
            Case Keys.F5
                consultar_informacion()
        End Select
    End Sub

    Private Sub Ayuda()

        Dim ventanaayuda As New Fr_Ayuda
        ventanaayuda.ShowDialog()
        'MsgBox("Este programa monitorea el estado de la batería de su computadora y le notifica cuando está completamente cargada o necesita ser recargada." & vbCrLf & vbCrLf &
        '       "También le informa si el cargador está conectado o desconectado." & vbCrLf & vbCrLf &
        '       "Desarrollado por: Ing. Eliasib Cadena Méndez" & vbCrLf &
        '       "Contacto: ingenieroeliasibcadena@gmail.com", MsgBoxStyle.Information, "Ayuda")
    End Sub

End Class
