Module Module1

    Sub Main()
        'DECLARATION
        Dim Str1, Str2 As String
        Dim Char1, Char2, Char3 As Char
        Dim i As Integer

        'INITIALISATION
        Str1 = ""
        Str2 = ""
        Char1 = ""
        Char2 = ""
        Char3 = ""
        i = 0

        'INPUT
        Console.Write("Enter String: ")
        Str1 = Console.ReadLine
        Console.Write("Enter Character To Be Replaced: ")
        Char1 = Console.ReadLine
        Console.Write("Enter Character To Replace Selected Character: ")
        Char2 = Console.ReadLine

        'PROCESS
        For i = 1 To Len(Str1)
            Char3 = Mid(Str1, i, 1)
            If Char3 = Char1 Then
                Str2 = Str2 + Char2
            Else
                Str2 = Str2 + Char3
            End If
        Next

        'OUTPUT
        Console.WriteLine("New String: " & Str2)
        Console.ReadKey()


    End Sub

End Module