Public Class Admin_equip

    Private Sub b_User_mod_Click(sender As System.Object, e As System.EventArgs)
        LOGIN.Show()
        Me.Hide()
    End Sub

    Private Sub b_rooms_Click(sender As System.Object, e As System.EventArgs) Handles b_rooms.Click
        Admin_rooms_mod.Show()
        Me.Hide()
    End Sub

    Private Sub b_reports_Click(sender As System.Object, e As System.EventArgs) Handles b_reports.Click
        Reports.Show()
        Me.Hide()
    End Sub

    Private Sub close_label_Click(sender As System.Object, e As System.EventArgs) Handles close_label.Click
        Admin_rooms_mod.Close()
        Me.Close()
        Reports.Close()
        Admin_rooms.Close()
        Admin_add.Close()
        LOGIN.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub b_edit_Click(sender As System.Object, e As System.EventArgs) Handles b_edit.Click
        Me.Hide()
        Admin_rooms.Show()
    End Sub

    Private Sub b_add_Click(sender As System.Object, e As System.EventArgs) Handles b_add.Click
        Me.Hide()
        Admin_add.Show()
    End Sub
End Class