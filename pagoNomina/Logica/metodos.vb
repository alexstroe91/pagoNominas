Imports LibreriaNominasBuena.metodos
Public Class metodos
    Dim numHijos As Decimal

    Public Sub desactivarContadorHijos(frm As formPagoNomina)
        'compurebo si el check box de tener hijos esta desactivado y si es así, desactivo el Numerico de contar cuantos hijos tiene
        If frm.cbxHijos.Checked = False Then
            frm.numNumHijos.Enabled = False
            numHijos = 0
        End If
    End Sub

    Public Sub cambiarEstadoNumHijos(frm As formPagoNomina)
        'compruebo el estado (Activado/Desactivado) del checkbox de numHijos, y le asigno a la variable numHijos el valor que tiene el numerico
        'sino, si esta desactivado, desactivo el numerico para contar los hijos que tiene y asigno el valor 0 a la variable de numHijos
        If frm.cbxHijos.Checked = True Then
            frm.numNumHijos.Enabled = True
            numHijos = frm.numNumHijos.Value
        ElseIf frm.cbxHijos.Checked = False Then
            frm.numNumHijos.Enabled = False
            numHijos = 0
        End If
    End Sub



    Public Sub mostrarInfo(frm As formPagoNomina, empleado As empleadoPluses)
        'muestro en los txtbox de abajo la informacion correspondiente
        With frm
            .txtInfoEmpleado.Text = StrConv(.txtNombre.Text & Space(1) & .txtApellidos.Text, vbProperCase)
            .txtSueldoBruto.Text = CStr(.numHorasTrabajadas.Value * .numPrecioHora.Value) & " €"
            .txtInfoPlusTrienios.Text = CStr(empleado.dineroTrienios(empleado.FechaIngreso, frm))
        End With
    End Sub

End Class
