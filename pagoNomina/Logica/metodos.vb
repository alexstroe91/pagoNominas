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

    Public Sub nifCorrecto(frm As formPagoNomina, e As KeyPressEventArgs)
        'si la longitud del texto es menor a 8 (se permiten 8 de longitud) se permite la introduccion de numeros
        If (frm.txtNif.TextLength < 8) Then
            If Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Or Char.IsLetter(e.KeyChar) Then
                e.Handled = True
            End If
        ElseIf frm.txtNif.TextLength = 8 Then
            'una vez se haya introducido el 8º caracter, solo se permite la introduccion de letras.
            'y como la longitud maxima de txtNif es de 9, ya no se permite introducir ningun caracter más
            If Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    Public Sub mostrarInfo(frm As formPagoNomina, empleado As empleadoPluses)
        'muestro en los txtbox de abajo la informacion correspondiente
        With frm
            .txtInfoEmpleado.Text = StrConv(.txtNombre.Text & Space(1) & .txtApellidos.Text, vbProperCase)
            .txtSueldoBruto.Text = CStr(FormatNumber(.numHorasTrabajadas.Value * .numPrecioHora.Value, 2)) & " €"
            'uso el metodo de la clases empleadoPluses, en donde con el metodo de la libreria para calcular la cantidad de trienios que tiene, saque los pluses por los trienios
            .txtInfoPlusTrienios.Text = CStr(empleado.dineroTrienios(empleado.FechaIngreso, frm))
            'usandoel metodo creado en la clase de empleadoPluses, recogemos el valor que retorna el mismo metodo para mostrar los pluses por hijos
            .txtInfoPlusHijos.Text = CStr(empleado.dineroHijos(frm))
            'sumamos el sueldo bruto + los pluses y tendremos el sueldo neto
            .txtInfoSuedoNeto.Text = CStr(FormatNumber(CInt((.numHorasTrabajadas.Value * .numPrecioHora.Value) + CDec(.txtInfoPlusTrienios.Text) + CDec(.txtInfoPlusHijos.Text)), 2)) & " €"
        End With
    End Sub

End Class
