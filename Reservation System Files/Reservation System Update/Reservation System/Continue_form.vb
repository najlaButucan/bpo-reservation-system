Public Class Continue_form

    Private Sub b_no_Click(sender As System.Object, e As System.EventArgs) Handles b_no.Click
        Me.Hide()
    End Sub


    Private Sub b_yes_Click(sender As System.Object, e As System.EventArgs) Handles b_yes.Click
        If _Login.userlvl = "ADMIN" Then
            Me.Hide()
            Admin_add.Hide()
            Admin_add_equips.Hide()
            Admin_edit.Hide()
            Admin_edit_equips.Hide()
            Admin_Equips.Hide()
            Admin_Report.Hide()
            Admin_Rooms.Hide()
            Admin_home.Show()
        ElseIf _Login.userlvl = "USER" Then
            '' all forms will be hidden 
            Me.Hide()
            reservation_form.Hide()
            reserved_materials_form.Hide()
            student_event_form.Hide()
            home_form.Show()

        End If
    End Sub


End Class