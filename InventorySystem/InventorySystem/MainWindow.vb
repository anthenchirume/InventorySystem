Public Class MainWindow

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    

    Private Sub ChangeActiveUserToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ChangeActiveUserToolStripMenuItem.Click
        LoginDialogue.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        LoginDialogue.Close()
    End Sub
End Class