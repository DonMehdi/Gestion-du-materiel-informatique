Imports System.Data.SqlClient
Imports System.Data
Public Class connecter
    Dim tentation As Int32 = 3
    Dim s As Integer
    Dim p As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click

        s = s & CType(sender, Button).Text
        's = CType(sender, Button).Text



    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click

        If tentation > 0 Then
            If s = 12345 Then

                menu_principale.Show()
                Me.Hide()
            Else
                If s <> 12345 Then
                    MessageBox.Show("MOT DE PASSE INCORRECT " & vbCrLf & "il vous reste " & tentation - 1 & " essai", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    s = 0
                ElseIf s = 12345 Then
                    menu_principale.Show()
                    Me.Hide()
                End If
                tentation -= 1
                If tentation = 0 Then
                    Application.Exit()
                End If

            End If
        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    If MsgBox("vouler vous vraiment ajouter", 1 + 32, "confirmation") = MsgBoxResult.Ok Then
        '        cn.Open()
        '        cmd.CommandType = CommandType.Text
        '        cmd.CommandText = "insert into securite(pasword) values ('" & s & "')"
        '        cmd.Connection = cn
        '        cmd.ExecuteNonQuery()
        '        MsgBox("ajout avec succé", 0 + 64, "good")
        '        cn.Close()
        '    End If
        '    cn.Open()
        '    If cn.State = ConnectionState.Open Then
        '        cmd.CommandType = CommandType.Text
        '        cmd.CommandText = (" select pasword from securite ")
        '        cmd.Connection = cn
        '        dr = cmd.ExecuteReader
        '        If dr.HasRows Then

        '            p = dr(0)
        '        Else
        '            MsgBox("pas de resrvation", 0 + 16, "!!!!")
        '        End If
        '        dr.Close()
        '        cn.Close()
        '    Else
        '        MsgBox("ERREUR HORS DE LA CONNXION", 0 + 64, "conx")
        '    End If

        '    s = Nothing
        '    MsgBox(p)
        'End Sub



    End Sub


    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        FrmApplication.Show()
        Me.Hide()
    End Sub

    Private Sub connecter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
