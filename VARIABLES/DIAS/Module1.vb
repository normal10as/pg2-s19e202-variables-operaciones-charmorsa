Imports Microsoft.VisualBasic.DateAndTime

Module Module1
    Enum diassemana As Byte
        domingo
        lunes
        martes
        miercoles
        jueves
        viernes
        sabado

    End Enum
    Sub Main()
        Dim a As diassemana
        Console.Write("ingrese un numero de la semana. del 1 al 7    ")
        a = Console.ReadLine()
        Console.Write("  " & a.ToString)
    End Sub

End Module
