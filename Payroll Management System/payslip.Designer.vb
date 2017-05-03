<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payslip
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
        Dim Emp_IDLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim EmpNameLabel As System.Windows.Forms.Label
        Dim Date_Of_JoinLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim BasicSalLabel As System.Windows.Forms.Label
        Dim LeaveLabel As System.Windows.Forms.Label
        Dim DALabel As System.Windows.Forms.Label
        Dim TALabel As System.Windows.Forms.Label
        Dim HRALabel As System.Windows.Forms.Label
        Dim PFLabel As System.Windows.Forms.Label
        Dim ITAXLabel As System.Windows.Forms.Label
        Dim COMMLabel As System.Windows.Forms.Label
        Dim Net_SalaryLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(payslip))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Net_SalaryTextBox = New System.Windows.Forms.TextBox
        Me.Empwise_payslipBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PayrollDataSet = New Payroll_Management_System.payrollDataSet
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.COMMTextBox = New System.Windows.Forms.TextBox
        Me.ITAXTextBox = New System.Windows.Forms.TextBox
        Me.PFTextBox = New System.Windows.Forms.TextBox
        Me.HRATextBox = New System.Windows.Forms.TextBox
        Me.TATextBox = New System.Windows.Forms.TextBox
        Me.DATextBox = New System.Windows.Forms.TextBox
        Me.LeaveTextBox = New System.Windows.Forms.TextBox
        Me.BasicSalTextBox = New System.Windows.Forms.TextBox
        Me.AddressTextBox = New System.Windows.Forms.TextBox
        Me.EmpNameTextBox = New System.Windows.Forms.TextBox
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox
        Me.Emp_IDTextBox = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Date_Of_JoinDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Empwise_payslipTableAdapter = New Payroll_Management_System.payrollDataSetTableAdapters.Empwise_payslipTableAdapter
        Me.TableAdapterManager = New Payroll_Management_System.payrollDataSetTableAdapters.TableAdapterManager
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Emp_IDLabel = New System.Windows.Forms.Label
        DepartmentLabel = New System.Windows.Forms.Label
        EmpNameLabel = New System.Windows.Forms.Label
        Date_Of_JoinLabel = New System.Windows.Forms.Label
        AddressLabel = New System.Windows.Forms.Label
        BasicSalLabel = New System.Windows.Forms.Label
        LeaveLabel = New System.Windows.Forms.Label
        DALabel = New System.Windows.Forms.Label
        TALabel = New System.Windows.Forms.Label
        HRALabel = New System.Windows.Forms.Label
        PFLabel = New System.Windows.Forms.Label
        ITAXLabel = New System.Windows.Forms.Label
        COMMLabel = New System.Windows.Forms.Label
        Net_SalaryLabel = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Empwise_payslipBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrollDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Emp_IDLabel
        '
        Emp_IDLabel.AutoSize = True
        Emp_IDLabel.Location = New System.Drawing.Point(66, 39)
        Emp_IDLabel.Name = "Emp_IDLabel"
        Emp_IDLabel.Size = New System.Drawing.Size(62, 16)
        Emp_IDLabel.TabIndex = 0
        Emp_IDLabel.Text = "Emp ID:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Location = New System.Drawing.Point(339, 39)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(92, 16)
        DepartmentLabel.TabIndex = 2
        DepartmentLabel.Text = "Department:"
        '
        'EmpNameLabel
        '
        EmpNameLabel.AutoSize = True
        EmpNameLabel.Location = New System.Drawing.Point(66, 103)
        EmpNameLabel.Name = "EmpNameLabel"
        EmpNameLabel.Size = New System.Drawing.Size(88, 16)
        EmpNameLabel.TabIndex = 4
        EmpNameLabel.Text = "Emp Name:"
        '
        'Date_Of_JoinLabel
        '
        Date_Of_JoinLabel.AutoSize = True
        Date_Of_JoinLabel.Location = New System.Drawing.Point(339, 103)
        Date_Of_JoinLabel.Name = "Date_Of_JoinLabel"
        Date_Of_JoinLabel.Size = New System.Drawing.Size(97, 16)
        Date_Of_JoinLabel.TabIndex = 6
        Date_Of_JoinLabel.Text = "Date Of Join:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(66, 167)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(70, 16)
        AddressLabel.TabIndex = 8
        AddressLabel.Text = "Address:"
        '
        'BasicSalLabel
        '
        BasicSalLabel.AutoSize = True
        BasicSalLabel.Location = New System.Drawing.Point(339, 181)
        BasicSalLabel.Name = "BasicSalLabel"
        BasicSalLabel.Size = New System.Drawing.Size(78, 16)
        BasicSalLabel.TabIndex = 10
        BasicSalLabel.Text = "Basic Sal:"
        '
        'LeaveLabel
        '
        LeaveLabel.AutoSize = True
        LeaveLabel.Location = New System.Drawing.Point(73, 231)
        LeaveLabel.Name = "LeaveLabel"
        LeaveLabel.Size = New System.Drawing.Size(55, 16)
        LeaveLabel.TabIndex = 12
        LeaveLabel.Text = "Leave:"
        '
        'DALabel
        '
        DALabel.AutoSize = True
        DALabel.Location = New System.Drawing.Point(339, 240)
        DALabel.Name = "DALabel"
        DALabel.Size = New System.Drawing.Size(33, 16)
        DALabel.TabIndex = 14
        DALabel.Text = "DA:"
        '
        'TALabel
        '
        TALabel.AutoSize = True
        TALabel.Location = New System.Drawing.Point(74, 295)
        TALabel.Name = "TALabel"
        TALabel.Size = New System.Drawing.Size(32, 16)
        TALabel.TabIndex = 16
        TALabel.Text = "TA:"
        '
        'HRALabel
        '
        HRALabel.AutoSize = True
        HRALabel.Location = New System.Drawing.Point(339, 296)
        HRALabel.Name = "HRALabel"
        HRALabel.Size = New System.Drawing.Size(44, 16)
        HRALabel.TabIndex = 18
        HRALabel.Text = "HRA:"
        '
        'PFLabel
        '
        PFLabel.AutoSize = True
        PFLabel.Location = New System.Drawing.Point(78, 359)
        PFLabel.Name = "PFLabel"
        PFLabel.Size = New System.Drawing.Size(31, 16)
        PFLabel.TabIndex = 20
        PFLabel.Text = "PF:"
        '
        'ITAXLabel
        '
        ITAXLabel.AutoSize = True
        ITAXLabel.Location = New System.Drawing.Point(339, 360)
        ITAXLabel.Name = "ITAXLabel"
        ITAXLabel.Size = New System.Drawing.Size(45, 16)
        ITAXLabel.TabIndex = 22
        ITAXLabel.Text = "ITAX:"
        '
        'COMMLabel
        '
        COMMLabel.AutoSize = True
        COMMLabel.Location = New System.Drawing.Point(286, 413)
        COMMLabel.Name = "COMMLabel"
        COMMLabel.Size = New System.Drawing.Size(57, 16)
        COMMLabel.TabIndex = 24
        COMMLabel.Text = "COMM:"
        '
        'Net_SalaryLabel
        '
        Net_SalaryLabel.AutoSize = True
        Net_SalaryLabel.Location = New System.Drawing.Point(257, 436)
        Net_SalaryLabel.Name = "Net_SalaryLabel"
        Net_SalaryLabel.Size = New System.Drawing.Size(85, 16)
        Net_SalaryLabel.TabIndex = 28
        Net_SalaryLabel.Text = "Net Salary:"
        Net_SalaryLabel.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(16, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(625, 62)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(129, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(383, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EMPLOYER'S PAYSLIP WIZARD"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Net_SalaryLabel)
        Me.GroupBox1.Controls.Add(Me.Net_SalaryTextBox)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(COMMLabel)
        Me.GroupBox1.Controls.Add(Me.COMMTextBox)
        Me.GroupBox1.Controls.Add(ITAXLabel)
        Me.GroupBox1.Controls.Add(Me.ITAXTextBox)
        Me.GroupBox1.Controls.Add(PFLabel)
        Me.GroupBox1.Controls.Add(Me.PFTextBox)
        Me.GroupBox1.Controls.Add(HRALabel)
        Me.GroupBox1.Controls.Add(Me.HRATextBox)
        Me.GroupBox1.Controls.Add(TALabel)
        Me.GroupBox1.Controls.Add(Me.TATextBox)
        Me.GroupBox1.Controls.Add(DALabel)
        Me.GroupBox1.Controls.Add(Me.DATextBox)
        Me.GroupBox1.Controls.Add(LeaveLabel)
        Me.GroupBox1.Controls.Add(Me.LeaveTextBox)
        Me.GroupBox1.Controls.Add(BasicSalLabel)
        Me.GroupBox1.Controls.Add(Me.BasicSalTextBox)
        Me.GroupBox1.Controls.Add(AddressLabel)
        Me.GroupBox1.Controls.Add(Me.AddressTextBox)
        Me.GroupBox1.Controls.Add(Date_Of_JoinLabel)
        Me.GroupBox1.Controls.Add(EmpNameLabel)
        Me.GroupBox1.Controls.Add(Me.EmpNameTextBox)
        Me.GroupBox1.Controls.Add(DepartmentLabel)
        Me.GroupBox1.Controls.Add(Me.DepartmentTextBox)
        Me.GroupBox1.Controls.Add(Emp_IDLabel)
        Me.GroupBox1.Controls.Add(Me.Emp_IDTextBox)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Date_Of_JoinDateTimePicker)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(19, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(709, 485)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Please Fill The Below Menu Wizard  :-"
        '
        'Net_SalaryTextBox
        '
        Me.Net_SalaryTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Net_SalaryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Net_SalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Empwise_payslipBindingSource, "Net_Salary", True))
        Me.Net_SalaryTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Net_SalaryTextBox.Location = New System.Drawing.Point(348, 433)
        Me.Net_SalaryTextBox.Name = "Net_SalaryTextBox"
        Me.Net_SalaryTextBox.Size = New System.Drawing.Size(100, 15)
        Me.Net_SalaryTextBox.TabIndex = 29
        '
        'Empwise_payslipBindingSource
        '
        Me.Empwise_payslipBindingSource.DataMember = "Empwise_payslip"
        Me.Empwise_payslipBindingSource.DataSource = Me.PayrollDataSet
        '
        'PayrollDataSet
        '
        Me.PayrollDataSet.DataSetName = "payrollDataSet"
        Me.PayrollDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(435, 100)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(123, 22)
        Me.TextBox1.TabIndex = 27
        '
        'COMMTextBox
        '
        Me.COMMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Empwise_payslipBindingSource, "COMM", True))
        Me.COMMTextBox.Location = New System.Drawing.Point(347, 409)
        Me.COMMTextBox.Name = "COMMTextBox"
        Me.COMMTextBox.Size = New System.Drawing.Size(100, 22)
        Me.COMMTextBox.TabIndex = 25
        '
        'ITAXTextBox
        '
        Me.ITAXTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Empwise_payslipBindingSource, "ITAX", True))
        Me.ITAXTextBox.Location = New System.Drawing.Point(433, 357)
        Me.ITAXTextBox.Name = "ITAXTextBox"
        Me.ITAXTextBox.Size = New System.Drawing.Size(142, 22)
        Me.ITAXTextBox.TabIndex = 23
        '
        'PFTextBox
        '
        Me.PFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Empwise_payslipBindingSource, "PF", True))
        Me.PFTextBox.Location = New System.Drawing.Point(160, 353)
        Me.PFTextBox.Name = "PFTextBox"
        Me.PFTextBox.Size = New System.Drawing.Size(156, 22)
        Me.PFTextBox.TabIndex = 21
        '
        'HRATextBox
        '
        Me.HRATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Empwise_payslipBindingSource, "HRA", True))
        Me.HRATextBox.Location = New System.Drawing.Point(433, 293)
        Me.HRATextBox.Name = "HRATextBox"
        Me.HRATextBox.Size = New System.Drawing.Size(142, 22)
        Me.HRATextBox.TabIndex = 19
        '
        'TATextBox
        '
        Me.TATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Empwise_payslipBindingSource, "TA", True))
        Me.TATextBox.Location = New System.Drawing.Point(160, 289)
        Me.TATextBox.Name = "TATextBox"
        Me.TATextBox.Size = New System.Drawing.Size(156, 22)
        Me.TATextBox.TabIndex = 17
        '
        'DATextBox
        '
        Me.DATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Empwise_payslipBindingSource, "DA", True))
        Me.DATextBox.Location = New System.Drawing.Point(433, 237)
        Me.DATextBox.Name = "DATextBox"
        Me.DATextBox.Size = New System.Drawing.Size(142, 22)
        Me.DATextBox.TabIndex = 15
        '
        'LeaveTextBox
        '
        Me.LeaveTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Empwise_payslipBindingSource, "Leave", True))
        Me.LeaveTextBox.Location = New System.Drawing.Point(160, 228)
        Me.LeaveTextBox.Name = "LeaveTextBox"
        Me.LeaveTextBox.Size = New System.Drawing.Size(156, 22)
        Me.LeaveTextBox.TabIndex = 13
        '
        'BasicSalTextBox
        '
        Me.BasicSalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Empwise_payslipBindingSource, "BasicSal", True))
        Me.BasicSalTextBox.Location = New System.Drawing.Point(433, 178)
        Me.BasicSalTextBox.Name = "BasicSalTextBox"
        Me.BasicSalTextBox.Size = New System.Drawing.Size(142, 22)
        Me.BasicSalTextBox.TabIndex = 11
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Empwise_payslipBindingSource, "Address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(160, 164)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(156, 47)
        Me.AddressTextBox.TabIndex = 9
        '
        'EmpNameTextBox
        '
        Me.EmpNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Empwise_payslipBindingSource, "EmpName", True))
        Me.EmpNameTextBox.Location = New System.Drawing.Point(160, 100)
        Me.EmpNameTextBox.Name = "EmpNameTextBox"
        Me.EmpNameTextBox.Size = New System.Drawing.Size(156, 22)
        Me.EmpNameTextBox.TabIndex = 5
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Empwise_payslipBindingSource, "Department", True))
        Me.DepartmentTextBox.Location = New System.Drawing.Point(434, 38)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(141, 22)
        Me.DepartmentTextBox.TabIndex = 3
        '
        'Emp_IDTextBox
        '
        Me.Emp_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Empwise_payslipBindingSource, "Emp_ID", True))
        Me.Emp_IDTextBox.Location = New System.Drawing.Point(160, 36)
        Me.Emp_IDTextBox.Name = "Emp_IDTextBox"
        Me.Emp_IDTextBox.Size = New System.Drawing.Size(156, 22)
        Me.Emp_IDTextBox.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(433, 37)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(142, 24)
        Me.ComboBox1.TabIndex = 26
        '
        'Date_Of_JoinDateTimePicker
        '
        Me.Date_Of_JoinDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Empwise_payslipBindingSource, "Date_Of_Join", True))
        Me.Date_Of_JoinDateTimePicker.Location = New System.Drawing.Point(435, 100)
        Me.Date_Of_JoinDateTimePicker.Name = "Date_Of_JoinDateTimePicker"
        Me.Date_Of_JoinDateTimePicker.Size = New System.Drawing.Size(142, 22)
        Me.Date_Of_JoinDateTimePicker.TabIndex = 7
        '
        'Empwise_payslipTableAdapter
        '
        Me.Empwise_payslipTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Empwise_payslipTableAdapter = Me.Empwise_payslipTableAdapter
        Me.TableAdapterManager.UpdateOrder = Payroll_Management_System.payrollDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(100, 642)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(220, 642)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "&Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(341, 642)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "&Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(577, 642)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "&Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(465, 642)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "&Cancel"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(244, 597)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(51, 23)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "<<"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(322, 597)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(51, 23)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "<"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(400, 597)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(51, 23)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = ">"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(478, 597)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(51, 23)
        Me.Button9.TabIndex = 10
        Me.Button9.Text = ">>"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'payslip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(739, 713)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "payslip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Payslip"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Empwise_payslipBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrollDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PayrollDataSet As Payroll_Management_System.payrollDataSet
    Friend WithEvents Empwise_payslipBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Empwise_payslipTableAdapter As Payroll_Management_System.payrollDataSetTableAdapters.Empwise_payslipTableAdapter
    Friend WithEvents TableAdapterManager As Payroll_Management_System.payrollDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BasicSalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_Of_JoinDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EmpNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DepartmentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Emp_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents COMMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ITAXTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HRATextBox As System.Windows.Forms.TextBox
    Friend WithEvents TATextBox As System.Windows.Forms.TextBox
    Friend WithEvents DATextBox As System.Windows.Forms.TextBox
    Friend WithEvents LeaveTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Net_SalaryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
End Class
