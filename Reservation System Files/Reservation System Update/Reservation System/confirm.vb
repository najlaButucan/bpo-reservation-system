Imports MySql.Data.MySqlClient

Public Class confirm
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader

    Private Sub confirm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        conn.ConnectionString = String.Format("Server = localhost; user = root; password = baba; database = dbbporeservationsystem")
        conn.Open()

    End Sub
    Private Sub b_reservation_Click(sender As System.Object, e As System.EventArgs) Handles b_reservation.Click
        
        cmd = New MySqlCommand("INSERT INTO tbreservation(buildingID, roomID,reservationdate, ETimeIN, ETimeOut, no_occupants, studentID, purpose, organization, comments) VALUES (" & reserved_materials_form.buildingID & "," & reserved_materials_form.roomID & ",'" & reservation_form.DateTimePicker1.Text & "','" & reservation_form.txt_time.Text & "','" & reservation_form.txt_timeEnd.Text & "'," & reservation_form.txt_occupants.Text & ",'" & student_event_form.t_id_number.Text & "','" & student_event_form.t_reason.Text & "','" & reservation_form.txt_class.Text & "','" & _Login.UsernameTextBox.Text & "')", conn)
        cmd.ExecuteNonQuery()

        cmd = New MySqlCommand("SELECT * FROM tbstudent WHERE studentid='" & student_event_form.t_id_number.Text & "'", conn)
        reader = cmd.ExecuteReader()
        If reader.HasRows = False Then
            reader.Close()
            cmd = New MySqlCommand("INSERT INTO tbstudent(studentId, lastname, firstname, contactnumber) VALUES ('" & student_event_form.t_id_number.Text & "','" & student_event_form.t_last_name.Text & "','" & student_event_form.t_first_name.Text & "','" & student_event_form.t_contact_number.Text & "')", conn)
            cmd.ExecuteNonQuery()

        Else
            reader.Close()
        End If

        MsgBox("SUCCESS")

        Me.Hide()
        student_event_form.Hide()
        home_form.Show()
        home_form.ListView1.Visible = False

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

   
End Class

''TASK TO BE DONE 
''DAPAT DITO NA PAPASOK ANG LAHAT NG RESERVATION INFO 
''DI PWEDE MAGRESERVE PAG KULANG SO LAGAY KA NALANG NG MGA ALERT NA MUST FILL ALL SHIT GANERNs