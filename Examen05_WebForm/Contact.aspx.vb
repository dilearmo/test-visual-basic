Public Class Contact
    Inherits Page

    Public Property lbParts As New ListBox

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        If Not IsPostBack Then
            lbParts.Items.Add("Programacion 1")
            lbParts.Items.Add("Arquitectura de computadores")
            lbParts.Items.Add("Lógica para computación")
        End If
    End Sub
End Class