Module Module1

    Sub Main()
        Console.WriteLine("Enter your age boy !!!!")
        Dim age As Integer = Console.ReadLine()
        Dim typeOfvar = age.GetType()
        Console.WriteLine($"The type is {age.GetType()} for {age}")
        Console.WriteLine($"The type is {CByte(age).GetType()} for {CByte(age)}")
        Console.ReadKey(True)

    End Sub

End Module
