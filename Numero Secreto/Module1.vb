Module Module1

    Sub Main()
        ' Generar número aleatorio entre 1 y 1000
        Dim random As New Random()
        Dim numeroSecreto As Integer = random.Next(1, 1001)

        Console.WriteLine("Bienvenido adivinar el número secreto entre 1 y 1000.")

        Dim intento As Integer
        Dim intentosRealizados As Integer = 0

        ' Permitir múltiples intentos hasta que el usuario adivine el número secreto
        Do
            Console.Write("Ingrese un número: ")
            intento = Integer.Parse(Console.ReadLine())

            If intento < numeroSecreto Then
                Console.WriteLine("El número es muy bajo.")
            ElseIf intento > numeroSecreto Then
                Console.WriteLine("El número es muy alto.")
            End If

            intentosRealizados += 1
        Loop While intento <> numeroSecreto

        Console.WriteLine($"¡Felicidades! Has adivinado el número secreto {numeroSecreto} después de {intentosRealizados} intentos.")
    End Sub
End Module
