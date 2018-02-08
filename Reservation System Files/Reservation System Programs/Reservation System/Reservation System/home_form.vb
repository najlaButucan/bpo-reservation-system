Public Class home_form

    Private Sub b_edit_reservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_edit_reservation.Click
        Me.Hide()
        edit_reservation_form.Show()
    End Sub

    Private Sub b_ovaerall_sched_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_ovaerall_sched.Click
        Me.Hide()
        overall_sched_form.Show()
    End Sub

    Private Sub b_reservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_reservation.Click
        Me.Hide()
        reservation_form.Show()
    End Sub

    Private Sub close_label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_label.Click
        Me.Close()
        reservation_form.Close()
        reserved_materials_form.Close()
        student_event_form.Close()
        overall_sched_form.Close()
        edit_reservation_form.Close()
        LOGIN.Show()
    End Sub

    Private Sub Time2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Time2.Tick
        Label2.Text = Format(Now, "hh:mm tt")
        Label3.Text = Format(Now, "MMMM dd, yyyy")
    End Sub

    Private Sub b_about_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_about.Click
        Me.Hide()
        about_form.Show()
    End Sub
End Class