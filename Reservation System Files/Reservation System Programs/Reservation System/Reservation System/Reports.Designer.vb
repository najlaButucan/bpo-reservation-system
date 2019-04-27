<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
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
        Me.datagrid_reports = New System.Windows.Forms.DataGridView()
        Me.b_reports = New System.Windows.Forms.Button()
        Me.b_rooms = New System.Windows.Forms.Button()
        Me.b_settings = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.close_label = New System.Windows.Forms.Label()
        CType(Me.datagrid_reports, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'datagrid_reports
        '
        Me.datagrid_reports.BackgroundColor = System.Drawing.Color.Honeydew
        Me.datagrid_reports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_reports.GridColor = System.Drawing.Color.Black
        Me.datagrid_reports.Location = New System.Drawing.Point(20, 46)
        Me.datagrid_reports.Name = "datagrid_reports"
        Me.datagrid_reports.Size = New System.Drawing.Size(650, 424)
        Me.datagrid_reports.TabIndex = 1
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.datagrid_reports)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox1.Location = New System.Drawing.Point(197, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(693, 495)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Monthly and Weeks Reports"
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
        'Reports
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
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.close_label)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkGreen
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(896, 553)
        Me.MinimumSize = New System.Drawing.Size(896, 553)
        Me.Name = "Reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports"
        CType(Me.datagrid_reports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents datagrid_reports As System.Windows.Forms.DataGridView
    Friend WithEvents b_reports As System.Windows.Forms.Button
    Friend WithEvents b_rooms As System.Windows.Forms.Button
    Friend WithEvents b_settings As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents close_label As System.Windows.Forms.Label
End Class
