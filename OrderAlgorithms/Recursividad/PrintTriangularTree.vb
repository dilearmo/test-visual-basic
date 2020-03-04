Public Class PrintTriangularTree
    Public Shared Sub PrintTriangularTree(n As Integer, Optional originalValue As Integer? = Nothing)
        If n > 0 Then
            PrintTriangularTree(n - 1, If(originalValue Is Nothing, n, originalValue))

            While originalValue > n
                Console.Write("  ")
                originalValue -= 1
            End While

            Dim aux As Integer = n * 2 - 1
            While aux > 0
                'Dim valueToPrint = If(n < 10, $"0{n}", n.ToString())
                Console.Write($"{n} ")
                aux -= 1
            End While
            Console.WriteLine()
        End If
    End Sub
End Class
