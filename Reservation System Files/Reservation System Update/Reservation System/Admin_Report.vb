Public Class Admin_Report
    ''lez do this together also 
    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click
        Me.Hide()
    End Sub

    Private Sub b_reservation_Click(sender As System.Object, e As System.EventArgs) Handles b_reservation.Click
        Me.Hide()
        Admin_Equips.Show()
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

    Private Sub Admin_Report_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class