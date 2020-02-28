Imports OrderAlgorithms

Public Class QuickSort : Implements ISorter
    Public Function Sort(array As Integer()) As Integer() Implements ISorter.Sort
        Dim orderedArr = _QuickSort(array, 0, array.Length - 1)

        Return orderedArr
    End Function

    Private Function _QuickSort(ByRef array As Integer(), ByVal inLow As Integer, ByVal inHi As Integer) As Integer()
        ' 1-	Implemente el método de ordenamiento de arreglos QuickSort
        ' Dim arr As Integer(5)
        ' Dim arr(5) As Integer
        ' Dim array = New Integer() {2, 8, 9, 1, 4, 3, 0, 15, 8, 15, 8, 9}

        Dim pivot As Integer
        Dim tempSwap As Integer
        Dim tempLow As Integer = inLow
        Dim tempHi As Integer = inHi

        pivot = array(Math.Floor((inLow + inHi) / 2))

        While (tempLow <= tempHi)
            While (array(tempLow) < pivot And tempLow < inHi)
                tempLow += 1
            End While

            While (pivot < array(tempHi) And tempHi > inLow)
                tempHi -= 1
            End While

            If (tempLow <= tempHi) Then
                tempSwap = array(tempLow)
                array(tempLow) = array(tempHi)
                array(tempHi) = tempSwap
                tempLow += 1
                tempHi -= 1
            End If
        End While

        If (inLow < tempHi) Then _QuickSort(array, inLow, tempHi)
        If (tempLow < inHi) Then _QuickSort(array, tempLow, inHi)

        Return array
    End Function

End Class
