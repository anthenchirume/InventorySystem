<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purchase
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
        Me.GboxDetails = New System.Windows.Forms.GroupBox()
        Me.LblInvoiceNo = New System.Windows.Forms.Label()
        Me.LblLocation = New System.Windows.Forms.Label()
        Me.LblPartner = New System.Windows.Forms.Label()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.GboxItems = New System.Windows.Forms.GroupBox()
        Me.CbxPartner = New System.Windows.Forms.ComboBox()
        Me.TbxInvoiceNo = New System.Windows.Forms.TextBox()
        Me.CbxLocation = New System.Windows.Forms.ComboBox()
        Me.CbxUser = New System.Windows.Forms.ComboBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GboxDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'GboxDetails
        '
        Me.GboxDetails.Controls.Add(Me.TbxInvoiceNo)
        Me.GboxDetails.Controls.Add(Me.CbxLocation)
        Me.GboxDetails.Controls.Add(Me.CbxUser)
        Me.GboxDetails.Controls.Add(Me.CbxPartner)
        Me.GboxDetails.Controls.Add(Me.LblInvoiceNo)
        Me.GboxDetails.Controls.Add(Me.LblLocation)
        Me.GboxDetails.Controls.Add(Me.LblPartner)
        Me.GboxDetails.Controls.Add(Me.LblUser)
        Me.GboxDetails.Location = New System.Drawing.Point(12, 12)
        Me.GboxDetails.Name = "GboxDetails"
        Me.GboxDetails.Size = New System.Drawing.Size(412, 144)
        Me.GboxDetails.TabIndex = 0
        Me.GboxDetails.TabStop = False
        Me.GboxDetails.Text = "Details"
        '
        'LblInvoiceNo
        '
        Me.LblInvoiceNo.AutoSize = True
        Me.LblInvoiceNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvoiceNo.Location = New System.Drawing.Point(6, 112)
        Me.LblInvoiceNo.Name = "LblInvoiceNo"
        Me.LblInvoiceNo.Size = New System.Drawing.Size(74, 15)
        Me.LblInvoiceNo.TabIndex = 1
        Me.LblInvoiceNo.Text = "Invoice No"
        '
        'LblLocation
        '
        Me.LblLocation.AutoSize = True
        Me.LblLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLocation.Location = New System.Drawing.Point(6, 49)
        Me.LblLocation.Name = "LblLocation"
        Me.LblLocation.Size = New System.Drawing.Size(62, 15)
        Me.LblLocation.TabIndex = 1
        Me.LblLocation.Text = "Location"
        '
        'LblPartner
        '
        Me.LblPartner.AutoSize = True
        Me.LblPartner.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPartner.Location = New System.Drawing.Point(6, 84)
        Me.LblPartner.Name = "LblPartner"
        Me.LblPartner.Size = New System.Drawing.Size(54, 15)
        Me.LblPartner.TabIndex = 1
        Me.LblPartner.Text = "Partner"
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUser.Location = New System.Drawing.Point(6, 16)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(37, 15)
        Me.LblUser.TabIndex = 1
        Me.LblUser.Text = "User"
        '
        'GboxItems
        '
        Me.GboxItems.BackColor = System.Drawing.Color.Bisque
        Me.GboxItems.Location = New System.Drawing.Point(12, 162)
        Me.GboxItems.Name = "GboxItems"
        Me.GboxItems.Size = New System.Drawing.Size(949, 337)
        Me.GboxItems.TabIndex = 0
        Me.GboxItems.TabStop = False
        Me.GboxItems.Text = "Items"
        '
        'CbxPartner
        '
        Me.CbxPartner.BackColor = System.Drawing.Color.Bisque
        Me.CbxPartner.FormattingEnabled = True
        Me.CbxPartner.Location = New System.Drawing.Point(86, 78)
        Me.CbxPartner.Name = "CbxPartner"
        Me.CbxPartner.Size = New System.Drawing.Size(121, 21)
        Me.CbxPartner.TabIndex = 1
        '
        'TbxInvoiceNo
        '
        Me.TbxInvoiceNo.BackColor = System.Drawing.Color.Bisque
        Me.TbxInvoiceNo.Location = New System.Drawing.Point(86, 107)
        Me.TbxInvoiceNo.Name = "TbxInvoiceNo"
        Me.TbxInvoiceNo.Size = New System.Drawing.Size(121, 20)
        Me.TbxInvoiceNo.TabIndex = 2
        '
        'CbxLocation
        '
        Me.CbxLocation.BackColor = System.Drawing.Color.Bisque
        Me.CbxLocation.FormattingEnabled = True
        Me.CbxLocation.Location = New System.Drawing.Point(86, 43)
        Me.CbxLocation.Name = "CbxLocation"
        Me.CbxLocation.Size = New System.Drawing.Size(121, 21)
        Me.CbxLocation.TabIndex = 1
        '
        'CbxUser
        '
        Me.CbxUser.BackColor = System.Drawing.Color.Bisque
        Me.CbxUser.FormattingEnabled = True
        Me.CbxUser.Location = New System.Drawing.Point(86, 10)
        Me.CbxUser.Name = "CbxUser"
        Me.CbxUser.Size = New System.Drawing.Size(121, 21)
        Me.CbxUser.TabIndex = 1
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(886, 505)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 1
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(805, 505)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Purchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(973, 532)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.GboxItems)
        Me.Controls.Add(Me.GboxDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Purchase"
        Me.Text = "Purchase"
        Me.GboxDetails.ResumeLayout(False)
        Me.GboxDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GboxDetails As System.Windows.Forms.GroupBox
    Friend WithEvents LblInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents LblLocation As System.Windows.Forms.Label
    Friend WithEvents LblPartner As System.Windows.Forms.Label
    Friend WithEvents LblUser As System.Windows.Forms.Label
    Friend WithEvents GboxItems As System.Windows.Forms.GroupBox
    Friend WithEvents TbxInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents CbxLocation As System.Windows.Forms.ComboBox
    Friend WithEvents CbxUser As System.Windows.Forms.ComboBox
    Friend WithEvents CbxPartner As System.Windows.Forms.ComboBox
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
End Class
