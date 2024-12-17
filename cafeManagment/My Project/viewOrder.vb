Imports System.Data.SqlClient
Imports Windows.Win32.System

Public Class viewOrder
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sansk\OneDrive\Documents\CafeVbDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False")

    Private Sub DisplayBill()
        Con.Open()
        Dim query = "select * from OrderTbl"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        OrderDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub viewOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBill()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Obj = New Order
        Obj.Show()
        Me.Hide()
    End Sub
End Class