<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_equip
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.b_add = New System.Windows.Forms.Button()
        Me.l_time_show = New System.Windows.Forms.Label()
        Me.l_date_show = New System.Windows.Forms.Label()
        Me.b_edit = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.b_reports = New System.Windows.Forms.Button()
        Me.l_day_show = New System.Windows.Forms.Label()
        Me.b_rooms = New System.Windows.Forms.Button()
        Me.b_settings = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.l_room_number_show = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.close_label = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 28)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Admin Access"
        '
        'b_add
        '
        Me.b_add.BackColor = System.Drawing.Color.Transparent
        Me.b_add.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green_sq
        Me.b_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_add.ForeColor = System.Drawing.Color.Transparent
        Me.b_add.Location = New System.Drawing.Point(149, 114)
        Me.b_add.Margin = New System.Windows.Forms.Padding(0)
        Me.b_add.Name = "b_add"
        Me.b_add.Size = New System.Drawing.Size(111, 45)
        Me.b_add.TabIndex = 10
        Me.b_add.Text = "Add"
        Me.b_add.UseVisualStyleBackColor = False
        '
        'l_time_show
        '
        Me.l_time_show.AutoSize = True
        Me.l_time_show.Location = New System.Drawing.Point(13, 229)
        Me.l_time_show.Name = "l_time_show"
        Me.l_time_show.Size = New System.Drawing.Size(65, 19)
        Me.l_time_show.TabIndex = 5
        Me.l_time_show.Text = "hh:mm"
        '
        'l_date_show
        '
        Me.l_date_show.AutoSize = True
        Me.l_date_show.Location = New System.Drawing.Point(13, 253)
        Me.l_date_show.Name = "l_date_show"
        Me.l_date_show.Size = New System.Drawing.Size(95, 19)
        Me.l_date_show.TabIndex = 6
        Me.l_date_show.Text = "mm/dd/yy"
        '
        'b_edit
        '
        Me.b_edit.BackColor = System.Drawing.Color.Transparent
        Me.b_edit.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green_sq
        Me.b_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_edit.ForeColor = System.Drawing.Color.Transparent
        Me.b_edit.Location = New System.Drawing.Point(20, 114)
        Me.b_edit.Margin = New System.Windows.Forms.Padding(0)
        Me.b_edit.Name = "b_edit"
        Me.b_edit.Size = New System.Drawing.Size(111, 45)
        Me.b_edit.TabIndex = 9
        Me.b_edit.Text = "Edit"
        Me.b_edit.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Honeydew
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.Black
        Me.DataGridView1.Location = New System.Drawing.Point(20, 173)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(417, 297)
        Me.DataGridView1.TabIndex = 1
        '
        'b_reports
        '
        Me.b_reports.BackColor = System.Drawing.Color.Transparent
        Me.b_reports.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green
        Me.b_reports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_reports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_reports.ForeColor = System.Drawing.Color.Transparent
        Me.b_reports.Location = New System.Drawing.Point(12, 202)
        Me.b_reports.Name = "b_reports"
        Me.b_reports.Size = New System.Drawing.Size(163, 53)
        Me.b_reports.TabIndex = 43
        Me.b_reports.Text = "Reports"
        Me.b_reports.UseVisualStyleBackColor = False
        '
        'l_day_show
        '
        Me.l_day_show.AutoSize = True
        Me.l_day_show.Location = New System.Drawing.Point(13, 205)
        Me.l_day_show.Name = "l_day_show"
        Me.l_day_show.Size = New System.Drawing.Size(40, 19)
        Me.l_day_show.TabIndex = 4
        Me.l_day_show.Text = "day"
        '
        'b_rooms
        '
        Me.b_rooms.BackColor = System.Drawing.Color.Transparent
        Me.b_rooms.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green
        Me.b_rooms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_rooms.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_rooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_rooms.ForeColor = System.Drawing.Color.Transparent
        Me.b_rooms.Location = New System.Drawing.Point(12, 143)
        Me.b_rooms.Name = "b_rooms"
        Me.b_rooms.Size = New System.Drawing.Size(163, 53)
        Me.b_rooms.TabIndex = 42
        Me.b_rooms.Text = "Rooms"
        Me.b_rooms.UseVisualStyleBackColor = False
        '
        'b_settings
        '
        Me.b_settings.BackColor = System.Drawing.Color.Transparent
        Me.b_settings.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green
        Me.b_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_settings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_settings.ForeColor = System.Drawing.Color.Transparent
        Me.b_settings.Location = New System.Drawing.Point(12, 261)
        Me.b_settings.Name = "b_settings"
        Me.b_settings.Size = New System.Drawing.Size(163, 53)
        Me.b_settings.TabIndex = 44
        Me.b_settings.Text = "Settings"
        Me.b_settings.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Schedule"
        '
        'l_room_number_show
        '
        Me.l_room_number_show.AutoSize = True
        Me.l_room_number_show.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_room_number_show.Location = New System.Drawing.Point(77, 73)
        Me.l_room_number_show.Name = "l_room_number_show"
        Me.l_room_number_show.Size = New System.Drawing.Size(78, 28)
        Me.l_room_number_show.TabIndex = 2
        Me.l_room_number_show.Text = "TT 000"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Honeydew
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.DarkGreen
        Me.TextBox1.Location = New System.Drawing.Point(61, 52)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(376, 31)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Text = "Search..."
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(12, 84)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(163, 53)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "Equipments"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Reservation_System.My.Resources.Resources.search_01
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(20, 52)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 29)
        Me.Button1.TabIndex = 31
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.l_date_show)
        Me.GroupBox2.Controls.Add(Me.l_time_show)
        Me.GroupBox2.Controls.Add(Me.l_day_show)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.l_room_number_show)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox2.Location = New System.Drawing.Point(660, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(225, 495)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Information Summary"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Room Number"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.b_add)
        Me.GroupBox1.Controls.Add(Me.b_edit)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox1.Location = New System.Drawing.Point(197, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 495)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Equipments"
        '
        'close_label
        '
        Me.close_label.AutoSize = True
        Me.close_label.BackColor = System.Drawing.Color.Transparent
        Me.close_label.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close_label.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close_label.ForeColor = System.Drawing.Color.White
        Me.close_label.Location = New System.Drawing.Point(860, 5)
        Me.close_label.Name = "close_label"
        Me.close_label.Size = New System.Drawing.Size(30, 32)
        Me.close_label.TabIndex = 36
        Me.close_label.Text = "x"
        '
        'Admin_equip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Reservation_System.My.Resources.Resources.bg_main_admin1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(896, 553)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.b_reports)
        Me.Controls.Add(Me.b_rooms)
        Me.Controls.Add(Me.b_settings)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.close_label)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkGreen
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(896, 553)
        Me.MinimumSize = New System.Drawing.Size(896, 553)
        Me.Name = "Admin_equip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_equip"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents b_add As System.Windows.Forms.Button
    Friend WithEvents l_time_show As System.Windows.Forms.Label
    Friend WithEvents l_date_show As System.Windows.Forms.Label
    Friend WithEvents b_edit As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents b_reports As System.Windows.Forms.Button
    Friend WithEvents l_day_show As System.Windows.Forms.Label
    Friend WithEvents b_rooms As System.Windows.Forms.Button
    Friend WithEvents b_settings As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents l_room_number_show As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents close_label As System.Windows.Forms.Label
End Class
