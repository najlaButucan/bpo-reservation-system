Imports MySql.Data.MySqlClient

Public Class edit_reservation_form
    Dim list As ListViewItem
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim adapter As MySqlDataAdapter
    Dim dataset As New DataSet
    Dim source As New BindingSource

    Dim delete_item As String
    Dim roomID As Integer
    Dim buildingID As Integer

    Private Sub close_label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_label.Click
        Me.Hide()
        home_form.Show()
        home_form.ListView1.Visible = False
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
        home_form.ListView1.Visible = False
    End Sub

    Private Sub b_about_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_about.Click
        about_form.Show()
    End Sub

    Private Sub reserved_room_list_view_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub l_date_show_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub edit_reservation_form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        conn.ConnectionString = String.Format("Server = localhost; user = root; password = baba; database = dbbporeservationsystem;")
        conn.Open()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        cmd = New MySqlCommand("SELECT tbrooms.description, tbreservation.dateofreservation, tbreservation.EtimeIn,tbreservation.EtimeOut, tbreservation.no_occupants, tbreservation.purpose, tbreservation.Organization FROM tbreservation INNER JOIN tbrooms ON tbrooms.roomID = tbreservation.roomID AND tbrooms.buildingID = tbreservation.buildingID WHERE studentID = '" & t_id_number.Text & "'", conn)
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
                ListView1.Items.Add(list)
            End While
            reader.Close()
        Else
            reader.Close()
        End If

        


    End Sub

    Private Sub b_edit_Click(sender As System.Object, e As System.EventArgs) Handles b_edit.Click
        delete_item = ListView1.Items(0).Text


        cmd = New MySqlCommand("SELECT tbreservation.buildingID, tbreservation.roomID from tbreservation INNER JOIN tbrooms ON tbreservation.buildingID = tbrooms.buildingID AND tbreservation.roomID = tbrooms.roomID WHERE tbrooms.description = '" & delete_item & "'", conn)
        reader = cmd.ExecuteReader

        If reader.HasRows() Then
            While reader.Read
                buildingID = reader(0).ToString
                roomID = reader(1).ToString
            End While
            reader.Close()
        End If
        reader.Close()

        cmd = New MySqlCommand("DELETE FROM tbreservation WHERE roomID = " & roomID & " AND buildingID =" & buildingID, conn)
        cmd.ExecuteNonQuery()
        ListView1.Items.Clear()

        cmd = New MySqlCommand("SELECT tbrooms.description, tbreservation.dateofreservation, tbreservation.EtimeIn,tbreservation.EtimeOut, tbreservation.no_occupants, tbreservation.purpose, tbreservation.Organization FROM tbreservation INNER JOIN tbrooms ON tbrooms.roomID = tbreservation.roomID AND tbrooms.buildingID = tbreservation.buildingID WHERE studentID = '" & t_id_number.Text & "'", conn)
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
                ListView1.Items.Add(list)
            End While
            reader.Close()
        Else
            reader.Close()
        End If

        t_id_number.Clear()
    End Sub
End Class

'TASK TO BE DONE 
' 