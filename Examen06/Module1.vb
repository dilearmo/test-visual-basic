Imports System.IO

Module Module1

    Sub Main()

        'Dim arr = {1, 2, 4, 5, 5, 3, 3, 3, 3, 3}
        ''Ejercicio9.AlvaroObtenerRepeticiones(arr)
        ''Console.WriteLine(Ejercicio9.YimiSumL(0, arr.ToList(), New Dictionary(Of Integer, Integer)))
        'Ejercicio9.MayorRepeticionesBrandon(New List(Of Integer)(arr))
        'arr = {2, 1, 1, 1, 1}
        ''Ejercicio9.AlvaroObtenerRepeticiones(arr)
        ''Console.WriteLine(Ejercicio9.YimiSumL(0, arr.ToList(), New Dictionary(Of Integer, Integer)))
        'Ejercicio9.MayorRepeticionesBrandon(New List(Of Integer)(arr))
        'arr = {1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1}
        ''Ejercicio9.AlvaroObtenerRepeticiones(arr)
        ''Console.WriteLine(Ejercicio9.YimiSumL(0, arr.ToList(), New Dictionary(Of Integer, Integer)))
        'Ejercicio9.MayorRepeticionesBrandon(New List(Of Integer)(arr))
        'arr = {1, 1, 1, 1, 2, 0, 5, 4, 3, 5, 4}
        ''Ejercicio9.AlvaroObtenerRepeticiones(arr)
        ''Console.WriteLine(Ejercicio9.YimiSumL(0, arr.ToList(), New Dictionary(Of Integer, Integer)))
        'Ejercicio9.MayorRepeticionesBrandon(New List(Of Integer)(arr))
        'arr = {5, 5, 5, 5, 2, 3, 3, 3, 3, 3, 3, 3, 3, 4}
        ''Ejercicio9.AlvaroObtenerRepeticiones(arr)
        ''Console.WriteLine(Ejercicio9.YimiSumL(0, arr.ToList(), New Dictionary(Of Integer, Integer)))
        'Ejercicio9.MayorRepeticionesBrandon(New List(Of Integer)(arr))

        Dim matriz1 = {
            {1, 1, 1},
            {1, 1, 1},
            {1, 1, 1},
            {1, 1, 1}
        }

        ''Console.WriteLine($"La suma de la matriz es: {Ejercicio10.AlvaroMatrizRecursiva(matriz1, 0, 0, 0)}")
        'Console.WriteLine($"Suma de matriz Yimi: {Ejercicio10.YimiSumeMatriz(matriz1, 0, 0).ToString()}")

        Console.WriteLine($"La suma de la matriz es: {Ejercicio10.SumaMatrizBrandon(matriz1)}")

        'Console.WriteLine(DistanciaPalabras("VERDE", "DIEGO"))



        Console.ReadLine()

    End Sub


    Public Function DistanciaPalabras(ByVal p1 As String, ByVal p2 As String) As Integer
        Dim texto = File.ReadAllText("c:\texto.txt")
        Dim listaPalabras = texto.Split(" ")
        Dim distancias As New List(Of Integer)
        Dim contador As Integer = 1
        Dim encontrada As String = String.Empty

        For Each p In listaPalabras
            If (p.Equals(p1) OrElse p.Equals(p2)) Then
                encontrada = If(encontrada.Length = 0, If(p.Equals(p1), p1, p2), encontrada)
                If p.Equals(encontrada) Then
                    contador = 1
                Else
                    distancias.Add(contador)
                    contador = 1
                    encontrada = p
                End If
            ElseIf contador > 0 Then
                contador += 1
            End If
        Next

        If distancias.Count > 0 Then
            distancias.Sort()
            Return distancias(0)
        End If
        Return 0
    End Function

    Public Function DistanciaPalabrass(ByVal p1 As String, ByVal p2 As String) As Integer
        Dim texto = File.ReadAllText("c:\texto.txt")
        Dim listaPalabras = texto.Split(" ")
        Dim menorDistancia As Integer? = Nothing
        Dim contador As Integer = 0
        Dim encontrada As String = String.Empty

        For Each p In listaPalabras
            If (p.Equals(p1) OrElse p.Equals(p2)) Then
                encontrada = If(encontrada.Length = 0, If(p.Equals(p1), p1, p2), encontrada)
                If p.Equals(encontrada) Then
                    contador = 0
                Else
                    menorDistancia = If(menorDistancia Is Nothing, contador, If(contador < menorDistancia, contador, menorDistancia))
                    contador = 0
                    encontrada = p
                End If
            ElseIf contador >= 0 Then
                contador += 1
            End If
        Next

        Return If(menorDistancia Is Nothing, 0, menorDistancia)
    End Function


End Module
