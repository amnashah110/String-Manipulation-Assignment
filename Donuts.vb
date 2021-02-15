Module Module1

    Sub Main()
        'DECLARATION
        Dim Donuts As Integer

        'INITIALISATION
        Donuts = 0

        'INPUT
        Console.Write("Input Number Of Donuts: ")
        Donuts = Console.ReadLine

        'PROCESS
        If Donuts >= 0 And Donuts < 10 Then
            Console.WriteLine("Number Of Donuts: " & Donuts)
        Else
            Console.WriteLine("Number Of Donuts: " & "Many")
        End If

        Console.ReadKey()

    End Sub

End Module
