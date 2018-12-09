Imports System.Data.OleDb

Public Class Form4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand
        Dim adaptor As New SqlClient.SqlDataAdapter
        Dim dataset As New DataSet
        connection.Open()
        connection.ConnectionString = ("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\accounts.mdf;Integrated Security=True;User Instance=True")
        command.CommandText = "UPDATE Accounts SET Password='" & Txtpass.Text & "';"
        'connection.Open()
        command.Connection = connection
        adaptor.SelectCommand = command
        adaptor.Fill(dataset, "0")

        MsgBox("Password Changed Successfully", MsgBoxStyle.Information, "Done!")
        Form1.Show()

    End Sub
End Class
