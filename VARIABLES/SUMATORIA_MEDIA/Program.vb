Imports System

Module Program
    Sub Main(args As String())
        Dim a, b, c, d As Integer
        Dim r As Double

        Console.WriteLine("ingrese el primer numero, debe ser entero: ")
        a = Console.ReadLine()
        Console.WriteLine("ingrese el segundo numero, debe ser entero: ")
        b = Console.ReadLine()
        Console.WriteLine("ingrese el tercer numero, debe ser entero: ")
        c = Console.ReadLine()
        Console.WriteLine("ingrese el cuarto numero, debe ser eentero: ")
        d = Console.ReadLine()

        r = a + b + c + d
        Console.WriteLine("la sumatoria de los valores ingresados es de " & r)
        r = (r / 4)
        Console.WriteLine("y la media o promedio de los numeros ingresados es de " & r)

    End Sub
End Module
