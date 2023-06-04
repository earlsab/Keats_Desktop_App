<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewUserRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewUserRegistration))
        Me.Username = New System.Windows.Forms.TextBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.ConfirmPasswordLabel = New System.Windows.Forms.Label()
        Me.ConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Back = New System.Windows.Forms.Button()
        Me.Register = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Username
        '
        Me.Username.Location = New System.Drawing.Point(176, 47)
        Me.Username.Margin = New System.Windows.Forms.Padding(4)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(312, 22)
        Me.Username.TabIndex = 0
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Location = New System.Drawing.Point(100, 50)
        Me.UsernameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(77, 17)
        Me.UsernameLabel.TabIndex = 1
        Me.UsernameLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(100, 110)
        Me.PasswordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(73, 17)
        Me.PasswordLabel.TabIndex = 3
        Me.PasswordLabel.Text = "Password:"
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(176, 106)
        Me.Password.Margin = New System.Windows.Forms.Padding(4)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(312, 22)
        Me.Password.TabIndex = 2
        '
        'ConfirmPasswordLabel
        '
        Me.ConfirmPasswordLabel.AutoSize = True
        Me.ConfirmPasswordLabel.Location = New System.Drawing.Point(43, 146)
        Me.ConfirmPasswordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel"
        Me.ConfirmPasswordLabel.Size = New System.Drawing.Size(125, 17)
        Me.ConfirmPasswordLabel.TabIndex = 5
        Me.ConfirmPasswordLabel.Text = "Confirm Password:"
        '
        'ConfirmPassword
        '
        Me.ConfirmPassword.Location = New System.Drawing.Point(176, 138)
        Me.ConfirmPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.ConfirmPassword.Name = "ConfirmPassword"
        Me.ConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmPassword.Size = New System.Drawing.Size(312, 22)
        Me.ConfirmPassword.TabIndex = 4
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(280, 199)
        Me.Back.Margin = New System.Windows.Forms.Padding(4)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(100, 28)
        Me.Back.TabIndex = 6
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Register
        '
        Me.Register.Location = New System.Drawing.Point(389, 199)
        Me.Register.Margin = New System.Windows.Forms.Padding(4)
        Me.Register.Name = "Register"
        Me.Register.Size = New System.Drawing.Size(100, 28)
        Me.Register.TabIndex = 7
        Me.Register.Text = "Register"
        Me.Register.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Registration"
        '
        'NewUserRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 260)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Register)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.ConfirmPasswordLabel)
        Me.Controls.Add(Me.ConfirmPassword)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.Username)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "NewUserRegistration"
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Username As System.Windows.Forms.TextBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents ConfirmPasswordLabel As System.Windows.Forms.Label
    Friend WithEvents ConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents Register As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
