Imports System
Imports System.Configuration

Module Program
    Sub Main(args As String())
        'Sumatoria.SumatoriaYimi(New Integer() {1, 3, 5, 4, 2}, 4)
        'Sumatoria.SumatoriaYimi(New Integer() {10, 20, 30}, 2)
        'Sumatoria.SumatoriaYimi(New Integer() {13, 14}, 1)
        
        Sumatoria.SumatoriaAlvaro(New Integer() {1, 3, 5, 4, 2}, 4)
        Sumatoria.SumatoriaAlvaro(New Integer() {10, 20, 30}, 2)
        Sumatoria.SumatoriaAlvaro(New Integer() {13, 14}, 1)

        Console.ReadLine()
    End Sub
End Module
