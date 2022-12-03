Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient
Public Class AddAccount


    Private Sub _Register_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Register.Click
        Register()
    End Sub
    Public Sub toFillup()
        If _Firstname.Text = "" Or _Lastname.Text = "" Or _Middle.Text = "" Or _Age.Text = "" Or _PasscodeTxt.Text = "" Then
            MessageBox.Show("Please fill up the forms.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            _Register.Enabled = False
        End If
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
    Public Sub Register()
        Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
        Dim MysqlRegisterCmd As New MySqlCommand

        Dim Fname As String
        Dim Lname As String
        Dim Mname As String
        Dim Age As String
        Dim Birth As String
        Dim gender As String
        Dim Balance As String
        Dim Passcode As String

        Fname = _Firstname.Text.ToUpper
        Lname = _Lastname.Text.ToUpper
        Mname = _Middle.Text.ToUpper
        Age = _Age.Text
        Birth = _Birth.Text
        gender = _Gender.Text.ToUpper
        Balance = _Deposit.Text
        Passcode = _PasscodeTxt.Text

        MysqlConn.Close()
        Try
            MysqlConn.Open()
            With MysqlRegisterCmd
                .Connection = MysqlConn
                .CommandText = "insert into account (AccountID,Firstname,Lastname,Middle,Birthdate,Balance,Passcode,Age,Gender)  Values(null,'" & Fname & "','" & Lname & "','" & Mname & "','" & Birth & "','" & Balance & "','" & GetHash(Passcode) & "','" & Age & "','" & gender & "')"
                .ExecuteNonQuery()
            End With
            MessageBox.Show("You have been successfully created an account.", "Account created", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UpdateLog()
            _Firstname.Text = ""
            _Lastname.Text = ""
            _Middle.Text = ""
            _Age.Text = ""
            _PasscodeTxt.Text = ""
            _Deposit.Text = ""
            _Gender.Text = "MALE"
            _Register.Enabled = False
        Catch ex As Exception
            MysqlConn.Close()
        Finally
            MysqlConn.Close()
        End Try
    End Sub
    Private Sub AddAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _Birth.Format = DateTimePickerFormat.Custom
        _Birth.CustomFormat = "yyyy-MM-dd"
        _Gender.Text = "MALE"
    End Sub

    Private Sub _Age_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _Age.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
    End Sub
    Private Sub _Firstname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _Firstname.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = (Char.IsDigit(e.KeyChar))
        End If
    End Sub

    Private Sub _Middle_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _Middle.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = (Char.IsDigit(e.KeyChar))
        End If
    End Sub

    Private Sub _Lastname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _Lastname.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = (Char.IsDigit(e.KeyChar))
        End If
    End Sub

    Private Sub _Deposit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _Deposit.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
    End Sub

    Private Sub _PasscodeTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _PasscodeTxt.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
    End Sub

    Private Sub _rdMale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _rdMale.CheckedChanged
        _Gender.Text = "MALE"
    End Sub

    Private Sub _rdFemale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _rdFemale.CheckedChanged
        _Gender.Text = "FEMALE"
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

    Private Sub _PasscodeTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If _PasscodeTxt.Text.Length < 6 Then
            _Message.Visible = True
            _Message.Text = "You must Enter 6 digit code."
        Else
            _Message.Visible = False
        End If
    End Sub

    Private Sub _Check_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Check.Click
        checkAccount()
    End Sub
    Public Sub checkAccount()
        Dim Fname As String
        Dim Lname As String
        Dim Mname As String
        Fname = _Firstname.Text.ToUpper
        Lname = _Lastname.Text.ToUpper
        Mname = _Middle.Text.ToUpper
        Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
        Dim MysqlReader As MySqlDataReader
        Dim MysqlQueryReader As New MySqlCommand("select * from account where Firstname='" & Fname & "' AND Lastname='" & Lname & "' AND Middle='" & Mname & "'", MysqlConn)
        MysqlConn.Open()
        MysqlReader = MysqlQueryReader.ExecuteReader
        If MysqlReader.HasRows Then
            MsgBox("Data is already exist!", MsgBoxStyle.Exclamation, "Existing Data!")
        ElseIf _Firstname.Text = "" Or _Lastname.Text = "" Or _Middle.Text = "" Or _Age.Text = "" Or _PasscodeTxt.Text = "" Then
            MessageBox.Show("Please fill up the forms.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            _Register.Enabled = False
        ElseIf _PasscodeTxt.Text.Length < 6 Then
            _Message.Visible = True
            _Message.Text = "You must Enter 6 digit code."
        Else
            _Message.Visible = False
            _Register.Enabled = True
            MysqlConn.Close()
        End If
    End Sub
    Private Sub _Deposit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _PasscodeTxt.TextChanged, _Middle.TextChanged, _Lastname.TextChanged, _Gender.TextChanged, _Firstname.TextChanged, _Deposit.TextChanged, _Age.TextChanged
        _Register.Enabled = False
    End Sub
End Class