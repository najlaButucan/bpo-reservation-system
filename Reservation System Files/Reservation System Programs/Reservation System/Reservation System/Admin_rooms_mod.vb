Public Class Admin_rooms_mod

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Admin_equip.Show()
        Me.Hide()
    End Sub

    Private Sub b_reports_Click(sender As System.Object, e As System.EventArgs) Handles b_reports.Click
        Reports.Show()
        Me.Hide()
    End Sub

    Private Sub close_label_Click(sender As System.Object, e As System.EventArgs) Handles close_label.Click
        Admin_equip.Close()
        Admin_rooms.Close()
        Admin_add.Close()
        Me.Close()
        Reports.Close()
        LOGIN.Show()
    End Sub

    Private Sub b_edit_Click(sender As System.Object, e As System.EventArgs) Handles b_edit.Click
        Admin_rooms.Show()
        Me.Hide()
    End Sub

    Private Sub b_add_Click(sender As System.Object, e As System.EventArgs) Handles b_add.Click
        Me.Hide()
        Admin_add.Show()
    End Sub
End Class