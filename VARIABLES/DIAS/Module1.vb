Imports Microsoft.VisualBasic.DateAndTime

Module Module1

    Sub Main()
        Dim a As Integer
        Console.Write("igrese un numero de la semana. del 1 al 7    ")
        a = Console.ReadLine()

        If ((a > 0) And (a < 8)) Then
            Select Case a
                Case 1
                    Console.WriteLine("LUNES")
                Case 2
                    Console.WriteLine("MARTES")
                Case 3
                    Console.WriteLine("MIERCOLES")
                Case 4
                    Console.WriteLine("JUEVES")
                Case 5
                    Console.WriteLine("VIERNES")
                Case 6
                    Console.WriteLine("SABADO")
                Case 7
                    Console.WriteLine("DOMINGO")
            End Select

        Else
            Console.WriteLine("el numero ingresado es incorreccto")
        End If
    End Sub

End Module
