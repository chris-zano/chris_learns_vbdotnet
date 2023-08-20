Module Module1
    
    Sub Main()
        'a simple calculator
        'operators {+, -, *, /}
        Dim a As Integer
        Dim myoperator As String
        Dim b As Integer
        Dim answer As Integer

        Console.WriteLine("This simple calculator allows you to add, subtract, multiply or divide two numbers")

        Console.WriteLine("Enter the first number: ")
        a = Console.ReadLine()

        Console.WriteLine("Choose an operator : {+, -, *, /}")
        myoperator = Console.ReadLine()

        Console.WriteLine("Enter the second number: ")
        b = Console.ReadLine()

        If myoperator = "+" Then
            answer = a + b
        ElseIf myoperator = "-" Then
            answer = a - b
        ElseIf myoperator = "*" Then
            answer = a * b
        ElseIf myoperator = "/" Then
            answer = a / b
        Else
            answer = 0
        End If

        Console.WriteLine($"The answer is : {answer}")
        Console.readKey(True)

    End Sub
End Module