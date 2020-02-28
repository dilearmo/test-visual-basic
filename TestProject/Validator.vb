Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()>
Public Class Validator

    <TestMethod()>
    Public Sub AreIsomorphTrueTest()
        Dim expectedResult As Boolean = True
        Dim result As Boolean = VisualBasicTests.Mio.AreIsomorph("CALLE", "PERRO")
        Assert.AreEqual(result, expectedResult)
    End Sub

    <TestMethod()>
    Public Sub AreIsomorphFalseTest()
        Dim expectedResult = False
        Dim result = VisualBasicTests.Mio.AreIsomorph("CASA", "CASE")
        Assert.AreEqual(result, expectedResult)
    End Sub


    Public Sub TestNewNodeIsRoot()
        'Dim tree As VisualBasicTests.Node = New VisualBasicTests.Node
        Dim expectedResult As VisualBasicTests.Node = Nothing
        VisualBasicTests.Node.IncludeNode(expectedResult, 15)

        Assert.AreEqual(expectedResult, expectedResult)

    End Sub


End Class