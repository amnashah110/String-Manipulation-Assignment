Module Module1

    Sub Main()
        'DECLARATION
        Dim Str1, Alphabets As String
        Dim Char1 As Char
        Dim i As Integer
        Dim Check As Boolean

        'INITIALISATION
        Str1 = ""
        Alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Char1 = ""
        i = 0
        Check = True

        'INPUT
        Console.Write("Enter String: ")
        Str1 = Console.ReadLine
        Str1 = UCase(Str1)

        'PROCESS
        For i = 1 To Len(Alphabets)
            Char1 = Mid(Alphabets, i, 1)
            If InStr(Str1, Char1) = 0 Then
                Check = False
            End If
        Next i

        'OUTPUT
        If Check = True Then
            Console.WriteLine("All Alphabets Are Present")
        ElseIf Check = False Then
            Console.WriteLine("All Alphabets Are Not Present")
        End If
        Console.ReadKey()

    End Sub

End Module
