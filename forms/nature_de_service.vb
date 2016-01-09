Public Class nature_de_service
    Public Sub vider()
        Tcdenatserv.Clear()
        tservfr.Clear()
        tservar.Clear()

    End Sub
    Public Sub verification()
        If Tcdenatserv.Text = "" Then
            ErrorProvider1.SetError(Tcdenatserv, "entrez le code")
        ElseIf Not IsNumeric(Tcdenatserv.Text) Then
            ErrorProvider1.SetError(Tcdenatserv, "entrez un nombre")
        Else
            ErrorProvider1.SetError(Tcdenatserv, Nothing)
        End If
        If tservar.Text = "" Then
            ErrorProvider1.SetError(tservar, "entez le service francais")
        Else
            ErrorProvider1.SetError(tservar, Nothing)
        End If
        If tservfr.Text = "" Then
            ErrorProvider1.SetError(tservfr, "entez le service Arabe")
        Else
            ErrorProvider1.SetError(tservfr, Nothing)
        End If
    End Sub

    Private Sub Bajouter_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bajouter.Click
        Try
            If MsgBox("vouler vous vraiment ajouter", 1 + 32, "confirmation") = MsgBoxResult.Ok Then
                verification()
                If Tcdenatserv.Text = "" Or tservar.Text = "" Or tservfr.Text = "" Then
                    MsgBox("Veullez Remplire tout les champs")
                Else
                    Dim nt As New nature_services(CInt(Tcdenatserv.Text), tservfr.Text, tservar.Text)
                    natservicseM.ajouter(nt)
                    vider()
                    My_Message_Boxe.Label_Ajouter.Visible = True
                    My_Message_Boxe.label_Modifier.Visible = False
                    My_Message_Boxe.Label1.Visible = False
                    My_Message_Boxe.Picture_ajouter.Visible = True
                    My_Message_Boxe.Picture_modifier.Visible = False
                    My_Message_Boxe.Picture_supp.Visible = False
                    My_Message_Boxe.Show()
                    ActualiserGrid()
                    Tcdenatserv.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub bmodifier_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bmodifier.Click
        Try
            If MsgBox("vouler vous vraiment modifier", 1 + 32, "confirmation") = MsgBoxResult.Ok Then
                verification()
                If Tcdenatserv.Text = "" Or tservar.Text = "" Or tservfr.Text = "" Then
                    MsgBox("Veullez Remplire tout les champs")
                Else
                    Dim nt As New nature_services(CInt(Tcdenatserv.Text), tservfr.Text, tservar.Text)
                    natservicseM.modifier(nt)
                    vider()
                    My_Message_Boxe.Label_Ajouter.Visible = False
                    My_Message_Boxe.label_Modifier.Visible = True
                    My_Message_Boxe.Label1.Visible = False
                    My_Message_Boxe.Picture_ajouter.Visible = False
                    My_Message_Boxe.Picture_modifier.Visible = True
                    My_Message_Boxe.Picture_supp.Visible = False
                    My_Message_Boxe.Show()
                    ActualiserGrid()
                    Tcdenatserv.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub bsupprimer_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsupprimer.Click
        Try
            If MsgBox("vouler vous vraiment suprimer", 1 + 32, "confirmation") = MsgBoxResult.Ok Then
                natservicseM.supprimer(CInt(Tcdenatserv.Text))
                vider()
                My_Message_Boxe.Label_Ajouter.Visible = False
                My_Message_Boxe.label_Modifier.Visible = False
                My_Message_Boxe.Label1.Visible = True
                My_Message_Boxe.Picture_ajouter.Visible = False
                My_Message_Boxe.Picture_modifier.Visible = False
                My_Message_Boxe.Picture_supp.Visible = True
                My_Message_Boxe.Show()
                ActualiserGrid()
                Tcdenatserv.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ActualiserGrid()
        dgv1.DataSource = natservicseM.rechercher("1=1")
    End Sub
    Private Sub nature_de_service_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualiserGrid()
    End Sub
    Private Sub trechercher_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles trechercher.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez des Nombes ¡¡¡¡")
        End If
    End Sub
    Private Sub trechercher_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trechercher.TextChanged
        Dim condition As String = "1=1"



        If trechercher.Text <> "" Then
            condition = "cdenatserv=" & trechercher.Text
        Else
            condition = "1=1"
        End If


        dgv1.DataSource = natservicseM.rechercher(condition)
    End Sub

    Private Sub Tcdenatserv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tcdenatserv.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez des Nombes ¡¡¡¡")
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Left += 1
        If Label1.Location.X = 1234 Then
            Label1.Top = 10
            Label1.Left = 0
        End If
    End Sub

    Private Sub tservfr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tservfr.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un char ¡¡¡¡")
        End If
    End Sub

    Private Sub tservar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tservar.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un char ¡¡¡¡")
        End If
    End Sub
    Private Sub Btn_Annuler_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Annuler.Click
        vider()
        Tcdenatserv.Focus()
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class