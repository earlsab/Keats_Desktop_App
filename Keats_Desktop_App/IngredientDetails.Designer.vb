<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngredientDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IngredientDetails))
        Me.IngredientVariant = New System.Windows.Forms.DataGridView()
        Me.IngredientID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IngredientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IngredientSubvariant = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectedVariant = New System.Windows.Forms.Label()
        Me.SelectedSubvariant = New System.Windows.Forms.Label()
        Me.SelectedSubvariantValue = New System.Windows.Forms.Label()
        Me.SelectedVariantValue = New System.Windows.Forms.Label()
        Me.SelectedIngredientValue = New System.Windows.Forms.Label()
        Me.SelectedIngredient = New System.Windows.Forms.Label()
        Me.CaloriesLabel = New System.Windows.Forms.Label()
        Me.CaloriesValue = New System.Windows.Forms.Label()
        Me.ProteinValue = New System.Windows.Forms.Label()
        Me.ProteinLabel = New System.Windows.Forms.Label()
        Me.CarbsValue = New System.Windows.Forms.Label()
        Me.CarbsLabel = New System.Windows.Forms.Label()
        Me.FatsValue = New System.Windows.Forms.Label()
        Me.FatsLabel = New System.Windows.Forms.Label()
        Me.AmountValue = New System.Windows.Forms.TextBox()
        Me.Amount = New System.Windows.Forms.Label()
        Me.Add = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        CType(Me.IngredientVariant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IngredientSubvariant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.IngredientVariant.Location = New System.Drawing.Point(17, 75)
        Me.IngredientVariant.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IngredientVariant.MultiSelect = False
        Me.IngredientVariant.Name = "IngredientVariant"
        Me.IngredientVariant.ReadOnly = True
        Me.IngredientVariant.RowHeadersVisible = False
        Me.IngredientVariant.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.IngredientVariant.ShowCellToolTips = False
        Me.IngredientVariant.ShowEditingIcon = False
        Me.IngredientVariant.Size = New System.Drawing.Size(667, 218)
        Me.IngredientVariant.TabIndex = 4
        '
        'IngredientID
        '
        Me.IngredientID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.IngredientID.HeaderText = "ID"
        Me.IngredientID.Name = "IngredientID"
        Me.IngredientID.ReadOnly = True
        Me.IngredientID.Visible = False
        '
        'IngredientName
        '
        Me.IngredientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.IngredientName.HeaderText = "Part / Type "
        Me.IngredientName.Name = "IngredientName"
        Me.IngredientName.ReadOnly = True
        Me.IngredientName.Width = 450
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
        Me.IngredientSubvariant.Location = New System.Drawing.Point(692, 75)
        Me.IngredientSubvariant.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IngredientSubvariant.MultiSelect = False
        Me.IngredientSubvariant.Name = "IngredientSubvariant"
        Me.IngredientSubvariant.ReadOnly = True
        Me.IngredientSubvariant.RowHeadersVisible = False
        Me.IngredientSubvariant.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.IngredientSubvariant.ShowCellToolTips = False
        Me.IngredientSubvariant.ShowEditingIcon = False
        Me.IngredientSubvariant.Size = New System.Drawing.Size(667, 218)
        Me.IngredientSubvariant.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn2.HeaderText = "Preparation Method"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 450
        '
        'SelectedVariant
        '
        Me.SelectedVariant.AutoSize = True
        Me.SelectedVariant.Location = New System.Drawing.Point(17, 52)
        Me.SelectedVariant.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SelectedVariant.Name = "SelectedVariant"
        Me.SelectedVariant.Size = New System.Drawing.Size(133, 17)
        Me.SelectedVariant.TabIndex = 6
        Me.SelectedVariant.Text = "Selected Part/Type:"
        '
        'SelectedSubvariant
        '
        Me.SelectedSubvariant.AutoSize = True
        Me.SelectedSubvariant.Location = New System.Drawing.Point(688, 52)
        Me.SelectedSubvariant.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SelectedSubvariant.Name = "SelectedSubvariant"
        Me.SelectedSubvariant.Size = New System.Drawing.Size(196, 17)
        Me.SelectedSubvariant.TabIndex = 8
        Me.SelectedSubvariant.Text = "Selected Preparation Method:"
        '
        'SelectedSubvariantValue
        '
        Me.SelectedSubvariantValue.AutoSize = True
        Me.SelectedSubvariantValue.Location = New System.Drawing.Point(893, 52)
        Me.SelectedSubvariantValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SelectedSubvariantValue.Name = "SelectedSubvariantValue"
        Me.SelectedSubvariantValue.Size = New System.Drawing.Size(12, 17)
        Me.SelectedSubvariantValue.TabIndex = 9
        Me.SelectedSubvariantValue.Text = "."
        '
        'SelectedVariantValue
        '
        Me.SelectedVariantValue.AutoSize = True
        Me.SelectedVariantValue.Location = New System.Drawing.Point(163, 52)
        Me.SelectedVariantValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SelectedVariantValue.Name = "SelectedVariantValue"
        Me.SelectedVariantValue.Size = New System.Drawing.Size(12, 17)
        Me.SelectedVariantValue.TabIndex = 10
        Me.SelectedVariantValue.Text = "."
        '
        'SelectedIngredientValue
        '
        Me.SelectedIngredientValue.AutoSize = True
        Me.SelectedIngredientValue.Location = New System.Drawing.Point(269, 17)
        Me.SelectedIngredientValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SelectedIngredientValue.Name = "SelectedIngredientValue"
        Me.SelectedIngredientValue.Size = New System.Drawing.Size(12, 17)
        Me.SelectedIngredientValue.TabIndex = 12
        Me.SelectedIngredientValue.Text = "."
        '
        'SelectedIngredient
        '
        Me.SelectedIngredient.AutoSize = True
        Me.SelectedIngredient.Location = New System.Drawing.Point(125, 17)
        Me.SelectedIngredient.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SelectedIngredient.Name = "SelectedIngredient"
        Me.SelectedIngredient.Size = New System.Drawing.Size(134, 17)
        Me.SelectedIngredient.TabIndex = 11
        Me.SelectedIngredient.Text = "Selected Ingredient:"
        '
        'CaloriesLabel
        '
        Me.CaloriesLabel.AutoSize = True
        Me.CaloriesLabel.Location = New System.Drawing.Point(13, 314)
        Me.CaloriesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CaloriesLabel.Name = "CaloriesLabel"
        Me.CaloriesLabel.Size = New System.Drawing.Size(106, 17)
        Me.CaloriesLabel.TabIndex = 13
        Me.CaloriesLabel.Text = "Calories (KCal):"
        '
        'CaloriesValue
        '
        Me.CaloriesValue.AutoSize = True
        Me.CaloriesValue.Location = New System.Drawing.Point(125, 314)
        Me.CaloriesValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CaloriesValue.Name = "CaloriesValue"
        Me.CaloriesValue.Size = New System.Drawing.Size(12, 17)
        Me.CaloriesValue.TabIndex = 14
        Me.CaloriesValue.Text = "."
        '
        'ProteinValue
        '
        Me.ProteinValue.AutoSize = True
        Me.ProteinValue.Location = New System.Drawing.Point(297, 314)
        Me.ProteinValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProteinValue.Name = "ProteinValue"
        Me.ProteinValue.Size = New System.Drawing.Size(12, 17)
        Me.ProteinValue.TabIndex = 16
        Me.ProteinValue.Text = "."
        '
        'ProteinLabel
        '
        Me.ProteinLabel.AutoSize = True
        Me.ProteinLabel.Location = New System.Drawing.Point(212, 314)
        Me.ProteinLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProteinLabel.Name = "ProteinLabel"
        Me.ProteinLabel.Size = New System.Drawing.Size(79, 17)
        Me.ProteinLabel.TabIndex = 15
        Me.ProteinLabel.Text = "Protein (g):"
        '
        'CarbsValue
        '
        Me.CarbsValue.AutoSize = True
        Me.CarbsValue.Location = New System.Drawing.Point(483, 314)
        Me.CarbsValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CarbsValue.Name = "CarbsValue"
        Me.CarbsValue.Size = New System.Drawing.Size(12, 17)
        Me.CarbsValue.TabIndex = 18
        Me.CarbsValue.Text = "."
        '
        'CarbsLabel
        '
        Me.CarbsLabel.AutoSize = True
        Me.CarbsLabel.Location = New System.Drawing.Point(405, 314)
        Me.CarbsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CarbsLabel.Name = "CarbsLabel"
        Me.CarbsLabel.Size = New System.Drawing.Size(71, 17)
        Me.CarbsLabel.TabIndex = 17
        Me.CarbsLabel.Text = "Carbs (g):"
        '
        'FatsValue
        '
        Me.FatsValue.AutoSize = True
        Me.FatsValue.Location = New System.Drawing.Point(671, 314)
        Me.FatsValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FatsValue.Name = "FatsValue"
        Me.FatsValue.Size = New System.Drawing.Size(12, 17)
        Me.FatsValue.TabIndex = 20
        Me.FatsValue.Text = "."
        '
        'FatsLabel
        '
        Me.FatsLabel.AutoSize = True
        Me.FatsLabel.Location = New System.Drawing.Point(603, 314)
        Me.FatsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FatsLabel.Name = "FatsLabel"
        Me.FatsLabel.Size = New System.Drawing.Size(61, 17)
        Me.FatsLabel.TabIndex = 19
        Me.FatsLabel.Text = "Fats (g):"
        '
        'AmountValue
        '
        Me.AmountValue.Location = New System.Drawing.Point(1101, 310)
        Me.AmountValue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AmountValue.Name = "AmountValue"
        Me.AmountValue.Size = New System.Drawing.Size(148, 22)
        Me.AmountValue.TabIndex = 21
        '
        'Amount
        '
        Me.Amount.AutoSize = True
        Me.Amount.Location = New System.Drawing.Point(1012, 314)
        Me.Amount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Amount.Name = "Amount"
        Me.Amount.Size = New System.Drawing.Size(82, 17)
        Me.Amount.TabIndex = 22
        Me.Amount.Text = "Amount (g):"
        '
        'Add
        '
        Me.Add.Location = New System.Drawing.Point(1259, 308)
        Me.Add.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(100, 28)
        Me.Add.TabIndex = 23
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = True
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(17, 11)
        Me.Back.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(100, 28)
        Me.Back.TabIndex = 24
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'IngredientDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1375, 352)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Add)
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
        Me.Controls.Add(Me.SelectedIngredientValue)
        Me.Controls.Add(Me.SelectedIngredient)
        Me.Controls.Add(Me.SelectedVariantValue)
        Me.Controls.Add(Me.SelectedSubvariantValue)
        Me.Controls.Add(Me.SelectedSubvariant)
        Me.Controls.Add(Me.SelectedVariant)
        Me.Controls.Add(Me.IngredientSubvariant)
        Me.Controls.Add(Me.IngredientVariant)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "IngredientDetails"
        Me.Text = "Ingredient Details"
        CType(Me.IngredientVariant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IngredientSubvariant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IngredientVariant As System.Windows.Forms.DataGridView
    Friend WithEvents IngredientSubvariant As System.Windows.Forms.DataGridView
    Friend WithEvents SelectedVariant As System.Windows.Forms.Label
    Friend WithEvents SelectedSubvariant As System.Windows.Forms.Label
    Friend WithEvents SelectedSubvariantValue As System.Windows.Forms.Label
    Friend WithEvents SelectedVariantValue As System.Windows.Forms.Label
    Friend WithEvents SelectedIngredientValue As System.Windows.Forms.Label
    Friend WithEvents SelectedIngredient As System.Windows.Forms.Label
    Friend WithEvents CaloriesLabel As System.Windows.Forms.Label
    Friend WithEvents CaloriesValue As System.Windows.Forms.Label
    Friend WithEvents ProteinValue As System.Windows.Forms.Label
    Friend WithEvents ProteinLabel As System.Windows.Forms.Label
    Friend WithEvents CarbsValue As System.Windows.Forms.Label
    Friend WithEvents CarbsLabel As System.Windows.Forms.Label
    Friend WithEvents FatsValue As System.Windows.Forms.Label
    Friend WithEvents FatsLabel As System.Windows.Forms.Label
    Friend WithEvents IngredientID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IngredientName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountValue As System.Windows.Forms.TextBox
    Friend WithEvents Amount As System.Windows.Forms.Label
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents Back As System.Windows.Forms.Button
End Class
