Public Class Ejercicio_1

    Public Shared Function valida()
        Try
            validacion()
        Catch ex As Exception
            Throw
        Catch ex As NotImplementedException
            Throw ex
        End Try
    End Function

    Private Shared Function validacion()
        Throw New NotImplementedException
    End Function

End Class
