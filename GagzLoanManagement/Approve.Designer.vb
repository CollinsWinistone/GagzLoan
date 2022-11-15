<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Approve
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.loanId = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.approveBtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Approve Loans"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(471, 33)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(605, 463)
        Me.DataGridView1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Choose which loans to approve"
        '
        'loanId
        '
        Me.loanId.FormattingEnabled = True
        Me.loanId.Location = New System.Drawing.Point(167, 154)
        Me.loanId.Name = "loanId"
        Me.loanId.Size = New System.Drawing.Size(182, 33)
        Me.loanId.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "loanId"
        '
        'approveBtn
        '
        Me.approveBtn.Location = New System.Drawing.Point(203, 256)
        Me.approveBtn.Name = "approveBtn"
        Me.approveBtn.Size = New System.Drawing.Size(112, 34)
        Me.approveBtn.TabIndex = 5
        Me.approveBtn.Text = "Approve"
        Me.approveBtn.UseVisualStyleBackColor = True
        '
        'Approve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 528)
        Me.Controls.Add(Me.approveBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.loanId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Approve"
        Me.Text = "Approve"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents loanId As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents approveBtn As Button
End Class
