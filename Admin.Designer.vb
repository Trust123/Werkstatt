﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(12, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 42)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Neuanlage"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(161, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 42)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Laden"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Location = New System.Drawing.Point(12, 60)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(143, 42)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button4.Location = New System.Drawing.Point(161, 60)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(143, 42)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button5.Location = New System.Drawing.Point(310, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(143, 42)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Zurück"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button6.Location = New System.Drawing.Point(310, 60)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(143, 42)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = False
        Me.Button6.Visible = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button7.Location = New System.Drawing.Point(459, 12)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(143, 42)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = False
        Me.Button7.Visible = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button8.Location = New System.Drawing.Point(458, 60)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(143, 42)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "Button8"
        Me.Button8.UseVisualStyleBackColor = False
        Me.Button8.Visible = False
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 114)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
End Class