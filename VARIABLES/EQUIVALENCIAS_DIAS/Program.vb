Imports System

Module Program
    Sub Main(args As String())
        Const diasemana As Byte = 7
        Const horadia As Byte = 24
        Const minutohora As Byte = 60

        Dim dias As Integer

        Console.Write("ingrese un numero ")
        dias = Console.ReadLine()

        Console.Write("semana n: " & dias / diasemana)
        Console.WriteLine("horas n: " & dias * horadia)
        Console.WriteLine("minutos n: " & dias * minutohora * horadia)

    End Sub
End Module
