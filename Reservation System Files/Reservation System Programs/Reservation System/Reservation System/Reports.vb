Public Class Reports

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Admin_equip.Show()
        Me.Hide()
    End Sub

    Private Sub b_rooms_Click(sender As System.Object, e As System.EventArgs) Handles b_rooms.Click
        Me.Hide()
        Admin_rooms_mod.Show()
    End Sub

    Private Sub close_label_Click(sender As System.Object, e As System.EventArgs) Handles close_label.Click
        Admin_equip.Close()
        Me.Close()
        Admin_rooms_mod.Close()
        Admin_rooms.Close()
        Admin_add.Close()
        LOGIN.Show()
    End Sub
End Class