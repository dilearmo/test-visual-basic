Public Class GraphResolver

    Public Shared Sub PreOrden(tree As Node)
        If (tree IsNot Nothing) Then
            Console.WriteLine(tree.Value)
            PreOrden(tree.LeftChild)
            PreOrden(tree.RigthChild)
        End If
    End Sub

    Public Shared Sub PostOrden(tree As Node)
        If (tree IsNot Nothing) Then
            PostOrden(tree.LeftChild)
            PostOrden(tree.RigthChild)
            Console.WriteLine(tree.Value)
        End If
    End Sub

    Public Shared Sub InOrder(tree As Node)
        If (tree IsNot Nothing) Then
            InOrder(tree.LeftChild)
            Console.WriteLine(tree.Value)
            InOrder(tree.RigthChild)
        End If
    End Sub

    Public Shared Sub InInverseOrder(tree As Node)
        If (tree IsNot Nothing) Then
            InInverseOrder(tree.RigthChild)
            Console.WriteLine(tree.Value)
            InInverseOrder(tree.LeftChild)
        End If
    End Sub
End Class
