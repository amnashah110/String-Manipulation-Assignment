Module Module1

    Sub Main()
        'DECLARATION
        Dim Str1, Str2 As String

        'INITIALISATION
        Str1 = ""
        Str2 = ""

        'INPUT
        Console.Write("Enter String: ")
        Str1 = Console.ReadLine
        Str1 = LCase(Str1)

        'PROCESS
        If Len(Str1) >= 3 Then
            If InStr(Str1, "ing") > 0 Then
                Str2 = Str1 + "ly"
            Else
                Str2 = Str1 + "ing"
            End If
        Else
            Str2 = Str1
        End If

        'OUTPUT
        Console.WriteLine("New String: " & Str2)
        Console.ReadKey()

    End Sub

End Module
