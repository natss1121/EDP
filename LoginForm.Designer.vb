<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.usernametxt = New System.Windows.Forms.TextBox()
        Me.passwordtxt = New System.Windows.Forms.TextBox()
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.cancelbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "LOGIN"
        '
        'usernametxt
        '
        Me.usernametxt.Location = New System.Drawing.Point(125, 77)
        Me.usernametxt.Name = "usernametxt"
        Me.usernametxt.Size = New System.Drawing.Size(172, 20)
        Me.usernametxt.TabIndex = 3
        '
        'passwordtxt
        '
        Me.passwordtxt.Location = New System.Drawing.Point(125, 113)
        Me.passwordtxt.Name = "passwordtxt"
        Me.passwordtxt.Size = New System.Drawing.Size(172, 20)
        Me.passwordtxt.TabIndex = 4
        '
        'loginbtn
        '
        Me.loginbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.loginbtn.Location = New System.Drawing.Point(102, 174)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(75, 23)
        Me.loginbtn.TabIndex = 5
        Me.loginbtn.Text = "Login"
        Me.loginbtn.UseVisualStyleBackColor = False
        '
        'cancelbtn
        '
        Me.cancelbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cancelbtn.Location = New System.Drawing.Point(183, 174)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(75, 23)
        Me.cancelbtn.TabIndex = 6
        Me.cancelbtn.Text = "Cancel"
        Me.cancelbtn.UseVisualStyleBackColor = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(360, 230)
        Me.Controls.Add(Me.cancelbtn)
        Me.Controls.Add(Me.loginbtn)
        Me.Controls.Add(Me.passwordtxt)
        Me.Controls.Add(Me.usernametxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN PAGE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents usernametxt As TextBox
    Friend WithEvents passwordtxt As TextBox
    Friend WithEvents loginbtn As Button
    Friend WithEvents cancelbtn As Button
End Class
