Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim obj = New Order
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles login.Click
        If String.IsNullOrWhiteSpace(UnameTb.Text) Or String.IsNullOrWhiteSpace(PasswordTb.Text) Then
            MsgBox("Please enter both username and password.", MsgBoxStyle.Exclamation, "Input Error")
        ElseIf UnameTb.Text = "Admin" And PasswordTb.Text = "Password" Then
            Dim obj As New items
            obj.Show()
            Me.Hide()
            ' Optionally clear fields
            UnameTb.Clear()
            PasswordTb.Clear()
        Else
            MsgBox("Invalid username or password.", MsgBoxStyle.Critical, "Login Failed")
            UnameTb.Clear()
            PasswordTb.Clear()
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub
End Class
