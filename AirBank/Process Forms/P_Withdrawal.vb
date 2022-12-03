Imports MySql.Data.MySqlClient
Public Class P_Withdrawal

    Private Sub P_Withdrawal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _btnDel.Enabled = False
        _btnCheck.Enabled = False
        _Withdraw.Enabled = False
    End Sub

    Private Sub _Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Cancel.Click
        Me.Close()
    End Sub
    Private Sub _Amount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles _Amount.KeyDown
        If Not Char.IsNumber(ChrW(e.KeyCode)) Then
            _Amount.Focus()
        End If
    End Sub

    Private Sub _Withdraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Withdraw.Click
        toWithdraw()
        Me.Hide()
        toReceipt()
    End Sub

    'Input to Passcode Field

    Private Sub _btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn1.Click
        'Get text from button 1
        _Withdraw.Enabled = False
        _btnDel.Enabled = True
        _btnCheck.Enabled = True
        '_Amount.MaxLength = 6
        _Amount.Text = _Amount.Text + _btn1.Text
    End Sub
    Private Sub _btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn2.Click
        'Get text from button 2
        _Withdraw.Enabled = False
        _btnDel.Enabled = True
        _btnCheck.Enabled = True
        _Amount.Text = _Amount.Text + _btn2.Text
    End Sub
    Private Sub _btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn3.Click
        'Get text from button 3
        _Withdraw.Enabled = False
        _btnDel.Enabled = True
        _btnCheck.Enabled = True
        _Amount.MaxLength = 6
        _Amount.Text = _Amount.Text + _btn3.Text
    End Sub
    Private Sub _btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn4.Click
        'Get text from button 4
        _Withdraw.Enabled = False
        _btnDel.Enabled = True
        _btnCheck.Enabled = True
        _Amount.MaxLength = 6
        _Amount.Text = _Amount.Text + _btn4.Text
    End Sub
    Private Sub _btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn5.Click
        'Get text from button 5
        _Withdraw.Enabled = False
        _btnDel.Enabled = True
        _btnCheck.Enabled = True
        _Amount.Text = _Amount.Text + _btn5.Text
    End Sub
    Private Sub _btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn6.Click
        'Get text from button 6
        _Withdraw.Enabled = False
        _btnDel.Enabled = True
        _btnCheck.Enabled = True
        _Amount.Text = _Amount.Text + _btn6.Text
    End Sub
    Private Sub _btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn7.Click
        'Get text from button 7
        _Withdraw.Enabled = False
        _btnDel.Enabled = True
        _btnCheck.Enabled = True
        _Amount.Text = _Amount.Text + _btn7.Text
    End Sub
    Private Sub _btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn8.Click
        'Get text from button 8
        _Withdraw.Enabled = False
        _btnDel.Enabled = True
        _btnCheck.Enabled = True
        _Amount.Text = _Amount.Text + _btn8.Text

    End Sub
    Private Sub _btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn9.Click
        'Get text from button 9
        _Withdraw.Enabled = False
        _btnDel.Enabled = True
        _btnCheck.Enabled = True
        _Amount.Text = _Amount.Text + _btn9.Text
    End Sub
    Private Sub _btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn0.Click
        'Get text from button 0
        _Withdraw.Enabled = False
        _btnDel.Enabled = True
        _btnCheck.Enabled = True
        _Amount.Text = _Amount.Text + _btn0.Text
    End Sub
    Private Sub _btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btnDel.Click
        _Amount.Text = Strings.Left(_Amount.Text, _Amount.Text.Length - 1)
        If _Amount.Text.Length < 1 Then
            _btnDel.Enabled = False
            _btnCheck.Enabled = False
            _Withdraw.Enabled = False
        End If
    End Sub

    'HOVER ACTION
    Private Sub _btn1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn1.MouseEnter
        _btn1.Width = 78
        _btn1.Height = 56
    End Sub
    Private Sub _btn1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn1.MouseLeave
        _btn1.Width = 75
        _btn1.Height = 53
    End Sub

    Private Sub _btn2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn2.MouseEnter
        _btn2.Width = 78
        _btn2.Height = 56
    End Sub

    Private Sub _btn2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn2.MouseLeave
        _btn2.Width = 75
        _btn2.Height = 53
    End Sub

    Private Sub _btn3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn3.MouseEnter
        _btn3.Width = 78
        _btn3.Height = 56
    End Sub

    Private Sub _btn3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn3.MouseLeave
        _btn3.Width = 75
        _btn3.Height = 53
    End Sub

    Private Sub _btn4_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn4.MouseEnter
        _btn4.Width = 78
        _btn4.Height = 56
    End Sub

    Private Sub _btn4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn4.MouseLeave
        _btn4.Width = 75
        _btn4.Height = 53
    End Sub

    Private Sub _btn5_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn5.MouseEnter
        _btn5.Width = 78
        _btn5.Height = 56
    End Sub

    Private Sub _btn5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn5.MouseLeave
        _btn5.Width = 75
        _btn5.Height = 53
    End Sub

    Private Sub _btn6_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn6.MouseEnter
        _btn6.Width = 78
        _btn6.Height = 56
    End Sub

    Private Sub _btn6_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn6.MouseLeave
        _btn6.Width = 75
        _btn6.Height = 53
    End Sub

    Private Sub _btn7_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn7.MouseEnter
        _btn7.Width = 78
        _btn7.Height = 56
    End Sub

    Private Sub _btn7_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn7.MouseLeave
        _btn7.Width = 75
        _btn7.Height = 53
    End Sub
    Private Sub _btn8_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn8.MouseEnter
        _btn8.Width = 78
        _btn8.Height = 56
    End Sub

    Private Sub _btn8_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn8.MouseLeave
        _btn8.Width = 75
        _btn8.Height = 53
    End Sub
    Private Sub _btn9_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn9.MouseEnter
        _btn9.Width = 78
        _btn9.Height = 56
    End Sub

    Private Sub _btn9_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn9.MouseLeave
        _btn9.Width = 75
        _btn9.Height = 53
    End Sub

    Private Sub _btn0_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn0.MouseEnter
        _btn0.Width = 78
        _btn0.Height = 56
    End Sub

    Private Sub _btn0_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn0.MouseLeave
        _btn0.Width = 75
        _btn0.Height = 53
    End Sub
    Private Sub _btnDel_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btnDel.MouseEnter
        _btnDel.Width = 78
        _btnDel.Height = 56
    End Sub

    Private Sub _btnDel_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btnDel.MouseLeave
        _btnDel.Width = 75
        _btnDel.Height = 53
    End Sub
    Private Sub _Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Clear.Click
        _Amount.Text = ""
        _tAmount.Text = ""
        _btnDel.Enabled = False
        _btnCheck.Enabled = False
    End Sub
    Private Sub _Amount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Amount.TextChanged
        '_Withdraw.Enabled = False
        If _Amount.Text = "" Then
            _Withdraw.Enabled = False
        End If
    End Sub

    Private Sub _btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btnCheck.Click
        Dim amount As Double
        Dim bal As Double
        Dim minWithdraw As Double


        amount = _Amount.Text
        bal = _bal.Text

        minWithdraw = amount
        _tAmount.Text = Convert.ToDouble(bal) - Convert.ToDouble(amount)
        _tAmount.Text = Format(Val(_tAmount.Text), "#,###,##0.00")


        If minWithdraw > bal Then
            _tAmount.Text = ""
            _Amount.Text = ""
            _Withdraw.Enabled = False
            MessageBox.Show("Insufficient Balance!", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf minWithdraw < 1000 Then
            _tAmount.Text = ""
            _Amount.Text = ""
            _Withdraw.Enabled = False
            MessageBox.Show("The minimum withdrawal is Php 1000", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            _Withdraw.Enabled = True
            MessageBox.Show("You will now be able to Withdraw.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Sub toWithdraw()


        Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
        Dim MysqlUpdateAccount As New MySqlCommand()


        Dim Bal As Double
        Dim Amount As Decimal
        Dim ID As Integer

        Bal = _bal.Text
        Amount = _Amount.Text
        ID = _Acc.Text
        Try
            MysqlConn.Open()
            With MysqlUpdateAccount
                .Connection = MysqlConn
                .CommandText = "update account set Balance=(Balance - '" & Amount & "') where AccountID='" & ID & "' "
                .ExecuteNonQuery()
            End With
            MessageBox.Show("Your withdrawal has been successfully.", "Withdrwal Completed.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '_bal.Text = ""
        Catch ex As Exception

        End Try
    End Sub
    Public Sub toReceipt()
        Dim WithdrawSuccessfully As New WithdrawalSuccessful
        Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
        Dim MysqlProcessReceipt As New MySqlCommand()
        Dim MysqlReader As MySqlDataReader

        Dim ID As Integer
        ID = _Acc.Text

        Try
            MysqlConn.Open()

            With MysqlProcessReceipt
                .Connection = MysqlConn
                .CommandText = "select AccountID,Firstname,Lastname,Middle,Balance from account where AccountID='" & ID & "'"
                .ExecuteNonQuery()
            End With
            MysqlReader = MysqlProcessReceipt.ExecuteReader

            If MysqlReader.HasRows Then
                MysqlReader.Read()
                WithdrawSuccessfully._Name.Text = MysqlReader("Firstname") + " " + MysqlReader("Middle") + " " + MysqlReader("Lastname")
                WithdrawSuccessfully._ID.Text = MysqlReader("AccountID")
                WithdrawSuccessfully._WithdrawAmount.Text = _Amount.Text
                WithdrawSuccessfully._TotalAmount.Text = MysqlReader("Balance")
                WithdrawSuccessfully.Show()
                Me.Close()
            End If


            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class