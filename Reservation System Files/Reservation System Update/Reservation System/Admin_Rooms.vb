Imports MySql.Data.MySqlClient

Public Class Admin_Rooms
    Dim conn As New MySqlConnection
    Private Sub Admin_Rooms_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        conn.ConnectionString = String.Format("server=localhost; user id=root; password=baba; database=dbbporeservationsystem")
        Dim cmd As New MySqlCommand("Select * From tbrooms", conn)

        _Login.userlvl = "ADMIN"
        conn.Open()
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim ds As DataSet = New DataSet
        da.Fill(ds, "tbrooms")
        materials_checked.DataSource = ds.Tables(0).DefaultView
    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click
        Me.Hide()
        Admin_home.Show()

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


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
        Me.Hide()
        Admin_add.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        Me.Hide()
        Admin_edit.Show()
    End Sub

    Private Sub b_reservation_nxt_Click(sender As System.Object, e As System.EventArgs)
        
    End Sub

    Private Sub b_edit_reservation_Click(sender As System.Object, e As System.EventArgs) Handles b_edit_reservation.Click
        Me.Hide()
        Admin_Report.Show()
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Me.Hide()
        Admin_add.Show()
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        Me.Hide()
        Admin_edit.Show()
    End Sub
End Class