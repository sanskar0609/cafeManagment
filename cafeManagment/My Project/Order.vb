Imports System.Data.SqlClient
Public Class Order
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sansk\OneDrive\Documents\CafeVbDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False")

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles QuantityTb.TextChanged

    End Sub

    Private Sub AddBill()
        Try
            Con.Open()
            ' Updated query with the correct column names
            Dim query = "INSERT INTO OrderTbl (OrdDate, OrdAmt) VALUES (@OrderDate, @GrdTotal)"
            Dim cmd As New SqlCommand(query, Con)

            ' Add parameters
            cmd.Parameters.AddWithValue("@OrderDate", DateTime.Today.Date)  ' Adding current date
            cmd.Parameters.AddWithValue("@GrdTotal", GrdTotal)  ' Assuming GredTotal is a variable holding the total value

            cmd.ExecuteNonQuery()
            MsgBox("Bill added successfully.")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            Con.Close()
        End Try


    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AddBill()
        PrintPreviewDialog1.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim obj = New Form1
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DisplayItem()

    End Sub

    Private Sub DisplayItem()
        Con.Open()
        Dim query = "select * from ItemTb1"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub FilterByCategory()
        Con.Open()
        Dim query = "select * from ItemTb1 where itCat='" & CatCb.SelectedValue.ToString() & "'"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub FillCategory()
        Con.Open()
        Dim cmd = New SqlCommand("Select * from CategoryTbl", Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim Tbl = New DataTable()
        adapter.Fill(Tbl)
        CatCb.DataSource = Tbl
        CatCb.DisplayMember = "CatName"
        CatCb.ValueMember = "CatName"
        Con.Close()
    End Sub
    Private Sub Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayItem()
        FillCategory()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub CatCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CatCb.SelectionChangeCommitted
        FilterByCategory()


    End Sub

    Private Sub BillDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BillDGV.CellContentClick

    End Sub

    Dim ProdName As String
    Dim i = 0, price, qty
    Dim key = 0, GrdTotal = 0, stock
    Private Sub ItemDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick
        Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
        ProdName = row.Cells(1).Value.ToString


        If ProdName = "" Then
            stock = 0
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
            stock = Convert.ToInt32(row.Cells(4).Value.ToString)
            price = Convert.ToInt32(row.Cells(3).Value.ToString)
        End If
    End Sub

    Private Sub UpdateItem()
        Try
            Dim newQty = stock - Convert.ToInt32(QuantityTb.Text)
            Con.Open()

            ' Use parameterized query to ensure safety and correctness
            Dim query = "UPDATE ItemTb1 SET itQty = @ItQty WHERE itId = @ItId"
            Dim cmd As New SqlCommand(query, Con)

            ' Convert price to decimal
            cmd.Parameters.AddWithValue("@ItQty", newQty) ' Convert quantity to integer
            cmd.Parameters.AddWithValue("@ItId", key) ' Key value to identify the record to update

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MsgBox("Item updated successfully.")
            Else
                MsgBox("No item found with the specified ID.")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            Con.Close()

            DisplayItem()
        End Try
    End Sub
    Private Sub AddToBill_Click(sender As Object, e As EventArgs) Handles AddToBill.Click
        If key = 0 Then
            MsgBox("Select a Item")
        ElseIf Convert.ToInt32(QuantityTb.Text) > stock Then
            MsgBox("no enough stock")
        Else
            Dim rnum = BillDGV.Rows.Add
            Dim total = Convert.ToInt32(QuantityTb.Text) * price
            i = i + 1
            BillDGV.Rows.Item(rnum).Cells("Column1").Value = i
            BillDGV.Rows.Item(rnum).Cells("Column2").Value = ProdName
            BillDGV.Rows.Item(rnum).Cells("Column4").Value = price
            BillDGV.Rows.Item(rnum).Cells("Column5").Value = QuantityTb.Text
            BillDGV.Rows.Item(rnum).Cells("Column3").Value = total
            GrdTotal = GrdTotal + total
            TotalTbl.Text = "Rs" + Convert.ToString(GrdTotal)
            UpdateItem()
            QuantityTb.Text = ""
            key = 0
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("cafe shop", New Font("Arial", 22), Brushes.BlueViolet, 355, 35)
        e.Graphics.DrawString("***Your Bill***", New Font("Arial", 14), Brushes.BlueViolet, 350, 30)
        Dim bm As New Bitmap(Me.BillDGV.Width, Me.BillDGV.Height)
        BillDGV.DrawToBitmap(bm, New Rectangle(0, 0, Me.BillDGV.Width, Me.BillDGV.Height))
        e.Graphics.DrawImage(bm, 0, 90)
        e.Graphics.DrawString("Total amount" + GrdTotal.ToString(), New Font("Arial", 15), Brushes.BlueViolet, 350, 30)
        e.Graphics.DrawString("******************Thanks for buying********", New Font("Arial", 15), Brushes.BlueViolet, 350, 30)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Obj = New viewOrder
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles removebtn.Click
        ' Check if a row is selected in the BillDGV
        If BillDGV.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = BillDGV.SelectedRows(0)

            ' Get the item details from the BillDGV
            Dim itemID As Integer = selectedRow.Cells("Column1").Value ' Assuming Column1 is the item ID
            Dim price As Decimal = selectedRow.Cells("Column4").Value ' Assuming Column4 is the price
            Dim qty As Integer = selectedRow.Cells("Column5").Value   ' Assuming Column5 is the quantity

            ' Update the stock back to the original value in the database
            Try
                Con.Open()
                Dim query = "UPDATE ItemTb1 SET itQty = itQty + @ItQty WHERE itId = @ItId"
                Dim cmd As New SqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@ItQty", qty) ' Add the quantity back to stock
                cmd.Parameters.AddWithValue("@ItId", itemID) ' Identify the item by its ID
                cmd.ExecuteNonQuery()
                Con.Close()

                ' Remove the selected row from BillDGV
                BillDGV.Rows.Remove(selectedRow)

                ' Recalculate the total
                GrdTotal -= price * qty
                TotalTbl.Text = "Rs" + GrdTotal.ToString()

                MsgBox("Item removed from the bill successfully.")
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Con.Close()
            End Try
        Else
            MsgBox("Please select an item to remove.")
        End If
    End Sub
End Class