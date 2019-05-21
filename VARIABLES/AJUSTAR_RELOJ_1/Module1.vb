Imports Microsoft
Imports Microsoft.VisualBasic.DateAndTime
Module Module1

    Sub Main()
        Dim a, b As Integer
        Dim mes As Date
        Dim ano As Date
        Dim resultado As Date
        Console.Write("ingresar un numero del 1 al 31 ")
        a = Console.ReadLine()
        Console.Write("ingresar un numero del 0 al 23 ")
        b = Console.ReadLine()
        ano = Now
        mes = Now
        resultado = New DateTime(Year(ano) & "/" & Month(mes) & "/" & a & "/" & b)
        Console.WriteLine("se a formado: " & resultado)

    End Sub

End Module
