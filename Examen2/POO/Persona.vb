Imports System.ComponentModel

Public Class Persona
    Public genero As Integer
    Public edad As Integer

    Public Sub New(ByVal genero As Genero)
        Me.genero = genero
    End Sub

    Public Sub AsignarEdad(ByVal p As Persona, edad As Integer)
        p.edad = edad
    End Sub
End Class

Public Enum Genero
    <Description("Femenino")>
    Femenino = 1
    <Description("Masculino")>
    Masculino = 0
End Enum