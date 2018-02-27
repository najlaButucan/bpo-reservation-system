Public Class _Login
    Dim user As String

    Private Sub OK_Click(sender As System.Object, e As System.EventArgs) Handles OK.Click

        'CLARK CONNECT THIS SA DATABASE PLOX!!
        '' the user must be sa database magbase 
        ''AJA GOODLUCK 
        If user = "admin" Then
            Me.Hide()
            Admin_home.Show()
        ElseIf user = "user" Then
            Me.Hide()
            home_form.Show()
        Else
            MsgBox("Error")
        End If
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles UsernameTextBox.TextChanged
        user = UsernameTextBox.Text
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Cancel_Click(sender As System.Object, e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub _Login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

'' YOURE LOWKEY DOING EVERYTHING ERRTHING SO GOODLUCK XD 
'' WE MUST FINISH THIS TILL THURSDAY 
'' MUST FINIIIIIISHH!!!