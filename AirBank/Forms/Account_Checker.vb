Imports MySql.Data.MySqlClient
Public Class Account_Checker

    Private Sub _Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Search.Click
        _Search.Text = ""
    End Sub
    Private Sub Account_Checker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OnLoadData()
        _Search.Focus()
    End Sub
    Private Sub _SeachBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _SeachBtn.Click
        Me.AcceptButton = _SeachBtn
        ToFilter()
    End Sub
    Public Sub ToFilter()
        Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
        Dim MysqlCmdSearchQuery As New MySqlCommand("SELECT AccountID, Firstname, Lastname, Middle,Birthdate,Age,Balance,Gender from account WHERE Concat(Firstname,Lastname,Middle,AccountID) LIKE '%" & _Search.Text & "%'", MysqlConn)
        MysqlConn.Open()
        MysqlCmdSearchQuery.ExecuteNonQuery()

        Dim DataList As New DataTable
        Dim MysqlAdptRecord As New MySqlDataAdapter(MysqlCmdSearchQuery)
        MysqlAdptRecord.Fill(DataList)
        Data.DataSource = DataList
        Data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Data.AutoResizeColumns()
        MysqlConn.Close()
    End Sub
    Public Sub OnLoadData()
        Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
        Dim MysqlCmdSearchQuery As New MySqlCommand("SELECT AccountID, Firstname, Lastname, Middle,Birthdate,Age,Balance,Gender from account", MysqlConn)
        MysqlConn.Open()
        MysqlCmdSearchQuery.ExecuteNonQuery()

        Dim DataList As New DataTable
        Dim MysqlAdptRecord As New MySqlDataAdapter(MysqlCmdSearchQuery)
        MysqlAdptRecord.Fill(DataList)
        Data.DataSource = DataList
        Data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Data.AutoResizeColumns()
        MysqlConn.Close()
    End Sub
    Private Sub _Search_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles _Search.KeyDown
        If e.KeyCode = Keys.Enter Then
            If _Search.Text = "" Then
                _Search.Focus()
            Else
                _SeachBtn.Focus()
            End If
        End If
    End Sub

    Private Sub _Search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Search.TextChanged
        _Search.Focus()
    End Sub
    Public Sub UpdateLog()
        Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
        Dim MysqlUpdateLog As New MySqlCommand
        Dim StatusDate As String
        Dim StatusTime As String
        MysqlConn.Close()
        Try
            StatusDate = DateTime.Now.ToString("yyyy-MM-dd")
            StatusTime = TimeOfDay.ToString("hh:mm:ss")
            MysqlConn.Open()
            With MysqlUpdateLog
                .Connection = MysqlConn
                .CommandText = "insert into log (Name,Date,Time,Description) Values('Admin','" & StatusDate & "','" & StatusTime & "','Admin: successfully created a new user.')"
                .ExecuteNonQuery()
            End With
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub _Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Refresh.Click
        loadData()
    End Sub
    Public Sub loadData()
        Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
        Dim MysqlCmdLogQuery As New MySqlCommand("SELECT AccountID, Firstname, Lastname, Middle,Birthdate,Age,Balance,Gender from account", MysqlConn)
        MysqlConn.Open()
        MysqlCmdLogQuery.ExecuteNonQuery()

        Dim DataList As New DataTable
        Dim MysqlAdptRecord As New MySqlDataAdapter(MysqlCmdLogQuery)
        MysqlAdptRecord.Fill(DataList)
        Data.DataSource = DataList
        Data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Data.AutoResizeColumns()
        MysqlConn.Close()
    End Sub

    Private Sub _Report_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Report.Click
        Dim MyReport As New Report
        MyReport.Show()
    End Sub
End Class