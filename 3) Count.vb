Module Module1

    Sub Main()
        'DECLARATION
        Dim Str1 As String
        Dim Count1, Count2, Count3 As Integer
        Dim Char1, Char2 As Char
        Dim i As Integer

        'INITIALISATION
        Str1 = ""
        Count1 = 0
        Count2 = 0
        Count3 = 0
        Char1 = ""
        Char2 = ""
        i = 0

        'INPUT
        Console.Write("Enter String: ")
        Str1 = Console.ReadLine
        Str1 = UCase(Str1)

        'PROCESS
        For i = 1 To Len(Str1)
            Char1 = Mid(Str1, i, 1)
            If Char1 >= "A" And Char1 <= "Z" Then
                Count1 = Count1 + 1
            ElseIf Char1 >= "0" And Char1 <= "9" Then
                Count2 = Count2 + 1
            Else
                Count3 = Count3 + 1
            End If
        Next

        'OUTPUT
        Console.WriteLine("Number of Alphabets: " & Count1)
        Console.WriteLine("Number of Digits: " & Count2)
        Console.WriteLine("Number of Other Characters: " & Count3)

        Console.ReadKey()


    End Sub

End Module
