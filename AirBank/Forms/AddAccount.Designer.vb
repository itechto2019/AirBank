<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAccount
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me._Message = New System.Windows.Forms.Label()
        Me._Gender = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me._rdFemale = New System.Windows.Forms.RadioButton()
        Me._rdMale = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me._PasscodeTxt = New System.Windows.Forms.TextBox()
        Me._Deposit = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me._Birth = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me._Age = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me._Lastname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me._Middle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me._Firstname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._Check = New System.Windows.Forms.Button()
        Me._Register = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me._Check)
        Me.GroupBox1.Controls.Add(Me._Message)
        Me.GroupBox1.Controls.Add(Me._Gender)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me._rdFemale)
        Me.GroupBox1.Controls.Add(Me._rdMale)
        Me.GroupBox1.Controls.Add(Me._Register)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me._PasscodeTxt)
        Me.GroupBox1.Controls.Add(Me._Deposit)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me._Birth)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me._Age)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me._Lastname)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me._Middle)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me._Firstname)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 46)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(978, 361)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add new Entry"
        '
        '_Message
        '
        Me._Message.AutoSize = True
        Me._Message.Location = New System.Drawing.Point(272, 314)
        Me._Message.Name = "_Message"
        Me._Message.Size = New System.Drawing.Size(69, 19)
        Me._Message.TabIndex = 33
        Me._Message.Text = "Message"
        Me._Message.Visible = False
        '
        '_Gender
        '
        Me._Gender.Location = New System.Drawing.Point(413, 285)
        Me._Gender.MaxLength = 6
        Me._Gender.Name = "_Gender"
        Me._Gender.ReadOnly = True
        Me._Gender.Size = New System.Drawing.Size(141, 27)
        Me._Gender.TabIndex = 32
        Me._Gender.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(272, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 19)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Gender: "
        '
        '_rdFemale
        '
        Me._rdFemale.AutoSize = True
        Me._rdFemale.Location = New System.Drawing.Point(479, 258)
        Me._rdFemale.Name = "_rdFemale"
        Me._rdFemale.Size = New System.Drawing.Size(75, 23)
        Me._rdFemale.TabIndex = 8
        Me._rdFemale.TabStop = True
        Me._rdFemale.Text = "Female"
        Me._rdFemale.UseVisualStyleBackColor = True
        '
        '_rdMale
        '
        Me._rdMale.AutoSize = True
        Me._rdMale.Checked = True
        Me._rdMale.Location = New System.Drawing.Point(413, 258)
        Me._rdMale.Name = "_rdMale"
        Me._rdMale.Size = New System.Drawing.Size(60, 23)
        Me._rdMale.TabIndex = 7
        Me._rdMale.TabStop = True
        Me._rdMale.Text = "Male"
        Me._rdMale.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(272, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 19)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Passcode:"
        '
        '_PasscodeTxt
        '
        Me._PasscodeTxt.Location = New System.Drawing.Point(413, 225)
        Me._PasscodeTxt.MaxLength = 6
        Me._PasscodeTxt.Name = "_PasscodeTxt"
        Me._PasscodeTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me._PasscodeTxt.Size = New System.Drawing.Size(280, 27)
        Me._PasscodeTxt.TabIndex = 6
        '
        '_Deposit
        '
        Me._Deposit.Location = New System.Drawing.Point(413, 159)
        Me._Deposit.Name = "_Deposit"
        Me._Deposit.Size = New System.Drawing.Size(280, 27)
        Me._Deposit.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(272, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "First Deposit:"
        '
        '_Birth
        '
        Me._Birth.Location = New System.Drawing.Point(413, 192)
        Me._Birth.Name = "_Birth"
        Me._Birth.Size = New System.Drawing.Size(280, 27)
        Me._Birth.TabIndex = 9
        Me._Birth.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(272, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Birthday: "
        '
        '_Age
        '
        Me._Age.Location = New System.Drawing.Point(413, 126)
        Me._Age.MaxLength = 3
        Me._Age.Name = "_Age"
        Me._Age.Size = New System.Drawing.Size(280, 27)
        Me._Age.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(272, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Age: "
        '
        '_Lastname
        '
        Me._Lastname.Location = New System.Drawing.Point(413, 93)
        Me._Lastname.Name = "_Lastname"
        Me._Lastname.Size = New System.Drawing.Size(280, 27)
        Me._Lastname.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(272, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Lastname: "
        '
        '_Middle
        '
        Me._Middle.Location = New System.Drawing.Point(413, 60)
        Me._Middle.Name = "_Middle"
        Me._Middle.Size = New System.Drawing.Size(280, 27)
        Me._Middle.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(272, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Middle: "
        '
        '_Firstname
        '
        Me._Firstname.Location = New System.Drawing.Point(413, 27)
        Me._Firstname.Name = "_Firstname"
        Me._Firstname.Size = New System.Drawing.Size(280, 27)
        Me._Firstname.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(272, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Firstname: "
        '
        '_Check
        '
        Me._Check.FlatAppearance.BorderSize = 0
        Me._Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Check.Image = Global.AirBank.My.Resources.Resources.icons8_ok_48px1
        Me._Check.Location = New System.Drawing.Point(560, 260)
        Me._Check.Name = "_Check"
        Me._Check.Size = New System.Drawing.Size(133, 54)
        Me._Check.TabIndex = 34
        Me._Check.Text = "Check"
        Me._Check.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me._Check.UseVisualStyleBackColor = True
        '
        '_Register
        '
        Me._Register.Enabled = False
        Me._Register.FlatAppearance.BorderSize = 0
        Me._Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Register.Image = Global.AirBank.My.Resources.Resources.icons8_plus_48px
        Me._Register.Location = New System.Drawing.Point(699, 260)
        Me._Register.Name = "_Register"
        Me._Register.Size = New System.Drawing.Size(133, 54)
        Me._Register.TabIndex = 9
        Me._Register.Text = "Register"
        Me._Register.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me._Register.UseVisualStyleBackColor = True
        '
        'AddAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1004, 435)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddAccount"
        Me.Text = "AddAccount"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents _Deposit As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents _Birth As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents _Age As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents _Lastname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents _Middle As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents _Firstname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents _PasscodeTxt As System.Windows.Forms.TextBox
    Friend WithEvents _Register As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents _rdFemale As System.Windows.Forms.RadioButton
    Friend WithEvents _rdMale As System.Windows.Forms.RadioButton
    Friend WithEvents _Gender As System.Windows.Forms.TextBox
    Friend WithEvents _Message As System.Windows.Forms.Label
    Friend WithEvents _Check As System.Windows.Forms.Button
End Class
