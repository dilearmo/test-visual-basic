Module Module1

    Sub Main()


        Dim array = New Integer() {2, 8, 9, 1, 4, 3, 0, 15, 8, 15, 8, 9}

        Console.WriteLine(array.ToString())

        'Dim quickSort As New QuickSort
        'quickSort.Sort(array)
        'Console.WriteLine(String.Join(",", quickSort.Order(array)))

        'Console.WriteLine(quickSort.Order(array).ToString())

        'Dim mergeSort As New MergeSort
        'mergeSort.Sort(array)

        'Console.WriteLine()

        Dim tree As Node = Nothing
        Dim vertices As Integer() = {10, 5, 2, 3, 6, 45, 8, 9, 12, 11, 98, 0, 54}
        For Each i As Integer In vertices
            Node.IncludeNode(tree, i)
        Next

        'GraphResolver.PreOrden(tree)

        'Console.WriteLine("-------------------------------------------------")

        'GraphResolver.PostOrden(tree)

        'Console.WriteLine("-------------------------------------------------")

        'GraphResolver.InOrder(tree)

        'Console.WriteLine("-------------------------------------------------")

        'GraphResolver.InInverseOrder(tree)

        'Console.WriteLine("-------------------------------------------------")
        Dim arr() As Integer = {1, 3, 5, 4, 2}
        Mio.GetMaxAndMin(arr, 4)


        Mio.AreIsomorph("COCO", "CACA")

        Mio.CuadroMagico({"HOLA", "OLLA", "LLAR", "AARO"})

        Console.WriteLine()


    End Sub

End Module
