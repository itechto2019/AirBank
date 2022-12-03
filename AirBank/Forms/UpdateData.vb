Imports MySql.Data.MySqlClient
Public Class UpdateData

    Public Sub updateData()
        Dim UpdateData As New UpdateData
        Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
        Dim MysqlCmdSearchQuery As New MySqlCommand("update account set Firstname='" + _Firstname.Text + "', Lastname='" + _Lastname.Text + "', Middle='" + _Middle.Text + "'", MysqlConn)
        MysqlConn.Open()
        MysqlCmdSearchQuery.ExecuteNonQuery()
    End Sub
    Private Sub _Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Search.Click
        _Search.Text = ""
    End Sub
    Private Sub _Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Save.Click
        toSave()
        updateLog()
    End Sub

    Private Sub _SeachBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _SeachBtn.Click
        toSearch()
    End Sub

    Private Sub UpdateData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _Search.Focus()
    End Sub

    Public Sub toSearch()
        Dim ID As String
        ID = _Search.Text
        Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
        Dim MysqlCmdSearchQuery As New MySqlCommand("SELECT * from account WHERE Concat(AccountID) like '%" & ID & "%'", MysqlConn)
        MysqlConn.Open()
        MysqlCmdSearchQuery.ExecuteNonQuery()

        Dim DataList As New DataTable
        Dim MysqlAdptRecord As New MySqlDataAdapter(MysqlCmdSearchQuery)
        MysqlAdptRecord.Fill(DataList)
        'DataSource = DataList

        If DataList.Rows.Count > 0 Then
            _ID.Text = DataList(0)(0)
            _Firstname.Text = DataList(0)(1)
            _Lastname.Text = DataList(0)(2)
            _Middle.Text = DataList(0)(3)
            _Save.Enabled = True
        Else
            MessageBox.Show("Please double check your Account ID to proceed an update. Thank you!", "The Account ID ( " & _Search.Text & " ) Not Found in the Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        MysqlConn.Close()
    End Sub
    Public Sub toSave()
        Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
        Dim MysqlUpdateCmd As New MySqlCommand


        Dim ID As String
        Dim Fname As String
        Dim Lname As String
        Dim Mname As String

        ID = _ID.Text
        Fname = _Firstname.Text.ToUpper
        Lname = _Lastname.Text.ToUpper
        Mname = _Middle.Text.ToUpper

        MysqlConn.Close()
        Try
            MysqlConn.Open()
            With MysqlUpdateCmd
                .CommandText = "update account set Firstname='" & Fname & "',Lastname='" & Lname & "', Middle='" & Mname & "' WHERE AccountID='" & ID & "'" 'My Query to Update
                .Connection = MysqlConn
                .ExecuteNonQuery()
            End With
            MysqlUpdateCmd.ExecuteNonQuery()

            _ID.Text = ""
            _Firstname.Text = ""
            _Lastname.Text = ""
            _Middle.Text = ""
            _Search.Text = "Search ID"
            MessageBox.Show("Information is updated.", "Update Complete.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub _Search_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles _Search.KeyDown
        If e.KeyCode = Keys.Enter Then
            _SeachBtn.Focus()
        End If
    End Sub
    Public Sub updateLog()
        Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
        Dim MysqlUpdateLog As New MySqlCommand
        Dim ChangeDate As String
        Dim ChangeTime As String

        'MysqlConn.Close()
        Try
            MysqlConn.Open()
            ChangeDate = DateTime.Now.ToString("yyyy-MM-dd")
            ChangeTime = TimeOfDay.ToString("hh:mm:ss")

            With MysqlUpdateLog
                .Connection = MysqlConn
                .CommandText = "insert into log (Name,Date,Time,Description) Values('Admin','" & ChangeDate & "','" & ChangeTime & "','Admin: Successfully update user account.')"
                .ExecuteNonQuery()
            End With
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class