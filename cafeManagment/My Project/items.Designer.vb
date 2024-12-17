<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class items
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(items))
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        ItemDGV = New DataGridView()
        Label7 = New Label()
        Button1 = New Button()
        Label6 = New Label()
        CatTb = New TextBox()
        Panel2 = New Panel()
        Resetbtn = New Button()
        Deletebtn = New Button()
        Editbtn = New Button()
        Addbtn = New Button()
        CatCb = New ComboBox()
        Label5 = New Label()
        Label4 = New Label()
        ItNameTb = New TextBox()
        QuantityTb = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        ItPriceTb = New TextBox()
        Label3 = New Label()
        Button5 = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(ItemDGV, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(ItemDGV)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(CatTb)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(94, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(958, 519)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(905, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(53, 43)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 29
        PictureBox2.TabStop = False
        ' 
        ' ItemDGV
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.DodgerBlue
        DataGridViewCellStyle2.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = Color.Blue
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        ItemDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        ItemDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ItemDGV.Location = New Point(30, 263)
        ItemDGV.Name = "ItemDGV"
        ItemDGV.RowHeadersWidth = 51
        ItemDGV.Size = New Size(911, 230)
        ItemDGV.TabIndex = 19
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label7.Location = New Point(431, 237)
        Label7.Name = "Label7"
        Label7.Size = New Size(95, 23)
        Label7.TabIndex = 18
        Label7.Text = "Items List"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.HotTrack
        Button1.Font = New Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(362, 44)
        Button1.Name = "Button1"
        Button1.Size = New Size(183, 44)
        Button1.TabIndex = 17
        Button1.Text = "Add Category"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DodgerBlue
        Label6.Location = New Point(46, 55)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 22)
        Label6.TabIndex = 15
        Label6.Text = "Name"
        ' 
        ' CatTb
        ' 
        CatTb.BorderStyle = BorderStyle.FixedSingle
        CatTb.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CatTb.Location = New Point(108, 55)
        CatTb.Name = "CatTb"
        CatTb.Size = New Size(231, 28)
        CatTb.TabIndex = 16
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Resetbtn)
        Panel2.Controls.Add(Deletebtn)
        Panel2.Controls.Add(Editbtn)
        Panel2.Controls.Add(Addbtn)
        Panel2.Controls.Add(CatCb)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(ItNameTb)
        Panel2.Controls.Add(QuantityTb)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(ItPriceTb)
        Panel2.Location = New Point(30, 89)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(911, 134)
        Panel2.TabIndex = 15
        ' 
        ' Resetbtn
        ' 
        Resetbtn.BackColor = SystemColors.HotTrack
        Resetbtn.Font = New Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Resetbtn.Location = New Point(28, 80)
        Resetbtn.Name = "Resetbtn"
        Resetbtn.Size = New Size(157, 31)
        Resetbtn.TabIndex = 21
        Resetbtn.Text = "Reset"
        Resetbtn.UseVisualStyleBackColor = False
        ' 
        ' Deletebtn
        ' 
        Deletebtn.BackColor = SystemColors.HotTrack
        Deletebtn.Font = New Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Deletebtn.Location = New Point(587, 80)
        Deletebtn.Name = "Deletebtn"
        Deletebtn.Size = New Size(157, 31)
        Deletebtn.TabIndex = 20
        Deletebtn.Text = "Delete"
        Deletebtn.UseVisualStyleBackColor = False
        ' 
        ' Editbtn
        ' 
        Editbtn.BackColor = SystemColors.HotTrack
        Editbtn.Font = New Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Editbtn.Location = New Point(400, 80)
        Editbtn.Name = "Editbtn"
        Editbtn.Size = New Size(157, 31)
        Editbtn.TabIndex = 19
        Editbtn.Text = "Edit"
        Editbtn.UseVisualStyleBackColor = False
        ' 
        ' Addbtn
        ' 
        Addbtn.BackColor = SystemColors.HotTrack
        Addbtn.Font = New Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Addbtn.Location = New Point(225, 80)
        Addbtn.Name = "Addbtn"
        Addbtn.Size = New Size(157, 31)
        Addbtn.TabIndex = 18
        Addbtn.Text = "Add"
        Addbtn.UseVisualStyleBackColor = False
        ' 
        ' CatCb
        ' 
        CatCb.Font = New Font("Tahoma", 10.2F)
        CatCb.FormattingEnabled = True
        CatCb.Location = New Point(263, 32)
        CatCb.Name = "CatCb"
        CatCb.Size = New Size(151, 29)
        CatCb.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.DodgerBlue
        Label5.Location = New Point(263, 7)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 22)
        Label5.TabIndex = 14
        Label5.Text = "categories"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DodgerBlue
        Label4.Location = New Point(14, 7)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 22)
        Label4.TabIndex = 7
        Label4.Text = "Name"
        ' 
        ' ItNameTb
        ' 
        ItNameTb.BorderStyle = BorderStyle.FixedSingle
        ItNameTb.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ItNameTb.Location = New Point(14, 32)
        ItNameTb.Name = "ItNameTb"
        ItNameTb.Size = New Size(231, 28)
        ItNameTb.TabIndex = 8
        ' 
        ' QuantityTb
        ' 
        QuantityTb.BorderStyle = BorderStyle.FixedSingle
        QuantityTb.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        QuantityTb.Location = New Point(628, 32)
        QuantityTb.Name = "QuantityTb"
        QuantityTb.Size = New Size(145, 28)
        QuantityTb.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DodgerBlue
        Label1.Location = New Point(435, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 22)
        Label1.TabIndex = 9
        Label1.Text = "Price"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DodgerBlue
        Label2.Location = New Point(628, 7)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 22)
        Label2.TabIndex = 11
        Label2.Text = "Quantity"
        ' 
        ' ItPriceTb
        ' 
        ItPriceTb.BorderStyle = BorderStyle.FixedSingle
        ItPriceTb.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ItPriceTb.Location = New Point(435, 32)
        ItPriceTb.Name = "ItPriceTb"
        ItPriceTb.Size = New Size(147, 28)
        ItPriceTb.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.Location = New Point(415, 14)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 23)
        Label3.TabIndex = 3
        Label3.Text = "Manage Items"
        ' 
        ' Button5
        ' 
        Button5.BackColor = SystemColors.HotTrack
        Button5.Font = New Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(3, 490)
        Button5.Name = "Button5"
        Button5.Size = New Size(90, 41)
        Button5.TabIndex = 21
        Button5.Text = "LogOut"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' items
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DodgerBlue
        ClientSize = New Size(1064, 543)
        Controls.Add(Button5)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "items"
        StartPosition = FormStartPosition.CenterScreen
        Text = "items"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(ItemDGV, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ItPriceTb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ItNameTb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CatCb As ComboBox
    Friend WithEvents QuantityTb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents CatTb As TextBox
    Friend WithEvents Addbtn As Button
    Friend WithEvents ItemDGV As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Deletebtn As Button
    Friend WithEvents Editbtn As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Resetbtn As Button
End Class
