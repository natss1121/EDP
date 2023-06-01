Imports System.IO
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class datagrid

    Private Sub Import_Click(sender As Object, e As EventArgs) Handles Import.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "CSV Files|*.csv"
        openFileDialog1.Title = "Select a CSV File"

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim file As String = openFileDialog1.FileName
            Dim table As New DataTable()

            Try
                Using sr As New StreamReader(file)
                    Dim headers() As String = sr.ReadLine().Split(","c)
                    For Each header As String In headers
                        table.Columns.Add(header)
                    Next

                    While Not sr.EndOfStream
                        Dim content() As String = sr.ReadLine().Split(","c)
                        Dim row As DataRow = table.NewRow()
                        row.ItemArray = content
                        table.Rows.Add(row)
                    End While
                End Using

                Productsdatagrid.DataSource = table
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Backup_Click(sender As Object, e As EventArgs) Handles Backup.Click
        Dim backup As New SaveFileDialog
        backup.InitialDirectory = "Desktop"
        backup.Title = "Database Backup"
        backup.CheckFileExists = False
        backup.CheckPathExists = False
        backup.DefaultExt = "sql"
        backup.FileName = "backup"
        backup.Filter = "SQL files (*.sql)| *.sql"
        backup.RestoreDirectory = True

        If backup.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim cmd As MySqlCommand = New MySqlCommand
            cmd.Connection = myconn
            Dim mb As MySqlBackup = New MySqlBackup(cmd)
            mb.ExportToFile(backup.FileName)
            MessageBox.Show("Database backup sucessfully at " & backup.FileName)
        End If
    End Sub

    Private Sub Productsdatagrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Productsdatagrid.CellContentClick

    End Sub

    Private Sub datagrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect_to_DB()
    End Sub
End Class