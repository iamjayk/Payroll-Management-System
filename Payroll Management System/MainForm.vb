Public Class MainForm
    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = "Developed By Ajay"

    End Sub
    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Silver
        Button1.ForeColor = Color.Black
    End Sub

    Private Sub Button1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseMove
        Button1.BackColor = Color.Purple
        Button1.ForeColor = Color.White
    End Sub
    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        lv(sender)
    End Sub
    Private Sub lv(ByVal sender As Object)
        sender.BackColor = Color.Silver
        sender.ForeColor = Color.Black
    End Sub
    Private Sub mv(ByVal sender As Object)
        sender.BackColor = Color.Purple
        sender.ForeColor = Color.White
    End Sub

    Private Sub Button2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseMove
        mv(sender)
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        lv(sender)
    End Sub

    Private Sub Button3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseMove
        mv(sender)
    End Sub

    Private Sub Button4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseLeave
        lv(sender)
    End Sub

    Private Sub Button4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button4.MouseMove
        mv(sender)
    End Sub
    Private Sub Button5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.MouseLeave
        lv(sender)
    End Sub
    Private Sub Button5_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button5.MouseMove
        mv(sender)
    End Sub
    Private Sub Button6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.MouseLeave
        lv(sender)
    End Sub
    Private Sub Button6_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button6.MouseMove
        mv(sender)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dept.Visible = True
        Me.Hide()
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        payslip.Show()
        Me.Hide()
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Restore.Show()
        Me.Hide()
    End Sub

    
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        empwisepayslip.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        view_all.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        About.Show()
        Me.Hide()

    End Sub

    Private Sub Button7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.MouseLeave
        lv(sender)
    End Sub

    Private Sub Button7_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button7.MouseMove
        mv(sender)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If MsgBox("Make sure that no other application is running....", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Database_Backup.Show()
            Me.Visible = False
        ElseIf MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If MsgBox("Are you sure you want to exit this application?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            'Quit.Show()
            Me.Visible = False
        ElseIf MsgBoxResult.No Then
            Exit Sub
        End If

    End Sub

    Private Sub Button8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button8.MouseLeave
        lv(sender)
    End Sub

    Private Sub Button8_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button8.MouseMove
        mv(sender)
    End Sub

    Private Sub Button9_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        lv(sender)
    End Sub

    Private Sub Button9_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        mv(sender)
    End Sub

    Private Sub Button10_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        lv(sender)
    End Sub

    Private Sub Button10_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        mv(sender)
    End Sub

End Class
