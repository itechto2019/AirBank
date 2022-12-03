<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePasscode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePasscode))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._Passcode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me._Acc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me._Name = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me._message = New System.Windows.Forms.Label()
        Me._btnDel = New System.Windows.Forms.Button()
        Me._btn7 = New System.Windows.Forms.Button()
        Me._btn9 = New System.Windows.Forms.Button()
        Me._btn0 = New System.Windows.Forms.Button()
        Me._btn8 = New System.Windows.Forms.Button()
        Me._btn6 = New System.Windows.Forms.Button()
        Me._btn5 = New System.Windows.Forms.Button()
        Me._btn4 = New System.Windows.Forms.Button()
        Me._btn3 = New System.Windows.Forms.Button()
        Me._btn2 = New System.Windows.Forms.Button()
        Me._btn1 = New System.Windows.Forms.Button()
        Me._Cancel = New System.Windows.Forms.Button()
        Me._Change = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me._Passcode)
        Me.GroupBox1.Controls.Add(Me._Cancel)
        Me.GroupBox1.Controls.Add(Me._Change)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me._Acc)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me._Name)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 320)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Change Passcode"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara Light", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(83, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 28)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "New Passcode"
        '
        '_Passcode
        '
        Me._Passcode.Font = New System.Drawing.Font("Candara Light", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Passcode.Location = New System.Drawing.Point(6, 184)
        Me._Passcode.MaxLength = 6
        Me._Passcode.Multiline = True
        Me._Passcode.Name = "_Passcode"
        Me._Passcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me._Passcode.ReadOnly = True
        Me._Passcode.Size = New System.Drawing.Size(301, 31)
        Me._Passcode.TabIndex = 37
        Me._Passcode.TabStop = False
        Me._Passcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Candara Light", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(66, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(188, 28)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Account Number#"
        '
        '_Acc
        '
        Me._Acc.Font = New System.Drawing.Font("Candara Light", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Acc.Location = New System.Drawing.Point(6, 119)
        Me._Acc.Multiline = True
        Me._Acc.Name = "_Acc"
        Me._Acc.ReadOnly = True
        Me._Acc.Size = New System.Drawing.Size(301, 31)
        Me._Acc.TabIndex = 31
        Me._Acc.TabStop = False
        Me._Acc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara Light", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(118, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 28)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Name:"
        '
        '_Name
        '
        Me._Name.Font = New System.Drawing.Font("Candara Light", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Name.Location = New System.Drawing.Point(6, 54)
        Me._Name.Multiline = True
        Me._Name.Name = "_Name"
        Me._Name.ReadOnly = True
        Me._Name.Size = New System.Drawing.Size(301, 31)
        Me._Name.TabIndex = 29
        Me._Name.TabStop = False
        Me._Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me._message)
        Me.GroupBox2.Controls.Add(Me._btnDel)
        Me.GroupBox2.Controls.Add(Me._btn7)
        Me.GroupBox2.Controls.Add(Me._btn9)
        Me.GroupBox2.Controls.Add(Me._btn0)
        Me.GroupBox2.Controls.Add(Me._btn8)
        Me.GroupBox2.Controls.Add(Me._btn6)
        Me.GroupBox2.Controls.Add(Me._btn5)
        Me.GroupBox2.Controls.Add(Me._btn4)
        Me.GroupBox2.Controls.Add(Me._btn3)
        Me.GroupBox2.Controls.Add(Me._btn2)
        Me.GroupBox2.Controls.Add(Me._btn1)
        Me.GroupBox2.Location = New System.Drawing.Point(335, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(292, 320)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Enter your new passcode"
        '
        '_message
        '
        Me._message.AutoSize = True
        Me._message.ForeColor = System.Drawing.Color.Red
        Me._message.Location = New System.Drawing.Point(38, 287)
        Me._message.Name = "_message"
        Me._message.Size = New System.Drawing.Size(69, 19)
        Me._message.TabIndex = 39
        Me._message.Text = "Message"
        Me._message.Visible = False
        '
        '_btnDel
        '
        Me._btnDel.Location = New System.Drawing.Point(32, 223)
        Me._btnDel.Name = "_btnDel"
        Me._btnDel.Size = New System.Drawing.Size(75, 53)
        Me._btnDel.TabIndex = 13
        Me._btnDel.TabStop = False
        Me._btnDel.Text = "Del"
        Me._btnDel.UseVisualStyleBackColor = True
        '
        '_btn7
        '
        Me._btn7.Location = New System.Drawing.Point(32, 46)
        Me._btn7.Name = "_btn7"
        Me._btn7.Size = New System.Drawing.Size(75, 53)
        Me._btn7.TabIndex = 7
        Me._btn7.TabStop = False
        Me._btn7.Text = "7"
        Me._btn7.UseVisualStyleBackColor = True
        '
        '_btn9
        '
        Me._btn9.Location = New System.Drawing.Point(194, 46)
        Me._btn9.Name = "_btn9"
        Me._btn9.Size = New System.Drawing.Size(75, 53)
        Me._btn9.TabIndex = 9
        Me._btn9.TabStop = False
        Me._btn9.Text = "9"
        Me._btn9.UseVisualStyleBackColor = True
        '
        '_btn0
        '
        Me._btn0.Location = New System.Drawing.Point(113, 223)
        Me._btn0.Name = "_btn0"
        Me._btn0.Size = New System.Drawing.Size(75, 53)
        Me._btn0.TabIndex = 10
        Me._btn0.TabStop = False
        Me._btn0.Text = "0"
        Me._btn0.UseVisualStyleBackColor = True
        '
        '_btn8
        '
        Me._btn8.Location = New System.Drawing.Point(113, 46)
        Me._btn8.Name = "_btn8"
        Me._btn8.Size = New System.Drawing.Size(75, 53)
        Me._btn8.TabIndex = 8
        Me._btn8.TabStop = False
        Me._btn8.Text = "8"
        Me._btn8.UseVisualStyleBackColor = True
        '
        '_btn6
        '
        Me._btn6.Location = New System.Drawing.Point(194, 105)
        Me._btn6.Name = "_btn6"
        Me._btn6.Size = New System.Drawing.Size(75, 53)
        Me._btn6.TabIndex = 6
        Me._btn6.TabStop = False
        Me._btn6.Text = "6"
        Me._btn6.UseVisualStyleBackColor = True
        '
        '_btn5
        '
        Me._btn5.Location = New System.Drawing.Point(113, 105)
        Me._btn5.Name = "_btn5"
        Me._btn5.Size = New System.Drawing.Size(75, 53)
        Me._btn5.TabIndex = 5
        Me._btn5.TabStop = False
        Me._btn5.Text = "5"
        Me._btn5.UseVisualStyleBackColor = True
        '
        '_btn4
        '
        Me._btn4.Location = New System.Drawing.Point(32, 105)
        Me._btn4.Name = "_btn4"
        Me._btn4.Size = New System.Drawing.Size(75, 53)
        Me._btn4.TabIndex = 4
        Me._btn4.TabStop = False
        Me._btn4.Text = "4"
        Me._btn4.UseVisualStyleBackColor = True
        '
        '_btn3
        '
        Me._btn3.Location = New System.Drawing.Point(194, 164)
        Me._btn3.Name = "_btn3"
        Me._btn3.Size = New System.Drawing.Size(75, 53)
        Me._btn3.TabIndex = 3
        Me._btn3.TabStop = False
        Me._btn3.Text = "3"
        Me._btn3.UseVisualStyleBackColor = True
        '
        '_btn2
        '
        Me._btn2.Location = New System.Drawing.Point(113, 164)
        Me._btn2.Name = "_btn2"
        Me._btn2.Size = New System.Drawing.Size(75, 53)
        Me._btn2.TabIndex = 2
        Me._btn2.TabStop = False
        Me._btn2.Text = "2"
        Me._btn2.UseVisualStyleBackColor = True
        '
        '_btn1
        '
        Me._btn1.Location = New System.Drawing.Point(32, 164)
        Me._btn1.Name = "_btn1"
        Me._btn1.Size = New System.Drawing.Size(75, 53)
        Me._btn1.TabIndex = 1
        Me._btn1.TabStop = False
        Me._btn1.Text = "1"
        Me._btn1.UseVisualStyleBackColor = True
        '
        '_Cancel
        '
        Me._Cancel.FlatAppearance.BorderSize = 0
        Me._Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cancel.ForeColor = System.Drawing.SystemColors.Control
        Me._Cancel.Image = Global.AirBank.My.Resources.Resources.icons8_unavailable_32px
        Me._Cancel.Location = New System.Drawing.Point(6, 270)
        Me._Cancel.Name = "_Cancel"
        Me._Cancel.Size = New System.Drawing.Size(301, 43)
        Me._Cancel.TabIndex = 36
        Me._Cancel.TabStop = False
        Me._Cancel.Text = "Cancel"
        Me._Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me._Cancel.UseVisualStyleBackColor = True
        '
        '_Change
        '
        Me._Change.Enabled = False
        Me._Change.FlatAppearance.BorderSize = 0
        Me._Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Change.ForeColor = System.Drawing.SystemColors.Control
        Me._Change.Image = Global.AirBank.My.Resources.Resources.icons8_ok_32px
        Me._Change.Location = New System.Drawing.Point(6, 221)
        Me._Change.Name = "_Change"
        Me._Change.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me._Change.Size = New System.Drawing.Size(301, 43)
        Me._Change.TabIndex = 35
        Me._Change.Text = "Change"
        Me._Change.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._Change.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me._Change.UseVisualStyleBackColor = True
        '
        'ChangePasscode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(635, 345)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ChangePasscode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Passcode"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents _Acc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents _Name As System.Windows.Forms.TextBox
    Friend WithEvents _Cancel As System.Windows.Forms.Button
    Friend WithEvents _Change As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents _btnDel As System.Windows.Forms.Button
    Friend WithEvents _btn7 As System.Windows.Forms.Button
    Friend WithEvents _btn9 As System.Windows.Forms.Button
    Friend WithEvents _btn0 As System.Windows.Forms.Button
    Friend WithEvents _btn8 As System.Windows.Forms.Button
    Friend WithEvents _btn6 As System.Windows.Forms.Button
    Friend WithEvents _btn5 As System.Windows.Forms.Button
    Friend WithEvents _btn4 As System.Windows.Forms.Button
    Friend WithEvents _btn3 As System.Windows.Forms.Button
    Friend WithEvents _btn2 As System.Windows.Forms.Button
    Friend WithEvents _btn1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents _Passcode As System.Windows.Forms.TextBox
    Friend WithEvents _message As System.Windows.Forms.Label
End Class
