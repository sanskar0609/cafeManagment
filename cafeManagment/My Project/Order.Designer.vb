<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Order
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Order))
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        removebtn = New Button()
        ItemDGV = New DataGridView()
        PictureBox2 = New PictureBox()
        Button4 = New Button()
        Button3 = New Button()
        TotalTbl = New Label()
        AddToBill = New Button()
        Label9 = New Label()
        Button5 = New Button()
        CatCb = New ComboBox()
        BillDGV = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Label7 = New Label()
        QuantityTb = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Button6 = New Button()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        Panel1.SuspendLayout()
        CType(ItemDGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(BillDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(removebtn)
        Panel1.Controls.Add(ItemDGV)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(TotalTbl)
        Panel1.Controls.Add(AddToBill)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(CatCb)
        Panel1.Controls.Add(BillDGV)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(QuantityTb)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(90, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(958, 519)
        Panel1.TabIndex = 1
        ' 
        ' removebtn
        ' 
        removebtn.BackColor = SystemColors.HotTrack
        removebtn.Font = New Font("Times New Roman", 12.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        removebtn.Location = New Point(768, 228)
        removebtn.Name = "removebtn"
        removebtn.Size = New Size(183, 33)
        removebtn.TabIndex = 32
        removebtn.Text = "Remove Item"
        removebtn.UseVisualStyleBackColor = False
        ' 
        ' ItemDGV
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.DodgerBlue
        DataGridViewCellStyle1.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = Color.Blue
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        ItemDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        ItemDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ItemDGV.Location = New Point(340, 41)
        ItemDGV.Name = "ItemDGV"
        ItemDGV.RowHeadersWidth = 51
        ItemDGV.Size = New Size(615, 181)
        ItemDGV.TabIndex = 31
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(905, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(53, 43)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 30
        PictureBox2.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.HotTrack
        Button4.Font = New Font("Times New Roman", 12.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(601, 470)
        Button4.Name = "Button4"
        Button4.Size = New Size(121, 37)
        Button4.TabIndex = 29
        Button4.Text = "View Order"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.HotTrack
        Button3.Font = New Font("Times New Roman", 12.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(321, 470)
        Button3.Name = "Button3"
        Button3.Size = New Size(121, 37)
        Button3.TabIndex = 28
        Button3.Text = "Print"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' TotalTbl
        ' 
        TotalTbl.AutoSize = True
        TotalTbl.Font = New Font("Times New Roman", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TotalTbl.ForeColor = Color.DodgerBlue
        TotalTbl.Location = New Point(508, 477)
        TotalTbl.Name = "TotalTbl"
        TotalTbl.Size = New Size(51, 22)
        TotalTbl.TabIndex = 27
        TotalTbl.Text = "Total"
        ' 
        ' AddToBill
        ' 
        AddToBill.BackColor = SystemColors.HotTrack
        AddToBill.Font = New Font("Times New Roman", 12.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        AddToBill.Location = New Point(579, 228)
        AddToBill.Name = "AddToBill"
        AddToBill.Size = New Size(183, 33)
        AddToBill.TabIndex = 26
        AddToBill.Text = "Add To Bill"
        AddToBill.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label9.Location = New Point(590, 19)
        Label9.Name = "Label9"
        Label9.Size = New Size(95, 23)
        Label9.TabIndex = 25
        Label9.Text = "Items List"
        ' 
        ' Button5
        ' 
        Button5.BackColor = SystemColors.HotTrack
        Button5.Font = New Font("Times New Roman", 12.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(184, 41)
        Button5.Name = "Button5"
        Button5.Size = New Size(121, 37)
        Button5.TabIndex = 23
        Button5.Text = "Refresh"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' CatCb
        ' 
        CatCb.Font = New Font("Tahoma", 10.2F)
        CatCb.FormattingEnabled = True
        CatCb.Location = New Point(18, 45)
        CatCb.Name = "CatCb"
        CatCb.Size = New Size(151, 29)
        CatCb.TabIndex = 21
        ' 
        ' BillDGV
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        BillDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        BillDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        BillDGV.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column4, Column5, Column3})
        BillDGV.Location = New Point(75, 304)
        BillDGV.Name = "BillDGV"
        BillDGV.RowHeadersWidth = 160
        BillDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        BillDGV.Size = New Size(849, 160)
        BillDGV.TabIndex = 19
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "ID"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Product"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Price"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Quantity"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Total"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label7.Location = New Point(428, 267)
        Label7.Name = "Label7"
        Label7.Size = New Size(106, 23)
        Label7.TabIndex = 18
        Label7.Text = "Your Order"
        ' 
        ' QuantityTb
        ' 
        QuantityTb.BorderStyle = BorderStyle.FixedSingle
        QuantityTb.Font = New Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        QuantityTb.Location = New Point(428, 231)
        QuantityTb.Name = "QuantityTb"
        QuantityTb.Size = New Size(145, 28)
        QuantityTb.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DodgerBlue
        Label2.Location = New Point(349, 233)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 22)
        Label2.TabIndex = 11
        Label2.Text = "Quantity"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.Location = New Point(366, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 23)
        Label3.TabIndex = 3
        Label3.Text = "Manage Items"
        ' 
        ' Button6
        ' 
        Button6.BackColor = SystemColors.HotTrack
        Button6.Font = New Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button6.Location = New Point(3, 487)
        Button6.Name = "Button6"
        Button6.Size = New Size(81, 41)
        Button6.TabIndex = 30
        Button6.Text = "LogOut"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' Order
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DodgerBlue
        ClientSize = New Size(1060, 535)
        Controls.Add(Button6)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Order"
        Text = "Order"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(ItemDGV, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(BillDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents QuantityTb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CatCb As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TotalTbl As Label
    Friend WithEvents AddToBill As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ItemDGV As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents BillDGV As System.Windows.Forms.DataGridView
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents removebtn As Button

End Class
