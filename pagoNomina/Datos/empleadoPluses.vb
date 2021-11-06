Imports LibreriaNominasBuena.metodos
Public Class empleadoPluses
    Inherits empleado

    Const PLUSHIJOS As Integer = 50
    Const PLUSPORTRIENIO As Integer = 100

    Public Function dineroTrienios(fechaIngreso As Date, form As formPagoNomina) As Integer
        MyBase.FechaIngreso = form.dteFechaIngreso.Value

        Return CInt(PLUSPORTRIENIO * calcularTrienios(MyBase.FechaIngreso))

    End Function

End Class
