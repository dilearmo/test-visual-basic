Public Class GraphNode
    Public Property Value As Integer
    Public Property NodeList As List(Of GraphNode)
    Public Property Visited As Boolean = False

    Sub New(value As Integer, nodeList As List(Of GraphNode))
        Me.Value = value
        Me.NodeList = nodeList
    End Sub

End Class

Public Class Graph
    Public Property Root As GraphNode

    Public Sub Iterate()
        Me._Iterate(Root, "|--")
    End Sub

    Private Sub _Iterate(node As GraphNode, ByRef tabs As String)
        If node IsNot Nothing AndAlso Not node.Visited Then
            node.Visited = True
            Console.WriteLine($"{tabs}{node.Value}")
            For i As Integer = 0 To node.NodeList.Count - 1
                _Iterate(node.NodeList(i), $"   {tabs}")
            Next
        End If
    End Sub


    Public Shared Function GetGraph() As Graph
        Dim rootValue = 5

        Dim nodo_100 = New GraphNode(100, New List(Of GraphNode))

        Dim lista1 = New List(Of GraphNode)(
            {
                nodo_100,
                New GraphNode(26, New List(Of GraphNode))
            })

        Dim lista2 = New List(Of GraphNode)(
            {
                New GraphNode(23, New List(Of GraphNode)),
                New GraphNode(4, New List(Of GraphNode)),
                New GraphNode(3, New List(Of GraphNode)),
                New GraphNode(32, lista1),
                New GraphNode(21, New List(Of GraphNode)({nodo_100}))
            })


        Dim nodo_54 = New GraphNode(54, lista2)
        Dim nodo_2 = New GraphNode(2, New List(Of GraphNode)({nodo_54}))

        nodo_100.NodeList = New List(Of GraphNode)({nodo_2})

        Dim lista3 = New List(Of GraphNode)(
            {
                New GraphNode(11, New List(Of GraphNode)),
                nodo_54
            })

        Dim lista5 = New List(Of GraphNode)(
            {
                New GraphNode(1, New List(Of GraphNode)),
                New GraphNode(14, New List(Of GraphNode)),
                New GraphNode(0, New List(Of GraphNode))
            })

        Dim lista4 = New List(Of GraphNode)(
            {
                New GraphNode(6, lista5),
                New GraphNode(8, lista3),
                nodo_2
            })

        Return New Graph With {.Root = New GraphNode(rootValue, lista4)}

    End Function

End Class