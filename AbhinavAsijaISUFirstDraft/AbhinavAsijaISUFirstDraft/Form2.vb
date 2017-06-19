Public Class Form2
    Public count As Integer 'Declare variables and counters
    Public tempString As String
    Dim x As Integer
    Dim knew As Integer
    Public forsubcounter As Integer
    Public dosubcounter As Integer
    Public forclick As Integer = 0
    Public doclick As Integer = 0

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Start() 'Formatting
        TextBox1.ReadOnly = True
        Label1.Text = "Click to Continue"
        count += 1
        PictureBox2.Hide()
        ForLoop.Hide()
        DoLoop.Hide()
        If count = 0 Or count = 4 Then
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        lesson() 'Start sub routine
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        lesson() 'Start sub routine
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If Label1.Text.Equals("") = False Then 'Make click to continue blink
            Label1.Text = ""
        ElseIf Label1.Text.Equals("") = True Then
            Label1.Text = "Click to Continue"
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.openform() 'Skip tutorial and go to activity
        Me.Hide()
        Form3.Show()
        Form3.TextBox4.Hide()
        Form3.Label1.Hide()
        If Form1.complete1 = 1 And Form1.complete2 = 0 And forclick = 0 And doclick = 0 Then
            Me.Show()
            Form3.Hide()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide() 'Return to homescreen
        Form1.Show()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        PictureBox2.Location = New Point(PictureBox2.Location.X, PictureBox2.Location.Y + x) 'Move pointer down
        If PictureBox2.Location.Y > 170 Then
            x = 0
            Timer3.Stop()
            Timer4.Start()
            x += 20
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        PictureBox2.Location = New Point(PictureBox2.Location.X, PictureBox2.Location.Y - x) 'Move pointer down
        If PictureBox2.Location.Y < 120 Then
            x = 0
            Timer3.Start()
            Timer4.Stop()
            x += 20
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        TextBox1.Text += tempString.Substring(TextBox1.Text.Length, 1) 'Make text appear one letter at a time

        If TextBox1.Text = tempString Then
            Timer5.Enabled = False
        End If
    End Sub

    Private Sub ForLoop_Click(sender As Object, e As EventArgs) Handles ForLoop.Click
        ForLoop.Hide() 'Formatting of game if you choose "for loop"
        DoLoop.Hide()
        TextBox1.Clear()
        Timer5.Enabled = False
        forclick = 1
        forsubcounter = 0
        My.Settings.forclick = 1
    End Sub

    Private Sub DoLoop_Click(sender As Object, e As EventArgs) Handles DoLoop.Click
        ForLoop.Hide() 'Formatting of game if you choose "do loop"
        DoLoop.Hide()
        TextBox1.Clear()
        Timer5.Enabled = False
        doclick = 1
        dosubcounter = 0
        My.Settings.doclick = 1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.ImageLocation = "E:\Technology\Grade 10\Computer Science\Culminating ISU\AbhinavAsijaISUFirstDraft\AbhinavAsijaISUFirstDraft\KenPointOpen.png" 'Teacher speaking animation
        If Timer1.Enabled = True Then
            Timer1.Enabled = False
            Timer6.Enabled = True
        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        PictureBox1.ImageLocation = "E:\Technology\Grade 10\Computer Science\Culminating ISU\AbhinavAsijaISUFirstDraft\AbhinavAsijaISUFirstDraft\KenPointClosed.png" 'Teacher speaking animation
        If Timer6.Enabled = True Then
            Timer6.Enabled = False
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub lesson()
        TextBox1.Clear()
        count += 1
        forsubcounter += 1
        dosubcounter += 1
        If Form1.complete1 = 0 Then
            If count = 0 Then
                TextBox1.Text = ""
            ElseIf count = 1 Then 'Start tutorial, timer5 will make tempString appear one letter at a time
                tempString = "Hello, my name is Kenric and I will be your VB teacher. This box will output everything I teach. The box beside me will display the output of what I am teaching. Today I will be teaching you how to declare a variable"
                Timer5.Enabled = True
                Timer1.Enabled = True
                If TextBox1.Text.Length = tempString.Length Then
                    Timer1.Enabled = False
                    Timer6.Enabled = False
                End If
            ElseIf count = 2 Then 'Continue tutorial
                tempString = "Syntax rules, are rules that you must follow in order to have your program run. To declare a variable we will use the syntax shown in the display box. CAPITAL LETTERS ARE VERY IMPORTANT WITH SYNTAX! 'Dim' will always start off a variable declaration, next comes the variable name, the word 'As' and then the type of variable you want to use"
                TextBox2.Text = "Dim (variable name) As (variable type)"
                Timer5.Enabled = True
                Timer1.Enabled = True
                If Timer5.Enabled = False Then
                    Timer1.Enabled = False
                    Timer2.Enabled = False
                End If
            ElseIf count = 3 Then 'Continue tutorial
                tempString = "The variable name can be anything you want it to be, but it is more useful to have a name that relates to its use. The variable type can vary although the ones that we will use most are..."
                PictureBox2.Show()
                PictureBox2.Location = New Point(66, 105)
                x += 20
                Timer3.Start()
                Timer1.Enabled = True
                Timer5.Enabled = True
                If Timer5.Enabled = False Then
                    Timer1.Enabled = False
                    Timer2.Enabled = False
                End If
            ElseIf count = 4 Then 'Continue tutorial
                tempString = "String - Any number, letter or punctuation symbol" & vbCrLf & "Integer - Any positive or negative whole number" & vbCrLf & "Single - A positive or negative number, including decimals"
                PictureBox2.Location = New Point(256, PictureBox2.Location.Y)
                Timer5.Enabled = True
                Timer1.Enabled = True
                If Timer5.Enabled = False Then
                    Timer1.Enabled = False
                    Timer2.Enabled = False
                End If
            Else 'End tutorial, start activity
                PictureBox2.Hide()
                Me.Hide()
                Form3.Show()
                TextBox2.Clear()
                count = 0
                PictureBox1.ImageLocation = "F:\Technology\Grade 10\Computer Science\Culminating ISU\AbhinavAsijaISUFirstDraft\AbhinavAsijaISUFirstDraft\KenMouthClosed.png"
                Form3.openform()
            End If
        ElseIf Form1.complete1 = 1 And Form1.complete2 = 0 Then 'Start tutorial
            If count = 0 Then
                TextBox1.Text = ""
            ElseIf count = 1 Then
                tempString = "Welcome back! Nice job completing your first tutorial, easy right? Well don't worry, the real challenges are yet to come"
                Timer5.Enabled = True
                Timer1.Enabled = True
                If Timer5.Enabled = False Then
                    Timer1.Enabled = False
                    Timer2.Enabled = False
                End If
            ElseIf count = 2 Then 'Continue tutorial
                tempString = "The next tutorial will be outling loops. This is your first choice event! You can choose to learn 'For Loops' or 'Do Loops'"
                Timer5.Enabled = True
                Timer1.Enabled = True
                If Timer5.Enabled = False Then
                    Timer1.Enabled = False
                    Timer2.Enabled = False
                End If
            ElseIf count = 3 Then 'Continue tutorial
                tempString = "Please select one of the loops as shown in my output box"
                ForLoop.Show()
                DoLoop.Show()
                Timer5.Enabled = True
                Timer1.Enabled = True
                If Timer5.Enabled = False Then
                    Timer1.Enabled = False
                    Timer2.Enabled = False
                End If
            Else 'End tutorial, start activity
                tempString = "Please select one of the loops as shown in my output box"
                Timer5.Enabled = True
                Timer1.Enabled = True
                If Timer5.Enabled = False Then
                    Timer1.Enabled = False
                    Timer2.Enabled = False
                End If
                If forclick = 1 Then
                    If forsubcounter = 1 Then 'Start tutorial
                        tempString = "Welcome to the first loop tutorial, you will learn what a loop does and how to write the proper syntax for a 'For Loop'"
                        Timer5.Enabled = True
                        Timer1.Enabled = True
                        If Timer5.Enabled = False Then
                            Timer1.Enabled = False
                            Timer2.Enabled = False
                        End If
                    ElseIf forsubcounter = 2 Then 'Continue tutorial
                        tempString = "A loop is a series of actions that are repeated until an condition is met"
                        Timer5.Enabled = True
                        Timer1.Enabled = True
                        If Timer5.Enabled = False Then
                            Timer1.Enabled = False
                            Timer2.Enabled = False
                        End If
                    ElseIf forsubcounter = 3 Then 'Continue tutorial
                        tempString = "An example of this in the real world is washing dishes. If you need to wash 10 dishes you will repeat the action of washing dishes, you will stop the loop once you have met the condition of 10 dishes being washed"
                        Timer5.Enabled = True
                        Timer1.Enabled = True
                        If Timer5.Enabled = False Then
                            Timer1.Enabled = False
                            Timer2.Enabled = False
                        End If
                    ElseIf forsubcounter = 4 Then 'Continue tutorial
                        tempString = "The basic syntax in a for loop is shown here, we are able to assign variables within the for statement to be more efficient with our code"
                        TextBox2.Text = "For (variable name) As (variable type) = (first parameter) to (second parameter) Step (scale)" & vbCrLf & vbCrLf & "End For"
                        Timer5.Enabled = True
                        Timer1.Enabled = True
                        If Timer5.Enabled = False Then
                            Timer1.Enabled = False
                            Timer2.Enabled = False
                        End If
                    ElseIf forsubcounter = 5 Then 'Continue tutorial
                        tempString = "The first half of the statement is declaring a variable, the second half is the harder part. Your parameters are 2 numbers that the loop will count from and to for example, 1 to 10. Step is the increment that you will count by. If your statement is For count As Integer = 1 to 10 Step 2, you will output the numbers 1, 3, 5, 7, 9. If you want to coutn by 1, there is no need to include 'Step'. End For are simply the keywords needed to enclose a for loop"
                        Timer5.Enabled = True
                        Timer1.Enabled = True
                        If Timer5.Enabled = False Then
                            Timer1.Enabled = False
                            Timer2.Enabled = False
                        End If
                    ElseIf forsubcounter = 6 Then 'Continue tutorial
                        tempString = "In order to output our for loop data, we will need to store the data in a variable, tempString is a common variable name that will be used to store our variables. tempString = tempString & count is how we put the data into a variable next, Textbox1.Text = tempString is how to display the data in the variable"
                        Timer5.Enabled = True
                        Timer1.Enabled = True
                        If Timer5.Enabled = False Then
                            Timer1.Enabled = False
                            Timer2.Enabled = False
                        End If
                    Else 'End tutorial, start activity
                        Me.Hide()
                        Form3.Show()
                        Form3.openform()
                        TextBox1.Clear()
                        TextBox2.Clear()
                        count = 0
                    End If
                ElseIf doclick = 1 Then 'Start tutorial
                    If dosubcounter = 1 Then
                        tempString = "Welcome to the first loop tutorial, you will learn what a loop does and how to write the proper syntax for a 'Do Loop'"
                        Timer5.Enabled = True
                        Timer1.Enabled = True
                        If Timer5.Enabled = False Then
                            Timer1.Enabled = False
                            Timer2.Enabled = False
                        End If
                    ElseIf dosubcounter = 2 Then 'Continue tutorial
                        tempString = "A loop is a series of actions that are repeated until an condition is met"
                        Timer5.Enabled = True
                        Timer1.Enabled = True
                        If Timer5.Enabled = False Then
                            Timer1.Enabled = False
                            Timer2.Enabled = False
                        End If
                    ElseIf dosubcounter = 3 Then 'Continue tutorial
                        tempString = "A real world example of this is when you wash dishes. If you need to wash 10 dishes, you will repeat the action of cleaning dishes until you have met the condition of 10 dishes"
                        Timer5.Enabled = True
                        Timer1.Enabled = True
                        If Timer5.Enabled = False Then
                            Timer1.Enabled = False
                            Timer2.Enabled = False
                        End If
                    ElseIf dosubcounter = 4 Then 'Continue tutorial
                        tempString = "The basic syntax for a do loop is shown here, 'Do Until' is simply basic syntax and will always be there. Next comes an expression such as x = 10, the loop will continue to run until x = 10. 'Loop' is also basic syntax needed to close a do loop. Often, counters are introduced into do loops in order for a variable value to change until the required value is met. The syntax for a counter is, (variable name) += 1"
                        TextBox2.Text = "Do Until (condition/expression)" & vbCrLf & vbCrLf & "Loop"
                        Timer5.Enabled = True
                        If Timer5.Enabled = False Then
                            Timer1.Enabled = False
                            Timer2.Enabled = False
                        End If
                    ElseIf dosubcounter = 5 Then 'Continue tutorial
                        tempString = "In order to output our for loop data, we will need to store the data in a variable, tempString is a common variable name that will be used to store our variables. tempString = tempString & count is how we put the data into a variable next, Textbox1.Text = tempString is how to display the data in the variable"
                        Timer5.Enabled = True
                        Timer1.Enabled = True
                        If Timer5.Enabled = False Then
                            Timer1.Enabled = False
                            Timer2.Enabled = False
                        Else 'End tutorial, start activity
                            Me.Hide()
                            Form3.Show()
                            Form3.openform()
                            TextBox1.Clear()
                            TextBox2.Clear()
                        End If
                    End If
                End If
            End If
        ElseIf Form1.complete2 = 1 And Form1.complete3 = 0 Then 'Start tutorial
            If count = 1 Then
                tempString = "New day new lesson! Today we will learn about mathematical functions"
                Timer5.Enabled = True
                Timer1.Enabled = True
                If Timer5.Enabled = False Then
                    Timer1.Enabled = False
                    Timer2.Enabled = False
                End If
            ElseIf count = 2 Then 'Continue tutorial
                tempString = "Some of the basic math functions used in VB programs are listed. +, -, /, * are your basic add, subtract, divide and multiply. Mod is a function that returns only the remainder of a division statement. Math.Sqrt takes the square root of a number. Lastly, brackets allow for the use of bedmas in our expressions and equations"
                TextBox2.Text = "+" & vbCrLf & "-" & vbCrLf & "/" & vbCrLf & "*" & vbCrLf & "Mod" & vbCrLf & "Math.Sqrt"
                Timer5.Enabled = True
                Timer1.Enabled = True
                If Timer5.Enabled = False Then
                    Timer1.Enabled = False
                    Timer2.Enabled = False
                End If
            ElseIf count = 3 Then 'Continue tutorial
                tempString = "These math operators are used to manipulate the values of variables and numbers. Listboxes are objects that can store multiple values of variables in a list format. The syntax needed to add a variable to a listbox is 'Listbox(number).Items.Add(variable being added)'"
                Timer5.Enabled = True
                Timer1.Enabled = True
                If Timer5.Enabled = False Then
                    Timer1.Enabled = False
                    Timer2.Enabled = False
                End If
            Else 'End tutorial, start activity 
                Me.Hide()
                Form3.Show()
                Form3.openform()
                TextBox1.Clear()
                TextBox2.Clear()
            End If
        ElseIf Form1.complete3 = 1 And Form1.complete4 = 0 Then 'Start tutorial
            If count = 1 Then
                tempString = "Your final tutorial will be about If statments. If statments are used to test variables and will perform a function if the test is true"
                Timer5.Enabled = True
                Timer1.Enabled = True
                If Timer5.Enabled = False Then
                    Timer1.Enabled = False
                    Timer2.Enabled = False
                End If
            ElseIf count = 2 Then 'Continue tutorial
                tempString = "The basic syntax of an if statement is shown. If, Then and End If are all required in an if statement. The condition is whatever is being tested, an example being if x = 5. The function(s) being performed are simply what you want the program to do if the condition tests true"
                TextBox2.Text = "If (condition being tested) Then" & vbCrLf & "(function(s) being performed)" & vbCrLf & "End If"
                Timer5.Enabled = True
                Timer1.Enabled = True
                If Timer5.Enabled = False Then
                    Timer1.Enabled = False
                    Timer2.Enabled = False
                End If
            ElseIf count = 3 Then 'Continue tutorial
                tempString = "Lots of if statments are made to test if user input is true. In order for us to get user input, we need to have a variable linked to a textbox. In order to do that we will use the syntax Textbox(number).Text = (variable name)"
                Timer5.Enabled = True
                Timer1.Enabled = True
                If Timer5.Enabled = False Then
                    Timer1.Enabled = False
                    Timer2.Enabled = False
                End If
            Else 'End tutorial, start activity
                Me.Hide()
                Form3.Show()
                Form3.openform()
                TextBox1.Clear()
                TextBox2.Clear()
            End If
        End If
    End Sub

  
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Settings.complete1 = Form1.complete1 'Save progress in settings
        My.Settings.complete2 = Form1.complete2
        My.Settings.complete3 = Form1.complete3
        My.Settings.complete4 = Form1.complete4
    End Sub

End Class

