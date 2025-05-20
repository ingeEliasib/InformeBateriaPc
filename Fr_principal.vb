Imports Microsoft.VisualBasic.ApplicationServices

Public Class Fr_principal
    Private estadoCargador As String
    Private PorcentajeFullBateria As Integer = 0
    Private WithEvents timer As New Timer()
    Private primerConsulta As Boolean = True
    Public Event StartupNextInstance(sender As Object, e As StartupNextInstanceEventArgs)

    Private Sub Fr_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Configurar NotifyIcon
        NotifyIcon1.Icon = Me.Icon ' Usa el icono del formulario o uno personalizado
        NotifyIcon1.Visible = False
        NotifyIcon1.Text = "Monitor de Batería"


        ' Mantener siempre encima
        Me.TopMost = True

        ' Iniciar con opacidad del 20%
        Me.Opacity = 0.3


        ' Configurar el temporizador para actualizar cada 1 minuto
        timer.Interval = 60000 ' 1 minuto en milisegundos

        timer.Start()

        If primerConsulta Then
            consultar_informacion()
            Dim alerta As New Form_Alerta
            alerta.MostrarMensaje($"Nivel de Batería {PorcentajeFullBateria} % , Cargador {estadoCargador}")
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

                System.Media.SystemSounds.Exclamation.Play() ' 🔊 Reproduce un sonido de alerta 'MsgBox("La batería está completamente cargada", MsgBoxStyle.Information Or MsgBoxStyle.SystemModal, "Información")
                Dim alerta As New Form_Alerta
                alerta.MostrarMensaje("La batería está cargada sobre el noventa porciento puede desconectar el pc")

            End If
        Else
            If PorcentajeFullBateria <= 20 Then
                System.Media.SystemSounds.Exclamation.Play() ' 🔊 Reproduce un sonido antes del mensaje
                Dim alerta As New Form_Alerta
                alerta.MostrarMensaje("Conecte el Cargador")

            End If
        End If
    End Sub


    Private Sub Btn_Salir_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click
        Dim respuesta As DialogResult
        respuesta = MessageBox.Show("¿Deseas cerrar el programa completamente?" & vbCrLf &
                            "Presiona NO para ocultarlo en el área de notificación.",
                            "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
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

        Txb_DescripcionEstadoBateria.Text = $"Estado Batería: {PorcentajeFullBateria} % {vbCrLf}" &
                                   $". Estado Cargador: {estadoCargador} {vbCrLf}" &
                                   $". Última Actualización: {DateTime.Now.ToString("'. hora: ' h:mm tt", New Globalization.CultureInfo("es-ES"))}"

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

    End Sub
    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        If e.Button = MouseButtons.Left Then
            Me.Show()
            Me.WindowState = FormWindowState.Normal
            Me.ShowInTaskbar = True
            NotifyIcon1.Visible = False
            Me.BringToFront()
        End If
    End Sub
    Private Sub MyApplication_StartupNextInstance(sender As Object, e As Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
        If Application.OpenForms.Count > 0 Then
            Dim frm = Application.OpenForms(0)
            If frm.WindowState = FormWindowState.Minimized Then
                frm.WindowState = FormWindowState.Normal
            End If
            frm.Activate()
        End If
    End Sub



End Class
