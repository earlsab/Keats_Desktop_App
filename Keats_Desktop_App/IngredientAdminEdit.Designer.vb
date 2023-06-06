<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngredientAdminEdit
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
        Me.SearchResult = New System.Windows.Forms.DataGridView()
        Me.IngredientID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IngredientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IngredientVariant = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IngredientSubvariant = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FatsValue = New System.Windows.Forms.Label()
        Me.FatsLabel = New System.Windows.Forms.Label()
        Me.CarbsValue = New System.Windows.Forms.Label()
        Me.CarbsLabel = New System.Windows.Forms.Label()
        Me.ProteinValue = New System.Windows.Forms.Label()
        Me.ProteinLabel = New System.Windows.Forms.Label()
        Me.CaloriesValue = New System.Windows.Forms.Label()
        Me.CaloriesLabel = New System.Windows.Forms.Label()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.SelectedSubvariantValue = New System.Windows.Forms.Label()
        Me.SelectedSubvariant = New System.Windows.Forms.Label()
        Me.SelectedVariant = New System.Windows.Forms.Label()
        Me.SelectedVariantValue = New System.Windows.Forms.Label()
        Me.SelectedIngredientValue = New System.Windows.Forms.Label()
        Me.SelectedIngredient = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.SearchResult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IngredientVariant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IngredientSubvariant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchResult
        '
        Me.SearchResult.AllowUserToAddRows = False
        Me.SearchResult.AllowUserToDeleteRows = False
        Me.SearchResult.AllowUserToResizeColumns = False
        Me.SearchResult.AllowUserToResizeRows = False
        Me.SearchResult.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.SearchResult.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SearchResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.SearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SearchResult.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IngredientID, Me.IngredientName})
        Me.SearchResult.Location = New System.Drawing.Point(18, 126)
        Me.SearchResult.MultiSelect = False
        Me.SearchResult.Name = "SearchResult"
        Me.SearchResult.ReadOnly = True
        Me.SearchResult.RowHeadersVisible = False
        Me.SearchResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.SearchResult.ShowCellToolTips = False
        Me.SearchResult.ShowEditingIcon = False
        Me.SearchResult.Size = New System.Drawing.Size(378, 267)
        Me.SearchResult.TabIndex = 4
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
        Me.IngredientName.HeaderText = "Ingredient Name"
        Me.IngredientName.Name = "IngredientName"
        Me.IngredientName.ReadOnly = True
        Me.IngredientName.Width = 600
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
        Me.IngredientVariant.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.IngredientVariant.Location = New System.Drawing.Point(413, 126)
        Me.IngredientVariant.MultiSelect = False
        Me.IngredientVariant.Name = "IngredientVariant"
        Me.IngredientVariant.ReadOnly = True
        Me.IngredientVariant.RowHeadersVisible = False
        Me.IngredientVariant.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.IngredientVariant.ShowCellToolTips = False
        Me.IngredientVariant.ShowEditingIcon = False
        Me.IngredientVariant.Size = New System.Drawing.Size(251, 267)
        Me.IngredientVariant.TabIndex = 26
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
        Me.DataGridViewTextBoxColumn2.HeaderText = "Part / Type "
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 450
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
        Me.IngredientSubvariant.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.IngredientSubvariant.Location = New System.Drawing.Point(690, 126)
        Me.IngredientSubvariant.MultiSelect = False
        Me.IngredientSubvariant.Name = "IngredientSubvariant"
        Me.IngredientSubvariant.ReadOnly = True
        Me.IngredientSubvariant.RowHeadersVisible = False
        Me.IngredientSubvariant.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.IngredientSubvariant.ShowCellToolTips = False
        Me.IngredientSubvariant.ShowEditingIcon = False
        Me.IngredientSubvariant.Size = New System.Drawing.Size(227, 267)
        Me.IngredientSubvariant.TabIndex = 27
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn3.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn4.HeaderText = "Preparation Method"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 450
        '
        'FatsValue
        '
        Me.FatsValue.AutoSize = True
        Me.FatsValue.Location = New System.Drawing.Point(546, 450)
        Me.FatsValue.Name = "FatsValue"
        Me.FatsValue.Size = New System.Drawing.Size(10, 13)
        Me.FatsValue.TabIndex = 48
        Me.FatsValue.Text = "."
        '
        'FatsLabel
        '
        Me.FatsLabel.AutoSize = True
        Me.FatsLabel.Location = New System.Drawing.Point(495, 450)
        Me.FatsLabel.Name = "FatsLabel"
        Me.FatsLabel.Size = New System.Drawing.Size(45, 13)
        Me.FatsLabel.TabIndex = 47
        Me.FatsLabel.Text = "Fats (g):"
        '
        'CarbsValue
        '
        Me.CarbsValue.AutoSize = True
        Me.CarbsValue.Location = New System.Drawing.Point(553, 425)
        Me.CarbsValue.Name = "CarbsValue"
        Me.CarbsValue.Size = New System.Drawing.Size(10, 13)
        Me.CarbsValue.TabIndex = 46
        Me.CarbsValue.Text = "."
        '
        'CarbsLabel
        '
        Me.CarbsLabel.AutoSize = True
        Me.CarbsLabel.Location = New System.Drawing.Point(495, 425)
        Me.CarbsLabel.Name = "CarbsLabel"
        Me.CarbsLabel.Size = New System.Drawing.Size(52, 13)
        Me.CarbsLabel.TabIndex = 45
        Me.CarbsLabel.Text = "Carbs (g):"
        '
        'ProteinValue
        '
        Me.ProteinValue.AutoSize = True
        Me.ProteinValue.Location = New System.Drawing.Point(382, 450)
        Me.ProteinValue.Name = "ProteinValue"
        Me.ProteinValue.Size = New System.Drawing.Size(10, 13)
        Me.ProteinValue.TabIndex = 44
        Me.ProteinValue.Text = "."
        '
        'ProteinLabel
        '
        Me.ProteinLabel.AutoSize = True
        Me.ProteinLabel.Location = New System.Drawing.Point(318, 450)
        Me.ProteinLabel.Name = "ProteinLabel"
        Me.ProteinLabel.Size = New System.Drawing.Size(58, 13)
        Me.ProteinLabel.TabIndex = 43
        Me.ProteinLabel.Text = "Protein (g):"
        '
        'CaloriesValue
        '
        Me.CaloriesValue.AutoSize = True
        Me.CaloriesValue.Location = New System.Drawing.Point(402, 424)
        Me.CaloriesValue.Name = "CaloriesValue"
        Me.CaloriesValue.Size = New System.Drawing.Size(10, 13)
        Me.CaloriesValue.TabIndex = 42
        Me.CaloriesValue.Text = "."
        '
        'CaloriesLabel
        '
        Me.CaloriesLabel.AutoSize = True
        Me.CaloriesLabel.Location = New System.Drawing.Point(318, 424)
        Me.CaloriesLabel.Name = "CaloriesLabel"
        Me.CaloriesLabel.Size = New System.Drawing.Size(78, 13)
        Me.CaloriesLabel.TabIndex = 41
        Me.CaloriesLabel.Text = "Calories (KCal):"
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(669, 435)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(114, 39)
        Me.Delete.TabIndex = 50
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(797, 435)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(118, 39)
        Me.Save.TabIndex = 49
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Search Ingredients"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(774, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 39)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "Add New Ingredient"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(16, 24)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(75, 39)
        Me.Back.TabIndex = 53
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'SelectedSubvariantValue
        '
        Me.SelectedSubvariantValue.AutoSize = True
        Me.SelectedSubvariantValue.Location = New System.Drawing.Point(169, 461)
        Me.SelectedSubvariantValue.Name = "SelectedSubvariantValue"
        Me.SelectedSubvariantValue.Size = New System.Drawing.Size(10, 13)
        Me.SelectedSubvariantValue.TabIndex = 56
        Me.SelectedSubvariantValue.Text = "."
        '
        'SelectedSubvariant
        '
        Me.SelectedSubvariant.AutoSize = True
        Me.SelectedSubvariant.Location = New System.Drawing.Point(15, 461)
        Me.SelectedSubvariant.Name = "SelectedSubvariant"
        Me.SelectedSubvariant.Size = New System.Drawing.Size(148, 13)
        Me.SelectedSubvariant.TabIndex = 55
        Me.SelectedSubvariant.Text = "Selected Preparation Method:"
        '
        'SelectedVariant
        '
        Me.SelectedVariant.AutoSize = True
        Me.SelectedVariant.Location = New System.Drawing.Point(15, 435)
        Me.SelectedVariant.Name = "SelectedVariant"
        Me.SelectedVariant.Size = New System.Drawing.Size(103, 13)
        Me.SelectedVariant.TabIndex = 54
        Me.SelectedVariant.Text = "Selected Part/Type:"
        '
        'SelectedVariantValue
        '
        Me.SelectedVariantValue.AutoSize = True
        Me.SelectedVariantValue.Location = New System.Drawing.Point(124, 435)
        Me.SelectedVariantValue.Name = "SelectedVariantValue"
        Me.SelectedVariantValue.Size = New System.Drawing.Size(10, 13)
        Me.SelectedVariantValue.TabIndex = 57
        Me.SelectedVariantValue.Text = "."
        '
        'SelectedIngredientValue
        '
        Me.SelectedIngredientValue.AutoSize = True
        Me.SelectedIngredientValue.Location = New System.Drawing.Point(123, 409)
        Me.SelectedIngredientValue.Name = "SelectedIngredientValue"
        Me.SelectedIngredientValue.Size = New System.Drawing.Size(10, 13)
        Me.SelectedIngredientValue.TabIndex = 59
        Me.SelectedIngredientValue.Text = "."
        '
        'SelectedIngredient
        '
        Me.SelectedIngredient.AutoSize = True
        Me.SelectedIngredient.Location = New System.Drawing.Point(15, 409)
        Me.SelectedIngredient.Name = "SelectedIngredient"
        Me.SelectedIngredient.Size = New System.Drawing.Size(102, 13)
        Me.SelectedIngredient.TabIndex = 58
        Me.SelectedIngredient.Text = "Selected Ingredient:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(321, 98)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 61
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SearchBox
        '
        Me.SearchBox.AcceptsReturn = True
        Me.SearchBox.Location = New System.Drawing.Point(16, 100)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(288, 20)
        Me.SearchBox.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(108, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Ingredient Edit"
        '
        'IngredientAdminEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 497)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.SearchBox)
        Me.Controls.Add(Me.SelectedIngredientValue)
        Me.Controls.Add(Me.SelectedIngredient)
        Me.Controls.Add(Me.SelectedSubvariantValue)
        Me.Controls.Add(Me.SelectedSubvariant)
        Me.Controls.Add(Me.SelectedVariant)
        Me.Controls.Add(Me.SelectedVariantValue)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.FatsValue)
        Me.Controls.Add(Me.FatsLabel)
        Me.Controls.Add(Me.CarbsValue)
        Me.Controls.Add(Me.CarbsLabel)
        Me.Controls.Add(Me.ProteinValue)
        Me.Controls.Add(Me.ProteinLabel)
        Me.Controls.Add(Me.CaloriesValue)
        Me.Controls.Add(Me.CaloriesLabel)
        Me.Controls.Add(Me.IngredientSubvariant)
        Me.Controls.Add(Me.IngredientVariant)
        Me.Controls.Add(Me.SearchResult)
        Me.Name = "IngredientAdminEdit"
        Me.Text = "IngredientAdminEdit"
        CType(Me.SearchResult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IngredientVariant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IngredientSubvariant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SearchResult As System.Windows.Forms.DataGridView
    Friend WithEvents IngredientID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IngredientName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IngredientVariant As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IngredientSubvariant As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FatsValue As System.Windows.Forms.Label
    Friend WithEvents FatsLabel As System.Windows.Forms.Label
    Friend WithEvents CarbsValue As System.Windows.Forms.Label
    Friend WithEvents CarbsLabel As System.Windows.Forms.Label
    Friend WithEvents ProteinValue As System.Windows.Forms.Label
    Friend WithEvents ProteinLabel As System.Windows.Forms.Label
    Friend WithEvents CaloriesValue As System.Windows.Forms.Label
    Friend WithEvents CaloriesLabel As System.Windows.Forms.Label
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents SelectedSubvariantValue As System.Windows.Forms.Label
    Friend WithEvents SelectedSubvariant As System.Windows.Forms.Label
    Friend WithEvents SelectedVariant As System.Windows.Forms.Label
    Friend WithEvents SelectedVariantValue As System.Windows.Forms.Label
    Friend WithEvents SelectedIngredientValue As System.Windows.Forms.Label
    Friend WithEvents SelectedIngredient As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SearchBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
