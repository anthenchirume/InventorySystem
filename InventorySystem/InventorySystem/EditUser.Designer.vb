<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditUser
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.TbxPassword = New System.Windows.Forms.TextBox()
        Me.TbxUsername = New System.Windows.Forms.TextBox()
        Me.TbxID = New System.Windows.Forms.TextBox()
        Me.LblLevel = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.LblID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Bisque
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Root", "Admin", "Manager", "Operator"})
        Me.ComboBox1.Location = New System.Drawing.Point(87, 162)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(95, 21)
        Me.ComboBox1.TabIndex = 13
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(217, 120)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(97, 32)
        Me.BtnCancel.TabIndex = 11
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(217, 61)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(97, 32)
        Me.BtnSave.TabIndex = 12
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'TbxPassword
        '
        Me.TbxPassword.BackColor = System.Drawing.Color.Bisque
        Me.TbxPassword.Location = New System.Drawing.Point(87, 120)
        Me.TbxPassword.Name = "TbxPassword"
        Me.TbxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbxPassword.Size = New System.Drawing.Size(95, 20)
        Me.TbxPassword.TabIndex = 8
        '
        'TbxUsername
        '
        Me.TbxUsername.BackColor = System.Drawing.Color.Bisque
        Me.TbxUsername.Location = New System.Drawing.Point(87, 73)
        Me.TbxUsername.Name = "TbxUsername"
        Me.TbxUsername.Size = New System.Drawing.Size(95, 20)
        Me.TbxUsername.TabIndex = 9
        '
        'TbxID
        '
        Me.TbxID.BackColor = System.Drawing.Color.Bisque
        Me.TbxID.Location = New System.Drawing.Point(87, 31)
        Me.TbxID.Name = "TbxID"
        Me.TbxID.Size = New System.Drawing.Size(95, 20)
        Me.TbxID.TabIndex = 10
        '
        'LblLevel
        '
        Me.LblLevel.AutoSize = True
        Me.LblLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLevel.Location = New System.Drawing.Point(21, 170)
        Me.LblLevel.Name = "LblLevel"
        Me.LblLevel.Size = New System.Drawing.Size(38, 13)
        Me.LblLevel.TabIndex = 4
        Me.LblLevel.Text = "Level"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.Location = New System.Drawing.Point(21, 127)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(61, 13)
        Me.LblPassword.TabIndex = 5
        Me.LblPassword.Text = "Password"
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsername.Location = New System.Drawing.Point(21, 80)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(63, 13)
        Me.LblUsername.TabIndex = 6
        Me.LblUsername.Text = "Username"
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblID.Location = New System.Drawing.Point(21, 38)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(20, 13)
        Me.LblID.TabIndex = 7
        Me.LblID.Text = "ID"
        '
        'EditUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(342, 196)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TbxPassword)
        Me.Controls.Add(Me.TbxUsername)
        Me.Controls.Add(Me.TbxID)
        Me.Controls.Add(Me.LblLevel)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblUsername)
        Me.Controls.Add(Me.LblID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "EditUser"
        Me.Text = "EditUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents TbxPassword As System.Windows.Forms.TextBox
    Friend WithEvents TbxUsername As System.Windows.Forms.TextBox
    Friend WithEvents TbxID As System.Windows.Forms.TextBox
    Friend WithEvents LblLevel As System.Windows.Forms.Label
    Friend WithEvents LblPassword As System.Windows.Forms.Label
    Friend WithEvents LblUsername As System.Windows.Forms.Label
    Friend WithEvents LblID As System.Windows.Forms.Label
End Class
