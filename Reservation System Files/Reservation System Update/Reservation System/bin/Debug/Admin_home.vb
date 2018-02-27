Public Class Admin_home

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label4.Text = Format(Now, "hh:mm tt")
        Label3.Text = Format(Now, "MMMM dd, yyyy")
    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click
        Me.Close()
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
End Class