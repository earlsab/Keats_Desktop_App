﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SelectedIngredient = New System.Windows.Forms.Label()
        Me.Calories = New System.Windows.Forms.Label()
        Me.CaloriesValue = New System.Windows.Forms.Label()
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
        Me.IngredientVariant.Location = New System.Drawing.Point(12, 105)
        Me.IngredientVariant.MultiSelect = False
        Me.IngredientVariant.Name = "IngredientVariant"
        Me.IngredientVariant.ReadOnly = True
        Me.IngredientVariant.RowHeadersVisible = False
        Me.IngredientVariant.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.IngredientVariant.ShowCellToolTips = False
        Me.IngredientVariant.ShowEditingIcon = False
        Me.IngredientVariant.Size = New System.Drawing.Size(500, 267)
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
        Me.IngredientName.Width = 500
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
        Me.IngredientSubvariant.Location = New System.Drawing.Point(518, 105)
        Me.IngredientSubvariant.MultiSelect = False
        Me.IngredientSubvariant.Name = "IngredientSubvariant"
        Me.IngredientSubvariant.ReadOnly = True
        Me.IngredientSubvariant.RowHeadersVisible = False
        Me.IngredientSubvariant.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.IngredientSubvariant.ShowCellToolTips = False
        Me.IngredientSubvariant.ShowEditingIcon = False
        Me.IngredientSubvariant.Size = New System.Drawing.Size(500, 267)
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
        Me.DataGridViewTextBoxColumn2.Width = 500
        '
        'SelectedVariant
        '
        Me.SelectedVariant.AutoSize = True
        Me.SelectedVariant.Location = New System.Drawing.Point(12, 86)
        Me.SelectedVariant.Name = "SelectedVariant"
        Me.SelectedVariant.Size = New System.Drawing.Size(103, 13)
        Me.SelectedVariant.TabIndex = 6
        Me.SelectedVariant.Text = "Selected Part/Type:"
        '
        'SelectedSubvariant
        '
        Me.SelectedSubvariant.AutoSize = True
        Me.SelectedSubvariant.Location = New System.Drawing.Point(515, 86)
        Me.SelectedSubvariant.Name = "SelectedSubvariant"
        Me.SelectedSubvariant.Size = New System.Drawing.Size(148, 13)
        Me.SelectedSubvariant.TabIndex = 8
        Me.SelectedSubvariant.Text = "Selected Preparation Method:"
        '
        'SelectedSubvariantValue
        '
        Me.SelectedSubvariantValue.AutoSize = True
        Me.SelectedSubvariantValue.Location = New System.Drawing.Point(669, 86)
        Me.SelectedSubvariantValue.Name = "SelectedSubvariantValue"
        Me.SelectedSubvariantValue.Size = New System.Drawing.Size(10, 13)
        Me.SelectedSubvariantValue.TabIndex = 9
        Me.SelectedSubvariantValue.Text = "."
        '
        'SelectedVariantValue
        '
        Me.SelectedVariantValue.AutoSize = True
        Me.SelectedVariantValue.Location = New System.Drawing.Point(121, 86)
        Me.SelectedVariantValue.Name = "SelectedVariantValue"
        Me.SelectedVariantValue.Size = New System.Drawing.Size(10, 13)
        Me.SelectedVariantValue.TabIndex = 10
        Me.SelectedVariantValue.Text = "."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(121, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "."
        '
        'SelectedIngredient
        '
        Me.SelectedIngredient.AutoSize = True
        Me.SelectedIngredient.Location = New System.Drawing.Point(12, 9)
        Me.SelectedIngredient.Name = "SelectedIngredient"
        Me.SelectedIngredient.Size = New System.Drawing.Size(102, 13)
        Me.SelectedIngredient.TabIndex = 11
        Me.SelectedIngredient.Text = "Selected Ingredient:"
        '
        'Calories
        '
        Me.Calories.AutoSize = True
        Me.Calories.Location = New System.Drawing.Point(9, 411)
        Me.Calories.Name = "Calories"
        Me.Calories.Size = New System.Drawing.Size(47, 13)
        Me.Calories.TabIndex = 13
        Me.Calories.Text = "Calories:"
        '
        'CaloriesValue
        '
        Me.CaloriesValue.AutoSize = True
        Me.CaloriesValue.Location = New System.Drawing.Point(62, 411)
        Me.CaloriesValue.Name = "CaloriesValue"
        Me.CaloriesValue.Size = New System.Drawing.Size(10, 13)
        Me.CaloriesValue.TabIndex = 14
        Me.CaloriesValue.Text = "."
        '
        'IngredientDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 788)
        Me.Controls.Add(Me.CaloriesValue)
        Me.Controls.Add(Me.Calories)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SelectedIngredient)
        Me.Controls.Add(Me.SelectedVariantValue)
        Me.Controls.Add(Me.SelectedSubvariantValue)
        Me.Controls.Add(Me.SelectedSubvariant)
        Me.Controls.Add(Me.SelectedVariant)
        Me.Controls.Add(Me.IngredientSubvariant)
        Me.Controls.Add(Me.IngredientVariant)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
    Friend WithEvents IngredientID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IngredientName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SelectedSubvariant As System.Windows.Forms.Label
    Friend WithEvents SelectedSubvariantValue As System.Windows.Forms.Label
    Friend WithEvents SelectedVariantValue As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SelectedIngredient As System.Windows.Forms.Label
    Friend WithEvents Calories As System.Windows.Forms.Label
    Friend WithEvents CaloriesValue As System.Windows.Forms.Label
End Class
