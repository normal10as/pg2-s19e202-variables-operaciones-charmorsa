Imports System
Imports System.Math
Module Program
    Sub Main(args As String())
        Dim a As Integer
        Console.WriteLine("INGRESE UN NUMERO ")
        a = Console.ReadLine()
        Console.WriteLine("el valor absoluto del numero ingresado es " & Abs(a))
        Console.WriteLine("la decima potenia del valor ingresado es " & Pow(a, 10))
        Console.WriteLine("la raaiz cuadrada de valor ingresado es " & Sqrt(a))
    End Sub
End Module
