Imports System

Module Program
    Sub Main(args As String())
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
End Module
