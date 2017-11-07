Imports System.Threading 'makes waiting possable
Module Module1

    Dim choice As Integer

    Sub drawMenu()
        Console.WriteLine("1) generate a username")
        Console.WriteLine("2) set a password")
        Console.WriteLine("3) generate a password")
        choice = Console.ReadLine
    End Sub
    Sub setusername()
        Dim FirstName, LastName, DOB, year, dateBorn, MonthBorn, YearBorn, username, InString As String ' sets the varibles
        Console.WriteLine("enter your First Name:") 'asks the users name
        FirstName = Console.ReadLine 'sets the FirstName varible to the users input
        Console.WriteLine("enter your last Name:") 'asks for the users last name
        LastName = Console.ReadLine 'sets the LastName varible to the users input
        Console.WriteLine("enter your date of birth:") ' asks for the users birthday
        DOB = Console.ReadLine 'sets the DOB vairble to the users input
        Console.WriteLine("enter the year you joined the school:") ' asks for what year the user joind the school
        year = Console.ReadLine 'sets the year vairble to the users input
        InString = InStr(DOB, "/" Or "-" Or ".") 'looks to see if there is any seperator in the birthday
        If Not InString = 0 Then 'looks to see if there is any seperator in the birthday
            dateBorn = Left(DOB, 2) 'looks to see if there is any seperator in the birthday
            MonthBorn = Mid(DOB, 4, 2) 'looks to see if there is any seperator in the birthday
            YearBorn = Right(DOB, 4) 'looks to see if there is any seperator in the birthday
        Else
            GoTo 21 'exits the check
        End If
21:

        Console.WriteLine(FirstName & " " & LastName & " joined in " & year & ", " & " his DOB is " & dateBorn & MonthBorn & YearBorn) 'outputs the data
        Console.ReadKey() 'waits for the user to press a key
        Console.Clear() 'clears the console
        Console.WriteLine("##################################################################") 'makes a fancy message
        Console.WriteLine("#                                                                #") 'makes a fancy message
        Console.WriteLine("#        please wait while the username is being generated       #") 'makes a fancy message
        Console.WriteLine("#                                                                #") 'makes a fancy message
        Console.WriteLine("##################################################################") 'makes a fancy message
        Thread.Sleep(2000) 'waits 2 seconds
        Console.WriteLine("your username is " & username) 'outputs the username
    End Sub
    Sub Main()
        drawMenu()
        Select Case choice
            Case 1
                Call setusername()
            Case 2
                Call setpassword()
            Case Else
                Throw New AccessViolationException

        End Select
    End Sub

    Sub setpassword()
        Dim pass1, pass2, hiddenPass As String 'sets variables
        Dim length, counter As Integer 'sets variables
        Dim valid As Boolean = False 'sets variables
        Dim worstpass(24) As String 'sets variables
        Dim yesno As String = "n"
        worstpass(0) = "123456"   'sets the worst passwords
        worstpass(1) = "password" 'sets the worst passwords
        worstpass(2) = "qwerty" 'sets the worst passwords
        worstpass(3) = "12345" 'sets the worst passwords
        worstpass(4) = "123456789" 'sets the worst passwords
        worstpass(5) = "football" 'sets the worst passwords
        worstpass(6) = "1234" 'sets the worst passwords
        worstpass(7) = "1234567" 'sets the worst passwords
        worstpass(8) = "baseball"  'sets the worst passwords
        worstpass(9) = "welcome" 'sets the worst passwords
        worstpass(10) = "1234567890" 'sets the worst passwords
        worstpass(11) = "abc123" 'sets the worst passwords
        worstpass(12) = "111111" 'sets the worst passwords
        worstpass(13) = "1qaz2wsx" 'sets the worst passwords
        worstpass(14) = "dragon" 'sets the worst passwords
        worstpass(15) = "master" 'sets the worst passwords
        worstpass(16) = "monkey"  'sets the worst passwords
        worstpass(17) = "letmein" 'sets the worst passwords
        worstpass(18) = "login" 'sets the worst passwords
        worstpass(19) = "princess" 'sets the worst passwords
        worstpass(20) = "qwertyuiop" 'sets the worst passwords
        worstpass(21) = "solo" 'sets the worst passwords
        worstpass(22) = "passw0rd" 'sets the worst passwords
        worstpass(23) = "starwars" 'sets the worst passwords
tryagain:
        Console.WriteLine("enter a password")
        pass1 = Console.ReadLine
        Console.WriteLine("do not use the following passwords")
        While Not valid = True
            Console.WriteLine("please enter a password")
            pass1 = Console.ReadLine
            Console.WriteLine("please re-enter the password")
            pass2 = Console.ReadLine
            If pass1 = pass2 Then
                Console.WriteLine("the passwords match")
                valid = True
            Else
                Console.WriteLine("the passwords do not match")

            End If
            If length > 5 Then
                Console.WriteLine("your password is valid")
            Else : GoTo tryagain
            End If
        End While
hidepass:
        length = Len(pass1)

        For Looper = 1 To length
            hiddenPass = hiddenPass & "*"
        Next
        Console.WriteLine("The password is: " & hiddenPass)
        Console.ReadKey()

    End Sub
End Module
