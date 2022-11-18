Imports System.Data.SqlClient
Public Class Form1
    Dim con As New SqlConnection("Data Source=EDITHPC;Initial Catalog=gagzDb;Integrated Security=True")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        'logging in functionality
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM Admin WHERE Id ='" & idnumTxt.Text & "' and password ='" & passTxt.Text & "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)

        If (dt.Rows.Count > 0) Then
            MsgBox("success")
            Me.Hide()
            AddCustomers.Show()
        Else
            MsgBox("failed")

        End If

    End Sub
End Class
