Imports Mvc_Unity
Imports Mvc_Unity.Models

Public Class RepositoryPersonMock
    Implements IRepositoryPerson

    Public Sub Update(person As Person) Implements IRepositoryPerson.Update

    End Sub

    Public Sub Delete(id As Integer) Implements IRepositoryPerson.Delete

    End Sub

    Public Function List() As List(Of Person) Implements IRepositoryPerson.List
        Return New List(Of Person)
    End Function

    Public Function Add(person As Person) As Integer Implements IRepositoryPerson.Add
        Return 1
    End Function

    Public Function Find(id As Integer) As Person Implements IRepositoryPerson.Find
        Return New Person()
    End Function
End Class
