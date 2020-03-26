Public Class Matriz

    Public Shared Function MatrixArturo(m(,) As Integer)
        Dim res = 0
        For i = 0 To m.GetLength(0) - 1
            For j = 0 To m.GetLength(1) - 1
                If (m(i, j) = 0) Then
                    res += 1
                End If
            Next
        Next
        Return res
    End Function

    Public Shared Sub ContarCerosBrayan(matriz As Integer(,), ByRef contador As Integer, Optional aux As Integer = 0)
        For i = 0 To matriz.GetLength(1) - 1
            If matriz(aux, i) = 0 Then
                contador += 1
            End If
        Next
        If matriz.GetLength(0) - 1 = aux Then
            Return
        Else
            ContarCerosBrayan(matriz, contador, aux + 1)
        End If
    End Sub

End Class
