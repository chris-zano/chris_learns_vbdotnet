Module Module1
    Sub Main()
        'Constants in VB.NET
        '   These are fixed values that the program may not alter during its execution
        '   Just like the concept of a constant variable in C or JavaScript

        'Declaring Constants - [modifiers{}] Const constantList
        'Example 
        '   Const maxVal As Long = 4999
        '   Public Const message As String = "Hello World"
        '   Private Const piValue As Double = 3.1415

        Const PI As Double = 3.1415
        Dim radius As Double
        Dim choice As Byte
        Dim circumfrence As Double
        Dim area As Double
        Console.WriteLine("Enter the radius of the circle: ")
        radius = Console.ReadLine()

        Console.WriteLine("Enter (1) to calculate the circumfrence or (2) to calculate area")
        choice = Console.ReadLine()

        If choice = 1 Then
            circumfrence = 2 * PI * radius
            Console.WriteLine($"The circumfrence is {circumfrence}")
        ElseIf choice = 2 Then
            area = PI * (radius ^ 2)
            Console.WriteLine($"The area id {area}")
        Else
            Console.WriteLine("Invalid request!!! Enter (1) to calculate the circumfrence or (2) to calculate area")
        End If

        Console.ReadKey(True)
    End Sub

End Module