Public Class StringT

    Public Shared Function GetMaxTStringLength(t As String) As Integer
        Dim distinctChars = t.Distinct().ToArray()
        Dim currentChar = distinctChars(0)
        Dim auxIndex = 1

        Dim result = 0

        While auxIndex <= distinctChars.Length - 1
            For i = auxIndex To distinctChars.Length - 1
                Dim generatedTString = GenerateTString(t, currentChar, distinctChars(i))
                If Validate(generatedTString) Then
                    result = If(generatedTString.Length > result, generatedTString.Length, result)
                End If
            Next
            currentChar = distinctChars(auxIndex)
            auxIndex += 1
        End While
        Return result
    End Function

    Private Shared Function Validate(t As String) As Boolean
        If t.Length = 0 Then
            Return False
        End If

        Dim lastChar As Char = t(0)
        For i = 1 To t.Length - 1
            If lastChar = t(i) Then
                Return False
            End If
            lastChar = t(i)
        Next
        Return True
    End Function

    Private Shared Function GenerateTString(t As String, char1 As Char, char2 As Char) As String
        Dim generatedTString = t.Where(Function(c) c.Equals(char1) Or c.Equals(char2)).Select(Function(c) c)
        Return String.Join("", generatedTString)
    End Function
End Class
