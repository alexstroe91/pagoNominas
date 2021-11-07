Public Class metodos

    Public Shared Function validarNif(nif As String) As Boolean
        'hago mayusculas la letra que tenga el nif para evitar problemas en la comprobacion
        nif.ToUpper()

        'defino el array con las letras
        Dim arrayLetras() As String = {"T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E"}

        'defino una variable donde recojo todos los numeros excepto el ultimo caracter que es una letra
        Dim numeros As Integer = CInt(nif.Substring(0, nif.Length() - 1))

        'recojo en una variable letraNif la letra que se corresponde al numero introducido
        Dim letraNif As Char = CChar(arrayLetras(numeros Mod 23))


        'compruebo si la letra del Nif introducido se corresponde a la letra asociada a ese numero y devuelve true o false
        If nif.Last = letraNif Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Shared Function calcularTrienios(fechaIngreso As Date) As Long

        ' compruebo si la fecha del año de la FechaIntroducida es mayor que el dia del año de la fecha actual y se retornan los años correspondientes
        If fechaIngreso.DayOfYear > Date.Now.DayOfYear Then
            Return ((Date.Now.Year - fechaIngreso.Year) - 1) \ 3
        Else
            Return ((Date.Now.Year - fechaIngreso.Year)) \ 3
        End If

    End Function
End Class
