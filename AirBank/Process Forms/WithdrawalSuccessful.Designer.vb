<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WithdrawalSuccessful
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WithdrawalSuccessful))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me._Time = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me._Date = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me._ID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me._TotalAmount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me._WithdrawAmount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me._Name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._OK = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me._Time)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me._Date)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me._ID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me._OK)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me._TotalAmount)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me._WithdrawAmount)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me._Name)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(351, 519)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Withdrawal Successful"
        '
        '_Time
        '
        Me._Time.Enabled = False
        Me._Time.Location = New System.Drawing.Point(112, 437)
        Me._Time.Name = "_Time"
        Me._Time.Size = New System.Drawing.Size(233, 27)
        Me._Time.TabIndex = 44
        Me._Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 440)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 19)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Time: "
        '
        '_Date
        '
        Me._Date.Enabled = False
        Me._Date.Location = New System.Drawing.Point(112, 404)
        Me._Date.Name = "_Date"
        Me._Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._Date.Size = New System.Drawing.Size(233, 27)
        Me._Date.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 407)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 19)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Date: "
        '
        '_ID
        '
        Me._ID.Enabled = False
        Me._ID.Location = New System.Drawing.Point(112, 305)
        Me._ID.Name = "_ID"
        Me._ID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._ID.Size = New System.Drawing.Size(233, 27)
        Me._ID.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 308)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 19)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Account #:  "
        '
        '_TotalAmount
        '
        Me._TotalAmount.Enabled = False
        Me._TotalAmount.Location = New System.Drawing.Point(112, 371)
        Me._TotalAmount.Name = "_TotalAmount"
        Me._TotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._TotalAmount.Size = New System.Drawing.Size(233, 27)
        Me._TotalAmount.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 374)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total Balance:  "
        '
        '_WithdrawAmount
        '
        Me._WithdrawAmount.Enabled = False
        Me._WithdrawAmount.Location = New System.Drawing.Point(112, 338)
        Me._WithdrawAmount.Name = "_WithdrawAmount"
        Me._WithdrawAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._WithdrawAmount.Size = New System.Drawing.Size(233, 27)
        Me._WithdrawAmount.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 333)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 38)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Amount " & Global.Microsoft.VisualBasic.ChrW(13) & "Withdraw: "
        '
        '_Name
        '
        Me._Name.Enabled = False
        Me._Name.Location = New System.Drawing.Point(112, 272)
        Me._Name.Name = "_Name"
        Me._Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._Name.Size = New System.Drawing.Size(233, 27)
        Me._Name.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 275)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name: "
        '
        '_OK
        '
        Me._OK.FlatAppearance.BorderSize = 0
        Me._OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._OK.Image = Global.AirBank.My.Resources.Resources.icons8_ok_32px
        Me._OK.Location = New System.Drawing.Point(10, 470)
        Me._OK.Name = "_OK"
        Me._OK.Padding = New System.Windows.Forms.Padding(10, 0, 5, 0)
        Me._OK.Size = New System.Drawing.Size(335, 43)
        Me._OK.TabIndex = 34
        Me._OK.Text = "OK"
        Me._OK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me._OK.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.AirBank.My.Resources.Resources.withdraw
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(10, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(335, 236)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'WithdrawalSuccessful
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(376, 544)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "WithdrawalSuccessful"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Successful"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents _TotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents _WithdrawAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents _Name As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents _ID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents _OK As System.Windows.Forms.Button
    Friend WithEvents _Time As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents _Date As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
