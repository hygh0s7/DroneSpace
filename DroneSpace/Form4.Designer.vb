﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ReNewPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txtpassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ReNewPass
        '
        Me.ReNewPass.Location = New System.Drawing.Point(431, 191)
        Me.ReNewPass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ReNewPass.Name = "ReNewPass"
        Me.ReNewPass.Size = New System.Drawing.Size(148, 26)
        Me.ReNewPass.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(231, 197)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Re-Enter New Password "
        '
        'Txtpassword
        '
        Me.Txtpassword.Location = New System.Drawing.Point(431, 142)
        Me.Txtpassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txtpassword.Name = "Txtpassword"
        Me.Txtpassword.Size = New System.Drawing.Size(148, 26)
        Me.Txtpassword.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(231, 145)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "New Password"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(431, 93)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(148, 26)
        Me.txtusername.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(231, 99)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Username "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(273, 325)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(246, 35)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Change Password"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReNewPass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txtpassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReNewPass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txtpassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
