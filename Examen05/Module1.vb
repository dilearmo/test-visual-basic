Module Module1

    Sub Main()
        'Ejercicio9.Imprimir()
        'Dim x As Integer = 5
        'Dim y = x

        'Alterar1(x)
        'Console.WriteLine("X: " & x)
        'Console.WriteLine("Y: " & y)
        'Alterar2(x)
        'Console.WriteLine("X: " & x)
        'Console.WriteLine("Y: " & y)
        'Alterar1(y)
        'Console.WriteLine("X: " & x)
        'Console.WriteLine("Y: " & y)
        'Alterar2(y)
        'Console.WriteLine("X: " & x)
        'Console.WriteLine("Y: " & y)

        Dim matriz As Integer(,) = {
            {1, 2, 3, 4, 5, 6, 7},
            {1, 2, 3, 4, 5, 6, 7},
            {1, 2, 3, 4, 5, 6, 7},
            {1, 2, 3, 4, 5, 0, 7},
            {1, 2, 3, 4, 5, 6, 7}}

        CerosMatriz.ImprimirMatriz(matriz)
        Console.WriteLine("----------------------------")
        CerosMatriz.CerosMatriz(matriz)
        CerosMatriz.ImprimirMatriz(matriz)

        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()

        Dim cadena = "aeiou, AEIOU, Hola"
        Console.WriteLine($"Cantidad de consonantes en {cadena}: {Consonantes.Consonantes(cadena)}")


        Dim ests As Estudiante() = {
            New Estudiante With {.Nombre = "Est1", .Promedio = 9.99},
            New Estudiante With {.Nombre = "Est1", .Promedio = 5.2},
            New Estudiante With {.Nombre = "Est1", .Promedio = 7.8},
            New Estudiante With {.Nombre = "Est1", .Promedio = 5.3},
            New Estudiante With {.Nombre = "Est1", .Promedio = 6.5},
            New Estudiante With {.Nombre = "Est1", .Promedio = 10},
            New Estudiante With {.Nombre = "Est1", .Promedio = 3}
        }

        Dim res = PromediosEstudiante.Promedio(ests)
        For Each e In res
            Console.WriteLine(e)
        Next

        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()

        Dim palabra1 = "CASAS",
            palabra2 = "SAC"
        Console.WriteLine($"¿'{palabra1}' y {palabra2}' son anagramas? R/ {Anagrama.EsAnagrama(palabra1, palabra2)}")

        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()

        Dim arrHojas = {6, 4, 8, 2, 1, 0, 9, 3, 5, 7}

        Dim tree As TreeNode = Nothing
        For Each e In arrHojas
            TreeNode.CrearArbol(tree, e)
        Next

        Console.WriteLine($"Las hojas son: {String.Join(",", Arbol.ObtenerHojas(tree))}")

        Console.Read()


    End Sub


    Sub Alterar1(ByVal i As Integer)
        i += 1
    End Sub

    Sub Alterar2(ByRef i As Integer)
        i += 1
    End Sub


End Module
