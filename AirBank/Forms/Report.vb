Imports MySql.Data.MySqlClient
Imports System
Imports System.Data
Public Class Report

    Private Sub Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OnLoadData()
    End Sub
    Public Sub OnLoadData()
        Dim Mysqlconn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
        Dim MysqlDisplayCommand = New MySqlCommand
        Dim MysqlAdapter As New MySqlDataAdapter("select Firstname,Lastname, Middle, Birthdate, Age, Balance from account", Mysqlconn)
        Dim MyDataSet As New DataSet
        Mysqlconn.Close()
        Try
            Mysqlconn.Open()
            MysqlAdapter.Fill(MyDataSet)
            MyDataSet.WriteXml(CurDir() & "\Report.xml", XmlWriteMode.WriteSchema)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Mysqlconn.Close()
        End Try
    End Sub

    Private Sub _ViewData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _ViewData.Click
        OnLoadData()
    End Sub
    Private Sub _Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Exit.Click
        Me.Close()
    End Sub
    Private Sub CrystalReportViewer1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        OnLoadData()
    End Sub
End Class