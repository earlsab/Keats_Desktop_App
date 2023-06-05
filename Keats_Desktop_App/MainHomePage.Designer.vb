<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainHomePage
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IntakeId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddMealButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MealsLoggedTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CaloriesTextBox = New System.Windows.Forms.TextBox()
        Me.ProteinTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CarbsTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FatsTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.MaxFats = New System.Windows.Forms.TextBox()
        Me.MaxCarbs = New System.Windows.Forms.TextBox()
        Me.MaxProtein = New System.Windows.Forms.TextBox()
        Me.MaxCalories = New System.Windows.Forms.TextBox()
        Me.ProfileManager = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Today's Summary"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 155)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 17)
        Me.Label2.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.IntakeId})
        Me.DataGridView1.Location = New System.Drawing.Point(32, 305)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(857, 193)
        Me.DataGridView1.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "Time Recorded"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Food"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 300
        '
        'Column3
        '
        Me.Column3.HeaderText = "Serving Size (g)"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Calories"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'IntakeId
        '
        Me.IntakeId.HeaderText = "IntakeId"
        Me.IntakeId.Name = "IntakeId"
        Me.IntakeId.ReadOnly = True
        Me.IntakeId.Visible = False
        '
        'AddMealButton
        '
        Me.AddMealButton.Location = New System.Drawing.Point(665, 103)
        Me.AddMealButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AddMealButton.Name = "AddMealButton"
        Me.AddMealButton.Size = New System.Drawing.Size(224, 103)
        Me.AddMealButton.TabIndex = 4
        Me.AddMealButton.Text = "Add Meal"
        Me.AddMealButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 276)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Today's Meals"
        '
        'MealsLoggedTextBox
        '
        Me.MealsLoggedTextBox.Enabled = False
        Me.MealsLoggedTextBox.Location = New System.Drawing.Point(195, 76)
        Me.MealsLoggedTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MealsLoggedTextBox.Name = "MealsLoggedTextBox"
        Me.MealsLoggedTextBox.ReadOnly = True
        Me.MealsLoggedTextBox.Size = New System.Drawing.Size(184, 22)
        Me.MealsLoggedTextBox.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "No. of Meals Logged"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(47, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Calories Eaten (KCal)"
        '
        'CaloriesTextBox
        '
        Me.CaloriesTextBox.Enabled = False
        Me.CaloriesTextBox.Location = New System.Drawing.Point(195, 108)
        Me.CaloriesTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CaloriesTextBox.Name = "CaloriesTextBox"
        Me.CaloriesTextBox.ReadOnly = True
        Me.CaloriesTextBox.Size = New System.Drawing.Size(184, 22)
        Me.CaloriesTextBox.TabIndex = 14
        '
        'ProteinTextBox
        '
        Me.ProteinTextBox.Enabled = False
        Me.ProteinTextBox.Location = New System.Drawing.Point(195, 140)
        Me.ProteinTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProteinTextBox.Name = "ProteinTextBox"
        Me.ProteinTextBox.ReadOnly = True
        Me.ProteinTextBox.Size = New System.Drawing.Size(184, 22)
        Me.ProteinTextBox.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(47, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Protein Eaten (g)"
        '
        'CarbsTextBox
        '
        Me.CarbsTextBox.Enabled = False
        Me.CarbsTextBox.Location = New System.Drawing.Point(195, 172)
        Me.CarbsTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CarbsTextBox.Name = "CarbsTextBox"
        Me.CarbsTextBox.ReadOnly = True
        Me.CarbsTextBox.Size = New System.Drawing.Size(184, 22)
        Me.CarbsTextBox.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(47, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Carbs Eaten (g)"
        '
        'FatsTextBox
        '
        Me.FatsTextBox.Enabled = False
        Me.FatsTextBox.Location = New System.Drawing.Point(195, 204)
        Me.FatsTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FatsTextBox.Name = "FatsTextBox"
        Me.FatsTextBox.ReadOnly = True
        Me.FatsTextBox.Size = New System.Drawing.Size(184, 22)
        Me.FatsTextBox.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(47, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 17)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Fats Eaten (g)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(387, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(12, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "/"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(387, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(12, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "/"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(387, 176)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(12, 17)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "/"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(387, 208)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(12, 17)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "/"
        '
        'MaxFats
        '
        Me.MaxFats.Enabled = False
        Me.MaxFats.Location = New System.Drawing.Point(409, 204)
        Me.MaxFats.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaxFats.Name = "MaxFats"
        Me.MaxFats.ReadOnly = True
        Me.MaxFats.Size = New System.Drawing.Size(184, 22)
        Me.MaxFats.TabIndex = 28
        '
        'MaxCarbs
        '
        Me.MaxCarbs.Enabled = False
        Me.MaxCarbs.Location = New System.Drawing.Point(409, 172)
        Me.MaxCarbs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaxCarbs.Name = "MaxCarbs"
        Me.MaxCarbs.ReadOnly = True
        Me.MaxCarbs.Size = New System.Drawing.Size(184, 22)
        Me.MaxCarbs.TabIndex = 27
        '
        'MaxProtein
        '
        Me.MaxProtein.Enabled = False
        Me.MaxProtein.Location = New System.Drawing.Point(409, 140)
        Me.MaxProtein.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaxProtein.Name = "MaxProtein"
        Me.MaxProtein.ReadOnly = True
        Me.MaxProtein.Size = New System.Drawing.Size(184, 22)
        Me.MaxProtein.TabIndex = 26
        '
        'MaxCalories
        '
        Me.MaxCalories.Enabled = False
        Me.MaxCalories.Location = New System.Drawing.Point(409, 108)
        Me.MaxCalories.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaxCalories.Name = "MaxCalories"
        Me.MaxCalories.ReadOnly = True
        Me.MaxCalories.Size = New System.Drawing.Size(184, 22)
        Me.MaxCalories.TabIndex = 25
        '
        'ProfileManager
        '
        Me.ProfileManager.Location = New System.Drawing.Point(783, 53)
        Me.ProfileManager.Margin = New System.Windows.Forms.Padding(4)
        Me.ProfileManager.Name = "ProfileManager"
        Me.ProfileManager.Size = New System.Drawing.Size(106, 42)
        Me.ProfileManager.TabIndex = 29
        Me.ProfileManager.Text = "Profile"
        Me.ProfileManager.UseVisualStyleBackColor = True
        '
        'MainHomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 533)
        Me.Controls.Add(Me.ProfileManager)
        Me.Controls.Add(Me.MaxFats)
        Me.Controls.Add(Me.MaxCarbs)
        Me.Controls.Add(Me.MaxProtein)
        Me.Controls.Add(Me.MaxCalories)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.FatsTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CarbsTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ProteinTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CaloriesTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MealsLoggedTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AddMealButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "MainHomePage"
        Me.Text = "MainHomePage"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents AddMealButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MealsLoggedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IntakeId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaloriesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProteinTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CarbsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents FatsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents MaxFats As System.Windows.Forms.TextBox
    Friend WithEvents MaxCarbs As System.Windows.Forms.TextBox
    Friend WithEvents MaxProtein As System.Windows.Forms.TextBox
    Friend WithEvents MaxCalories As System.Windows.Forms.TextBox
    Friend WithEvents ProfileManager As System.Windows.Forms.Button
End Class
