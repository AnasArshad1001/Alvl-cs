Module Module1
    Dim UsernameArray() = {"637828 Aston", "637826 Martin", "637830 Lambo", "637825 Aventador", "637831 Gallardo", "637827 Merc", "637829 BMW"}
    Sub Main()
        Dim swapped As Boolean
        Dim temp As String
        Dim maxsize As Integer
        Dim x1, x2 As String
        maxsize = 6

        swapped = True
        While swapped <> False
            swapped = False

            For count = 0 To maxsize - 1

                x1 = Mid(UsernameArray(count), 8, 1)
                x2 = Mid(UsernameArray(count + 1), 8, 1)

                If x2 < x1 Then

                    temp = UserNameArray(count)

                    UserNameArray(count) = UserNameArray(count + 1)

                    UserNameArray(count + 1) = temp

                    swapped = True
                End If

            Next
            maxsize = maxsize - 1

        End While
        For count = 0 To 6
            Console.WriteLine(count & ": " & UserNameArray(count))
        Next
        Console.ReadKey()
    End Sub

End Module
