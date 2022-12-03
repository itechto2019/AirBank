Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Menu
    Private Sub _Withdraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Withdraw.Click
        ProcessWithdraw()
    End Sub
    Public Sub ProcessWithdraw()
        Dim Process_Withdrawal As New P_Withdrawal
        Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
        Dim MysqlCommand As New MySqlCommand("select AccountID,Firstname,Lastname,Middle,Balance from account  where AccountID='" & _Acc.Text & "'", MysqlConn)

        Dim MysqlReader As MySqlDataReader

        Try
            MysqlConn.Open()
            MysqlReader = MysqlCommand.ExecuteReader
            If MysqlReader.HasRows Then
                Process_Withdrawal.Show()
                MysqlReader.Read()
                Process_Withdrawal._Name.Text = MysqlReader("Firstname") + " " + MysqlReader("Middle") + " " + MysqlReader("Lastname")
                Process_Withdrawal._Acc.Text = MysqlReader("AccountID")
                Process_Withdrawal._bal.Text = MysqlReader("Balance")
                Process_Withdrawal._bal.Text = Format(Val(Process_Withdrawal._bal.Text), "#,###,##0.00")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    Public Sub ProcessDeposit()
        Dim Process_Deposit As New P_Deposit
        Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
        Dim MysqlCommand As New MySqlCommand("select AccountID,Firstname,Lastname,Middle,Balance from account  where AccountID='" & _Acc.Text & "'", MysqlConn)

        Dim MysqlReader As MySqlDataReader

        Try
            MysqlConn.Open()
            MysqlReader = MysqlCommand.ExecuteReader
            If MysqlReader.HasRows Then
                Process_Deposit.Show()
                MysqlReader.Read()
                Process_Deposit._Name.Text = MysqlReader("Firstname") + " " + MysqlReader("Middle") + " " + MysqlReader("Lastname")
                Process_Deposit._Acc.Text = MysqlReader("AccountID")
                Process_Deposit._bal.Text = MysqlReader("Balance")
                Process_Deposit._bal.Text = Format(Val(Process_Deposit._bal.Text), "#,###,##0.00")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub _Deposite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Deposite.Click
        ProcessDeposit()
    End Sub

    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
    Public Sub UpdateLog()
        Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
        Dim MysqlUpdateLog As New MySqlCommand

        Dim ID As Integer
        Dim Fullname As String
        Dim LoginDate As String
        Dim LoginTime As String
        MysqlConn.Close()
        Try
            ID = Val(_Acc.Text)
            Fullname = Me._Name.Text
            LoginDate = DateTime.Now.ToString("yyyy-MM-dd")
            LoginTime = TimeOfDay.ToString("hh:mm:ss")
            MysqlConn.Open()
            With MysqlUpdateLog
                .Connection = MysqlConn
                .CommandText = "insert into log (AccountID,Name,Date,Time,Description) Values('" & ID & "','" & Fullname & "','" & LoginDate & "','" & LoginTime & "','Successfully Logged to the system.')"
                .ExecuteNonQuery()
            End With
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub _Logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Logout.Click
        Dim ReLogin As New Login
        Me.Close()
        ReLogin.Show()

    End Sub
    Public Sub toPassodeFormShow()
        Dim changePasscode As New ChangePasscode
        Dim Menu As New Menu
        Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
        Dim MysqlCommand As New MySqlCommand("select AccountID,Firstname,Lastname,Middle,Balance from account where AccountID='" & _Acc.Text & "'", MysqlConn)
        Dim MysqlReader As MySqlDataReader

        Try
            MysqlConn.Open()
            MysqlReader = MysqlCommand.ExecuteReader
            If MysqlReader.HasRows Then
                changePasscode.Show()
                MysqlReader.Read()
                ChangePasscode._Name.Text = MysqlReader("Firstname") + " " + MysqlReader("Middle") + " " + MysqlReader("Lastname")
                ChangePasscode._Acc.Text = MysqlReader("AccountID")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub _ChangeCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _ChangeCode.Click
        toPassodeFormShow()
    End Sub
    
End Class