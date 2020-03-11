Public Class Validador
    Public Shared Function EsNumeroPermitido(ByVal numero As Byte)
        If numero < 0 Then
            Return True
        End If
        Return False
    End Function

End Class
