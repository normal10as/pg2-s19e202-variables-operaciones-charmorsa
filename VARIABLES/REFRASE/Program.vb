Imports System
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic.Strings
Module Program
    Sub Main(args As String())
        Dim a, b, c, d, e As String
        c = "Aunque la cadena sea de oro, sirve para lo mismo "
        e = " "
        Console.WriteLine("ingrse una palabra")
        a = Console.ReadLine()
        Console.WriteLine("ingrse la palabra que desea reemplazar en la cadena")
        b = Console.ReadLine()

        d = c.Split(e, StringSplitOptions.RemoveEmptyEntries)

        If (d(0) = b) Then
            c.Replace(b, a)
        End If
        If (d(1) = b) Then
            c.Replace(b, a)
        End If
        If (d(2) = b) Then
            c.Replace(b, a)
        End If
        If (d(3) = b) Then
            c.Replace(b, a)
        End If
    End Sub
End Module
