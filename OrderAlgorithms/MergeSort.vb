Imports OrderAlgorithms

Public Class MergeSort : Implements ISorter
    Public Function Sort(array As Integer()) As Integer() Implements ISorter.Sort
        Dim orderedArr = _MergeSort(array, 0, array.Length - 1)

        Return orderedArr
    End Function

    Private Function _MergeSort(ByRef arr() As Integer, lowIndex As Integer, highIndex As Integer) As Integer()
        If (lowIndex < highIndex) Then
            Dim midIndex = Math.Floor((lowIndex + highIndex) / 2)
            _MergeSort(arr, lowIndex, midIndex)
            _MergeSort(arr, midIndex + 1, highIndex)
            _Merge(arr, lowIndex, midIndex, highIndex)
        End If
        Return arr
    End Function

    Private Sub _Merge(ByRef arr() As Integer, lowIndex As Integer, midIndex As Integer, highIndex As Integer)
        Dim n1 As Integer = midIndex - lowIndex + 1
        Dim n2 As Integer = highIndex - midIndex

        Dim L(n1) As Integer
        Dim R(n2) As Integer

        Dim k As Integer = lowIndex

        Dim counterI As Integer = 0
        Dim counterJ As Integer = 0

        While (counterI < n1)
            L(counterI) = arr(lowIndex + counterI)
            counterI += 1
        End While

        While (counterJ < n2)
            R(counterJ) = arr(midIndex + 1 + counterJ)
            counterJ += 1
        End While

        k = lowIndex
        Dim i As Integer = 0
        Dim j As Integer = 0

        While (i < n1 And j < n2)
            If (L(i) < R(j)) Then
                arr(k) = L(i)
                i += 1
            Else
                arr(k) = R(j)
                j += 1
            End If
            k += 1
        End While

        While (i < n1)
            arr(k) = L(i)
            i += 1
            k += 1
        End While

        While (j < n2)
            arr(k) = R(j)
            j += 1
            k += 1
        End While

        Console.WriteLine("The sorted array with the Merge Sort is:")
        For indx As Integer = 0 To arr.Length - 1
            Console.Write(arr(indx) & " ")
        Next
        Console.WriteLine()
    End Sub

End Class
