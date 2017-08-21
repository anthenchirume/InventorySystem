Public Class MainWindow

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 
    End Sub

    

    Private Sub ChangeActiveUserToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ChangeActiveUserToolStripMenuItem.Click
        Me.Close()
        LoginDialogue.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        LoginDialogue.Close()
    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        Users.Show()
    End Sub

    Private Sub ItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemsToolStripMenuItem.Click
        Items.Show()
    End Sub

    Private Sub PurchaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseToolStripMenuItem.Click
        Purchase.Show()

    End Sub
End Class