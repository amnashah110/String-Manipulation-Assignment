Module Module1

    Sub Main()
        'DECLARATION
        Dim Str1, Str2, Str3, Str4, Str5, Str6 As String
        
        'INITIALISATION
        Str1 = ""
        Str2 = ""
        Str3 = ""
        Str4 = ""
        Str5 = ""
        Str6 = ""

        'INPUT
        Console.Write("Enter First String: ")
        Str1 = Console.ReadLine
        Console.Write("Enter Second String: ")
        Str2 = Console.ReadLine

        'PROCESS
        Str3 = Left(Str1, 2)
        Str4 = Left(Str2, 2)
        Str5 = Right(Str1, Len(Str1) - Len(Str3))
        Str6 = Right(Str2, Len(Str2) - Len(Str4))

        'OUTPUT
        Console.WriteLine("New String: " & Str4 & Str5 & " " & Str3 & Str6)
        Console.ReadKey()

    End Sub


End Module
