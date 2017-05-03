Imports System.IO

Public Class Database_Backup

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = Now

        Dim sDBFile As String = "F:\Dream Project\Payroll Management System\Payroll Management System\bin\Debug\payroll.mdb"

        Dim tempFile As String = "F:\Payroll Management System\tempBackUp.mdb"
        Dim sBackUpFile As String = "F:\Payroll Management System\payroll_BackUp.dat"

        If File.Exists(sDBFile) Then
            Dim db As New dao.DBEngine
            db.CompactDatabase(sDBFile, tempFile)
            File.Copy(tempFile, sBackUpFile, True)
        
            File.Delete(tempFile)
        End If

        ProgressBar1.Value += 2

        If ProgressBar1.Value = 100 Then
            Timer1.Dispose()
            MsgBox("You can find the backup file in D:\Payroll Management System\payroll_BackUp.dat", MsgBoxStyle.OkOnly)
            MainForm.Show()
            Me.Close()

        End If
    End Sub

    Private Sub Database_Backup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class