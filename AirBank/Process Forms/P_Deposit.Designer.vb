<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_Deposit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_Deposit))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me._Clear = New System.Windows.Forms.Button()
        Me._Cancel = New System.Windows.Forms.Button()
        Me._Deposit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me._tAmount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me._Amount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me._Acc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me._Name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._bal = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me._btnCheck = New System.Windows.Forms.Button()
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Panel1.Controls.Add(Me._Clear)
        Me.Panel1.Controls.Add(Me._Cancel)
        Me.Panel1.Controls.Add(Me._Deposit)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me._tAmount)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me._Amount)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me._Acc)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me._Name)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me._bal)
        Me.Panel1.Location = New System.Drawing.Point(6, 166)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(335, 512)
        Me.Panel1.TabIndex = 1
        '
        '_Clear
        '
        Me._Clear.FlatAppearance.BorderSize = 0
        Me._Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Clear.Image = Global.AirBank.My.Resources.Resources.icons8_clear_symbol_32px
        Me._Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._Clear.Location = New System.Drawing.Point(17, 453)
        Me._Clear.Name = "_Clear"
        Me._Clear.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me._Clear.Size = New System.Drawing.Size(301, 43)
        Me._Clear.TabIndex = 37
        Me._Clear.TabStop = False
        Me._Clear.Text = " Clear"
        Me._Clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me._Clear.UseVisualStyleBackColor = True
        '
        '_Cancel
        '
        Me._Cancel.FlatAppearance.BorderSize = 0
        Me._Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Cancel.Image = Global.AirBank.My.Resources.Resources.icons8_unavailable_32px
        Me._Cancel.Location = New System.Drawing.Point(17, 404)
        Me._Cancel.Name = "_Cancel"
        Me._Cancel.Size = New System.Drawing.Size(301, 43)
        Me._Cancel.TabIndex = 34
        Me._Cancel.TabStop = False
        Me._Cancel.Text = "Cancel"
        Me._Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me._Cancel.UseVisualStyleBackColor = True
        '
        '_Deposit
        '
        Me._Deposit.Enabled = False
        Me._Deposit.FlatAppearance.BorderSize = 0
        Me._Deposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Deposit.Image = Global.AirBank.My.Resources.Resources.icons8_ok_32px
        Me._Deposit.Location = New System.Drawing.Point(17, 355)
        Me._Deposit.Name = "_Deposit"
        Me._Deposit.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me._Deposit.Size = New System.Drawing.Size(301, 43)
        Me._Deposit.TabIndex = 33
        Me._Deposit.TabStop = False
        Me._Deposit.Text = "Deposit"
        Me._Deposit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._Deposit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me._Deposit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Candara Light", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(93, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 28)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Total Balance: "
        '
        '_tAmount
        '
        Me._tAmount.Font = New System.Drawing.Font("Candara Light", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tAmount.Location = New System.Drawing.Point(17, 309)
        Me._tAmount.Multiline = True
        Me._tAmount.Name = "_tAmount"
        Me._tAmount.ReadOnly = True
        Me._tAmount.Size = New System.Drawing.Size(301, 31)
        Me._tAmount.TabIndex = 31
        Me._tAmount.TabStop = False
        Me._tAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara Light", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(83, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 28)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Deposit Amount:"
        '
        '_Amount
        '
        Me._Amount.Font = New System.Drawing.Font("Candara Light", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Amount.Location = New System.Drawing.Point(17, 244)
        Me._Amount.Multiline = True
        Me._Amount.Name = "_Amount"
        Me._Amount.ReadOnly = True
        Me._Amount.Size = New System.Drawing.Size(301, 31)
        Me._Amount.TabIndex = 29
        Me._Amount.TabStop = False
        Me._Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Candara Light", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(71, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(188, 28)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Account Number#"
        '
        '_Acc
        '
        Me._Acc.Font = New System.Drawing.Font("Candara Light", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Acc.Location = New System.Drawing.Point(17, 114)
        Me._Acc.Multiline = True
        Me._Acc.Name = "_Acc"
        Me._Acc.ReadOnly = True
        Me._Acc.Size = New System.Drawing.Size(301, 31)
        Me._Acc.TabIndex = 27
        Me._Acc.TabStop = False
        Me._Acc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara Light", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(121, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 28)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Name:"
        '
        '_Name
        '
        Me._Name.Font = New System.Drawing.Font("Candara Light", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Name.Location = New System.Drawing.Point(17, 49)
        Me._Name.Multiline = True
        Me._Name.Name = "_Name"
        Me._Name.ReadOnly = True
        Me._Name.Size = New System.Drawing.Size(301, 31)
        Me._Name.TabIndex = 25
        Me._Name.TabStop = False
        Me._Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara Light", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(121, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 28)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Balance: "
        '
        '_bal
        '
        Me._bal.Font = New System.Drawing.Font("Candara Light", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._bal.Location = New System.Drawing.Point(17, 179)
        Me._bal.Multiline = True
        Me._bal.Name = "_bal"
        Me._bal.ReadOnly = True
        Me._bal.Size = New System.Drawing.Size(301, 31)
        Me._bal.TabIndex = 23
        Me._bal.TabStop = False
        Me._bal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(347, 684)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Deposit"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.AirBank.My.Resources.Resources.icons8_deposit_96px1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(6, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(335, 134)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me._btnCheck)
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
        Me.GroupBox2.Location = New System.Drawing.Point(366, 397)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(292, 298)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Enter Deposit Amount"
        '
        '_btnCheck
        '
        Me._btnCheck.Location = New System.Drawing.Point(194, 223)
        Me._btnCheck.Name = "_btnCheck"
        Me._btnCheck.Size = New System.Drawing.Size(75, 53)
        Me._btnCheck.TabIndex = 14
        Me._btnCheck.TabStop = False
        Me._btnCheck.Text = "Check"
        Me._btnCheck.UseVisualStyleBackColor = True
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(366, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(290, 376)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Latest Update"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(6, 26)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(278, 344)
        Me.TextBox5.TabIndex = 0
        Me.TextBox5.TabStop = False
        Me.TextBox5.Text = "[READ CAREFULLY]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- We will maintenace on " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   June 1, 2021. It takes " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   two " & _
            "hours to server " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   open."
        '
        'P_Deposit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(665, 707)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "P_Deposit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deposit"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _Deposit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents _tAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents _Amount As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents _Acc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents _Name As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents _bal As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents _Cancel As System.Windows.Forms.Button
    Friend WithEvents _Clear As System.Windows.Forms.Button
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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents _btnCheck As System.Windows.Forms.Button
End Class
