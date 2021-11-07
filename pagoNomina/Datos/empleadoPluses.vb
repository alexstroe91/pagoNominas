Imports LibreriaNominasBuena.metodos
Public Class empleadoPluses
    Inherits empleado

    Const PLUSHIJOS As Integer = 50
    Const PLUSPORTRIENIO As Integer = 100

    Public Function dineroTrienios(fechaIngreso As Date, form As formPagoNomina) As Integer
        MyBase.FechaIngreso = form.dteFechaIngreso.Value

        Return CInt(PLUSPORTRIENIO * calcularTrienios(MyBase.FechaIngreso))

    End Function

    Public Function dineroHijos(form As formPagoNomina) As Integer
        If form.cbxHijos.Checked = False Then
            Return 0
        Else
            Return CInt(form.numNumHijos.Value * PLUSHIJOS)
        End If
    End Function

End Class
