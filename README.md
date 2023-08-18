# chris_learns_vbdotnet

## Variables, Declarations and DataTypes
* To declare a variable in vb, we use the 'DIM' keyword followed by the variablename then the data type
* Example
```vb
'Dim variableName As DataType
Dim name As String ' declares name variable as a String object
Dim age As Integer ' declares age variable as an Integer Object
```
* To read the contents of a variable, we can use the command 
```vb
Console.WriteLine(variableName) ' to write the contents of a variable to the console
```
* We can concatenate the contents of a variable to a stream output strings.
* example
```vb
'using the &
Console.WriteLine("This is a string ", & variableName)
Console.WriteLine("This is a ", &variableOne& " for this content => "&variableTwo)

'using string formatting
Console.WriteLine("This is a single variable {0}", variableName)
Console.WriteLine("These are multiple variables {0},{1},{2}", variableOne, variableTwo, variableThree)

'using string interpolation - my favorite
Console.WriteLine($"This is {varialeOne} as well as {variableTwo} and {variableThree}")
```
* There are several different datatypes in visual basic
* The code block below outlines some of the native and most commonly used ones
```vb
Module Module1
    Sub Main()
        'For every datatype, create a variable, assign it a value and output it to the console

        'Boolean - True or False values [used in conditional statements and logical operations]
        Dim isBeginnerProgrammer As Boolean = False
        Console.WriteLine($"isBeginner = {isBeginnerProgrammer}")

        'Byte - small integer values [positive numbers from 0 to 255] [1 byte]
        Dim numberOfChildren As Byte = 4
        Console.WriteLine($"Number of Children = {numberOfChildren}")

        'Char - individual unicode characters [positive values from 0 to 65_535] [2 bytes]
        Dim gravitationalConstant As Char = "G"c
        Console.WriteLine($"Gravitational Constant = {gravitationalConstant}")

        'Date - stores date and time [from January 1, 0001 to December 31, 9999] [8 bytes]
        Dim dateOfAdmission As Date = #2018-09-04#
        Console.WriteLine($"Date of Admission: {dateOfAdmission}")

        'Decimal - used when precision is critical (financial and scientific calculations) [16 bytes]
        Dim accountBalance As Decimal = 250_000.638954609234 'GHC
        Console.WriteLine($"Account Balance = {accountBalance}")

        'Double - general purpose floating point number [for both positive and negative values] [8 bytes]
        Dim circumfrence As Double = 27.342857142857142 'radius = 4.35
        Console.WriteLine($"Circumfrence of circle = {circumfrence}")

        'Integer - storing whole numbers, positive and negative [(-2,147,483,648) to (2,147,483,647)] [4 bytes]
        Dim currentNetWorth As Integer = 2_000_000_000 'USD
        Console.WriteLine($"Current Net Worth = {currentNetWorth}")

        'Long - large whole numbers beyond the range of integers [signed] [8 bytes]
        Dim nationalDebt As Long = 40_000_000_000_000 'USD
        Console.WriteLine($"Ghana's national debt = {nationalDebt}")

        'Object - store any type of data [provides flexibility] [4 bytes - 32_bit_pc] [8 bytes - 64_bit_pc]
        Dim myObj As Object = "This is an object" 'string object
        Console.WriteLine($"Object can be a string -> {myObj}")
        myObj = 23 'byte object
        Console.WriteLine($"Object can be a number(byte) -> {myObj}")
        myObj = True 'boolean object
        Console.WriteLine($"Object can be a boolean -> {myObj}")
        myObj = 3.142 'single object
        Console.WriteLine($"Object can be a single -> {myObj}")
        Console.WriteLine("NB://Object datatype can store any other datatype")

        'SByte - small signed integer values [-128 to 127] [1 byte] [signed]
        Dim outputEfficiency As SByte = -78 '%
        Console.WriteLine($"Output Efficency = {outputEfficiency}")

        'Short - short signed integer values [2 bytes] [signed]
        Dim milesOnCar As Short = 15_000 'miles
        Console.WriteLine($"Miles left on car = {milesOnCar}")

        'Single - floating point numbers with lower precision [4 bytes] [signed]
        Dim temperatureInDegrees As Single = -4.344 'degrees
        Console.WriteLine($"Current Temperature = {temperatureInDegrees}")

        'String - represents any sequence of characters [approx. 2 billion unicode characters]
        Dim stMyName As String = "Christian Solomon"
        Console.WriteLine($"Name = {stMyName}")

        'UInteger - large unsigned integer whole numbers [4 bytes] [ 0 to 4,294,967,295 ]
        Dim annualRevenue As UInteger = 4_967_295
        Console.WriteLine($"Annual revenue = {annualRevenue}")

        'ULong - large unsigned whole numbers beyond the range of UInteger [8 bytes]
        Dim lightYearInKilometers As ULong = 9_460_730_500_000 'km [approximation]
        Console.WriteLine($"Lightyear in kilometers(approx.) = {lightYearInKilometers}")

        'UShort - represents short unsigned whole numbers [2 bytes] [0 to 65_535]
        Dim studentPopulation As UShort = 60_000 'students
        Console.WriteLine($"Student Population = {studentPopulation}")

        'User-Defined - (like structures in C programming language)[Platform Dependent]
        '   used to create custom datatypes using structures to encapsulate related data
        Dim studentOne As StudentStructure
        studentOne.stName = "Michael Asante"
        studentOne.nAge = 23 'years
        studentOne.bCompleted = True
        Console.WriteLine($"The student {studentOne.stName} is {studentOne.nAge} years of age, and has 'isCmpleted' status set to {studentOne.bCompleted}")
        Console.ReadKey(True)
    End Sub

    Structure StudentStructure
        Public stName As String
        Public nAge As SByte
        Public bCompleted As Boolean
    End Structure
End Module
```

