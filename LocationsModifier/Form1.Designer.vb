<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.StartTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BPanel6 = New WHLClasses.Controls.BPanel()
        Me.StoreLocations = New System.Windows.Forms.Label()
        Me.PickLocation = New System.Windows.Forms.Label()
        Me.BPanel5 = New WHLClasses.Controls.BPanel()
        Me.ModeText = New System.Windows.Forms.Label()
        Me.ControlBox = New WHLClasses.Controls.BPanel()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.BPanel4 = New WHLClasses.Controls.BPanel()
        Me.ItemDetails = New System.Windows.Forms.Label()
        Me.BPanel3 = New WHLClasses.Controls.BPanel()
        Me.History = New System.Windows.Forms.TextBox()
        Me.BPanel2 = New WHLClasses.Controls.BPanel()
        Me.Instruction = New System.Windows.Forms.Label()
        Me.BPanel1 = New WHLClasses.Controls.BPanel()
        Me.ScanTarget = New System.Windows.Forms.TextBox()
        Me.BPanel6.SuspendLayout()
        Me.BPanel5.SuspendLayout()
        Me.ControlBox.SuspendLayout()
        Me.BPanel4.SuspendLayout()
        Me.BPanel3.SuspendLayout()
        Me.BPanel2.SuspendLayout()
        Me.BPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StartTimer
        '
        Me.StartTimer.Enabled = True
        '
        'BPanel6
        '
        Me.BPanel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BPanel6.BorderWidth = 1
        Me.BPanel6.Controls.Add(Me.StoreLocations)
        Me.BPanel6.Controls.Add(Me.PickLocation)
        Me.BPanel6.HighlightBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BPanel6.HighlightBorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BPanel6.HighlightNotBackgroundColor = System.Drawing.Color.Empty
        Me.BPanel6.HighlightNotBorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.BPanel6.HighlightOnFocus = True
        Me.BPanel6.Location = New System.Drawing.Point(328, 564)
        Me.BPanel6.Margin = New System.Windows.Forms.Padding(10)
        Me.BPanel6.Name = "BPanel6"
        Me.BPanel6.Padding = New System.Windows.Forms.Padding(21, 8, 8, 8)
        Me.BPanel6.Size = New System.Drawing.Size(717, 179)
        Me.BPanel6.TabIndex = 5
        Me.BPanel6.Title = "Current Locations"
        '
        'StoreLocations
        '
        Me.StoreLocations.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StoreLocations.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StoreLocations.Location = New System.Drawing.Point(21, 88)
        Me.StoreLocations.Name = "StoreLocations"
        Me.StoreLocations.Size = New System.Drawing.Size(688, 83)
        Me.StoreLocations.TabIndex = 2
        Me.StoreLocations.Text = "Store:"
        Me.StoreLocations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.StoreLocations.UseMnemonic = False
        '
        'PickLocation
        '
        Me.PickLocation.Dock = System.Windows.Forms.DockStyle.Top
        Me.PickLocation.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PickLocation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PickLocation.Location = New System.Drawing.Point(21, 8)
        Me.PickLocation.Name = "PickLocation"
        Me.PickLocation.Size = New System.Drawing.Size(688, 80)
        Me.PickLocation.TabIndex = 1
        Me.PickLocation.Text = "Pick: "
        Me.PickLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PickLocation.UseMnemonic = False
        '
        'BPanel5
        '
        Me.BPanel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BPanel5.BorderWidth = 1
        Me.BPanel5.Controls.Add(Me.ModeText)
        Me.BPanel5.HighlightBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BPanel5.HighlightBorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BPanel5.HighlightNotBackgroundColor = System.Drawing.Color.Empty
        Me.BPanel5.HighlightNotBorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.BPanel5.HighlightOnFocus = True
        Me.BPanel5.Location = New System.Drawing.Point(985, 140)
        Me.BPanel5.Margin = New System.Windows.Forms.Padding(10)
        Me.BPanel5.Name = "BPanel5"
        Me.BPanel5.Padding = New System.Windows.Forms.Padding(21, 8, 8, 8)
        Me.BPanel5.Size = New System.Drawing.Size(260, 136)
        Me.BPanel5.TabIndex = 3
        Me.BPanel5.Title = "Mode"
        '
        'ModeText
        '
        Me.ModeText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ModeText.Font = New System.Drawing.Font("Segoe UI Semibold", 46.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModeText.Location = New System.Drawing.Point(21, 8)
        Me.ModeText.Name = "ModeText"
        Me.ModeText.Size = New System.Drawing.Size(231, 120)
        Me.ModeText.TabIndex = 0
        Me.ModeText.Text = "STORE"
        Me.ModeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ControlBox
        '
        Me.ControlBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlBox.BorderWidth = 1
        Me.ControlBox.Controls.Add(Me.QuitButton)
        Me.ControlBox.HighlightBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ControlBox.HighlightBorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ControlBox.HighlightNotBackgroundColor = System.Drawing.Color.Empty
        Me.ControlBox.HighlightNotBorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.ControlBox.HighlightOnFocus = True
        Me.ControlBox.Location = New System.Drawing.Point(1050, 285)
        Me.ControlBox.Margin = New System.Windows.Forms.Padding(10)
        Me.ControlBox.Name = "ControlBox"
        Me.ControlBox.Padding = New System.Windows.Forms.Padding(21, 8, 8, 8)
        Me.ControlBox.Size = New System.Drawing.Size(195, 457)
        Me.ControlBox.TabIndex = 7
        Me.ControlBox.Title = "Controls"
        '
        'QuitButton
        '
        Me.QuitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.QuitButton.BackColor = System.Drawing.Color.Navy
        Me.QuitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.QuitButton.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitButton.Location = New System.Drawing.Point(24, 313)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(163, 133)
        Me.QuitButton.TabIndex = 7
        Me.QuitButton.Text = "QUIT"
        Me.QuitButton.UseVisualStyleBackColor = False
        '
        'BPanel4
        '
        Me.BPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BPanel4.BorderWidth = 1
        Me.BPanel4.Controls.Add(Me.ItemDetails)
        Me.BPanel4.HighlightBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BPanel4.HighlightBorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BPanel4.HighlightNotBackgroundColor = System.Drawing.Color.Empty
        Me.BPanel4.HighlightNotBorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.BPanel4.HighlightOnFocus = True
        Me.BPanel4.Location = New System.Drawing.Point(328, 285)
        Me.BPanel4.Margin = New System.Windows.Forms.Padding(10)
        Me.BPanel4.Name = "BPanel4"
        Me.BPanel4.Padding = New System.Windows.Forms.Padding(21, 8, 8, 8)
        Me.BPanel4.Size = New System.Drawing.Size(717, 273)
        Me.BPanel4.TabIndex = 4
        Me.BPanel4.Title = "Item Details"
        '
        'ItemDetails
        '
        Me.ItemDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemDetails.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemDetails.Location = New System.Drawing.Point(21, 8)
        Me.ItemDetails.Name = "ItemDetails"
        Me.ItemDetails.Size = New System.Drawing.Size(688, 257)
        Me.ItemDetails.TabIndex = 1
        Me.ItemDetails.Text = "Please Wait"
        Me.ItemDetails.UseMnemonic = False
        '
        'BPanel3
        '
        Me.BPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BPanel3.BorderWidth = 1
        Me.BPanel3.Controls.Add(Me.History)
        Me.BPanel3.HighlightBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BPanel3.HighlightBorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BPanel3.HighlightNotBackgroundColor = System.Drawing.Color.Empty
        Me.BPanel3.HighlightNotBorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.BPanel3.HighlightOnFocus = True
        Me.BPanel3.Location = New System.Drawing.Point(19, 285)
        Me.BPanel3.Margin = New System.Windows.Forms.Padding(10)
        Me.BPanel3.Name = "BPanel3"
        Me.BPanel3.Padding = New System.Windows.Forms.Padding(21, 8, 8, 8)
        Me.BPanel3.Size = New System.Drawing.Size(304, 457)
        Me.BPanel3.TabIndex = 3
        Me.BPanel3.Title = "History"
        '
        'History
        '
        Me.History.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.History.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.History.Dock = System.Windows.Forms.DockStyle.Fill
        Me.History.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.History.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.History.Location = New System.Drawing.Point(21, 8)
        Me.History.Multiline = True
        Me.History.Name = "History"
        Me.History.Size = New System.Drawing.Size(275, 441)
        Me.History.TabIndex = 0
        Me.History.Text = "==========================="
        '
        'BPanel2
        '
        Me.BPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BPanel2.BorderWidth = 1
        Me.BPanel2.Controls.Add(Me.Instruction)
        Me.BPanel2.HighlightBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BPanel2.HighlightBorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BPanel2.HighlightNotBackgroundColor = System.Drawing.Color.Empty
        Me.BPanel2.HighlightNotBorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.BPanel2.HighlightOnFocus = True
        Me.BPanel2.Location = New System.Drawing.Point(19, 140)
        Me.BPanel2.Margin = New System.Windows.Forms.Padding(10)
        Me.BPanel2.Name = "BPanel2"
        Me.BPanel2.Padding = New System.Windows.Forms.Padding(21, 8, 8, 8)
        Me.BPanel2.Size = New System.Drawing.Size(961, 136)
        Me.BPanel2.TabIndex = 2
        Me.BPanel2.Title = "Instruction"
        '
        'Instruction
        '
        Me.Instruction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Instruction.Font = New System.Drawing.Font("Segoe UI", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Instruction.Location = New System.Drawing.Point(21, 8)
        Me.Instruction.Name = "Instruction"
        Me.Instruction.Size = New System.Drawing.Size(932, 120)
        Me.Instruction.TabIndex = 0
        Me.Instruction.Text = "Please Wait"
        Me.Instruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BPanel1
        '
        Me.BPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BPanel1.BorderWidth = 1
        Me.BPanel1.Controls.Add(Me.ScanTarget)
        Me.BPanel1.HighlightBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BPanel1.HighlightBorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BPanel1.HighlightNotBackgroundColor = System.Drawing.Color.Empty
        Me.BPanel1.HighlightNotBorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.BPanel1.HighlightOnFocus = True
        Me.BPanel1.Location = New System.Drawing.Point(19, 17)
        Me.BPanel1.Margin = New System.Windows.Forms.Padding(10)
        Me.BPanel1.Name = "BPanel1"
        Me.BPanel1.Padding = New System.Windows.Forms.Padding(21, 8, 8, 8)
        Me.BPanel1.Size = New System.Drawing.Size(1226, 116)
        Me.BPanel1.TabIndex = 1
        Me.BPanel1.Title = "Scan Here"
        '
        'ScanTarget
        '
        Me.ScanTarget.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ScanTarget.BackColor = System.Drawing.Color.Black
        Me.ScanTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ScanTarget.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScanTarget.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ScanTarget.Location = New System.Drawing.Point(24, 11)
        Me.ScanTarget.Name = "ScanTarget"
        Me.ScanTarget.Size = New System.Drawing.Size(1191, 93)
        Me.ScanTarget.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 761)
        Me.Controls.Add(Me.BPanel6)
        Me.Controls.Add(Me.BPanel5)
        Me.Controls.Add(Me.ControlBox)
        Me.Controls.Add(Me.BPanel4)
        Me.Controls.Add(Me.BPanel3)
        Me.Controls.Add(Me.BPanel2)
        Me.Controls.Add(Me.BPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Location Modifier"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BPanel6.ResumeLayout(False)
        Me.BPanel5.ResumeLayout(False)
        Me.ControlBox.ResumeLayout(False)
        Me.BPanel4.ResumeLayout(False)
        Me.BPanel3.ResumeLayout(False)
        Me.BPanel3.PerformLayout()
        Me.BPanel2.ResumeLayout(False)
        Me.BPanel1.ResumeLayout(False)
        Me.BPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ScanTarget As TextBox
    Friend WithEvents BPanel1 As WHLClasses.Controls.BPanel
    Friend WithEvents BPanel2 As WHLClasses.Controls.BPanel
    Friend WithEvents Instruction As Label
    Friend WithEvents BPanel3 As WHLClasses.Controls.BPanel
    Friend WithEvents History As TextBox
    Friend WithEvents StartTimer As Timer
    Friend WithEvents BPanel4 As WHLClasses.Controls.BPanel
    Friend WithEvents ItemDetails As Label
    Friend WithEvents ControlBox As WHLClasses.Controls.BPanel
    Friend WithEvents QuitButton As Button
    Friend WithEvents BPanel5 As WHLClasses.Controls.BPanel
    Friend WithEvents ModeText As Label
    Friend WithEvents BPanel6 As WHLClasses.Controls.BPanel
    Friend WithEvents StoreLocations As Label
    Friend WithEvents PickLocation As Label
End Class
