Imports System.Data
Imports System.Data.OleDb
Public Class dbase
    Public str As String
    Public con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\Payroll Management System\Payroll Management System\payroll.mdb;")
    Public adp As OleDbDataAdapter
    Public dr As OleDbDataReader
    Public ds As New DataSet
    Public dt As New DataTable
    Public tbl As String
    Public Sub New(ByVal tbl As String)

        con.Open()
        adp = New OleDbDataAdapter("select * from " & tbl, con)
        adp.Fill(ds, tbl)
        dt = ds.Tables(tbl)
        Me.tbl = tbl
    End Sub
    Public Sub save()
        Dim cmdb As New OleDbCommandBuilder(adp)
        adp.Update(ds, tbl)
    End Sub
End Class
