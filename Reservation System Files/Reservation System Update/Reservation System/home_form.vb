Public Class home_form

    Private Sub home_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''CLARK LAMS NA CONNECT SA DATABASE
        b_reservation.Enabled = True
    End Sub

    Private Sub b_reservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_reservation.Click
        Me.Hide()
        reservation_form.Show()
    End Sub

    Private Sub b_ovaerall_sched_Click_1(sender As System.Object, e As System.EventArgs) Handles b_ovaerall_sched.Click
        overall_sched_form.Show()
        'overall_sched_form.Location = Screen.AllScreens(UBound(Screen.AllScreens)).Bounds.Location + New Point(100, 100)
        'overall_sched_form.Show()
    End Sub

    Private Sub b_edit_reservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_edit_reservation.Click
        Me.Hide()
        edit_reservation_form.Show()
    End Sub

    Private Sub b_about_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_about.Click
        Me.Hide()
        about_form.Show()
    End Sub

    Private Sub Time2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Time2.Tick
        Label2.Text = Format(Now, "hh:mm tt")
        Label3.Text = Format(Now, "MMMM dd, yyyy")
    End Sub

    Private Sub close_label_Click(sender As System.Object, e As System.EventArgs) Handles close_label.Click
        Me.Hide()
        _Login.Show()
    End Sub
End Class