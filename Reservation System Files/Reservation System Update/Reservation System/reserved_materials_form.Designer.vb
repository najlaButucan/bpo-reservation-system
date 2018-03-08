<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reserved_materials_form
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rb_others = New System.Windows.Forms.RadioButton()
        Me.rb_classroom = New System.Windows.Forms.RadioButton()
        Me.cb_room = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.materials_choose = New System.Windows.Forms.CheckedListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.b_confirm = New System.Windows.Forms.Button()
        Me.b_back = New System.Windows.Forms.Button()
        Me.b_reservation_nxt = New System.Windows.Forms.Button()
        Me.l_date_show = New System.Windows.Forms.Label()
        Me.l_time_show = New System.Windows.Forms.Label()
        Me.l_org_show = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.l_room_number_show = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.close_label = New System.Windows.Forms.Label()
        Me.b_reservation = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.b_home = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.cb_room)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.materials_choose)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox1.Location = New System.Drawing.Point(196, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(516, 555)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Equipments Reservation"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Honeydew
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.rb_others)
        Me.Panel1.Controls.Add(Me.rb_classroom)
        Me.Panel1.Location = New System.Drawing.Point(27, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(459, 110)
        Me.Panel1.TabIndex = 13
        '
        'rb_others
        '
        Me.rb_others.AutoSize = True
        Me.rb_others.Location = New System.Drawing.Point(17, 58)
        Me.rb_others.Name = "rb_others"
        Me.rb_others.Size = New System.Drawing.Size(87, 27)
        Me.rb_others.TabIndex = 1
        Me.rb_others.TabStop = True
        Me.rb_others.Text = "Others"
        Me.rb_others.UseVisualStyleBackColor = True
        '
        'rb_classroom
        '
        Me.rb_classroom.AutoSize = True
        Me.rb_classroom.Location = New System.Drawing.Point(17, 28)
        Me.rb_classroom.Name = "rb_classroom"
        Me.rb_classroom.Size = New System.Drawing.Size(125, 27)
        Me.rb_classroom.TabIndex = 0
        Me.rb_classroom.TabStop = True
        Me.rb_classroom.Text = "Classroom"
        Me.rb_classroom.UseVisualStyleBackColor = True
        '
        'cb_room
        '
        Me.cb_room.BackColor = System.Drawing.Color.Honeydew
        Me.cb_room.CausesValidation = False
        Me.cb_room.FormattingEnabled = True
        Me.cb_room.Location = New System.Drawing.Point(27, 231)
        Me.cb_room.Name = "cb_room"
        Me.cb_room.Size = New System.Drawing.Size(459, 31)
        Me.cb_room.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 23)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "II. Room Details"
        '
        'materials_choose
        '
        Me.materials_choose.BackColor = System.Drawing.Color.Honeydew
        Me.materials_choose.CheckOnClick = True
        Me.materials_choose.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.materials_choose.ForeColor = System.Drawing.Color.DarkGreen
        Me.materials_choose.FormattingEnabled = True
        Me.materials_choose.Location = New System.Drawing.Point(27, 308)
        Me.materials_choose.Name = "materials_choose"
        Me.materials_choose.Size = New System.Drawing.Size(459, 220)
        Me.materials_choose.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "III. Equipment"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "I. Facilities"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Controls.Add(Me.b_confirm)
        Me.GroupBox2.Controls.Add(Me.b_back)
        Me.GroupBox2.Controls.Add(Me.b_reservation_nxt)
        Me.GroupBox2.Controls.Add(Me.l_date_show)
        Me.GroupBox2.Controls.Add(Me.l_time_show)
        Me.GroupBox2.Controls.Add(Me.l_org_show)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.l_room_number_show)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox2.Location = New System.Drawing.Point(718, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(413, 555)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Information Summary"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Honeydew
        Me.ListBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 17
        Me.ListBox1.Location = New System.Drawing.Point(26, 275)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(370, 191)
        Me.ListBox1.TabIndex = 10
        '
        'b_confirm
        '
        Me.b_confirm.BackColor = System.Drawing.Color.Transparent
        Me.b_confirm.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green_sq
        Me.b_confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_confirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_confirm.ForeColor = System.Drawing.Color.Transparent
        Me.b_confirm.Location = New System.Drawing.Point(155, 488)
        Me.b_confirm.Margin = New System.Windows.Forms.Padding(0)
        Me.b_confirm.Name = "b_confirm"
        Me.b_confirm.Size = New System.Drawing.Size(106, 45)
        Me.b_confirm.TabIndex = 9
        Me.b_confirm.Text = "Confirm"
        Me.b_confirm.UseVisualStyleBackColor = False
        '
        'b_back
        '
        Me.b_back.BackColor = System.Drawing.Color.Transparent
        Me.b_back.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green_sq
        Me.b_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_back.ForeColor = System.Drawing.Color.Transparent
        Me.b_back.Location = New System.Drawing.Point(17, 488)
        Me.b_back.Margin = New System.Windows.Forms.Padding(0)
        Me.b_back.Name = "b_back"
        Me.b_back.Size = New System.Drawing.Size(100, 45)
        Me.b_back.TabIndex = 8
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
        Me.b_reservation_nxt.Location = New System.Drawing.Point(297, 488)
        Me.b_reservation_nxt.Margin = New System.Windows.Forms.Padding(0)
        Me.b_reservation_nxt.Name = "b_reservation_nxt"
        Me.b_reservation_nxt.Size = New System.Drawing.Size(99, 45)
        Me.b_reservation_nxt.TabIndex = 7
        Me.b_reservation_nxt.Text = "Next" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.b_reservation_nxt.UseVisualStyleBackColor = False
        '
        'l_date_show
        '
        Me.l_date_show.AutoSize = True
        Me.l_date_show.Location = New System.Drawing.Point(13, 219)
        Me.l_date_show.Name = "l_date_show"
        Me.l_date_show.Size = New System.Drawing.Size(112, 23)
        Me.l_date_show.TabIndex = 6
        Me.l_date_show.Text = "mm/dd/yy"
        '
        'l_time_show
        '
        Me.l_time_show.AutoSize = True
        Me.l_time_show.Location = New System.Drawing.Point(13, 195)
        Me.l_time_show.Name = "l_time_show"
        Me.l_time_show.Size = New System.Drawing.Size(73, 23)
        Me.l_time_show.TabIndex = 5
        Me.l_time_show.Text = "hh:mm"
        '
        'l_org_show
        '
        Me.l_org_show.AutoSize = True
        Me.l_org_show.Location = New System.Drawing.Point(13, 171)
        Me.l_org_show.Name = "l_org_show"
        Me.l_org_show.Size = New System.Drawing.Size(26, 23)
        Me.l_org_show.TabIndex = 4
        Me.l_org_show.Text = "--"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 23)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Schedule"
        '
        'l_room_number_show
        '
        Me.l_room_number_show.AutoSize = True
        Me.l_room_number_show.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_room_number_show.Location = New System.Drawing.Point(68, 63)
        Me.l_room_number_show.Name = "l_room_number_show"
        Me.l_room_number_show.Size = New System.Drawing.Size(78, 28)
        Me.l_room_number_show.TabIndex = 2
        Me.l_room_number_show.Text = "TT 000"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 23)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Room Number"
        '
        'close_label
        '
        Me.close_label.AutoSize = True
        Me.close_label.BackColor = System.Drawing.Color.Transparent
        Me.close_label.Cursor = System.Windows.Forms.Cursors.Default
        Me.close_label.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close_label.ForeColor = System.Drawing.Color.White
        Me.close_label.Location = New System.Drawing.Point(1101, 6)
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
        'b_home
        '
        Me.b_home.BackColor = System.Drawing.Color.Transparent
        Me.b_home.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green
        Me.b_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_home.ForeColor = System.Drawing.Color.Transparent
        Me.b_home.Location = New System.Drawing.Point(12, 540)
        Me.b_home.Name = "b_home"
        Me.b_home.Size = New System.Drawing.Size(163, 53)
        Me.b_home.TabIndex = 29
        Me.b_home.Text = "Home"
        Me.b_home.UseVisualStyleBackColor = False
        '
        'reserved_materials_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Reservation_System.My.Resources.Resources.bg_main_admin1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1143, 619)
        Me.Controls.Add(Me.b_home)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.b_reservation)
        Me.Controls.Add(Me.close_label)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkGreen
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(1143, 619)
        Me.MinimumSize = New System.Drawing.Size(1143, 619)
        Me.Name = "reserved_materials_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservation Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents close_label As System.Windows.Forms.Label
    Friend WithEvents b_reservation As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents l_date_show As System.Windows.Forms.Label
    Friend WithEvents l_time_show As System.Windows.Forms.Label
    Friend WithEvents l_org_show As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents l_room_number_show As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents b_reservation_nxt As System.Windows.Forms.Button
    Friend WithEvents b_back As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents materials_choose As System.Windows.Forms.CheckedListBox
    Friend WithEvents b_home As System.Windows.Forms.Button
    Friend WithEvents cb_room As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents b_confirm As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rb_others As System.Windows.Forms.RadioButton
    Friend WithEvents rb_classroom As System.Windows.Forms.RadioButton
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox

End Class
