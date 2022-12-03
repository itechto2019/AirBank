Imports MySql.Data.MySqlClient
Public Class Dashboard
    Dim AccountChecker As New Account_Checker
    Dim log As New Log
    Dim updatingForm As New UpdateData
    Dim add As New AddAccount

    'Switch
    Dim sCheckAccount As Boolean = False
    Dim sLog As Boolean = False
    Dim sAdd As Boolean = False
    Dim sUpdate As Boolean = False

    Private Sub Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckAccount()
        Time.Start()
    End Sub
    Public Sub getDate()
        MyTime.Text = TimeOfDay.ToString("hh:mm tt")
        myDate.Text = DateTime.Now.ToShortDateString
    End Sub
    Public Sub showLog()
        sLog = True
        sCheckAccount = False
        sAdd = False
        If sLog = True Then
            log.TopLevel = False
            log.TopMost = True
            _Main.Controls.Add(log)
            log.Show()
            add.Hide()
            AccountChecker.Hide()
            updatingForm.Hide()
            _Log.BackColor = Color.FromArgb(3, 33, 90)
            _AddEntry.BackColor = Color.FromArgb(3, 33, 64)
            _AccountCheck.BackColor = Color.FromArgb(3, 33, 64)
            _Update.BackColor = Color.FromArgb(3, 33, 64)
            sLog = False
        ElseIf sLog = False Then
            sLog = False
        End If
    End Sub
    Public Sub CheckAccount()
        sCheckAccount = True
        sLog = False
        sAdd = False
        If sCheckAccount = True Then
            AccountChecker.TopLevel = False
            AccountChecker.TopMost = True
            _Main.Controls.Add(AccountChecker)
            AccountChecker.Show()
            log.Hide()
            add.Hide()
            updatingForm.Hide()
            _AccountCheck.BackColor = Color.FromArgb(3, 33, 90)
            _Log.BackColor = Color.FromArgb(3, 33, 64)
            _AddEntry.BackColor = Color.FromArgb(3, 33, 64)
            _Update.BackColor = Color.FromArgb(3, 33, 64)
            sCheckAccount = False
        ElseIf sCheckAccount = False Then
            sCheckAccount = False
        End If
    End Sub
    Public Sub AddAccount()
        sAdd = True
        sLog = False
        sCheckAccount = False
        If sAdd = True Then
            add.TopLevel = False
            add.TopMost = True
            _Main.Controls.Add(add)
            add.Show()
            log.Hide()
            AccountChecker.Hide()
            updatingForm.Hide()
            _AddEntry.BackColor = Color.FromArgb(3, 33, 90)
            _AccountCheck.BackColor = Color.FromArgb(3, 33, 64)
            _Log.BackColor = Color.FromArgb(3, 33, 64)
            _Update.BackColor = Color.FromArgb(3, 33, 64)
            sAdd = False
        ElseIf sLog = False Then
            sAdd = False
        End If
    End Sub
    Public Sub UpdateForm()
        sUpdate = True
        sLog = False
        sCheckAccount = False
        sAdd = False
        If sUpdate = True Then
            updatingForm.TopLevel = False
            updatingForm.TopMost = True
            _Main.Controls.Add(updatingForm)
            updatingForm.Show()
            AccountChecker.Hide()
            add.Hide()
            log.Hide()
            _AddEntry.BackColor = Color.FromArgb(3, 33, 64)
            _AccountCheck.BackColor = Color.FromArgb(3, 33, 64)
            _Log.BackColor = Color.FromArgb(3, 33, 64)
            _Update.BackColor = Color.FromArgb(3, 33, 90)
            sUpdate = False
        ElseIf sUpdate = False Then
            sUpdate = False
        End If
    End Sub
    'Account Check Button
    Private Sub _AccountCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _AccountCheck.Click
        CheckAccount()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        'Dim About As AboutUs
        AboutUs.Show()
    End Sub

    Public Sub UpdateLog()
        Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
        Dim MysqlUpdateLog As New MySqlCommand
        Dim LoginDate As String
        Dim LoginTime As String
        MysqlConn.Close()
        Try
            LoginDate = DateTime.Now.ToString("yyyy-MM-dd")
            LoginTime = TimeOfDay.ToString("hh:mm:ss")
            MysqlConn.Open()
            With MysqlUpdateLog
                .Connection = MysqlConn
                .CommandText = "insert into log (Name,Date,Time,Description) Values('Admin','" & LoginDate & "','" & LoginTime & "','Admin: was successfully Logged to the System.')"
                .ExecuteNonQuery()
            End With
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub logoutLog()
        Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
        Dim MysqlUpdateLog As New MySqlCommand
        Dim LogoutDate As String
        Dim LogoutTime As String
        MysqlConn.Close()
        Try
            LogoutDate = DateTime.Now.ToString("yyyy-MM-dd")
            LogoutTime = TimeOfDay.ToString("hh:mm:ss")
            MysqlConn.Open()
            With MysqlUpdateLog
                .Connection = MysqlConn
                .CommandText = "insert into log (Name,Date,Time,Description) Values('Admin','" & LogoutDate & "','" & LogoutTime & "','Admin: was Logged out on the System.')"
                .ExecuteNonQuery()
            End With
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub _Log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Log.Click
        showLog()
    End Sub

    Private Sub _AddEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _AddEntry.Click
        AddAccount()
    End Sub

    Private Sub _Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Update.Click
        UpdateForm()
    End Sub

    Private Sub _Logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Logout.Click
        logoutLog()
        Dim Home As New Accounts
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Time_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Time.Tick
        getDate()
    End Sub
End Class