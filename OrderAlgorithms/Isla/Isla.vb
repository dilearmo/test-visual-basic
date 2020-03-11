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

End Class
