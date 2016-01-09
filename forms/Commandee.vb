Imports System.Data
Imports System.Data.SqlClient
Public Class Commandee
    Private Sub ActualiserGrid()
        dgv1.DataSource = commandeM.rechercher("1=1")
    End Sub
    Public Sub vider()
        Txt_n_marchbc.Clear()
        Txt_Exerc.Clear()
        Txt_Observ.Clear()
        Txt_Montant.Clear()
        txt_chapitre.Clear()
        txt_ligne.Clear()
        Txt_nature_credi.Clear()
        Txt_nature_presenta.Clear()
        txt_objectif_depen.Clear()
        txt_paragraphe.Clear()
        txt_region.Clear()
        Txt_rubrique.Clear()
    End Sub
    Public Sub verification()
        If Txt_n_marchbc.Text = "" Then
            ErrorProvider1.SetError(Txt_n_marchbc, "entrez le numero de commande")
        Else
            ErrorProvider1.SetError(Txt_n_marchbc, Nothing)
        End If
        If Txt_Observ.Text = "" Then
            ErrorProvider1.SetError(Txt_Observ, "entrez l'observation")
        Else
            ErrorProvider1.SetError(Txt_Observ, Nothing)
        End If
        If Txt_Exerc.Text = "" Then
            ErrorProvider1.SetError(Txt_Exerc, "entrez l'exercice")
        Else
            ErrorProvider1.SetError(Txt_Exerc, Nothing)
        End If
        If Txt_Montant.Text = "" Then
            ErrorProvider1.SetError(Txt_Montant, "entrez le Montant")
        ElseIf Not IsNumeric(Txt_Montant.Text) Then
            ErrorProvider1.SetError(Txt_Montant, "entrez un nombre")
        Else
            ErrorProvider1.SetError(Txt_Montant, Nothing)
        End If
    End Sub
    Private Sub Btn_ajoute_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ajoute.Click
        Try
            If MsgBox("vouler vous vraiment ajouter", 1 + 32, "confirmation") = MsgBoxResult.Ok Then
                verification()
                If Txt_n_marchbc.Text = "" Or Txt_Observ.Text = "" Or Txt_Exerc.Text = "" Or Txt_Montant.Text = "" Or Txt_rubrique.Text = "" Or Txt_nature_credi.Text = "" Or txt_objectif_depen.Text = "" Or Txt_nature_presenta.Text = "" Or txt_ligne.Text = "" Or txt_paragraphe.Text = "" Or txt_chapitre.Text = "" Or Txt_rubrique.Text = "" Then
                    MsgBox("Veuillez Remplire tout les champs")
                Else
                    Dim c As New commandes(CInt(Txt_n_marchbc.Text), Txt_Exerc.Text, Txt_Observ.Text, Txt_Montant.Text, Cmb_cdeFournisseur.Text, cmb_typebudget.Text, Txt_rubrique.Text, Txt_nature_credi.Text, txt_objectif_depen.Text, Txt_nature_presenta.Text, txt_ligne.Text, txt_paragraphe.Text, txt_chapitre.Text, Txt_rubrique.Text)
                    commandeM.ajouter(c)
                    vider()
                    My_Message_Boxe.Label_Ajouter.Visible = True
                    My_Message_Boxe.label_Modifier.Visible = False
                    My_Message_Boxe.Label1.Visible = False
                    My_Message_Boxe.Picture_ajouter.Visible = True
                    My_Message_Boxe.Picture_modifier.Visible = False
                    My_Message_Boxe.Picture_supp.Visible = False
                    My_Message_Boxe.Show()
                    ActualiserGrid()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub Btn_modifier_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_modifier.Click
        Try
            If MsgBox("vouler vous vraiment modifier", 1 + 32, "confirmation") = MsgBoxResult.Ok Then
                verification()
                If Txt_n_marchbc.Text = "" Or Txt_Observ.Text = "" Or Txt_Exerc.Text = "" Or Txt_Montant.Text = "" Or Txt_rubrique.Text = "" Or Txt_nature_credi.Text = "" Or txt_objectif_depen.Text = "" Or Txt_nature_presenta.Text = "" Or txt_ligne.Text = "" Or txt_paragraphe.Text = "" Or txt_chapitre.Text = "" Or Txt_rubrique.Text = "" Then
                    MsgBox("Veuillez Remplire tout les champs")
                Else
                    Dim c As New commandes(CInt(Txt_n_marchbc.Text), Txt_Exerc.Text, Txt_Observ.Text, Txt_Montant.Text, Cmb_cdeFournisseur.Text, cmb_typebudget.Text, Txt_rubrique.Text, Txt_nature_credi.Text, txt_objectif_depen.Text, Txt_nature_presenta.Text, txt_ligne.Text, txt_paragraphe.Text, txt_chapitre.Text, Txt_rubrique.Text)
                    commandeM.modifier(c)
                    vider()
                    My_Message_Boxe.Label_Ajouter.Visible = False
                    My_Message_Boxe.label_Modifier.Visible = True
                    My_Message_Boxe.Label1.Visible = False
                    My_Message_Boxe.Picture_ajouter.Visible = False
                    My_Message_Boxe.Picture_modifier.Visible = True
                    My_Message_Boxe.Picture_supp.Visible = False
                    My_Message_Boxe.Show()
                    ActualiserGrid()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub Btn_supprime_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_supprime.Click
        Try
            If MsgBox("voulez-vous vraiment suppimer", 0 + 32, "Confimation") = MsgBoxResult.Ok Then
                commandeM.supprimer(CInt(Txt_n_marchbc.Text))
                vider()
                My_Message_Boxe.Label_Ajouter.Visible = False
                My_Message_Boxe.label_Modifier.Visible = False
                My_Message_Boxe.Label1.Visible = True
                My_Message_Boxe.Picture_ajouter.Visible = False
                My_Message_Boxe.Picture_modifier.Visible = False
                My_Message_Boxe.Picture_supp.Visible = True
                My_Message_Boxe.Show()
                ActualiserGrid()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_annuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_annuler.Click
        vider()
        Tnºmarchebc.Focus()
    End Sub
    Private Sub Commandee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualiserGrid()
        Cmb_cdeFournisseur.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_typebudget.DropDownStyle = ComboBoxStyle.DropDownList
        Dim req As String = "select * from type_budge  "
        Dim dr As SqlDataReader = connexion.extract(req)
        If dr.HasRows Then
            While dr.Read
                cmb_typebudget.Items.Add(dr(1))
            End While
        End If
        dr.Close()
        Dim re As String = "select * from fournisseur  "
        Dim dtr As SqlDataReader = connexion.extract(re)
        If dtr.HasRows Then
            While dtr.Read 'ba9i des blocs à lire
                Cmb_cdeFournisseur.Items.Add(dtr(0))
            End While
        End If
        dtr.Close()
    End Sub
    Private Sub Tnºmarchebc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tnºmarchebc.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un numero ¡¡¡¡")
        End If
    End Sub
    Private Sub Tnºmarchebc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tnºmarchebc.TextChanged
        Dim condit As String = "1=1"
        If Tnºmarchebc.Text <> "" Then
            condit = "N_mar_BC=" & Tnºmarchebc.Text
        Else
            condit = "1=1"
        End If
        dgv1.DataSource = commandeM.rechercher(condit)
    End Sub
    Private Sub Txt_n_marchbc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_n_marchbc.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un numero ¡¡¡¡")
        End If
    End Sub
    Private Sub Txt_Montant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Montant.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un numero ¡¡¡¡")
        End If
    End Sub

    Private Sub Txt_Exerc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Exerc.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un char ¡¡¡¡")
        End If
    End Sub

    Private Sub Txt_Observ_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Observ.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un char ¡¡¡¡")
        End If
    End Sub

    Private Sub Txt_rubrique_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_rubrique.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un char ¡¡¡¡")
        End If
    End Sub

    Private Sub Txt_nature_credi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_nature_credi.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un char ¡¡¡¡")
        End If
    End Sub

    Private Sub Txt_nature_presenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_nature_presenta.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un char ¡¡¡¡")
        End If
    End Sub

    Private Sub txt_objectif_depen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_objectif_depen.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un char ¡¡¡¡")
        End If
    End Sub

    Private Sub txt_ligne_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ligne.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un numero ¡¡¡¡")
        End If
    End Sub

    Private Sub txt_paragraphe_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_paragraphe.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un numero ¡¡¡¡")
        End If
    End Sub

    Private Sub txt_chapitre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_chapitre.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un numero ¡¡¡¡")
        End If
    End Sub

    Private Sub txt_region_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_region.KeyPress
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

   
 
   
   
   
  
   
   














    Private Sub Lbl_rubriq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbl_rubriq.Click

    End Sub
    Private Sub Lbl_cdfourmiss_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbl_cdfourmiss.Click

    End Sub

    Private Sub txt_ligne_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ligne.TextChanged

    End Sub

    Private Sub Txt_n_marchbc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_n_marchbc.TextChanged

    End Sub

    Private Sub dgv1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub

    Private Sub Cmb_cdeFournisseur_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_cdeFournisseur.SelectedIndexChanged

    End Sub
End Class