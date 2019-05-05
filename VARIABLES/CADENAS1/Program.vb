Imports System
Imports Microsoft.VisualBasic.Strings
Imports System.String
Module Program
    Sub Main(args As String())
        Dim palabra As String
        Console.WriteLine("escribir una palabra ")
        palabra = Console.ReadLine()

        Console.WriteLine("la primera A aparece en la posicion " & InStr(1, palabra, "a"))
        Console.WriteLine("la primera O aparece en la posicion " & InStr(1, palabra, "o"))
        Console.WriteLine("cadena invertida: " & InStrRev(palabra))

    End Sub
End Module
