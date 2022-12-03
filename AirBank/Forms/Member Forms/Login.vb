Imports MySql.Data.MySqlClient
Imports System.Drawing.Text
Imports System.Security.Cryptography
Imports System.Text

Public Class Login
    Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _passcodeTxt.Focus()
        If ConnectionState.Closed Then
            MysqlConn.Open()
        Else
            MysqlConn.Close()
        End If

        _btnDel.Enabled = False
        Dim Eighty As New PrivateFontCollection()
        Eighty.AddFontFile("C:\Users\User\Desktop\Eighty-Eight.otf")
        Label1.Font = New Font(Eighty.Families(0), 30, FontStyle.Regular)
    End Sub
    'Input to Passcode Field
    Private Sub _btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn1.Click
        'Get text from button 1
        _btnDel.Enabled = True
        _passcodeTxt.MaxLength = 6
        _passcodeTxt.Text = _passcodeTxt.Text + _btn1.Text
        If _passcodeTxt.Text.Length > 6 Then
            _message.Visible = True
            _message.Text = "Allowed only 6 Characters"
            _passcodeTxt.Text = Strings.Left(_passcodeTxt.Text, _passcodeTxt.Text.Length - 1)
        End If
    End Sub
    Private Sub _btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn2.Click
        'Get text from button 2
        _btnDel.Enabled = True
        _passcodeTxt.MaxLength = 6
        _passcodeTxt.Text = _passcodeTxt.Text + _btn2.Text
        If _passcodeTxt.Text.Length > 6 Then
            _message.Visible = True
            _message.Text = "Allowed only 6 Characters"
            _passcodeTxt.Text = Strings.Left(_passcodeTxt.Text, _passcodeTxt.Text.Length - 1)
        End If
    End Sub
    Private Sub _btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn3.Click
        'Get text from button 3
        _btnDel.Enabled = True
        _passcodeTxt.MaxLength = 6
        _passcodeTxt.Text = _passcodeTxt.Text + _btn3.Text
        If _passcodeTxt.Text.Length > 6 Then
            _message.Visible = True
            _message.Text = "Allowed only 6 Characters"
            _passcodeTxt.Text = Strings.Left(_passcodeTxt.Text, _passcodeTxt.Text.Length - 1)
        End If
    End Sub
    Private Sub _btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn4.Click
        'Get text from button 4
        _btnDel.Enabled = True
        _passcodeTxt.MaxLength = 6
        _passcodeTxt.Text = _passcodeTxt.Text + _btn4.Text
        If _passcodeTxt.Text.Length > 6 Then
            _message.Visible = True
            _message.Text = "Allowed only 6 Characters"
            _passcodeTxt.Text = Strings.Left(_passcodeTxt.Text, _passcodeTxt.Text.Length - 1)
        End If
    End Sub
    Private Sub _btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn5.Click
        'Get text from button 5
        _btnDel.Enabled = True
        _passcodeTxt.MaxLength = 6
        _passcodeTxt.Text = _passcodeTxt.Text + _btn5.Text
        If _passcodeTxt.Text.Length > 6 Then
            _message.Visible = True
            _message.Text = "Allowed only 6 Characters"
            _passcodeTxt.Text = Strings.Left(_passcodeTxt.Text, _passcodeTxt.Text.Length - 1)
        End If
    End Sub
    Private Sub _btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn6.Click
        'Get text from button 6
        _btnDel.Enabled = True
        _passcodeTxt.MaxLength = 6
        _passcodeTxt.Text = _passcodeTxt.Text + _btn6.Text
        If _passcodeTxt.Text.Length > 6 Then
            _message.Visible = True
            _message.Text = "Allowed only 6 Characters"
            _passcodeTxt.Text = Strings.Left(_passcodeTxt.Text, _passcodeTxt.Text.Length - 1)
        End If
    End Sub
    Private Sub _btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn7.Click
        'Get text from button 7
        _btnDel.Enabled = True
        _passcodeTxt.MaxLength = 6
        _passcodeTxt.Text = _passcodeTxt.Text + _btn7.Text
        If _passcodeTxt.Text.Length > 6 Then
            _message.Visible = True
            _message.Text = "Allowed only 6 Characters"
            _passcodeTxt.Text = Strings.Left(_passcodeTxt.Text, _passcodeTxt.Text.Length - 1)
        End If
    End Sub
    Private Sub _btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn8.Click
        'Get text from button 8
        _btnDel.Enabled = True
        _passcodeTxt.MaxLength = 6
        _passcodeTxt.Text = _passcodeTxt.Text + _btn8.Text
        If _passcodeTxt.Text.Length > 6 Then
            _message.Visible = True
            _message.Text = "Allowed only 6 Characters"
            _passcodeTxt.Text = Strings.Left(_passcodeTxt.Text, _passcodeTxt.Text.Length - 1)
        End If
    End Sub
    Private Sub _btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn9.Click
        'Get text from button 9
        _btnDel.Enabled = True
        _passcodeTxt.MaxLength = 6
        _passcodeTxt.Text = _passcodeTxt.Text + _btn9.Text
        If _passcodeTxt.Text.Length > 6 Then
            _message.Visible = True
            _message.Text = "Allowed only 6 Characters"
            _passcodeTxt.Text = Strings.Left(_passcodeTxt.Text, _passcodeTxt.Text.Length - 1)
        End If
    End Sub
    Private Sub _btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn0.Click
        'Get text from button 0
        _btnDel.Enabled = True
        _passcodeTxt.MaxLength = 6
        _passcodeTxt.Text = _passcodeTxt.Text + _btn0.Text
        If _passcodeTxt.Text.Length > 6 Then
            _message.Visible = True
            _message.Text = "Allowed only 6 Characters"
            _passcodeTxt.Text = Strings.Left(_passcodeTxt.Text, _passcodeTxt.Text.Length - 1)
        End If
    End Sub
    Private Sub _btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btnEnter.Click
        'Validation
        toLoginUser()
        _btnDel.Enabled = False
    End Sub

    Private Sub _btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btnDel.Click
        _passcodeTxt.Text = Strings.Left(_passcodeTxt.Text, _passcodeTxt.Text.Length - 1)
        _message.Visible = False
        If _passcodeTxt.Text.Length < 1 Then
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
    Private Sub _btnEnter_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btnEnter.MouseEnter
        _btnEnter.Width = 78
        _btnEnter.Height = 56
    End Sub

    Private Sub _btnEnter_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btnEnter.MouseLeave
        _btnEnter.Width = 75
        _btnEnter.Height = 53
    End Sub
    Public Sub toLoginUser()
        Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
        Dim MysqlCmdLogin As New MySqlCommand("select * from account where AccountID='" & _AccountID.Text & "' and Passcode='" & GetHash(_passcodeTxt.Text) & "' ", MysqlConn)
        Dim MysqlCmdRecord As New MySqlCommand("select AccountID,Firstname,Lastname,Middle,Age,Birthdate,Balance,Gender from account", MysqlConn)
        Dim MysqlReader As MySqlDataReader

        Try
            MysqlConn.Open()
            MysqlCmdLogin.Parameters.Add(New MySqlParameter("AccountID", _AccountID.Text))
            MysqlCmdLogin.Parameters.Add(New MySqlParameter("Passcode", _passcodeTxt.Text))
            MysqlReader = MysqlCmdLogin.ExecuteReader
            Dim Menu As New Menu
            If MysqlReader.HasRows Then
                MessageBox.Show("Login Success", "Login Status: Online", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                Menu.Show()

                MysqlReader.Read()
                Menu._Name.Text = MysqlReader("Firstname") + " " + MysqlReader("Middle") + " " + MysqlReader("Lastname")
                Menu._Age.Text = MysqlReader("Age")
                Menu._Gender.Text = MysqlReader("Gender")
                Menu._Acc.Text = MysqlReader("AccountID")
                Menu._Birth.Text = MysqlReader("Birthdate")
                Menu._bal.Text = MysqlReader("Balance")
                Menu._bal.Text = Format(Val(Menu._bal.Text), "#,###,##0.00")
                Menu.UpdateLog()


            Else
                _message.Visible = True
                _message.Text = "Invalid Passcode."
                _passcodeTxt.Text = ""
                _AccountID.Text = ""
            End If
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            MysqlConn.Close()
        End Try
    End Sub
    Function GetHash(ByVal theInput As String) As String

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

    Private Sub _AccountID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _AccountID.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
    End Sub

    Private Sub _AccountID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _AccountID.Click
        _AccountID.Text = ""
    End Sub
End Class