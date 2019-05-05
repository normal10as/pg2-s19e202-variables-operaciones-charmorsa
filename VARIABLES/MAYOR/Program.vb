Imports System
Imports System.Math
Module Program
    Sub Main(args As String())
        Dim a, b, c As Integer
        Console.WriteLine("ingrese el valor de A")
        a = Console.ReadLine()
        Console.WriteLine("ingrese el valor de B")
        b = Console.ReadLine()
        Console.WriteLine("ingrese el valor de C")
        c = Console.ReadLine()

        If (Max(a, b) = Max(a, c)) Then
            Console.WriteLine("el valor maximo es " & a)
        End If
        If (Max(b, c) = Max(a, b)) Then
            Console.WriteLine("el valor maximo es " & b)
        End If
        If (Max(b, c) = Max(a, c)) Then
            Console.WriteLine("el valor maximo es " & c)
        End If

    End Sub
End Module
