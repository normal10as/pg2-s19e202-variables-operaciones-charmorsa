Module Module1

    Sub Main()
        Dim a, b As Integer
        Dim mes As month
        Dim ano As year
        Dim resultado As DateTime
        Console.Write("ingresar un numero del 1 al 31 ")
        a = Console.ReadLine()
        Console.Write("ingresar un numero del 0 al 23 ")
        b = Console.ReadLine()

        resultado = Console.WriteLine("se a formado: " & ano / mes / a / b)
    End Sub

End Module
