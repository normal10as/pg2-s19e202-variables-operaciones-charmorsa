Imports System

Module Program
    Sub Main(args As String())
        Dim dias_ano, dias_laboral, dias_semana, total As Integer
        dias_ano = 365
        dias_laboral = 5
        dias_semana = 7

        total = dias_ano / dias_semana
        Console.WriteLine("el total de semanas en el año es de " & total)
        total = (total * dias_laboral) / dias_semana
        Console.WriteLine("el total de semanas laborales es de " & total)
    End Sub
End Module
