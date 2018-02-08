﻿Public Class overall_sched_form

    Private Sub b_reservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_reservation.Click
        Me.Hide()
        reservation_form.Show()
    End Sub

    Private Sub close_label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_label.Click
        Me.Close()
        reservation_form.Close()
        reserved_materials_form.Close()
        student_event_form.Close()
        edit_reservation_form.Close()
        home_form.Close()
    End Sub

    Private Sub b_edit_reservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_edit_reservation.Click
        Me.Hide()
        edit_reservation_form.Show()
    End Sub

    Private Sub b_home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_home.Click
        Me.Hide()
        home_form.Show()
    End Sub

    Private Sub b_about_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_about.Click
        Me.Hide()
        about_form.Show()
    End Sub
End Class