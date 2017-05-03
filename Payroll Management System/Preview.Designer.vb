<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Preview
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Preview))
        Me.Empwise_payslipBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.payrollDataSet = New Payroll_Management_System.payrollDataSet
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Empwise_payslipTableAdapter = New Payroll_Management_System.payrollDataSetTableAdapters.Empwise_payslipTableAdapter
        CType(Me.Empwise_payslipBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.payrollDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Empwise_payslipBindingSource
        '
        Me.Empwise_payslipBindingSource.DataMember = "Empwise_payslip"
        Me.Empwise_payslipBindingSource.DataSource = Me.payrollDataSet
        '
        'payrollDataSet
        '
        Me.payrollDataSet.DataSetName = "payrollDataSet"
        Me.payrollDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 482)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(857, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Purple
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(179, 17)
        Me.ToolStripStatusLabel1.Text = "Report Developed By Ajay"
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "payrollDataSet_Empwise_payslip"
        ReportDataSource1.Value = Me.Empwise_payslipBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Payroll_Management_System.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-1, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(858, 482)
        Me.ReportViewer1.TabIndex = 1
        '
        'Empwise_payslipTableAdapter
        '
        Me.Empwise_payslipTableAdapter.ClearBeforeFill = True
        '
        'Preview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 504)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Preview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preview"
        CType(Me.Empwise_payslipBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.payrollDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Empwise_payslipBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents payrollDataSet As Payroll_Management_System.payrollDataSet
    Friend WithEvents Empwise_payslipTableAdapter As Payroll_Management_System.payrollDataSetTableAdapters.Empwise_payslipTableAdapter
End Class
