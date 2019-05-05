Imports System

Module Program
    Sub Main(args As String())
        Dim p, r As Integer
        Console.WriteLine("Favor de ingresaar un valor ")
        p = Console.ReadLine()

        Console.WriteLine("el siguiente sera dividido por 2 y se mostrara el resto de dicha division")

        r = p Mod 2
        Console.WriteLine("el resto de la division entre el numero ingresado y 2 es de " & r)
    End Sub
End Module
