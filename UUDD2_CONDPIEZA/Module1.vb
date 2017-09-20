Module Module1

    Sub Main()
        'Diseñar y escribir un programa para poder realizar un control de errores de una pieza. Se deben solicitar tres datos o atributos para una pieza: altura, ancho y código.
        'Para cada atributo se debe controlar lo siguiente:

        '- La altura tiene que estar comprendida entre los valores 7 y 9.
        '- El ancho debe estar comprendido entre 2,5 y 8,5 pero no se permiten los valores 3 ni 3,5.
        '- El valor del código sólo puede ser A, B, C o D.

        'En caso de detectar alguno de los errores indicados, mostrar mensaje por pantalla: PIEZA NO ADMISIBLE. Si los datos leídos, pasan todas las validaciones, mostrar mensaje por pantalla: PIEZA ADMITIDA.

        Dim altura, ancho As Double
        Dim codigo As String
        Dim sw As Boolean = False

        Console.Write("Introduce la altura: ")
        altura = Console.ReadLine()
        If altura >= 7 And altura <= 9 Then
            Console.WriteLine("Altura valida")
        Else
            Console.WriteLine("Altura no valida")
            sw = True
        End If

        Console.Write("Introduce el ancho: ")
        ancho = Console.ReadLine()
        If ancho >= 2.5 And ancho <= 8.5 Then
            If ancho = 3 Or ancho = 3.5 Then
                Console.WriteLine("Error, el valor no es valido")
                sw = True
            End If
            Console.WriteLine("ancho valido")
        Else
            Console.WriteLine("Error, el valor no es valido")
            sw = True
        End If

        Console.Write("Introduce el codigo (A,B,C o D): ")
        codigo = Console.ReadLine()
        Select Case codigo
            Case "A", "B", "C", "D"
                Console.WriteLine("Codigo valido")
            Case Else
                Console.WriteLine("Codigo invalido")
                sw = True
        End Select

        If sw = False Then
            Console.WriteLine("Pieza admitida")
        Else
            Console.WriteLine("Pieza no admitida")
        End If
        Console.ReadLine()







    End Sub

End Module
