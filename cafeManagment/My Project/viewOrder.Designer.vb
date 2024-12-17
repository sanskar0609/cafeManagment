<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewOrder))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label3 = New Label()
        Button2 = New Button()
        PictureBox2 = New PictureBox()
        OrderDGV = New DataGridView()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(OrderDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.Location = New Point(362, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(171, 38)
        Label3.TabIndex = 4
        Label3.Text = "Order List"
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.InactiveBorder
        Button2.Font = New Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button2.Location = New Point(316, 468)
        Button2.Name = "Button2"
        Button2.Size = New Size(183, 33)
        Button2.TabIndex = 27
        Button2.Text = "Back"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(827, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(53, 43)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 28
        PictureBox2.TabStop = False
        ' 
        ' OrderDGV
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.DodgerBlue
        DataGridViewCellStyle1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = Color.Blue
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        OrderDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        OrderDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.DarkOrange
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        OrderDGV.DefaultCellStyle = DataGridViewCellStyle2
        OrderDGV.Location = New Point(39, 61)
        OrderDGV.Name = "OrderDGV"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.MenuHighlight
        DataGridViewCellStyle3.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        OrderDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        OrderDGV.RowHeadersWidth = 51
        OrderDGV.Size = New Size(807, 364)
        OrderDGV.TabIndex = 32
        ' 
        ' viewOrder
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DodgerBlue
        ClientSize = New Size(892, 536)
        Controls.Add(OrderDGV)
        Controls.Add(PictureBox2)
        Controls.Add(Button2)
        Controls.Add(Label3)
        FormBorderStyle = FormBorderStyle.None
        Name = "viewOrder"
        Text = "viewOrder"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(OrderDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents OrderDGV As DataGridView
End Class
