Module Module1

    Sub Main()
        'DECLARATION
        Dim Str1 As String
        Dim CountA, CountE, CountI, CountO, CountU As Integer
        Dim Char1 As Char
        Dim i As Integer

        'INITIALISATION
        Str1 = ""
        CountA = 0
        CountE = 0
        CountI = 0
        CountO = 0
        CountU = 0
        Char1 = ""
        i = 0

        'INPUT
        Console.Write("Enter String: ")
        Str1 = Console.ReadLine
        Str1 = UCase(Str1)

        'PROCESS
        For i = 1 To Len(Str1)
            Char1 = Mid(Str1, i, 1)
            If Char1 = "A" Then
                CountA = CountA + 1
            ElseIf Char1 = "E" Then
                CountE = CountE + 1
            ElseIf Char1 = "I" Then
                CountI = CountI + 1
            ElseIf Char1 = "O" Then
                CountO = CountO + 1
            ElseIf Char1 = "U" Then
                CountU = CountU + 1
            End If
        Next

        'OUTPUT
        Console.WriteLine("Count of A: " & CountA)
        Console.WriteLine("Count of E: " & CountE)
        Console.WriteLine("Count of I: " & CountI)
        Console.WriteLine("Count of O: " & CountO)
        Console.WriteLine("Count of U: " & CountU)

        Console.ReadKey()


    End Sub

End Module
