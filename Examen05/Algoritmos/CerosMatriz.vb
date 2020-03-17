Public Class CerosMatriz

    Public Shared Function CerosMatriz(matriz As Integer(,)) As Integer(,)
        Dim hayCero = False
        For i = 0 To matriz.GetUpperBound(0)
            For j = 0 To matriz.GetUpperBound(1)
                If matriz(i, j) = 0 And Not hayCero Then
                    hayCero = True
                    j = 0
                ElseIf hayCero Then
                    matriz(i, j) = 0
                End If
            Next
            hayCero = False
        Next
        Return matriz
    End Function

    Public Shared Sub ImprimirMatriz(matriz As Integer(,))
        For i = 0 To matriz.GetUpperBound(0)
            For j = 0 To matriz.GetUpperBound(1)
                Console.Write(matriz(i, j) & " ")
                If j = matriz.GetUpperBound(1) Then
                    Console.WriteLine()
                End If
            Next
        Next
    End Sub

End Class
