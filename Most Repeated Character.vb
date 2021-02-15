Module Module1

    Sub Main()
        'DECLARATION
        Dim Str1 As String
        Dim Char1, Char2, Char3 As Char
        Dim i, j, NumOfChar, CharCount As Integer

        'INITIALISATION
        Str1 = ""
        Char1 = ""
        Char2 = ""
        Char3 = ""
        i = 0
        j = 0
        NumOfChar = 0
        CharCount = 0

        'INPUT
        Console.Write("Enter String: ")
        Str1 = Console.ReadLine

        'PROCESS
        For i = 1 To Len(Str1)
            Char1 = Mid(Str1, i, 1)
            For j = 1 To Len(Str1)
                Char2 = Mid(Str1, j, 1)
                If Char2 = Char1 Then
                    NumOfChar = NumOfChar + 1
                End If
            Next
            If NumOfChar > CharCount Then
                Char3 = Char1
                CharCount = NumOfChar
            End If
            NumOfChar = 0
        Next

        'OUTPUT
        Console.WriteLine("Most repeated character: " & Char3)
        Console.ReadKey()
    End Sub

End Module
