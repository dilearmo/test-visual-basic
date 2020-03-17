Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports VisualBasicTests

<TestClass()>
Public Class Validator

    <TestMethod()>
    Public Sub AreIsomorphTrueTest()
        Dim expectedResult As Boolean = True
        Dim result As Boolean = Mio.AreIsomorph("CALLE", "PERRO")
        Assert.AreEqual(result, expectedResult)
    End Sub

    <TestMethod()>
    Public Sub AreIsomorphFalseTest()
        Dim expectedResult = False
        Dim result = Mio.AreIsomorph("CASA", "CASE")
        Assert.AreEqual(result, expectedResult)
    End Sub


    Public Sub TestNewNodeIsRoot()
        'Dim tree As VisualBasicTests.Node = New VisualBasicTests.Node
        Dim expectedResult As Node = Nothing
        Node.IncludeNode(expectedResult, 15)

        Assert.AreEqual(expectedResult, expectedResult)
    End Sub

End Class