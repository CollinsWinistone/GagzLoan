Imports System.Data.SqlClient
Public Class OverdueLoans
    Dim myConn As SqlConnection = New SqlConnection("Data Source=COLWAM;Initial Catalog=gagz;Integrated Security=True")

    Private Sub OverdueLoans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim thisDate As Date
        thisDate = Today
        myConn.Open()
        Dim sql = "select * from loans where DueDate <= '" & thisDate & "'"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, myConn)
        Dim builder As New SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        overDueDGV.DataSource = ds.Tables(0)

        myConn.Close()
    End Sub

    Private Sub overDueDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles overDueDGV.CellContentClick

    End Sub
End Class