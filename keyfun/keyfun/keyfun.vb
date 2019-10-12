''' <summary>
''' Keep this in if you aint a scum.
''' 
''' github.com/pxtrickbtw/
''' instagram.com/pxtrick.btw/
''' https://www.buymeacoffee.com/SFbsykMJa
''' like my work? spend me a morning coffee. 
'''
'''  Tried to make the code as understand able as possible for anyone
''' </summary>


Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.IO
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Threading.Tasks



Module keyfun
    'Declarations
    Dim CurrentItem = 1
    Dim Currentkey As !
    ' Currentitem & CurrentKey arent in use anymore, remove them to make it look cleaner if you want tho

    ' Short     Info    /   Q&A

    ' Q: Why u did this whole thing with "phases"
    ' A: To make it more readable for myself and also should be for others.
    '
    ' Q: What is the porpuse of "KeyFun beta"
    ' A: Generating Serial Keys, that can be checked and may give a succeed free subscription.
    ' (A2: Also its for learning porpuses on my side)
    '
    ' I guess that an anwser to most of the questions.

    Sub Main()
        phase1()




    End Sub

    Private Sub phase1()
        'setup the title
        ' This creates a moving title on startup // you can also make auth checks or some things while creating the title.
        Do
            Console.Title = "K"
            Console.WriteLine("[debug] .")
            Threading.Thread.Sleep("250")
            Console.WriteLine("[debug] ..")
            Console.Title = "Ke"
            Threading.Thread.Sleep("250")
            Console.Title = "Key"
            Console.WriteLine("[debug] ...")
            Threading.Thread.Sleep("250")
            Console.Title = "KeyF"
            Console.WriteLine("[debug] ....")
            Threading.Thread.Sleep("250")
            Console.Title = "KeyFu"
            Console.WriteLine("[debug] .....")
            Threading.Thread.Sleep("250")
            Console.Title = "KeyFun"
            Console.WriteLine("[debug] ......")
            Threading.Thread.Sleep("250")
            ' You Could put any auth system in here or similar things.

            File.Create("C:\Desktop\output.txt").Dispose()

            ' This is a pretty good system in my opinion so users see something going on but they dont know what actually going on.
            Console.Title = "KeyFun 1"
            Console.WriteLine("[debug] .......")
            Threading.Thread.Sleep("250")
            Console.Title = "KeyFun 1."
            Console.WriteLine("[debug] ........")
            Threading.Thread.Sleep("250")
            Console.Title = "KeyFun 1.0"
            Console.WriteLine("[debug] .........")
            Threading.Thread.Sleep("250")
            Console.Title = "KeyFun 1.0 |"
            Console.WriteLine("[debug] ..........")
            Threading.Thread.Sleep("250")
            Console.Title = "KeyFun 1.0 | b"
            Console.WriteLine("[debug] ...........")
            Threading.Thread.Sleep("250")
            Console.Title = "KeyFun 1.0 | be"
            Console.WriteLine("[debug] ............")
            Threading.Thread.Sleep("250")
            Console.Title = "KeyFun 1.0 | bet"
            Console.WriteLine("[debug] .............")
            Threading.Thread.Sleep("250")
            Console.Title = "KeyFun 1.0 | beta"
            Console.WriteLine("Preparation is done.")
            Threading.Thread.Sleep(2500)

        Loop While False

        phase2()

    End Sub

    Private Sub phase2()


        Console.Clear()


        ' Big watermark
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine(" ___  __    _______       ___    ___ ________ ___  ___  ________      ".PadLeft((Console.WindowWidth / 2) + (" ___  __    _______       ___    ___ ________ ___  ___  ________      ".Length / 2)))
        Console.WriteLine("|\  \|\  \ |\  ___ \     |\  \  /  /|\  _____\\  \|\  \|\   ___  \    ".PadLeft((Console.WindowWidth / 2) + ("|\  \|\  \ |\  ___ \     |\  \  /  /|\  _____\\  \|\  \|\   ___  \    ".Length / 2)))
        Console.WriteLine("\ \  \/  /|\ \   __/|    \ \  \/  / | \  \__/\ \  \\\  \ \  \\ \  \   ".PadLeft((Console.WindowWidth / 2) + ("\ \  \/  /|\ \   __/|    \ \  \/  / | \  \__/\ \  \\\  \ \  \\ \  \   ".Length / 2)))
        Console.WriteLine(" \ \   ___  \ \  \_|/__   \ \    / / \ \   __\\ \  \\\  \ \  \\ \  \  ".PadLeft((Console.WindowWidth / 2) + (" \ \   ___  \ \  \_|/__   \ \    / / \ \   __\\ \  \\\  \ \  \\ \  \  ".Length / 2)))
        Console.WriteLine("  \ \  \\ \  \ \  \_|\ \   \/  /  /   \ \  \_| \ \  \\\  \ \  \\ \  \ ".PadLeft((Console.WindowWidth / 2) + ("  \ \  \\ \  \ \  \_|\ \   \/  /  /   \ \  \_| \ \  \\\  \ \  \\ \  \ ".Length / 2)))
        Console.WriteLine("   \ \  \\ \  \ \  \_|\ \   \/  /  /   \ \  \_| \ \  \\\  \ \  \\ \  \ ".PadLeft((Console.WindowWidth / 2) + ("   \ \  \\ \  \ \  \_|\ \   \/  /  /   \ \  \_| \ \  \\\  \ \  \\ \  \ ".Length / 2)))
        Console.WriteLine("   \ \__\\ \__\ \_______\__/  / /      \ \__\   \ \_______\ \__\\ \__\".PadLeft((Console.WindowWidth / 2) + ("   \ \__\\ \__\ \_______\__/  / /      \ \__\   \ \_______\ \__\\ \__\".Length / 2)))
        Console.WriteLine("    \|__| \|__|\|_______|\___/ /        \|__|    \|_______|\|__| \|__|".PadLeft((Console.WindowWidth / 2) + ("    \|__| \|__|\|_______|\___/ /        \|__|    \|_______|\|__| \|__|".Length / 2)))
        Console.WriteLine("                        \|___|/                                       ".PadLeft((Console.WindowWidth / 2) + ("                        \|___|/                                       ".Length / 2)))
        Console.WriteLine("beta 1.0".PadLeft((Console.WindowWidth / 2) + ("beta 1.0".Length / 2)))

        Console.WriteLine("[K] Generate Netflix gift cards".PadLeft((Console.WindowWidth / 2) + ("[K] Generate Netflix gift cards".Length / 2)))
        Console.WriteLine("[E] Generate Discord nitro gifts".PadLeft((Console.WindowWidth / 2) + ("[E] Generate Discord nitro gifts".Length / 2)))
        Console.WriteLine("[Y] Information".PadLeft((Console.WindowWidth / 2) + ("[Y] Information".Length / 2)))

        ' Bad Key system to get users keypresses for command execution
        If Console.ReadKey().Key = ConsoleKey.Y Then
            Informationp5()
        End If

        If Console.ReadKey().Key = ConsoleKey.K Then
            NetflixGCp3()
        End If

        If Console.ReadKey().Key = ConsoleKey.E Then
            DiscordGCp4()
        End If
        Console.Read()
    End Sub

    Private Sub NetflixGCp3() ' Netflix Gift Cards (Phase 3) 
        'Decl:

        Dim prefix = "LEQ"
        Dim Limit As Integer = 0
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Green
        Do
            If Limit = MaxLimit Then
                'if maxlimit done go back to main menu.
                Console.WriteLine("7.5s left until returning...")
                Threading.Thread.Sleep(7500)
                Console.Clear()
                phase2()
            Else
                ' nothing
            End If
            Threading.Thread.Sleep(25)
            Console.WriteLine(prefix + GenerateString2(2) + GenerateString(6)) ' Netflix Pattern (i think so..)
            Limit += 1
        Loop
        Console.Read()
    End Sub


    ' <<------------------------>>
    ' <<------------------------>>
    ' <<------------------------>>
    Dim MaxLimit = 501 ' Set here the amoung of generated codes
    ' <<------------------------>>
    ' <<------------------------>>
    ' <<------------------------>>

    Private Sub DiscordGCp4() ' Discord Gift Cards (Phase 4)
        'Decl:

        Dim prefix = "discord.gift/" ' + 4 Digit uppercase chars
        Dim limit As Integer = 0


        Dim path As String = "C:\Desktop\output.txt"
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Green
        Do
            If limit = MaxLimit Then ' Set your limit here also if you put smth like 500 They will only check until 499

                ' was to lazy to add a file writer...
                ' its easy go ahead do it yourself
                Console.WriteLine("7.5s left until returning...")
                Threading.Thread.Sleep(7500)
                Console.Clear()
                phase2() ' go back to main menu
            Else
                ' nothing
            End If
            Threading.Thread.Sleep(25) ' small delay
            Console.WriteLine(prefix + GenerateRandomString(4, True)) ' Generate random gift card
            'Want to make the generation more customized? Maybe add a + " | " + Limit.toString to count the keys 
            limit += 1
        Loop
        Console.Read()
    End Sub

    Private Sub Informationp5() ' Info Center (Phase 5)
        Console.WriteLine("")
        Console.Clear()
        Console.WriteLine(" Netflix:")
        Console.WriteLine("  With specific software you can check those randomly generated netflix giftcards.")
        Console.WriteLine("  With good luck you may get some free netflix giftcard.")
        Console.WriteLine("")
        Console.WriteLine(" Discord:")
        Console.WriteLine("  With specific software you can check discord nitro gifts. May the luck is on your side.")
        Console.WriteLine("  hopefully you will get some Free Discord Nitro :)")

        Console.WriteLine("")
        Console.WriteLine("In 15 seconds we return you to normal page...")
        Threading.Thread.Sleep(15000)
        phase2()

        Console.Read()

    End Sub
    Public Function GenerateRandomString(ByRef len As Integer, ByRef upper As Boolean) As String     ' Methode to generate lowercase or uppercase only chars
        Dim rand As New Random()
        Dim allowableChars() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLOMNOPQRSTUVWXYZ0123456789".ToCharArray()
        Dim final As String = String.Empty
        For i As Integer = 0 To len - 1
            final += allowableChars(rand.Next(allowableChars.Length - 1))
        Next

        Return IIf(upper, final.ToUpper(), final)
    End Function
    Public Function GenerateString(ByVal size As Integer) As String ' Gen string
        Dim chars As Char() = New Char(size - 1) {}

        For i As Integer = 0 To size - 1
            chars(i) = Alphabeta(Random.[Next](Alphabeta.Length))
        Next

        Return New String(chars)
    End Function
    Private mouseinX As Integer = 0, mouseinY As Integer = 0 ' useless implemented things i wanted todo smth with...
    Private mouseX As Integer = 0, mouseY As Integer = 0 'useless implemented things i wanted todo smth with...
    Private mouseDown As Boolean 'useless implemented things i wanted todo smth with...
    Private random As Random = New Random()
    Public Const Alphabeta As String = "0123456789"
    Private random2 As Random = New Random()
    Public Const Alphabeta2 As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"

    Public Function GenerateString2(ByVal size As Integer) As String ' other way to generate uppercase chars (only.)
        Dim chars As Char() = New Char(size - 1) {}

        For i As Integer = 0 To size - 1
            chars(i) = Alphabeta2(random.[Next](Alphabeta2.Length))
        Next

        Return New String(chars)
    End Function
End Module
