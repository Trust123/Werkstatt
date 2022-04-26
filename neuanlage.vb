Imports System.Data.Odbc
Public Class neuanlage
    Dim query As String
    Dim conStr As String = "Driver={Microsoft Access Driver (*.mdb)};Dbq=" & My.Settings.Datenbankpfad
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'speichern
        query = "INSERT INTO motorrad(typ, fin, hersteller, kennzeichen, farbe, hu, km, reifen) VALUES ('" & TextBox4.Text & "', '" & TextBox2.Text & "', '" & TextBox1.Text & "', '" & TextBox3.Text & "', '" & TextBox6.Text & "', '" & TextBox5.Text & "', '" & TextBox7.Text & "', '" & TextBox8.Text & "')"
        Dim conn As New OdbcConnection(conStr)
        Dim com As New OdbcCommand(query, conn)

        Try
            conn.Open()
            com.ExecuteNonQuery()
            MsgBox("Gespeichert")
        Catch ex As Exception
            MsgBox("Fehler" & vbCrLf & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class