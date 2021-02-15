Module Module1

    Sub Main()
        'DECLARATION
        Dim Str1, Str2, Str3 As String
        Dim Char1, Char2 As Char

        'INITIALISATION
        Str1 = ""
        Str2 = ""
        Str3 = ""
        Char1 = ""
        Char2 = ""

        'INPUT
        Console.Write("Input String: ")
        Str1 = Console.ReadLine

        'PROCESS
        If Len(Str1) >= 2 Then
            Str2 = Left(Str1, 2)
            Str3 = Right(Str1, 2)
        ElseIf Len(Str1) < 2 Then
            Str2 = Left(Str1, 1)
            Str3 = " "
        End If

        'OUTPUT
        Console.WriteLine("New String: " & Str2 & Str3)
        Console.ReadKey()

    End Sub

End Module
