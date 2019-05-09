Imports System

Module Program
    Sub Main(args As String())
        Dim m, i As Decimal
        Dim r As Single
        Dim t As UShort
        Console.WriteLine(" Ingrese el monto: ")
        m = Console.ReadLine()
        Console.WriteLine(" Ingrese el interes anual: ")
        r = Console.ReadLine()
        Console.WriteLine(" Ingrese la cantidad de dias arregladass: ")
        t = Console.ReadLine()

        i = (m * r * t) / (360 * 100)
        Console.WriteLine("el interes producido es de " & i & " segun los datos ingresados...")
        Console.WriteLine("el interes anual " & m + i)
    End Sub
End Module
