Imports MySql.Data.MySqlClient
Public Class Admin_Equips
    Dim conn As New MySqlConnection
    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click
        Me.Hide()
        Admin_home.Show()
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

    Private Sub b_edit_reservation_Click(sender As System.Object, e As System.EventArgs) Handles b_edit_reservation.Click
        Me.Hide()
        Admin_Report.Show()
    End Sub

    Private Sub btnShow_Click(sender As System.Object, e As System.EventArgs)
        

    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        Me.Hide()
        Admin_edit_equips.Show()
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Me.Hide()
        Admin_add_equips.Show()
    End Sub

    Private Sub Admin_Equips_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        conn.ConnectionString = String.Format("server=localhost; user id=root; password=baba; database=dbbporeservationsystem")
        Dim cmd As New MySqlCommand("Select * From tbequipments", conn)
        conn.Open()
        _Login.userlvl = "ADMIN"

        Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim ds As DataSet = New DataSet
        da.Fill(ds, "tbequipments")
        materials_checked.DataSource = ds.Tables(0).DefaultView
    End Sub
End Class