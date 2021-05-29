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
        query = "INSERT INTO motorrad(typ, fin, hersteller, kennzeichen, farbe, hu, km, reifen) VALUES ('" & TextBox4.Text & "', '" & TextBox2.Text & "', '" & TextBox1.Text & "', '" & ComboBox1.SelectedItem & "',  '" & TextBox6.Text & "', '" & TextBox5.Text & "', '" & TextBox7.Text & "', '" & TextBox8.Text & "')"
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Datenbank Kennzeichen laden beim öffnen
        query = "SELECT * FROM Motorrad"
        Dim conn As New OdbcConnection(conStr)
        Dim com As New OdbcCommand(query, conn)
        Dim reader As OdbcDataReader

        Try
            conn.Open()
            reader = com.ExecuteReader()

            Do While reader.Read()

                TextBox2.Text = reader("fin")
                TextBox1.Text = reader("hersteller")
                TextBox4.Text = reader("typ")
                TextBox6.Text = reader("farbe")
                TextBox7.Text = reader("km")
                TextBox5.Text = reader("hu")
                TextBox8.Text = reader("reifen")


            Loop
            reader.Close()
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

End Class