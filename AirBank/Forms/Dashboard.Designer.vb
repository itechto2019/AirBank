<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._Header = New System.Windows.Forms.Panel()
        Me.MyTime = New System.Windows.Forms.Label()
        Me.myDate = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me._Aside = New System.Windows.Forms.Panel()
        Me._Logout = New System.Windows.Forms.Button()
        Me._Update = New System.Windows.Forms.Button()
        Me._AddEntry = New System.Windows.Forms.Button()
        Me._Log = New System.Windows.Forms.Button()
        Me._AccountCheck = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me._Footer = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._Main = New System.Windows.Forms.Panel()
        Me.Time = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me._Header.SuspendLayout()
        Me._Aside.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._Footer.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1212, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HelpToolStripMenuItem.Text = "About"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.AboutToolStripMenuItem.Text = "About Airbank"
        '
        '_Header
        '
        Me._Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(211, Byte), Integer))
        Me._Header.Controls.Add(Me.MyTime)
        Me._Header.Controls.Add(Me.myDate)
        Me._Header.Controls.Add(Me.Label5)
        Me._Header.Dock = System.Windows.Forms.DockStyle.Top
        Me._Header.Location = New System.Drawing.Point(200, 24)
        Me._Header.Name = "_Header"
        Me._Header.Size = New System.Drawing.Size(1012, 61)
        Me._Header.TabIndex = 2
        '
        'MyTime
        '
        Me.MyTime.AutoSize = True
        Me.MyTime.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyTime.ForeColor = System.Drawing.SystemColors.Control
        Me.MyTime.Location = New System.Drawing.Point(934, 27)
        Me.MyTime.Name = "MyTime"
        Me.MyTime.Size = New System.Drawing.Size(41, 19)
        Me.MyTime.TabIndex = 35
        Me.MyTime.Text = "Time"
        '
        'myDate
        '
        Me.myDate.AutoSize = True
        Me.myDate.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.myDate.ForeColor = System.Drawing.SystemColors.Control
        Me.myDate.Location = New System.Drawing.Point(852, 27)
        Me.myDate.Name = "myDate"
        Me.myDate.Size = New System.Drawing.Size(41, 19)
        Me.myDate.TabIndex = 34
        Me.myDate.Text = "Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Candara Light", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(353, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(304, 33)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "WELCOME TO AIRBANK"
        '
        '_Aside
        '
        Me._Aside.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._Aside.Controls.Add(Me._Logout)
        Me._Aside.Controls.Add(Me._Update)
        Me._Aside.Controls.Add(Me._AddEntry)
        Me._Aside.Controls.Add(Me._Log)
        Me._Aside.Controls.Add(Me._AccountCheck)
        Me._Aside.Controls.Add(Me.PictureBox1)
        Me._Aside.Dock = System.Windows.Forms.DockStyle.Left
        Me._Aside.Location = New System.Drawing.Point(0, 24)
        Me._Aside.Name = "_Aside"
        Me._Aside.Size = New System.Drawing.Size(200, 524)
        Me._Aside.TabIndex = 1
        '
        '_Logout
        '
        Me._Logout.Dock = System.Windows.Forms.DockStyle.Top
        Me._Logout.FlatAppearance.BorderSize = 0
        Me._Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Logout.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Logout.ForeColor = System.Drawing.SystemColors.Control
        Me._Logout.Image = Global.AirBank.My.Resources.Resources.icons8_shutdown_32px
        Me._Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Logout.Location = New System.Drawing.Point(0, 331)
        Me._Logout.Name = "_Logout"
        Me._Logout.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me._Logout.Size = New System.Drawing.Size(200, 48)
        Me._Logout.TabIndex = 7
        Me._Logout.TabStop = False
        Me._Logout.Text = "Logout"
        Me._Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me._Logout.UseVisualStyleBackColor = True
        '
        '_Update
        '
        Me._Update.Dock = System.Windows.Forms.DockStyle.Top
        Me._Update.FlatAppearance.BorderSize = 0
        Me._Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Update.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Update.ForeColor = System.Drawing.SystemColors.Control
        Me._Update.Image = Global.AirBank.My.Resources.Resources.icons8_update_32px
        Me._Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Update.Location = New System.Drawing.Point(0, 283)
        Me._Update.Name = "_Update"
        Me._Update.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me._Update.Size = New System.Drawing.Size(200, 48)
        Me._Update.TabIndex = 6
        Me._Update.TabStop = False
        Me._Update.Text = "Update Center"
        Me._Update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me._Update.UseVisualStyleBackColor = True
        '
        '_AddEntry
        '
        Me._AddEntry.Dock = System.Windows.Forms.DockStyle.Top
        Me._AddEntry.FlatAppearance.BorderSize = 0
        Me._AddEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._AddEntry.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._AddEntry.ForeColor = System.Drawing.SystemColors.Control
        Me._AddEntry.Image = Global.AirBank.My.Resources.Resources.icons8_plus_32px
        Me._AddEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._AddEntry.Location = New System.Drawing.Point(0, 235)
        Me._AddEntry.Name = "_AddEntry"
        Me._AddEntry.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me._AddEntry.Size = New System.Drawing.Size(200, 48)
        Me._AddEntry.TabIndex = 5
        Me._AddEntry.TabStop = False
        Me._AddEntry.Text = "Add Account"
        Me._AddEntry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me._AddEntry.UseVisualStyleBackColor = True
        '
        '_Log
        '
        Me._Log.Dock = System.Windows.Forms.DockStyle.Top
        Me._Log.FlatAppearance.BorderSize = 0
        Me._Log.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Log.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Log.ForeColor = System.Drawing.SystemColors.Control
        Me._Log.Image = Global.AirBank.My.Resources.Resources.icons8_time_machine_32px
        Me._Log.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Log.Location = New System.Drawing.Point(0, 187)
        Me._Log.Name = "_Log"
        Me._Log.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me._Log.Size = New System.Drawing.Size(200, 48)
        Me._Log.TabIndex = 4
        Me._Log.TabStop = False
        Me._Log.Text = "Log"
        Me._Log.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me._Log.UseVisualStyleBackColor = True
        '
        '_AccountCheck
        '
        Me._AccountCheck.Dock = System.Windows.Forms.DockStyle.Top
        Me._AccountCheck.FlatAppearance.BorderSize = 0
        Me._AccountCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._AccountCheck.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._AccountCheck.ForeColor = System.Drawing.SystemColors.Control
        Me._AccountCheck.Image = Global.AirBank.My.Resources.Resources.icons8_verified_account_32px
        Me._AccountCheck.Location = New System.Drawing.Point(0, 139)
        Me._AccountCheck.Name = "_AccountCheck"
        Me._AccountCheck.Size = New System.Drawing.Size(200, 48)
        Me._AccountCheck.TabIndex = 1
        Me._AccountCheck.TabStop = False
        Me._AccountCheck.Text = "Account Checker"
        Me._AccountCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me._AccountCheck.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.AirBank.My.Resources.Resources.icons8_money_bag_96px
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 139)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        '_Footer
        '
        Me._Footer.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(211, Byte), Integer))
        Me._Footer.Controls.Add(Me.Label1)
        Me._Footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._Footer.Location = New System.Drawing.Point(200, 520)
        Me._Footer.Name = "_Footer"
        Me._Footer.Size = New System.Drawing.Size(1012, 28)
        Me._Footer.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(250, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(572, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Copyright 2021 | AirBank Company | By Rapsing"
        Me.Label1.UseMnemonic = False
        '
        '_Main
        '
        Me._Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me._Main.Location = New System.Drawing.Point(200, 85)
        Me._Main.Name = "_Main"
        Me._Main.Size = New System.Drawing.Size(1012, 435)
        Me._Main.TabIndex = 4
        '
        'Time
        '
        Me.Time.Enabled = True
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1212, 548)
        Me.ControlBox = False
        Me.Controls.Add(Me._Main)
        Me.Controls.Add(Me._Footer)
        Me.Controls.Add(Me._Header)
        Me.Controls.Add(Me._Aside)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me._Header.ResumeLayout(False)
        Me._Header.PerformLayout()
        Me._Aside.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me._Footer.ResumeLayout(False)
        Me._Footer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents _Header As System.Windows.Forms.Panel
    Friend WithEvents _Aside As System.Windows.Forms.Panel
    Friend WithEvents _Footer As System.Windows.Forms.Panel
    Friend WithEvents _Main As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents _Log As System.Windows.Forms.Button
    Friend WithEvents _AccountCheck As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _AddEntry As System.Windows.Forms.Button
    Friend WithEvents _Update As System.Windows.Forms.Button
    Friend WithEvents _Logout As System.Windows.Forms.Button
    Friend WithEvents MyTime As System.Windows.Forms.Label
    Friend WithEvents myDate As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Time As System.Windows.Forms.Timer
End Class
