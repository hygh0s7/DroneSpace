Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'LOGIN BUTTON
        'LOGIN BUTTON
        If TextBox1.Text = My.Settings.username And
            TextBox2.Text = My.Settings.password Then
            MsgBox("Welcome, " & TextBox1.Text)
            Me.Hide()
            Form3.Show()
        Else
            MsgBox("Wrong username or password!")
        End If
        'LOGIN BUTTON

        Timer1.Start() 'Timer on Form1.vb show
        ProgressBar1.Show() 'Progress bar on Form1.vb show


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked 'REGISTER
        'REGISTER
        Form2.Show()
        'REGISTER
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form4.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

