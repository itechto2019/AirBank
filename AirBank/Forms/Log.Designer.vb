<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Log
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
        Me._DataLog = New System.Windows.Forms.DataGridView()
        Me._Clear = New System.Windows.Forms.Button()
        Me._Refresh = New System.Windows.Forms.Button()
        CType(Me._DataLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_DataLog
        '
        Me._DataLog.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me._DataLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me._DataLog.Location = New System.Drawing.Point(12, 49)
        Me._DataLog.Name = "_DataLog"
        Me._DataLog.ReadOnly = True
        Me._DataLog.Size = New System.Drawing.Size(980, 382)
        Me._DataLog.TabIndex = 1
        '
        '_Clear
        '
        Me._Clear.FlatAppearance.BorderSize = 0
        Me._Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Clear.Image = Global.AirBank.My.Resources.Resources.delete_all
        Me._Clear.Location = New System.Drawing.Point(664, 0)
        Me._Clear.Name = "_Clear"
        Me._Clear.Size = New System.Drawing.Size(161, 43)
        Me._Clear.TabIndex = 27
        Me._Clear.Text = "Clear"
        Me._Clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me._Clear.UseVisualStyleBackColor = True
        '
        '_Refresh
        '
        Me._Refresh.FlatAppearance.BorderSize = 0
        Me._Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Refresh.Image = Global.AirBank.My.Resources.Resources.icons8_update_32px
        Me._Refresh.Location = New System.Drawing.Point(831, 0)
        Me._Refresh.Name = "_Refresh"
        Me._Refresh.Size = New System.Drawing.Size(161, 43)
        Me._Refresh.TabIndex = 26
        Me._Refresh.Text = "Refresh"
        Me._Refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me._Refresh.UseVisualStyleBackColor = True
        '
        'Log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1004, 435)
        Me.Controls.Add(Me._Clear)
        Me.Controls.Add(Me._Refresh)
        Me.Controls.Add(Me._DataLog)
        Me.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Log"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log"
        CType(Me._DataLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _DataLog As System.Windows.Forms.DataGridView
    Friend WithEvents _Refresh As System.Windows.Forms.Button
    Friend WithEvents _Clear As System.Windows.Forms.Button
End Class
