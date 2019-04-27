Public Class Login

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click, Cancel.Click
        Me.Close()
    End Sub

    Private Sub OK_Click(sender As System.Object, e As System.EventArgs) Handles OK.Click
        Me.Hide()
        reservation_form.Show()
    End Sub
End Class