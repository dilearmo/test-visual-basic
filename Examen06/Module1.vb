Module Module1

    Sub Main()

        'Dim arr = {1, 2, 4, 5, 5, 3, 3, 3, 3, 3}
        ''Ejercicio9.AlvaroObtenerRepeticiones(arr)
        'Console.WriteLine(Ejercicio9.YimiSumL(0, arr.ToList(), New Dictionary(Of Integer, Integer)))
        'arr = {2, 1, 1, 1, 1}
        ''Ejercicio9.AlvaroObtenerRepeticiones(arr)
        'Console.WriteLine(Ejercicio9.YimiSumL(0, arr.ToList(), New Dictionary(Of Integer, Integer)))
        'arr = {1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1}
        ''Ejercicio9.AlvaroObtenerRepeticiones(arr)
        'Console.WriteLine(Ejercicio9.YimiSumL(0, arr.ToList(), New Dictionary(Of Integer, Integer)))
        'arr = {1, 1, 1, 1, 2, 0, 5, 4, 3, 5, 4}
        ''Ejercicio9.AlvaroObtenerRepeticiones(arr)
        'Console.WriteLine(Ejercicio9.YimiSumL(0, arr.ToList(), New Dictionary(Of Integer, Integer)))
        'arr = {5, 5, 5, 5, 2, 3, 3, 3, 3, 3, 3, 3, 3, 4}
        ''Ejercicio9.AlvaroObtenerRepeticiones(arr)
        'Console.WriteLine(Ejercicio9.YimiSumL(0, arr.ToList(), New Dictionary(Of Integer, Integer)))

        Dim matriz1 = {
            {1, 1, 1},
            {1, 1, 1},
            {1, 1, 1},
            {1, 1, 1}
        }

        'Console.WriteLine($"La suma de la matriz es: {Ejercicio10.AlvaroMatrizRecursiva(matriz1, 0, 0, 0)}")
        Console.WriteLine($"Suma de matriz Yimi: {Ejercicio10.YimiSumeMatriz(matriz1, 0, 0).ToString()}")

        Console.ReadLine()

    End Sub

End Module
