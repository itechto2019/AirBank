Imports MySql.Data.MySqlClient
Public Class WithdrawalSuccessful

    Private Sub _OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _OK.Click
        UpdateLog()
        Me.Close()
    End Sub

    Private Sub WithdrawalSuccessful_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _Date.Text = DateTime.Now.ToString("yyyy-MM-dd")
        _Time.Text = TimeOfDay.ToString("hh:mm tt")
        P_Withdrawal._Amount.Text = Format(Val(P_Withdrawal._Amount.Text), "#,###,##0.00")
        _WithdrawAmount.Text = Format(Val(_WithdrawAmount.Text), "#,###,##0.00")
        _TotalAmount.Text = Format(Val(_TotalAmount.Text), "#,###,##0.00")
    End Sub
    Public Sub UpdateLog()
        Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
        Dim MysqlUpdateLog As New MySqlCommand

        Dim ID As Integer
        Dim Fullname As String
        Dim WithdrawalDate As String
        Dim WithdrawalTime As String

        ID = Val(_ID.Text)
        Fullname = _Name.Text
        WithdrawalDate = DateTime.Now.ToString("yyyy-MM-dd")
        WithdrawalTime = TimeOfDay.ToString("hh:mm:ss")
        MysqlConn.Open()
        With MysqlUpdateLog
            .Connection = MysqlConn
            .CommandText = "insert into log (AccountID,Name,Date,Time,Description) Values('" & ID & "','" & Fullname & "','" & WithdrawalDate & "','" & WithdrawalTime & "','Successfully Withdawn to the account.')"
            .ExecuteNonQuery()
        End With

        MysqlConn.Close()
    End Sub
End Class