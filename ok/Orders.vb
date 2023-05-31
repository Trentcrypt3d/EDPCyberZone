Imports MySql.Data.MySqlClient

Public Class Orders
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        HomePage.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgOrdersPage.CellContentClick
        Connect_to_DB()

        Dim sql As String = "SELECT * FROM orders"
        Dim dataAdapter As New MySqlDataAdapter(sql, myconn)
        Dim dataSet As New DataSet()

        dataAdapter.Fill(dataSet, sql)
        myconn.Close()


        dgOrdersPage.DataSource = dataSet.Tables(sql)
    End Sub

    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles BtnExport.Click
        export_excel(dgName:=dgOrdersPage, type:="Orders", directory:="C:\Users\stren\source\repos\Dollentas, CyberZone BSIT 3-B\ok\Report\orders.xlsx")
    End Sub
End Class