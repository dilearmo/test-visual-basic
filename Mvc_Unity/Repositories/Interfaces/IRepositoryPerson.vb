Imports Mvc_Unity.Models

Public Interface IRepositoryPerson
    Function List() As List(Of Person)
    Function Add(person As Person) As Integer
    Function Find(id As Integer) As Person
    Sub Update(person As Person)
    Sub Delete(id As Integer)
End Interface
