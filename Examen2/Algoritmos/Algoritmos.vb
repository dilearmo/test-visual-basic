Public Class Algoritmos
    Public Shared Function Test()
        Dim list As New List(Of Grafo)
        Dim i = 0
        Dim o = list(1)?.Lista
    End Function

    Public Class Grafo
        Public Property Lista As List(Of String)
    End Class

#Region "Ordenar Vector Pares/Impares"
    Public Shared Sub OrdenarParesImpares(n As Integer)
        Dim arr(n - 1) As Integer
        For i As Integer = 0 To arr.Length - 1
            If i Mod 2 = 0 Then
                arr(i) = i * i + 1
            Else
                arr(i) = 3 * (i + 1)
            End If
        Next

        Console.WriteLine($"Desordenado: {String.Join(",", arr)}")

        Dim arrImpares As Integer() = arr.Where(Function(x) x Mod 2 > 0).ToArray()
        Array.Sort(arrImpares)

        Dim arrPares As Integer() = arr.Where(Function(x) x Mod 2 = 0).ToArray()
        Array.Sort(arrPares)
        Array.Reverse(arrPares)

        arr = arrPares.Concat(arrImpares).ToArray()

        Console.WriteLine($"Ordenado: {String.Join(",", arr)}")
    End Sub
#End Region
End Class
