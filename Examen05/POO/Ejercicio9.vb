Public Class A
    Public Overridable Sub F()
        Console.WriteLine("A.F")
    End Sub

    Public Sub G()
        Console.WriteLine("A.G")
    End Sub
End Class

Public Class B
    Inherits A
    Public Overrides Sub F()
        Console.WriteLine("B.F")
    End Sub

    Public Shadows Sub G()
        Console.WriteLine("B.G")
    End Sub
End Class

Public Class C
    Inherits B
    Public Overridable Shadows Sub F()
        Console.WriteLine("C.F")
    End Sub
End Class

Public Class D
    Inherits C
    Public Overrides Sub F()
        Console.WriteLine("D.F")
    End Sub
End Class

Public Class Ejercicio9
    Public Shared Sub Imprimir()
        Dim d As New D
        Dim a As A = d
        Dim b As B = d
        Dim c As C = d

        a.F()
        b.F()
        c.F()
        d.F()

        Dim b1 As B = New B
        Dim a1 As A = b
        a1.G()
        b1.G()
    End Sub
End Class