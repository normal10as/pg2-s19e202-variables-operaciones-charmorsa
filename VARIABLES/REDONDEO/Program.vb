Imports System
Imports System.Math
Module Program
    Sub Main(args As String())
        Dim r As Double
        Console.WriteLine("ingrese un valor con decimal ")
        r = Console.ReadLine()
        Console.WriteLine("valor aproximado por exceso " & ceiling(r))
        Console.WriteLine("valor aproximado por defecto " & Floor(r))
        Console.WriteLine("valor redondeado " & Round(r))

    End Sub
End Module
