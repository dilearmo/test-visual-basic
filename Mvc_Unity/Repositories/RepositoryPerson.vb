Imports Mvc_Unity
Imports Mvc_Unity.Models

Public Class RepositoryPerson : Implements IRepositoryPerson

    Public Sub Update(person As Person) Implements IRepositoryPerson.Update
        Using context As New EjemploUnityContext
            context.Entry(person).State = Entity.EntityState.Modified
            context.SaveChanges()
        End Using
    End Sub

    Public Sub Delete(id As Integer) Implements IRepositoryPerson.Delete
        Using context As New EjemploUnityContext
            Dim p As New Person With {.Id = id}
            context.Entry(p).State = Entity.EntityState.Deleted
            context.SaveChanges()
        End Using
    End Sub

    Public Function List() As List(Of Person) Implements IRepositoryPerson.List
        Using context As New EjemploUnityContext
            Return context.Person.ToList()
        End Using
    End Function

    Public Function Add(person As Person) As Integer Implements IRepositoryPerson.Add
        Using context As New EjemploUnityContext
            context.Person.Add(person)
            context.SaveChanges()
        End Using
        Return person.Id
    End Function

    Public Function Find(id As Integer) As Person Implements IRepositoryPerson.Find
        Dim p As Person
        Using context As New EjemploUnityContext
            p = context.Person.Find(id)
        End Using
        Return p
    End Function
End Class
