<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.btn_login = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.tb_pass = New System.Windows.Forms.TextBox()
        Me.tb_usr = New System.Windows.Forms.TextBox()
        Me.lbl_usr = New System.Windows.Forms.Label()
        Me.lbl_pass = New System.Windows.Forms.Label()
        Me.drag_panel = New System.Windows.Forms.Panel()
        Me.pnl_close = New System.Windows.Forms.Panel()
        Me.lbl_close = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_login = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.drag_panel.SuspendLayout()
        Me.pnl_close.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btn_login.FlatAppearance.BorderSize = 0
        Me.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.Black
        Me.btn_login.Location = New System.Drawing.Point(375, 163)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(64, 28)
        Me.btn_login.TabIndex = 3
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Location = New System.Drawing.Point(307, 163)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(64, 28)
        Me.btn_exit.TabIndex = 0
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'tb_pass
        '
        Me.tb_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_pass.Location = New System.Drawing.Point(269, 131)
        Me.tb_pass.Name = "tb_pass"
        Me.tb_pass.Size = New System.Drawing.Size(170, 22)
        Me.tb_pass.TabIndex = 2
        Me.tb_pass.UseSystemPasswordChar = True
        '
        'tb_usr
        '
        Me.tb_usr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_usr.Location = New System.Drawing.Point(269, 103)
        Me.tb_usr.Name = "tb_usr"
        Me.tb_usr.Size = New System.Drawing.Size(170, 22)
        Me.tb_usr.TabIndex = 1
        '
        'lbl_usr
        '
        Me.lbl_usr.AutoSize = True
        Me.lbl_usr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usr.ForeColor = System.Drawing.Color.Black
        Me.lbl_usr.Location = New System.Drawing.Point(188, 103)
        Me.lbl_usr.Name = "lbl_usr"
        Me.lbl_usr.Size = New System.Drawing.Size(74, 16)
        Me.lbl_usr.TabIndex = 4
        Me.lbl_usr.Text = "Username:"
        '
        'lbl_pass
        '
        Me.lbl_pass.AutoSize = True
        Me.lbl_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pass.ForeColor = System.Drawing.Color.Black
        Me.lbl_pass.Location = New System.Drawing.Point(188, 131)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(71, 16)
        Me.lbl_pass.TabIndex = 5
        Me.lbl_pass.Text = "Password:"
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
        Me.drag_panel.Size = New System.Drawing.Size(459, 39)
        Me.drag_panel.TabIndex = 6
        '
        'pnl_close
        '
        Me.pnl_close.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.pnl_close.Controls.Add(Me.lbl_close)
        Me.pnl_close.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_close.Location = New System.Drawing.Point(420, -4)
        Me.pnl_close.Name = "pnl_close"
        Me.pnl_close.Size = New System.Drawing.Size(41, 43)
        Me.pnl_close.TabIndex = 7
        '
        'lbl_close
        '
        Me.lbl_close.AutoSize = True
        Me.lbl_close.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_close.ForeColor = System.Drawing.Color.DarkGray
        Me.lbl_close.Location = New System.Drawing.Point(7, 5)
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
        'lbl_login
        '
        Me.lbl_login.AutoSize = True
        Me.lbl_login.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_login.ForeColor = System.Drawing.Color.Black
        Me.lbl_login.Location = New System.Drawing.Point(182, 58)
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(82, 31)
        Me.lbl_login.TabIndex = 1
        Me.lbl_login.Text = "Login"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Marubooks_v2._0.My.Resources.Resources.Book
        Me.PictureBox1.Location = New System.Drawing.Point(21, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(459, 215)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_login)
        Me.Controls.Add(Me.drag_panel)
        Me.Controls.Add(Me.lbl_pass)
        Me.Controls.Add(Me.lbl_usr)
        Me.Controls.Add(Me.tb_usr)
        Me.Controls.Add(Me.tb_pass)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.drag_panel.ResumeLayout(False)
        Me.drag_panel.PerformLayout()
        Me.pnl_close.ResumeLayout(False)
        Me.pnl_close.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_login As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents tb_pass As TextBox
    Friend WithEvents tb_usr As TextBox
    Friend WithEvents lbl_usr As Label
    Friend WithEvents lbl_pass As Label
    Friend WithEvents drag_panel As Panel
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_login As Label
    Friend WithEvents lbl_close As Label
    Friend WithEvents pnl_close As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
