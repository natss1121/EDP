<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class datagrid
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
        Me.Productsdatagrid = New System.Windows.Forms.DataGridView()
        Me.Import = New System.Windows.Forms.Button()
        Me.Backup = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.Productsdatagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Productsdatagrid
        '
        Me.Productsdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Productsdatagrid.Location = New System.Drawing.Point(100, 74)
        Me.Productsdatagrid.Name = "Productsdatagrid"
        Me.Productsdatagrid.Size = New System.Drawing.Size(597, 254)
        Me.Productsdatagrid.TabIndex = 0
        '
        'Import
        '
        Me.Import.Location = New System.Drawing.Point(117, 357)
        Me.Import.Name = "Import"
        Me.Import.Size = New System.Drawing.Size(88, 29)
        Me.Import.TabIndex = 1
        Me.Import.Text = "Import"
        Me.Import.UseVisualStyleBackColor = True
        '
        'Backup
        '
        Me.Backup.Location = New System.Drawing.Point(626, 357)
        Me.Backup.Name = "Backup"
        Me.Backup.Size = New System.Drawing.Size(88, 29)
        Me.Backup.TabIndex = 2
        Me.Backup.Text = "Backup"
        Me.Backup.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox1.Location = New System.Drawing.Point(303, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(195, 31)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "List of Products"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'datagrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Backup)
        Me.Controls.Add(Me.Import)
        Me.Controls.Add(Me.Productsdatagrid)
        Me.Name = "datagrid"
        Me.Text = "datagrid"
        CType(Me.Productsdatagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Productsdatagrid As DataGridView
    Friend WithEvents Import As Button
    Friend WithEvents Backup As Button
    Friend WithEvents TextBox1 As TextBox
End Class
