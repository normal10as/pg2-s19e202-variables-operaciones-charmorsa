Imports System

Module Program
    Sub Main(args As String())
        Dim nombre, lugar, calle As String
        Dim temperatura As SByte
        Dim documento, kms, kilos As ULong
        Dim altura_calle, profundidad As UShort
        Dim habitantes As UInteger
        Dim altura As Byte
        Dim fecha As Date
        Dim total As Decimal
        Dim nacionalidad As Boolean

        nombre = "FABIO"
        documento = 26985134
        lugar = "POSADAS MISIONES"
        fecha = "15 / 9 / 1986"
        altura = 172
        nacionalidad = True
        temperatura = 24
        calle = "JAPON"
        altura_calle = 3306
        kms = 80.5
        profundidad = 120.6
        habitantes = 44292159
        total = 527.5
        kilos = 2.6

        Console.WriteLine("el Nombre es " & nombre)
        Console.WriteLine("D.N.I. " & documento)
        Console.WriteLine("Nacio en :" & lugar)
        Console.WriteLine("el Dia " & fecha)
        Console.WriteLine("su altura es de " & altura & " cm")
        Console.WriteLine("es ARGENTINO? " & nacionalidad)
        Console.WriteLine("la temperatura es de " & temperatura & " *C")
        Console.WriteLine("el Nombre de la calle es " & calle)
        Console.WriteLine("estamos en la altura " & altura_calle)
        Console.WriteLine("entre POSADAS y APOSTOLES, existe una distancia de " & kms)
        Console.WriteLine("el MAR ARG posee una profundidad aprox. de " & profundidad)
        Console.WriteLine("el territorio ARGENTINO posee una cantidad de " & habitantes & " habitantes")
        Console.WriteLine("llevamos a casa " & kilos & " kilos de asado para 4 personas")
        Console.WriteLine("que nos costo, incluyendo la bebida, un total de " & total)
    End Sub
End Module
