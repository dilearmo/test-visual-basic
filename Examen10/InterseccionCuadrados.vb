Public Class InterseccionCuadrados

    Public Shared Function Interseca(cuadrado1 As Cuadrado, cuadrado2 As Cuadrado)
        Dim resultado As Boolean = False

        Dim x1 = cuadrado1.Vertice1.x - cuadrado1.Vertice1.x Mod 10
        Dim y1 = cuadrado1.Vertice1.y - cuadrado1.Vertice2.y Mod 10
        Dim largo1 = cuadrado1.Vertice2.x - cuadrado1.Vertice1.x

        Dim x2 = cuadrado2.Vertice1.x - cuadrado2.Vertice1.x Mod 10
        Dim y2 = cuadrado2.Vertice1.y - cuadrado2.Vertice1.y Mod 10
        Dim largo2 = cuadrado2.Vertice2.x - cuadrado2.Vertice1.x

        If (x2 > x1 And x2 < x1 + largo1) Then
            For posy2 = y2 To y2 + largo1
                If posy2 > y1 And posy2 < y1 + largo1 Then
                    resultado = True
                End If
            Next
        Else
            If (y2 > y1 And y2 < y1 + largo1) Then
                For posx2 = x2 To x2 + largo2
                    If posx2 > x1 And posx2 < x1 + largo1 Then
                        resultado = True
                    End If
                Next
            End If
        End If
        If x2 < x1 And x2 + largo2 > x1 Then
            If y2 < y1 And y2 + largo2 > y1 Then
                resultado = True
            End If
        End If
        Return resultado
    End Function

End Class

Public Class Cuadrado
    Property Vertice1 As Vertice
    Property Vertice2 As Vertice
End Class

Public Class Vertice
    Public x As Integer
    Public y As Integer
End Class