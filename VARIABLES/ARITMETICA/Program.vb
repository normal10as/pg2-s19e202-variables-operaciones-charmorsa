Imports System

Module Program
    Sub Main(args As String())
        Dim a, b, x As Integer
        Dim c, d, y As Double

        a = 15
        b = 4
        c = 7.65
        d = 12.3

        Console.WriteLine("suma entre nuemro entero y numero decimal, con resultado decimal")
        y = a + c
        Console.WriteLine(a & " + " & c & " = " & y)

        Console.WriteLine("suma entre nuemro entero y numero entero, con resultado entero")
        x = a + b
        Console.WriteLine(a & " + " & b & " = " & x)

        Console.WriteLine("suma entre nuemro entero y numero decimal, con resultado entero")
        x = b + d
        Console.WriteLine(b & " + " & d & " = " & x)

        Console.WriteLine("suma entre nuemro decimal y numero decimal, con reesultado decimal")
        y = d + c
        Console.WriteLine(d & " + " & c & " = " & y)

        Console.WriteLine("suma entre nuemro entero y numero entero, con resultado decimal")
        y = a + b
        Console.WriteLine(a & " + " & b & " = " & y)

        Console.WriteLine("suma entre nuemro decimal y numero decimal, con resultado entero")
        x = c + d
        Console.WriteLine(c & " + " & d & " = " & x)
    End Sub
End Module
