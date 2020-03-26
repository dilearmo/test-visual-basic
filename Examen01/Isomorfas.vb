Public Class Isomorfas
    Public Shared Function SonIsomorfas(a As String, b As String) As Boolean
        Dim temporal As String
        If b IsNot Nothing Then
            For i = 0 To a.Length - 1
                temporal = temporal + a(i)
            Next
            If a = temporal Then
                Return True
            Else
                Return False
            End If
            SonIsomorfas(b, Nothing)
        End If
    End Function

End Class
