Public Class Form3
    Dim count2 As Integer 'Declare variables for answers 
    Dim BlankCounter As Integer = 0
    Dim Dim112 As String = "Dim"
    Dim dim212 As String = "dim"
    Dim Integer122 As String = "Integer"
    Dim Single122 As String = "Single"
    Dim outputString As String
    

    Public Sub openform() 'Formatting for when form3 is opened
        TextBox4.Hide()
        Label1.Hide()
        TextBox5.Hide()
        Label2.Hide()
        Label2.BringToFront()
        TextBox3.Clear()
        ListBox1.Hide()
        Label3.Hide()
        If Form1.complete1 = 0 Then
            TextBox1.Text = "This is your activity screen, this is where you will be given a task that relates to the tutorial you just completed. In today's task, you will need to complete the following code by writing in the syntax that allows the code to run" & vbCrLf & vbCrLf & "___ Num As _____ " & vbCrLf & vbCrLf & "Write the first word then click sumbit code, I will then let you know if your answer was right or not, I might even give you a hint! You can move onto the next blank after I have confirmed your answer"
        ElseIf Form1.complete1 = 1 And Form1.complete2 = 0 Then
            If Form2.forclick = 1 Then
                TextBox1.Text = "The box to the right is the output box, we will call it 'Textbox1' when displaying the value of our loops. In your for loop task, you will unscramble the syntax for for the following loop" & vbCrLf & "Integer counter 1 For 30 As Step Integer 2 =  To " & vbCrLf & "counter & = tempString tempString" & vbCrLf & "Next" & vbCrLf & "tempString Text = . Textbox1" & vbCrLf & "Write all four lines of unscrambled code then click the submit code button"
            ElseIf Form2.doclick = 1 Then
                TextBox1.Text = "The box to the right is the output box, we will call it 'Textbox1' when displaying the value of our loops. In your do loop task, you will unscramble the syntax for the following loop" & vbCrLf & "Until 10 Do = count" & vbCrLf & "+ count 1 =" & vbCrLf & "Loop" & vbCrLf & "count Textbox1. = Text" & vbCrLf & "Write all four lines of unscrambled code then click the submit code button"
            End If
        ElseIf Form1.complete2 = 1 And Form1.complete3 = 0 Then
            TextBox1.Text = "For the math operators activity, you will need to fill in the blanks of a program that can calculate the area of a triangle using the variables b and h (representing base and height)" & vbCrLf & "_b_h_ _ 2" & vbCrLf & "Write one blank, click submit, then move onto the next and then repeat two more times"
        ElseIf Form1.complete3 = 1 And Form1.complete4 = 0 Then
            TextBox1.Text = "Your final test will require you to use all of the skills that you have aquired along your journey through my teachings. You will write a program that can factor any number from user input (within the parameters of 1 and 999). There is a testing textbox and a listbox so that you can ensure that your code works. The variable x will be bound to textbox2 (the number being factored). You will need to manually declare 'x'"
            TextBox3.Hide()
            ListBox1.Show()
            Label3.Show()
            Label3.BringToFront()
            TextBox6.Show()
            TextBox6.BringToFront()
            Button5.Show()
            Button5.BringToFront()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide() 'Formatting when the user wants to return to the tutorial
        Label1.Hide()
        TextBox4.Hide()
        Form2.Show()
        Form2.count = 0
        Form2.TextBox2.Clear()
        TextBox2.Clear()
        Form2.Timer5.Enabled = False
        Form2.TextBox1.Clear()
        Form2.forsubcounter = 0
        Form2.dosubcounter = 0
        Form2.forclick = 0
        My.Settings.forclick = 0
        My.Settings.doclick = 0
        Form2.doclick = 0
        Form2.PictureBox2.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Form1.complete1 = 0 Then
            If BlankCounter = 0 Then
                If TextBox2.Text = Dim112 Then 'The next lines of code will test for answers and output a response, there are also formatting changes
                    TextBox4.Show()
                    Label1.Show()
                    TextBox4.Clear()
                    TextBox4.Text = "Great job, move onto the next blank"
                    TextBox1.Text = "This is your activity screen, this is where you will be given a task that relates to the tutorial you just completed. in today's task, you will need to complete the following code by writing in the syntax that allows the code to run" & vbCrLf & vbCrLf & "Dim num as _____ " & vbCrLf & vbCrLf & "Write the first word then click sumbit code, I will then let you know if your answer was right or not, I might even give you a hint! you can move onto the next blank after i have confirmed your answer"
                    BlankCounter = 1
                    TextBox2.Clear()
                ElseIf TextBox2.Text = dim212 Then
                    TextBox4.Show()
                    TextBox4.Clear()
                    TextBox4.Text = "Almost got it, try looking at your syntax again."
                    Label1.Show()
                Else
                    TextBox4.Clear()
                    TextBox4.Show()
                    TextBox4.Text = "Try again, review the tutorial if you need a refresher on the lesson"
                    Label1.Show()
                    TextBox2.Clear()
                End If
            ElseIf BlankCounter = 1 Then
                If TextBox2.Text = Single122 Then
                    BlankCounter = 0
                    TextBox5.Show()
                    Label2.Show()
                    TextBox5.Clear()
                    TextBox5.Text = "Great job, move onto the next tutorial"
                    TextBox1.Text = "This is your activity screen, this is where you will be given a task that relates to the tutorial you just completed. in today's task, you will need to complete the following code by writing in the syntax that allows the code to run" & vbCrLf & vbCrLf & "Dim num as Single" & vbCrLf & vbCrLf & "Write the first word then click sumbit code, I will then let you know if your answer was right or not, I might even give you a hint! you can move onto the next blank after i have confirmed your answer"
                    TextBox2.Clear()
                    Form2.TextBox1.Clear()
                    Form2.TextBox2.Clear()
                    Form1.complete1 = 1
                    My.Settings.complete1 = 1
                    Form2.count = 0
                    Form2.Timer1.Enabled = False
                    Form2.Timer6.Enabled = False
                ElseIf TextBox2.Text = Integer122 Then
                    BlankCounter = 0
                    TextBox5.Show()
                    Label2.Show()
                    TextBox5.Clear()
                    TextBox5.Text = "Great job, move onto the next tutorial"
                    TextBox1.Text = "This is your activity screen, this is where you will be given a task that relates to the tutorial you just completed. in today's task, you will need to complete the following code by writing in the syntax that allows the code to run" & vbCrLf & vbCrLf & "Dim num as Integer" & vbCrLf & vbCrLf & "Write the first word then click sumbit code, I will then let you know if your answer was right or not, I might even give you a hint! you can move onto the next blank after i have confirmed your answer"
                    TextBox2.Clear()
                    Form2.TextBox1.Clear()
                    Form2.TextBox2.Clear()
                    Form1.complete1 = 1
                    My.Settings.complete1 = 1
                    Form2.count = 0
                    Form2.Timer1.Enabled = False
                    Form2.Timer6.Enabled = False
                ElseIf TextBox2.Text = "single" Then
                    TextBox4.Show()
                    TextBox4.Text = "Almost got it, try looking at your syntax again."
                    Label1.Show()
                ElseIf TextBox2.Text = "integer" Then
                    TextBox4.Show()
                    TextBox4.Text = "Almost got it, try looking at your syntax again."
                    Label1.Show()
                ElseIf TextBox2.Text = "String" Then
                    TextBox4.Show()
                    TextBox4.Clear()
                    TextBox4.Text = "Lets try to make our variable type relate to the variable name"
                    Label1.Show()
                ElseIf TextBox2.Text = "string" Then
                    TextBox4.Show()
                    TextBox4.Clear()
                    TextBox4.Text = "Lets try to make our variable type relate to the variable name"
                    Label1.Show()
                Else
                    TextBox4.Show()
                    TextBox4.Clear()
                    TextBox4.Text = "Try again, review the tutorial if you need a refresher on the lesson"
                    Label1.Show()
                    TextBox2.Clear()
                End If
            End If
        ElseIf Form1.complete1 = 1 And Form1.complete2 = 0 Then
            If Form2.forclick = 1 Then
                If TextBox2.Text = "For counter As Integer = 1 to 30 Step 2" & vbCrLf & "tempString = tempString & counter" & vbCrLf & "Next" & vbCrLf & "Textbox1.Text = tempString" Then
                    TextBox5.Show()
                    Label1.Show()
                    TextBox5.Clear()
                    TextBox5.Text = "Great job, move onto the next tutorial"
                    TextBox2.Clear()
                    Form2.TextBox1.Clear()
                    Form1.complete2 = 1
                    Form2.count = 0
                    Form2.Timer1.Enabled = False
                    Form2.Timer6.Enabled = False
                    For counter As Integer = 1 To 30 Step 2
                        outputString = outputString & counter
                    Next
                    TextBox3.Text = outputString
                Else
                    TextBox4.Clear()
                    TextBox4.Show()
                    TextBox4.Text = "Try again, review the tutorial if you need a refresher on the lesson"
                    Label2.Show()
                    TextBox2.Clear()
                End If
            ElseIf Form2.doclick = 1 Then
                If TextBox2.Text = "Do Until count = 10" & vbCrLf & "count += 1" & vbCrLf & "Loop" & vbCrLf & "Textbox1.Text = count" Then
                    TextBox5.Show()
                    Label1.Show()
                    TextBox5.Clear()
                    TextBox5.Text = "Great job, move onto the next tutorial"
                    TextBox2.Clear()
                    Form2.TextBox1.Clear()
                    Form1.complete2 = 1
                    Form2.count = 0
                    Form2.Timer1.Enabled = False
                    Form2.Timer6.Enabled = False
                    TextBox3.Clear()
                    TextBox3.Text = "12345678910"
                Else
                    TextBox4.Clear()
                    TextBox4.Show()
                    TextBox4.Text = "Try again, review the tutorial if you need a refresher on the lesson"
                    Label2.Show()
                    TextBox2.Clear()
                End If
            End If
        ElseIf Form1.complete2 = 1 And Form1.complete3 = 0 Then
            If BlankCounter = 0 Then
                If TextBox2.Text = "(" Then
                    TextBox4.Show()
                    Label1.Show()
                    TextBox4.Clear()
                    TextBox4.Text = "Great job, move onto the next blank"
                    TextBox1.Text = "For the math operators activity, you will need to fill in the blanks of a program that can calculate the area of a triangle using the variables b and h (representing base and height)" & vbCrLf & "(b_h_ _ 2" & vbCrLf & "Write one blank, click submit, then move onto the next and then repeat once again"
                    BlankCounter = 1
                    TextBox2.Clear()
                Else
                    TextBox4.Clear()
                    TextBox4.Show()
                    TextBox4.Text = "Try again, review the tutorial if you need a refresher on the lesson"
                    Label1.Show()
                    TextBox2.Clear()
                End If
            ElseIf BlankCounter = 1 Then
                If TextBox2.Text = "*" Then
                    TextBox4.Show()
                    Label1.Show()
                    TextBox4.Clear()
                    TextBox4.Text = "Great job, move onto the next blank"
                    TextBox1.Text = "For the math operators activity, you will need to fill in the blanks of a program that can calculate the area of a triangle using the variables b and h (representing base and height)" & vbCrLf & "(b*h_ _ 2" & vbCrLf & "Write one blank, click submit, then move onto the next and then repeat once again"
                    BlankCounter = 2
                    TextBox2.Clear()
                Else
                    TextBox4.Clear()
                    TextBox4.Show()
                    TextBox4.Text = "Try again, review the tutorial if you need a refresher on the lesson"
                    Label1.Show()
                    TextBox2.Clear()
                End If
            ElseIf BlankCounter = 2 Then
                If TextBox2.Text = ")" Then
                    TextBox4.Show()
                    Label1.Show()
                    TextBox4.Clear()
                    TextBox4.Text = "Great job, move onto the next blank"
                    TextBox1.Text = "For the math operators activity, you will need to fill in the blanks of a program that can calculate the area of a triangle using the variables b and h (representing base and height)" & vbCrLf & "(b*h) _ 2" & vbCrLf & "Write one blank, click submit, then move onto the next and then repeat once again"
                    BlankCounter = 3
                    TextBox2.Clear()
                Else
                    TextBox4.Clear()
                    TextBox4.Show()
                    TextBox4.Text = "Try again, review the tutorial if you need a refresher on the lesson"
                    Label1.Show()
                    TextBox2.Clear()
                End If
            ElseIf BlankCounter = 3 Then
                If TextBox2.Text = "/" Then
                    TextBox1.Text = "For the math operators activity, you will need to fill in the blanks of a program that can calculate the area of a triangle using the variables b and h (representing base and height)" & vbCrLf & "(b*h) / 2" & vbCrLf & "Write one blank, click submit, then move onto the next and then repeat once again"
                    TextBox5.Show()
                    Label1.Show()
                    TextBox5.Clear()
                    TextBox5.Text = "Great job, move onto the next tutorial"
                    TextBox2.Clear()
                    Form2.TextBox1.Clear()
                    Form1.complete3 = 1
                    Form2.count = 0
                    Form2.Timer1.Enabled = False
                    Form2.Timer6.Enabled = False
                Else
                    TextBox4.Clear()
                    TextBox4.Show()
                    TextBox4.Text = "Try again, review the tutorial if you need a refresher on the lesson"
                    Label1.Show()
                    TextBox2.Clear()
                End If
            End If
        ElseIf Form1.complete3 = 1 And Form1.complete4 = 0 Then
            ListBox1.Show()
            Label3.Hide()
            If TextBox2.Text = "Dim x As Integer" & vbCrLf & "Textbox2.Text = x" & vbCrLf & "For y As Integer = 1 to 999" & vbCrLf & "If x mod y = 0 Then" & vbCrLf & "ListBox1.Items.Add(y)" & vbCrLf & "End If" & vbCrLf & "Next" Then
                TextBox5.Show()
                Label1.Show()
                TextBox5.Clear()
                TextBox5.Text = "Thanks for playing VB Teacher 2.0"
                TextBox2.Clear()
                Form2.TextBox1.Clear()
                Form1.complete4 = 1
                Form2.count = 0
                Form2.Timer1.Enabled = False
                Form2.Timer6.Enabled = False
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label1.Text.Equals("") = False Then 'Makes 'click to continue' blink
            Label1.Text = ""
        ElseIf Label1.Text.Equals("") = True Then
            Label1.Text = "Click to Continue"
        End If
        If Label2.Text.Equals("") = False Then
            Label2.Text = ""
        ElseIf Label2.Text.Equals("") = True Then
            Label2.Text = "Click to Continue"
        End If
    End Sub


    Private Sub TextBox4_Click(sender As Object, e As EventArgs) Handles TextBox4.Click
        TextBox4.Hide() 'Formatting after an answer has been submitted
        Label1.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        TextBox4.Hide() 'Formatting after an answer has been submitted
        Label1.Hide()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Settings.complete1 = Form1.complete1 'Save pregress in settings 
        My.Settings.complete2 = Form1.complete2
        My.Settings.complete3 = Form1.complete3
        My.Settings.complete4 = Form1.complete4
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide() 'Return to home screen
        Form1.Show()
        TextBox4.Hide()
        Label1.Hide()
    End Sub

    Private Sub TextBox5_Click(sender As Object, e As EventArgs) Handles TextBox5.Click
        If Form1.complete1 = 1 Then 'Formatting when an activity is completed
            Me.Hide()
            Form2.Show()
        ElseIf Form1.complete1 = 1 And Form2.forclick = 1 Or Form2.doclick = 1 Then
            TextBox5.Hide()
            Label2.Hide()
        ElseIf Form1.complete2 = 1 Then
            Me.Hide()
            Form2.Show()
        ElseIf Form1.complete4 = 1 Then
            Me.Hide()
            Form1.Show()
        End If
    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        TextBox4.Hide() 'Formatting when an activity is completed
        Label1.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox2.Text = "Dim x As Integer" & vbCrLf & "Textbox2.Text = x" & vbCrLf & "For y As Integer = 1 to 999" & vbCrLf & "If x mod y = 0 Then" & vbCrLf & "ListBox1.Items.Add(y)" & vbCrLf & "End If" & vbCrLf & "Next" Then 'Test your answers on the final tutorial
            Dim x As Integer = TextBox6.Text
            For y As Integer = 1 To 999
                If x Mod y = 0 Then
                    ListBox1.Items.Add(y)
                End If
            Next
        Else
            ListBox1.Items.Clear()
            ListBox1.Items.Add("Incorrect Code")
        End If
    End Sub
End Class