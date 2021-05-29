Public Class settings
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
End Class