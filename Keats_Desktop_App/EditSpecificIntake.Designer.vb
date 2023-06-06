<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditSpecificIntake
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditSpecificIntake))
        Me.Back = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.Amount = New System.Windows.Forms.Label()
        Me.AmountValue = New System.Windows.Forms.TextBox()
        Me.FatsValue = New System.Windows.Forms.Label()
        Me.FatsLabel = New System.Windows.Forms.Label()
        Me.CarbsValue = New System.Windows.Forms.Label()
        Me.CarbsLabel = New System.Windows.Forms.Label()
        Me.ProteinValue = New System.Windows.Forms.Label()
        Me.ProteinLabel = New System.Windows.Forms.Label()
        Me.CaloriesValue = New System.Windows.Forms.Label()
        Me.CaloriesLabel = New System.Windows.Forms.Label()
        Me.SelectedIngredient = New System.Windows.Forms.Label()
        Me.SelectedSubvariantValue = New System.Windows.Forms.Label()
        Me.SelectedSubvariant = New System.Windows.Forms.Label()
        Me.SelectedVariant = New System.Windows.Forms.Label()
        Me.SelectedIngredientValue = New System.Windows.Forms.Label()
        Me.SelectedVariantValue = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(11, 20)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(75, 23)
        Me.Back.TabIndex = 0
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(295, 283)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(118, 39)
        Me.Delete.TabIndex = 44
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(295, 238)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(118, 39)
        Me.Save.TabIndex = 43
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Amount
        '
        Me.Amount.AutoSize = True
        Me.Amount.Location = New System.Drawing.Point(230, 25)
        Me.Amount.Name = "Amount"
        Me.Amount.Size = New System.Drawing.Size(61, 13)
        Me.Amount.TabIndex = 42
        Me.Amount.Text = "Amount (g):"
        '
        'AmountValue
        '
        Me.AmountValue.Location = New System.Drawing.Point(297, 22)
        Me.AmountValue.Name = "AmountValue"
        Me.AmountValue.Size = New System.Drawing.Size(112, 20)
        Me.AmountValue.TabIndex = 41
        '
        'FatsValue
        '
        Me.FatsValue.AutoSize = True
        Me.FatsValue.Location = New System.Drawing.Point(64, 283)
        Me.FatsValue.Name = "FatsValue"
        Me.FatsValue.Size = New System.Drawing.Size(10, 13)
        Me.FatsValue.TabIndex = 40
        Me.FatsValue.Text = "."
        '
        'FatsLabel
        '
        Me.FatsLabel.AutoSize = True
        Me.FatsLabel.Location = New System.Drawing.Point(13, 283)
        Me.FatsLabel.Name = "FatsLabel"
        Me.FatsLabel.Size = New System.Drawing.Size(45, 13)
        Me.FatsLabel.TabIndex = 39
        Me.FatsLabel.Text = "Fats (g):"
        '
        'CarbsValue
        '
        Me.CarbsValue.AutoSize = True
        Me.CarbsValue.Location = New System.Drawing.Point(71, 255)
        Me.CarbsValue.Name = "CarbsValue"
        Me.CarbsValue.Size = New System.Drawing.Size(10, 13)
        Me.CarbsValue.TabIndex = 38
        Me.CarbsValue.Text = "."
        '
        'CarbsLabel
        '
        Me.CarbsLabel.AutoSize = True
        Me.CarbsLabel.Location = New System.Drawing.Point(13, 255)
        Me.CarbsLabel.Name = "CarbsLabel"
        Me.CarbsLabel.Size = New System.Drawing.Size(52, 13)
        Me.CarbsLabel.TabIndex = 37
        Me.CarbsLabel.Text = "Carbs (g):"
        '
        'ProteinValue
        '
        Me.ProteinValue.AutoSize = True
        Me.ProteinValue.Location = New System.Drawing.Point(77, 229)
        Me.ProteinValue.Name = "ProteinValue"
        Me.ProteinValue.Size = New System.Drawing.Size(10, 13)
        Me.ProteinValue.TabIndex = 36
        Me.ProteinValue.Text = "."
        '
        'ProteinLabel
        '
        Me.ProteinLabel.AutoSize = True
        Me.ProteinLabel.Location = New System.Drawing.Point(13, 229)
        Me.ProteinLabel.Name = "ProteinLabel"
        Me.ProteinLabel.Size = New System.Drawing.Size(58, 13)
        Me.ProteinLabel.TabIndex = 35
        Me.ProteinLabel.Text = "Protein (g):"
        '
        'CaloriesValue
        '
        Me.CaloriesValue.AutoSize = True
        Me.CaloriesValue.Location = New System.Drawing.Point(97, 202)
        Me.CaloriesValue.Name = "CaloriesValue"
        Me.CaloriesValue.Size = New System.Drawing.Size(10, 13)
        Me.CaloriesValue.TabIndex = 34
        Me.CaloriesValue.Text = "."
        '
        'CaloriesLabel
        '
        Me.CaloriesLabel.AutoSize = True
        Me.CaloriesLabel.Location = New System.Drawing.Point(13, 202)
        Me.CaloriesLabel.Name = "CaloriesLabel"
        Me.CaloriesLabel.Size = New System.Drawing.Size(78, 13)
        Me.CaloriesLabel.TabIndex = 33
        Me.CaloriesLabel.Text = "Calories (KCal):"
        '
        'SelectedIngredient
        '
        Me.SelectedIngredient.AutoSize = True
        Me.SelectedIngredient.Location = New System.Drawing.Point(13, 92)
        Me.SelectedIngredient.Name = "SelectedIngredient"
        Me.SelectedIngredient.Size = New System.Drawing.Size(102, 13)
        Me.SelectedIngredient.TabIndex = 31
        Me.SelectedIngredient.Text = "Selected Ingredient:"
        '
        'SelectedSubvariantValue
        '
        Me.SelectedSubvariantValue.AutoSize = True
        Me.SelectedSubvariantValue.Location = New System.Drawing.Point(166, 146)
        Me.SelectedSubvariantValue.Name = "SelectedSubvariantValue"
        Me.SelectedSubvariantValue.Size = New System.Drawing.Size(10, 13)
        Me.SelectedSubvariantValue.TabIndex = 29
        Me.SelectedSubvariantValue.Text = "."
        '
        'SelectedSubvariant
        '
        Me.SelectedSubvariant.AutoSize = True
        Me.SelectedSubvariant.Location = New System.Drawing.Point(12, 146)
        Me.SelectedSubvariant.Name = "SelectedSubvariant"
        Me.SelectedSubvariant.Size = New System.Drawing.Size(148, 13)
        Me.SelectedSubvariant.TabIndex = 28
        Me.SelectedSubvariant.Text = "Selected Preparation Method:"
        '
        'SelectedVariant
        '
        Me.SelectedVariant.AutoSize = True
        Me.SelectedVariant.Location = New System.Drawing.Point(12, 118)
        Me.SelectedVariant.Name = "SelectedVariant"
        Me.SelectedVariant.Size = New System.Drawing.Size(103, 13)
        Me.SelectedVariant.TabIndex = 27
        Me.SelectedVariant.Text = "Selected Part/Type:"
        '
        'SelectedIngredientValue
        '
        Me.SelectedIngredientValue.AutoSize = True
        Me.SelectedIngredientValue.Location = New System.Drawing.Point(121, 92)
        Me.SelectedIngredientValue.Name = "SelectedIngredientValue"
        Me.SelectedIngredientValue.Size = New System.Drawing.Size(10, 13)
        Me.SelectedIngredientValue.TabIndex = 32
        Me.SelectedIngredientValue.Text = "."
        '
        'SelectedVariantValue
        '
        Me.SelectedVariantValue.AutoSize = True
        Me.SelectedVariantValue.Location = New System.Drawing.Point(121, 118)
        Me.SelectedVariantValue.Name = "SelectedVariantValue"
        Me.SelectedVariantValue.Size = New System.Drawing.Size(10, 13)
        Me.SelectedVariantValue.TabIndex = 30
        Me.SelectedVariantValue.Text = "."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Edit Intake"
        '
        'EditSpecificIntake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 348)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Amount)
        Me.Controls.Add(Me.AmountValue)
        Me.Controls.Add(Me.FatsValue)
        Me.Controls.Add(Me.FatsLabel)
        Me.Controls.Add(Me.CarbsValue)
        Me.Controls.Add(Me.CarbsLabel)
        Me.Controls.Add(Me.ProteinValue)
        Me.Controls.Add(Me.ProteinLabel)
        Me.Controls.Add(Me.CaloriesValue)
        Me.Controls.Add(Me.CaloriesLabel)
        Me.Controls.Add(Me.SelectedIngredient)
        Me.Controls.Add(Me.SelectedSubvariantValue)
        Me.Controls.Add(Me.SelectedSubvariant)
        Me.Controls.Add(Me.SelectedVariant)
        Me.Controls.Add(Me.SelectedIngredientValue)
        Me.Controls.Add(Me.SelectedVariantValue)
        Me.Controls.Add(Me.Back)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditSpecificIntake"
        Me.Text = "Edit Intake"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents Amount As System.Windows.Forms.Label
    Friend WithEvents AmountValue As System.Windows.Forms.TextBox
    Friend WithEvents FatsValue As System.Windows.Forms.Label
    Friend WithEvents FatsLabel As System.Windows.Forms.Label
    Friend WithEvents CarbsValue As System.Windows.Forms.Label
    Friend WithEvents CarbsLabel As System.Windows.Forms.Label
    Friend WithEvents ProteinValue As System.Windows.Forms.Label
    Friend WithEvents ProteinLabel As System.Windows.Forms.Label
    Friend WithEvents CaloriesValue As System.Windows.Forms.Label
    Friend WithEvents CaloriesLabel As System.Windows.Forms.Label
    Friend WithEvents SelectedIngredient As System.Windows.Forms.Label
    Friend WithEvents SelectedSubvariantValue As System.Windows.Forms.Label
    Friend WithEvents SelectedSubvariant As System.Windows.Forms.Label
    Friend WithEvents SelectedVariant As System.Windows.Forms.Label
    Friend WithEvents SelectedIngredientValue As System.Windows.Forms.Label
    Friend WithEvents SelectedVariantValue As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
