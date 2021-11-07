Imports LibreriaNominasBuena.metodos
Public Class formPagoNomina
    Dim logica As New metodos
    Dim empleado As New empleadoPluses

    'hacemos que cuando se pulse el boton de salir, se cierre la aplicacion
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    'comprobamos que al pulsar el boton de calcular, que la casilla de NIF no esté vacía y si lo está le muestra un mensaje informándole que tiene que introducir un nif.
    'posteriormente si ha introducido un nif, se comprueba si el nif es válido utilizando el método de la librería que hemos importado
    'si el método nos retorna que el nif introducido no es válido, muestra un mensaje, y si lo es, calcula la nómina
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If txtNif.Text = Nothing Then
            MessageBox.Show("Tienes que introducir un NIF")
        Else
            If validarNif(txtNif.Text) Then
                logica.mostrarInfo(Me, empleado)
            Else
                MessageBox.Show("El NIF introducido no es correcto. Porfavor intoduce uno válido")
            End If
        End If

    End Sub

    'al cargar el formulario, desactivamos el numerico donde guardamos al cantidad de hijos que tiene el empleado, por que el checkbox asociado está desacitvado
    Private Sub formPagoNomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        logica.desactivarContadorHijos(Me)
    End Sub

    'comprobamos que el checkbox este acitvado o no y activamos o desactivamos el numerico de hijos
    Private Sub cbxHijos_CheckedChanged(sender As Object, e As EventArgs) Handles cbxHijos.CheckedChanged
        logica.cambiarEstadoNumHijos(Me)
    End Sub

    'depuramos la casilla de nif para que solo pueda introducir un formato válido para el nif.
    Private Sub txtNif_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNif.KeyPress
        logica.nifCorrecto(Me, e)
    End Sub
End Class
