Imports System.Data.SqlClient

Public Class ApprovedLoans
    Dim myConn As SqlConnection = New SqlConnection("Data Source=COLWAM;Initial Catalog=gagz;Integrated Security=True")

    Private Sub ApprovedLoans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConn.Open()
        Dim sql = "select * from loans where approved ='yes'"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, myConn)
        Dim builder As New SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        approveLoansDGV.DataSource = ds.Tables(0)
    End Sub
End Class