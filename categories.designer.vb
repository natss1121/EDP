<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class categories
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(categories))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.categoryidtxt = New System.Windows.Forms.TextBox()
        Me.categnametxt = New System.Windows.Forms.TextBox()
        Me.addrecordbtn = New System.Windows.Forms.Button()
        Me.searchbtn = New System.Windows.Forms.Button()
        Me.searchtxt = New System.Windows.Forms.TextBox()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.listbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Categories"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Category ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Category Name"
        '
        'categoryidtxt
        '
        Me.categoryidtxt.Location = New System.Drawing.Point(142, 141)
        Me.categoryidtxt.Name = "categoryidtxt"
        Me.categoryidtxt.Size = New System.Drawing.Size(222, 20)
        Me.categoryidtxt.TabIndex = 4
        '
        'categnametxt
        '
        Me.categnametxt.Location = New System.Drawing.Point(142, 172)
        Me.categnametxt.Name = "categnametxt"
        Me.categnametxt.Size = New System.Drawing.Size(222, 20)
        Me.categnametxt.TabIndex = 5
        '
        'addrecordbtn
        '
        Me.addrecordbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.addrecordbtn.Location = New System.Drawing.Point(41, 233)
        Me.addrecordbtn.Name = "addrecordbtn"
        Me.addrecordbtn.Size = New System.Drawing.Size(101, 33)
        Me.addrecordbtn.TabIndex = 6
        Me.addrecordbtn.Text = "Add Record"
        Me.addrecordbtn.UseVisualStyleBackColor = False
        '
        'searchbtn
        '
        Me.searchbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.searchbtn.Location = New System.Drawing.Point(289, 86)
        Me.searchbtn.Name = "searchbtn"
        Me.searchbtn.Size = New System.Drawing.Size(75, 23)
        Me.searchbtn.TabIndex = 7
        Me.searchbtn.Text = "Search"
        Me.searchbtn.UseVisualStyleBackColor = False
        '
        'searchtxt
        '
        Me.searchtxt.Location = New System.Drawing.Point(142, 88)
        Me.searchtxt.Name = "searchtxt"
        Me.searchtxt.Size = New System.Drawing.Size(141, 20)
        Me.searchtxt.TabIndex = 8
        '
        'updatebtn
        '
        Me.updatebtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.updatebtn.Location = New System.Drawing.Point(148, 233)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(101, 33)
        Me.updatebtn.TabIndex = 9
        Me.updatebtn.Text = "Update Record"
        Me.updatebtn.UseVisualStyleBackColor = False
        '
        'deletebtn
        '
        Me.deletebtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.deletebtn.Location = New System.Drawing.Point(255, 233)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(101, 33)
        Me.deletebtn.TabIndex = 10
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
        Me.listbtn.Location = New System.Drawing.Point(344, 12)
        Me.listbtn.Name = "listbtn"
        Me.listbtn.Size = New System.Drawing.Size(40, 29)
        Me.listbtn.TabIndex = 11
        Me.listbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.listbtn.UseVisualStyleBackColor = False
        '
        'categories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(396, 331)
        Me.Controls.Add(Me.listbtn)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.searchtxt)
        Me.Controls.Add(Me.searchbtn)
        Me.Controls.Add(Me.addrecordbtn)
        Me.Controls.Add(Me.categnametxt)
        Me.Controls.Add(Me.categoryidtxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "categories"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "categories"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents categoryidtxt As TextBox
    Friend WithEvents categnametxt As TextBox
    Friend WithEvents addrecordbtn As Button
    Friend WithEvents searchbtn As Button
    Friend WithEvents searchtxt As TextBox
    Friend WithEvents updatebtn As Button
    Friend WithEvents deletebtn As Button
    Friend WithEvents listbtn As Button
End Class
