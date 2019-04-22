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
        Call variables(nombre, apellido, fechanacimiento)
        Call variables_tipos()
        Call concatenacion()
        Call aritmetica()
        Call ecuacion()
        Call sumatoria_media()
        Call semanas()
        Call algebra()


    End Sub
    Sub variables(nom, ape, fecha)

        Console.WriteLine(nom & " " & ape & " " & " nacio el " & fecha)

    End Sub

    Sub variables_tipos()
        Dim nombre, lugar, calle As String
        Dim documento, temperatura, altura_calle, habitantes, altura As Integer
        Dim fecha As Date
        Dim kms, profundidad, kilos, total As Double
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

    Sub concatenacion()
        Dim nombre_empresa, nombre_calle As String
        Dim altura_calle As Integer
        Dim fecha_actividad As Date
        Dim da1, da2 As String
        nombre_empresa = "CALIFORNIA S.A."
        nombre_calle = "CORDOBA"
        altura_calle = 1756
        fecha_actividad = "19 / 4 / 2019"

        da1 = (nombre_empresa & " " & nombre_calle & " " & altura_calle & " " & fecha_actividad)
        da2 = (nombre_empresa & " " & nombre_calle & " " & CInt(altura_calle) & " " & fecha_actividad)

        Console.WriteLine(da1)
        Console.WriteLine(da2)

    End Sub

    Sub aritmetica()
        Dim a, b, x As Integer
        Dim c, d, y As Double

        a = 15
        b = 4
        c = 7.65
        d = 12.3

        Console.WriteLine("suma entre nuemro entero y numero decimal, con resultado decimal")
        y = a + c
        Console.WriteLine(a & " + " & c & " = " & y)

        Console.WriteLine("suma entre nuemro entero y numero entero, con resultado entero")
        x = a + b
        Console.WriteLine(a & " + " & b & " = " & x)

        Console.WriteLine("suma entre nuemro entero y numero decimal, con resultado entero")
        x = b + d
        Console.WriteLine(b & " + " & d & " = " & x)

        Console.WriteLine("suma entre nuemro decimal y numero decimal, con reesultado decimal")
        y = d + c
        Console.WriteLine(d & " + " & c & " = " & y)

        Console.WriteLine("suma entre nuemro entero y numero entero, con resultado decimal")
        y = a + b
        Console.WriteLine(a & " + " & b & " = " & y)

        Console.WriteLine("suma entre nuemro decimal y numero decimal, con resultado entero")
        x = c + d
        Console.WriteLine(c & " + " & d & " = " & x)

    End Sub

    Sub ecuacion()
        Dim a, b, c As Integer
        Dim r As Double

        a = 1
        b = 5
        c = 2

        r = (((b ^ 2) - 4 * a * c) / 2 * a)
        Console.WriteLine("el resultado de la ecuacion {[(b^2)-4*1*2]/2*1} es igual a " & r)

    End Sub

    Sub sumatoria_media()
        Dim a, b, c, d As Integer
        Dim r As Double

        Console.WriteLine("ingrese el primer numero, debe ser entero: ")
        a = Console.ReadLine()
        Console.WriteLine("ingrese el segundo numero, debe ser entero: ")
        b = Console.ReadLine()
        Console.WriteLine("ingrese el tercer numero, debe ser entero: ")
        c = Console.ReadLine()
        Console.WriteLine("ingrese el cuarto numero, debe ser eentero: ")
        d = Console.ReadLine()

        r = a + b + c + d
        Console.WriteLine("la sumatoria de los valores ingresados es de " & r)
        r = (r / 4)
        Console.WriteLine("y la media o promedio de los numeros ingresados es de " & r)

    End Sub

    Sub semanas()
        Dim dias_ano, dias_laboral, dias_semana, total As Integer
        dias_ano = 365
        dias_laboral = 5
        dias_semana = 7

        total = dias_ano / dias_semana
        Console.WriteLine("el total de semanas en el año es de " & total)
        total = (total * dias_laboral) / dias_semana
        Console.WriteLine("el total de semanas laborales es de " & total)

    End Sub

    Sub algebra()
        Dim a, b, r, c, d, t, o As Boolean
        Dim x As Integer
        a = True
        b = True
        x = 0
        Console.WriteLine("      AND")
        Console.WriteLine("  A   ^   B   =  R")
        For x = 1 To 4
            If x < 3 Then
                r = a And b
                Console.WriteLine(a & " ^ " & b & " = " & r)
            End If
            If x > 2 Then
                a = Not (a)
                r = a And b
                Console.WriteLine(a & " ^ " & b & " = " & r)
                a = Not (a)
            End If
            b = Not (b)
        Next

        Console.WriteLine("      OR")
        Console.WriteLine("  A   v   B   =  R")
        a = True
        b = True
        x = 0
        For x = 1 To 4
            If x < 3 Then
                r = a Or b
                Console.WriteLine(a & " v " & b & " = " & r)
            End If
            If x > 2 Then
                a = Not (a)
                r = a Or b
                Console.WriteLine(a & " v " & b & " = " & r)
                a = Not (a)
            End If
            b = Not (b)
        Next

        Console.WriteLine("      NOT")
        Console.WriteLine("  A     A'")
        a = True
        x = 0
        For x = 1 To 2
            Console.WriteLine(a & "  " & Not (a))
            a = Not (a)

        Next

        Console.WriteLine("      XOR")
        a = True
        b = False
        c = False
        d = True
        Console.WriteLine(" ( A     ^     B'   )      V      (   C'     ^     D   )")
        For x = 1 To 4
            If x < 3 Then
                r = a And b
                t = c And d
                o = r Or t
                Console.Write(a & "  " & r & "  " & b)
                Console.Write("        " & o & "  ")
                Console.WriteLine("          " & c & "  " & t & "  " & d)
            End If
            If x > 2 Then
                a = Not (a)
                c = Not (c)
                r = a And b
                t = c And d
                o = r Or t
                Console.Write(a & "  " & r & "  " & b)
                Console.Write("         " & o & "  ")
                Console.WriteLine("          " & c & "  " & t & "  " & d)
                a = Not (a)
                c = Not (c)
            End If
            b = Not (b)
            d = Not (d)
        Next

    End Sub
End Module