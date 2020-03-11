Imports System.Web.Mvc
Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Unity.Configuration

<TestClass()>
Public Class PersonControllerTest
    Private _unityContainer As IUnityContainer

    <TestInitialize()>
    Public Sub TestInitialize()
        _unityContainer = New UnityContainer()
        _unityContainer.LoadConfiguration()
    End Sub

    <TestMethod()>
    Public Sub PersonIndex()
        Dim controller As New Controllers.PersonController(_unityContainer.Resolve(Of IRepositoryPerson))
        Dim result As ViewResult = DirectCast(controller.Index(), ViewResult)
        Assert.IsNotNull(result)
    End Sub

End Class
