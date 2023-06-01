<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class orders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(orders))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.orderidtxt = New System.Windows.Forms.TextBox()
        Me.customeridtxt = New System.Windows.Forms.TextBox()
        Me.prodidtxt = New System.Windows.Forms.TextBox()
        Me.quantitxt = New System.Windows.Forms.TextBox()
        Me.orderdatetxt = New System.Windows.Forms.TextBox()
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
        Me.Label1.Location = New System.Drawing.Point(28, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Orders"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Order ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Customer ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Product ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Quantity"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 290)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Date of Order"
        '
        'orderidtxt
        '
        Me.orderidtxt.Location = New System.Drawing.Point(140, 129)
        Me.orderidtxt.Name = "orderidtxt"
        Me.orderidtxt.Size = New System.Drawing.Size(224, 20)
        Me.orderidtxt.TabIndex = 7
        '
        'customeridtxt
        '
        Me.customeridtxt.Location = New System.Drawing.Point(140, 167)
        Me.customeridtxt.Name = "customeridtxt"
        Me.customeridtxt.Size = New System.Drawing.Size(224, 20)
        Me.customeridtxt.TabIndex = 8
        '
        'prodidtxt
        '
        Me.prodidtxt.Location = New System.Drawing.Point(140, 206)
        Me.prodidtxt.Name = "prodidtxt"
        Me.prodidtxt.Size = New System.Drawing.Size(224, 20)
        Me.prodidtxt.TabIndex = 9
        '
        'quantitxt
        '
        Me.quantitxt.Location = New System.Drawing.Point(140, 245)
        Me.quantitxt.Name = "quantitxt"
        Me.quantitxt.Size = New System.Drawing.Size(224, 20)
        Me.quantitxt.TabIndex = 10
        '
        'orderdatetxt
        '
        Me.orderdatetxt.Location = New System.Drawing.Point(140, 287)
        Me.orderdatetxt.Name = "orderdatetxt"
        Me.orderdatetxt.Size = New System.Drawing.Size(224, 20)
        Me.orderdatetxt.TabIndex = 11
        '
        'searchbtn
        '
        Me.searchbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.searchbtn.Location = New System.Drawing.Point(302, 77)
        Me.searchbtn.Name = "searchbtn"
        Me.searchbtn.Size = New System.Drawing.Size(62, 23)
        Me.searchbtn.TabIndex = 12
        Me.searchbtn.Text = "Search"
        Me.searchbtn.UseVisualStyleBackColor = False
        '
        'searchtxt
        '
        Me.searchtxt.Location = New System.Drawing.Point(140, 79)
        Me.searchtxt.Name = "searchtxt"
        Me.searchtxt.Size = New System.Drawing.Size(156, 20)
        Me.searchtxt.TabIndex = 13
        '
        'addrecordbtn
        '
        Me.addrecordbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.addrecordbtn.FlatAppearance.BorderSize = 0
        Me.addrecordbtn.Location = New System.Drawing.Point(59, 342)
        Me.addrecordbtn.Name = "addrecordbtn"
        Me.addrecordbtn.Size = New System.Drawing.Size(93, 31)
        Me.addrecordbtn.TabIndex = 14
        Me.addrecordbtn.Text = "Add Record"
        Me.addrecordbtn.UseVisualStyleBackColor = False
        '
        'updatebtn
        '
        Me.updatebtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.updatebtn.Location = New System.Drawing.Point(158, 342)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(93, 31)
        Me.updatebtn.TabIndex = 15
        Me.updatebtn.Text = "Update Record"
        Me.updatebtn.UseVisualStyleBackColor = False
        '
        'deletebtn
        '
        Me.deletebtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.deletebtn.Location = New System.Drawing.Point(257, 342)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(93, 31)
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
        Me.listbtn.Location = New System.Drawing.Point(356, 12)
        Me.listbtn.Name = "listbtn"
        Me.listbtn.Size = New System.Drawing.Size(40, 29)
        Me.listbtn.TabIndex = 17
        Me.listbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.listbtn.UseVisualStyleBackColor = False
        '
        'orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(408, 439)
        Me.Controls.Add(Me.listbtn)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.addrecordbtn)
        Me.Controls.Add(Me.searchtxt)
        Me.Controls.Add(Me.searchbtn)
        Me.Controls.Add(Me.orderdatetxt)
        Me.Controls.Add(Me.quantitxt)
        Me.Controls.Add(Me.prodidtxt)
        Me.Controls.Add(Me.customeridtxt)
        Me.Controls.Add(Me.orderidtxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "orders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "orders"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents orderidtxt As TextBox
    Friend WithEvents customeridtxt As TextBox
    Friend WithEvents prodidtxt As TextBox
    Friend WithEvents quantitxt As TextBox
    Friend WithEvents orderdatetxt As TextBox
    Friend WithEvents searchbtn As Button
    Friend WithEvents searchtxt As TextBox
    Friend WithEvents addrecordbtn As Button
    Friend WithEvents updatebtn As Button
    Friend WithEvents deletebtn As Button
    Friend WithEvents listbtn As Button
End Class
