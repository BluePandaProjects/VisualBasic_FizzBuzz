<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFizzBuzz
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
        Me.textboxInputVale = New System.Windows.Forms.TextBox()
        Me.labelInputValue = New System.Windows.Forms.Label()
        Me.listviewResults = New System.Windows.Forms.ListView()
        Me.buttonFizzBuzz = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textboxInputVale
        '
        Me.textboxInputVale.Location = New System.Drawing.Point(82, 12)
        Me.textboxInputVale.Name = "textboxInputVale"
        Me.textboxInputVale.Size = New System.Drawing.Size(100, 20)
        Me.textboxInputVale.TabIndex = 0
        '
        'labelInputValue
        '
        Me.labelInputValue.AutoSize = True
        Me.labelInputValue.Location = New System.Drawing.Point(12, 15)
        Me.labelInputValue.Name = "labelInputValue"
        Me.labelInputValue.Size = New System.Drawing.Size(47, 13)
        Me.labelInputValue.TabIndex = 1
        Me.labelInputValue.Text = "Number:"
        '
        'listviewResults
        '
        Me.listviewResults.HideSelection = False
        Me.listviewResults.Location = New System.Drawing.Point(12, 38)
        Me.listviewResults.Name = "listviewResults"
        Me.listviewResults.Size = New System.Drawing.Size(776, 400)
        Me.listviewResults.TabIndex = 2
        Me.listviewResults.UseCompatibleStateImageBehavior = False
        '
        'buttonFizzBuzz
        '
        Me.buttonFizzBuzz.Location = New System.Drawing.Point(713, 10)
        Me.buttonFizzBuzz.Name = "buttonFizzBuzz"
        Me.buttonFizzBuzz.Size = New System.Drawing.Size(75, 23)
        Me.buttonFizzBuzz.TabIndex = 3
        Me.buttonFizzBuzz.Text = "FizzBuzz"
        Me.buttonFizzBuzz.UseVisualStyleBackColor = True
        '
        'frmFizzBuzz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.buttonFizzBuzz)
        Me.Controls.Add(Me.listviewResults)
        Me.Controls.Add(Me.labelInputValue)
        Me.Controls.Add(Me.textboxInputVale)
        Me.Name = "frmFizzBuzz"
        Me.Text = "FizzBuzz - BluePandaProjects"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textboxInputVale As TextBox
    Friend WithEvents labelInputValue As Label
    Friend WithEvents listviewResults As ListView
    Friend WithEvents buttonFizzBuzz As Button
End Class
