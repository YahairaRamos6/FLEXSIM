Public Class Punto
    Protected _x As Decimal

    Public Property X() As Decimal
        Get
            Return _x
        End Get
        Set(value As Decimal)
            _x = value
        End Set
    End Property

    Public Sub New()
        _x = 0
    End Sub

    Public Sub New(x As Decimal)
        _x = x
    End Sub

    Public Function Calcular_Distancia(Punto_a As Punto)
        Return Math.Abs(_x - Punto_a.X)
    End Function

    Public Overrides Function ToString() As String
        Return _x + " "
    End Function

End Class
