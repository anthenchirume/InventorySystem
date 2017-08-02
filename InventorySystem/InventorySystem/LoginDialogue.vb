Imports MySql.Data.MySqlClient
Public Class LoginDialogue

    Dim mysqlconn As MySqlConnection
    Dim command As MySqlCommand

    Private Sub LoginDialogue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InventoryDataSet.security' table. You can move, or remove it, as needed.
        'Me.SecurityTableAdapter.Fill(Me.InventoryDataSet.security)
        mysqlconn = New MySqlConnection

        mysqlconn.ConnectionString =
        "server=localhost;userid=root;password=@Adneshia94;database=inventory"
        Dim reader As MySqlDataReader

        Try
            mysqlconn.Open()
            Dim query As String
            query = "select username from inventory.security "
            command = New MySqlCommand(query, mysqlconn)
            reader = command.ExecuteReader


            While reader.Read
                ' this line lists all users in database
                ComboBox1.Items.Add(reader.Item(0))
            End While

            mysqlconn.Close()

        Catch ex As MySqlException

            MessageBox.Show(ex.Message)
        Finally
            mysqlconn.Dispose()

        End Try
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        mysqlconn = New MySqlConnection

        mysqlconn.ConnectionString =
        "server=localhost;userid=root;password=@Adneshia94;database=inventory"
        Dim reader As MySqlDataReader

        Try
            mysqlconn.Open()
            Dim query As String
            query = "select * from inventory.security where username='" & ComboBox1.Text & "' and password = '" & TbxPassword.Text & "' "
            command = New MySqlCommand(query, mysqlconn)
            reader = command.ExecuteReader
            Dim count As Integer

            count = 0
            While reader.Read
                count = count + 1
            End While

            If count = 1 Then
                ' MessageBox.Show("Username and password are correct")
                Me.Hide()
                MainWindow.Show()

            Else
                MessageBox.Show("Incorrect username and password !!!")

            End If

            mysqlconn.Close()

        Catch ex As MySqlException

            MessageBox.Show(ex.Message)
        Finally
            mysqlconn.Dispose()

        End Try

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TbxPassword.Text = ""
        ComboBox1.Text = ""
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
    Private Sub TbxUsername_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
