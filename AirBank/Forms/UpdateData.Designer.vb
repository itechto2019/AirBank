<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateData))
        Me.Label1 = New System.Windows.Forms.Label()
        Me._Firstname = New System.Windows.Forms.TextBox()
        Me._Lastname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me._Middle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me._Search = New System.Windows.Forms.TextBox()
        Me._ID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me._SeachBtn = New System.Windows.Forms.Button()
        Me._Save = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(438, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Firstname: "
        '
        '_Firstname
        '
        Me._Firstname.Location = New System.Drawing.Point(527, 212)
        Me._Firstname.Name = "_Firstname"
        Me._Firstname.Size = New System.Drawing.Size(232, 27)
        Me._Firstname.TabIndex = 1
        Me._Firstname.TabStop = False
        '
        '_Lastname
        '
        Me._Lastname.Location = New System.Drawing.Point(527, 245)
        Me._Lastname.Name = "_Lastname"
        Me._Lastname.Size = New System.Drawing.Size(232, 27)
        Me._Lastname.TabIndex = 3
        Me._Lastname.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(438, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Lastname: "
        '
        '_Middle
        '
        Me._Middle.Location = New System.Drawing.Point(527, 278)
        Me._Middle.Name = "_Middle"
        Me._Middle.Size = New System.Drawing.Size(232, 27)
        Me._Middle.TabIndex = 5
        Me._Middle.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(438, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Middle: "
        '
        '_Search
        '
        Me._Search.Location = New System.Drawing.Point(638, 136)
        Me._Search.Name = "_Search"
        Me._Search.Size = New System.Drawing.Size(251, 27)
        Me._Search.TabIndex = 26
        Me._Search.TabStop = False
        Me._Search.Text = "Search ID"
        Me._Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_ID
        '
        Me._ID.Enabled = False
        Me._ID.Location = New System.Drawing.Point(527, 179)
        Me._ID.Name = "_ID"
        Me._ID.Size = New System.Drawing.Size(232, 27)
        Me._ID.TabIndex = 30
        Me._ID.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(438, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 19)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "AccountID: "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(259, 435)
        Me.Panel1.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Candara", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(4, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(252, 57)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "This page is for updating only," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "not visible to all users. Except admin" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "that wil" & _
            "l manage the Database."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Candara Light", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(12, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(222, 66)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "AirBank Updating" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Form"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Candara", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(265, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(239, 95)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "This is the updating form," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "if something encountered error" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in an account, please" & _
            ", contact the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Developer to fix it. Thank for your " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "support AirBank Inc."
        '
        '_SeachBtn
        '
        Me._SeachBtn.FlatAppearance.BorderSize = 0
        Me._SeachBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._SeachBtn.Image = Global.AirBank.My.Resources.Resources.icons8_search_32px
        Me._SeachBtn.Location = New System.Drawing.Point(858, 137)
        Me._SeachBtn.Name = "_SeachBtn"
        Me._SeachBtn.Size = New System.Drawing.Size(30, 25)
        Me._SeachBtn.TabIndex = 27
        Me._SeachBtn.TabStop = False
        Me._SeachBtn.UseVisualStyleBackColor = True
        '
        '_Save
        '
        Me._Save.Enabled = False
        Me._Save.FlatAppearance.BorderSize = 0
        Me._Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Save.Image = Global.AirBank.My.Resources.Resources.icons8_save_32px_1
        Me._Save.Location = New System.Drawing.Point(711, 311)
        Me._Save.Name = "_Save"
        Me._Save.Size = New System.Drawing.Size(48, 39)
        Me._Save.TabIndex = 25
        Me._Save.TabStop = False
        Me._Save.UseVisualStyleBackColor = True
        '
        'UpdateData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1004, 435)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me._ID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me._SeachBtn)
        Me.Controls.Add(Me._Search)
        Me.Controls.Add(Me._Save)
        Me.Controls.Add(Me._Middle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me._Lastname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me._Firstname)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UpdateData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UpdateData"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents _Firstname As System.Windows.Forms.TextBox
    Friend WithEvents _Lastname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents _Middle As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents _Save As System.Windows.Forms.Button
    Friend WithEvents _SeachBtn As System.Windows.Forms.Button
    Friend WithEvents _Search As System.Windows.Forms.TextBox
    Friend WithEvents _ID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
