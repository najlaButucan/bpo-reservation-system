Public Class reserved_materials_form

    ''NAJ
    Private Sub reserved_materials_form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'connect db
        b_reservation.Enabled = False
    End Sub
    Private Sub close_label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_label.Click
        Me.Close()
    End Sub

    Private Sub b_reservation_nxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_reservation_nxt.Click
        student_event_form.Show()
        Me.Hide()
    End Sub

    Private Sub b_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_back.Click
        Me.Close()
        reservation_form.Show()
    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub


End Class

'TASK TO BE DONE:
' - DAPAT MAY CANCEL BUTTON (SO COPY PASTE NLANG THE DESIGN)
' - DAPAT MAY HOME BUTTON AT ABOUT US NA BUTTON 
' - YUNG CHECKBOX DAPAT KUKUHA SIYA NG INFO SA DATABASE 