Public Class _Default
    Inherits Page

    Public Property lbParts As ListBox

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        lbParts.Items.Add("Programacion 1")
        lbParts.Items.Add("Arquitectura de computadores")
        lbParts.Items.Add("Lógica para computación")
    End Sub
End Class