Public Class reserved_materials_form

    Private Sub close_label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_label.Click
        Me.Close()
        reservation_form.Close()
        student_event_form.Close()
        overall_sched_form.Close()
        edit_reservation_form.Close()
        home_form.Close()
    End Sub

    Private Sub b_reservation_nxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_reservation_nxt.Click
        student_event_form.Show()
        Me.Hide()
    End Sub

    Private Sub b_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_back.Click
        Me.Hide()
        reservation_form.Show()
    End Sub
End Class
