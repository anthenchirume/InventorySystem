Imports MySql.Data.MySqlClient
Public Class AddUser

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
            Dim query As String
            query = "select level from inventory.security "
            command = New MySqlCommand(query, mysqlconn)
            reader = command.ExecuteReader


            While reader.Read
                ' this line lists all levels in database
                CbxLevel.Items.Add(reader.Item(0))
            End While

            mysqlconn.Close()

        Catch ex As MySqlException

            MessageBox.Show(ex.Message)
        Finally
            mysqlconn.Dispose()

        End Try
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class