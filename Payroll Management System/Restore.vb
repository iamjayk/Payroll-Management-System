Imports System.IO
Public Class Restore

    Private Sub Restore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = Now


        Dim sDBFile As String = "F:\Payroll Management System\Payroll Management System\bin\Debug\payroll.mdb"
        Dim sBackUpFile As String = "F:\Payroll Management System\payroll_BackUp.dat"
        If File.Exists(sBackUpFile) Then
            File.Copy(sBackUpFile, sDBFile, True)
        End If
        ProgressBar1.Value += 2

        If ProgressBar1.Value = 100 Then
            Timer1.Dispose()
            MsgBox("You have successfully restore your backup database....", MsgBoxStyle.OkOnly)
            MainForm.Show()
            Me.Close()

        End If

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class