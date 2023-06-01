<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class products
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(products))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.prodidtxt = New System.Windows.Forms.TextBox()
        Me.prodnametxt = New System.Windows.Forms.TextBox()
        Me.descriptiontxt = New System.Windows.Forms.TextBox()
        Me.categnametxt = New System.Windows.Forms.TextBox()
        Me.pricetxt = New System.Windows.Forms.TextBox()
        Me.searchbtn = New System.Windows.Forms.Button()
        Me.searchtxt = New System.Windows.Forms.TextBox()
        Me.addbtn = New System.Windows.Forms.Button()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.listbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Products"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Product ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Product Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Description"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Category Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Price"
        '
        'prodidtxt
        '
        Me.prodidtxt.Location = New System.Drawing.Point(134, 129)
        Me.prodidtxt.Name = "prodidtxt"
        Me.prodidtxt.Size = New System.Drawing.Size(227, 20)
        Me.prodidtxt.TabIndex = 7
        '
        'prodnametxt
        '
        Me.prodnametxt.Location = New System.Drawing.Point(134, 164)
        Me.prodnametxt.Name = "prodnametxt"
        Me.prodnametxt.Size = New System.Drawing.Size(227, 20)
        Me.prodnametxt.TabIndex = 8
        '
        'descriptiontxt
        '
        Me.descriptiontxt.Location = New System.Drawing.Point(134, 198)
        Me.descriptiontxt.Name = "descriptiontxt"
        Me.descriptiontxt.Size = New System.Drawing.Size(227, 20)
        Me.descriptiontxt.TabIndex = 9
        '
        'categnametxt
        '
        Me.categnametxt.Location = New System.Drawing.Point(134, 239)
        Me.categnametxt.Name = "categnametxt"
        Me.categnametxt.Size = New System.Drawing.Size(227, 20)
        Me.categnametxt.TabIndex = 10
        '
        'pricetxt
        '
        Me.pricetxt.Location = New System.Drawing.Point(134, 273)
        Me.pricetxt.Name = "pricetxt"
        Me.pricetxt.Size = New System.Drawing.Size(227, 20)
        Me.pricetxt.TabIndex = 11
        '
        'searchbtn
        '
        Me.searchbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.searchbtn.Location = New System.Drawing.Point(299, 81)
        Me.searchbtn.Name = "searchbtn"
        Me.searchbtn.Size = New System.Drawing.Size(61, 23)
        Me.searchbtn.TabIndex = 12
        Me.searchbtn.Text = "Search"
        Me.searchbtn.UseVisualStyleBackColor = False
        '
        'searchtxt
        '
        Me.searchtxt.Location = New System.Drawing.Point(134, 83)
        Me.searchtxt.Name = "searchtxt"
        Me.searchtxt.Size = New System.Drawing.Size(159, 20)
        Me.searchtxt.TabIndex = 13
        '
        'addbtn
        '
        Me.addbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.addbtn.Location = New System.Drawing.Point(61, 331)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(90, 29)
        Me.addbtn.TabIndex = 14
        Me.addbtn.Text = "Add Record"
        Me.addbtn.UseVisualStyleBackColor = False
        '
        'updatebtn
        '
        Me.updatebtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.updatebtn.Location = New System.Drawing.Point(157, 331)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(90, 29)
        Me.updatebtn.TabIndex = 15
        Me.updatebtn.Text = "Update Record"
        Me.updatebtn.UseVisualStyleBackColor = False
        '
        'deletebtn
        '
        Me.deletebtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.deletebtn.Location = New System.Drawing.Point(253, 331)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(90, 29)
        Me.deletebtn.TabIndex = 16
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
        Me.listbtn.Location = New System.Drawing.Point(353, 12)
        Me.listbtn.Name = "listbtn"
        Me.listbtn.Size = New System.Drawing.Size(40, 29)
        Me.listbtn.TabIndex = 17
        Me.listbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.listbtn.UseVisualStyleBackColor = False
        '
        'products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(405, 434)
        Me.Controls.Add(Me.listbtn)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.addbtn)
        Me.Controls.Add(Me.searchtxt)
        Me.Controls.Add(Me.searchbtn)
        Me.Controls.Add(Me.pricetxt)
        Me.Controls.Add(Me.categnametxt)
        Me.Controls.Add(Me.descriptiontxt)
        Me.Controls.Add(Me.prodnametxt)
        Me.Controls.Add(Me.prodidtxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "products"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "products"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents prodidtxt As TextBox
    Friend WithEvents prodnametxt As TextBox
    Friend WithEvents descriptiontxt As TextBox
    Friend WithEvents categnametxt As TextBox
    Friend WithEvents pricetxt As TextBox
    Friend WithEvents searchbtn As Button
    Friend WithEvents searchtxt As TextBox
    Friend WithEvents addbtn As Button
    Friend WithEvents updatebtn As Button
    Friend WithEvents deletebtn As Button
    Friend WithEvents listbtn As Button
End Class
