Imports System.Data.OleDb

Public Class Form4
    Dim connection As New OleDb.OleDbConnection

    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim cmd As New OleDbCommand(sql, connection)
    Dim connStr As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Txtpassword.Text = ReNewPass.Text Then
            Try
                connection.Open()
                cmd = New OleDbCommand("update robocopy set [password] = '" & NewPass.Text & "' where username = '" & Txtpassword.Text & "'", connection)
                cmd.ExecuteNonQuery()
                MessageBox.Show("PASSWORD CHANGE SUCCESSFULLY")
                connection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class