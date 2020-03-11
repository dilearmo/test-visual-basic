Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration.Conventions
Imports Mvc_Unity.Models

Public Class EjemploUnityContext : Inherits DbContext

    Public Property Person As DbSet(Of Person)

    Sub New()
        MyBase.New("EjemploUnity")
        Database.SetInitializer(Of EjemploUnityContext)(Nothing)
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        modelBuilder.Conventions.Remove(Of PluralizingTableNameConvention)()
    End Sub

End Class
