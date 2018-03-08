Imports MySql.Data.MySqlClient
Public Class _Login
    Public userlvl As String

    Dim conn As New MySqlConnection
    Dim reader As MySqlDataReader
    Dim user As String

    Private Sub OK_Click(sender As System.Object, e As System.EventArgs) Handles OK.Click

        conn.ConnectionString = String.Format("server=localhost; user id=root; password=baba; database=dbusers")
        conn.Open()


        Dim cmd As New MySqlCommand("Select Password From tbusers where Username LIKE '" & UsernameTextBox.Text & "'", conn)

        reader = cmd.ExecuteReader()
        reader.Read()

        If reader.HasRows() Then

            If PasswordTextBox.Text = reader(0).ToString Then

                If user = "admin" Or user = "ADMIN" Then
                    userlvl = "ADMIN"
                    Me.Hide()
                    Admin_home.Show()
                ElseIf user = "ppo" Or user = "PPO" Or user = "osa" Or user = "OSA" Then
                    userlvl = "USER"
                    Me.Hide()
                    home_form.Show()
                End If

            Else
                MsgBox("Incorrect Password.")
            End If
        Else
            MsgBox("Incorrect Username")
        End If


        reader.Close()
        conn.Close()
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
