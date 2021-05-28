Imports System.IO
Imports System.Data.Odbc
Public Class Start
    Dim query As String
    Dim conStr As String = "Driver={Microsoft Access Driver (*.mdb)};Dbq=" & My.Settings.Datenbankpfad

    Public Sub start_load(sender As Object, e As EventArgs) Handles Me.Load
        'Datenbank laden beim öffnen
        query = "SELECT * FROM Motorrad"
        Dim conn As New OdbcConnection(conStr)
        Dim com As New OdbcCommand(query, conn)
        Dim reader As OdbcDataReader

        Try
            conn.Open()
            reader = com.ExecuteReader()

            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            ListBox3.Items.Clear()
            ComboBox1.Items.Clear()
            Label4.Text = ""

            Do While reader.Read()
                ComboBox1.Items.Add(
                    reader("Kennzeichen"))
            Loop
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Fehler" & vbCrLf & ex.Message)
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Admin-Panel
        Admin.Show()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Beenden
        Application.Exit()
    End Sub
End Class
