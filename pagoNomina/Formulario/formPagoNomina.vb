Imports LibreriaNominasBuena.metodos
Public Class formPagoNomina
    Dim logica As New metodos
    Dim empleado As New empleadoPluses

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If validarNif(txtNif.Text) Then
            logica.mostrarInfo(Me, empleado)
        Else
            MessageBox.Show("El NIF introducido no es correcto. \n Porfavor intoduce uno válido")
        End If

    End Sub

    Private Sub formPagoNomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        logica.desactivarContadorHijos(Me)
    End Sub

    Private Sub cbxHijos_CheckedChanged(sender As Object, e As EventArgs) Handles cbxHijos.CheckedChanged
        logica.cambiarEstadoNumHijos(Me)
    End Sub
End Class
