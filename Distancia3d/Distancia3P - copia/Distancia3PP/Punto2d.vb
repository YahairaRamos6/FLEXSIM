Public Class Punto2d
    Inherits Punto
    Protected _y As Decimal

    Public Property Y() As Decimal
        Get
            Return _y
        End Get
        Set(value As Decimal)
            _y = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        _y = 0
    End Sub

    Public Sub New(x As Decimal, y As Decimal)
        MyBase.New(x)
        _y = y
    End Sub

    Public Overloads Function Calcular_Distancia(a As Punto2d)
        Return Math.Sqrt(Math.Pow(_x - a.X, 2) + Math.Pow(_y - a.Y, 2))
    End Function

    Public Overrides Function ToString() As String
        Return _x + " " + _y
    End Function
End Class
