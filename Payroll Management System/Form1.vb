Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 2

        If ProgressBar1.Value <= 30 Then
            Label3.Text = "Initializing System....."
        ElseIf ProgressBar1.Value <= 50 Then
            Label3.Text = "Loading Components....."
        ElseIf ProgressBar1.Value <= 70 Then
            Label3.Text = "Integrating Database...."
        ElseIf ProgressBar1.Value <= 100 Then
            Label3.Text = "Please wait..."
        End If

        If ProgressBar1.Value = 100 Then
            Timer1.Dispose()
            Me.Visible = False
            Login_Box.Show()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class
