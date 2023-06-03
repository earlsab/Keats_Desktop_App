<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditSpecific
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
        Me.SuspendLayout()
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(422, 275)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(75, 23)
        Me.Back.TabIndex = 0
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'EditSpecific
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 325)
        Me.Controls.Add(Me.Back)
        Me.Name = "EditSpecific"
        Me.Text = "EditSpecific"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Back As System.Windows.Forms.Button
End Class
