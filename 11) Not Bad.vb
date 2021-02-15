Module Module1

    Sub Main()
        'DECLARATION
        Dim Str1, Str2, Str3 As String
        Dim NotPos, BadPos As Integer

        'INITIALISATION
        Str1 = ""
        Str2 = ""
        Str3 = ""
        NotPos = 0
        BadPos = 0

        'INPUT
        Console.Write("Enter String: ")
        Str1 = Console.ReadLine

        'PROCESS AND OUTPUT
        If InStr(Str1, "not") > 0 And InStr(Str1, "bad") > 0 Then
            NotPos = InStr(Str1, "not")
            BadPos = InStr(Str1, "bad")
            If NotPos < BadPos Then
                Str2 = Left(Str1, NotPos - 1)
                Console.WriteLine("New String: " & Str2 & "good!")
            End If
        Else
            Console.WriteLine("New String: " & Str1)
        End If
        Console.ReadKey()

    End Sub

End Module
