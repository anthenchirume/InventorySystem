<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeActiveUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchasesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdersReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FAQToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbxBottomPanel = New System.Windows.Forms.GroupBox()
        Me.LblLoggedAs = New System.Windows.Forms.Label()
        Me.LblTime = New System.Windows.Forms.Label()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.LblCurrentUser = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GbxBottomPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.NewToolStripMenuItem, Me.RunToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeActiveUserToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'ChangeActiveUserToolStripMenuItem
        '
        Me.ChangeActiveUserToolStripMenuItem.BackColor = System.Drawing.Color.Bisque
        Me.ChangeActiveUserToolStripMenuItem.Name = "ChangeActiveUserToolStripMenuItem"
        Me.ChangeActiveUserToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ChangeActiveUserToolStripMenuItem.Text = "Change Active User"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.Color.Bisque
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PurchaseToolStripMenuItem, Me.OrderToolStripMenuItem, Me.ItemsToolStripMenuItem, Me.UserToolStripMenuItem})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.NewToolStripMenuItem.Text = "Edit"
        '
        'PurchaseToolStripMenuItem
        '
        Me.PurchaseToolStripMenuItem.BackColor = System.Drawing.Color.Bisque
        Me.PurchaseToolStripMenuItem.Name = "PurchaseToolStripMenuItem"
        Me.PurchaseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PurchaseToolStripMenuItem.Text = "Purchase"
        '
        'OrderToolStripMenuItem
        '
        Me.OrderToolStripMenuItem.BackColor = System.Drawing.Color.Bisque
        Me.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem"
        Me.OrderToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OrderToolStripMenuItem.Text = "Dispatch"
        '
        'ItemsToolStripMenuItem
        '
        Me.ItemsToolStripMenuItem.BackColor = System.Drawing.Color.Bisque
        Me.ItemsToolStripMenuItem.Name = "ItemsToolStripMenuItem"
        Me.ItemsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ItemsToolStripMenuItem.Text = "Items"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.BackColor = System.Drawing.Color.Bisque
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UserToolStripMenuItem.Text = "Users"
        '
        'RunToolStripMenuItem
        '
        Me.RunToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PurchasesReportToolStripMenuItem, Me.OrdersReportToolStripMenuItem})
        Me.RunToolStripMenuItem.Name = "RunToolStripMenuItem"
        Me.RunToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.RunToolStripMenuItem.Text = "Run"
        '
        'PurchasesReportToolStripMenuItem
        '
        Me.PurchasesReportToolStripMenuItem.BackColor = System.Drawing.Color.Bisque
        Me.PurchasesReportToolStripMenuItem.Name = "PurchasesReportToolStripMenuItem"
        Me.PurchasesReportToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.PurchasesReportToolStripMenuItem.Text = "Purchases Report"
        '
        'OrdersReportToolStripMenuItem
        '
        Me.OrdersReportToolStripMenuItem.BackColor = System.Drawing.Color.Bisque
        Me.OrdersReportToolStripMenuItem.Name = "OrdersReportToolStripMenuItem"
        Me.OrdersReportToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.OrdersReportToolStripMenuItem.Text = "Dispatch Report"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FAQToolStripMenuItem, Me.HowToToolStripMenuItem, Me.AboutToolStripMenuItem, Me.AboutToolStripMenuItem1})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'FAQToolStripMenuItem
        '
        Me.FAQToolStripMenuItem.BackColor = System.Drawing.Color.Bisque
        Me.FAQToolStripMenuItem.Name = "FAQToolStripMenuItem"
        Me.FAQToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.FAQToolStripMenuItem.Text = "FAQ"
        '
        'HowToToolStripMenuItem
        '
        Me.HowToToolStripMenuItem.BackColor = System.Drawing.Color.Bisque
        Me.HowToToolStripMenuItem.Name = "HowToToolStripMenuItem"
        Me.HowToToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.HowToToolStripMenuItem.Text = "How To.."
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.BackColor = System.Drawing.Color.Bisque
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.AboutToolStripMenuItem.Text = "Feedback"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.BackColor = System.Drawing.Color.Bisque
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(124, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'GbxBottomPanel
        '
        Me.GbxBottomPanel.BackColor = System.Drawing.Color.Bisque
        Me.GbxBottomPanel.Controls.Add(Me.LblLoggedAs)
        Me.GbxBottomPanel.Controls.Add(Me.LblTime)
        Me.GbxBottomPanel.Controls.Add(Me.LblDate)
        Me.GbxBottomPanel.Controls.Add(Me.LblCurrentUser)
        Me.GbxBottomPanel.ForeColor = System.Drawing.Color.DimGray
        Me.GbxBottomPanel.Location = New System.Drawing.Point(12, 622)
        Me.GbxBottomPanel.Name = "GbxBottomPanel"
        Me.GbxBottomPanel.Size = New System.Drawing.Size(960, 27)
        Me.GbxBottomPanel.TabIndex = 1
        Me.GbxBottomPanel.TabStop = False
        '
        'LblLoggedAs
        '
        Me.LblLoggedAs.AutoSize = True
        Me.LblLoggedAs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLoggedAs.Location = New System.Drawing.Point(563, 11)
        Me.LblLoggedAs.Name = "LblLoggedAs"
        Me.LblLoggedAs.Size = New System.Drawing.Size(84, 13)
        Me.LblLoggedAs.TabIndex = 4
        Me.LblLoggedAs.Text = "Logged in as:"
        '
        'LblTime
        '
        Me.LblTime.AutoSize = True
        Me.LblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTime.Location = New System.Drawing.Point(800, 11)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(34, 13)
        Me.LblTime.TabIndex = 3
        Me.LblTime.Text = "Time"
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDate.Location = New System.Drawing.Point(915, 11)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(34, 13)
        Me.LblDate.TabIndex = 3
        Me.LblDate.Text = "Date"
        '
        'LblCurrentUser
        '
        Me.LblCurrentUser.AutoSize = True
        Me.LblCurrentUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCurrentUser.Location = New System.Drawing.Point(653, 11)
        Me.LblCurrentUser.Name = "LblCurrentUser"
        Me.LblCurrentUser.Size = New System.Drawing.Size(78, 13)
        Me.LblCurrentUser.TabIndex = 2
        Me.LblCurrentUser.Text = "Current User"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.GbxBottomPanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InveSys"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GbxBottomPanel.ResumeLayout(False)
        Me.GbxBottomPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchasesReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdersReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FAQToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HowToToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeActiveUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GbxBottomPanel As System.Windows.Forms.GroupBox
    Friend WithEvents LblLoggedAs As System.Windows.Forms.Label
    Friend WithEvents LblTime As System.Windows.Forms.Label
    Friend WithEvents LblDate As System.Windows.Forms.Label
    Friend WithEvents LblCurrentUser As System.Windows.Forms.Label
    Friend WithEvents ItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
