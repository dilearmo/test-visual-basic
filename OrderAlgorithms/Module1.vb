﻿Module Module1

    Sub Main()


        'PrintTriangularTree.PrintTriangularTree(9)

        'Dim array = New Integer() {2, 8, 9, 1, 4, 3, 0, 15, 8, 15, 8, 9}

        'Console.WriteLine(array.ToString())

        'Dim quickSort As New QuickSort
        'quickSort.Sort(array)
        'Console.WriteLine(String.Join(",", quickSort.Order(array)))

        'Console.WriteLine(quickSort.Order(array).ToString())

        'Dim mergeSort As New MergeSort
        'mergeSort.Sort(array)

        'Console.WriteLine()

        'Dim tree As Node = Nothing
        'Dim vertices As Integer() = {10, 5, 2, 3, 6, 45, 8, 9, 12, 11, 98, 0, 54}
        'For Each i As Integer In vertices
        '    Node.IncludeNode(tree, i)
        'Next

        'Dim profundidad As Integer = GraphResolver.CalcularProfundidad(tree)
        'Dim anchura As Integer = GraphResolver.CalcularAnchura(tree)

        'Dim sumaPorNiveles = GraphResolver.SumatoriaPorNivel(tree)
        'For i = 0 To sumaPorNiveles.Count - 1
        '    Console.WriteLine($"Nivel {i + 1}: {sumaPorNiveles(i)}")
        'Next

        'Dim sumaNivelX = GraphResolver.SumatoriaNivelX(tree, 2)

        'Console.ReadLine()

        ''''''' Obtener 5 mayor valor del arbol
        'Dim list As New List(Of Integer)
        'GraphResolver.PostOrder(tree, list)

        'Console.WriteLine($"Fifth max value: {list(4)}")

        'Dim maxValue As Integer? = Nothing
        'GraphResolver.GetMaxNthValue(tree, 5, maxValue)
        'Console.WriteLine($"Nth max value: {maxValue}")

        'GraphResolver.PreOrden(tree)

        'Console.WriteLine("-------------------------------------------------")

        'GraphResolver.PostOrden(tree)

        'Console.WriteLine("-------------------------------------------------")

        'GraphResolver.InOrder(tree)

        'Console.WriteLine("-------------------------------------------------")

        'GraphResolver.InInverseOrder(tree)

        'Console.WriteLine("-------------------------------------------------")
        'Dim arr() As Integer = {1, 3, 5, 4, 2}
        'Mio.GetMaxAndMin(arr, 4)

        'Mio.AreIsomorph("COCO", "CACA")

        'Mio.CuadroMagico({"HOLA", "OLLA", "LLAR", "AARO"})

        'Console.WriteLine()

        'Dim nodeTest = New Node With {.Value = 8, .LeftChild = New Node With {.Value = 98}}
        'Dim copied As Node = nodeTest.Copy(nodeTest)
        'nodeTest.Value = 40
        'Console.WriteLine()

        'Dim strList() As String = {"Uno", "Dos", "Tres", "Cuatro", "Cinco"}
        'Dim objList As List(Of Node) = New List(Of Node)({New Node With {.Value = 5}, New Node With {.Value = 15}, New Node With {.Value = 50}})
        'Dim strTable As DataTable = strList.ToTable()
        'Dim objTable As DataTable = objList.ToTable()


        'Mio.PruebaExUsing()

#Region "Islas"

        'Dim islasCompilado() As Integer = {0, 1, 0, 2, 1, 0, 1, 2, 3, 2, 1, 2, 1} '6
        'Dim islas1() As Integer = {2, 0, 1, 3, 0, 1, 0, 0, 0} ' 4
        'Dim islas2() As Integer = {7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2} '20
        'Dim islas3() As Integer = {2, 0, 1, 3, 0, 2, 1, 1, 2} '7
        'Dim islas4 As Integer() = {3, 1, 0, 2, 1, 2, 1, 1, 1, 1, 1, 1, 1} '4
        'Dim islas5 As Integer() = {7, 0, 0, 0, 4, 2, 2, 0, 3, 0, 0, 2} '21
        'Dim islas6 As Integer() = {7, 1, 2, 0, 4, 3, 2, 0, 3, 3, 0, 2} '15
        'Dim islas7 As Integer() = {4, 0, 0, 0, 4, 3, 4, 0, 0, 0, 4} '25
        'Dim cantPozos = Isla.ContarPozos(islas7)

        'Console.WriteLine($"El total de pozos es {cantPozos}")

        'Console.Read()
#End Region


#Region "Grafos"

        Dim grafo = Graph.GetGraph()
        grafo.Iterate()

        Console.Read()

#End Region



    End Sub

End Module
