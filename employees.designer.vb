<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class employees
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(employees))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.empidtxt = New System.Windows.Forms.TextBox()
        Me.firstnametxt = New System.Windows.Forms.TextBox()
        Me.lastnametxt = New System.Windows.Forms.TextBox()
        Me.emailtxt = New System.Windows.Forms.TextBox()
        Me.phonetxt = New System.Windows.Forms.TextBox()
        Me.depnametxt = New System.Windows.Forms.TextBox()
        Me.searchbtn = New System.Windows.Forms.Button()
        Me.searchtxt = New System.Windows.Forms.TextBox()
        Me.addrecordbtn = New System.Windows.Forms.Button()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.listbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employees"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Employee ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Last Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Contact Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 290)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Department Name"
        '
        'empidtxt
        '
        Me.empidtxt.Location = New System.Drawing.Point(154, 120)
        Me.empidtxt.Name = "empidtxt"
        Me.empidtxt.Size = New System.Drawing.Size(202, 20)
        Me.empidtxt.TabIndex = 8
        '
        'firstnametxt
        '
        Me.firstnametxt.Location = New System.Drawing.Point(154, 153)
        Me.firstnametxt.Name = "firstnametxt"
        Me.firstnametxt.Size = New System.Drawing.Size(202, 20)
        Me.firstnametxt.TabIndex = 9
        '
        'lastnametxt
        '
        Me.lastnametxt.Location = New System.Drawing.Point(154, 185)
        Me.lastnametxt.Name = "lastnametxt"
        Me.lastnametxt.Size = New System.Drawing.Size(202, 20)
        Me.lastnametxt.TabIndex = 10
        '
        'emailtxt
        '
        Me.emailtxt.Location = New System.Drawing.Point(154, 219)
        Me.emailtxt.Name = "emailtxt"
        Me.emailtxt.Size = New System.Drawing.Size(202, 20)
        Me.emailtxt.TabIndex = 11
        '
        'phonetxt
        '
        Me.phonetxt.Location = New System.Drawing.Point(154, 253)
        Me.phonetxt.Name = "phonetxt"
        Me.phonetxt.Size = New System.Drawing.Size(202, 20)
        Me.phonetxt.TabIndex = 12
        '
        'depnametxt
        '
        Me.depnametxt.Location = New System.Drawing.Point(154, 287)
        Me.depnametxt.Name = "depnametxt"
        Me.depnametxt.Size = New System.Drawing.Size(202, 20)
        Me.depnametxt.TabIndex = 13
        '
        'searchbtn
        '
        Me.searchbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.searchbtn.Location = New System.Drawing.Point(295, 75)
        Me.searchbtn.Name = "searchbtn"
        Me.searchbtn.Size = New System.Drawing.Size(61, 23)
        Me.searchbtn.TabIndex = 14
        Me.searchbtn.Text = "Search"
        Me.searchbtn.UseVisualStyleBackColor = False
        '
        'searchtxt
        '
        Me.searchtxt.Location = New System.Drawing.Point(154, 77)
        Me.searchtxt.Name = "searchtxt"
        Me.searchtxt.Size = New System.Drawing.Size(135, 20)
        Me.searchtxt.TabIndex = 15
        '
        'addrecordbtn
        '
        Me.addrecordbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.addrecordbtn.Location = New System.Drawing.Point(41, 326)
        Me.addrecordbtn.Name = "addrecordbtn"
        Me.addrecordbtn.Size = New System.Drawing.Size(100, 29)
        Me.addrecordbtn.TabIndex = 16
        Me.addrecordbtn.Text = "Add Record"
        Me.addrecordbtn.UseVisualStyleBackColor = False
        '
        'updatebtn
        '
        Me.updatebtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.updatebtn.Location = New System.Drawing.Point(147, 326)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(100, 29)
        Me.updatebtn.TabIndex = 17
        Me.updatebtn.Text = "Update Record"
        Me.updatebtn.UseVisualStyleBackColor = False
        '
        'deletebtn
        '
        Me.deletebtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.deletebtn.Location = New System.Drawing.Point(253, 326)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(100, 29)
        Me.deletebtn.TabIndex = 18
        Me.deletebtn.Text = "Delete Record"
        Me.deletebtn.UseVisualStyleBackColor = False
        '
        'listbtn
        '
        Me.listbtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.listbtn.FlatAppearance.BorderSize = 0
        Me.listbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.listbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listbtn.Image = CType(resources.GetObject("listbtn.Image"), System.Drawing.Image)
        Me.listbtn.Location = New System.Drawing.Point(343, 12)
        Me.listbtn.Name = "listbtn"
        Me.listbtn.Size = New System.Drawing.Size(40, 29)
        Me.listbtn.TabIndex = 19
        Me.listbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.listbtn.UseVisualStyleBackColor = False
        '
        'employees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(395, 407)
        Me.Controls.Add(Me.listbtn)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.addrecordbtn)
        Me.Controls.Add(Me.searchtxt)
        Me.Controls.Add(Me.searchbtn)
        Me.Controls.Add(Me.depnametxt)
        Me.Controls.Add(Me.phonetxt)
        Me.Controls.Add(Me.emailtxt)
        Me.Controls.Add(Me.lastnametxt)
        Me.Controls.Add(Me.firstnametxt)
        Me.Controls.Add(Me.empidtxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "employees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "employees"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents empidtxt As TextBox
    Friend WithEvents firstnametxt As TextBox
    Friend WithEvents lastnametxt As TextBox
    Friend WithEvents emailtxt As TextBox
    Friend WithEvents phonetxt As TextBox
    Friend WithEvents depnametxt As TextBox
    Friend WithEvents searchbtn As Button
    Friend WithEvents searchtxt As TextBox
    Friend WithEvents addrecordbtn As Button
    Friend WithEvents updatebtn As Button
    Friend WithEvents deletebtn As Button
    Friend WithEvents listbtn As Button
End Class
