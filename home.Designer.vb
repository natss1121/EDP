<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.empbtn = New System.Windows.Forms.Button()
        Me.customerbtn = New System.Windows.Forms.Button()
        Me.prodbtn = New System.Windows.Forms.Button()
        Me.categbtn = New System.Windows.Forms.Button()
        Me.orderbtn = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.logoutbtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(173, 387)
        Me.Splitter1.TabIndex = 6
        Me.Splitter1.TabStop = False
        '
        'empbtn
        '
        Me.empbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.empbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.empbtn.FlatAppearance.BorderSize = 0
        Me.empbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.empbtn.Location = New System.Drawing.Point(0, 77)
        Me.empbtn.Name = "empbtn"
        Me.empbtn.Size = New System.Drawing.Size(173, 34)
        Me.empbtn.TabIndex = 7
        Me.empbtn.Text = "Employees"
        Me.empbtn.UseVisualStyleBackColor = False
        '
        'customerbtn
        '
        Me.customerbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.customerbtn.FlatAppearance.BorderSize = 0
        Me.customerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.customerbtn.Location = New System.Drawing.Point(0, 117)
        Me.customerbtn.Name = "customerbtn"
        Me.customerbtn.Size = New System.Drawing.Size(173, 34)
        Me.customerbtn.TabIndex = 8
        Me.customerbtn.Text = "Customers"
        Me.customerbtn.UseVisualStyleBackColor = False
        '
        'prodbtn
        '
        Me.prodbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.prodbtn.FlatAppearance.BorderSize = 0
        Me.prodbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.prodbtn.Location = New System.Drawing.Point(0, 157)
        Me.prodbtn.Name = "prodbtn"
        Me.prodbtn.Size = New System.Drawing.Size(173, 34)
        Me.prodbtn.TabIndex = 9
        Me.prodbtn.Text = "Products"
        Me.prodbtn.UseVisualStyleBackColor = False
        '
        'categbtn
        '
        Me.categbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.categbtn.FlatAppearance.BorderSize = 0
        Me.categbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.categbtn.Location = New System.Drawing.Point(0, 197)
        Me.categbtn.Name = "categbtn"
        Me.categbtn.Size = New System.Drawing.Size(173, 34)
        Me.categbtn.TabIndex = 10
        Me.categbtn.Text = "Categories"
        Me.categbtn.UseVisualStyleBackColor = False
        '
        'orderbtn
        '
        Me.orderbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.orderbtn.FlatAppearance.BorderSize = 0
        Me.orderbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.orderbtn.Location = New System.Drawing.Point(0, 237)
        Me.orderbtn.Name = "orderbtn"
        Me.orderbtn.Size = New System.Drawing.Size(173, 34)
        Me.orderbtn.TabIndex = 11
        Me.orderbtn.Text = "Orders"
        Me.orderbtn.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(28, 25)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(116, 34)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "Home"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'logoutbtn
        '
        Me.logoutbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.logoutbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.logoutbtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.logoutbtn.FlatAppearance.BorderSize = 0
        Me.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logoutbtn.Location = New System.Drawing.Point(0, 295)
        Me.logoutbtn.Name = "logoutbtn"
        Me.logoutbtn.Size = New System.Drawing.Size(173, 34)
        Me.logoutbtn.TabIndex = 13
        Me.logoutbtn.Text = "Log out"
        Me.logoutbtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(179, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(502, 341)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(276, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 24)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Company Management System"
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(684, 387)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.logoutbtn)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.orderbtn)
        Me.Controls.Add(Me.categbtn)
        Me.Controls.Add(Me.prodbtn)
        Me.Controls.Add(Me.customerbtn)
        Me.Controls.Add(Me.empbtn)
        Me.Controls.Add(Me.Splitter1)
        Me.Name = "home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "home"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents empbtn As Button
    Friend WithEvents customerbtn As Button
    Friend WithEvents prodbtn As Button
    Friend WithEvents categbtn As Button
    Friend WithEvents orderbtn As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents logoutbtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
