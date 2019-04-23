Imports System

Module Program
    Sub Main(args As String())
        Dim nombre, apellido As String
        Dim fechanacimiento As Date

        Console.WriteLine("         BIENVENIDOS")

        Console.WriteLine("POR FAVOR, Ingrese un Nombre: ")
        nombre = Console.ReadLine()
        Console.WriteLine("POR FAVOR, Ingrese un APELLIDO: ")
        apellido = Console.ReadLine()
        Console.WriteLine("POR FAVOR, Ingrese la Fecha de Nacimiento: ")
        fechanacimiento = Console.ReadLine()
        Console.WriteLine(nombre & " " & apellido & " " & " nacio el " & fechanacimiento)

    End Sub
End Module