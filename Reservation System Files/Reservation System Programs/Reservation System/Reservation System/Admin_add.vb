Public Class Admin_add

    Private Sub close_label_Click(sender As System.Object, e As System.EventArgs) Handles close_label.Click
        Admin_rooms_mod.Close()
        Me.Close()
        Reports.Close()
        Admin_rooms.Close()
        Admin_equip.Close()
        LOGIN.Show()
    End Sub

    Private Sub b_reservation_nxt_Click(sender As System.Object, e As System.EventArgs) Handles b_reservation_nxt.Click
        confirm_form.Show()
    End Sub

    Private Sub b_equip_Click(sender As System.Object, e As System.EventArgs) Handles b_equip.Click
        Me.Hide()
        Admin_equip.Show()
    End Sub

    Private Sub b_rooms_Click(sender As System.Object, e As System.EventArgs) Handles b_rooms.Click
        Me.Hide()
        Admin_rooms_mod.Show()
    End Sub

    Private Sub b_reports_Click(sender As System.Object, e As System.EventArgs) Handles b_reports.Click
        Me.Hide()
        Reports.Show()
    End Sub
End Class