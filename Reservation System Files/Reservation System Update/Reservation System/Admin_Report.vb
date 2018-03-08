Imports MySql.Data.MySqlClient

Public Class Admin_Report
    ''lez do this together also 
    Dim conn As New MySqlConnection
    Dim reader As MySqlDataReader
    Dim list As New ListViewItem

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click
        Me.Hide()
        _Login.Close()
    End Sub

    Private Sub b_reservation_Click(sender As System.Object, e As System.EventArgs) Handles b_reservation.Click
        Me.Hide()
        Admin_Equips.Show()
    End Sub

    Private Sub b_home_Click(sender As System.Object, e As System.EventArgs) Handles b_home.Click
        Me.Hide()
        Admin_home.Show()
    End Sub

    Private Sub b_about_Click(sender As System.Object, e As System.EventArgs) Handles b_about.Click
        about_form.Show()
    End Sub

    Private Sub b_ovaerall_sched_Click(sender As System.Object, e As System.EventArgs) Handles b_ovaerall_sched.Click
        Me.Hide()
        Admin_Rooms.Show()
    End Sub

    Private Sub Admin_Report_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        conn.ConnectionString = String.Format("server=localhost; user id=root; password=baba; database=dbbporeservationsystem")

    End Sub

    Private Sub b_reservation_nxt_Click(sender As Object, e As EventArgs)
        

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub b_reservation_nxt_Click_1(sender As System.Object, e As System.EventArgs) Handles b_reservation_nxt.Click
        conn.Open()

        ListView1.GridLines = True

        Dim cmd As New MySqlCommand("Select * From tbreservation", conn)
        reader = cmd.ExecuteReader()

        If reader.HasRows() Then
            While reader.Read()
                list = New ListViewItem
                list.Text = reader(0).ToString
                list.SubItems.Add(reader(1).ToString)
                list.SubItems.Add(reader(2).ToString)
                list.SubItems.Add(reader(3).ToString)
                list.SubItems.Add(reader(4).ToString)
                list.SubItems.Add(reader(5).ToString)
                list.SubItems.Add(reader(6).ToString)
                list.SubItems.Add(reader(7).ToString)
                list.SubItems.Add(reader(8).ToString)
                list.SubItems.Add(reader(9).ToString)
                list.SubItems.Add(reader(10).ToString)
                list.SubItems.Add(reader(11).ToString)
                ListView1.Items.Add(list)
            End While
            reader.Close()
        Else
            reader.Close()
        End If
    End Sub
End Class