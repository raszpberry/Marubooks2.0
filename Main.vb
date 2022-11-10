Public Class Main
    Dim _drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()

    End Sub

    Private Sub drag_panel_MouseDown(sender As Object, e As MouseEventArgs) Handles drag_panel.MouseDown
        _drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub drag_panel_MouseUp(sender As Object, e As MouseEventArgs) Handles drag_panel.MouseUp
        _drag = False
    End Sub

    Private Sub drag_panel_MouseMove(sender As Object, e As MouseEventArgs) Handles drag_panel.MouseMove
        If _drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex

        End If
    End Sub

    Private Sub pnl_close_MouseHover(sender As Object, e As EventArgs) Handles pnl_close.MouseHover
        pnl_close.BackColor = Color.FromArgb(181, 54, 54)
        lbl_close.ForeColor = Color.White
    End Sub

    Private Sub lbl_close_MouseHover(sender As Object, e As EventArgs) Handles lbl_close.MouseHover
        lbl_close.ForeColor = Color.White
        pnl_close.BackColor = Color.FromArgb(181, 54, 54)
    End Sub

    Private Sub pnl_close_MouseLeave(sender As Object, e As EventArgs) Handles pnl_close.MouseLeave
        pnl_close.BackColor = Color.FromArgb(111, 120, 232)
    End Sub

    Private Sub lbl_close_MouseLeave(sender As Object, e As EventArgs) Handles lbl_close.MouseLeave
        lbl_close.ForeColor = Color.DarkGray
        pnl_close.BackColor = Color.FromArgb(111, 120, 232)
    End Sub

    Private Sub btn_exit_MouseHover(sender As Object, e As EventArgs) Handles btn_exit.MouseHover
        btn_exit.ForeColor = Color.White
    End Sub

    Private Sub btn_login_MouseHover(sender As Object, e As EventArgs) Handles btn_login.MouseHover
        btn_login.ForeColor = Color.White
    End Sub
    Private Sub btn_exit_MouseLeave(sender As Object, e As EventArgs) Handles btn_exit.MouseLeave
        btn_exit.ForeColor = Color.Black
    End Sub

    Private Sub btn_login_MouseLeave(sender As Object, e As EventArgs) Handles btn_login.MouseLeave
        btn_login.ForeColor = Color.Black
    End Sub

    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        Me.Close()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        openConnect()

        If String.IsNullOrEmpty(tb_usr.Text.Trim()) Or String.IsNullOrEmpty(tb_pass.Text.Trim()) Then
            MessageBox.Show("Please input Username and Password", "Marubooks", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Exit Sub
        End If

        DBModule.openConnect()

        Try
            DBModule.com.CommandText = "SELECT * FROM `admin` WHERE `username`= @username AND `password`=@password"
            DBModule.com.Parameters.Clear()
            DBModule.com.Parameters.AddWithValue("username", tb_usr.Text.Trim())
            DBModule.com.Parameters.AddWithValue("password", tb_pass.Text.Trim())

            Using rd = DBModule.com.ExecuteReader()
                If rd.HasRows Then
                    While rd.Read
                        DBModule.currentUsername = Convert.ToString(rd("username"))
                        DBModule.currentPassword = Convert.ToString(rd("password"))

                    End While
                    tb_usr.Clear()
                    tb_pass.Clear()


                    MessageBox.Show("Welcome " & currentUsername, "Marubooks")
                    Me.Hide()
                    BookLibrary.Show()

                Else
                    tb_usr.Clear()
                    tb_pass.Clear()
                    MessageBox.Show("Incorrect Username or Password ", "Marubooks", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Marubooks", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DBModule.closeConnect()

        End Try

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcceptButton = btn_login

    End Sub


End Class
