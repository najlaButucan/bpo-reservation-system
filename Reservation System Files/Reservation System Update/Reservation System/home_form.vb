Imports MySql.Data.MySqlClient

Public Class home_form

    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim list As ListViewItem
    Dim counter As Integer

    Private Sub home_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = String.Format("Server = localhost; user = root; password = baba; database = dbbporeservationsystem;")
        conn.Open()
        b_reservation.Enabled = True


        cmd = New MySqlCommand("SELECT dateofreservation, studentID FROM tbreservation", conn)
        reader = cmd.ExecuteReader()
        If reader.HasRows() Then

            While reader.Read()
                counter += 1
            End While
            reader.Close()
        Else
            reader.Close()
        End If

        Label5.Text = counter

        ListView1.Visible = False

    End Sub

    Private Sub b_reservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_reservation.Click
        Me.Hide()
        reservation_form.Show()
    End Sub

    Private Sub b_ovaerall_sched_Click_1(sender As System.Object, e As System.EventArgs) Handles b_ovaerall_sched.Click
        overall_sched_form.Show()
    End Sub

    Private Sub b_edit_reservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_edit_reservation.Click
        Me.Hide()
        edit_reservation_form.Show()
    End Sub

    Private Sub b_about_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_about.Click
        about_form.Show()
    End Sub

    Private Sub Time2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Time2.Tick
        Label2.Text = Format(Now, "hh:mm tt")
        Label3.Text = Format(Now, "MMMM dd, yyyy")
    End Sub

    Private Sub close_label_Click(sender As System.Object, e As System.EventArgs) Handles close_label.Click
        Me.Hide()
        Application.Restart()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ListView1.Visible = True
        ListView1.Items.Clear()

        cmd = New MySqlCommand("SELECT dateofreservation, studentID, comments FROM tbreservation", conn)
        reader = cmd.ExecuteReader()
        If reader.HasRows() Then

            While reader.Read()
                list = New ListViewItem
                list.Text = reader(0).ToString
                list.SubItems.Add(reader(1).ToString & " reserved a room. User = " & reader(2).ToString)
                ListView1.Items.Add(list)
            End While
            reader.Close()
        Else
            reader.Close()
        End If
        Label5.Visible = False
    End Sub

End Class