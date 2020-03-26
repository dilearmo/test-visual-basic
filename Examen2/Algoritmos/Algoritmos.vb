Public Class Algoritmos
    Public Shared Function Test()
        Dim list As New List(Of Grafo)
        Dim i = 0
        Dim o = list(1)?.Lista
    End Function

    Public Class Grafo
        Public Property Lista As List(Of String)
    End Class

#Region "Ordenar Vector Pares/Impares"
    Public Shared Sub OrdenarParesImpares(n As Integer)
        Dim arr(n - 1) As Integer
        For i As Integer = 0 To arr.Length - 1
            If i Mod 2 = 0 Then
                arr(i) = i * i + 1
            Else
                arr(i) = 3 * (i + 1)
            End If
        Next

        Console.WriteLine($"Desordenado: {String.Join(",", arr)}")

        Dim arrImpares As Integer() = arr.Where(Function(x) x Mod 2 > 0).ToArray()
        Array.Sort(arrImpares)

        Dim arrPares As Integer() = arr.Where(Function(x) x Mod 2 = 0).ToArray()
        Array.Sort(arrPares)
        Array.Reverse(arrPares)

        arr = arrPares.Concat(arrImpares).ToArray()

        Console.WriteLine($"Ordenado: {String.Join(",", arr)}")
    End Sub

#Region "Arturo"

    ' #1
    Public Shared Function BuscarFilasArturo(m1 As Integer(,), m2 As Integer(,)) As String
        Dim flag As Boolean = False
        Dim Salida As String = ""
        Dim temp1 As String = ""
        Dim temp2 As String = ""

        For i = 0 To m1.GetLength(0) - 1
            temp1 = m1(i, 0).ToString() & ", " & m1(i, 1).ToString() & ", " & m1(i, 2).ToString()
            For x = 0 To m2.GetLength(0) - 1
                temp2 = m2(x, 0).ToString() & ", " & m2(x, 1).ToString() & ", " & m2(x, 2).ToString()
                If (temp1 = temp2) Then
                    Salida += temp1 & " - "
                    Exit For
                End If
            Next
        Next
        Return Salida
    End Function

    Public Shared Function InvertirCadenaArturo(cad As String)
        Dim vec As String() = cad.Split(" ")
        Dim salida As String = ""
        For x = vec.Length - 1 To 0 Step -1
            salida += vec(x).ToString() & " "
        Next
        Return salida
    End Function

    Public Shared Function EsAnoBiciesto(ano As Integer) As String
        Dim salida As String
        If ((ano Mod 4 = 0 And ano Mod 100 <> 0) Or ano Mod 400 = 0) Then
            salida = $"Ano: {ano} si es biciesto"
        Else
            salida = $"Ano: {ano} no es biciesto"
        End If
        Return salida
    End Function

    Public Shared Function PosicionVector(cant As Integer) As Integer()
        Dim vector(cant - 1) As Integer
        Dim pares As Integer = 0
        Dim impares As Integer = 0

        For i = 0 To vector.Length - 1
            If i Mod 2 = 0 Then
                pares += 1
                vector(i) = i * i + 1
            Else
                impares += 1
                vector(i) = 3 * (i + 1)
            End If
            Console.WriteLine(vector(i).ToString())
        Next

        pares = pares - 1
        impares = impares - 1

        Dim vecPar(pares) As Integer
        Dim vecImpar(impares) As Integer

        For j = 0 To vector.Length - 1
            If vector(j) Mod 2 = 0 Then
                vecPar(pares) = vector(j)
                pares = pares - 1
            Else
                vecImpar(impares) = vector(j)
                impares = impares - 1
            End If
        Next
        vecPar = OrdenarArturo(vecPar, "D")
        vecImpar = OrdenarArturo(vecImpar, "A")

        For k = 0 To vecPar.Length - 1
            vector(k) = vecPar(k)
            Console.WriteLine(vector(k))
        Next

        For L = 0 To vecImpar.Length - 1
            vector(L) = vecImpar(L)
            Console.WriteLine(vector(L))
        Next

        Return vector

    End Function

    Private Shared Function OrdenarArturo(v As Integer(), tipo As String) As Integer()
        Dim aux = ""
        For i = 0 To v.Length - 1
            For j = 0 To v.Length - 1
                If v(j) < v(i) And i <> j And tipo = "A" Then
                    aux = v(j)
                    v(j) = v(i)
                    v(i) = aux
                ElseIf v(j) > v(i) And i <> j And tipo = "D" Then
                    aux = v(i)
                    v(i) = v(j)
                    v(j) = aux
                End If
            Next
        Next
        Return v
    End Function

#End Region

    Public Shared Sub InvertirClaribel(ByVal texto As String)
        Dim aux As String()
        Dim res As String
        aux = texto.Split(" ")

        For x = 0 To aux.Length - 1
            res = res + " " + aux(x)
        Next
        Console.WriteLine(res)
    End Sub

    Public Shared Sub recorridoClaribel(arbol As Nodo)
        If arbol.nivel?.Count > 0 Then
            For x As Integer = 0 To arbol.nivel.Count - 1
                recorridoClaribel(arbol.nivel(x))
            Next
        End If
        Console.WriteLine(arbol.dato)
    End Sub

    Public Shared Sub BiciestoClaribel(anno As Integer)
        Dim res = False
        Dim aux As Decimal = anno Mod 4
        If aux = 0 Then
            Dim multiplo = anno Mod 100
            If multiplo <> 0 Then
                multiplo = anno Mod 400
                If multiplo = 0 Then
                    res = True
                End If
            End If
        End If
        Console.WriteLine(res)
    End Sub

    Public Shared Sub ProgramaClaribel(pos As Integer)
        Dim vector(pos) As Integer
        For i = 0 To pos - 1
            Dim par As Integer = i Mod 2
            If par = 0 Then
                vector(i) = i * i + 1
            Else
                vector(i) = 3 * (i + 1)
            End If
        Next
        MostrarVectorClaribel(vector)
        Dim cont As Integer = 0, imp = pos - 1
        Dim nuevo(pos) As Integer
        For x = pos - 1 To 0 Step -1
            Dim par = x Mod 2
            If par = 0 Then
                nuevo(cont) = vector(x)
                cont += 1
            Else
                nuevo(imp) = vector(x)
                imp -= 1
            End If
        Next
        MostrarVectorClaribel(nuevo)
    End Sub

    Private Shared Sub MostrarVectorClaribel(vector As Integer())
        For Each a In vector
            Console.Write($"{a} ")
        Next
        Console.WriteLine()
    End Sub
#End Region
End Class

Public Class Nodo
    Public Property dato As Integer
    Public Property nivel As List(Of Nodo)

End Class

Public Class Arbol
    Public Property raiz As Nodo
End Class