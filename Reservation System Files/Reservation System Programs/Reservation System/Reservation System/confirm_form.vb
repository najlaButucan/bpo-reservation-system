Public Class confirm_form

    Private Sub b_YES_Click(sender As System.Object, e As System.EventArgs) Handles b_YES.Click
        home_form.Show()
    End Sub

    Private Sub b_NO_Click(sender As System.Object, e As System.EventArgs) Handles b_NO.Click
        Me.Hide()
    End Sub
End Class