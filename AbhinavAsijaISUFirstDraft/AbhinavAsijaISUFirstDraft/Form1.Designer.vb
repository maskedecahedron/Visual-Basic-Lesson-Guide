<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NewGame = New System.Windows.Forms.Button()
        Me.ContinueGame = New System.Windows.Forms.Button()
        Me.TutSelector = New System.Windows.Forms.Button()
        Me.Instruction = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Variables = New System.Windows.Forms.Button()
        Me.ForLoops = New System.Windows.Forms.Button()
        Me.DoLoops = New System.Windows.Forms.Button()
        Me.Operators = New System.Windows.Forms.Button()
        Me.IfStatments = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.25!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(337, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 39)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "VB Teacher 2.0"
        '
        'NewGame
        '
        Me.NewGame.Location = New System.Drawing.Point(449, 106)
        Me.NewGame.Name = "NewGame"
        Me.NewGame.Size = New System.Drawing.Size(75, 23)
        Me.NewGame.TabIndex = 9
        Me.NewGame.Text = "New Game"
        Me.NewGame.UseVisualStyleBackColor = True
        '
        'ContinueGame
        '
        Me.ContinueGame.Location = New System.Drawing.Point(449, 152)
        Me.ContinueGame.Name = "ContinueGame"
        Me.ContinueGame.Size = New System.Drawing.Size(75, 23)
        Me.ContinueGame.TabIndex = 10
        Me.ContinueGame.Text = "Continue"
        Me.ContinueGame.UseVisualStyleBackColor = True
        '
        'TutSelector
        '
        Me.TutSelector.Location = New System.Drawing.Point(433, 200)
        Me.TutSelector.Name = "TutSelector"
        Me.TutSelector.Size = New System.Drawing.Size(104, 23)
        Me.TutSelector.TabIndex = 11
        Me.TutSelector.Text = "Tutorial Selector"
        Me.TutSelector.UseVisualStyleBackColor = True
        '
        'Instruction
        '
        Me.Instruction.Location = New System.Drawing.Point(449, 246)
        Me.Instruction.Name = "Instruction"
        Me.Instruction.Size = New System.Drawing.Size(75, 23)
        Me.Instruction.TabIndex = 12
        Me.Instruction.Text = "Instructions"
        Me.Instruction.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(396, 423)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 14
        Me.Button6.Text = "Home"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(343, 100)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(247, 295)
        Me.TextBox1.TabIndex = 16
        '
        'Variables
        '
        Me.Variables.Location = New System.Drawing.Point(123, 226)
        Me.Variables.Name = "Variables"
        Me.Variables.Size = New System.Drawing.Size(75, 23)
        Me.Variables.TabIndex = 17
        Me.Variables.Text = "Variables"
        Me.Variables.UseVisualStyleBackColor = True
        '
        'ForLoops
        '
        Me.ForLoops.Location = New System.Drawing.Point(286, 168)
        Me.ForLoops.Name = "ForLoops"
        Me.ForLoops.Size = New System.Drawing.Size(75, 23)
        Me.ForLoops.TabIndex = 18
        Me.ForLoops.Text = "For Loops"
        Me.ForLoops.UseVisualStyleBackColor = True
        '
        'DoLoops
        '
        Me.DoLoops.Location = New System.Drawing.Point(286, 274)
        Me.DoLoops.Name = "DoLoops"
        Me.DoLoops.Size = New System.Drawing.Size(75, 23)
        Me.DoLoops.TabIndex = 19
        Me.DoLoops.Text = "Do Loops"
        Me.DoLoops.UseVisualStyleBackColor = True
        '
        'Operators
        '
        Me.Operators.Location = New System.Drawing.Point(449, 226)
        Me.Operators.Name = "Operators"
        Me.Operators.Size = New System.Drawing.Size(88, 23)
        Me.Operators.TabIndex = 20
        Me.Operators.Text = "Math Operators"
        Me.Operators.UseVisualStyleBackColor = True
        '
        'IfStatments
        '
        Me.IfStatments.Location = New System.Drawing.Point(621, 226)
        Me.IfStatments.Name = "IfStatments"
        Me.IfStatments.Size = New System.Drawing.Size(75, 23)
        Me.IfStatments.TabIndex = 21
        Me.IfStatments.Text = "If Statments"
        Me.IfStatments.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(912, 503)
        Me.Controls.Add(Me.IfStatments)
        Me.Controls.Add(Me.Operators)
        Me.Controls.Add(Me.DoLoops)
        Me.Controls.Add(Me.ForLoops)
        Me.Controls.Add(Me.Variables)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Instruction)
        Me.Controls.Add(Me.TutSelector)
        Me.Controls.Add(Me.ContinueGame)
        Me.Controls.Add(Me.NewGame)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NewGame As System.Windows.Forms.Button
    Friend WithEvents ContinueGame As System.Windows.Forms.Button
    Friend WithEvents TutSelector As System.Windows.Forms.Button
    Friend WithEvents Instruction As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Variables As System.Windows.Forms.Button
    Friend WithEvents ForLoops As System.Windows.Forms.Button
    Friend WithEvents DoLoops As System.Windows.Forms.Button
    Friend WithEvents Operators As System.Windows.Forms.Button
    Friend WithEvents IfStatments As System.Windows.Forms.Button

End Class
