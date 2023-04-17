Imports MySql.Data.MySqlClient

Public Class HomePage


    Private Sub BtnProduct_Click(sender As Object, e As EventArgs) Handles BtnProduct.Click
        Products.Show()
        Me.Hide()
    End Sub


    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Dim backup As New SaveFileDialog
        backup.InitialDirectory = "C:\Users\1130m\Desktop\Database Backup"
        backup.Title = "Database Backup"
        backup.CheckFileExists = False
        backup.CheckPathExists = False
        backup.DefaultExt = "sql"
        backup.FileName = "backup"
        backup.Filter = "SQL files (*.sql)| *.sql"
        backup.RestoreDirectory = True

        If backup.ShowDialog = Windows.Forms.DialogResult.OK Then
            Connect_to_DB()
            Dim cmd As MySqlCommand = New MySqlCommand
            cmd.Connection = myconn
            Dim mb As MySqlBackup = New MySqlBackup(cmd)
            mb.ExportToFile(backup.FileName)
            MessageBox.Show("Database backup sucessfully at " & backup.FileName)
        End If
    End Sub


End Class
