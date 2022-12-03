<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me._btnDel = New System.Windows.Forms.Button()
        Me._message = New System.Windows.Forms.Label()
        Me._btnEnter = New System.Windows.Forms.Button()
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
        Me._passcodeTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me._AccountID = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me._AccountID)
        Me.GroupBox1.Controls.Add(Me._btnDel)
        Me.GroupBox1.Controls.Add(Me._message)
        Me.GroupBox1.Controls.Add(Me._btnEnter)
        Me.GroupBox1.Controls.Add(Me._btn7)
        Me.GroupBox1.Controls.Add(Me._btn9)
        Me.GroupBox1.Controls.Add(Me._btn0)
        Me.GroupBox1.Controls.Add(Me._btn8)
        Me.GroupBox1.Controls.Add(Me._btn6)
        Me.GroupBox1.Controls.Add(Me._btn5)
        Me.GroupBox1.Controls.Add(Me._btn4)
        Me.GroupBox1.Controls.Add(Me._btn3)
        Me.GroupBox1.Controls.Add(Me._btn2)
        Me.GroupBox1.Controls.Add(Me._btn1)
        Me.GroupBox1.Controls.Add(Me._passcodeTxt)
        Me.GroupBox1.Location = New System.Drawing.Point(507, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(295, 392)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter your passcode"
        '
        '_btnDel
        '
        Me._btnDel.Location = New System.Drawing.Point(30, 316)
        Me._btnDel.Name = "_btnDel"
        Me._btnDel.Size = New System.Drawing.Size(75, 53)
        Me._btnDel.TabIndex = 13
        Me._btnDel.TabStop = False
        Me._btnDel.Text = "Del"
        Me._btnDel.UseVisualStyleBackColor = True
        '
        '_message
        '
        Me._message.AutoSize = True
        Me._message.ForeColor = System.Drawing.Color.Red
        Me._message.Location = New System.Drawing.Point(0, 373)
        Me._message.Name = "_message"
        Me._message.Padding = New System.Windows.Forms.Padding(50, 0, 50, 0)
        Me._message.Size = New System.Drawing.Size(169, 19)
        Me._message.TabIndex = 12
        Me._message.Text = "Message"
        Me._message.Visible = False
        '
        '_btnEnter
        '
        Me._btnEnter.Location = New System.Drawing.Point(192, 316)
        Me._btnEnter.Name = "_btnEnter"
        Me._btnEnter.Size = New System.Drawing.Size(75, 53)
        Me._btnEnter.TabIndex = 11
        Me._btnEnter.TabStop = False
        Me._btnEnter.Text = "Enter"
        Me._btnEnter.UseVisualStyleBackColor = True
        '
        '_btn7
        '
        Me._btn7.Location = New System.Drawing.Point(30, 139)
        Me._btn7.Name = "_btn7"
        Me._btn7.Size = New System.Drawing.Size(75, 53)
        Me._btn7.TabIndex = 7
        Me._btn7.TabStop = False
        Me._btn7.Text = "7"
        Me._btn7.UseVisualStyleBackColor = True
        '
        '_btn9
        '
        Me._btn9.Location = New System.Drawing.Point(192, 139)
        Me._btn9.Name = "_btn9"
        Me._btn9.Size = New System.Drawing.Size(75, 53)
        Me._btn9.TabIndex = 9
        Me._btn9.TabStop = False
        Me._btn9.Text = "9"
        Me._btn9.UseVisualStyleBackColor = True
        '
        '_btn0
        '
        Me._btn0.Location = New System.Drawing.Point(111, 316)
        Me._btn0.Name = "_btn0"
        Me._btn0.Size = New System.Drawing.Size(75, 53)
        Me._btn0.TabIndex = 10
        Me._btn0.TabStop = False
        Me._btn0.Text = "0"
        Me._btn0.UseVisualStyleBackColor = True
        '
        '_btn8
        '
        Me._btn8.Location = New System.Drawing.Point(111, 139)
        Me._btn8.Name = "_btn8"
        Me._btn8.Size = New System.Drawing.Size(75, 53)
        Me._btn8.TabIndex = 8
        Me._btn8.TabStop = False
        Me._btn8.Text = "8"
        Me._btn8.UseVisualStyleBackColor = True
        '
        '_btn6
        '
        Me._btn6.Location = New System.Drawing.Point(192, 198)
        Me._btn6.Name = "_btn6"
        Me._btn6.Size = New System.Drawing.Size(75, 53)
        Me._btn6.TabIndex = 6
        Me._btn6.TabStop = False
        Me._btn6.Text = "6"
        Me._btn6.UseVisualStyleBackColor = True
        '
        '_btn5
        '
        Me._btn5.Location = New System.Drawing.Point(111, 198)
        Me._btn5.Name = "_btn5"
        Me._btn5.Size = New System.Drawing.Size(75, 53)
        Me._btn5.TabIndex = 5
        Me._btn5.TabStop = False
        Me._btn5.Text = "5"
        Me._btn5.UseVisualStyleBackColor = True
        '
        '_btn4
        '
        Me._btn4.Location = New System.Drawing.Point(30, 198)
        Me._btn4.Name = "_btn4"
        Me._btn4.Size = New System.Drawing.Size(75, 53)
        Me._btn4.TabIndex = 4
        Me._btn4.TabStop = False
        Me._btn4.Text = "4"
        Me._btn4.UseVisualStyleBackColor = True
        '
        '_btn3
        '
        Me._btn3.Location = New System.Drawing.Point(192, 257)
        Me._btn3.Name = "_btn3"
        Me._btn3.Size = New System.Drawing.Size(75, 53)
        Me._btn3.TabIndex = 3
        Me._btn3.TabStop = False
        Me._btn3.Text = "3"
        Me._btn3.UseVisualStyleBackColor = True
        '
        '_btn2
        '
        Me._btn2.Location = New System.Drawing.Point(111, 257)
        Me._btn2.Name = "_btn2"
        Me._btn2.Size = New System.Drawing.Size(75, 53)
        Me._btn2.TabIndex = 2
        Me._btn2.TabStop = False
        Me._btn2.Text = "2"
        Me._btn2.UseVisualStyleBackColor = True
        '
        '_btn1
        '
        Me._btn1.Location = New System.Drawing.Point(30, 257)
        Me._btn1.Name = "_btn1"
        Me._btn1.Size = New System.Drawing.Size(75, 53)
        Me._btn1.TabIndex = 1
        Me._btn1.TabStop = False
        Me._btn1.Text = "1"
        Me._btn1.UseVisualStyleBackColor = True
        '
        '_passcodeTxt
        '
        Me._passcodeTxt.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._passcodeTxt.Font = New System.Drawing.Font("Candara Light", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._passcodeTxt.Location = New System.Drawing.Point(30, 58)
        Me._passcodeTxt.MaxLength = 6
        Me._passcodeTxt.Name = "_passcodeTxt"
        Me._passcodeTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me._passcodeTxt.ReadOnly = True
        Me._passcodeTxt.Size = New System.Drawing.Size(237, 66)
        Me._passcodeTxt.TabIndex = 0
        Me._passcodeTxt.TabStop = False
        Me._passcodeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara Light", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(187, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 33)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "WELCOME TO AIRBANK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara Light", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(23, 408)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 33)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Quick Step"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.AirBank.My.Resources.Resources.steps
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(12, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(489, 392)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        '_AccountID
        '
        Me._AccountID.Location = New System.Drawing.Point(30, 26)
        Me._AccountID.Name = "_AccountID"
        Me._AccountID.Size = New System.Drawing.Size(237, 27)
        Me._AccountID.TabIndex = 14
        Me._AccountID.TabStop = False
        Me._AccountID.Text = "Account ID"
        Me._AccountID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(814, 462)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Airbank Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents _passcodeTxt As System.Windows.Forms.TextBox
    Friend WithEvents _btnEnter As System.Windows.Forms.Button
    Friend WithEvents _btn0 As System.Windows.Forms.Button
    Friend WithEvents _btn9 As System.Windows.Forms.Button
    Friend WithEvents _btn8 As System.Windows.Forms.Button
    Friend WithEvents _btn7 As System.Windows.Forms.Button
    Friend WithEvents _btn6 As System.Windows.Forms.Button
    Friend WithEvents _btn5 As System.Windows.Forms.Button
    Friend WithEvents _btn4 As System.Windows.Forms.Button
    Friend WithEvents _btn2 As System.Windows.Forms.Button
    Friend WithEvents _btn1 As System.Windows.Forms.Button
    Friend WithEvents _btn3 As System.Windows.Forms.Button
    Friend WithEvents _message As System.Windows.Forms.Label
    Friend WithEvents _btnDel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents _AccountID As System.Windows.Forms.TextBox
End Class
