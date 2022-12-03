<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accounts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accounts))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MyTime = New System.Windows.Forms.Label()
        Me.myDate = New System.Windows.Forms.Label()
        Me._AdminMode = New System.Windows.Forms.Button()
        Me._Usermode = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(700, 70)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara Light", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(116, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 33)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "WELCOME TO AIRBANK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara Light", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(264, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 36)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Select user"
        '
        'MyTime
        '
        Me.MyTime.AutoSize = True
        Me.MyTime.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyTime.ForeColor = System.Drawing.SystemColors.Control
        Me.MyTime.Location = New System.Drawing.Point(610, 361)
        Me.MyTime.Name = "MyTime"
        Me.MyTime.Size = New System.Drawing.Size(41, 19)
        Me.MyTime.TabIndex = 42
        Me.MyTime.Text = "Time"
        '
        'myDate
        '
        Me.myDate.AutoSize = True
        Me.myDate.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.myDate.ForeColor = System.Drawing.SystemColors.Control
        Me.myDate.Location = New System.Drawing.Point(528, 361)
        Me.myDate.Name = "myDate"
        Me.myDate.Size = New System.Drawing.Size(41, 19)
        Me.myDate.TabIndex = 41
        Me.myDate.Text = "Date"
        '
        '_AdminMode
        '
        Me._AdminMode.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(210, Byte), Integer))
        Me._AdminMode.FlatAppearance.BorderSize = 0
        Me._AdminMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._AdminMode.ForeColor = System.Drawing.SystemColors.Control
        Me._AdminMode.Image = Global.AirBank.My.Resources.Resources.icons8_administrative_tools_32px_1
        Me._AdminMode.Location = New System.Drawing.Point(126, 160)
        Me._AdminMode.Name = "_AdminMode"
        Me._AdminMode.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me._AdminMode.Size = New System.Drawing.Size(420, 43)
        Me._AdminMode.TabIndex = 39
        Me._AdminMode.TabStop = False
        Me._AdminMode.Text = "Admin"
        Me._AdminMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._AdminMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me._AdminMode.UseVisualStyleBackColor = False
        '
        '_Usermode
        '
        Me._Usermode.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(210, Byte), Integer))
        Me._Usermode.FlatAppearance.BorderSize = 0
        Me._Usermode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Usermode.ForeColor = System.Drawing.SystemColors.Control
        Me._Usermode.Image = Global.AirBank.My.Resources.Resources.icons8_user_32px
        Me._Usermode.Location = New System.Drawing.Point(126, 209)
        Me._Usermode.Name = "_Usermode"
        Me._Usermode.Size = New System.Drawing.Size(420, 43)
        Me._Usermode.TabIndex = 38
        Me._Usermode.TabStop = False
        Me._Usermode.Text = "User"
        Me._Usermode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._Usermode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me._Usermode.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.AirBank.My.Resources.Resources.icons8_bank_building_48px
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 63)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Accounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 389)
        Me.Controls.Add(Me.MyTime)
        Me.Controls.Add(Me.myDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me._AdminMode)
        Me.Controls.Add(Me._Usermode)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Accounts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents _Usermode As System.Windows.Forms.Button
    Friend WithEvents _AdminMode As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MyTime As System.Windows.Forms.Label
    Friend WithEvents myDate As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
