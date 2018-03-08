Imports MySql.Data.MySqlClient

Public Class reservation_form
    Dim startTime As DateTime

    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader

    Private Sub reservation_form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        conn.ConnectionString = String.Format("server=localhost; user id=root; password=baba; database=dbbporeservationsystem")
        conn.Open()
        b_reservation_nxt.Enabled = False
        b_reservation.Enabled = False

        _Login.userlvl = "USER"

    End Sub
    Private Sub b_edit_reservation_Click(sender As System.Object, e As System.EventArgs) Handles b_edit_reservation.Click
        Me.Hide()
        edit_reservation_form.Show()
    End Sub

    Private Sub b_home_Click(sender As System.Object, e As System.EventArgs) Handles b_home.Click
        Me.Hide()
        home_form.Show()
        home_form.ListView1.Visible = False
    End Sub
    Private Sub close_label_Click(sender As System.Object, e As System.EventArgs) Handles close_label.Click
        Continue_form.Show()
    End Sub

    Private Sub b_about_Click(sender As System.Object, e As System.EventArgs) Handles b_about.Click
        about_form.Show()
    End Sub

    Private Sub b_reservation_nxt_Click(sender As System.Object, e As System.EventArgs) Handles b_reservation_nxt.Click
        Me.Hide()
        reserved_materials_form.Show()
    End Sub

    Private Sub b_confirm_Click(sender As System.Object, e As System.EventArgs) Handles b_confirm.Click
        txt_time.Format = DateTimePickerFormat.Custom
        txt_time.CustomFormat = "hh:mm:ss tt"

        txt_timeEnd.Format = DateTimePickerFormat.Custom
        txt_timeEnd.CustomFormat = "hh:mm:ss tt"

        If txt_time.Text = txt_timeEnd.Text Then
            MsgBox("Time must have an interval of atleast 1 hour")
            If txt_class.Text = "" Or txt_occupants.Text = "" Then
                MsgBox("All fields must be filled")
            End If

        Else
            l_org_show.Text = txt_class.Text
            l_time_show.Text = txt_time.Text & " - " & txt_timeEnd.Text
            l_date_show.Text = DateTimePicker1.Text
            l_occupants.Text = txt_occupants.Text & " est. persons"

            b_reservation_nxt.Enabled = True
        End If


    End Sub
End Class
