Imports System
Imports System.Math
Module Program
    Sub Main(args As String())
        Dim a, b, c, mayor As Integer
        Console.WriteLine("ingrese el valor de A")
        a = Console.ReadLine()
        Console.WriteLine("ingrese el valor de B")
        b = Console.ReadLine()
        Console.WriteLine("ingrese el valor de C")
        c = Console.ReadLine()

        mayor = Max(a, b)
        mayor = Max(c, mayor)

        Console.Write("el mayor es " & mayor)

    End Sub
End Module
