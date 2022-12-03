<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me._Birth = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me._Acc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me._Gender = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me._Age = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me._Name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._bal = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me._ChangeCode = New System.Windows.Forms.Button()
        Me._Logout = New System.Windows.Forms.Button()
        Me._Deposite = New System.Windows.Forms.Button()
        Me._Withdraw = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me._Birth)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me._Acc)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me._Gender)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me._Age)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me._Name)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me._bal)
        Me.Panel1.Location = New System.Drawing.Point(203, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(396, 438)
        Me.Panel1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Candara Light", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 28)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Date of Birth"
        '
        '_Birth
        '
        Me._Birth.Font = New System.Drawing.Font("Candara Light", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Birth.Location = New System.Drawing.Point(147, 284)
        Me._Birth.Multiline = True
        Me._Birth.Name = "_Birth"
        Me._Birth.ReadOnly = True
        Me._Birth.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._Birth.Size = New System.Drawing.Size(233, 31)
        Me._Birth.TabIndex = 23
        Me._Birth.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Candara Light", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(188, 28)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Account Number#"
        '
        '_Acc
        '
        Me._Acc.Font = New System.Drawing.Font("Candara Light", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Acc.Location = New System.Drawing.Point(203, 247)
        Me._Acc.Multiline = True
        Me._Acc.Name = "_Acc"
        Me._Acc.ReadOnly = True
        Me._Acc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._Acc.Size = New System.Drawing.Size(177, 31)
        Me._Acc.TabIndex = 21
        Me._Acc.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Candara Light", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 28)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Gender: "
        '
        '_Gender
        '
        Me._Gender.Font = New System.Drawing.Font("Candara Light", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Gender.Location = New System.Drawing.Point(277, 213)
        Me._Gender.Multiline = True
        Me._Gender.Name = "_Gender"
        Me._Gender.ReadOnly = True
        Me._Gender.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._Gender.Size = New System.Drawing.Size(103, 31)
        Me._Gender.TabIndex = 19
        Me._Gender.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Candara Light", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 28)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Age: "
        '
        '_Age
        '
        Me._Age.Font = New System.Drawing.Font("Candara Light", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Age.Location = New System.Drawing.Point(277, 178)
        Me._Age.Multiline = True
        Me._Age.Name = "_Age"
        Me._Age.ReadOnly = True
        Me._Age.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._Age.Size = New System.Drawing.Size(103, 31)
        Me._Age.TabIndex = 17
        Me._Age.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara Light", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 28)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Name:"
        '
        '_Name
        '
        Me._Name.Font = New System.Drawing.Font("Candara Light", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Name.Location = New System.Drawing.Point(90, 144)
        Me._Name.Multiline = True
        Me._Name.Name = "_Name"
        Me._Name.ReadOnly = True
        Me._Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._Name.Size = New System.Drawing.Size(290, 31)
        Me._Name.TabIndex = 15
        Me._Name.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara Light", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(44, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(304, 33)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "WELCOME TO AIRBANK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara Light", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 324)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Balance: "
        '
        '_bal
        '
        Me._bal.Font = New System.Drawing.Font("Candara Light", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._bal.Location = New System.Drawing.Point(113, 321)
        Me._bal.Multiline = True
        Me._bal.Name = "_bal"
        Me._bal.ReadOnly = True
        Me._bal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._bal.Size = New System.Drawing.Size(267, 31)
        Me._bal.TabIndex = 0
        Me._bal.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(614, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(188, 262)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Latest Update"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(6, 26)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(176, 230)
        Me.TextBox5.TabIndex = 0
        Me.TextBox5.Text = "[READ CAREFULLY]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- We will maintenace on " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   June 1, 2021. It takes " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   two " & _
            "hours to server " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   open." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- This 1st of May we " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   open on 10 a.m. to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   1" & _
            "0 p.m."
        '
        '_ChangeCode
        '
        Me._ChangeCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(191, Byte), Integer))
        Me._ChangeCode.FlatAppearance.BorderSize = 0
        Me._ChangeCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._ChangeCode.Image = Global.AirBank.My.Resources.Resources.icons8_asterisk_96px
        Me._ChangeCode.Location = New System.Drawing.Point(631, 300)
        Me._ChangeCode.Name = "_ChangeCode"
        Me._ChangeCode.Size = New System.Drawing.Size(158, 138)
        Me._ChangeCode.TabIndex = 5
        Me._ChangeCode.Text = "Change Passcode"
        Me._ChangeCode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._ChangeCode.UseVisualStyleBackColor = False
        '
        '_Logout
        '
        Me._Logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(191, Byte), Integer))
        Me._Logout.FlatAppearance.BorderSize = 0
        Me._Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Logout.Image = Global.AirBank.My.Resources.Resources.icons8_close_window_96px
        Me._Logout.Location = New System.Drawing.Point(25, 300)
        Me._Logout.Name = "_Logout"
        Me._Logout.Size = New System.Drawing.Size(158, 138)
        Me._Logout.TabIndex = 3
        Me._Logout.Text = "Logout"
        Me._Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Logout.UseVisualStyleBackColor = False
        '
        '_Deposite
        '
        Me._Deposite.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(191, Byte), Integer))
        Me._Deposite.FlatAppearance.BorderSize = 0
        Me._Deposite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Deposite.Image = Global.AirBank.My.Resources.Resources.icons8_deposit_96px
        Me._Deposite.Location = New System.Drawing.Point(25, 156)
        Me._Deposite.Name = "_Deposite"
        Me._Deposite.Size = New System.Drawing.Size(158, 138)
        Me._Deposite.TabIndex = 2
        Me._Deposite.Text = "Deposit"
        Me._Deposite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Deposite.UseVisualStyleBackColor = False
        '
        '_Withdraw
        '
        Me._Withdraw.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(191, Byte), Integer))
        Me._Withdraw.FlatAppearance.BorderSize = 0
        Me._Withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Withdraw.Image = Global.AirBank.My.Resources.Resources.icons8_withdrawal_96px
        Me._Withdraw.Location = New System.Drawing.Point(25, 12)
        Me._Withdraw.Name = "_Withdraw"
        Me._Withdraw.Size = New System.Drawing.Size(158, 138)
        Me._Withdraw.TabIndex = 1
        Me._Withdraw.Text = "Withdraw"
        Me._Withdraw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Withdraw.UseVisualStyleBackColor = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(814, 462)
        Me.Controls.Add(Me._ChangeCode)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me._Logout)
        Me.Controls.Add(Me._Deposite)
        Me.Controls.Add(Me._Withdraw)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents _bal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents _Acc As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents _Gender As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents _Age As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents _Name As System.Windows.Forms.TextBox
    Friend WithEvents _Withdraw As System.Windows.Forms.Button
    Friend WithEvents _Deposite As System.Windows.Forms.Button
    Friend WithEvents _Logout As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents _ChangeCode As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents _Birth As System.Windows.Forms.TextBox
End Class
