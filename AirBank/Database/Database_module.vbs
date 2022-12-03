Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient
Module Database_module
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
    Public Sub toLogin()
        Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
        Dim MysqlCmdLogin As New MySqlCommand("select * from adminDB where username='" & GetHash(Index._username.Text) & "' and password='" & GetHash(Index._password.Text) & "'", MysqlConn)
        Dim MysqlReader As MySqlDataReader

        Try
            MysqlConn.Open()
            MysqlCmdLogin.Parameters.Add(New MySqlParameter("username", Index._username.Text))
            MysqlCmdLogin.Parameters.Add(New MySqlParameter("password", Index._password.Text))
            MysqlReader = MysqlCmdLogin.ExecuteReader

            If MysqlReader.HasRows Then
                MessageBox.Show("You have successfully Login to the system. If you encountered technical error, please, contact the Developer.Thank you!", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Index.Hide()
                Dashboard.Show()
                Dashboard.UpdateLog()
            Else
                Index._message.Visible = True
                Index._username.Text = ""
                Index._password.Text = ""
                Index._username.Focus()
                Index._message.Text = "Invalid Username or Password."

            End If

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            MysqlConn.Close()

        End Try
    End Sub
    Public Sub toLoginUser()
        Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
        Dim MysqlCmdLogin As New MySqlCommand("select * from account where Passcode='" & GetHash(Login._passcodeTxt.Text) & "' ", MysqlConn)
        Dim MysqlCmdRecord As New MySqlCommand("select AccountID,Firstname,Lastname,Middle,Age,Birthdate,Balance,Gender from account", MysqlConn)
        Dim MysqlReader As MySqlDataReader

        Try
            MysqlConn.Open()
            MysqlCmdLogin.Parameters.Add(New MySqlParameter("Passcode", Login._passcodeTxt.Text))
            MysqlReader = MysqlCmdLogin.ExecuteReader

            If MysqlReader.HasRows Then
                MessageBox.Show("Login Success", "Login Status: Online", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Login.Hide()
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
                Login._message.Visible = True
                Login._message.Text = "Invalid Passcode."
                Login._passcodeTxt.Text = ""
            End If
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            MysqlConn.Close()
        End Try
    End Sub

    Public Sub toPassodeFormShow()
        Dim ChangePasscode As New ChangePasscode
        Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=administratordb")
        Dim MysqlCommand As New MySqlCommand("select AccountID,Firstname,Lastname,Middle,Balance from account  where AccountID='" & Menu._Acc.Text & "'", MysqlConn)

        Dim MysqlReader As MySqlDataReader

        Try
            MysqlConn.Open()
            MysqlReader = MysqlCommand.ExecuteReader
            If MysqlReader.HasRows Then
                ChangePasscode.Show()
                MysqlReader.Read()
                ChangePasscode._Name.Text = MysqlReader("Firstname") + "," + MysqlReader("Middle") + " " + MysqlReader("Lastname")
                ChangePasscode._Acc.Text = MysqlReader("AccountID")
            End If
        Catch ex As Exception

        End Try


    End Sub
    
    
End Module