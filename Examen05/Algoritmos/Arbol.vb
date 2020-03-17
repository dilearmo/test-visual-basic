Public Class Arbol

    Private Shared Sub RecorrerArbol(nodo As TreeNode, pila As IList(Of Integer))
        Dim cola As New Queue(Of TreeNode)
        cola.Enqueue(nodo)
        While cola.Count > 0
            Dim cabeza = cola.Dequeue()
            pila.Add(cabeza.Value)
            If cabeza.LeftNode IsNot Nothing Then
                cola.Enqueue(cabeza.LeftNode)
            End If
            If cabeza.RigthNode IsNot Nothing Then
                cola.Enqueue(cabeza.RigthNode)
            End If
        End While
    End Sub

    Public Shared Function ObtenerHojas(nodo As TreeNode) As IList(Of Integer)
        Dim hojas As New List(Of Integer)
        RecorrerArbol(nodo, hojas)
        Return hojas
    End Function

End Class

Public Class TreeNode
    Public Property Value As Double
    Public Property LeftNode As TreeNode
    Public Property RigthNode As TreeNode

    Public Shared Sub CrearArbol(ByRef parent As TreeNode, value As Double)
        If parent Is Nothing Then
            parent = New TreeNode With {.Value = value}
        ElseIf value < parent.Value Then
            CrearArbol(parent.LeftNode, value)
        Else
            CrearArbol(parent.RigthNode, value)
        End If
    End Sub

End Class
