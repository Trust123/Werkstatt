Public Class datenladen

    Public Sub datenladen_onload(sender As Object, e As EventArgs) Handles Me.Load
        Label5.Text = ""
        Label6.Text = ""
        Label7.Text = ""
        Label9.Text = ""
        Label11.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class