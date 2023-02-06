Public Class Punto3d
    Inherits Punto2d

    Protected _z As Decimal

    Public Property Z() As Decimal
        Get
            Return _z
        End Get
        Set(value As Decimal)
            _z = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        _z = 0
    End Sub

    Public Sub New(x As Decimal, y As Decimal, z As Decimal)
        MyBase.New(x, y)
        _z = z
    End Sub

    Public Overloads Function Calcular_Distancia(a As Punto3d)
        Return Math.Sqrt(Math.Pow(_x - a.X, 2) + Math.Pow(_y - a.Y, 2) + Math.Pow(_z - a.Z, 2))
    End Function

    Public Overrides Function ToString() As String
        Return _x + " " + _y + " " + _z
    End Function
End Class