## Conditional Branching and Loops

* In VB.NET, the If statement is used for conditional branching.
* It allows you to execute different blocks of code based on whether a specified condition is true or false.
* The If statement can be used in various forms, including single-line and multi-line constructs.
* Here's an overview of how to use the If statement:

1. Single-Line If Statement:
* The single-line If statement is used when you have a simple condition and a single action to perform if the condition is true. The syntax is as follows
```vb
'If condition Then resultIfTrue
Dim num As Integer = 10
If num > 5 Then Console.WriteLine("Number is greater than 5")
```
2. Multi-Line If Statement:
* The multi-line If statement is used when you want to execute multiple statements if the condition is true. It has the following syntax:
```vb
'If condition Then
    ' Code to execute if condition is true
    ' More code...
'End If

Dim score As Integer = 85
If score >= 60 Then
    Console.WriteLine("Pass")
    Console.WriteLine("Congratulations!")
End If
```
* Single-line
```vb
'Conditionals and Loops
        '   If statements
        Console.WriteLine("Enter your name: ")
        Dim name As String = Console.ReadLine()

        Console.WriteLine("Enter your age: ")
        Dim age As Byte = Console.ReadLine()

        If age < 13 Then Console.WriteLine($"Hi {name}, You are not yet a teenager")

        If age > 12 And age < 20 Then Console.WriteLine($"Hi {name}, You are a Teenager")

        If age > 19 Then Console.WriteLine($"Hi {name}, You are an adult")

        Console.ReadKey(True)
```
* Multi-line
```vb
'multi line if statements

        Console.WriteLine("Enter your name young ser: ")
        Dim name As String = Console.ReadLine()

        Console.WriteLine("Enter your age now sillyboyyy: ")
        Dim age As Byte = Console.ReadLine()

        If age > 19 Then
            Console.WriteLine($"Hi, {name}!! You are an adult!")
            Console.WriteLine("That means you can drink")
        End If

        Console.ReadKey(True)
```

### ___if else statements___

* If...Else Statement:
The If...Else statement is used to execute one block of code if the condition is true and another block of code if the condition is false. The syntax is:
```vb
If condition Then
    ' Code to execute if condition is true
Else
    ' Code to execute if condition is false
End If
```
* Example:
```vb
Dim age As Integer = 18
If age >= 18 Then
    Console.WriteLine("You are an adult.")
Else
    Console.WriteLine("You are not yet an adult.")
End If
```

### ___if elseif else statements___
* If...ElseIf...Else Statement:
This construct is used when you have multiple conditions to check. You can use multiple ElseIf clauses between the initial If and the final Else (optional) to handle different cases. The syntax is:
```vb
If condition1 Then
    ' Code to execute if condition1 is true
ElseIf condition2 Then
    ' Code to execute if condition2 is true
' ... (more ElseIf clauses)
Else
    ' Code to execute if none of the conditions are true
End If
```
* Example:
```vb
Dim dayOfWeek As Integer = 3
If dayOfWeek = 1 Then
    Console.WriteLine("It's Sunday.")
ElseIf dayOfWeek = 7 Then
    Console.WriteLine("It's Saturday.")
Else
    Console.WriteLine("It's a weekday.")
End If
```
* *These are the basic forms of the If statement in VB.NET. They allow you to control the flow of your program based on different conditions. You can use logical operators (such as And, Or, Not) to create complex conditions.*

### ___here's a mini fizzbuzz codeblock using just if elseif else statements___
```vb
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
```
