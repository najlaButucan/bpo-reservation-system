Public Class Admin_Equips


    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click
        Me.Hide()
    End Sub

    Private Sub b_home_Click(sender As System.Object, e As System.EventArgs) Handles b_home.Click
        Me.Hide()
        Admin_home.Show()
    End Sub

    Private Sub b_about_Click(sender As System.Object, e As System.EventArgs) Handles b_about.Click
        about_form.Show()
    End Sub

    Private Sub b_ovaerall_sched_Click(sender As System.Object, e As System.EventArgs) Handles b_ovaerall_sched.Click
        Me.Hide()
        Admin_Rooms.Show()
    End Sub

    Private Sub b_edit_reservation_Click(sender As System.Object, e As System.EventArgs) Handles b_edit_reservation.Click
        Me.Hide()
        Admin_Report.Show()
    End Sub
End Class