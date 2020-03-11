Module Module1

    Sub Main()

        'Dim c1 As New Cuadrado With {
        '.Vertice1 = New Vertice With {
        '    .x = 1.5, .y = 3.5
        '},
        '.Vertice2 = New Vertice With {
        '    .x = 3.5, .y = 1.5
        '}}
        'Dim c2 As New Cuadrado With {
        '.Vertice1 = New Vertice With {
        '    .x = 3, .y = 2
        '},
        '.Vertice2 = New Vertice With {
        '    .x = 4, .y = 1
        '}}

        'InterseccionCuadrados.Interseca(c1, c2)
        Dim arr As Integer() = {9, 10, 61, 5, 3, 13, -98, 56, 7, 38, 9, 2, 0, 8}
        Ordenamiento.OrdenarArreglo(arr)
        Console.WriteLine($"Arreglo ordenado: {String.Join(",", arr)}")
        Console.Read()

    End Sub

End Module
