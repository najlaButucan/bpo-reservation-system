<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class student_event_form
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.t_event_name = New System.Windows.Forms.TextBox()
        Me.t_student_name = New System.Windows.Forms.TextBox()
        Me.t_id_number = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.reason_events_list = New System.Windows.Forms.CheckedListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.b_back = New System.Windows.Forms.Button()
        Me.b_reservation_nxt = New System.Windows.Forms.Button()
        Me.l_date_show = New System.Windows.Forms.Label()
        Me.l_time_show = New System.Windows.Forms.Label()
        Me.l_day_show = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.l_room_number_show = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.close_label = New System.Windows.Forms.Label()
        Me.b_reservation = New System.Windows.Forms.Button()
        Me.b_ovaerall_sched = New System.Windows.Forms.Button()
        Me.b_edit_reservation = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.l_student_id = New System.Windows.Forms.Label()
        Me.l_student_name = New System.Windows.Forms.Label()
        Me.l_event_name = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.t_event_name)
        Me.GroupBox1.Controls.Add(Me.t_student_name)
        Me.GroupBox1.Controls.Add(Me.t_id_number)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.reason_events_list)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox1.Location = New System.Drawing.Point(196, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 495)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student and Event Info"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 273)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 19)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Reason of Reservation"
        '
        't_event_name
        '
        Me.t_event_name.BackColor = System.Drawing.Color.Honeydew
        Me.t_event_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.t_event_name.ForeColor = System.Drawing.Color.DarkGreen
        Me.t_event_name.Location = New System.Drawing.Point(36, 208)
        Me.t_event_name.Name = "t_event_name"
        Me.t_event_name.Size = New System.Drawing.Size(222, 27)
        Me.t_event_name.TabIndex = 8
        '
        't_student_name
        '
        Me.t_student_name.BackColor = System.Drawing.Color.Honeydew
        Me.t_student_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.t_student_name.ForeColor = System.Drawing.Color.DarkGreen
        Me.t_student_name.Location = New System.Drawing.Point(36, 132)
        Me.t_student_name.Name = "t_student_name"
        Me.t_student_name.Size = New System.Drawing.Size(222, 27)
        Me.t_student_name.TabIndex = 7
        '
        't_id_number
        '
        Me.t_id_number.BackColor = System.Drawing.Color.Honeydew
        Me.t_id_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.t_id_number.ForeColor = System.Drawing.Color.DarkGreen
        Me.t_id_number.Location = New System.Drawing.Point(36, 62)
        Me.t_id_number.Name = "t_id_number"
        Me.t_id_number.Size = New System.Drawing.Size(222, 27)
        Me.t_id_number.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Event Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Student Name:"
        '
        'reason_events_list
        '
        Me.reason_events_list.BackColor = System.Drawing.Color.Honeydew
        Me.reason_events_list.ForeColor = System.Drawing.Color.DarkGreen
        Me.reason_events_list.FormattingEnabled = True
        Me.reason_events_list.Location = New System.Drawing.Point(38, 306)
        Me.reason_events_list.Name = "reason_events_list"
        Me.reason_events_list.Size = New System.Drawing.Size(379, 158)
        Me.reason_events_list.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Number"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.l_event_name)
        Me.GroupBox2.Controls.Add(Me.l_student_name)
        Me.GroupBox2.Controls.Add(Me.l_student_id)
        Me.GroupBox2.Controls.Add(Me.b_back)
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
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Information Summary"
        '
        'b_back
        '
        Me.b_back.BackColor = System.Drawing.Color.Transparent
        Me.b_back.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green_sq
        Me.b_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_back.ForeColor = System.Drawing.Color.Transparent
        Me.b_back.Location = New System.Drawing.Point(10, 437)
        Me.b_back.Margin = New System.Windows.Forms.Padding(0)
        Me.b_back.Name = "b_back"
        Me.b_back.Size = New System.Drawing.Size(99, 45)
        Me.b_back.TabIndex = 9
        Me.b_back.Text = "Back"
        Me.b_back.UseVisualStyleBackColor = False
        '
        'b_reservation_nxt
        '
        Me.b_reservation_nxt.BackColor = System.Drawing.Color.Transparent
        Me.b_reservation_nxt.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green_sq
        Me.b_reservation_nxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_reservation_nxt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_reservation_nxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_reservation_nxt.ForeColor = System.Drawing.Color.Transparent
        Me.b_reservation_nxt.Location = New System.Drawing.Point(118, 437)
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
        Me.l_date_show.Location = New System.Drawing.Point(13, 253)
        Me.l_date_show.Name = "l_date_show"
        Me.l_date_show.Size = New System.Drawing.Size(95, 19)
        Me.l_date_show.TabIndex = 6
        Me.l_date_show.Text = "mm/dd/yy"
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
        'l_day_show
        '
        Me.l_day_show.AutoSize = True
        Me.l_day_show.Location = New System.Drawing.Point(13, 205)
        Me.l_day_show.Name = "l_day_show"
        Me.l_day_show.Size = New System.Drawing.Size(40, 19)
        Me.l_day_show.TabIndex = 4
        Me.l_day_show.Text = "day"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Room Number"
        '
        'close_label
        '
        Me.close_label.AutoSize = True
        Me.close_label.BackColor = System.Drawing.Color.Transparent
        Me.close_label.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close_label.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close_label.ForeColor = System.Drawing.Color.White
        Me.close_label.Location = New System.Drawing.Point(859, 5)
        Me.close_label.Name = "close_label"
        Me.close_label.Size = New System.Drawing.Size(30, 32)
        Me.close_label.TabIndex = 3
        Me.close_label.Text = "x"
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
        Me.b_reservation.TabIndex = 4
        Me.b_reservation.Text = "Reservation"
        Me.b_reservation.UseVisualStyleBackColor = False
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
        Me.b_ovaerall_sched.TabIndex = 5
        Me.b_ovaerall_sched.Text = "Overall Sched" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.b_ovaerall_sched.UseVisualStyleBackColor = False
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
        Me.b_edit_reservation.TabIndex = 6
        Me.b_edit_reservation.Text = "Edit Reservation"
        Me.b_edit_reservation.UseVisualStyleBackColor = False
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
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Rooms Reservation"
        '
        'l_student_id
        '
        Me.l_student_id.AutoSize = True
        Me.l_student_id.Location = New System.Drawing.Point(13, 293)
        Me.l_student_id.Name = "l_student_id"
        Me.l_student_id.Size = New System.Drawing.Size(24, 19)
        Me.l_student_id.TabIndex = 10
        Me.l_student_id.Text = "ID"
        '
        'l_student_name
        '
        Me.l_student_name.AutoSize = True
        Me.l_student_name.Location = New System.Drawing.Point(13, 321)
        Me.l_student_name.Name = "l_student_name"
        Me.l_student_name.Size = New System.Drawing.Size(117, 19)
        Me.l_student_name.TabIndex = 11
        Me.l_student_name.Text = "Student name"
        '
        'l_event_name
        '
        Me.l_event_name.AutoSize = True
        Me.l_event_name.Location = New System.Drawing.Point(13, 350)
        Me.l_event_name.Name = "l_event_name"
        Me.l_event_name.Size = New System.Drawing.Size(101, 19)
        Me.l_event_name.TabIndex = 12
        Me.l_event_name.Text = "Event name"
        '
        'student_event_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Reservation_System.My.Resources.Resources.bg_main_admin1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(896, 553)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.b_edit_reservation)
        Me.Controls.Add(Me.b_ovaerall_sched)
        Me.Controls.Add(Me.b_reservation)
        Me.Controls.Add(Me.close_label)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkGreen
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(896, 553)
        Me.MinimumSize = New System.Drawing.Size(896, 553)
        Me.Name = "student_event_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservation Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents close_label As System.Windows.Forms.Label
    Friend WithEvents b_reservation As System.Windows.Forms.Button
    Friend WithEvents b_ovaerall_sched As System.Windows.Forms.Button
    Friend WithEvents b_edit_reservation As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents l_date_show As System.Windows.Forms.Label
    Friend WithEvents l_time_show As System.Windows.Forms.Label
    Friend WithEvents l_day_show As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents l_room_number_show As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents b_reservation_nxt As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents reason_events_list As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents t_event_name As System.Windows.Forms.TextBox
    Friend WithEvents t_student_name As System.Windows.Forms.TextBox
    Friend WithEvents t_id_number As System.Windows.Forms.TextBox
    Friend WithEvents b_back As System.Windows.Forms.Button
    Friend WithEvents l_event_name As System.Windows.Forms.Label
    Friend WithEvents l_student_name As System.Windows.Forms.Label
    Friend WithEvents l_student_id As System.Windows.Forms.Label

End Class
