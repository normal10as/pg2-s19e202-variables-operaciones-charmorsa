Imports System

Module Program
    Sub Main(args As String())
        Dim a, b, c As Integer
        Dim r As Double

        a = 1
        b = 5
        c = 2

        r = (((b ^ 2) - 4 * a * c) / 2 * a)
        Console.WriteLine("el resultado de la ecuacion {[(b^2)-4*1*2]/2*1} es igual a " & r)
    End Sub
End Module
