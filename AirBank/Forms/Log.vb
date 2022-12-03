Imports MySql.Data.MySqlClient
Imports System.ComponentModel

Public Class Log

    Private Sub Log_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadLogs()

    End Sub
    Public Sub loadLogs()
        Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
        Dim MysqlCmdLogQuery As New MySqlCommand("SELECT Count,Name,Date,Time,Description from log", MysqlConn)
        MysqlConn.Open()
        MysqlCmdLogQuery.ExecuteNonQuery()

        Dim DataList As New DataTable
        Dim MysqlAdptRecord As New MySqlDataAdapter(MysqlCmdLogQuery)
        MysqlAdptRecord.Fill(DataList)
        _DataLog.DataSource = DataList
        _DataLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        _DataLog.Sort(_DataLog.Columns(0), ListSortDirection.Descending)
        _DataLog.AutoResizeColumns()
        MysqlConn.Close()
    End Sub

    Private Sub _Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Refresh.Click
        loadLogs()
    End Sub

    Private Sub _Clear_Click(sender As System.Object, e As System.EventArgs) Handles _Clear.Click
        delData()
    End Sub
    Public Sub delData()
        Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
        MysqlConn.Open()
        Try
            If (MsgBox("Are you sure you want to delete log?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                MysqlConn.Open()
                Dim MysqlCmdLogQuery As New MySqlCommand("Delete * from log", MysqlConn)
                MysqlCmdLogQuery.ExecuteNonQuery()
                MsgBox("Log has been Deleted!", MsgBoxStyle.Information)
                MysqlConn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MysqlConn.Close()
        End Try

    End Sub
End Class