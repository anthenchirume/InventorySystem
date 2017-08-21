<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
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
        Me.LvAllUsers = New System.Windows.Forms.ListView()
        Me.BtnNewUser = New System.Windows.Forms.Button()
        Me.BtnDeletUser = New System.Windows.Forms.Button()
        Me.BtnEditUser = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LvAllUsers
        '
        Me.LvAllUsers.BackColor = System.Drawing.Color.Bisque
        Me.LvAllUsers.Location = New System.Drawing.Point(13, 13)
        Me.LvAllUsers.Name = "LvAllUsers"
        Me.LvAllUsers.Size = New System.Drawing.Size(159, 236)
        Me.LvAllUsers.TabIndex = 0
        Me.LvAllUsers.UseCompatibleStateImageBehavior = False
        '
        'BtnNewUser
        '
        Me.BtnNewUser.Location = New System.Drawing.Point(194, 24)
        Me.BtnNewUser.Name = "BtnNewUser"
        Me.BtnNewUser.Size = New System.Drawing.Size(80, 25)
        Me.BtnNewUser.TabIndex = 1
        Me.BtnNewUser.Text = "New"
        Me.BtnNewUser.UseVisualStyleBackColor = True
        '
        'BtnDeletUser
        '
        Me.BtnDeletUser.Location = New System.Drawing.Point(194, 86)
        Me.BtnDeletUser.Name = "BtnDeletUser"
        Me.BtnDeletUser.Size = New System.Drawing.Size(80, 25)
        Me.BtnDeletUser.TabIndex = 1
        Me.BtnDeletUser.Text = "Delete"
        Me.BtnDeletUser.UseVisualStyleBackColor = True
        '
        'BtnEditUser
        '
        Me.BtnEditUser.Location = New System.Drawing.Point(194, 55)
        Me.BtnEditUser.Name = "BtnEditUser"
        Me.BtnEditUser.Size = New System.Drawing.Size(80, 25)
        Me.BtnEditUser.TabIndex = 1
        Me.BtnEditUser.Text = "Edit"
        Me.BtnEditUser.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(194, 117)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(80, 25)
        Me.BtnCancel.TabIndex = 1
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.BtnEditUser)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnDeletUser)
        Me.Controls.Add(Me.BtnNewUser)
        Me.Controls.Add(Me.LvAllUsers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Users"
        Me.Text = "Users"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LvAllUsers As System.Windows.Forms.ListView
    Friend WithEvents BtnNewUser As System.Windows.Forms.Button
    Friend WithEvents BtnDeletUser As System.Windows.Forms.Button
    Friend WithEvents BtnEditUser As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
End Class
