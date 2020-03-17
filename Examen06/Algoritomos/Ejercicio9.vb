Public Class Ejercicio9

    Public Shared Sub AlvaroObtenerRepeticiones(lista As IList(Of Integer))
        Dim reps = 0,
            reps2 = 0,
            pos = 0,
            pos2 = 0

        For i = pos To lista.Count - 1
            If lista(i) = lista(pos) Then
                reps += 1
            End If
            If i = lista.Count - 1 Then
                pos += 1
                If reps >= reps2 Then
                    reps2 = reps
                    pos2 = pos
                End If
            End If
        Next
        Console.WriteLine($"El elemento {lista(pos2)} tuvo la mayor cantidad de repeticiones: {reps2}")
    End Sub

    Public Shared Function YimiSumL(i As Integer, l As List(Of Integer), ByRef dic As Dictionary(Of Integer, Integer),
                                    ByRef Optional valor As Integer = 0, ByRef Optional repeticiones As Integer = 0)
        If i < l.Count Then
            If Not dic.ContainsKey(l(i)) Then
                dic.Add(l(i), 1)
            Else
                dic(l(i)) += 1
            End If

            YimiSumL((i + 1), l, dic, valor, repeticiones)
            If repeticiones < dic(l(i)) Then
                repeticiones = dic(l(i))
                valor = l(i)
            End If
            Return valor.ToString() + " se repite = " + repeticiones.ToString()
        End If
    End Function

End Class
