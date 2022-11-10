Imports MySql.Data.MySqlClient
Public Module DBModule
    Public connect As New MySqlConnection()
    Public com As New MySqlCommand("", connect)

    Public currentUsername As String
    Public currentPassword As String

    Public Sub openConnect()
        Try
            If connect.State = ConnectionState.Closed Then
                connect.ConnectionString = "server=localhost;username=root;password=;database=db_marubooks"
                connect.Open()

            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
    Public Sub closeConnect()
        If connect.State = ConnectionState.Open Then
            connect.Close()

        End If
    End Sub

End Module
