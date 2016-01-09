Imports System.Data.SqlClient
Imports System.Data
Public Class detail_commande
    Public Sub vider()
        Tnartcle.Clear()
        tprixunitaire.Clear()
        tdesignation.Clear()
        tqte.Clear()
        tremarques.Clear()
    End Sub
    Private Sub Grid()
        dataGridView.DataSource = detailM.rechercher("1=1")
    End Sub
    Public Sub verification()
        If Tnartcle.Text = "" Then
            ErrorProvider1.SetError(Tnartcle, "entrez le numero d'article")
        ElseIf Not IsNumeric(Tnartcle.Text) Then
            ErrorProvider1.SetError(Tnartcle, "entrez un nombre")
        Else
            ErrorProvider1.SetError(Tnartcle, Nothing)
        End If
        If tprixunitaire.Text = "" Then
            ErrorProvider1.SetError(tprixunitaire, "entrez le prix unitaire")
        ElseIf Not IsNumeric(tprixunitaire.Text) Then
            ErrorProvider1.SetError(tprixunitaire, "entrez un nombre")
        Else
            ErrorProvider1.SetError(tprixunitaire, Nothing)
        End If
        If tqte.Text = "" Then
            ErrorProvider1.SetError(tqte, "entrez la Quantite")
        ElseIf Not IsNumeric(tqte.Text) Then
            ErrorProvider1.SetError(tqte, "entrez un nombre")
        Else
            ErrorProvider1.SetError(tqte, Nothing)
        End If
        If tdesignation.Text = "" Then
            ErrorProvider1.SetError(tdesignation, "entrez la designation")
        Else
            ErrorProvider1.SetError(tdesignation, Nothing)
        End If
        If tremarques.Text = "" Then
            ErrorProvider1.SetError(tremarques, "entrez une remarque")
        Else
            ErrorProvider1.SetError(tremarques, Nothing)
        End If
    End Sub
    Private Sub bajouter_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bajouter.Click
        Try
            If MsgBox("vouler vous vraiment ajouter", 1 + 32, "confirmation") = MsgBoxResult.Ok Then
                verification()
                If Tnartcle.Text = "" Or tprixunitaire.Text = "" Or tqte.Text = "" Or tdesignation.Text = "" Or tremarques.Text = "" Then
                    MsgBox("Veuillez remplire tout les champs")
                Else
                    Dim dc As New détail_commandes(CInt(Tnartcle.Text), tprixunitaire.Text, tdesignation.Text, tqte.Text, tremarques.Text, CInt(creferenceproduit.Text), CInt(cncommande.Text), cexercice.Text)
                    detailM.ajouter(dc)
                    vider()
                    My_Message_Boxe.Label_Ajouter.Visible = True
                    My_Message_Boxe.label_Modifier.Visible = False
                    My_Message_Boxe.Label1.Visible = False
                    My_Message_Boxe.Picture_ajouter.Visible = True
                    My_Message_Boxe.Picture_modifier.Visible = False
                    My_Message_Boxe.Picture_supp.Visible = False
                    My_Message_Boxe.Show()
                    Grid()
                    Tnartcle.Focus()
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
                If Tnartcle.Text = "" Or tprixunitaire.Text = "" Or tqte.Text = "" Or tdesignation.Text = "" Or tremarques.Text = "" Then
                    MsgBox("Veuillez remplire tout les champs")
                Else
                    Dim dc As New détail_commandes(CInt(Tnartcle.Text), tprixunitaire.Text, tdesignation.Text, tqte.Text, tremarques.Text, CInt(creferenceproduit.Text), CInt(cncommande.Text), cexercice.Text)
                    detailM.Modifier(dc)
                    vider()
                    My_Message_Boxe.Label_Ajouter.Visible = False
                    My_Message_Boxe.label_Modifier.Visible = True
                    My_Message_Boxe.Label1.Visible = False
                    My_Message_Boxe.Picture_ajouter.Visible = False
                    My_Message_Boxe.Picture_modifier.Visible = True
                    My_Message_Boxe.Picture_supp.Visible = False
                    My_Message_Boxe.Show()
                    Grid()
                    Tnartcle.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub bsupprimer_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsupprimer.Click
        Try
            If MsgBox("vouler vous vraiment suprimer", 1 + 32, "confirmation") = MsgBoxResult.Ok Then
                detailM.supprimer(CInt(Tnartcle.Text))
                vider()
                My_Message_Boxe.Label_Ajouter.Visible = False
                My_Message_Boxe.label_Modifier.Visible = False
                My_Message_Boxe.Label1.Visible = True
                My_Message_Boxe.Picture_ajouter.Visible = False
                My_Message_Boxe.Picture_modifier.Visible = False
                My_Message_Boxe.Picture_supp.Visible = True
                My_Message_Boxe.Show()
                Grid()
                Tnartcle.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub detail_commande_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Grid()
        Dim req As String = "select * from marcheBC   "
        Dim dr As SqlDataReader = connexion.extract(req)
        If dr.HasRows Then
            While dr.Read
                cncommande.Items.Add(dr(0))
            End While
        End If
        dr.Close()
        Dim re As String = "select * from marcheBC  "
        Dim dtr As SqlDataReader = connexion.extract(re)
        If dtr.HasRows Then
            While dtr.Read
                cexercice.Items.Add(dtr(1))
            End While
        End If
        dtr.Close()
        Dim rq As String = "select * from produit  "

        Dim d As SqlDataReader = connexion.extract(rq)


        If d.HasRows Then
            While d.Read
                creferenceproduit.Items.Add(d(0))
            End While

        End If
        d.Close()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Left += 1
        If Label1.Location.X = 1234 Then
            Label1.Top = 10
            Label1.Left = 0
        End If
    End Sub

    Private Sub Tnartcle_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tnartcle.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un numero ¡¡¡¡")
        End If
    End Sub

    Private Sub tprixunitaire_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tprixunitaire.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un numero ¡¡¡¡")
        End If
    End Sub

    Private Sub tqte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tqte.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un numero ¡¡¡¡")
        End If
    End Sub

    Private Sub tdesignation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdesignation.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un char ¡¡¡¡")
        End If
    End Sub

    Private Sub tremarques_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tremarques.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un char ¡¡¡¡")
        End If
    End Sub
    Private Sub Btn_Annuler_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Annuler.Click
        vider()
        Tnartcle.Focus()
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un numero ¡¡¡¡")
        End If
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim condit As String = "1=1"
        If Tnartcle.Text <> "" Then
            condit = "num_article=" & Tnartcle.Text
        Else
            condit = "1=1"
        End If
        dataGridView.DataSource = detailM.rechercher(condit)
        TextBox1.Focus()
    End Sub

  
End Class