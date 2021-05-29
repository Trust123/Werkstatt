Imports System.IO
Imports System.Data.Odbc

Public Class datenupdate
    Dim query As String
    Dim conStr As String = "Driver={Microsoft Access Driver (*.mdb)};Dbq=" & My.Settings.Datenbankpfad
    Public Sub neu_load(sender As Object, e As EventArgs) Handles Me.Load
        'Datenbank Kennzeichen laden beim öffnen
        query = "SELECT * FROM Motorrad"
        Dim conn As New OdbcConnection(conStr)
        Dim com As New OdbcCommand(query, conn)
        Dim reader As OdbcDataReader

        Try
            conn.Open()
            reader = com.ExecuteReader()
            ComboBox1.Items.Clear()


            Do While reader.Read()
                ComboBox1.Items.Add(
                    reader("Kennzeichen"))
            Loop
            reader.Close()
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'moped löschen
        Dim query As String
        Dim conStr As String = "Driver={Microsoft Access Driver (*.mdb)};Dbq=" & Application.StartupPath & "\db\corona.mdb;"
        query = "DELETE FROM motorrad WHERE kennzeichen IN ('" & ComboBox1.SelectedItem & "')"
        Dim conn As New OdbcConnection(conStr)
        Dim com As New OdbcCommand(query, conn)


        Try
            conn.Open()
            com.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Fehler" & vbCrLf & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Button2_Click2(sender As Object, e As EventArgs) Handles Button2.Click
        'moped einfügen
        Dim query As String
        Dim conStr As String = "Driver={Microsoft Access Driver (*.mdb)};Dbq=" & Application.StartupPath & "\db\corona.mdb;"
        query = "INSERT INTO motorrad(typ, fin, hersteller, kennzeichen, farbe, hu, km, reifen) VALUES ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & ComboBox1.SelectedItem & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "', '" & TextBox7.Text & "', '" & TextBox8.Text & "')"
        Dim conn As New OdbcConnection(conStr)
        Dim com As New OdbcCommand(query, conn)


        Try
            conn.Open()
            com.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Fehler" & vbCrLf & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class