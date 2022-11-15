Imports System.Data.SqlClient

Public Class AddCustomers
    'Create ADO.NET objects

    Private myReader As SqlDataReader
    Private results As String

    Dim myConn As SqlConnection = New SqlConnection("Data Source=COLWAM;Initial Catalog=gagz;Integrated Security=True")
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        myConn.Open()
        'adds a customer to the database
        Dim cmd As New SqlCommand("INSERT INTO Customers VALUES(" & custId.Text & ",'" & username.Text & "','" & phone.Text & "','" & custLocation.Text & "','" & loan_amount.Text & "','" & occupation.Text & "')", myConn)
        cmd.ExecuteNonQuery()
        myConn.Close()


    End Sub

    Private Sub AddCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class