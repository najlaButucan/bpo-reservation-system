Imports MySql.Data.MySqlClient
Public Class Admin_edit
    Dim conn As New MySqlConnection
    Dim buildingID As Integer

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click
        Continue_form.Show()
    End Sub

    Private Sub b_home_Click(sender As System.Object, e As System.EventArgs) Handles b_home.Click
        Me.Hide()
        Admin_home.Show()
    End Sub

    Private Sub b_about_Click(sender As System.Object, e As System.EventArgs) Handles b_about.Click
        about_form.Show()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub b_reservation_Click(sender As System.Object, e As System.EventArgs) Handles b_reservation.Click

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Admin_Rooms.Close()
        Admin_Rooms.Show()
        Me.Close()
    End Sub

    Private Sub Admin_edit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        conn.ConnectionString = String.Format("server=localhost; user id=root; password=baba; database=dbbporeservationsystem")
        conn.Open()

        _Login.userlvl = "ADMIN"
    End Sub

    Private Sub btnConfirm_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirm.Click
        If CmbBuilding.Text = "MO" Then
            buildingID = 1
        ElseIf CmbBuilding.Text = "LS" Then
            buildingID = 2
        End If

        Dim cmd As New MySqlCommand("Update tbrooms Set BuildingID = '" & buildingID & "', Description = '" & txtDescription.Text & "', RoomCode = '" & TxtRoomCode.Text & "' Where RoomID = " & Admin_Rooms.materials_checked.SelectedCells(0).Value & "", conn)
        cmd.ExecuteNonQuery()

        CmbBuilding.Text = ""
        TxtRoomCode.Text = ""
        txtDescription.Text = ""

        MsgBox("Edit Successful")
    End Sub
End Class