Imports System.IO
Imports System.Data.Odbc
Public Class Start
    Dim query As String
    Dim conStr As String = "Driver={Microsoft Access Driver (*.mdb)};Dbq=" & My.Settings.Datenbankpfad

    Public Sub Tool_load(sender As Object, e As EventArgs) Handles Me.Load
        'Datenbank Kennzeichen laden beim öffnen
        Label4.Text = ""
        Label10.Text = ""
        uplabel.Text = Application.ProductVersion

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
            ListBox4.Items.Clear()
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



    Public Sub Tool_load2(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Datenbank Kennzeichen laden beim öffnen
        Label4.Text = ""
        query = "SELECT * FROM motorrad WHERE kennzeichen='" & ComboBox1.SelectedItem & "'"
        Dim conn As New OdbcConnection(conStr)
        Dim com As New OdbcCommand(query, conn)
        Dim reader As OdbcDataReader

        Try
            conn.Open()
            reader = com.ExecuteReader()
            Label8.Text = ""
            Label6.Text = ""
            Label7.Text = ""
            Label9.Text = ""
            Label11.Text = ""
            Label13.Text = ""
            Label15.Text = ""


            Do While reader.Read()
                Label8.Text = reader("fin")
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

        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        login.Show()
    End Sub
    Private Sub EinstellungenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EinstellungenToolStripMenuItem.Click
        'Einstellungen
        settings.Show()
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        'Beenden
        Application.Exit()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Datenbank laden bei Kennzeichenauswahl
        query = "SELECT * FROM service WHERE kennzeichen='" & ComboBox1.SelectedItem & "'"
        Dim conn As New OdbcConnection(conStr)
        Dim com As New OdbcCommand(query, conn)
        Dim reader As OdbcDataReader

        Try
            conn.Open()
            reader = com.ExecuteReader()
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            ListBox3.Items.Clear()
            ListBox4.Items.Clear()

            Do While reader.Read()
                ListBox1.Items.Add(
                    reader("datum"))

                ListBox2.Items.Add(
                    reader("was"))

                ListBox3.Items.Add(
                    reader("km"))
                ListBox4.Items.Add(
                    reader("datum"))
                ListBox4.Items.Add(
                    reader("km"))
                ListBox4.Items.Add(
                    reader("was"))
                ListBox4.Items.Add(
                    "")

            Loop
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Fehler" & vbCrLf & ex.Message)
        End Try
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged2(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Datenbank laden bei Kennzeichenauswahl
        query = "SELECT * FROM Motorrad WHERE kennzeichen='" & ComboBox1.SelectedItem & "'"
        Dim conn As New OdbcConnection(conStr)
        Dim com As New OdbcCommand(query, conn)
        Dim reader As OdbcDataReader

        Try
            conn.Open()
            reader = com.ExecuteReader()

            Do While reader.Read()
                TextBox1.Text = reader("km")
                TextBox2.Text = reader("hu")
                Label4.Text = reader("hersteller")
                Label10.Text = reader("typ")
            Loop
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Fehler" & vbCrLf & ex.Message)
        End Try
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'speichern
        query = "INSERT INTO service(kennzeichen, datum, km, was) VALUES ('" & ComboBox1.SelectedItem & "', '" & MonthCalendar1.SelectionStart.ToString("dd/MM/yyyy") & "', '" & TextBox1.Text & "', '" & RichTextBox1.Text & "')"
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
    Private Sub Button5_Click2(sender As Object, e As EventArgs) Handles Button5.Click
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
    Private Sub Button5_Click3(sender As Object, e As EventArgs) Handles Button5.Click
        'speichern
        query = "INSERT INTO motorrad(typ, fin, hersteller, kennzeichen, farbe, hu, km, reifen) VALUES ('" & Label7.Text & "', '" & Label8.Text & "', '" & Label6.Text & "', '" & ComboBox1.SelectedItem & "', '" & Label9.Text & "','" & TextBox2.Text & "', '" & TextBox1.Text & "', '" & Label15.Text & "')"
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
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Laden
        query = "SELECT * FROM service WHERE kennzeichen='" & ComboBox1.SelectedItem & "' ORDER BY km"
        Dim conn As New OdbcConnection(conStr)
        Dim com As New OdbcCommand(query, conn)
        Dim reader As OdbcDataReader

        Try
            conn.Open()
            reader = com.ExecuteReader()
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            ListBox3.Items.Clear()
            ListBox4.Items.Clear()

            Do While reader.Read()
                ListBox1.Items.Add(
                    reader("datum"))

                ListBox2.Items.Add(
                    reader("was"))

                ListBox3.Items.Add(
                    reader("km"))

                ListBox4.Items.Add(
                    reader("datum"))
                ListBox4.Items.Add(
                    reader("km"))
                ListBox4.Items.Add(
                    reader("was"))
                ListBox4.Items.Add(
                    "")


            Loop
            reader.Close()
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button6_Click2(sender As Object, e As EventArgs) Handles Button6.Click
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
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim startX As Integer = 62
        Dim startY As Integer = 200
        e.Graphics.DrawString("Kennzeichen:", ListBox4.Font, Brushes.Black, 62, 60)
        e.Graphics.DrawString(ComboBox1.SelectedItem, ListBox4.Font, Brushes.Black, 150, 60)
        e.Graphics.DrawString("Hersteller:", ListBox4.Font, Brushes.Black, 62, 80)
        e.Graphics.DrawString(Label4.Text, ListBox4.Font, Brushes.Black, 150, 80)
        e.Graphics.DrawString("Typ:", ListBox4.Font, Brushes.Black, 62, 100)
        e.Graphics.DrawString(Label10.Text, ListBox4.Font, Brushes.Black, 150, 100)
        e.Graphics.DrawString("FIN:", ListBox4.Font, Brushes.Black, 62, 120)
        e.Graphics.DrawString(Label8.Text, ListBox4.Font, Brushes.Black, 150, 120)
        e.Graphics.DrawImage(PictureBox2.Image, 600, 30)
        For x As Integer = 0 To ListBox4.Items.Count - 1
            e.Graphics.DrawString(ListBox4.Items(x).ToString, ListBox4.Font, Brushes.Black, startX, startY)
            startY += ListBox4.ItemHeight
        Next
    End Sub

    Private Sub AnlegenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnlegenToolStripMenuItem.Click
        neuanlage.Show()
    End Sub
    Private Sub ÄndernToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÄndernToolStripMenuItem.Click
        datenupdate.Show()
    End Sub

    'Updatefunktion
    Private Sub Update() Handles Me.Load


        Dim url As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(My.Settings.update)
        Dim response As System.Net.HttpWebResponse = url.GetResponse()
        Dim sr As StreamReader = New StreamReader(response.GetResponseStream())
        Dim newversion As String = sr.ReadToEnd()
        Dim current As String = Application.ProductVersion
        uplabel.Text = current.ToString
        uplabelnew.Text = newversion.ToString

        If uplabelnew.Text > uplabel.Text Then
            upbutton.Visible = True

        End If

    End Sub
    Private Sub upbutton_Click(sender As Object, e As EventArgs) Handles upbutton.Click

        Try
            Dim path As String = My.Settings.download
            My.Computer.Network.DownloadFile(path, Application.StartupPath & "Werkstatt" & uplabelnew.Text & ".exe")
            MsgBox("Das Update wurde herunter geladen!")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
