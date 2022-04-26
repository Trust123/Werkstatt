Imports System.Data.Odbc

Public Class Admin

    Dim query As String
    Dim conStr As String = "Driver={Microsoft Access Driver (*.mdb)};Dbq=" & My.Settings.Datenbankpfad
    Public Sub admin_load(sender As Object, e As EventArgs) Handles Me.Load
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
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        neuanlage.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        datenladen.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        datenupdate.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
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
End Class