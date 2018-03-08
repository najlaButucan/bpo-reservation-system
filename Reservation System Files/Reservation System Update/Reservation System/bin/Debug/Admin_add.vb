Imports MySql.Data.MySqlClient
Public Class Admin_add
    Dim buildingID As Integer
    Dim conn As New MySqlConnection

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

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
        Admin_Rooms.Close()
        Admin_Rooms.Show()
    End Sub

    Private Sub btnConfirm_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirm.Click
        If cmbBuilding.Text = "MO" Then
            buildingID = 1
        ElseIf cmbBuilding.Text = "LS" Then
            buildingID = 2
        End If

        If txtRoomCode.Text <> "" Or txtDescription.Text <> "" Then
            Dim cmd As New MySqlCommand("Insert Into tbrooms (BuildingID, RoomCode, Description) Values ('" & buildingID & "','" & txtRoomCode.Text & "','" & txtDescription.Text & "')", conn)
            cmd.ExecuteNonQuery()

            buildingID = 0
            cmbBuilding.Text = ""
            txtRoomCode.Text = ""
            txtDescription.Text = ""

            MsgBox("Add Successful")
        Else
            MsgBox("All fields are required")
        End If
    End Sub

    Private Sub Admin_add_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        conn.ConnectionString = String.Format("server=localhost; user id=root; password=baba; database=dbbporeservationsystem")
        conn.Open()

        _Login.userlvl = "ADMIN"
    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class