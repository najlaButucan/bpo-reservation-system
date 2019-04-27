Public Class student_event_form

    Private Sub close_label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_label.Click
        Me.Close()
        reservation_form.Close()
        reserved_materials_form.Close()
        overall_sched_form.Close()
        edit_reservation_form.Close()
        home_form.Close()
    End Sub

    Private Sub b_reservation_nxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_reservation_nxt.Click
        confirm_form.Show()
    End Sub

    Private Sub b_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_back.Click
        Me.Hide()
        reserved_materials_form.Show()
    End Sub
End Class
