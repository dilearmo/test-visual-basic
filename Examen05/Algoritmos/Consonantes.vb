Public Class Consonantes

    Public Shared Function Consonantes(cadena As String) As Integer
        Dim vocales = "aeiou"
        Dim cons = 0
        For Each letra In cadena
            If Not vocales.Contains(letra) Then
                cons += 1
            End If
        Next
        Return cons
    End Function

End Class
