Public Class Anagrama
    Public Shared Function EsAnagrama(p1 As String, p2 As String) As Boolean
        For Each letra In p1
            If Not p2.Contains(letra) Then
                Return False
            End If
        Next
        Return True
    End Function
End Class
