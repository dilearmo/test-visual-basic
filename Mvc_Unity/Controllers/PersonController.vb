Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Mvc_Unity
Imports Mvc_Unity.Models

Namespace Controllers
    Public Class PersonController
        Inherits System.Web.Mvc.Controller

        Private Property _repositoryPerson As IRepositoryPerson

        Public Sub New(repositoryPerson As IRepositoryPerson)
            _repositoryPerson = repositoryPerson
        End Sub

        ' GET: Person
        Function Index() As ActionResult
            Return View(_repositoryPerson.List())
        End Function

        ' GET: Person/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim person As Person = _repositoryPerson.Find(id)
            If IsNothing(person) Then
                Return HttpNotFound()
            End If
            Return View(person)
        End Function

        ' GET: Person/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Person/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(ByVal person As Person) As ActionResult
            If ModelState.IsValid Then
                person.Id = _repositoryPerson.Add(person)
                Return RedirectToAction("Index")
            End If
            Return View(person)
        End Function

        ' GET: Person/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim person As Person = _repositoryPerson.Find(id)
            If IsNothing(person) Then
                Return HttpNotFound()
            End If
            Return View(person)
        End Function

        ' POST: Person/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(ByVal person As Person) As ActionResult
            If ModelState.IsValid Then
                _repositoryPerson.Update(person)
                Return RedirectToAction("Index")
            End If
            Return View(person)
        End Function

        ' GET: Person/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim person As Person = _repositoryPerson.Find(id)
            If IsNothing(person) Then
                Return HttpNotFound()
            End If
            Return View(person)
        End Function

        ' POST: Person/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            _repositoryPerson.Delete(id)
            Return RedirectToAction("Index")
        End Function
    End Class
End Namespace
