<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.loginRole = New System.Windows.Forms.ComboBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(216, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GAGZ LOAN MANAGEMENT SYSTEM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(324, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Login"
        '
        'loginRole
        '
        Me.loginRole.FormattingEnabled = True
        Me.loginRole.Location = New System.Drawing.Point(280, 127)
        Me.loginRole.Name = "loginRole"
        Me.loginRole.Size = New System.Drawing.Size(182, 33)
        Me.loginRole.TabIndex = 2
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(280, 189)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(182, 31)
        Me.username.TabIndex = 3
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(280, 253)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(182, 31)
        Me.password.TabIndex = 4
        '
        'loginBtn
        '
        Me.loginBtn.Location = New System.Drawing.Point(324, 331)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(112, 34)
        Me.loginBtn.TabIndex = 5
        Me.loginBtn.Text = "Login"
        Me.loginBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(159, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Role"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(159, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "username"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(159, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "password"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.loginRole)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents loginRole As ComboBox
    Friend WithEvents username As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents loginBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
