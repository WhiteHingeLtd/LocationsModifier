<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YesNoDialog
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
        Me.BPanel5 = New WHLClasses.Controls.BPanel()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.NoButton = New System.Windows.Forms.Button()
        Me.YesButton = New System.Windows.Forms.Button()
        Me.BPanel2 = New WHLClasses.Controls.BPanel()
        Me.Instruction = New System.Windows.Forms.Label()
        Me.BPanel5.SuspendLayout()
        Me.BPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BPanel5
        '
        Me.BPanel5.BorderWidth = 1
        Me.BPanel5.Controls.Add(Me.OKButton)
        Me.BPanel5.Controls.Add(Me.CancelButton)
        Me.BPanel5.Controls.Add(Me.NoButton)
        Me.BPanel5.Controls.Add(Me.YesButton)
        Me.BPanel5.HighlightBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BPanel5.HighlightBorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BPanel5.HighlightNotBackgroundColor = System.Drawing.Color.Empty
        Me.BPanel5.HighlightNotBorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.BPanel5.HighlightOnFocus = True
        Me.BPanel5.Location = New System.Drawing.Point(19, 229)
        Me.BPanel5.Margin = New System.Windows.Forms.Padding(10)
        Me.BPanel5.Name = "BPanel5"
        Me.BPanel5.Padding = New System.Windows.Forms.Padding(21, 8, 8, 8)
        Me.BPanel5.Size = New System.Drawing.Size(827, 155)
        Me.BPanel5.TabIndex = 6
        Me.BPanel5.Title = "Controls"
        '
        'OKButton
        '
        Me.OKButton.BackColor = System.Drawing.Color.Navy
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OKButton.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OKButton.Location = New System.Drawing.Point(242, 11)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(168, 133)
        Me.OKButton.TabIndex = 5
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = False
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.Navy
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButton.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.Location = New System.Drawing.Point(444, 11)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(168, 133)
        Me.CancelButton.TabIndex = 0
        Me.CancelButton.Text = "CANCEL"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'NoButton
        '
        Me.NoButton.BackColor = System.Drawing.Color.Maroon
        Me.NoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NoButton.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoButton.Location = New System.Drawing.Point(648, 11)
        Me.NoButton.Name = "NoButton"
        Me.NoButton.Size = New System.Drawing.Size(168, 133)
        Me.NoButton.TabIndex = 4
        Me.NoButton.Text = "NO"
        Me.NoButton.UseVisualStyleBackColor = False
        '
        'YesButton
        '
        Me.YesButton.BackColor = System.Drawing.Color.DarkGreen
        Me.YesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.YesButton.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YesButton.Location = New System.Drawing.Point(24, 11)
        Me.YesButton.Name = "YesButton"
        Me.YesButton.Size = New System.Drawing.Size(168, 133)
        Me.YesButton.TabIndex = 4
        Me.YesButton.Text = "YES"
        Me.YesButton.UseVisualStyleBackColor = False
        '
        'BPanel2
        '
        Me.BPanel2.BorderWidth = 1
        Me.BPanel2.Controls.Add(Me.Instruction)
        Me.BPanel2.HighlightBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BPanel2.HighlightBorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BPanel2.HighlightNotBackgroundColor = System.Drawing.Color.Empty
        Me.BPanel2.HighlightNotBorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.BPanel2.HighlightOnFocus = True
        Me.BPanel2.Location = New System.Drawing.Point(19, 19)
        Me.BPanel2.Margin = New System.Windows.Forms.Padding(10)
        Me.BPanel2.Name = "BPanel2"
        Me.BPanel2.Padding = New System.Windows.Forms.Padding(21, 8, 8, 8)
        Me.BPanel2.Size = New System.Drawing.Size(827, 190)
        Me.BPanel2.TabIndex = 7
        Me.BPanel2.Title = "Question"
        '
        'Instruction
        '
        Me.Instruction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Instruction.Location = New System.Drawing.Point(21, 8)
        Me.Instruction.Name = "Instruction"
        Me.Instruction.Size = New System.Drawing.Size(798, 174)
        Me.Instruction.TabIndex = 0
        Me.Instruction.Text = "Please Wait"
        Me.Instruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'YesNoDialog
        '
        Me.AcceptButton = Me.YesButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(865, 403)
        Me.ControlBox = False
        Me.Controls.Add(Me.BPanel2)
        Me.Controls.Add(Me.BPanel5)
        Me.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "YesNoDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QUESTION"
        Me.TopMost = True
        Me.BPanel5.ResumeLayout(False)
        Me.BPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BPanel5 As WHLClasses.Controls.BPanel
    Friend WithEvents NoButton As Button
    Friend WithEvents YesButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents BPanel2 As WHLClasses.Controls.BPanel
    Friend WithEvents Instruction As Label
    Friend WithEvents OKButton As Button
End Class
