Public Class formPagoNomina
    Dim logica As New metodos

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        logica.mostrarInfo(Me)

    End Sub

    Private Sub formPagoNomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        logica.desactivarContadorHijos(Me)
    End Sub

    Private Sub cbxHijos_CheckedChanged(sender As Object, e As EventArgs) Handles cbxHijos.CheckedChanged
        logica.cambiarEstadoNumHijos(Me)
    End Sub
End Class
