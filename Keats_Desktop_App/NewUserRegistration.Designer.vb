﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Username = New System.Windows.Forms.TextBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.ConfirmPasswordLabel = New System.Windows.Forms.Label()
        Me.ConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Back = New System.Windows.Forms.Button()
        Me.Register = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Username
        '
        Me.Username.Location = New System.Drawing.Point(132, 38)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(235, 20)
        Me.Username.TabIndex = 0
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Location = New System.Drawing.Point(75, 41)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(58, 13)
        Me.UsernameLabel.TabIndex = 1
        Me.UsernameLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(75, 89)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(56, 13)
        Me.PasswordLabel.TabIndex = 3
        Me.PasswordLabel.Text = "Password:"
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(132, 86)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(235, 20)
        Me.Password.TabIndex = 2
        '
        'ConfirmPasswordLabel
        '
        Me.ConfirmPasswordLabel.AutoSize = True
        Me.ConfirmPasswordLabel.Location = New System.Drawing.Point(32, 119)
        Me.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel"
        Me.ConfirmPasswordLabel.Size = New System.Drawing.Size(94, 13)
        Me.ConfirmPasswordLabel.TabIndex = 5
        Me.ConfirmPasswordLabel.Text = "Confirm Password:"
        '
        'ConfirmPassword
        '
        Me.ConfirmPassword.Location = New System.Drawing.Point(132, 112)
        Me.ConfirmPassword.Name = "ConfirmPassword"
        Me.ConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmPassword.Size = New System.Drawing.Size(235, 20)
        Me.ConfirmPassword.TabIndex = 4
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(210, 162)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(75, 23)
        Me.Back.TabIndex = 6
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Register
        '
        Me.Register.Location = New System.Drawing.Point(292, 162)
        Me.Register.Name = "Register"
        Me.Register.Size = New System.Drawing.Size(75, 23)
        Me.Register.TabIndex = 7
        Me.Register.Text = "Register"
        Me.Register.UseVisualStyleBackColor = True
        '
        'NewUserRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 211)
        Me.Controls.Add(Me.Register)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.ConfirmPasswordLabel)
        Me.Controls.Add(Me.ConfirmPassword)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.Username)
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

End Class