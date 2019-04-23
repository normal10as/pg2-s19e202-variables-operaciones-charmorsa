Imports System

Module Program
    Sub Main(args As String())
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
