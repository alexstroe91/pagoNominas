Imports LibreriaNominasBuena.metodos
Public Class empleadoPluses

    'declaramos la clase heredando de la clase empleado por lo que hereda todos sus atributos.

    Inherits empleado

    'declaro las constantes de los pluses con los cuales vamos a operar posteriormente
    Const PLUSHIJOS As Integer = 50
    Const PLUSPORTRIENIO As Integer = 100

    'calculamos el dinero que cobrará el empleado dependiendo de los trienios que tenga y retornamos un Double con la cantidad de dinero correspondiente
    Public Function dineroTrienios(fechaIngreso As Date, form As formPagoNomina) As Double
        MyBase.FechaIngreso = form.dteFechaIngreso.Value

        Return CInt(PLUSPORTRIENIO * calcularTrienios(MyBase.FechaIngreso))

    End Function

    'calculamos el dinero que cobrará el empleado dependiendo los hijos que tenga y retornamos un Double con la cantidad de dinero correspondiente
    Public Function dineroHijos(form As formPagoNomina) As Double
        If form.cbxHijos.Checked = False Then
            Return 0
        Else
            Return CInt(form.numNumHijos.Value * PLUSHIJOS)
        End If
    End Function

End Class
