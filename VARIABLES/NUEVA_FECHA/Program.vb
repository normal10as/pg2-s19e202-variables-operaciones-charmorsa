Imports System
Imports System.Runtime
Imports System.DateTime

Module Program
    Sub Main(args As String())
        Dim fecha As Date
        Dim a As Integer
        Dim resultado As Date

        Console.Write("ingresar una fecha ")
        fecha = Console.ReadLine()
        Console.Write("ingresar un numero ")
        a = Console.ReadLine()

        resultado = dateadd("d", a, fecha)

        Console.WriteLine(resultado)

    End Sub
End Module
