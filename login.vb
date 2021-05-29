Public Class login

    Private Sub me_load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "Admin" And TextBox2.Text = "Dietmar" Then
            Admin.Show()
            Me.Close()
        End If
    End Sub
End Class