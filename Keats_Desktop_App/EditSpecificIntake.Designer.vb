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
        Me.Back = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IngredientSubvariant = New System.Windows.Forms.DataGridView()
        Me.IngredientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IngredientID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectedIngredientValue = New System.Windows.Forms.Label()
        Me.SelectedVariantValue = New System.Windows.Forms.Label()
        Me.IngredientVariant = New System.Windows.Forms.DataGridView()
        CType(Me.IngredientSubvariant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IngredientVariant, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(397, 338)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 39)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(525, 338)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(118, 39)
        Me.Save.TabIndex = 43
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Amount
        '
        Me.Amount.AutoSize = True
        Me.Amount.Location = New System.Drawing.Point(406, 304)
        Me.Amount.Name = "Amount"
        Me.Amount.Size = New System.Drawing.Size(61, 13)
        Me.Amount.TabIndex = 42
        Me.Amount.Text = "Amount (g):"
        '
        'AmountValue
        '
        Me.AmountValue.Location = New System.Drawing.Point(473, 301)
        Me.AmountValue.Name = "AmountValue"
        Me.AmountValue.Size = New System.Drawing.Size(112, 20)
        Me.AmountValue.TabIndex = 41
        '
        'FatsValue
        '
        Me.FatsValue.AutoSize = True
        Me.FatsValue.Location = New System.Drawing.Point(755, 270)
        Me.FatsValue.Name = "FatsValue"
        Me.FatsValue.Size = New System.Drawing.Size(10, 13)
        Me.FatsValue.TabIndex = 40
        Me.FatsValue.Text = "."
        '
        'FatsLabel
        '
        Me.FatsLabel.AutoSize = True
        Me.FatsLabel.Location = New System.Drawing.Point(704, 270)
        Me.FatsLabel.Name = "FatsLabel"
        Me.FatsLabel.Size = New System.Drawing.Size(45, 13)
        Me.FatsLabel.TabIndex = 39
        Me.FatsLabel.Text = "Fats (g):"
        '
        'CarbsValue
        '
        Me.CarbsValue.AutoSize = True
        Me.CarbsValue.Location = New System.Drawing.Point(614, 270)
        Me.CarbsValue.Name = "CarbsValue"
        Me.CarbsValue.Size = New System.Drawing.Size(10, 13)
        Me.CarbsValue.TabIndex = 38
        Me.CarbsValue.Text = "."
        '
        'CarbsLabel
        '
        Me.CarbsLabel.AutoSize = True
        Me.CarbsLabel.Location = New System.Drawing.Point(556, 270)
        Me.CarbsLabel.Name = "CarbsLabel"
        Me.CarbsLabel.Size = New System.Drawing.Size(52, 13)
        Me.CarbsLabel.TabIndex = 37
        Me.CarbsLabel.Text = "Carbs (g):"
        '
        'ProteinValue
        '
        Me.ProteinValue.AutoSize = True
        Me.ProteinValue.Location = New System.Drawing.Point(475, 270)
        Me.ProteinValue.Name = "ProteinValue"
        Me.ProteinValue.Size = New System.Drawing.Size(10, 13)
        Me.ProteinValue.TabIndex = 36
        Me.ProteinValue.Text = "."
        '
        'ProteinLabel
        '
        Me.ProteinLabel.AutoSize = True
        Me.ProteinLabel.Location = New System.Drawing.Point(411, 270)
        Me.ProteinLabel.Name = "ProteinLabel"
        Me.ProteinLabel.Size = New System.Drawing.Size(58, 13)
        Me.ProteinLabel.TabIndex = 35
        Me.ProteinLabel.Text = "Protein (g):"
        '
        'CaloriesValue
        '
        Me.CaloriesValue.AutoSize = True
        Me.CaloriesValue.Location = New System.Drawing.Point(346, 270)
        Me.CaloriesValue.Name = "CaloriesValue"
        Me.CaloriesValue.Size = New System.Drawing.Size(10, 13)
        Me.CaloriesValue.TabIndex = 34
        Me.CaloriesValue.Text = "."
        '
        'CaloriesLabel
        '
        Me.CaloriesLabel.AutoSize = True
        Me.CaloriesLabel.Location = New System.Drawing.Point(262, 270)
        Me.CaloriesLabel.Name = "CaloriesLabel"
        Me.CaloriesLabel.Size = New System.Drawing.Size(78, 13)
        Me.CaloriesLabel.TabIndex = 33
        Me.CaloriesLabel.Text = "Calories (KCal):"
        '
        'SelectedIngredient
        '
        Me.SelectedIngredient.AutoSize = True
        Me.SelectedIngredient.Location = New System.Drawing.Point(92, 25)
        Me.SelectedIngredient.Name = "SelectedIngredient"
        Me.SelectedIngredient.Size = New System.Drawing.Size(102, 13)
        Me.SelectedIngredient.TabIndex = 31
        Me.SelectedIngredient.Text = "Selected Ingredient:"
        '
        'SelectedSubvariantValue
        '
        Me.SelectedSubvariantValue.AutoSize = True
        Me.SelectedSubvariantValue.Location = New System.Drawing.Point(668, 53)
        Me.SelectedSubvariantValue.Name = "SelectedSubvariantValue"
        Me.SelectedSubvariantValue.Size = New System.Drawing.Size(10, 13)
        Me.SelectedSubvariantValue.TabIndex = 29
        Me.SelectedSubvariantValue.Text = "."
        '
        'SelectedSubvariant
        '
        Me.SelectedSubvariant.AutoSize = True
        Me.SelectedSubvariant.Location = New System.Drawing.Point(514, 53)
        Me.SelectedSubvariant.Name = "SelectedSubvariant"
        Me.SelectedSubvariant.Size = New System.Drawing.Size(148, 13)
        Me.SelectedSubvariant.TabIndex = 28
        Me.SelectedSubvariant.Text = "Selected Preparation Method:"
        '
        'SelectedVariant
        '
        Me.SelectedVariant.AutoSize = True
        Me.SelectedVariant.Location = New System.Drawing.Point(11, 53)
        Me.SelectedVariant.Name = "SelectedVariant"
        Me.SelectedVariant.Size = New System.Drawing.Size(103, 13)
        Me.SelectedVariant.TabIndex = 27
        Me.SelectedVariant.Text = "Selected Part/Type:"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn2.HeaderText = "Preparation Method"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 450
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'IngredientSubvariant
        '
        Me.IngredientSubvariant.AllowUserToAddRows = False
        Me.IngredientSubvariant.AllowUserToDeleteRows = False
        Me.IngredientSubvariant.AllowUserToResizeColumns = False
        Me.IngredientSubvariant.AllowUserToResizeRows = False
        Me.IngredientSubvariant.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.IngredientSubvariant.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IngredientSubvariant.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.IngredientSubvariant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IngredientSubvariant.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.IngredientSubvariant.Location = New System.Drawing.Point(517, 72)
        Me.IngredientSubvariant.MultiSelect = False
        Me.IngredientSubvariant.Name = "IngredientSubvariant"
        Me.IngredientSubvariant.ReadOnly = True
        Me.IngredientSubvariant.RowHeadersVisible = False
        Me.IngredientSubvariant.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.IngredientSubvariant.ShowCellToolTips = False
        Me.IngredientSubvariant.ShowEditingIcon = False
        Me.IngredientSubvariant.Size = New System.Drawing.Size(500, 177)
        Me.IngredientSubvariant.TabIndex = 26
        '
        'IngredientName
        '
        Me.IngredientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.IngredientName.HeaderText = "Part / Type "
        Me.IngredientName.Name = "IngredientName"
        Me.IngredientName.ReadOnly = True
        Me.IngredientName.Width = 450
        '
        'IngredientID
        '
        Me.IngredientID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.IngredientID.HeaderText = "ID"
        Me.IngredientID.Name = "IngredientID"
        Me.IngredientID.ReadOnly = True
        Me.IngredientID.Visible = False
        '
        'SelectedIngredientValue
        '
        Me.SelectedIngredientValue.AutoSize = True
        Me.SelectedIngredientValue.Location = New System.Drawing.Point(200, 25)
        Me.SelectedIngredientValue.Name = "SelectedIngredientValue"
        Me.SelectedIngredientValue.Size = New System.Drawing.Size(10, 13)
        Me.SelectedIngredientValue.TabIndex = 32
        Me.SelectedIngredientValue.Text = "."
        '
        'SelectedVariantValue
        '
        Me.SelectedVariantValue.AutoSize = True
        Me.SelectedVariantValue.Location = New System.Drawing.Point(120, 53)
        Me.SelectedVariantValue.Name = "SelectedVariantValue"
        Me.SelectedVariantValue.Size = New System.Drawing.Size(10, 13)
        Me.SelectedVariantValue.TabIndex = 30
        Me.SelectedVariantValue.Text = "."
        '
        'IngredientVariant
        '
        Me.IngredientVariant.AllowUserToAddRows = False
        Me.IngredientVariant.AllowUserToDeleteRows = False
        Me.IngredientVariant.AllowUserToResizeColumns = False
        Me.IngredientVariant.AllowUserToResizeRows = False
        Me.IngredientVariant.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.IngredientVariant.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IngredientVariant.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.IngredientVariant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IngredientVariant.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IngredientID, Me.IngredientName})
        Me.IngredientVariant.Location = New System.Drawing.Point(11, 72)
        Me.IngredientVariant.MultiSelect = False
        Me.IngredientVariant.Name = "IngredientVariant"
        Me.IngredientVariant.ReadOnly = True
        Me.IngredientVariant.RowHeadersVisible = False
        Me.IngredientVariant.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.IngredientVariant.ShowCellToolTips = False
        Me.IngredientVariant.ShowEditingIcon = False
        Me.IngredientVariant.Size = New System.Drawing.Size(500, 177)
        Me.IngredientVariant.TabIndex = 25
        '
        'EditSpecificIntake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 399)
        Me.Controls.Add(Me.Button1)
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
        Me.Controls.Add(Me.IngredientSubvariant)
        Me.Controls.Add(Me.SelectedIngredientValue)
        Me.Controls.Add(Me.SelectedVariantValue)
        Me.Controls.Add(Me.IngredientVariant)
        Me.Controls.Add(Me.Back)
        Me.Name = "EditSpecificIntake"
        Me.Text = "EditSpecific"
        CType(Me.IngredientSubvariant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IngredientVariant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
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
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IngredientSubvariant As System.Windows.Forms.DataGridView
    Friend WithEvents IngredientName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IngredientID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SelectedIngredientValue As System.Windows.Forms.Label
    Friend WithEvents SelectedVariantValue As System.Windows.Forms.Label
    Friend WithEvents IngredientVariant As System.Windows.Forms.DataGridView
End Class
