Public Class Node
    Public Property Value As Integer
    Public Property ParentNode As Node
    Public Property LeftChild As Node
    Public Property RigthChild As Node

    Public Shared Sub IncludeNode(ByRef node As Node, ByVal value As Integer)
        If node IsNot Nothing Then
            If value < node.Value Then
                If node.LeftChild Is Nothing Then
                    node.LeftChild = New Node With {.Value = value}
                Else
                    IncludeNode(node.LeftChild, value)
                End If
            ElseIf node.RigthChild Is Nothing Then
                node.RigthChild = New Node With {.Value = value}
            Else
                IncludeNode(node.RigthChild, value)
            End If
        Else
            node = New Node With {.Value = value}
        End If
    End Sub
End Class
