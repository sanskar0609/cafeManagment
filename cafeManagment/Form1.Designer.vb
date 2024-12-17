<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        Label4 = New Label()
        UnameTb = New TextBox()
        PasswordTb = New TextBox()
        Label6 = New Label()
        login = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Blue
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(406, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(449, 449)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(396, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(53, 43)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(116, 207)
        Label2.Name = "Label2"
        Label2.Size = New Size(204, 42)
        Label2.TabIndex = 1
        Label2.Text = " by Sanskar"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(18, 155)
        Label1.Name = "Label1"
        Label1.Size = New Size(418, 42)
        Label1.TabIndex = 0
        Label1.Text = "cafe Management System"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.Location = New Point(108, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(147, 42)
        Label3.TabIndex = 2
        Label3.Text = "MyCafe"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(108, 68)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(147, 93)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.DodgerBlue
        Label5.Location = New Point(12, 297)
        Label5.Name = "Label5"
        Label5.Size = New Size(121, 33)
        Label5.TabIndex = 5
        Label5.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DodgerBlue
        Label4.Location = New Point(12, 231)
        Label4.Name = "Label4"
        Label4.Size = New Size(124, 33)
        Label4.TabIndex = 6
        Label4.Text = "Username"
        ' 
        ' UnameTb
        ' 
        UnameTb.BorderStyle = BorderStyle.FixedSingle
        UnameTb.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UnameTb.Location = New Point(142, 237)
        UnameTb.Name = "UnameTb"
        UnameTb.Size = New Size(231, 32)
        UnameTb.TabIndex = 7
        ' 
        ' PasswordTb
        ' 
        PasswordTb.BorderStyle = BorderStyle.FixedSingle
        PasswordTb.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PasswordTb.Location = New Point(142, 298)
        PasswordTb.Name = "PasswordTb"
        PasswordTb.Size = New Size(231, 32)
        PasswordTb.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 16.2F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DodgerBlue
        Label6.Location = New Point(154, 408)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 33)
        Label6.TabIndex = 9
        Label6.Text = "Seller"
        ' 
        ' login
        ' 
        login.BackColor = Color.DodgerBlue
        login.Font = New Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        login.Location = New Point(108, 350)
        login.Name = "login"
        login.Size = New Size(180, 44)
        login.TabIndex = 10
        login.Text = "Login"
        login.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(854, 450)
        Controls.Add(login)
        Controls.Add(Label6)
        Controls.Add(PasswordTb)
        Controls.Add(UnameTb)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents UnameTb As TextBox
    Friend WithEvents PasswordTb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents login As Button
    Friend WithEvents PictureBox2 As PictureBox

End Class
