'By Andrew Cave and Jordan McCall
' ▲
'▲ ▲ Do you even triforce
Imports System.Threading
Module Module1
    Dim coins As Integer = 100
    Dim r As New Random
    Dim reels As Dictionary(Of String, Integer)
    Dim currentStake As Integer = 1
    Sub Main()
        Console.SetWindowSize(100, 50)
        Console.SetWindowPosition(0, 0)
        Do
            Call menu()
            Call functionPrompt()
            Console.ReadKey()
        Loop
    End Sub
    Sub menu()
        Console.Clear()
        Console.WriteLine("*************** Functions ***************")
        Console.WriteLine("*****************************************")
        Console.WriteLine("**                                     **")
        Console.WriteLine("** Addition                 (+)        **")
        Console.WriteLine("** Subtraction              (-)        **")
        Console.WriteLine("** Multiplication           (*)        **")
        Console.WriteLine("** Division                 (/)        **")
        Console.WriteLine("** Multiple Operation       (multcalc) **")
        Console.WriteLine("** Integer Division         (div)      **")
        Console.WriteLine("** Modulo                   (mod)      **")
        Console.WriteLine("** Index                    (index)    **")
        Console.WriteLine("** Root                     (root)     **")
        Console.WriteLine("** Character to ASCII       (ascii)    **")
        Console.WriteLine("** ASCII to Character       (char)     **")
        Console.WriteLine("** Binary to Denary         (b2d)      **")
        Console.WriteLine("** Binary to Hex            (b2h)      **")
        Console.WriteLine("** Denary to Binary         (d2b)      **")
        Console.WriteLine("** Denary to Hex            (d2h)      **")
        Console.WriteLine("** Hex to Binary            (h2b)      **")
        Console.WriteLine("** Hex to Denary            (h2d)      **")
        Console.WriteLine("** Change text colour       (colour)   **")
        Console.WriteLine("** Change background colour (bcolour)  **")
        Console.WriteLine("** Text To Morse Code       (t2m)      **")
        Console.WriteLine("** Slot machine             (slot)     **")
        Console.WriteLine("**                                     **")
        Console.WriteLine("*****************************************")
        Console.WriteLine("*****************************************")
    End Sub
    Sub functionPrompt()
        Dim func As String
        Dim output As String = ""
        Console.Write("Function: ")
        func = Console.ReadLine()
        If func = "+" Then
            output = simpleAddition()
        ElseIf func = "-" Then
            output = simpleMinus()
            Console.WriteLine("= " & output)
        ElseIf func = "*" Then
            output = simpleMultiplication()
            Console.WriteLine("= " & output)
        ElseIf func = "/" Then
            output = simpleDivision()
            Console.WriteLine("= " & output)
        ElseIf func = "div" Or func = "\" Then
            output = integerDivision()
            Console.WriteLine("= " & output)
        ElseIf func = "mod" Then
            output = modulo()
            Console.WriteLine("= " & output)
        ElseIf func = "index" Or func = "^" Then
            output = index()
            Console.WriteLine("= " & output)
        ElseIf func = "root" Then
            output = root()
            Console.WriteLine("= " & output)
        ElseIf func = "andrew" Then
            Call MeMaybe()
        ElseIf func = "jordan" Then
            Call whyyounocallme()
        ElseIf func = "ascii" Then
            output = char2ascii()
            Console.WriteLine("= " & output)
        ElseIf func = "char" Then
            output = ascii2char()
            Console.WriteLine("= " & output)
        ElseIf func = "colour" Then
            Call colourMenu()
        ElseIf func = "b2d" Then
            output = BinToDen()
            Console.WriteLine("= " & output)
        ElseIf func = "b2h" Then
            output = BinToHex()
            Console.WriteLine("= " & output)
        ElseIf func = "d2b" Then
            output = DenToBin()
            Console.WriteLine("= " & output)
        ElseIf func = "d2h" Then
            output = DenToHex()
            Console.WriteLine("= " & output)
        ElseIf func = "h2b" Then
            Console.WriteLine("= " & output)
            output = HexToBin()
            Console.WriteLine("= " & output)
        ElseIf func = "h2d" Then
            output = HexToDen()
            Console.WriteLine("= " & output)
        ElseIf func = "bcolour" Then
            Call bcolourMenu()
        ElseIf func = "multcalc" Then
            output = MultiCalculation()
            Console.WriteLine("= " & output)
        ElseIf func = "matrix" Then
            Call matrix()
        ElseIf func = "t2m" Then
            output = TextToMorse()
            Console.WriteLine("= " & output)
        ElseIf func = "slot" Then
            Call begin()
        End If
        Console.WriteLine("Press any key to continue")
    End Sub
    Sub colourMenu()
        Console.Clear()
        Dim uopt As String = ""
        Console.WriteLine("********** Colours **********")
        Console.WriteLine("*****************************")
        Console.WriteLine("**                         **")
        Console.WriteLine("** 1.  Dark Blue           **")
        Console.WriteLine("** 2.  Dark Green          **")
        Console.WriteLine("** 3.  Dark Cyan           **")
        Console.WriteLine("** 4.  Dark Red            **")
        Console.WriteLine("** 5.  Dark Magenta        **")
        Console.WriteLine("** 6.  Dark Yellow         **")
        Console.WriteLine("** 7.  Gray                **")
        Console.WriteLine("** 8.  Dark Gray           **")
        Console.WriteLine("** 9.  Blue                **")
        Console.WriteLine("** 10. Green               **")
        Console.WriteLine("** 11. Cyan                **")
        Console.WriteLine("** 12. Red                 **")
        Console.WriteLine("** 13. Magenta             **")
        Console.WriteLine("** 14. Yellow              **")
        Console.WriteLine("** 15. White               **")
        Console.WriteLine("**                         **")
        Console.WriteLine("*****************************")
        Console.WriteLine("*****************************")
        Console.WriteLine()
        Console.Write("I choose colour number: ")
        uopt = Console.ReadLine
        Console.Clear()
        Try
            Console.ForegroundColor = uopt
        Catch ex As Exception
            Console.WriteLine("Input was invalid, press any key to continue")
            Console.ReadKey()
        End Try
    End Sub
    Sub whyyounocallme()
        Dim colour As Integer
        Call Randomize()

        Do
            colour = Rnd() * 15
            Console.ForegroundColor = colour
            colour = Rnd() * 15
            Console.BackgroundColor = colour
            Call FE()
            Console.Clear()
        Loop
    End Sub
    Sub FE()
        Console.WriteLine(" .    .....                              .      ...      ..                     ")
        Console.WriteLine("                           .   .. ... .                                         ")
        Console.WriteLine("                              MMM?7= .MM.                                       ")
        Console.WriteLine("                     ....$MM?.... . .  .MM.                                     ")
        Console.WriteLine("                  ..,8MM  ....  ..8.   ...M .                                   ")
        Console.WriteLine("                ...NM.  .. .. ..~ .8  .  8+M                                    ")
        Console.WriteLine("              ...NN.....,...  ..,Z. .   .. O$. .                                ")
        Console.WriteLine("             . .M~   . .   ..+8+  ..=.... . MM.                                 ")
        Console.WriteLine("             .+M  ..M..8..88 .  .  +:Z,OM8:...M.                                ")
        Console.WriteLine("           .. M~ .  M  .ONMDO.  M . . NIM~   ,MMMMMD8. ..                       ")
        Console.WriteLine("           .. O.    . ,.MN.:M.    .  .+M,7:,DD8DD8.  .NMZ                       ")
        Console.WriteLine("             M .    .,. MMI?+. .,  .N ...,,DDDOMODMM?.  .M.                     ")
        Console.WriteLine("           . M. .   ..  8$7.8 .M=N :: ...... :,MM8.. N   .ZM .                  ")
        Console.WriteLine("            :M..8.     O..,M ,...  Z . .. , DNM8$.I..=      NM                  ")
        Console.WriteLine("          ..:M        .. =.O..  ..    =M:MMMN.MM.,.         ..N..               ")
        Console.WriteLine("          . M=.       . ,IMMMMMMMMMMNMNOIMMMMO..8.I,        . ~M.               ")
        Console.WriteLine("          . M .     ..$  ...   ...~8MMM8 O ? . ?.:       ..  ..Z7.              ")
        Console.WriteLine("            M O...  ..= ...,? O?...,.   . ,,I......      ,      D8 .            ")
        Console.WriteLine("           .M .M,.    .  .N . ..  7N,   .8 . ..,...      :.     .M:.            ")
        Console.WriteLine("          ..D  O, :      .~  :.. ..... ..    ..+. ... ..        ..M.            ")
        Console.WriteLine("         . M...   ,+     ..,. . O. .         ..7.. ...          ..M             ")
        Console.WriteLine("         ..M...   .      ..=. . . .        .......... . .        .M             ")
        Console.WriteLine("         .OD.Z ?           ..       ..     .        .=           .M.        .   ")
        Console.WriteLine("         .M  O...        ....     ..:             ...,..      .  ~M.            ")
        Console.WriteLine("          M... .Z.       ..       ..              ..+.. .     . .M..            ")
        Console.WriteLine("          M  .:. .  I      ..                   . ..          ..M .             ")
        Console.WriteLine("          ~M . .   IO       .  ..   . ,             .         ,N+.              ")
        Console.WriteLine("            MD.  ..+.          +.    .  .   .               ..MM.               ")
        Console.WriteLine("           . :M . .?..       .  7.   . ..  ..               .I8 .               ")
        Console.WriteLine("             . ~M. O Z... .,.   ..         .               .MM                  ")
        Console.WriteLine("                .M8..~.  .   . .            O              M,                   ")
        Console.WriteLine("                 .NM. ,.:..  . .           .O            .M:                    ")
        Console.WriteLine("                    MN ..: ..              .            ,M.                     ")
        Console.WriteLine("                     :N. ..8 . .          .,      . ..  M=.                     ")
        Console.WriteLine("                    ...~M.   8. ..       ....   .. O. MM.                       ")
        Console.WriteLine("                        ..MMI ....$:  . 8 .. ,D. .  M8.                    .    ")
        Console.WriteLine("                            ,.8MM~====+==~MMMMMMMOO  .                          ")
        Console.WriteLine("                              . .   ....MD., ... .. ..                          ")
        Console.WriteLine("                                       .MM+,                                    ")
        Console.WriteLine("                                     ..DMMOMMM ...                              ")
        Console.WriteLine("                                   ..OMM.M.  7MM                                ")
        Console.WriteLine("                                   .MM? .M     OMM~.                            ")
        Console.WriteLine("           .                       MM ...M,       MM                            ")
        Console.WriteLine("                                ..MM.    M,    .   MM= .                        ")
        Console.WriteLine("                                .NN .    IN    .  . =MM                         ")
        Console.WriteLine("  .                      .       .       ..  . .       ..                       ")
    End Sub
    Sub bcolourMenu()
        Console.Clear()
        Dim uopt As String = ""
        Console.WriteLine("********** Colours **********")
        Console.WriteLine("*****************************")
        Console.WriteLine("**                         **")
        Console.WriteLine("** 1.  Dark Blue           **")
        Console.WriteLine("** 2.  Dark Green          **")
        Console.WriteLine("** 3.  Dark Cyan           **")
        Console.WriteLine("** 4.  Dark Red            **")
        Console.WriteLine("** 5.  Dark Magenta        **")
        Console.WriteLine("** 6.  Dark Yellow         **")
        Console.WriteLine("** 7.  Gray                **")
        Console.WriteLine("** 8.  Dark Gray           **")
        Console.WriteLine("** 9.  Blue                **")
        Console.WriteLine("** 10. Green               **")
        Console.WriteLine("** 11. Cyan                **")
        Console.WriteLine("** 12. Red                 **")
        Console.WriteLine("** 13. Magenta             **")
        Console.WriteLine("** 14. Yellow              **")
        Console.WriteLine("** 15. White               **")
        Console.WriteLine("**                         **")
        Console.WriteLine("*****************************")
        Console.WriteLine("*****************************")
        Console.WriteLine()
        Console.Write("I choose colour number: ")
        uopt = Console.ReadLine
        Console.Clear()
        Try
            Console.BackgroundColor = uopt
        Catch ex As Exception
            Console.WriteLine("Input was invalid, press any key to continue")
            Console.ReadKey()
        End Try
    End Sub
    Function simpleAddition()
        Dim x As Integer
        Dim a As Integer
        Dim b As Integer
        Console.WriteLine("Enter first value")
        a = Console.ReadLine()
        Console.WriteLine("Enter second value")
        b = Console.ReadLine()
        x = a + b
        Return x
    End Function
    Function simpleMinus()
        Dim x As Integer
        Dim a As Integer
        Dim b As Integer
        Console.WriteLine("Enter first value")
        a = Console.ReadLine()
        Console.WriteLine("Enter second value")
        b = Console.ReadLine()
        x = a - b
        Return x
    End Function
    Function simpleMultiplication()
        Dim x As Integer
        Dim a As Integer
        Dim b As Integer
        Console.WriteLine("Enter first value")
        a = Console.ReadLine()
        Console.WriteLine("Enter second value")
        b = Console.ReadLine()
        x = a * b
        Return x
    End Function
    Function simpleDivision()
        Dim x As Integer
        Dim a As Integer
        Dim b As Integer
        Console.WriteLine("Enter first value")
        Try
            a = Console.ReadLine()
        Catch ex As Exception
            Console.WriteLine("Invalid input")
            Console.ReadKey()
            End
        End Try
        If a = 0 Then
            Call divbyzero()
        End If
        Console.WriteLine("Enter second value")
        Try
            b = Console.ReadLine()
        Catch ex As Exception
            Console.WriteLine("Invalid input")
            Console.ReadKey()
            End
        End Try
        If b = 0 Then
            Call divbyzero()
        End If
        x = a / b
        Return x
    End Function
    Function integerDivision()
        Dim x As Integer
        Dim a As Integer
        Dim b As Integer
        Console.WriteLine("Enter first value")
        a = Console.ReadLine()
        Console.WriteLine("Enter second value")
        b = Console.ReadLine()
        x = a \ b
        Return x
    End Function
    Function modulo()
        Dim x As Integer
        Dim a As Integer
        Dim b As Integer
        Console.WriteLine("Enter first value")
        a = Console.ReadLine()
        Console.WriteLine("Enter second value")
        b = Console.ReadLine()
        x = a Mod b
        Return x
    End Function
    Function index()
        Dim x As Integer
        Dim a As Integer
        Dim b As Integer
        Console.WriteLine("Enter first value")
        a = Console.ReadLine()
        Console.WriteLine("Enter second value")
        b = Console.ReadLine()
        x = a ^ b
        Return x
    End Function
    Function root()
        Dim x As Integer
        Dim a As Integer
        Dim b As Integer
        Console.WriteLine("Enter constant")
        a = Console.ReadLine()
        Console.WriteLine("Enter root value")
        b = Console.ReadLine()
        x = a ^ (1 / b)
        Return x
    End Function
    Function ascii2char()
        Dim x As String
        Dim a As String
        Console.WriteLine("Enter ASCII code")
        a = Console.ReadLine()
        x = Asc(a)
        Return x
    End Function
    Function char2ascii()
        Dim x As String
        Dim a As String
        Console.WriteLine("Enter character")
        a = Console.ReadLine()
        x = Chr(a)
        Return x
    End Function
    Function BinToDen()
        Dim x As String
        Console.WriteLine("Enter binary Value")
        x = Console.ReadLine
        Dim out As Integer
        Dim multiplier As Integer = 1
        Dim current As Integer
        For i = Len(x) To 1 Step -1
            Try
                current = Mid(x, i, 1)
            Catch ex As Exception
                Console.WriteLine("Invalid input")
                Console.ReadLine()
                End
            End Try
            If current = 1 Or current = 0 Then
                out += (current * multiplier)
            End If
            multiplier *= 2
        Next
        Return out
    End Function
    Function BinToHex()
        Dim x As String = ""
        Console.WriteLine("Enter binary Value")
        x = Console.ReadLine
        Dim temp As String = ""
        Dim out As String = ""
        If x.Length Mod 4 = 1 Then
            x = "000" & x
        ElseIf x.Length Mod 4 = 2 Then
            x = "00" & x
        ElseIf x.Length Mod 4 = 3 Then
            x = "0" & x
        End If
        For i = 1 To Len(x) Step 4
            temp = Mid(x, i, 4)
            Select Case temp
                Case "0000"
                    out &= "0"
                Case "0001"
                    out &= "1"
                Case "0010"
                    out &= "2"
                Case "0011"
                    out &= "3"
                Case "0100"
                    out &= "4"
                Case "0101"
                    out &= "5"
                Case "0110"
                    out &= "6"
                Case "0111"
                    out &= "7"
                Case "1000"
                    out &= "8"
                Case "1001"
                    out &= "9"
                Case "1010"
                    out &= "A"
                Case "1011"
                    out &= "B"
                Case "1100"
                    out &= "C"
                Case "1101"
                    out &= "D"
                Case "1110"
                    out &= "E"
                Case "1111"
                    out &= "F"
            End Select
        Next
        Return out
    End Function
    Function DenToBin()
        Dim x As Integer
        Console.WriteLine("Please enter a value")
        x = Console.ReadLine
        Dim binarynum
        Dim output As String = ""
        Do
            binarynum = x Mod 2
            x \= 2
            output = binarynum & output
        Loop Until x = 0
        If output.Length Mod 4 = 1 Then
            output = "000" & output
        ElseIf output.Length Mod 4 = 2 Then
            output = "00" & output
        ElseIf output.Length Mod 4 = 3 Then
            output = "0" & output
        End If
        Return output
    End Function
    Sub MeMaybe()

        Do
            Console.Clear()
            Console.ForegroundColor = 9
            Call sierpinski()
            Console.Clear()
            Console.ForegroundColor = 10
            Call sierpinski()
            Console.Clear()
            Console.ForegroundColor = 11
            Call sierpinski()
            Console.Clear()
            Console.ForegroundColor = 12
            Call sierpinski()
            Console.Clear()
            Console.ForegroundColor = 13
            Call sierpinski()
            Console.Clear()
            Console.ForegroundColor = 14
            Call sierpinski()
        Loop
    End Sub

    Sub sierpinski()
        Console.WriteLine("                                                   ▲                               ")
        Console.WriteLine("                                                  ▲ ▲                              ")
        Console.WriteLine("                                                 ▲   ▲                             ")
        Console.WriteLine("                                                ▲ ▲ ▲ ▲                            ")
        Console.WriteLine("                                               ▲       ▲                           ")
        Console.WriteLine("                                              ▲ ▲     ▲ ▲                          ")
        Console.WriteLine("                                             ▲   ▲   ▲   ▲                         ")
        Console.WriteLine("                                            ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲                        ")
        Console.WriteLine("                                           ▲               ▲                       ")
        Console.WriteLine("                                          ▲ ▲             ▲ ▲                      ")
        Console.WriteLine("                                         ▲   ▲           ▲   ▲                     ")
        Console.WriteLine("                                        ▲ ▲ ▲ ▲         ▲ ▲ ▲ ▲                    ")
        Console.WriteLine("                                       ▲       ▲       ▲       ▲                   ")
        Console.WriteLine("                                      ▲ ▲     ▲ ▲     ▲ ▲     ▲ ▲                  ")
        Console.WriteLine("                                     ▲   ▲   ▲   ▲   ▲   ▲   ▲   ▲                 ")
        Console.WriteLine("                                    ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲                ")
        Console.WriteLine("                                   ▲                               ▲               ")
        Console.WriteLine("                                  ▲ ▲                             ▲ ▲              ")
        Console.WriteLine("                                 ▲   ▲        Do not wake        ▲   ▲             ")
        Console.WriteLine("                                ▲ ▲ ▲ ▲        the beast.       ▲ ▲ ▲ ▲            ")
        Console.WriteLine("                               ▲       ▲                       ▲       ▲           ")
        Console.WriteLine("                              ▲ ▲     ▲ ▲                     ▲ ▲     ▲ ▲          ")
        Console.WriteLine("                             ▲   ▲   ▲   ▲                   ▲   ▲   ▲   ▲         ")
        Console.WriteLine("                            ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲                 ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲        ")
        Console.WriteLine("                           ▲               ▲               ▲               ▲       ")
        Console.WriteLine("                          ▲ ▲             ▲ ▲             ▲ ▲             ▲ ▲      ")
        Console.WriteLine("                         ▲   ▲           ▲   ▲           ▲   ▲           ▲   ▲     ")
        Console.WriteLine("                        ▲ ▲ ▲ ▲         ▲ ▲ ▲ ▲         ▲ ▲ ▲ ▲         ▲ ▲ ▲ ▲    ")
        Console.WriteLine("                       ▲       ▲       ▲       ▲       ▲       ▲       ▲       ▲   ")
        Console.WriteLine("                      ▲ ▲     ▲ ▲     ▲ ▲     ▲ ▲     ▲ ▲     ▲ ▲     ▲ ▲     ▲ ▲  ")
        Console.WriteLine("                     ▲   ▲   ▲   ▲   ▲   ▲   ▲   ▲   ▲   ▲   ▲   ▲   ▲   ▲   ▲   ▲ ")
        Console.WriteLine("                    ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲ ▲")
    End Sub


    Function DenToHex()
        Dim x As Integer
        Console.WriteLine("Please enter a value")
        x = Console.ReadLine
        Dim binarynum
        Dim temp As String = ""
        Dim temp2
        Dim output As String = ""
        Do
            binarynum = x Mod 2
            x \= 2
            temp = binarynum & temp
        Loop Until x = 0
        If temp.Length Mod 4 = 1 Then
            temp = "000" & temp
        ElseIf temp.Length Mod 4 = 2 Then
            temp = "00" & temp
        ElseIf temp.Length Mod 4 = 3 Then
            temp = "0" & temp
        End If
        For i = 1 To Len(temp) Step 4
            temp2 = Mid(temp, i, 4)
            Select Case temp2
                Case "0000"
                    output &= "0"
                Case "0001"
                    output &= "1"
                Case "0010"
                    output &= "2"
                Case "0011"
                    output &= "3"
                Case "0100"
                    output &= "4"
                Case "0101"
                    output &= "5"
                Case "0110"
                    output &= "6"
                Case "0111"
                    output &= "7"
                Case "1000"
                    output &= "8"
                Case "1001"
                    output &= "9"
                Case "1010"
                    output &= "A"
                Case "1011"
                    output &= "B"
                Case "1100"
                    output &= "C"
                Case "1101"
                    output &= "D"
                Case "1110"
                    output &= "E"
                Case "1111"
                    output &= "F"
            End Select
        Next
        Return output
    End Function
    Function HexToBin()
        Dim x As String = ""
        Console.WriteLine("Please enter a hexedecimal value")
        x = Console.ReadLine
        Dim InvInput(Len(x)) As String
        Dim binarynum As String = ""
        For i = 1 To Len(x)
            InvInput(i) = Mid(x, i, 1)
        Next
        For i = 1 To Len(x)
            Select Case UCase(InvInput(i))
                Case 0
                    binarynum &= "0000"
                Case 1
                    binarynum &= "0001"
                Case 2
                    binarynum &= "0010"
                Case 3
                    binarynum &= "0011"
                Case 4
                    binarynum &= "0100"
                Case 5
                    binarynum &= "0101"
                Case 6
                    binarynum &= "0110"
                Case 7
                    binarynum &= "0111"
                Case 8
                    binarynum &= "1000"
                Case 9
                    binarynum &= "1001"
                Case "A"
                    binarynum &= "1010"
                Case "B"
                    binarynum &= "1011"
                Case "C"
                    binarynum &= "1100"
                Case "D"
                    binarynum &= "1101"
                Case "E"
                    binarynum &= "1110"
                Case "F"
                    binarynum &= "1111"
            End Select
        Next
        Return binarynum
    End Function
    Function HexToDen()
        Dim x As String = ""
        Console.WriteLine("Please enter a hexedecimal value")
        x = Console.ReadLine
        Dim InvInput(Len(x)) As String
        Dim binarynum As String = ""
        Dim out As Integer
        Dim current As Integer
        Dim multiplier As Integer = 1
        For i = 1 To Len(x)
            InvInput(i) = Mid(x, i, 1)
        Next
        For i = 1 To Len(x)
            Select Case UCase(InvInput(i))
                Case 0
                    binarynum &= "0000"
                Case 1
                    binarynum &= "0001"
                Case 2
                    binarynum &= "0010"
                Case 3
                    binarynum &= "0011"
                Case 4
                    binarynum &= "0100"
                Case 5
                    binarynum &= "0101"
                Case 6
                    binarynum &= "0110"
                Case 7
                    binarynum &= "0111"
                Case 8
                    binarynum &= "1000"
                Case 9
                    binarynum &= "1001"
                Case "A"
                    binarynum &= "1010"
                Case "B"
                    binarynum &= "1011"
                Case "C"
                    binarynum &= "1100"
                Case "D"
                    binarynum &= "1101"
                Case "E"
                    binarynum &= "1110"
                Case "F"
                    binarynum &= "1111"
            End Select
        Next
        For i = Len(binarynum) To 1 Step -1
            Try
                current = Mid(binarynum, i, 1)
            Catch ex As Exception
                Console.WriteLine("Invalid input")
                Console.ReadLine()
                End
            End Try
            If current = 1 Or current = 0 Then
                out += (current * multiplier)
            End If
            multiplier *= 2
        Next
        Return out
    End Function
    Function MultiCalculation()
        Dim total As Single
        Dim pass As Integer = 0
        Dim func As String = ""
        Dim current As Single
        Dim calculation As String
        Console.Clear()
        Console.WriteLine("Enter '=' to end calculations and show output")
        Console.WriteLine("Press any key to begin")
        Console.ReadKey()
        Console.Clear()
        Console.Write("Please enter number 1: ")
        total = Console.ReadLine
        calculation = total
        Do
            If pass > 0 Then
                calculation = calculation & func & current
                Console.Clear()
                Console.WriteLine("Current calculation is " & calculation & "=" & total)
                Console.WriteLine()
            End If
            pass = pass + 1
            Console.Write("Please enter a function (Currently supports +, -, /, *, \, mod, index, root ): ")
            func = Console.ReadLine
            If Not func = "=" Then
                Console.Write("Please enter number " & pass + 1 & " ")
                current = Console.ReadLine
                If func = "/" And current = 0 Then
                    Call divbyzero()
                End If
                If func = "+" Then
                    total += current
                ElseIf func = "-" Then
                    total -= current
                ElseIf func = "*" Then
                    total *= current
                ElseIf func = "/" Then
                    total /= current
                ElseIf func = "\" Then
                    total \= current
                ElseIf func = "mod" Then
                    total = total Mod current
                ElseIf func = "index" Then
                    total ^= current
                ElseIf func = "root" Then
                    total = (total) ^ (1 / current)
                Else
                    Console.WriteLine("Invalid function entered, defaulting to '='")
                    func = "="
                End If
            End If
        Loop Until func = "="
        Return total
    End Function
    Function TextToMorse()
        Dim input As String
        Dim current As String
        Dim output As String = ""
        Console.WriteLine("Please enter some text")
        input = Console.ReadLine
        input = LCase(input)
        For i = 1 To Len(input)
            current = Mid(input, i, 1)
            Select Case current
                Case "a"
                    output &= ".- "
                Case "b"
                    output &= "-... "
                Case "c"
                    output &= "-.-. "
                Case "d"
                    output &= "-.. "
                Case "e"
                    output &= ". "
                Case "f"
                    output &= "..-. "
                Case "g"
                    output &= "--. "
                Case "h"
                    output &= ".... "
                Case "i"
                    output &= ".. "
                Case "j"
                    output &= ".--- "
                Case "k"
                    output &= "-.- "
                Case "l"
                    output &= ".-.. "
                Case "m"
                    output &= "-- "
                Case "n"
                    output &= "-. "
                Case "o"
                    output &= "--- "
                Case "p"
                    output &= ".--. "
                Case "q"
                    output &= "--.- "
                Case "r"
                    output &= ".-. "
                Case "s"
                    output &= "... "
                Case "t"
                    output &= "- "
                Case "u"
                    output &= "..- "
                Case "v"
                    output &= "...- "
                Case "w"
                    output &= ".-- "
                Case "x"
                    output &= "-..- "
                Case "y"
                    output &= "-.-- "
                Case "z"
                    output &= "--.. "
                Case " "
                    output &= "    "
                Case "1"
                    output &= ".---- "
                Case "2"
                    output &= "..--- "
                Case "3"
                    output &= "...-- "
                Case "4"
                    output &= "....- "
                Case "5"
                    output &= "..... "
                Case "6"
                    output &= "-.... "
                Case "7"
                    output &= "--... "
                Case "8"
                    output &= "---.. "
                Case "9"
                    output &= "----. "
                Case "0"
                    output &= "----- "
                Case Else
                    output &= "  "
            End Select
        Next
        Return output
    End Function
    Sub begin()
        coins = 100
        Call SetDict()
        Console.WriteLine(Instructions)
        While coins > 0
            Dim response As String = Console.ReadLine
            If response.ToLower = "b" Then
                Console.WriteLine(Balance)
            ElseIf response.ToLower = "d" Then
                Console.WriteLine(Instructions)
            ElseIf response.ToLower = "p" Then
                Console.Clear()
                coins -= currentStake
                Call Pull()
                Console.WriteLine(Balance)
                Console.WriteLine(Instructions)
            ElseIf response.ToLower = "t" Then
                Console.WriteLine(Payouts)
            ElseIf response.ToLower = "q" Then
                coins = 0
            ElseIf response.ToLower = "s" Then
                Call EditStake()
            Else
                Console.WriteLine("Invalid Input.")
            End If
        End While
    End Sub
    Sub SetDict()
        reels = New Dictionary(Of String, Integer)
        reels.Add("apple | apple | apple", 30)
        reels.Add("apple | apple | pear", 0)
        reels.Add("apple | apple | grape", 0)
        reels.Add("apple | apple | orange", 0)
        reels.Add("apple | apple | cherry", 0)
        reels.Add("apple | pear | apple", 0)
        reels.Add("apple | pear | pear", 0)
        reels.Add("apple | pear | grape", 0)
        reels.Add("apple | pear | orange", 0)
        reels.Add("apple | pear | cherry", 0)
        reels.Add("apple | grape | apple", 0)
        reels.Add("apple | grape | pear", 0)
        reels.Add("apple | grape | grape", 0)
        reels.Add("apple | grape | orange", 0)
        reels.Add("apple | grape | cherry", 0)
        reels.Add("apple | orange | apple", 0)
        reels.Add("apple | orange | pear", 0)
        reels.Add("apple | orange | grape", 0)
        reels.Add("apple | orange | orange", 0)
        reels.Add("apple | orange | cherry", 0)
        reels.Add("apple | cherry | apple", 0)
        reels.Add("apple | cherry | pear", 0)
        reels.Add("apple | cherry | grape", 0)
        reels.Add("apple | cherry | orange", 0)
        reels.Add("apple | cherry | cherry", 0)
        reels.Add("pear | apple | apple", 0)
        reels.Add("pear | apple | pear", 0)
        reels.Add("pear | apple | grape", 0)
        reels.Add("pear | apple | orange", 0)
        reels.Add("pear | apple | cherry", 0)
        reels.Add("pear | pear | apple", 0)
        reels.Add("pear | pear | pear", 25)
        reels.Add("pear | pear | grape", 0)
        reels.Add("pear | pear | orange", 0)
        reels.Add("pear | pear | cherry", 0)
        reels.Add("pear | grape | apple", 0)
        reels.Add("pear | grape | pear", 0)
        reels.Add("pear | grape | grape", 0)
        reels.Add("pear | grape | orange", 0)
        reels.Add("pear | grape | cherry", 0)
        reels.Add("pear | orange | apple", 0)
        reels.Add("pear | orange | pear", 0)
        reels.Add("pear | orange | grape", 0)
        reels.Add("pear | orange | orange", 0)
        reels.Add("pear | orange | cherry", 0)
        reels.Add("pear | cherry | apple", 0)
        reels.Add("pear | cherry | pear", 0)
        reels.Add("pear | cherry | grape", 0)
        reels.Add("pear | cherry | orange", 0)
        reels.Add("pear | cherry | cherry", 0)
        reels.Add("grape | apple | apple", 0)
        reels.Add("grape | apple | pear", 0)
        reels.Add("grape | apple | grape", 0)
        reels.Add("grape | apple | orange", 0)
        reels.Add("grape | apple | cherry", 0)
        reels.Add("grape | pear | apple", 0)
        reels.Add("grape | pear | pear", 0)
        reels.Add("grape | pear | grape", 0)
        reels.Add("grape | pear | orange", 0)
        reels.Add("grape | pear | cherry", 0)
        reels.Add("grape | grape | apple", 0)
        reels.Add("grape | grape | pear", 0)
        reels.Add("grape | grape | grape", 50)
        reels.Add("grape | grape | orange", 0)
        reels.Add("grape | grape | cherry", 0)
        reels.Add("grape | orange | apple", 0)
        reels.Add("grape | orange | pear", 0)
        reels.Add("grape | orange | grape", 0)
        reels.Add("grape | orange | orange", 0)
        reels.Add("grape | orange | cherry", 0)
        reels.Add("grape | cherry | apple", 0)
        reels.Add("grape | cherry | pear", 0)
        reels.Add("grape | cherry | grape", 0)
        reels.Add("grape | cherry | orange", 0)
        reels.Add("grape | cherry | cherry", 0)
        reels.Add("orange | apple | apple", 0)
        reels.Add("orange | apple | pear", 0)
        reels.Add("orange | apple | grape", 0)
        reels.Add("orange | apple | orange", 0)
        reels.Add("orange | apple | cherry", 0)
        reels.Add("orange | pear | apple", 0)
        reels.Add("orange | pear | pear", 0)
        reels.Add("orange | pear | grape", 0)
        reels.Add("orange | pear | orange", 0)
        reels.Add("orange | pear | cherry", 0)
        reels.Add("orange | grape | apple", 0)
        reels.Add("orange | grape | pear", 0)
        reels.Add("orange | grape | grape", 0)
        reels.Add("orange | grape | orange", 0)
        reels.Add("orange | grape | cherry", 0)
        reels.Add("orange | orange | apple", 0)
        reels.Add("orange | orange | pear", 0)
        reels.Add("orange | orange | grape", 0)
        reels.Add("orange | orange | orange", 15)
        reels.Add("orange | orange | cherry", 0)
        reels.Add("orange | cherry | apple", 0)
        reels.Add("orange | cherry | pear", 0)
        reels.Add("orange | cherry | grape", 0)
        reels.Add("orange | cherry | orange", 0)
        reels.Add("orange | cherry | cherry", 0)
        reels.Add("cherry | apple | apple", 0)
        reels.Add("cherry | apple | pear", 0)
        reels.Add("cherry | apple | grape", 0)
        reels.Add("cherry | apple | orange", 0)
        reels.Add("cherry | apple | cherry", 0)
        reels.Add("cherry | pear | apple", 0)
        reels.Add("cherry | pear | pear", 0)
        reels.Add("cherry | pear | grape", 0)
        reels.Add("cherry | pear | orange", 0)
        reels.Add("cherry | pear | cherry", 0)
        reels.Add("cherry | grape | apple", 0)
        reels.Add("cherry | grape | pear", 0)
        reels.Add("cherry | grape | grape", 0)
        reels.Add("cherry | grape | orange", 0)
        reels.Add("cherry | grape | cherry", 0)
        reels.Add("cherry | orange | apple", 0)
        reels.Add("cherry | orange | pear", 0)
        reels.Add("cherry | orange | grape", 0)
        reels.Add("cherry | orange | orange", 0)
        reels.Add("cherry | orange | cherry", 0)
        reels.Add("cherry | cherry | apple", 0)
        reels.Add("cherry | cherry | pear", 0)
        reels.Add("cherry | cherry | grape", 0)
        reels.Add("cherry | cherry | orange", 0)
        reels.Add("cherry | cherry | cherry", 20)
        reels.Add("bonus | bonus | bonus", 100)
    End Sub
    Function Balance() As String
        Return "Your current coin balance is: $" & coins.ToString
    End Function
    Function Instructions() As String
        Return String.Format("Instructions:{0}To view your balance type: b{0}To view these instructions type: d{0}To spin the slot machine type: p{0}To show the payout table: t{0}To leave the slot machine early: q{0}To change the stake: s{0}", Environment.NewLine)
    End Function
    Function Payouts() As String
        Return String.Format("Payout Table{0}Apple | Apple | Apple = 30{0}Pear | Pear | Pear = 25{0}Orange | Orange | Orange = 15{0}Cherry | Cherry | Cherry = 20{0}Grape | Grape | Grape = 50{0}", Environment.NewLine)
    End Function
    Sub EditStake()
        Dim temp As Integer
        Console.Clear()
        Console.WriteLine("The Current stake is: " & currentStake)
        Console.WriteLine("Possible stakes are: 1, 2, 5 and 10")
        Console.Write("Please enter the new stake: ")
        Try
            temp = Console.ReadLine
        Catch ex As Exception
            Console.WriteLine("Stake entered is invalid")
            Console.ReadKey()
            coins = -1
        End Try
        Select Case temp
            Case 1, 2, 5, 10
                currentStake = temp
            Case Else
                Console.WriteLine("Stake entered is invalid")
                Console.ReadKey()
                coins = -1
        End Select
        Console.WriteLine(Instructions)
    End Sub
    Sub Pull()
        Dim spinned_reel As KeyValuePair(Of String, Integer) = reels.ToList()(r.Next(0, reels.Count - 1))
        Console.WriteLine(spinned_reel.Key)
        coins += spinned_reel.Value * currentStake
    End Sub
    Sub divbyzero()
        Console.Clear()
        Console.WriteLine("You tried to divide by zero")
        Thread.Sleep(2000)
        Console.WriteLine("You never try to divide by zero")
        Thread.Sleep(2000)
        Console.WriteLine("For all you know, you just broke the earth")
        Thread.Sleep(2000)
        Console.WriteLine("Everything outside the building you are in now is gone")
        Thread.Sleep(2000)
        Console.WriteLine("Everything, just gone")
        Thread.Sleep(2000)
        Console.WriteLine("All because you divided by zero")
        Thread.Sleep(2000)
        Console.WriteLine("I've got one question....")
        Thread.Sleep(2300)
        Console.WriteLine("Was it worth it")
        Thread.Sleep(2000)
        Console.WriteLine("Did nobody ever tell you about dividing by zero")
        Thread.Sleep(2000)
        Console.WriteLine("How it can instantly break everything")
        Thread.Sleep(2700)
        Console.WriteLine("But you did it")
        Thread.Sleep(2900)
        Console.WriteLine("So for now")
        Thread.Sleep(2000)
        Console.WriteLine("I must say, goodbye")
        Thread.Sleep(3500)
        Console.WriteLine("     _.-^^---....,,--")
        Console.WriteLine(" _--                  --_")
        Console.WriteLine("<                        >)")
        Console.WriteLine("|                         |")
        Console.WriteLine(" \._                   _./")
        Console.WriteLine("    ```--. . , ; .--'''")
        Console.WriteLine("          | |   |")
        Console.WriteLine("       .-=||  | |=-.")
        Console.WriteLine("       `-=#$%&%$#=-'")
        Console.WriteLine("          | ;  :|")
        Console.WriteLine("_____.,-#%&$@%#&#~,._____ ")
        Console.ReadKey()
        End
    End Sub
    Sub matrix()
        Console.ForegroundColor = 10
        Call Randomize()
        Dim output As Integer
        Do
            output = Rnd() * 1
            Console.Write(output)
        Loop
    End Sub
    Sub spiral()
        Console.WriteLine("■□□□□□□□□□□□□□□□□□□□")
        Console.WriteLine("□□□□□□□□□□□□□□□□□□□□")
        Console.WriteLine("□□□□□□□□□□□□□□□□□□□□")
        Console.WriteLine("□□□□□□□□□□□□□□□□□□□□")
        Console.WriteLine("□□□□□□□□□□□□□□□□□□□□")
        Console.WriteLine("□□□□□□□□□□□□□□□□□□□□")
        Console.WriteLine("□□□□□□□□□□□□□□□□□□□□")
        Console.WriteLine("□□□□□□□□□□□□□□□□□□□□")
        Console.WriteLine("□□□□□□□□□□□□□□□□□□□□")
        Console.WriteLine("□□□□□□□□□□□□□□□□□□□□")
        Console.WriteLine("□□□□□□□□□□□□□□□□□□□□")
        Console.WriteLine("□□□□□□□□□□□□□□□□□□□□")
        Console.WriteLine("□□□□□□□□□□□□□□□□□□□□")
        Console.WriteLine("□□□□□□□□□□□□□□□□□□□□")
        Console.WriteLine("□□□□□□□□□□□□□□□□□□□□")
        Console.WriteLine("□□□□□□□□□□□□□□□□□□□□")
        Console.WriteLine("□□□□□□□□□□□□□□□□□□□□")
        Console.WriteLine("□□□□□□□□□□□□□□□□□□□□")
        Console.WriteLine("□□□□□□□□□□□□□□□□□□□□")
        Console.WriteLine("□□□□□□□□□□□□□□□□□□□□")
        Thread.Sleep(100)
        Console.Clear()

    End Sub
End Module