Imports MySql.Data.MySqlClient

Public Class Categories
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        HomePage.Show()
        Me.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCategories.CellContentClick
        Connect_to_DB()

        Dim sql As String = "SELECT * FROM categories"
        Dim dataAdapter As New MySqlDataAdapter(sql, myconn)
        Dim dataSet As New DataSet()

        dataAdapter.Fill(dataSet, sql)
        myconn.Close()


        dgCategories.DataSource = dataSet.Tables(sql)
    End Sub

    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles BtnExport.Click
        export_excel(dgName:=dgCategories, type:="Orders", directory:="C:\Users\stren\source\repos\Dollentas, CyberZone BSIT 3-B\ok\Report\orders.xlsx")
    End Sub
End Class