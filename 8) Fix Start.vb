Module Module1

    Sub Main()
        'DELCARATION
        Dim Str1, Str2, Str3 As String
        Dim Char1, Char2, Char3 As Char
        Dim i As Integer

        'INITIALISATION
        Str1 = ""
        Str2 = ""
        Str3 = ""
        Char1 = ""
        Char2 = ""
        Char3 = "*"
        i = 0

        'INPUT 
        Console.Write("Input String: ")
        Str1 = Console.ReadLine
        Str1 = UCase(Str1)

        'PROCESS
        Char1 = Mid(Str1, 1, 1)
        Str2 = Right(Str1, Len(Str1) - 1)
        For i = 1 To Len(Str2)
            Char2 = Mid(Str2, i, 1)
            If Char2 = Char1 Then
                Str3 = Str3 + Char3
            Else
                Str3 = Str3 + Char2
            End If
        Next
        Str3 = LCase(Str3)

        'OUTPUT
        Console.WriteLine("New String: " & Char1 & Str3)
        Console.ReadKey()
    End Sub

End Module
