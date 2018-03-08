<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Continue_form
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.b_yes = New System.Windows.Forms.Button()
        Me.b_no = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(106, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(342, 64)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Are you sure you want to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "continue?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Reservation_System.My.Resources.Resources.____
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(19, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 64)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(146, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "(all fields will be cleared)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'b_yes
        '
        Me.b_yes.BackColor = System.Drawing.Color.Transparent
        Me.b_yes.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green
        Me.b_yes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_yes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_yes.ForeColor = System.Drawing.Color.Transparent
        Me.b_yes.Location = New System.Drawing.Point(84, 156)
        Me.b_yes.Margin = New System.Windows.Forms.Padding(0)
        Me.b_yes.Name = "b_yes"
        Me.b_yes.Size = New System.Drawing.Size(120, 40)
        Me.b_yes.TabIndex = 26
        Me.b_yes.Text = "Yes"
        Me.b_yes.UseVisualStyleBackColor = False
        '
        'b_no
        '
        Me.b_no.BackColor = System.Drawing.Color.Transparent
        Me.b_no.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green
        Me.b_no.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_no.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_no.ForeColor = System.Drawing.Color.Transparent
        Me.b_no.Location = New System.Drawing.Point(264, 156)
        Me.b_no.Margin = New System.Windows.Forms.Padding(0)
        Me.b_no.Name = "b_no"
        Me.b_no.Size = New System.Drawing.Size(120, 40)
        Me.b_no.TabIndex = 27
        Me.b_no.Text = "No"
        Me.b_no.UseVisualStyleBackColor = False
        '
        'Continue_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Reservation_System.My.Resources.Resources.bg_main_admin11
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(467, 232)
        Me.Controls.Add(Me.b_no)
        Me.Controls.Add(Me.b_yes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkGreen
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Continue_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Continue_form"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents b_yes As System.Windows.Forms.Button
    Friend WithEvents b_no As System.Windows.Forms.Button
End Class
