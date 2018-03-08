Imports MySql.Data.MySqlClient

Public Class reserved_materials_form

    Public roomID As Integer
    Public buildingID As Integer
    Public equipments(10) As String
    Public counter As Integer = 0

    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader
  
    Private Sub reserved_materials_form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        conn.ConnectionString = String.Format("Server = localhost; user = root; password = baba; database = dbbporeservationsystem")
        conn.Open()

        b_reservation_nxt.Enabled = False
        b_reservation.Enabled = False

        l_org_show.Text = reservation_form.l_org_show.Text
        l_time_show.Text = reservation_form.l_time_show.Text
        l_date_show.Text = reservation_form.l_date_show.Text


       
        cmd = New MySqlCommand("SELECT description FROM tbequipments", conn)
        reader = cmd.ExecuteReader

        If reader.HasRows() Then
            While reader.Read()
                materials_choose.Items.Add(reader(0).ToString)
            End While
            reader.Close()

        Else
            reader.Close()

        End If
        _Login.userlvl = "USER"

    End Sub

    Private Sub close_label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_label.Click
        Continue_form.Show()
    End Sub

    Private Sub b_reservation_nxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_reservation_nxt.Click
        student_event_form.Show()
        Me.Hide()
    End Sub

    Private Sub b_confirm_Click(sender As System.Object, e As System.EventArgs) Handles b_confirm.Click

        If rb_classroom.Checked = False And rb_others.Checked = False Then
            MsgBox("Please choose a room/facility")

        Else
            If cb_room.Text = "" Then
                MsgBox("Please choose a room/facility")
            Else
                cmd = New MySqlCommand("SELECT buildingID, roomID FROM tbrooms WHERE description = '" & cb_room.Text & "'", conn)
                reader = cmd.ExecuteReader

                If reader.HasRows() Then
                    reader.Read()
                    buildingID = Val(reader(0).ToString)
                    roomID = Val(reader(1).ToString)
                    reader.Close()
                Else
                    reader.Close()
                End If

                cmd = New MySqlCommand("SELECT * FROM tbreservation WHERE (buildingID = " & buildingID & " AND roomID = " & roomID & ") AND (reservationdate LIKE '" & reservation_form.DateTimePicker1.Text & "' AND EtimeIn LIKE '" & reservation_form.txt_time.Text & "')", conn)
                reader = cmd.ExecuteReader

                If reader.HasRows() Then
                    reader.Close()
                    MsgBox("ROOM IS ALREADY RESERVED")
                Else
                    reader.Close()
                    l_room_number_show.Text = cb_room.Text
                End If

                b_reservation_nxt.Enabled = True

                ListBox1.Items.Add("Equipments Reserved")
                For i As Integer = 0 To materials_choose.Items.Count - 1
                    If materials_choose.GetItemChecked(i) = True Then
                        ListBox1.Items.Add(materials_choose.Items(i))
                        equipments(counter) = materials_choose.Items(i)
                        counter += 1
                    End If
                Next
            End If



        End If



    End Sub

    Private Sub cb_room_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cb_room.SelectedIndexChanged
       

    End Sub

    Private Sub b_back_Click(sender As System.Object, e As System.EventArgs) Handles b_back.Click
        Me.Hide()
        reservation_form.Show()
    End Sub

    Private Sub b_home_Click(sender As System.Object, e As System.EventArgs) Handles b_home.Click
        Me.Hide()
        home_form.Show()
        home_form.ListView1.Visible = False
    End Sub

    Private Sub b_about_Click(sender As System.Object, e As System.EventArgs)
        about_form.Show()
    End Sub

    'Private Sub facilities_choose_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
    '    If facilities_choose.SelectedItem.ToString = "Classroom" Then
    '        cmd = New MySqlCommand("SELECT description FROM tbrooms WHERE buildingID <= 5", conn)
    '        reader = cmd.ExecuteReader()

    '        If reader.HasRows() Then
    '            cb_room.Items.Clear()
    '            While reader.Read()
    '                cb_room.Items.Add(reader(0).ToString)
    '            End While
    '            reader.Close()
    '        End If
    '    Else
    '        cmd = New MySqlCommand("SELECT description FROM tbrooms WHERE buildingID >= 6", conn)
    '        reader = cmd.ExecuteReader()

    '        If reader.HasRows() Then
    '            cb_room.Items.Clear()
    '            While reader.Read()
    '                cb_room.Items.Add(reader(0).ToString)
    '            End While
    '            reader.Close()
    '        End If

    '    End If

    'End Sub

    Private Sub rb_classroom_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rb_classroom.CheckedChanged, rb_others.CheckedChanged
        If rb_classroom.Checked = True Then
            cmd = New MySqlCommand("SELECT description FROM tbrooms WHERE buildingID <= 5", conn)
            reader = cmd.ExecuteReader()

            If reader.HasRows() Then
                cb_room.Items.Clear()
                While reader.Read()
                    cb_room.Items.Add(reader(0).ToString)
                End While
                reader.Close()
            End If

        ElseIf rb_others.Checked = True Then
            cmd = New MySqlCommand("SELECT description FROM tbrooms WHERE buildingID >= 6", conn)
            reader = cmd.ExecuteReader()

            If reader.HasRows() Then
                cb_room.Items.Clear()
                While reader.Read()
                    cb_room.Items.Add(reader(0).ToString)
                End While
                reader.Close()
            End If

        End If
    End Sub
End Class

'TASK TO BE DONE:
' - DAPAT MAY CANCEL BUTTON (SO COPY PASTE NLANG THE DESIGN)
' - DAPAT MAY HOME BUTTON AT ABOUT US NA BUTTON 
' - YUNG CHECKBOX DAPAT KUKUHA SIYA NG INFO SA DATABASE 