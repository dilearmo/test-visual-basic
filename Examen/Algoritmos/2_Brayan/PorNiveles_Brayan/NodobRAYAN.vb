Public Class RecorrerArbolBrayan
    Public Shared Sub PorNiveles(raiz As NodoAlg2)
        Dim niveles = 0
        _Niveles(raiz, niveles)
        For i = 0 To niveles
            Imprimir(raiz, i)
        Next
    End Sub

    Private Shared Sub _Niveles(raiz As NodoAlg2, ByRef niveles As Integer, Optional aux As Integer = 0)
        If raiz Is Nothing Then
            Return
        End If
        _Niveles(raiz.Iz, niveles, aux + 1)
        If niveles < aux Then
            niveles = aux
        End If
        _Niveles(raiz.Dr, niveles, aux + 1)

    End Sub

    Private Shared Sub Imprimir(raiz As NodoAlg2, nivel As Integer, Optional ByRef aux As Integer = 0)
        If raiz Is Nothing Then
            Return
        End If
        Imprimir(raiz.Iz, nivel, aux + 1)
        If aux = nivel Then
            Console.Write($"{raiz.Valor}, ")
        End If
        Imprimir(raiz.Dr, nivel, aux + 1)
    End Sub
End Class