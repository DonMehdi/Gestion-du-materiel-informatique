Imports System.Data
Imports System.Data.SqlClient
Public Class fournisseur
    Public Sub vider()
        tcodefournisseur.Clear()
        tfournisseur.Clear()
        tfournisseurabr.Clear()
        Tacivite.Clear()
        ttypeste.Clear()
        ttel.Clear()
        tgsm.Clear()
        tfax.Clear()
        tinterlocuteur.Clear()
        tpatente.Clear()
        tadresse.Clear()
        tcodepostale.Clear()
        tville.Clear()
        tbanque.Clear()
        tagence.Clear()
        trip.Clear()
        temail.Clear()
        tcodefournisseur.Focus()
    End Sub
    Public Sub verification()
        If tcodefournisseur.Text = "" Then
            ErrorProvider1.SetError(tcodefournisseur, "entrez le code")
        ElseIf Not IsNumeric(tcodefournisseur.Text) Then
            ErrorProvider1.SetError(tcodefournisseur, "entrez un nombre")
        Else
            ErrorProvider1.SetError(tcodefournisseur, Nothing)
        End If
        If ttypeste.Text = "" Then
            ErrorProvider1.SetError(ttypeste, "entrez le type de societer")
        Else
            ErrorProvider1.SetError(ttypeste, Nothing)
        End If
        If tfax.Text = "" Then
            ErrorProvider1.SetError(tfax, "entrez le Fax ")
        ElseIf Not IsNumeric(tfax.Text) Then
            ErrorProvider1.SetError(tfax, "entrez le numero de fax ")
        Else
            ErrorProvider1.SetError(tfax, Nothing)
        End If
        If tville.Text = "" Then
            ErrorProvider1.SetError(tville, "entrez la ville")
        Else
            ErrorProvider1.SetError(tville, Nothing)
        End If
        If tagence.Text = "" Then
            ErrorProvider1.SetError(tagence, "entrez l'agence")
        Else
            ErrorProvider1.SetError(tagence, Nothing)
        End If
        If tbanque.Text = "" Then
            ErrorProvider1.SetError(tbanque, "entrez la banque")
        Else
            ErrorProvider1.SetError(tbanque, Nothing)
        End If
        If tfournisseur.Text = "" Then
            ErrorProvider1.SetError(tfournisseur, "entrez le fournisseur")
        Else
            ErrorProvider1.SetError(tfournisseur, Nothing)
        End If
        If ttel.Text = "" Then
            ErrorProvider1.SetError(ttel, "entrez le numero de telephone")
        Else
            ErrorProvider1.SetError(ttel, Nothing)
        End If
        If tinterlocuteur.Text = "" Then
            ErrorProvider1.SetError(tinterlocuteur, "entrez l'interlocuteur")
        Else
            ErrorProvider1.SetError(tinterlocuteur, Nothing)
        End If
        If tadresse.Text = "" Then
            ErrorProvider1.SetError(tadresse, "entrez l'adresse")
        Else
            ErrorProvider1.SetError(tadresse, Nothing)
        End If
        If temail.Text = "" Then
            ErrorProvider1.SetError(temail, "entrez l'email")
        Else
            ErrorProvider1.SetError(temail, Nothing)
        End If
        If tfournisseurabr.Text = "" Then
            ErrorProvider1.SetError(tfournisseurabr, "entrez le fournisseurabr")
        Else
            ErrorProvider1.SetError(tfournisseurabr, Nothing)
        End If
        If tgsm.Text = "" Then
            ErrorProvider1.SetError(tgsm, "entrez le numero de GSM")
        Else
            ErrorProvider1.SetError(tgsm, Nothing)
        End If
        If tpatente.Text = "" Then
            ErrorProvider1.SetError(tpatente, "entrez le patente")
        Else
            ErrorProvider1.SetError(tpatente, Nothing)
        End If
        If tcodepostale.Text = "" Then
            ErrorProvider1.SetError(tcodepostale, "entrez le code postale")
        ElseIf Not IsNumeric(tcodepostale.Text) Then
            ErrorProvider1.SetError(tcodepostale, "entrez un code")
        Else
            ErrorProvider1.SetError(tcodepostale, Nothing)
        End If
        If Tacivite.Text = "" Then
            ErrorProvider1.SetError(Tacivite, "entrez l'acivite")
        Else
            ErrorProvider1.SetError(Tacivite, Nothing)
        End If
        If trip.Text = "" Then
            ErrorProvider1.SetError(trip, "entrez la rip")
        Else
            ErrorProvider1.SetError(trip, Nothing)
        End If
    End Sub
    Private Sub bajouter_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bajouter.Click
        Try
            If MsgBox("vouler vous vraiment ajouter", 1 + 32, "confirmation") = MsgBoxResult.Ok Then
                verification()
                If tcodefournisseur.Text = "" Or ttypeste.Text = "" Or tfax.Text = "" Or tville.Text = "" Or tagence.Text = "" Or tbanque.Text = "" Or tfournisseur.Text = "" Or ttel.Text = "" Or tinterlocuteur.Text = "" Or tadresse.Text = "" Or temail.Text = "" Or tfournisseurabr.Text = "" Or tgsm.Text = "" Or tpatente.Text = "" Or tcodepostale.Text = "" Or Tacivite.Text = "" Or trip.Text = "" Then
                    MsgBox("Veuillez Remplire tout les champs")
                Else
                    Dim fr As New fournisseurs(CInt(tcodefournisseur.Text), tfournisseur.Text, tfournisseurabr.Text, Tacivite.Text, ttypeste.Text, ttel.Text, tgsm.Text, tfax.Text, tinterlocuteur.Text, tpatente.Text, tadresse.Text, tcodepostale.Text, tville.Text, tbanque.Text, tagence.Text, trip.Text, temail.Text)
                    fournisseurM.ajouter(fr)
                    vider()
                    My_Message_Boxe.Label_Ajouter.Visible = True
                    My_Message_Boxe.label_Modifier.Visible = False
                    My_Message_Boxe.Label1.Visible = False
                    My_Message_Boxe.Picture_ajouter.Visible = True
                    My_Message_Boxe.Picture_modifier.Visible = False
                    My_Message_Boxe.Picture_supp.Visible = False
                    My_Message_Boxe.Show()
                    ActualiserGrid()
                    tcodefournisseur.Focus()
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
                If tcodefournisseur.Text = "" Or ttypeste.Text = "" Or tfax.Text = "" Or tville.Text = "" Or tagence.Text = "" Or tbanque.Text = "" Or tfournisseur.Text = "" Or ttel.Text = "" Or tinterlocuteur.Text = "" Or tadresse.Text = "" Or temail.Text = "" Or tfournisseurabr.Text = "" Or tgsm.Text = "" Or tpatente.Text = "" Or tcodepostale.Text = "" Or Tacivite.Text = "" Or trip.Text = "" Then
                    MsgBox("Veuillez Remplire tout les champs")
                Else
                    Dim fr As New fournisseurs(CInt(tcodefournisseur.Text), tfournisseur.Text, tfournisseurabr.Text, Tacivite.Text, ttypeste.Text, ttel.Text, tgsm.Text, tfax.Text, tinterlocuteur.Text, tpatente.Text, tadresse.Text, tcodepostale.Text, tville.Text, tbanque.Text, tagence.Text, trip.Text, temail.Text)
                    fournisseurM.modifier(fr)
                    vider()
                    My_Message_Boxe.Label_Ajouter.Visible = False
                    My_Message_Boxe.label_Modifier.Visible = True
                    My_Message_Boxe.Label1.Visible = False
                    My_Message_Boxe.Picture_ajouter.Visible = False
                    My_Message_Boxe.Picture_modifier.Visible = True
                    My_Message_Boxe.Picture_supp.Visible = False
                    My_Message_Boxe.Show()
                    ActualiserGrid()
                    tcodefournisseur.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub bsupprimer_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsupprimer.Click
        Try
            If MsgBox("vouler vous vraiment suprimer", 1 + 32, "confirmation") = MsgBoxResult.Ok Then
                fournisseurM.supprimer(CInt(tcodefournisseur.Text))
                vider()
                My_Message_Boxe.Label_Ajouter.Visible = False
                My_Message_Boxe.label_Modifier.Visible = False
                My_Message_Boxe.Label1.Visible = True
                My_Message_Boxe.Picture_ajouter.Visible = False
                My_Message_Boxe.Picture_modifier.Visible = False
                My_Message_Boxe.Picture_supp.Visible = True
                My_Message_Boxe.Show()
                ActualiserGrid()
                tcodefournisseur.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
   
    Private Sub ActualiserGrid()
        dgv1.DataSource = fournisseurM.rechercher("1=1")
    End Sub

    Private Sub fournisseur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualiserGrid()
    End Sub
    Private Sub tcodefournisseur_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tcodefournisseur.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez des Nombes ¡¡¡¡")
        End If
    End Sub

    Private Sub tfournisseur_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tfournisseur.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un char ¡¡¡¡")
        End If
    End Sub

    Private Sub tfournisseurabr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tfournisseurabr.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un char ¡¡¡¡")
        End If
    End Sub

    Private Sub ttypeste_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ttypeste.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un char ¡¡¡¡")
        End If
    End Sub

    Private Sub ttel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ttel.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un numero ¡¡¡¡")
        End If
    End Sub

    Private Sub tgsm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tgsm.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un numero ¡¡¡¡")
        End If
    End Sub

    Private Sub tfax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tfax.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un numero ¡¡¡¡")
        End If
    End Sub

    Private Sub tinterlocuteur_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tinterlocuteur.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un char ¡¡¡¡")
        End If
    End Sub

    Private Sub tpatente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tpatente.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un numero ¡¡¡¡")
        End If
    End Sub

    Private Sub tville_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tville.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un char ¡¡¡¡")
        End If
    End Sub

    Private Sub tcodepostale_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tcodepostale.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un numero ¡¡¡¡")
        End If
    End Sub

    Private Sub tagence_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tagence.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un char ¡¡¡¡")
        End If
    End Sub

    Private Sub Tacivite_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tacivite.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un char ¡¡¡¡")
        End If
    End Sub

    Private Sub tbanque_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbanque.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un char ¡¡¡¡")
        End If
    End Sub

    Private Sub trip_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles trip.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un char ¡¡¡¡")
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Left += 1
        If Label1.Location.X = 1234 Then
            Label1.Top = 10
            Label1.Left = 0
        End If
    End Sub
    Private Sub trechercher_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trechercher.TextChanged
        Dim condition As String = "1=1"


        If rfourni.Checked Then
            condition = "fournisseur like '%" & trechercher.Text & "%'"
        ElseIf Rcode.Checked Then
            If trechercher.Text <> "" Then
                condition = "code_fournisseur=" & trechercher.Text
            Else
                condition = "1=1"
            End If

        End If
        dgv1.DataSource = fournisseurM.rechercher(condition)
    End Sub
    Private Sub Btn_annuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_annuler.Click
        vider()
        tcodefournisseur.Focus()
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub ttypeste_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ttypeste.TextChanged

    End Sub
End Class