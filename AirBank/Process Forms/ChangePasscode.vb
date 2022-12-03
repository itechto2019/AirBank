Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient
Public Class ChangePasscode

    Private Sub _Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Cancel.Click
        Me.Close()
    End Sub
    'Input to Passcode Field
    Private Sub _btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn1.Click
        'Get text from button 1
        _btnDel.Enabled = True
        _Passcode.Text = _Passcode.Text + _btn1.Text
        If _Passcode.Text.Length > 6 Then
            _message.Visible = True
            _message.Text = "Allowed only 6 Characters"
            _Passcode.Text = Strings.Left(_Passcode.Text, _Passcode.Text.Length - 1)
        End If
    End Sub
    Private Sub _btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn2.Click
        'Get text from button 2
        _btnDel.Enabled = True
        _Passcode.Text = _Passcode.Text + _btn2.Text
        If _Passcode.Text.Length > 6 Then
            _message.Visible = True
            _message.Text = "Allowed only 6 Characters"
            _Passcode.Text = Strings.Left(_Passcode.Text, _Passcode.Text.Length - 1)
        End If
    End Sub
    Private Sub _btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn3.Click
        'Get text from button 3
        _btnDel.Enabled = True
        _Passcode.Text = _Passcode.Text + _btn3.Text
        If _Passcode.Text.Length > 6 Then
            _message.Visible = True
            _message.Text = "Allowed only 6 Characters"
            _Passcode.Text = Strings.Left(_Passcode.Text, _Passcode.Text.Length - 1)
        End If
    End Sub
    Private Sub _btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn4.Click
        'Get text from button 4
        _btnDel.Enabled = True
        _Passcode.Text = _Passcode.Text + _btn4.Text
        If _Passcode.Text.Length > 6 Then
            _message.Visible = True
            _message.Text = "Allowed only 6 Characters"
            _Passcode.Text = Strings.Left(_Passcode.Text, _Passcode.Text.Length - 1)
        End If
    End Sub
    Private Sub _btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn5.Click
        'Get text from button 5
        _btnDel.Enabled = True
        _Passcode.Text = _Passcode.Text + _btn5.Text
        If _Passcode.Text.Length > 6 Then
            _message.Visible = True
            _message.Text = "Allowed only 6 Characters"
            _Passcode.Text = Strings.Left(_Passcode.Text, _Passcode.Text.Length - 1)
        End If
    End Sub
    Private Sub _btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn6.Click
        'Get text from button 6
        _btnDel.Enabled = True
        _Passcode.Text = _Passcode.Text + _btn6.Text
        If _Passcode.Text.Length > 6 Then
            _message.Visible = True
            _message.Text = "Allowed only 6 Characters"
            _Passcode.Text = Strings.Left(_Passcode.Text, _Passcode.Text.Length - 1)
        End If
    End Sub
    Private Sub _btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn7.Click
        'Get text from button 7
        _btnDel.Enabled = True
        _Passcode.Text = _Passcode.Text + _btn7.Text
        If _Passcode.Text.Length > 6 Then
            _message.Visible = True
            _message.Text = "Allowed only 6 Characters"
            _Passcode.Text = Strings.Left(_Passcode.Text, _Passcode.Text.Length - 1)
        End If
    End Sub
    Private Sub _btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn8.Click
        'Get text from button 8
        _btnDel.Enabled = True
        _Passcode.Text = _Passcode.Text + _btn8.Text
        If _Passcode.Text.Length > 6 Then
            _message.Visible = True
            _message.Text = "Allowed only 6 Characters"
            _Passcode.Text = Strings.Left(_Passcode.Text, _Passcode.Text.Length - 1)
        End If

    End Sub
    Private Sub _btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn9.Click
        'Get text from button 9
        _btnDel.Enabled = True
        _Passcode.Text = _Passcode.Text + _btn9.Text
        If _Passcode.Text.Length > 6 Then
            _message.Visible = True
            _message.Text = "Allowed only 6 Characters"
            _Passcode.Text = Strings.Left(_Passcode.Text, _Passcode.Text.Length - 1)
        End If
    End Sub
    Private Sub _btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn0.Click
        'Get text from button 0
        _btnDel.Enabled = True
        _Passcode.Text = _Passcode.Text + _btn0.Text
        If _Passcode.Text.Length > 6 Then
            _message.Visible = True
            _message.Text = "Allowed only 6 Characters"
            _Passcode.Text = Strings.Left(_Passcode.Text, _Passcode.Text.Length - 1)
        End If
    End Sub
    Private Sub _btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btnDel.Click
        _Passcode.Text = Strings.Left(_Passcode.Text, _Passcode.Text.Length - 1)
        _message.Visible = False
        If _Passcode.Text.Length < 1 Then
            _btnDel.Enabled = False
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
    Private Sub ChangePasscode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _Passcode.Focus()
        _btnDel.Enabled = False
    End Sub
    Private Sub _Passcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Passcode.TextChanged
        If _Passcode.Text.Length = 6 Then
            _message.Visible = False
            _Change.Enabled = True
        Else
            _Change.Enabled = False
        End If
    End Sub

    Private Sub _Change_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Change.Click
        ChangePasscode()
        ChangepasscodeLog()
        _btnDel.Enabled = False
        MessageBox.Show("Your passcode has been changed, click OK. and you will redirect to the Login page.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Application.Restart()
    End Sub
    Public Sub ChangePasscode()
        Dim Menu As New Menu
        Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
        Dim MysqlCommand As New MySqlCommand

        MysqlConn.Close()
        Dim Account As String
        Dim Passcode As String
        Account = _Acc.Text
        Passcode = _Passcode.Text

        Try
            MysqlConn.Open()
            With MysqlCommand
                .Connection = MysqlConn
                .CommandText = "update account set Passcode='" & GetHash(Passcode) & "' where AccountID='" & Account & "' "
                .ExecuteNonQuery()
            End With

            MessageBox.Show("You have been change your passcode.", "Passcode is updated.", MessageBoxButtons.OK, MessageBoxIcon.Information)

            _Passcode.Text = ""


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Close()
        End Try
    End Sub
    Public Sub ChangepasscodeLog()
        Dim ChangePasscode As New ChangePasscode
        Dim MenuHome As New Menu
        Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
        Dim MysqlUpdateLog As New MySqlCommand

        Dim ID As Integer
        Dim Fullname As String
        Dim ChangeDate As String
        Dim ChangeTime As String

        'MysqlConn.Close()
        Try
            MysqlConn.Open()
            ID = Val(Me._Acc.Text)
            Fullname = Me._Name.Text
            ChangeDate = DateTime.Now.ToString("yyyy-MM-dd")
            ChangeTime = TimeOfDay.ToString("hh:mm:ss")

            With MysqlUpdateLog
                .Connection = MysqlConn
                .CommandText = "insert into log (AccountID,Name,Date,Time,Description) Values('" & ID & "','" & Fullname & "','" & ChangeDate & "','" & ChangeTime & "','Successfully Changed the passcode.')"
                .ExecuteNonQuery()
            End With
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Shared Function GetHash(ByVal theInput As String) As String

        Using hasher As MD5 = MD5.Create()    ' create hash object

            ' Convert to byte array and get hash
            Dim dbytes As Byte() =
                 hasher.ComputeHash(Encoding.UTF8.GetBytes(theInput))

            ' sb to create string from bytes
            Dim sBuilder As New StringBuilder()

            ' convert byte data to hex string
            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("X2"))
            Next n

            Return sBuilder.ToString()
        End Using

    End Function

End Class