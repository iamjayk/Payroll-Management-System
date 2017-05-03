Imports System.Data.OleDb
Imports System.Data
Public Class empwisepayslip
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\Payroll Management System\Payroll Management System\payroll.mdb;")
    Dim dt, dt2 As New DataTable
    Dim adp, adp2 As OleDbDataAdapter
    Dim i As Integer

    Private Sub payslip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()
        adp = New OleDbDataAdapter("select distinct EmpName from Empwise_payslip", con)
        adp.Fill(dt)
        ComboBox1.DataSource = dt
        ComboBox1.DisplayMember = "EmpName"
        Me.Label1.Text = Format(Now, "dd-MM-yyyy") & vbCrLf & Now.ToLongTimeString.ToString()
        Me.Width = "937"
        Me.Height = "408"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        dt2 = New DataTable
        If i = 1 Then
            adp2 = New OleDbDataAdapter("select * from Empwise_payslip where EmpName='" & ComboBox1.Text & "'", con)
        Else
            adp2 = New OleDbDataAdapter("select * from Empwise_payslip where Emp_ID='" & ComboBox1.Text & "'", con)
        End If
        adp2.Fill(dt2)
        DataGridView1.DataSource = dt2
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        dt = New DataTable
        adp = New OleDbDataAdapter("select distinct EmpName from Empwise_payslip", con)
        adp.Fill(dt)
        ComboBox1.DataSource = dt
        ComboBox1.DisplayMember = "EmpName"
        i = 1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dt = New DataTable
        adp = New OleDbDataAdapter("select distinct Emp_ID from Empwise_payslip", con)
        adp.Fill(dt)
        ComboBox1.DataSource = dt
        ComboBox1.DisplayMember = "Emp_ID"
        i = 2
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        con.Close()


        Me.Close()
        MainForm.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        view_all.Show()
        Me.Visible = False

    End Sub
End Class