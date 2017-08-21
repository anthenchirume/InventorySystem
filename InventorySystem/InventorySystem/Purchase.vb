Imports MySql.Data.MySqlClient
Public Class Purchase


    Dim mysqlconn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub Purchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InventoryDataSet.security' table. You can move, or remove it, as needed.
        'Me.SecurityTableAdapter.Fill(Me.InventoryDataSet.security)
        mysqlconn = New MySqlConnection

        mysqlconn.ConnectionString =
        "server=localhost;userid=root;password=@Adneshia94;database=inventory"
        Dim reader As MySqlDataReader

        Try
            mysqlconn.Open()
            Dim query1 As String
            query1 = "select username from inventory.security "
            command = New MySqlCommand(query1, mysqlconn)
            reader = command.ExecuteReader


            While reader.Read
                ' this line lists all users in database
                CbxUser.Items.Add(reader.Item(0))
            End While

            mysqlconn.Close()

        Catch ex As MySqlException

            MessageBox.Show(ex.Message)
        Finally
            mysqlconn.Dispose()

        End Try
        Try
            mysqlconn.Open()
            Dim query2 As String
            query2 = "select name from inventory.locations "
            command = New MySqlCommand(query2, mysqlconn)
            reader = command.ExecuteReader


            While reader.Read
                ' this line lists all users in database
                CbxLocation.Items.Add(reader.Item(0))
            End While

            mysqlconn.Close()

        Catch ex As MySqlException

            MessageBox.Show(ex.Message)
        Finally
            mysqlconn.Dispose()

        End Try
        Try
            mysqlconn.Open()
            Dim query3 As String
            query3 = "select name from inventory.partners "
            command = New MySqlCommand(query3, mysqlconn)
            reader = command.ExecuteReader


            While reader.Read
                ' this line lists all users in database
                CbxPartner.Items.Add(reader.Item(0))
            End While

            mysqlconn.Close()

        Catch ex As MySqlException

            MessageBox.Show(ex.Message)
        Finally
            mysqlconn.Dispose()

        End Try
    End Sub

    Private Sub LblUser_Click(sender As Object, e As EventArgs) Handles LblUser.Click

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class