<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchIngredient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchIngredient))
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SearchResult = New System.Windows.Forms.DataGridView()
        Me.IngredientID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IngredientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SearchResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchBox
        '
        Me.SearchBox.AcceptsReturn = True
        Me.SearchBox.Location = New System.Drawing.Point(12, 42)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(600, 20)
        Me.SearchBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search Ingredient"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(618, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.SearchResult.Location = New System.Drawing.Point(12, 68)
        Me.SearchResult.MultiSelect = False
        Me.SearchResult.Name = "SearchResult"
        Me.SearchResult.ReadOnly = True
        Me.SearchResult.RowHeadersVisible = False
        Me.SearchResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.SearchResult.ShowCellToolTips = False
        Me.SearchResult.ShowEditingIcon = False
        Me.SearchResult.Size = New System.Drawing.Size(600, 267)
        Me.SearchResult.TabIndex = 3
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
        'SearchIngredient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 350)
        Me.Controls.Add(Me.SearchResult)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SearchIngredient"
        Me.Text = "Search Ingredient"
        CType(Me.SearchResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SearchBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SearchResult As System.Windows.Forms.DataGridView
    Friend WithEvents IngredientID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IngredientName As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
