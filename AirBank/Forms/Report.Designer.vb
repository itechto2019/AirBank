<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me._Exit = New System.Windows.Forms.Button()
        Me._ViewData = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.myreport1 = New AirBank.myreport()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Panel1.Controls.Add(Me._Exit)
        Me.Panel1.Controls.Add(Me._ViewData)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1256, 58)
        Me.Panel1.TabIndex = 2
        '
        '_Exit
        '
        Me._Exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._Exit.FlatAppearance.BorderSize = 0
        Me._Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Exit.Image = Global.AirBank.My.Resources.Resources.icons8_shutdown_32px
        Me._Exit.Location = New System.Drawing.Point(1029, 8)
        Me._Exit.Name = "_Exit"
        Me._Exit.Size = New System.Drawing.Size(88, 43)
        Me._Exit.TabIndex = 29
        Me._Exit.Text = "Exit"
        Me._Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me._Exit.UseVisualStyleBackColor = True
        '
        '_ViewData
        '
        Me._ViewData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._ViewData.FlatAppearance.BorderSize = 0
        Me._ViewData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._ViewData.Image = Global.AirBank.My.Resources.Resources.icons8_update_32px
        Me._ViewData.Location = New System.Drawing.Point(1123, 8)
        Me._ViewData.Name = "_ViewData"
        Me._ViewData.Size = New System.Drawing.Size(120, 43)
        Me._ViewData.TabIndex = 28
        Me._ViewData.Text = "View Data"
        Me._ViewData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me._ViewData.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara Light", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AirBank Crystal Report"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 58)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.myreport1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1256, 428)
        Me.CrystalReportViewer1.TabIndex = 3
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1256, 486)
        Me.ControlBox = False
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Report"
        Me.Text = "My Report"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents _Exit As System.Windows.Forms.Button
    Friend WithEvents _ViewData As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents myreport1 As AirBank.myreport
End Class
