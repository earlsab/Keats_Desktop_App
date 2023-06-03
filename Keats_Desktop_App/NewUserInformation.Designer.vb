<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewUserInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewUserInformation))
        Me.Back = New System.Windows.Forms.Button()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.ConfirmRegistration = New System.Windows.Forms.Button()
        Me.TextBoxPassw = New System.Windows.Forms.TextBox()
        Me.TextBoxPh = New System.Windows.Forms.TextBox()
        Me.TextBoxW = New System.Windows.Forms.TextBox()
        Me.TextBoxH = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxEm = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBoxAL = New System.Windows.Forms.ComboBox()
        Me.ComboBoxDP = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(258, 382)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(90, 25)
        Me.Back.TabIndex = 1
        Me.Back.Text = "Cancel"
        Me.Back.UseVisualStyleBackColor = True
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxUsername.Location = New System.Drawing.Point(98, 51)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(181, 22)
        Me.TextBoxUsername.TabIndex = 2
        '
        'ConfirmRegistration
        '
        Me.ConfirmRegistration.Location = New System.Drawing.Point(353, 382)
        Me.ConfirmRegistration.Name = "ConfirmRegistration"
        Me.ConfirmRegistration.Size = New System.Drawing.Size(154, 25)
        Me.ConfirmRegistration.TabIndex = 3
        Me.ConfirmRegistration.Text = "Confirm details"
        Me.ConfirmRegistration.UseVisualStyleBackColor = True
        '
        'TextBoxPassw
        '
        Me.TextBoxPassw.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxPassw.Location = New System.Drawing.Point(98, 79)
        Me.TextBoxPassw.Name = "TextBoxPassw"
        Me.TextBoxPassw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassw.Size = New System.Drawing.Size(181, 22)
        Me.TextBoxPassw.TabIndex = 4
        '
        'TextBoxPh
        '
        Me.TextBoxPh.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxPh.Location = New System.Drawing.Point(98, 169)
        Me.TextBoxPh.Name = "TextBoxPh"
        Me.TextBoxPh.Size = New System.Drawing.Size(249, 22)
        Me.TextBoxPh.TabIndex = 5
        '
        'TextBoxW
        '
        Me.TextBoxW.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxW.Location = New System.Drawing.Point(98, 258)
        Me.TextBoxW.Name = "TextBoxW"
        Me.TextBoxW.Size = New System.Drawing.Size(249, 22)
        Me.TextBoxW.TabIndex = 6
        '
        'TextBoxH
        '
        Me.TextBoxH.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxH.Location = New System.Drawing.Point(98, 286)
        Me.TextBoxH.Name = "TextBoxH"
        Me.TextBoxH.Size = New System.Drawing.Size(249, 22)
        Me.TextBoxH.TabIndex = 7
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(98, 141)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(249, 22)
        Me.DateTimePicker1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Username"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Weight"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Height"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(2, 317)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Activity Level"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Phone No."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Date of birth"
        '
        'TextBoxEm
        '
        Me.TextBoxEm.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxEm.Location = New System.Drawing.Point(98, 197)
        Me.TextBoxEm.Name = "TextBoxEm"
        Me.TextBoxEm.Size = New System.Drawing.Size(249, 22)
        Me.TextBoxEm.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(50, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 17)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Email"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(12, 9)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(335, 17)
        Me.Label.TabIndex = 0
        Me.Label.Text = "We just need to know a little more about you!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Keats_Desktop_App.My.Resources.Resources.cloyd
        Me.PictureBox1.Location = New System.Drawing.Point(362, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 140)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 345)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Diet Plan"
        '
        'ComboBoxAL
        '
        Me.ComboBoxAL.FormattingEnabled = True
        Me.ComboBoxAL.Location = New System.Drawing.Point(98, 314)
        Me.ComboBoxAL.Name = "ComboBoxAL"
        Me.ComboBoxAL.Size = New System.Drawing.Size(249, 24)
        Me.ComboBoxAL.TabIndex = 24
        '
        'ComboBoxDP
        '
        Me.ComboBoxDP.FormattingEnabled = True
        Me.ComboBoxDP.Location = New System.Drawing.Point(98, 344)
        Me.ComboBoxDP.Name = "ComboBoxDP"
        Me.ComboBoxDP.Size = New System.Drawing.Size(249, 24)
        Me.ComboBoxDP.TabIndex = 25
        '
        'NewUserInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 416)
        Me.Controls.Add(Me.ComboBoxDP)
        Me.Controls.Add(Me.ComboBoxAL)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBoxEm)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBoxH)
        Me.Controls.Add(Me.TextBoxW)
        Me.Controls.Add(Me.TextBoxPh)
        Me.Controls.Add(Me.TextBoxPassw)
        Me.Controls.Add(Me.ConfirmRegistration)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Label)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewUserInformation"
        Me.Text = "Register"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents TextBoxUsername As System.Windows.Forms.TextBox
    Friend WithEvents ConfirmRegistration As System.Windows.Forms.Button
    Friend WithEvents TextBoxPassw As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPh As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxW As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxH As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxEm As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxAL As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxDP As System.Windows.Forms.ComboBox
End Class
