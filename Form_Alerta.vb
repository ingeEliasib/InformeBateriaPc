Public Class Form_Alerta
    Private tiempoRestante As Integer = 20 ' segundos
    Private WithEvents TimerAutoCerrar As New Timer()

    Public Sub MostrarMensaje(mensaje As String)
        Txb_EstadoBateria.Text = mensaje
        TimerAutoCerrar.Interval = 1000 ' 1 segundo
        TimerAutoCerrar.Start()
        Me.ShowDialog()
    End Sub

    Private Sub TimerAutoCerrar_Tick(sender As Object, e As EventArgs) Handles TimerAutoCerrar.Tick
        tiempoRestante -= 1
        If tiempoRestante <= 0 Then
            TimerAutoCerrar.Stop()
            Me.Close()
        End If
    End Sub

    Private Sub Btn_Aceptar_Click(sender As Object, e As EventArgs) Handles Btn_Aceptar.Click
        TimerAutoCerrar.Stop
        Close
    End Sub


End Class
