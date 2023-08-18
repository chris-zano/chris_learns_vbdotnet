Module Module1

    Sub Main()
        'if elseif else endif staements

        'fizz - multiples of 3
        'buzz - multiples of 5
        'fizzbuzz - multiples of both 3 and 5

        Console.WriteLine("Enter a number [uInteger] let me tell you if it is a fizz, buzz or fizzbuzz")
        Dim intRange As UInteger = 4_294_967_295
        Dim n As UInteger = Console.ReadLine()

        If n > intRange Then
            Console.WriteLine("sorry, your number is outside the range of an unsigned integer")
        ElseIf n < intRange Then
            If n Mod 3 = 0 AndAlso n Mod 5 = 0 Then
                Console.WriteLine("fizzbuzz")
            ElseIf n Mod 3 = 0 Then
                Console.WriteLine("fizz")
            ElseIf n Mod 5 = 0 Then
                Console.WriteLine("buzz")
            Else
                Console.WriteLine($"{n} is not a fizz nor a buzz")
            End If
        Else
            Console.WriteLine("Some Serious Error Occurred")
        End If

        Console.ReadKey(True)

    End Sub

End Module
