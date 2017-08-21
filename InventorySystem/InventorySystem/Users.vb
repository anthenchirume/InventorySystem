Public Class Users

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnNewUser_Click(sender As Object, e As EventArgs) Handles BtnNewUser.Click
        AddUser.Show()
    End Sub

    Private Sub BtnEditUser_Click(sender As Object, e As EventArgs) Handles BtnEditUser.Click
        EditUser.Show()
    End Sub
End Class