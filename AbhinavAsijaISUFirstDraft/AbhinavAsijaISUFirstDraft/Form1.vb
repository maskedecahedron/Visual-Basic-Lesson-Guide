Public Class Form1
    Public complete1 As Integer = 0 'Declaring variables for tutorial completion
    Public complete2 As Integer = 0
    Public complete3 As Integer = 0
    Public complete4 As Integer = 0
    Public ForLoop As Integer = 0
    Public DoLoop As Integer = 0
    Public WhileLoop As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button6.Hide() 'The following code is used for formatting
        Form2.Hide()
        Form3.Hide()
        My.Computer.Audio.Play("E:\Technology\Grade 10\Computer Science\Culminating ISU\AbhinavAsijaISUFirstDraft\AbhinavAsijaISUFirstDraft\Music.wav", AudioPlayMode.BackgroundLoop)
        Form3.ListBox1.Hide()
        Form3.Label3.Hide()
        Form3.TextBox6.Hide()
        Form3.Button5.Hide()
        Variables.Hide()
        ForLoops.Hide()
        DoLoops.Hide()
        Operators.Hide()
        IfStatments.Hide()
        TextBox1.Hide()
        Button6.Hide()
    End Sub

    Private Sub Instruction_Click(sender As Object, e As EventArgs) Handles Instruction.Click
        Button6.Show() 'Formatting and display instructions
        NewGame.Hide()
        ContinueGame.Hide()
        TutSelector.Hide()
        Instruction.Hide()
        Button6.Show()
        Label1.Text = "Instructions"
        TextBox1.Show()
        TextBox1.Text = "The object of the game is to learn the basics of coding in VB. The online teacher will guide you through barious tutorials to allow you to succeed in the program. After each lesson, you will be given an activity to prove that you have learned the tutorial. The activities include unscrambling code and filing in missing values within the code"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Hide() 'Formatting
        Button6.Hide()
        NewGame.Show()
        ContinueGame.Show()
        TutSelector.Show()
        Instruction.Show()
        Label1.Text = "Let's Learn Visual Basic"
    End Sub

    Private Sub NewGame_Click(sender As Object, e As EventArgs) Handles NewGame.Click
        Me.Hide() 'Start game from scratch
        Form2.Show()
        Form2.count = 0
        Form2.TextBox2.Clear()
        Form2.TextBox1.Clear()
        complete1 = 0
        complete2 = 0
        complete3 = 0
        complete4 = 0
    End Sub

    Private Sub ContinueGame_Click(sender As Object, e As EventArgs) Handles ContinueGame.Click
        Form2.TextBox1.Clear() 'Continue save game from stored variables
        Form2.TextBox2.Clear()
        complete1 = My.Settings.complete1
        complete2 = My.Settings.complete2
        complete3 = My.Settings.complete3
        complete4 = My.Settings.complete4
        Form2.forclick = My.Settings.forclick
        Form2.doclick = My.Settings.doclick
        Me.Hide()
        Form2.Show()
        Form2.count = 0
        Form2.forsubcounter = 0
        Form2.dosubcounter = 0
        Form2.TextBox1.Clear()
        Form2.tempString = "   "
        Form2.DoLoop.Hide()
        Form2.ForLoop.Hide()
    End Sub

    Private Sub TutSelector_Click(sender As Object, e As EventArgs) Handles TutSelector.Click
        Label1.Hide() 'Choose what tutorial you want to start on (only works if you have a save game"
        NewGame.Hide()
        ContinueGame.Hide()
        TutSelector.Hide()
        Instruction.Hide()
        Variables.Show()

    End Sub

    Private Sub Variables_Click(sender As Object, e As EventArgs)
        If complete1 = 1 And complete2 = 0 Then 'Start selected tutorial
            Form2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub ForLoops_Click(sender As Object, e As EventArgs) Handles ForLoops.Click
        If complete1 = 1 And Form2.forclick = 1 And complete2 = 0 Then 'Start selected tutorial
            Form2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub DoLoops_Click(sender As Object, e As EventArgs) Handles DoLoops.Click
        If complete1 = 1 And Form2.doclick = 1 And complete2 = 0 Then 'Start selected tutorial
            Form2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Operators_Click(sender As Object, e As EventArgs) Handles Operators.Click
        If complete2 = 1 And complete3 = 0 Then 'Start selected tutorial
            Form2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub IfStatments_Click(sender As Object, e As EventArgs) Handles IfStatments.Click
        If complete3 = 1 Then 'Start selected tutorial
            Form2.Show()
            Me.Hide()
        End If
    End Sub
End Class
