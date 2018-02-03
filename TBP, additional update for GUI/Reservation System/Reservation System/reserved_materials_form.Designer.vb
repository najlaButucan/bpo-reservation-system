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
        Me.materials_checked = New System.Windows.Forms.DataGridView()
        Me.materials_choose = New System.Windows.Forms.CheckedListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.close_label = New System.Windows.Forms.Label()
        Me.b_reservation = New System.Windows.Forms.Button()
        Me.b_edit_reservation = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.materials_checked, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.materials_checked)
        Me.GroupBox1.Controls.Add(Me.materials_choose)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox1.Location = New System.Drawing.Point(196, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 495)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reserved Materials"
        '
        'materials_checked
        '
        Me.materials_checked.BackgroundColor = System.Drawing.Color.Honeydew
        Me.materials_checked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.materials_checked.GridColor = System.Drawing.Color.DarkGreen
        Me.materials_checked.Location = New System.Drawing.Point(241, 152)
        Me.materials_checked.Name = "materials_checked"
        Me.materials_checked.Size = New System.Drawing.Size(186, 301)
        Me.materials_checked.TabIndex = 7
        '
        'materials_choose
        '
        Me.materials_choose.BackColor = System.Drawing.Color.Honeydew
        Me.materials_choose.ForeColor = System.Drawing.Color.DarkGreen
        Me.materials_choose.FormattingEnabled = True
        Me.materials_choose.Location = New System.Drawing.Point(38, 152)
        Me.materials_choose.Name = "materials_choose"
        Me.materials_choose.Size = New System.Drawing.Size(179, 301)
        Me.materials_choose.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Honeydew
        Me.ComboBox1.ForeColor = System.Drawing.Color.DarkGreen
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(39, 92)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(212, 31)
        Me.ComboBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Search:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.b_back)
        Me.GroupBox2.Controls.Add(Me.b_reservation_nxt)
        Me.GroupBox2.Controls.Add(Me.l_date_show)
        Me.GroupBox2.Controls.Add(Me.l_time_show)
        Me.GroupBox2.Controls.Add(Me.l_day_show)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.l_room_number_show)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
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
        Me.b_back.Location = New System.Drawing.Point(8, 437)
        Me.b_back.Margin = New System.Windows.Forms.Padding(0)
        Me.b_back.Name = "b_back"
        Me.b_back.Size = New System.Drawing.Size(99, 45)
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
        Me.b_reservation_nxt.Location = New System.Drawing.Point(118, 437)
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
        Me.l_date_show.Location = New System.Drawing.Point(13, 353)
        Me.l_date_show.Name = "l_date_show"
        Me.l_date_show.Size = New System.Drawing.Size(116, 23)
        Me.l_date_show.TabIndex = 6
        Me.l_date_show.Text = "mm/dd/yy"
        '
        'l_time_show
        '
        Me.l_time_show.AutoSize = True
        Me.l_time_show.Location = New System.Drawing.Point(13, 329)
        Me.l_time_show.Name = "l_time_show"
        Me.l_time_show.Size = New System.Drawing.Size(78, 23)
        Me.l_time_show.TabIndex = 5
        Me.l_time_show.Text = "hh:mm"
        '
        'l_day_show
        '
        Me.l_day_show.AutoSize = True
        Me.l_day_show.Location = New System.Drawing.Point(13, 305)
        Me.l_day_show.Name = "l_day_show"
        Me.l_day_show.Size = New System.Drawing.Size(48, 23)
        Me.l_day_show.TabIndex = 4
        Me.l_day_show.Text = "day"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 23)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Schedule"
        '
        'l_room_number_show
        '
        Me.l_room_number_show.AutoSize = True
        Me.l_room_number_show.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_room_number_show.Location = New System.Drawing.Point(77, 227)
        Me.l_room_number_show.Name = "l_room_number_show"
        Me.l_room_number_show.Size = New System.Drawing.Size(102, 37)
        Me.l_room_number_show.TabIndex = 2
        Me.l_room_number_show.Text = "TT 000"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 23)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Room Number"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Honeydew
        Me.PictureBox1.Location = New System.Drawing.Point(8, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(192, 157)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
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
        Me.close_label.Size = New System.Drawing.Size(36, 40)
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
        'b_edit_reservation
        '
        Me.b_edit_reservation.BackColor = System.Drawing.Color.Transparent
        Me.b_edit_reservation.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green
        Me.b_edit_reservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_edit_reservation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_edit_reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_edit_reservation.ForeColor = System.Drawing.Color.Transparent
        Me.b_edit_reservation.Location = New System.Drawing.Point(13, 144)
        Me.b_edit_reservation.Name = "b_edit_reservation"
        Me.b_edit_reservation.Size = New System.Drawing.Size(163, 53)
        Me.b_edit_reservation.TabIndex = 6
        Me.b_edit_reservation.Text = "Edit"
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
        Me.Label1.Size = New System.Drawing.Size(289, 37)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Rooms Reservation"
        '
        'reserved_materials_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Reservation_System.My.Resources.Resources.bg_main_admin1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(896, 553)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.b_edit_reservation)
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
        Me.Name = "reserved_materials_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservation Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.materials_checked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents close_label As System.Windows.Forms.Label
    Friend WithEvents b_reservation As System.Windows.Forms.Button
    Friend WithEvents b_edit_reservation As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents l_date_show As System.Windows.Forms.Label
    Friend WithEvents l_time_show As System.Windows.Forms.Label
    Friend WithEvents l_day_show As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents l_room_number_show As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents b_reservation_nxt As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents materials_choose As System.Windows.Forms.CheckedListBox
    Friend WithEvents materials_checked As System.Windows.Forms.DataGridView
    Friend WithEvents b_back As System.Windows.Forms.Button

End Class
