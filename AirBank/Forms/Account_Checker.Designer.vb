<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Account_Checker
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Account_Checker))
        Me._Search = New System.Windows.Forms.TextBox()
        Me.Data = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me._SeachBtn = New System.Windows.Forms.Button()
        Me._Refresh = New System.Windows.Forms.Button()
        Me._Report = New System.Windows.Forms.Button()
        CType(Me.Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_Search
        '
        Me._Search.Location = New System.Drawing.Point(710, 12)
        Me._Search.Name = "_Search"
        Me._Search.Size = New System.Drawing.Size(282, 27)
        Me._Search.TabIndex = 0
        Me._Search.Text = "Search Name"
        Me._Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Data
        '
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Data.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Data.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Data.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Data.Location = New System.Drawing.Point(12, 49)
        Me.Data.MultiSelect = False
        Me.Data.Name = "Data"
        Me.Data.ReadOnly = True
        Me.Data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Data.ShowEditingIcon = False
        Me.Data.Size = New System.Drawing.Size(979, 378)
        Me.Data.TabIndex = 23
        Me.Data.TabStop = False
        '
        '_SeachBtn
        '
        Me._SeachBtn.FlatAppearance.BorderSize = 0
        Me._SeachBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._SeachBtn.Image = Global.AirBank.My.Resources.Resources.icons8_search_32px
        Me._SeachBtn.Location = New System.Drawing.Point(961, 13)
        Me._SeachBtn.Name = "_SeachBtn"
        Me._SeachBtn.Size = New System.Drawing.Size(30, 25)
        Me._SeachBtn.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me._SeachBtn, "Search")
        Me._SeachBtn.UseVisualStyleBackColor = True
        '
        '_Refresh
        '
        Me._Refresh.FlatAppearance.BorderSize = 0
        Me._Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Refresh.Image = Global.AirBank.My.Resources.Resources.icons8_update_32px
        Me._Refresh.Location = New System.Drawing.Point(589, 3)
        Me._Refresh.Name = "_Refresh"
        Me._Refresh.Size = New System.Drawing.Size(115, 43)
        Me._Refresh.TabIndex = 27
        Me._Refresh.Text = "Refresh"
        Me._Refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me._Refresh.UseVisualStyleBackColor = True
        '
        '_Report
        '
        Me._Report.FlatAppearance.BorderSize = 0
        Me._Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Report.Image = Global.AirBank.My.Resources.Resources.icons8_agreement
        Me._Report.Location = New System.Drawing.Point(452, 4)
        Me._Report.Name = "_Report"
        Me._Report.Size = New System.Drawing.Size(131, 43)
        Me._Report.TabIndex = 29
        Me._Report.Text = "View Report"
        Me._Report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me._Report.UseVisualStyleBackColor = True
        '
        'Account_Checker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1004, 435)
        Me.ControlBox = False
        Me.Controls.Add(Me._Report)
        Me.Controls.Add(Me._Refresh)
        Me.Controls.Add(Me.Data)
        Me.Controls.Add(Me._SeachBtn)
        Me.Controls.Add(Me._Search)
        Me.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Account_Checker"
        Me.Text = "Account_Checker"
        CType(Me.Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _Search As System.Windows.Forms.TextBox
    Friend WithEvents _SeachBtn As System.Windows.Forms.Button
    Friend WithEvents Data As System.Windows.Forms.DataGridView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents _Refresh As System.Windows.Forms.Button
    Friend WithEvents _Report As System.Windows.Forms.Button
End Class
