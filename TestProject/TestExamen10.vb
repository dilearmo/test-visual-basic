Imports Examen10

<TestClass()>
Public Class TestExamen10

    <TestMethod()>
    Public Sub EsNumeroPermitidoTest()
        Dim resultado As Boolean = True
        Dim numero As Byte = 1
        Dim resultadoEsperado = True
        resultado = Validador.EsNumeroPermitido(numero)
        Assert.AreEqual(resultadoEsperado, resultado)
    End Sub

End Class
