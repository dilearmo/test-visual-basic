'Imports System.Threading

'Public Class ProductorConsumidor

'    Public recipiente As New Queue
'    Private Sub Main()

'        Dim Hilo_Productor As New Hilo_Productor(recipiente)
'        Dim Hilo_Consumidor As New Hilo_Consumidor(recipiente)

'        Dim hilo1 As New Thread(AddressOf Hilo_Productor.Produce)
'        Dim hilo2 As New Thread(AddressOf Hilo_Consumidor.Consume)

'        hilo1.Start()
'        hilo2.Start()

'        Console.ReadLine()
'    End Sub
'End Class

'Public Class Hilo_Productor
'    Sub Produce()
'        'Dim segundos As Integer = CInt(Int((5 * Rnd()) + 1))
'        For i = 0 To 9
'            Dim Random As New Random()
'            Dim segundos As Integer = Random.Next(1, 5)

'            recipiente.Enqueue(i)
'            Console.WriteLine($"Produce  -> {i} - > rnd {segundos} --> {DateTime.Now.ToString("hh:mm:ss.fff tt")}")

'            Thread.Sleep(segundos * 1000
'        Next
'        Console.Write("Fin Productor---")
'        Console.ReadLine()
'    End Sub
'End Class

'Public Class Hilo_Consumidor
'    Private Const CantidadIterciones As Integer = 9

'    Sub Consume()
'        '  Dim segundos As Integer = CInt(Int((5 * Rnd()) + 1))
'        For i = 0 To CantidadIterciones
'            Dim segundos As Integer = GenerarRandom()
'            While (True)
'                If recipiente.Count = 0 Then
'                    Threading.Thread.Sleep(1000)
'                Else
'                    Dim objetoObtienido = recipiente.Dequeue()
'                    Console.WriteLine($"consume -> {objetoObtienido} - > rnd {segundos} --> {DateTime.Now.ToString("hh:mm:ss.fff tt")}")
'                    Exit While
'                End If
'            End While
'            Thread.Sleep(segundos * 1000)
'        Next
'        Console.Write("Fin consumidor---")
'        Console.ReadLine()
'    End Sub

'    Public Shared Function GenerarRandom() As Integer
'        Dim Random As New Random()
'        Return Random.Next(1, 10)
'    End Function
'End Class