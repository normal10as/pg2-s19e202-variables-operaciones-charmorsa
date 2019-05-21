Imports Microsoft
Imports Microsoft.VisualBasic.DateAndTime
Module Module1

    Sub Main()
        Dim ano, mes, dia, hora, minuto, segundo As Date
        ano = Now
        mes = Now
        dia = Now
        hora = Now
        minuto = Now
        segundo = Now

        Console.WriteLine("el AñO es " & Year(ano))
        Console.WriteLine("el MES es " & Month(mes))
        Console.WriteLine("el DIA es " & Day(dia))
        Console.WriteLine("la HORA es " & Hour(hora))
        Console.WriteLine("los MINUTOS son " & Minute(minuto))
        Console.WriteLine("los SEGUNDOS son " & Second(segundo))
    End Sub

End Module
