Public Class Ejercicio10
    Public Shared Function AlvaroMatrizRecursiva(matriz As Integer(,), fila As Integer, col As Integer, ByRef sum As Integer)
        sum += matriz(fila, col)

        If fila < matriz.GetUpperBound(0) Then
            If col < matriz.GetUpperBound(1) Then
                AlvaroMatrizRecursiva(matriz, fila, col + 1, sum)
            End If
            AlvaroMatrizRecursiva(matriz, fila + 1, col, sum)
        End If
        Return sum
    End Function



    Public Shared Function YimiSumeMatriz(ByVal m As Integer(,), ByRef i As Integer, ByRef j As Integer,
                                      Optional ByRef salida As Integer = 0)
        If i < 4 Then
            If j = 2 Then
                j = 0
                i += 1
            End If
            salida += m(i, j)
            j += 1
            YimiSumeMatriz(m, i, j, salida)
        End If
        Return salida
    End Function

    Public Shared Function SumaMatrizBrandon(matriz As Integer(,))
        Dim result As Integer
        _SumaMatrizBrandon(0, result, matriz)
        Return result
    End Function

    Private Shared Sub _SumaMatrizBrandon(fila As Integer, ByRef suma As Integer, arr(,) As Integer)
        If fila > UBound(arr) Then
            Return
        End If
        For i = 0 To UBound(arr, 2)
            suma += arr(fila, i)
        Next
        _SumaMatrizBrandon(fila + 1, suma, arr)
    End Sub

End Class
