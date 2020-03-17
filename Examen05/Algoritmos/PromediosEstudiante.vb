Public Class PromediosEstudiante

    Public Shared Function Promedio(est As Estudiante()) As Estudiante()
        For i = 0 To est.Length - 1
            For j = est.Length - 1 To i Step -1
                If est(i).Promedio < est(j).Promedio Then
                    Dim aux = est(i)
                    est(i) = est(j)
                    est(j) = aux
                End If
            Next
        Next
        Return est
    End Function

End Class

Public Class Estudiante
    Public Nombre As String
    Public Promedio As Double

    Public Overrides Function ToString() As String
        Return $"{Me.Nombre} - {Me.Promedio}"
    End Function
End Class