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
            'uso el metodo de la clases empleadoPluses, en donde con el metodo de la libreria para calcular la cantidad de trienios que tiene, saque los pluses por los trienios
            .txtInfoPlusTrienios.Text = CStr(empleado.dineroTrienios(empleado.FechaIngreso, frm))
            'usandoel metodo creado en la clase de empleadoPluses, recogemos el valor que retorna el mismo metodo para mostrar los pluses por hijos
            .txtInfoPlusHijos.Text = CStr(empleado.dineroHijos(frm))
            'sumamos el sueldo bruto + los pluses y tendremos el sueldo neto
            .txtInfoSuedoNeto.Text = CStr(CInt((.numHorasTrabajadas.Value * .numPrecioHora.Value) + CDec(.txtInfoPlusTrienios.Text) + CDec(.txtInfoPlusHijos.Text))) & " €"
        End With
    End Sub

End Class
