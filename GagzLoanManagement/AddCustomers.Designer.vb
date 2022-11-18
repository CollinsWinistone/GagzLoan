<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCustomers
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
        Me.username = New System.Windows.Forms.TextBox()
        Me.phone = New System.Windows.Forms.TextBox()
        Me.custLocation = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.loan_amount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.occupation = New System.Windows.Forms.TextBox()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.custId = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(203, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add New Customer to Gagz"
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(260, 82)
        Me.username.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(121, 27)
        Me.username.TabIndex = 1
        '
        'phone
        '
        Me.phone.Location = New System.Drawing.Point(260, 115)
        Me.phone.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(121, 27)
        Me.phone.TabIndex = 2
        '
        'custLocation
        '
        Me.custLocation.Location = New System.Drawing.Point(260, 156)
        Me.custLocation.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.custLocation.Name = "custLocation"
        Me.custLocation.Size = New System.Drawing.Size(121, 27)
        Me.custLocation.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(183, 83)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(183, 115)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "phone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(163, 156)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "userLocation"
        '
        'loan_amount
        '
        Me.loan_amount.Location = New System.Drawing.Point(262, 201)
        Me.loan_amount.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.loan_amount.Name = "loan_amount"
        Me.loan_amount.Size = New System.Drawing.Size(121, 27)
        Me.loan_amount.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(153, 201)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "loan amount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(163, 249)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "occupation"
        '
        'occupation
        '
        Me.occupation.Location = New System.Drawing.Point(263, 244)
        Me.occupation.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.occupation.Name = "occupation"
        Me.occupation.Size = New System.Drawing.Size(121, 27)
        Me.occupation.TabIndex = 10
        '
        'addBtn
        '
        Me.addBtn.Location = New System.Drawing.Point(266, 298)
        Me.addBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(90, 27)
        Me.addBtn.TabIndex = 11
        Me.addBtn.Text = "Add Customer"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'custId
        '
        Me.custId.Location = New System.Drawing.Point(262, 48)
        Me.custId.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.custId.Name = "custId"
        Me.custId.Size = New System.Drawing.Size(121, 27)
        Me.custId.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(202, 43)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "ID"
        '
        'AddCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 399)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.custId)
        Me.Controls.Add(Me.addBtn)
        Me.Controls.Add(Me.occupation)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.loan_amount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.custLocation)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "AddCustomers"
        Me.Text = "AddCustomers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents username As TextBox
    Friend WithEvents phone As TextBox
    Friend WithEvents custLocation As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents loan_amount As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents occupation As TextBox
    Friend WithEvents addBtn As Button
    Friend WithEvents custId As TextBox
    Friend WithEvents Label7 As Label
End Class
