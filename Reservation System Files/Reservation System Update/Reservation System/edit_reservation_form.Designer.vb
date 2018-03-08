<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edit_reservation_form
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
        Me.b_about = New System.Windows.Forms.Button()
        Me.b_edit_reservation = New System.Windows.Forms.Button()
        Me.b_ovaerall_sched = New System.Windows.Forms.Button()
        Me.b_reservation = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.close_label = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.b_edit = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.t_id_number = New System.Windows.Forms.TextBox()
        Me.b_home = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'b_about
        '
        Me.b_about.BackColor = System.Drawing.Color.Transparent
        Me.b_about.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green
        Me.b_about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_about.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_about.ForeColor = System.Drawing.Color.Transparent
        Me.b_about.Location = New System.Drawing.Point(11, 552)
        Me.b_about.Name = "b_about"
        Me.b_about.Size = New System.Drawing.Size(163, 53)
        Me.b_about.TabIndex = 20
        Me.b_about.Text = "About" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.b_about.UseVisualStyleBackColor = False
        '
        'b_edit_reservation
        '
        Me.b_edit_reservation.BackColor = System.Drawing.Color.Transparent
        Me.b_edit_reservation.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green
        Me.b_edit_reservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_edit_reservation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_edit_reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_edit_reservation.ForeColor = System.Drawing.Color.Transparent
        Me.b_edit_reservation.Location = New System.Drawing.Point(12, 203)
        Me.b_edit_reservation.Name = "b_edit_reservation"
        Me.b_edit_reservation.Size = New System.Drawing.Size(163, 53)
        Me.b_edit_reservation.TabIndex = 19
        Me.b_edit_reservation.Text = "Delete Reservation"
        Me.b_edit_reservation.UseVisualStyleBackColor = False
        '
        'b_ovaerall_sched
        '
        Me.b_ovaerall_sched.BackColor = System.Drawing.Color.Transparent
        Me.b_ovaerall_sched.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green
        Me.b_ovaerall_sched.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_ovaerall_sched.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_ovaerall_sched.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_ovaerall_sched.ForeColor = System.Drawing.Color.Transparent
        Me.b_ovaerall_sched.Location = New System.Drawing.Point(12, 144)
        Me.b_ovaerall_sched.Name = "b_ovaerall_sched"
        Me.b_ovaerall_sched.Size = New System.Drawing.Size(163, 53)
        Me.b_ovaerall_sched.TabIndex = 18
        Me.b_ovaerall_sched.Text = "Overall Sched" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.b_ovaerall_sched.UseVisualStyleBackColor = False
        '
        'b_reservation
        '
        Me.b_reservation.BackColor = System.Drawing.Color.Transparent
        Me.b_reservation.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green
        Me.b_reservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_reservation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_reservation.ForeColor = System.Drawing.Color.Transparent
        Me.b_reservation.Location = New System.Drawing.Point(12, 85)
        Me.b_reservation.Margin = New System.Windows.Forms.Padding(0)
        Me.b_reservation.Name = "b_reservation"
        Me.b_reservation.Size = New System.Drawing.Size(163, 53)
        Me.b_reservation.TabIndex = 17
        Me.b_reservation.Text = "Reservation"
        Me.b_reservation.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 28)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Rooms Reservation"
        '
        'close_label
        '
        Me.close_label.AutoSize = True
        Me.close_label.BackColor = System.Drawing.Color.Transparent
        Me.close_label.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close_label.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close_label.ForeColor = System.Drawing.Color.White
        Me.close_label.Location = New System.Drawing.Point(1101, 6)
        Me.close_label.Name = "close_label"
        Me.close_label.Size = New System.Drawing.Size(30, 32)
        Me.close_label.TabIndex = 15
        Me.close_label.Text = "x"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.b_edit)
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.t_id_number)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox1.Location = New System.Drawing.Point(196, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(935, 555)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search and Delete Reservation"
        '
        'b_edit
        '
        Me.b_edit.BackColor = System.Drawing.Color.Transparent
        Me.b_edit.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green_sq
        Me.b_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_edit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_edit.ForeColor = System.Drawing.Color.Transparent
        Me.b_edit.Location = New System.Drawing.Point(755, 52)
        Me.b_edit.Margin = New System.Windows.Forms.Padding(0)
        Me.b_edit.Name = "b_edit"
        Me.b_edit.Size = New System.Drawing.Size(150, 45)
        Me.b_edit.TabIndex = 3
        Me.b_edit.Text = "Delete"
        Me.b_edit.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.Honeydew
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListView1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(36, 122)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(869, 427)
        Me.ListView1.TabIndex = 9
        Me.ListView1.TileSize = New System.Drawing.Size(5, 5)
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Room #"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Reserved Date"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 130
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "IN"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 120
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "OUT"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 120
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "# of occupants"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 130
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Purpose"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 120
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Organization"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 120
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Reservation_System.My.Resources.Resources.search_01
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(508, 62)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = False
        '
        't_id_number
        '
        Me.t_id_number.BackColor = System.Drawing.Color.Honeydew
        Me.t_id_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.t_id_number.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_id_number.ForeColor = System.Drawing.Color.DarkGreen
        Me.t_id_number.Location = New System.Drawing.Point(36, 62)
        Me.t_id_number.Name = "t_id_number"
        Me.t_id_number.Size = New System.Drawing.Size(452, 31)
        Me.t_id_number.TabIndex = 1
        '
        'b_home
        '
        Me.b_home.BackColor = System.Drawing.Color.Transparent
        Me.b_home.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green
        Me.b_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_home.ForeColor = System.Drawing.Color.Transparent
        Me.b_home.Location = New System.Drawing.Point(11, 493)
        Me.b_home.Name = "b_home"
        Me.b_home.Size = New System.Drawing.Size(163, 53)
        Me.b_home.TabIndex = 23
        Me.b_home.Text = "Home"
        Me.b_home.UseVisualStyleBackColor = False
        '
        'edit_reservation_form
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Reservation_System.My.Resources.Resources.bg_main_admin1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1143, 619)
        Me.Controls.Add(Me.b_home)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.b_about)
        Me.Controls.Add(Me.b_edit_reservation)
        Me.Controls.Add(Me.b_ovaerall_sched)
        Me.Controls.Add(Me.b_reservation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.close_label)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkGreen
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximumSize = New System.Drawing.Size(1143, 619)
        Me.MinimumSize = New System.Drawing.Size(1143, 619)
        Me.Name = "edit_reservation_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "edit_reservation_form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents b_about As System.Windows.Forms.Button
    Friend WithEvents b_edit_reservation As System.Windows.Forms.Button
    Friend WithEvents b_ovaerall_sched As System.Windows.Forms.Button
    Friend WithEvents b_reservation As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents close_label As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents t_id_number As System.Windows.Forms.TextBox
    Friend WithEvents b_home As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents b_edit As System.Windows.Forms.Button
End Class
