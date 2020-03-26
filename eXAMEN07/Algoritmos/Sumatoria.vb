Public Class Sumatoria
    Public Shared Sub SumatoriaYimi(arrego As Integer(), n As Integer)
        Dim auxMayor = 0
        Dim auxMenor = 0

        ordernarYimi(arrego)
        For i = 0 To n - 1
            auxMayor += arrego((arrego.Length - 1) - i)
            auxMenor += arrego(i)
        Next
        Console.WriteLine($"Máxima={auxMayor}")
        Console.WriteLine($"Mínima={auxMenor}")
    End Sub

    Private Shared Sub ordernarYimi(ByRef arreglo As Integer())
        Dim aux As Integer = 0

        For i = 0 To arreglo.Length - 1
            For j = 0 To arreglo.Length - 2
                If arreglo(j) > arreglo(j + 1) Then
                    aux = arreglo(j + 1)
                    arreglo(j + 1) = arreglo(j)
                    arreglo(j) = aux
                End If
            Next
        Next
    End Sub

    Public Shared Sub SumatoriaAlvaro(arreglo As Integer(), n As Integer)
        Dim min = 0,
            max = 0

        Array.Sort(arreglo)

        For i = 0 To n - 1
            min += arreglo(i)
        Next

        For i = arreglo.Length - 1 To arreglo.Length - n Step -1
            max += arreglo(i)
        Next

        Console.WriteLine($"Max: {max}")
        Console.WriteLine($"Min: {min}")
    End Sub

End Class
