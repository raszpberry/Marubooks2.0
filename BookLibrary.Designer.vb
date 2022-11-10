<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookLibrary
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
        Me.drag_panel = New System.Windows.Forms.Panel()
        Me.pnl_close = New System.Windows.Forms.Panel()
        Me.lbl_close = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.drag_panel.SuspendLayout()
        Me.pnl_close.SuspendLayout()
        Me.SuspendLayout()
        '
        'drag_panel
        '
        Me.drag_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.drag_panel.Controls.Add(Me.pnl_close)
        Me.drag_panel.Controls.Add(Me.lbl_title)
        Me.drag_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.drag_panel.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drag_panel.Location = New System.Drawing.Point(0, 0)
        Me.drag_panel.Name = "drag_panel"
        Me.drag_panel.Size = New System.Drawing.Size(702, 39)
        Me.drag_panel.TabIndex = 7
        '
        'pnl_close
        '
        Me.pnl_close.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.pnl_close.Controls.Add(Me.lbl_close)
        Me.pnl_close.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl_close.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_close.Location = New System.Drawing.Point(661, 0)
        Me.pnl_close.Name = "pnl_close"
        Me.pnl_close.Size = New System.Drawing.Size(41, 39)
        Me.pnl_close.TabIndex = 7
        '
        'lbl_close
        '
        Me.lbl_close.AutoSize = True
        Me.lbl_close.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_close.ForeColor = System.Drawing.Color.DarkGray
        Me.lbl_close.Location = New System.Drawing.Point(7, 2)
        Me.lbl_close.Name = "lbl_close"
        Me.lbl_close.Size = New System.Drawing.Size(28, 31)
        Me.lbl_close.TabIndex = 2
        Me.lbl_close.Text = "x"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(15, 10)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(206, 19)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Marubooks: Library Database"
        '
        'BookLibrary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 450)
        Me.Controls.Add(Me.drag_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BookLibrary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BookLibrary"
        Me.drag_panel.ResumeLayout(False)
        Me.drag_panel.PerformLayout()
        Me.pnl_close.ResumeLayout(False)
        Me.pnl_close.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents drag_panel As Panel
    Friend WithEvents pnl_close As Panel
    Friend WithEvents lbl_close As Label
    Friend WithEvents lbl_title As Label
End Class
