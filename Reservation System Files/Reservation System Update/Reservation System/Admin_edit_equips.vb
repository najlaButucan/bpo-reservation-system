Imports MySql.Data.MySqlClient

Public Class Admin_edit_equips
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

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub b_reservation_Click(sender As System.Object, e As System.EventArgs) Handles b_reservation.Click

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
        Me.Hide()
        Admin_Equips.Show()
    End Sub

    Private Sub btnConfirm_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirm.Click
        Dim cmd As New MySqlCommand("Update tbequipments Set EquipmentCode = '" & txtEquipmentName.Text & "', Description = '" & txtDescription.Text & "', Quantity = '" & txtQuantity.Text & "' Where EquipmentID = " & Admin_Equips.materials_checked.SelectedCells(0).Value & "", conn)
        cmd.ExecuteNonQuery()

        txtEquipmentName.Text = ""
        txtQuantity.Text = ""
        txtDescription.Text = ""

        MsgBox("Edit Successful")
    End Sub

    Private Sub Admin_edit_equips_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        conn.ConnectionString = String.Format("server=localhost; user id=root; password=baba; database=dbbporeservationsystem")
        conn.Open()

        _Login.userlvl = "ADMIN"
    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Admin_Equips.Close()
        Admin_Equips.Show()
        Me.Close()
    End Sub
End Class