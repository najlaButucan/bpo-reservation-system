<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_add
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.b_reservation_nxt = New System.Windows.Forms.Button()
        Me.l_date_show = New System.Windows.Forms.Label()
        Me.l_time_show = New System.Windows.Forms.Label()
        Me.l_day_show = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.l_room_number_show = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.b_settings = New System.Windows.Forms.Button()
        Me.b_reports = New System.Windows.Forms.Button()
        Me.b_rooms = New System.Windows.Forms.Button()
        Me.b_equip = New System.Windows.Forms.Button()
        Me.close_label = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.b_reservation_nxt)
        Me.GroupBox2.Controls.Add(Me.l_date_show)
        Me.GroupBox2.Controls.Add(Me.l_time_show)
        Me.GroupBox2.Controls.Add(Me.l_day_show)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.l_room_number_show)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox2.Location = New System.Drawing.Point(659, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(225, 495)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Information Summary"
        '
        'b_reservation_nxt
        '
        Me.b_reservation_nxt.BackColor = System.Drawing.Color.Transparent
        Me.b_reservation_nxt.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green_sq
        Me.b_reservation_nxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_reservation_nxt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_reservation_nxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_reservation_nxt.ForeColor = System.Drawing.Color.Transparent
        Me.b_reservation_nxt.Location = New System.Drawing.Point(110, 438)
        Me.b_reservation_nxt.Margin = New System.Windows.Forms.Padding(0)
        Me.b_reservation_nxt.Name = "b_reservation_nxt"
        Me.b_reservation_nxt.Size = New System.Drawing.Size(99, 45)
        Me.b_reservation_nxt.TabIndex = 7
        Me.b_reservation_nxt.Text = "Confirm"
        Me.b_reservation_nxt.UseVisualStyleBackColor = False
        '
        'l_date_show
        '
        Me.l_date_show.AutoSize = True
        Me.l_date_show.Location = New System.Drawing.Point(13, 254)
        Me.l_date_show.Name = "l_date_show"
        Me.l_date_show.Size = New System.Drawing.Size(95, 19)
        Me.l_date_show.TabIndex = 6
        Me.l_date_show.Text = "mm/dd/yy"
        '
        'l_time_show
        '
        Me.l_time_show.AutoSize = True
        Me.l_time_show.Location = New System.Drawing.Point(13, 230)
        Me.l_time_show.Name = "l_time_show"
        Me.l_time_show.Size = New System.Drawing.Size(65, 19)
        Me.l_time_show.TabIndex = 5
        Me.l_time_show.Text = "hh:mm"
        '
        'l_day_show
        '
        Me.l_day_show.AutoSize = True
        Me.l_day_show.Location = New System.Drawing.Point(13, 206)
        Me.l_day_show.Name = "l_day_show"
        Me.l_day_show.Size = New System.Drawing.Size(40, 19)
        Me.l_day_show.TabIndex = 4
        Me.l_day_show.Text = "day"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Schedule"
        '
        'l_room_number_show
        '
        Me.l_room_number_show.AutoSize = True
        Me.l_room_number_show.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_room_number_show.Location = New System.Drawing.Point(77, 74)
        Me.l_room_number_show.Name = "l_room_number_show"
        Me.l_room_number_show.Size = New System.Drawing.Size(78, 28)
        Me.l_room_number_show.TabIndex = 2
        Me.l_room_number_show.Text = "TT 000"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Room Number"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox1.Location = New System.Drawing.Point(196, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 495)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Reservation_System.My.Resources.Resources.add1
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(324, 111)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 31)
        Me.Button1.TabIndex = 46
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Honeydew
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.DarkGreen
        Me.TextBox2.Location = New System.Drawing.Point(29, 331)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(284, 31)
        Me.TextBox2.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 303)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 23)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Capacity:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Honeydew
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.DarkGreen
        Me.TextBox1.Location = New System.Drawing.Point(29, 219)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(284, 31)
        Me.TextBox1.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 23)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Room:"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Honeydew
        Me.ComboBox1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.DarkGreen
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(29, 111)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(284, 31)
        Me.ComboBox1.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 23)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Building: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 28)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Admin Access  - ADD" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'b_settings
        '
        Me.b_settings.BackColor = System.Drawing.Color.Transparent
        Me.b_settings.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green
        Me.b_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_settings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_settings.ForeColor = System.Drawing.Color.Transparent
        Me.b_settings.Location = New System.Drawing.Point(11, 262)
        Me.b_settings.Name = "b_settings"
        Me.b_settings.Size = New System.Drawing.Size(163, 53)
        Me.b_settings.TabIndex = 36
        Me.b_settings.Text = "Settings"
        Me.b_settings.UseVisualStyleBackColor = False
        '
        'b_reports
        '
        Me.b_reports.BackColor = System.Drawing.Color.Transparent
        Me.b_reports.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green
        Me.b_reports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_reports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_reports.ForeColor = System.Drawing.Color.Transparent
        Me.b_reports.Location = New System.Drawing.Point(11, 202)
        Me.b_reports.Name = "b_reports"
        Me.b_reports.Size = New System.Drawing.Size(163, 53)
        Me.b_reports.TabIndex = 39
        Me.b_reports.Text = "Reports"
        Me.b_reports.UseVisualStyleBackColor = False
        '
        'b_rooms
        '
        Me.b_rooms.BackColor = System.Drawing.Color.Transparent
        Me.b_rooms.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green
        Me.b_rooms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_rooms.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_rooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_rooms.ForeColor = System.Drawing.Color.Transparent
        Me.b_rooms.Location = New System.Drawing.Point(11, 143)
        Me.b_rooms.Name = "b_rooms"
        Me.b_rooms.Size = New System.Drawing.Size(163, 53)
        Me.b_rooms.TabIndex = 38
        Me.b_rooms.Text = "Rooms"
        Me.b_rooms.UseVisualStyleBackColor = False
        '
        'b_equip
        '
        Me.b_equip.BackColor = System.Drawing.Color.Transparent
        Me.b_equip.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green
        Me.b_equip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_equip.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_equip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_equip.ForeColor = System.Drawing.Color.Transparent
        Me.b_equip.Location = New System.Drawing.Point(11, 84)
        Me.b_equip.Margin = New System.Windows.Forms.Padding(0)
        Me.b_equip.Name = "b_equip"
        Me.b_equip.Size = New System.Drawing.Size(163, 53)
        Me.b_equip.TabIndex = 37
        Me.b_equip.Text = "Equipments"
        Me.b_equip.UseVisualStyleBackColor = False
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
        Me.close_label.TabIndex = 40
        Me.close_label.Text = "x"
        '
        'Admin_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Reservation_System.My.Resources.Resources.bg_main_admin1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(896, 553)
        Me.Controls.Add(Me.close_label)
        Me.Controls.Add(Me.b_reports)
        Me.Controls.Add(Me.b_rooms)
        Me.Controls.Add(Me.b_equip)
        Me.Controls.Add(Me.b_settings)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkGreen
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(896, 553)
        Me.MinimumSize = New System.Drawing.Size(896, 553)
        Me.Name = "Admin_add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_add"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents b_reservation_nxt As System.Windows.Forms.Button
    Friend WithEvents l_date_show As System.Windows.Forms.Label
    Friend WithEvents l_time_show As System.Windows.Forms.Label
    Friend WithEvents l_day_show As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents l_room_number_show As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents b_settings As System.Windows.Forms.Button
    Friend WithEvents b_reports As System.Windows.Forms.Button
    Friend WithEvents b_rooms As System.Windows.Forms.Button
    Friend WithEvents b_equip As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents close_label As System.Windows.Forms.Label
End Class
