<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser
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
        Me.LblID = New System.Windows.Forms.Label()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblLevel = New System.Windows.Forms.Label()
        Me.TbxID = New System.Windows.Forms.TextBox()
        Me.TbxUsername = New System.Windows.Forms.TextBox()
        Me.TbxPassword = New System.Windows.Forms.TextBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.CbxLevel = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblID.Location = New System.Drawing.Point(21, 36)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(20, 13)
        Me.LblID.TabIndex = 0
        Me.LblID.Text = "ID"
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsername.Location = New System.Drawing.Point(21, 78)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(63, 13)
        Me.LblUsername.TabIndex = 0
        Me.LblUsername.Text = "Username"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.Location = New System.Drawing.Point(21, 125)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(61, 13)
        Me.LblPassword.TabIndex = 0
        Me.LblPassword.Text = "Password"
        '
        'LblLevel
        '
        Me.LblLevel.AutoSize = True
        Me.LblLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLevel.Location = New System.Drawing.Point(21, 168)
        Me.LblLevel.Name = "LblLevel"
        Me.LblLevel.Size = New System.Drawing.Size(38, 13)
        Me.LblLevel.TabIndex = 0
        Me.LblLevel.Text = "Level"
        '
        'TbxID
        '
        Me.TbxID.BackColor = System.Drawing.Color.Bisque
        Me.TbxID.Location = New System.Drawing.Point(87, 29)
        Me.TbxID.Name = "TbxID"
        Me.TbxID.Size = New System.Drawing.Size(95, 20)
        Me.TbxID.TabIndex = 1
        '
        'TbxUsername
        '
        Me.TbxUsername.BackColor = System.Drawing.Color.Bisque
        Me.TbxUsername.Location = New System.Drawing.Point(87, 71)
        Me.TbxUsername.Name = "TbxUsername"
        Me.TbxUsername.Size = New System.Drawing.Size(95, 20)
        Me.TbxUsername.TabIndex = 1
        '
        'TbxPassword
        '
        Me.TbxPassword.BackColor = System.Drawing.Color.Bisque
        Me.TbxPassword.Location = New System.Drawing.Point(87, 118)
        Me.TbxPassword.Name = "TbxPassword"
        Me.TbxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbxPassword.Size = New System.Drawing.Size(95, 20)
        Me.TbxPassword.TabIndex = 1
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Location = New System.Drawing.Point(217, 59)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(97, 32)
        Me.BtnAdd.TabIndex = 2
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(217, 118)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(97, 32)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'CbxLevel
        '
        Me.CbxLevel.BackColor = System.Drawing.Color.Bisque
        Me.CbxLevel.FormattingEnabled = True
        Me.CbxLevel.Items.AddRange(New Object() {"Root", "Admin", "Manager", "Operator"})
        Me.CbxLevel.Location = New System.Drawing.Point(87, 160)
        Me.CbxLevel.Name = "CbxLevel"
        Me.CbxLevel.Size = New System.Drawing.Size(95, 21)
        Me.CbxLevel.TabIndex = 3
        '
        'AddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(342, 196)
        Me.Controls.Add(Me.CbxLevel)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.TbxPassword)
        Me.Controls.Add(Me.TbxUsername)
        Me.Controls.Add(Me.TbxID)
        Me.Controls.Add(Me.LblLevel)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblUsername)
        Me.Controls.Add(Me.LblID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AddUser"
        Me.Text = "Add User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblID As System.Windows.Forms.Label
    Friend WithEvents LblUsername As System.Windows.Forms.Label
    Friend WithEvents LblPassword As System.Windows.Forms.Label
    Friend WithEvents LblLevel As System.Windows.Forms.Label
    Friend WithEvents TbxID As System.Windows.Forms.TextBox
    Friend WithEvents TbxUsername As System.Windows.Forms.TextBox
    Friend WithEvents TbxPassword As System.Windows.Forms.TextBox
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents CbxLevel As System.Windows.Forms.ComboBox
End Class
