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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.b_ovaerall_sched = New System.Windows.Forms.Button()
        Me.b_home = New System.Windows.Forms.Button()
        Me.b_about = New System.Windows.Forms.Button()
        Me.b_edit_reservation = New System.Windows.Forms.Button()
        Me.b_reservation = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbBuilding = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtRoomCode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Admin Access - Rooms" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(1096, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 38)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "x"
        '
        'b_ovaerall_sched
        '
        Me.b_ovaerall_sched.BackColor = System.Drawing.Color.Transparent
        Me.b_ovaerall_sched.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green
        Me.b_ovaerall_sched.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_ovaerall_sched.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_ovaerall_sched.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_ovaerall_sched.ForeColor = System.Drawing.Color.Transparent
        Me.b_ovaerall_sched.Location = New System.Drawing.Point(22, 135)
        Me.b_ovaerall_sched.Name = "b_ovaerall_sched"
        Me.b_ovaerall_sched.Size = New System.Drawing.Size(163, 53)
        Me.b_ovaerall_sched.TabIndex = 29
        Me.b_ovaerall_sched.Text = "Rooms"
        Me.b_ovaerall_sched.UseVisualStyleBackColor = False
        '
        'b_home
        '
        Me.b_home.BackColor = System.Drawing.Color.Transparent
        Me.b_home.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green
        Me.b_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_home.ForeColor = System.Drawing.Color.Transparent
        Me.b_home.Location = New System.Drawing.Point(22, 495)
        Me.b_home.Name = "b_home"
        Me.b_home.Size = New System.Drawing.Size(163, 53)
        Me.b_home.TabIndex = 28
        Me.b_home.Text = "Home"
        Me.b_home.UseVisualStyleBackColor = False
        '
        'b_about
        '
        Me.b_about.BackColor = System.Drawing.Color.Transparent
        Me.b_about.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green
        Me.b_about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_about.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_about.ForeColor = System.Drawing.Color.Transparent
        Me.b_about.Location = New System.Drawing.Point(22, 554)
        Me.b_about.Name = "b_about"
        Me.b_about.Size = New System.Drawing.Size(163, 53)
        Me.b_about.TabIndex = 27
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
        Me.b_edit_reservation.Location = New System.Drawing.Point(22, 194)
        Me.b_edit_reservation.Name = "b_edit_reservation"
        Me.b_edit_reservation.Size = New System.Drawing.Size(163, 53)
        Me.b_edit_reservation.TabIndex = 26
        Me.b_edit_reservation.Text = "Reports"
        Me.b_edit_reservation.UseVisualStyleBackColor = False
        '
        'b_reservation
        '
        Me.b_reservation.BackColor = System.Drawing.Color.Transparent
        Me.b_reservation.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green
        Me.b_reservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_reservation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_reservation.ForeColor = System.Drawing.Color.Transparent
        Me.b_reservation.Location = New System.Drawing.Point(22, 76)
        Me.b_reservation.Margin = New System.Windows.Forms.Padding(0)
        Me.b_reservation.Name = "b_reservation"
        Me.b_reservation.Size = New System.Drawing.Size(163, 53)
        Me.b_reservation.TabIndex = 25
        Me.b_reservation.Text = "Equipments"
        Me.b_reservation.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmbBuilding)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.btnConfirm)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.txtRoomCode)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox1.Location = New System.Drawing.Point(196, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(935, 555)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adding Rooms"
        '
        'cmbBuilding
        '
        Me.cmbBuilding.BackColor = System.Drawing.Color.Honeydew
        Me.cmbBuilding.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cmbBuilding.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold)
        Me.cmbBuilding.ForeColor = System.Drawing.Color.DarkGreen
        Me.cmbBuilding.FormattingEnabled = True
        Me.cmbBuilding.Items.AddRange(New Object() {"MO", "LS"})
        Me.cmbBuilding.Location = New System.Drawing.Point(74, 128)
        Me.cmbBuilding.Name = "cmbBuilding"
        Me.cmbBuilding.Size = New System.Drawing.Size(313, 33)
        Me.cmbBuilding.TabIndex = 34
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green_sq
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Location = New System.Drawing.Point(74, 485)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 45)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.Transparent
        Me.btnConfirm.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green_sq
        Me.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.ForeColor = System.Drawing.Color.Transparent
        Me.btnConfirm.Location = New System.Drawing.Point(720, 485)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(180, 45)
        Me.btnConfirm.TabIndex = 31
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.Honeydew
        Me.txtDescription.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtDescription.Location = New System.Drawing.Point(74, 358)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(313, 33)
        Me.txtDescription.TabIndex = 31
        '
        'txtRoomCode
        '
        Me.txtRoomCode.BackColor = System.Drawing.Color.Honeydew
        Me.txtRoomCode.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomCode.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtRoomCode.Location = New System.Drawing.Point(74, 244)
        Me.txtRoomCode.Name = "txtRoomCode"
        Me.txtRoomCode.Size = New System.Drawing.Size(313, 33)
        Me.txtRoomCode.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(69, 322)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 25)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Description:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(69, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 25)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Room Code:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(69, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Building:"
        '
        'Admin_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Reservation_System.My.Resources.Resources.bg_main_admin1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1143, 619)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.b_ovaerall_sched)
        Me.Controls.Add(Me.b_home)
        Me.Controls.Add(Me.b_about)
        Me.Controls.Add(Me.b_edit_reservation)
        Me.Controls.Add(Me.b_reservation)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkGreen
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(1143, 619)
        Me.MinimumSize = New System.Drawing.Size(1143, 619)
        Me.Name = "Admin_add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_home"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents b_ovaerall_sched As System.Windows.Forms.Button
    Friend WithEvents b_home As System.Windows.Forms.Button
    Friend WithEvents b_about As System.Windows.Forms.Button
    Friend WithEvents b_edit_reservation As System.Windows.Forms.Button
    Friend WithEvents b_reservation As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtRoomCode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents cmbBuilding As System.Windows.Forms.ComboBox
End Class
