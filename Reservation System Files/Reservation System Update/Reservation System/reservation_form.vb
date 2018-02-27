Public Class reservation_form

    Dim org_name As String
    Dim date_needed As String
    Dim time_needed As String
    Dim time_ended As String
    Dim num_of_students As Integer
    Dim studentName As String
    Dim studentID As String

    ''CLARK

    Private Sub reservation_form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ''CONNECT SA DATABASE CLARK
        b_reservation.Enabled = False
    End Sub
    Private Sub b_edit_reservation_Click(sender As System.Object, e As System.EventArgs) Handles b_edit_reservation.Click
        Me.Hide()
        edit_reservation_form.Show()
    End Sub

    Private Sub b_home_Click(sender As System.Object, e As System.EventArgs) Handles b_home.Click
        Me.Hide()
        home_form.Show()
    End Sub

    Private Sub close_label_Click(sender As System.Object, e As System.EventArgs) Handles close_label.Click
        Me.Close()
    End Sub

    Private Sub b_about_Click(sender As System.Object, e As System.EventArgs) Handles b_about.Click
        Me.Hide()
        about_form.Show()
    End Sub

    Private Sub b_reservation_nxt_Click(sender As System.Object, e As System.EventArgs) Handles b_reservation_nxt.Click
        Me.Hide()
        reserved_materials_form.Show()
    End Sub
End Class


'NOTES
'dapat pag nagpress ang user ng ENTER lalabas yung summary so dapat may keypress