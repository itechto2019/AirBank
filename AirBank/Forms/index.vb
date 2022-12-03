Imports MySql.Data.MySqlClient
Imports System.Drawing.Text

Public Class Index
    Dim Dashboard As New Dashboard
    Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
    Private Sub Index_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _OnClick.Focus()
        If ConnectionState.Closed Then
            MysqlConn.Open()
        Else
            MysqlConn.Close()
        End If
        Dim Eighty As New PrivateFontCollection()
        Eighty.AddFontFile("C:\Users\User\Desktop\Eighty-Eight.otf")
        Label3.Font = New Font(Eighty.Families(0), 25, FontStyle.Regular)
    End Sub
    Private Sub _OnClick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _OnClick.Click
        If _username.Text = "" And _password.Text = "" Then
            MessageBox.Show("Please, Enter your username and password!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ConnectionLogin()
        End If

    End Sub
    Private Sub _password_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles _password.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.AcceptButton = _OnClick
            ConnectionLogin()
        End If
    End Sub
    Public Sub ConnectionLogin()
        toLogin()
    End Sub
    Public Sub toLogin()
        Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
        Dim MysqlCmdLogin As New MySqlCommand("select * from adminDB where username='" & _username.Text & "' and password='" & _password.Text & "'", MysqlConn)
        Dim MysqlReader As MySqlDataReader

        Try
            MysqlConn.Open()
            MysqlCmdLogin.Parameters.Add(New MySqlParameter("username", _username.Text))
            MysqlCmdLogin.Parameters.Add(New MySqlParameter("password", _password.Text))
            MysqlReader = MysqlCmdLogin.ExecuteReader

            If MysqlReader.HasRows Then
                MessageBox.Show("You have successfully Login to the system. If you encountered bugs, please, report to the Developer.Thank you!", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                Dashboard.Show()
                Dashboard.UpdateLog()
            Else
                _message.Visible = True
                _username.Text = ""
                _password.Text = ""
                _username.Focus()
                _message.Text = "Invalid Username or Password."

            End If

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            MysqlConn.Close()

        End Try
    End Sub
End Class
