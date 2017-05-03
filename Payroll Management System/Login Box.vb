Public Class Login_Box

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim user As String
        Dim pass As String
        user = "admin"
        pass = "admin"

        If UsernameTextBox.Text = user And PasswordTextBox.Text = pass Then
            MessageBox.Show("Welcome " & UsernameTextBox.Text & "  to Payroll Management System", " login successfull ")
            MainForm.Show()
            Me.Visible = False
        Else : MessageBox.Show("Sorry " & UsernameTextBox.Text & " your username or password is incorrect", " Warning")
            UsernameTextBox.Focus()
            PasswordTextBox.Clear()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            End
        ElseIf MsgBoxResult.No Then
            UsernameTextBox.Focus()
        End If
    End Sub

End Class
