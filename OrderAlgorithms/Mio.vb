Public Class Mio

    'Public algo1, algo2, algo3 As String
    'Public Sub New()

    'End Sub

    'Public Sub New(algo As String)
    '    Me.New()
    'End Sub

    Public Shared Sub GetMaxAndMin(ByRef arr As Integer(), n As Integer)
        arr = SortMio(arr)
        Dim max As Integer = 0
        Dim min As Integer = 0
        For i As Integer = 0 To n - 1
            min += arr(i)
        Next
        For j As Integer = arr.Length - 1 To arr.Length - n Step -1
            max += arr(j)
        Next
        Console.WriteLine($"Ordenado: {String.Join(",", arr)}")
        Console.WriteLine($"Max: {max}, Min: {min}")
    End Sub

    Private Shared Function SortMio(ByRef arr As Integer()) As Integer()
        For i As Integer = arr.Length - 1 To 0 Step -1
            For j As Integer = 0 To arr.Length - 1
                If (arr(i) < arr(j) AndAlso j < i) Then
                    Dim aux As Integer = arr(j)
                    arr(j) = arr(i)
                    arr(i) = aux
                End If
            Next
        Next
        Return arr
    End Function

    Public Shared Function AreIsomorph(p1 As String, p2 As String) As Boolean
        If (p1.Length <> p2.Length) Then
            Return False
        End If

        Dim dictionary = New Dictionary(Of String, String)
        For i As Integer = 0 To p1.Length - 1
            If Not (dictionary.ContainsKey(p1(i))) Then
                dictionary.Add(p1(i), p2(i))
            ElseIf (dictionary(p1(i)) <> p2(i)) Then
                Return False
            End If
        Next
        Return True
    End Function

    Public Shared Function CuadroMagico(listaPalabas As String()) As Boolean
        For i As Integer = 0 To listaPalabas.Length - 1
            Dim auxP As String = ""
            For Each p In listaPalabas
                auxP += p(i)
            Next
            If Not (listaPalabas(i).Equals(auxP)) Then Return False
        Next
        Return True
    End Function

End Class
