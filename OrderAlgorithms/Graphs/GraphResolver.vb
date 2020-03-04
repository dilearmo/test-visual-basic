Public Class GraphResolver

    Public Shared Sub InOrder(tree As Node)
        If (tree IsNot Nothing) Then
            Console.WriteLine(tree.Value)
            InOrder(tree.LeftChild)
            InOrder(tree.RigthChild)
        End If
    End Sub

    Public Shared Sub NiIdea(tree As Node)
        If (tree IsNot Nothing) Then
            NiIdea(tree.LeftChild)
            NiIdea(tree.RigthChild)
            Console.WriteLine(tree.Value)
        End If
    End Sub

    Public Shared Sub PreOrden(tree As Node, Optional ByRef arr As List(Of Integer) = Nothing)
        If (tree IsNot Nothing) Then
            PreOrden(tree.LeftChild, arr)
            Console.WriteLine(tree.Value)
            If arr IsNot Nothing Then
                arr.Add(tree.Value)
            End If
            PreOrden(tree.RigthChild, arr)
        End If
    End Sub

    Public Shared Sub PostOrder(tree As Node, Optional ByRef arr As List(Of Integer) = Nothing)
        If (tree IsNot Nothing) Then
            PostOrder(tree.RigthChild, arr)
            Console.WriteLine(tree.Value)
            If arr IsNot Nothing Then
                arr.Add(tree.Value)
            End If
            PostOrder(tree.LeftChild, arr)
        End If
    End Sub


    Public Shared Sub GetMaxNthValue(tree As Node, ByRef n As Integer, Optional ByRef result As Integer? = Nothing)
        If result Is Nothing AndAlso tree IsNot Nothing Then
            GetMaxNthValue(tree.RigthChild, n, result)
            If n = 1 Then
                result = tree.Value
            End If
            n -= 1
            GetMaxNthValue(tree.LeftChild, n, result)
        End If
    End Sub

    Public Shared Function CalcularProfundidad(tree As Node, Optional ByRef result As Integer = 0,
                                          Optional profundidad As Integer = 0)
        If tree IsNot Nothing Then
            profundidad += 1
            result = If(profundidad > result, profundidad, result)
            CalcularProfundidad(tree.LeftChild, result, profundidad)
            CalcularProfundidad(tree.RigthChild, result, profundidad)
        End If
        Return result
    End Function

    Public Shared Function CalcularAnchura(tree As Node,
                                             Optional ByRef list As List(Of Integer) = Nothing,
                                             Optional currentLevel As Integer = 1) As Integer
        If tree IsNot Nothing Then
            If list Is Nothing Then list = New List(Of Integer)
            If currentLevel > list.Count Then
                list.Add(1)
            Else
                list(currentLevel - 1) += 1
            End If

            CalcularAnchura(tree.LeftChild, list, currentLevel + 1)
            CalcularAnchura(tree.RigthChild, list, currentLevel + 1)
        End If
        Return list.Max
    End Function

    Public Shared Function SumatoriaPorNivel(tree As Node,
                                             Optional ByRef list As List(Of Integer) = Nothing,
                                             Optional currentLevel As Integer = 1) As List(Of Integer)
        If tree IsNot Nothing Then
            If list Is Nothing Then list = New List(Of Integer)
            If currentLevel > list.Count Then
                list.Add(tree.Value)
            Else
                list(currentLevel - 1) += tree.Value
            End If

            SumatoriaPorNivel(tree.LeftChild, list, currentLevel + 1)
            SumatoriaPorNivel(tree.RigthChild, list, currentLevel + 1)
        End If
        Return list
    End Function

    Public Shared Function SumatoriaNivelX(tree As Node, level As Integer,
                                             Optional ByRef result As Integer = 0,
                                             Optional currentLevel As Integer = 1) As Integer
        If tree IsNot Nothing AndAlso level > 0 Then
            If level = currentLevel Then
                result += tree.Value
            Else
                SumatoriaNivelX(tree.LeftChild, level, result, currentLevel + 1)
                SumatoriaNivelX(tree.RigthChild, level, result, currentLevel + 1)
            End If
        End If
        Return result
    End Function

End Class
