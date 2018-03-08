Imports MySql.Data.MySqlClient

Public Class student_event_form
    Dim roomID As Integer
    Dim buildingID As Integer

    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader

    Private Sub student_event_form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        conn.ConnectionString = String.Format("Server = localhost; user = root; password = baba; database = dbbporeservationsystem")
        conn.Open()
        _Login.userlvl = "USER"
        Button1.Enabled = False
        b_reservation.Enabled = False
        l_room_number_show.Text = reserved_materials_form.l_room_number_show.Text
        l_org_show.Text = reservation_form.l_org_show.Text
        l_time_show.Text = reservation_form.l_time_show.Text
        l_date_show.Text = reservation_form.l_date_show.Text

    End Sub

    Private Sub close_label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_label.Click
        Continue_form.Show()
    End Sub

    Private Sub b_reservation_nxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        confirm.Show()
    End Sub

    Private Sub b_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        reserved_materials_form.Show()
    End Sub


    Private Sub b_ok_Click(sender As System.Object, e As System.EventArgs) Handles b_ok.Click
        l_idnum.Text = t_id_number.Text
        l_studentName.Text = t_last_name.Text & ", " & t_first_name.Text
        l_conNum.Text = t_contact_number.Text
        l_reason.Text = t_reason.Text

        Button1.Enabled = True

    End Sub

    Private Sub b_about_Click(sender As System.Object, e As System.EventArgs)
        about_form.Show()
    End Sub

    Private Sub b_home_Click(sender As System.Object, e As System.EventArgs) Handles b_home.Click
        Me.Hide()
        home_form.Show()

    End Sub
End Class
