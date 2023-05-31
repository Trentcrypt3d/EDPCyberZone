Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Products
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgProductPage.CellContentClick
        Connect_to_DB()

        Dim sql As String = "SELECT * FROM products"
        Dim dataAdapter As New MySqlDataAdapter(sql, myconn)
        Dim dataSet As New DataSet()

        dataAdapter.Fill(dataSet, sql)
        myconn.Close()


        dgProductPage.DataSource = dataSet.Tables(sql)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub BtnAddProduct_Click(sender As Object, e As EventArgs) Handles BtnAddProduct.Click
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

                dgProductPage.DataSource = table
                MessageBox.Show("File loaded successfully")
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        HomePage.Show()
        Me.Hide()
    End Sub

    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect_to_DB()

        Dim sql As String = "SELECT * FROM products"
        Dim dataAdapter As New MySqlDataAdapter(sql, myconn)
        Dim dataSet As New DataSet()

        dataAdapter.Fill(dataSet, sql)
        myconn.Close()


        dgProductPage.DataSource = dataSet.Tables(sql)

    End Sub
End Class