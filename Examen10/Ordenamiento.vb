Public Class Ordenamiento

    Public Shared Sub OrdenarArreglo(ByRef arreglo As Integer())
        Dim valor1 As Integer

        For x = 0 To arreglo.Length - 1
            For y = x + 1 To arreglo.Length - 1
                If arreglo(x) > arreglo(y) Then
                    valor1 = arreglo(x)
                    arreglo(x) = arreglo(y)
                    arreglo(y) = valor1
                End If
            Next
        Next
    End Sub

End Class
