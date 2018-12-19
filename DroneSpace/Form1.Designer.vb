<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(510, 189)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(237, 26)
        Me.TextBox2.TabIndex = 11
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(510, 138)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(237, 26)
        Me.TextBox1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(409, 194)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Password :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(409, 138)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Username :"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(447, 393)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(150, 35)
        Me.ProgressBar1.TabIndex = 15
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(335, 333)
        Me.LinkLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(129, 20)
        Me.LinkLabel2.TabIndex = 14
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Forget Password"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(590, 333)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(133, 20)
        Me.LinkLabel1.TabIndex = 13
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Create a Account"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Turquoise
        Me.Button1.Location = New System.Drawing.Point(339, 265)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(384, 35)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.DroneSpace.My.Resources.Resource1.design5
        Me.PictureBox1.Location = New System.Drawing.Point(7, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(457, 290)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 466)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button1 As Button
    Private WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
End Class
