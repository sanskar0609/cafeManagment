Imports System.Data.SqlClient

Public Class items
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sansk\OneDrive\Documents\CafeVbDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False")
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

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
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        If CatCb.SelectedIndex = -1 Or ItNameTb.Text = "" Or ItPriceTb.Text = "" Or QuantityTb.Text = "" Then
            MsgBox(" missing information")
            Return
        End If

        Try
            Con.Open()
            ' Updated query with the correct column names
            Dim query = "INSERT INTO itemTb1 (ItName, ItCat, ItPrice, ItQty) VALUES (@ItName, @ItCat, @ItPrice, @ItQty)"
            Dim cmd As New SqlCommand(query, Con)

            ' Add parameters
            cmd.Parameters.AddWithValue("@ItName", ItNameTb.Text)
            cmd.Parameters.AddWithValue("@ItCat", CatCb.SelectedValue.ToString())
            cmd.Parameters.AddWithValue("@ItPrice", ItPriceTb.Text)  ' Corresponds to ItPrice column
            cmd.Parameters.AddWithValue("@ItQty", QuantityTb.Text)  ' Corresponds to ItQty column

            cmd.ExecuteNonQuery()
            MsgBox("Item added successfully.")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            Con.Close()
            Reset()
            DisplayItem()


        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim obj = New Form1
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrWhiteSpace(CatTb.Text) Then
            MsgBox("Category cannot be empty.")
            Return
        End If

        Try
            Con.Open()
            Dim query = "INSERT INTO CategoryTbl (CatName) VALUES (@Category)"
            Dim cmd As New SqlCommand(query, Con)
            cmd.Parameters.AddWithValue("@Category", CatTb.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Category added successfully.")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            Con.Close()
            CatTb.Text = ""
            FillCategory()
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CatCb.SelectedIndexChanged

    End Sub

    Private Sub Reset()
        ItNameTb.Text = ""
        CatCb.SelectedIndex = 0
        QuantityTb.Text = ""
        ItPriceTb.Text = ""

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
    Private Sub Resetbtn_Click(sender As Object, e As EventArgs) Handles Resetbtn.Click
        Reset()
    End Sub

    Private Sub items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCategory()
        DisplayItem()

    End Sub

    Dim key = 0
    Private Sub ItemDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick
        Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
        ItNameTb.Text = row.Cells(1).Value.ToString
        CatCb.SelectedValue = row.Cells(2).Value.ToString
        ItPriceTb.Text = row.Cells(3).Value.ToString
        QuantityTb.Text = row.Cells(4).Value.ToString
        If ItNameTb.Text = " " Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub Editbtn_Click(sender As Object, e As EventArgs) Handles Editbtn.Click
        If CatCb.SelectedIndex = -1 Or ItNameTb.Text = "" Or ItPriceTb.Text = "" Or QuantityTb.Text = "" Then
            MsgBox(" missing information")
            Return
        End If

        Try
            Con.Open()

            ' Use parameterized query to ensure safety and correctness
            Dim query = "UPDATE ItemTb1 SET itName = @ItName, itCat = @ItCat, itPrice = @ItPrice, itQty = @ItQty WHERE itId = @ItId"
            Dim cmd As New SqlCommand(query, Con)

            ' Add parameters to the query
            cmd.Parameters.AddWithValue("@ItName", ItNameTb.Text) ' TextBox value for the item name
            cmd.Parameters.AddWithValue("@ItCat", CatCb.SelectedValue.ToString()) ' Selected value for category
            cmd.Parameters.AddWithValue("@ItPrice", Convert.ToDecimal(ItPriceTb.Text)) ' Convert price to decimal
            cmd.Parameters.AddWithValue("@ItQty", Convert.ToInt32(QuantityTb.Text)) ' Convert quantity to integer
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
            Reset()
            DisplayItem()
        End Try

    End Sub

    Private Sub Deletebtn_Click(sender As Object, e As EventArgs) Handles Deletebtn.Click
        If key = 0 Then
            MsgBox("Missing information.")
            Return
        End If

        Try
            Con.Open()

            ' Use parameterized query for safety and correctness
            Dim query = "DELETE FROM ItemTb1 WHERE itId = @key"
            Dim cmd As SqlCommand = New SqlCommand(query, Con)
            cmd.Parameters.AddWithValue("@key", key)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MsgBox("Item deleted successfully.")
            Else
                MsgBox("No item found with the specified key.")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            Con.Close()
            Reset()
            DisplayItem()
        End Try

    End Sub
End Class