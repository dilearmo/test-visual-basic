Public Class Isla

    Public Shared Function ContarPozos_V1(ByRef arrIslas As Integer()) As Integer
        Dim totalPozos As Integer = 0
        Dim ultimoMasAlto As Integer = 0
        Dim segundoMasAlto As Integer = 0

        Dim pozosDesdeDeUltimoMasAlto As Integer = 0
        Dim pozosDesdeSegundoMasAlto As Integer = 0

        For i As Integer = 0 To arrIslas.Length - 1
            If arrIslas(i) >= ultimoMasAlto Then
                If pozosDesdeDeUltimoMasAlto > 0 Then
                    totalPozos += pozosDesdeDeUltimoMasAlto
                    pozosDesdeDeUltimoMasAlto = 0
                    pozosDesdeSegundoMasAlto = 0
                End If
                ultimoMasAlto = arrIslas(i)
                segundoMasAlto = 0
            Else
                pozosDesdeDeUltimoMasAlto += ultimoMasAlto - arrIslas(i)

                If arrIslas(i) >= segundoMasAlto Then
                    segundoMasAlto = arrIslas(i)
                    totalPozos += pozosDesdeSegundoMasAlto
                    pozosDesdeDeUltimoMasAlto -= pozosDesdeSegundoMasAlto
                    pozosDesdeSegundoMasAlto = 0
                Else
                    pozosDesdeSegundoMasAlto += segundoMasAlto - arrIslas(i)
                End If
            End If
        Next

        Return totalPozos
    End Function

    Public Shared Function ContarPozos(ByRef arrIslas As Integer()) As Integer
        Dim totalPozos As Integer = 0
        Dim ultimoMasAlto As Integer = 0
        Dim segundoMasAlto As Integer = 0

        Dim pozosDesdeDeUltimoMasAlto As Integer = 0
        Dim pasosDesdeMasAlto As Integer = 0
        Dim pasosDesdeMasAltoHastaSegundo As Integer = 0
        Dim yaContados As Integer = 0

        For i As Integer = 0 To arrIslas.Length - 1
            If arrIslas(i) >= ultimoMasAlto Then
                If pozosDesdeDeUltimoMasAlto > 0 Then
                    totalPozos += pozosDesdeDeUltimoMasAlto
                    pozosDesdeDeUltimoMasAlto = 0
                    pasosDesdeMasAlto = 0
                    yaContados = 0
                    pasosDesdeMasAltoHastaSegundo = 0
                End If
                ultimoMasAlto = arrIslas(i)
            Else
                pozosDesdeDeUltimoMasAlto += ultimoMasAlto - arrIslas(i)

                If arrIslas(i) > segundoMasAlto Then
                    segundoMasAlto = arrIslas(i)
                    pasosDesdeMasAltoHastaSegundo = pasosDesdeMasAlto + 1
                End If

                If arrIslas(i) > 0 AndAlso pasosDesdeMasAlto > 0 Then
                    Dim asegurados = arrIslas(i) * pasosDesdeMasAlto - (yaContados -
                       If(arrIslas(i) < segundoMasAlto, (segundoMasAlto - arrIslas(i)) * pasosDesdeMasAltoHastaSegundo, 0))

                    If asegurados > 0 Then
                        totalPozos += asegurados
                        pozosDesdeDeUltimoMasAlto -= asegurados
                        yaContados += asegurados
                    End If
                End If

                yaContados += arrIslas(i)
                pasosDesdeMasAlto += 1
            End If
        Next

        Return totalPozos
    End Function


    Public Sub ValidarIslasJoel(listaIslas As Integer())
        Dim nivel = 0
        Dim posminimoInicial = 0
        Dim posMinimoFinal = listaIslas.Length - 1
        Dim cantidadPozos = 0
        Dim max = listaIslas.Max()
        While nivel < max
            While listaIslas(posminimoInicial) < nivel + 1 'adelanto posiciones mientras encuentro un valor inicial alto o mayor a mi nivel
                posminimoInicial += 1
            End While
            While listaIslas(posMinimoFinal) <= nivel 'atraso posiciones mientras encuentro un valor final alto o que cumpla con el nivel
                posMinimoFinal -= 1
            End While
            For x = posminimoInicial To posMinimoFinal 'recorro el nivel
                If listaIslas(x) <= nivel Then
                    cantidadPozos += 1
                End If
            Next
            nivel += 1
        End While
        Console.WriteLine("validar islas 2 cantidad de pozos " + cantidadPozos.ToString)
    End Sub

End Class
