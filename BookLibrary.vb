Public Class BookLibrary
    Dim _drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub drag_panel_MouseMove(sender As Object, e As MouseEventArgs) Handles drag_panel.MouseMove
        If _drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex

        End If
    End Sub

    Private Sub drag_panel_MouseUp(sender As Object, e As MouseEventArgs) Handles drag_panel.MouseUp
        _drag = False
    End Sub

    Private Sub drag_panel_MouseDown(sender As Object, e As MouseEventArgs) Handles drag_panel.MouseDown
        _drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
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

    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        Me.Close()
        Main.Show()

    End Sub

End Class