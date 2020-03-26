Public Class Puentes

    Public Shared Function ValidarPuenteArturo(c As String) As Boolean
        If Not c(0).Equals("*"c) Or Not (c(c.Length - 1).Equals("*"c)) Then
            Return False
        End If

        If (c.Length > 2) Then
            Dim a() = c.Split("+")
            Dim contador As Integer = 0
            Dim aux = ""

            For i = 0 To a.Length - 1
                aux = a(i)
                For j = 0 To aux.Length - 1
                    If aux(j).Equals("="c) Then
                        contador += 1
                    End If
                Next
                If (a.Length Mod 2 = 0 And contador > 2) Then
                    Return False
                ElseIf a.Length Mod 2 <> 0 And i = Math.Ceiling(a.Length / 2) Then
                    If contador < 1 Or contador > 3 Then
                        Return False
                    End If
                End If
                aux = ""
                contador = 0
            Next

            If a.Length Mod 2 = 0 Then
                Dim medio As Integer = a.Length / 2
                Dim one As String = ""

                For i = 0 To medio - 1
                    one += a(i)
                Next

                Dim two = ""

                For j = a.Length - 1 To medio Step -1
                    two += a(j)
                Next
                If Not one.Equals(two) Then
                    Return False
                End If
            End If
        End If
        Return True
    End Function



End Class
