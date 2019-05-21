Module Module1

    Sub Main()
        Dim palabra, palabranueva, c, resultado As String
        c = "Aunque la cadena sea de oro, sirve para lo mismo "
        Console.WriteLine(c)
        Console.WriteLine("ingrse una palabra")
        palabra = Console.ReadLine()
        Console.WriteLine("ingrse la palabra que desea reemplazar en la cadena")
        palabranueva = Console.ReadLine()
        palabranueva = " " + palabranueva + " "
        palabra = " " + palabra + " "
        resultado = Replace(c, palabra, palabranueva)
        Console.WriteLine("resultado :" & resultado)
    End Sub

End Module
