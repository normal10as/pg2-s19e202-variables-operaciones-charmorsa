Module Module1

    Sub Main()
        Dim fecha As Date
        Dim a As Integer
        Dim resultado As Date

        Console.Write("ingresar una fecha ")
        fecha = Console.ReadLine()
        Console.Write("ingresar un numero ")
        a = Console.ReadLine()

        resultado = DateAdd("d", a, fecha)

        Console.WriteLine(resultado)
    End Sub

End Module
