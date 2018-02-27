Public Class edit_reservation_form

    'CLARK IGNORE THIS FORM MUNA.. SABAY TAYO MAG CODE NETO HUEHUE
    Private Sub close_label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_label.Click
        Me.Close()
     
    End Sub

    Private Sub b_ovaerall_sched_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_ovaerall_sched.Click
        overall_sched_form.Show()
        Me.Hide()
    End Sub

    Private Sub b_reservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_reservation.Click
        Me.Hide()
        reservation_form.Show()
    End Sub

    Private Sub b_home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_home.Click
        Me.Hide()
        home_form.Show()
    End Sub

    Private Sub b_about_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_about.Click
        Me.Hide()
        about_form.Show()
    End Sub

    Private Sub reserved_room_list_view_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles reserved_room_list_view.CellContentClick

    End Sub

    Private Sub l_date_show_Click(sender As System.Object, e As System.EventArgs) Handles l_date_show.Click

    End Sub

    Private Sub edit_reservation_form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

'TASK TO BE DONE 
' 