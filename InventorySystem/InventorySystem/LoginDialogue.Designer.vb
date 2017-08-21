<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginDialogue
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
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.TbxPassword = New System.Windows.Forms.TextBox()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SecurityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryDataSet = New InventorySystem.inventoryDataSet()
        Me.SecurityTableAdapter = New InventorySystem.inventoryDataSetTableAdapters.securityTableAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.SecurityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsername.Location = New System.Drawing.Point(32, 37)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(62, 18)
        Me.LblUsername.TabIndex = 0
        Me.LblUsername.Text = "Username"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.Location = New System.Drawing.Point(32, 76)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(60, 18)
        Me.LblPassword.TabIndex = 0
        Me.LblPassword.Text = "Password"
        '
        'TbxPassword
        '
        Me.TbxPassword.BackColor = System.Drawing.Color.Bisque
        Me.TbxPassword.Location = New System.Drawing.Point(121, 74)
        Me.TbxPassword.Name = "TbxPassword"
        Me.TbxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbxPassword.Size = New System.Drawing.Size(121, 20)
        Me.TbxPassword.TabIndex = 1
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(109, 117)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(58, 22)
        Me.BtnClear.TabIndex = 4
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(36, 117)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(58, 22)
        Me.BtnLogin.TabIndex = 4
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(184, 117)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(58, 22)
        Me.BtnExit.TabIndex = 4
        Me.BtnExit.Text = "Cancel"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'SecurityBindingSource
        '
        Me.SecurityBindingSource.DataMember = "security"
        Me.SecurityBindingSource.DataSource = Me.InventoryDataSet
        '
        'InventoryDataSet
        '
        Me.InventoryDataSet.DataSetName = "inventoryDataSet"
        Me.InventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SecurityTableAdapter
        '
        Me.SecurityTableAdapter.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Bisque
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(121, 33)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'LoginDialogue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(284, 161)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.TbxPassword)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblUsername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginDialogue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Login"
        CType(Me.SecurityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblUsername As System.Windows.Forms.Label
    Friend WithEvents LblPassword As System.Windows.Forms.Label
    Friend WithEvents TbxPassword As System.Windows.Forms.TextBox
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents InventoryDataSet As InventorySystem.inventoryDataSet
    Friend WithEvents SecurityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SecurityTableAdapter As InventorySystem.inventoryDataSetTableAdapters.securityTableAdapter
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox

End Class
