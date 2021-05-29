Imports System.IO
Imports System.Data.Odbc
Public Class datenladen
    Dim query As String
    Dim conStr As String = "Driver={Microsoft Access Driver (*.mdb)};Dbq=" & My.Settings.Datenbankpfad
    Public Sub datenladen_onload(sender As Object, e As EventArgs) Handles Me.Load
        Label5.Text = ""
        Label6.Text = ""
        Label7.Text = ""
        Label9.Text = ""
        Label11.Text = ""
        Label13.Text = ""
        Label15.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Laden
        query = "SELECT * FROM motorrad WHERE kennzeichen='" & ComboBox1.SelectedItem & "'"
        Dim conn As New OdbcConnection(conStr)
        Dim com As New OdbcCommand(query, conn)
        Dim reader As OdbcDataReader

        Try
            conn.Open()
            reader = com.ExecuteReader()


            Do While reader.Read()
                Label5.Text = reader("fin")
                Label6.Text = reader("hersteller")
                Label7.Text = reader("typ")
                Label9.Text = reader("farbe")
                Label11.Text = reader("km")
                Label13.Text = reader("hu")
                Label15.Text = reader("reifen")


            Loop
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Fehler" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class