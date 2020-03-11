Class Z
    Public Sub M()
        Console.WriteLine("Z.M")
    End Sub
    Public Overridable Sub P()
        Console.WriteLine("Z.P")
    End Sub
End Class

Class Y : Inherits Z
    Public Sub M()
        Console.WriteLine("Y.M")
    End Sub
    Public Overrides Sub P()
        Console.WriteLine("Y.P")
    End Sub
End Class

Class X : Inherits Y
    Public Sub M()
        Console.WriteLine("X.M")
    End Sub
End Class

Class W : Inherits X
    Public Sub M()
        Console.WriteLine("W.M")
    End Sub
End Class


Public Class POO_4
    Public Shared Sub Exec()
        Dim d As W = New W
        Dim a As Z = d
        Dim b As Y = d
        Dim c As X = d

        a.M()
        b.M()
        c.M()
        d.M()

        Dim b1 As Y = New Y
        Dim a1 As Z = b
        a1.P()
        b1.P()

        Console.ReadLine()
    End Sub
End Class