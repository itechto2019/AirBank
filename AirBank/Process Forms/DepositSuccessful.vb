Imports MySql.Data.MySqlClient
Public Class DepositSuccessful

    Private Sub _OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _OK.Click
        UpdateLog()
        Me.Close()
    End Sub
    Private Sub DepositSuccessful_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'SucessfullDeposit()
        _Date.Text = DateTime.Now.ToString("yyyy-MM-dd")
        _Time.Text = TimeOfDay.ToString("hh:mm tt")
        P_Deposit._Amount.Text = Format(Val(P_Deposit._Amount.Text), "#,###,##0.00")
        _DepositAmount.Text = Format(Val(_DepositAmount.Text), "#,###,##0.00")

    End Sub
    Public Sub SucessfullDeposit()
        Dim id As String
        Dim pDeposit As New P_Deposit

        id = pDeposit._Acc.Text
        _Name.Text.ToUpper()

        Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
        Dim MysqlQueryDisplay As New MySqlCommand("Select Firstname, Middle, Lastname,Balance from account where AccountID='" & id & "'", MysqlConn)
        Dim MysqlReader As MySqlDataReader
        MysqlConn.Open()
        MysqlReader = MysqlQueryDisplay.ExecuteReader
        If MysqlReader.HasRows Then
            MysqlReader.Read()
            _Name.Text = MysqlReader("Firstname") + " " + MysqlReader("Middle") + " " + MysqlReader("Lastname")
            _TotalAmount.Text = MysqlReader("Balance")
            P_Deposit._Amount.Text = Format(Val(P_Deposit._Amount.Text), "#,###,##0.00")
            _TotalAmount.Text = Format(Val(_TotalAmount.Text), "#,###,##0.00")
        End If


    End Sub
    Public Sub UpdateLog()
        Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
        Dim MysqlUpdateLog As New MySqlCommand

        Dim ID As Integer
        Dim Fullname As String
        Dim DepositDate As String
        Dim DepositTime As String

        ID = Val(_ID.Text)
        Fullname = _Name.Text.ToUpper
        DepositDate = DateTime.Now.ToString("yyyy-MM-dd")
        DepositTime = TimeOfDay.ToString("hh:mm:ss")
        MysqlConn.Open()
        With MysqlUpdateLog
            .Connection = MysqlConn
            .CommandText = "insert into log (AccountID,Name,Date,Time,Description) Values('" & ID & "','" & Fullname & "','" & DepositDate & "','" & DepositTime & "','Successfully Deposited to the account.')"
            .ExecuteNonQuery()
        End With
        MysqlConn.Close()
    End Sub

End Class