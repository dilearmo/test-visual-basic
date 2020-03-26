Module Module1

    Sub Main()

        'Console.WriteLine($"Puentes Arturo: {Puentes.ValidarPuenteArturo("*==+===+==*")}")
        'Console.WriteLine($"Puentes Arturo: {Puentes.ValidarPuenteArturo("*==+==+==*")}")
        'Console.WriteLine($"Puentes Arturo: {Puentes.ValidarPuenteArturo("**")}")
        'Console.WriteLine($"Puentes Arturo: {Puentes.ValidarPuenteArturo("==+====+==")}")
        'Console.WriteLine($"Puentes Arturo: {Puentes.ValidarPuenteArturo("*==+=+===+==*")}")

        'Console.WriteLine($"----------------------------------")
        'Console.WriteLine($"Puentes Arturo: {Puentes.ValidarPuenteArturo("*==+=====+==*")}")
        'Console.WriteLine($"Puentes Arturo: {Puentes.ValidarPuenteArturo("*===+===+===*")}")
        'Console.WriteLine($"Puentes Arturo: {Puentes.ValidarPuenteArturo("*==++++++==*")}")

        Dim nodo15 As New NodoAlg2 With {.Valor = 15}
        Dim nodo9 As New NodoAlg2 With {.Valor = 9}
        Dim nodo6 As New NodoAlg2 With {.Valor = 6}
        Dim nodo14 As New NodoAlg2 With {.Valor = 14}
        Dim nodo13 As New NodoAlg2 With {.Valor = 13}
        Dim nodo20 As New NodoAlg2 With {.Valor = 20}
        Dim nodo17 As New NodoAlg2 With {.Valor = 17}
        Dim nodo64 As New NodoAlg2 With {.Valor = 64}
        Dim nodo26 As New NodoAlg2 With {.Valor = 26}
        Dim nodo72 As New NodoAlg2 With {.Valor = 72}

        nodo14.Iz = nodo13
        nodo9.Iz = nodo6
        nodo9.Dr = nodo14
        nodo15.Iz = nodo9

        nodo64.Dr = nodo72
        nodo64.Iz = nodo26
        nodo20.Dr = nodo64
        nodo20.Iz = nodo17
        nodo15.Dr = nodo20

        'RecorrerArbol.PorNiveles(nodo15)
        'Dim m(,) As Integer = {
        '    {1, 0, 0, 0, 1},
        '    {1, 1, 0, 1, 1},
        '    {0, 1, 1, 0, 0}
        '}
        ''Console.WriteLine($"En la matriz hay {Matriz.MatrixArturo(m)} ceros")
        'Dim contadorBrayan = 0
        'Matriz.ContarCerosBrayan(m, contadorBrayan)
        'Console.WriteLine($"En la matriz Brayan hay {contadorBrayan} ceros")

        RecorrerArbolBrayan.PorNiveles(nodo15)

        Console.Read()

    End Sub

End Module
