Public Class RecorrerArbol
    Public Shared Sub PorNiveles(nodo As NodoAlg2)
        If nodo IsNot Nothing Then
            Console.Write($"{nodo.Valor.ToString}, ") 'No sirve
            PorNiveles(nodo.Iz)
            PorNiveles(nodo.Dr)
        End If
    End Sub
End Class