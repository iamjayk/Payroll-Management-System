Public Class Preview

    Private Sub Preview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'payrollDataSet.Empwise_payslip' table. You can move, or remove it, as needed.
        Me.Empwise_payslipTableAdapter.Fill(Me.payrollDataSet.Empwise_payslip)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class