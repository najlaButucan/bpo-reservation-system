Public Class Admin_home
    '' you do this part :DDDDDDDDD
    '' ya know what.. do all the admin part except for the reports lets both cry together there
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label4.Text = Format(Now, "hh:mm tt")
        Label3.Text = Format(Now, "MMMM dd, yyyy")
    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click
        Me.Hide()
        _Login.Show()
        _Login.UsernameTextBox.Clear()
        _Login.PasswordTextBox.Clear()

    End Sub

    Private Sub b_reservation_Click(sender As System.Object, e As System.EventArgs) Handles b_reservation.Click
        Me.Hide()
        Admin_Equips.Show()
    End Sub

    Private Sub b_ovaerall_sched_Click(sender As System.Object, e As System.EventArgs) Handles b_ovaerall_sched.Click
        Me.Hide()
        Admin_Rooms.Show()
    End Sub

    Private Sub b_edit_reservation_Click(sender As System.Object, e As System.EventArgs) Handles b_edit_reservation.Click
        Me.Hide()
        Admin_Report.Show()
    End Sub

    Private Sub Admin_home_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        _Login.userlvl = "ADMIN"
    End Sub

    Private Sub b_about_Click(sender As System.Object, e As System.EventArgs) Handles b_about.Click
        admin_about.Show()
    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub
End Class