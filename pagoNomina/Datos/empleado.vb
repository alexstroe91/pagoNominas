Imports LibreriaNominasBuena.metodos

Public Class empleado
    Dim _nif, _nombre, _apellidos As String
    Dim _fechaIngreso As Date
    Dim _numHiijos As Decimal

    Public Sub New()

    End Sub
    Public Sub New(_nif As String, _nombre As String, _apellidos As String, _fechaIngreso As Date, _numHiijos As Decimal)
        Me._nif = _nif
        Me._nombre = _nombre
        Me._apellidos = _apellidos
        Me._fechaIngreso = _fechaIngreso
        Me._numHiijos = _numHiijos
    End Sub

    Public Property Nif As String
        Get
            Return _nif
        End Get
        Set(value As String)
            _nif = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Apellidos As String
        Get
            Return _apellidos
        End Get
        Set(value As String)
            _apellidos = value
        End Set
    End Property

    Public Property FechaIngreso As Date
        Get
            Return _fechaIngreso
        End Get
        Set(value As Date)
            _fechaIngreso = value
        End Set
    End Property

    Public Property NumHiijos As Decimal
        Get
            Return _numHiijos
        End Get
        Set(value As Decimal)
            _numHiijos = value
        End Set
    End Property
End Class
