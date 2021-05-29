Public Class settings
    Private Sub Setting_load(sender As Object, e As EventArgs) Handles Me.Load

        TextBox1.Text = My.Settings.Datenbankpfad

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim greeting As String = My.Settings.Datenbankpfad
        Try
            My.Settings.Datenbankpfad = TextBox1.Text
            My.Settings.Save()
            MsgBox("Gespeichert")
        Catch ex As Exception
            MsgBox("Fehler")
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.ShowDialog()
        TextBox1.Text = OpenFileDialog1.FileName
    End Sub

End Class