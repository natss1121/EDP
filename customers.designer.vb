<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class customers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customers))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.customersidtxt = New System.Windows.Forms.TextBox()
        Me.fnametxt = New System.Windows.Forms.TextBox()
        Me.lnametxt = New System.Windows.Forms.TextBox()
        Me.emailtxt = New System.Windows.Forms.TextBox()
        Me.phonetxt = New System.Windows.Forms.TextBox()
        Me.searchbtn = New System.Windows.Forms.Button()
        Me.addrecordbtn = New System.Windows.Forms.Button()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.searchtxt = New System.Windows.Forms.TextBox()
        Me.listbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customers"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Customers ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Last Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 279)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Contact Number"
        '
        'customersidtxt
        '
        Me.customersidtxt.Location = New System.Drawing.Point(151, 115)
        Me.customersidtxt.Name = "customersidtxt"
        Me.customersidtxt.Size = New System.Drawing.Size(219, 20)
        Me.customersidtxt.TabIndex = 7
        '
        'fnametxt
        '
        Me.fnametxt.Location = New System.Drawing.Point(151, 156)
        Me.fnametxt.Name = "fnametxt"
        Me.fnametxt.Size = New System.Drawing.Size(219, 20)
        Me.fnametxt.TabIndex = 8
        '
        'lnametxt
        '
        Me.lnametxt.Location = New System.Drawing.Point(151, 196)
        Me.lnametxt.Name = "lnametxt"
        Me.lnametxt.Size = New System.Drawing.Size(219, 20)
        Me.lnametxt.TabIndex = 9
        '
        'emailtxt
        '
        Me.emailtxt.Location = New System.Drawing.Point(151, 233)
        Me.emailtxt.Name = "emailtxt"
        Me.emailtxt.Size = New System.Drawing.Size(219, 20)
        Me.emailtxt.TabIndex = 10
        '
        'phonetxt
        '
        Me.phonetxt.Location = New System.Drawing.Point(151, 276)
        Me.phonetxt.Name = "phonetxt"
        Me.phonetxt.Size = New System.Drawing.Size(219, 20)
        Me.phonetxt.TabIndex = 11
        '
        'searchbtn
        '
        Me.searchbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.searchbtn.Location = New System.Drawing.Point(295, 68)
        Me.searchbtn.Name = "searchbtn"
        Me.searchbtn.Size = New System.Drawing.Size(75, 23)
        Me.searchbtn.TabIndex = 12
        Me.searchbtn.Text = "Search"
        Me.searchbtn.UseVisualStyleBackColor = False
        '
        'addrecordbtn
        '
        Me.addrecordbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.addrecordbtn.Location = New System.Drawing.Point(52, 328)
        Me.addrecordbtn.Name = "addrecordbtn"
        Me.addrecordbtn.Size = New System.Drawing.Size(99, 29)
        Me.addrecordbtn.TabIndex = 13
        Me.addrecordbtn.Text = "Add Record"
        Me.addrecordbtn.UseVisualStyleBackColor = False
        '
        'updatebtn
        '
        Me.updatebtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.updatebtn.Location = New System.Drawing.Point(157, 328)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(99, 29)
        Me.updatebtn.TabIndex = 14
        Me.updatebtn.Text = "Update Record"
        Me.updatebtn.UseVisualStyleBackColor = False
        '
        'deletebtn
        '
        Me.deletebtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.deletebtn.Location = New System.Drawing.Point(262, 328)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(99, 29)
        Me.deletebtn.TabIndex = 15
        Me.deletebtn.Text = "Delete Record"
        Me.deletebtn.UseVisualStyleBackColor = False
        '
        'searchtxt
        '
        Me.searchtxt.Location = New System.Drawing.Point(151, 70)
        Me.searchtxt.Name = "searchtxt"
        Me.searchtxt.Size = New System.Drawing.Size(138, 20)
        Me.searchtxt.TabIndex = 16
        '
        'listbtn
        '
        Me.listbtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.listbtn.FlatAppearance.BorderSize = 0
        Me.listbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.listbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listbtn.Image = CType(resources.GetObject("listbtn.Image"), System.Drawing.Image)
        Me.listbtn.Location = New System.Drawing.Point(360, 12)
        Me.listbtn.Name = "listbtn"
        Me.listbtn.Size = New System.Drawing.Size(40, 29)
        Me.listbtn.TabIndex = 17
        Me.listbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.listbtn.UseVisualStyleBackColor = False
        '
        'customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(412, 420)
        Me.Controls.Add(Me.listbtn)
        Me.Controls.Add(Me.searchtxt)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.addrecordbtn)
        Me.Controls.Add(Me.searchbtn)
        Me.Controls.Add(Me.phonetxt)
        Me.Controls.Add(Me.emailtxt)
        Me.Controls.Add(Me.lnametxt)
        Me.Controls.Add(Me.fnametxt)
        Me.Controls.Add(Me.customersidtxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "customers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "customers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents customersidtxt As TextBox
    Friend WithEvents fnametxt As TextBox
    Friend WithEvents lnametxt As TextBox
    Friend WithEvents emailtxt As TextBox
    Friend WithEvents phonetxt As TextBox
    Friend WithEvents searchbtn As Button
    Friend WithEvents addrecordbtn As Button
    Friend WithEvents updatebtn As Button
    Friend WithEvents deletebtn As Button
    Friend WithEvents searchtxt As TextBox
    Friend WithEvents listbtn As Button
End Class
