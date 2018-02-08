<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class confirm_form
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
        Me.b_YES = New System.Windows.Forms.Button()
        Me.b_NO = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'b_YES
        '
        Me.b_YES.BackColor = System.Drawing.Color.Transparent
        Me.b_YES.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green
        Me.b_YES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_YES.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_YES.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_YES.ForeColor = System.Drawing.Color.Transparent
        Me.b_YES.Location = New System.Drawing.Point(36, 107)
        Me.b_YES.Margin = New System.Windows.Forms.Padding(0)
        Me.b_YES.Name = "b_YES"
        Me.b_YES.Size = New System.Drawing.Size(93, 37)
        Me.b_YES.TabIndex = 5
        Me.b_YES.Text = "Yes"
        Me.b_YES.UseVisualStyleBackColor = False
        '
        'b_NO
        '
        Me.b_NO.BackColor = System.Drawing.Color.Transparent
        Me.b_NO.BackgroundImage = Global.Reservation_System.My.Resources.Resources.Button_01_green
        Me.b_NO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_NO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_NO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_NO.ForeColor = System.Drawing.Color.Transparent
        Me.b_NO.Location = New System.Drawing.Point(165, 107)
        Me.b_NO.Margin = New System.Windows.Forms.Padding(0)
        Me.b_NO.Name = "b_NO"
        Me.b_NO.Size = New System.Drawing.Size(93, 37)
        Me.b_NO.TabIndex = 6
        Me.b_NO.Text = "No"
        Me.b_NO.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 28)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Continue process?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Note: This cannot be undone..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'confirm_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Reservation_System.My.Resources.Resources.bg_main_admin12
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(296, 176)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.b_NO)
        Me.Controls.Add(Me.b_YES)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkGreen
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "confirm_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "confirm_form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents b_YES As System.Windows.Forms.Button
    Friend WithEvents b_NO As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
