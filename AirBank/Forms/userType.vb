Imports System.Drawing.Text
Public Class Accounts

    Private Sub userType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Eighty As New PrivateFontCollection()
        Eighty.AddFontFile("C:\Users\User\Desktop\Eighty-Eight.otf")
        Label1.Font = New Font(Eighty.Families(0), 30, FontStyle.Regular)
        getDate()
    End Sub
    Public Sub getDate()
        MyTime.Text = TimeOfDay.ToString("hh:mm tt")
        myDate.Text = DateTime.Now.ToShortDateString
    End Sub

    Private Sub _AdminMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _AdminMode.Click
        Dim AdminMode As New Index
        Me.Hide()
        AdminMode.Show()
    End Sub

    Private Sub _Usermode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Usermode.Click
        Dim Usermode As New Login
        Me.Hide()
        Usermode.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Report.Show()
    End Sub
End Class