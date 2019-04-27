Public Class about_form

    Private Sub b_home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_home.Click
        Me.Hide()
    End Sub

    Private Sub close_label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_label.Click
        Me.Close()
        reservation_form.Close()
        reserved_materials_form.Close()
        student_event_form.Close()
        overall_sched_form.Close()
        edit_reservation_form.Close()
        home_form.Close()
    End Sub
End Class