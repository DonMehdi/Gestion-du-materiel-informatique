Imports System.Data
Imports System.Data.SqlClient
Public Class inventaire

    Public Sub vider()
        Tcodeinventaire.Clear()
        thistorique.Clear()
        tnfactt.Clear()
        tnbl.Clear()
        tmr.Clear()
    End Sub
    Public Sub verification()
        If Tcodeinventaire.Text = "" Then
            ErrorProvider1.SetError(Tcodeinventaire, "entrez le code")
        Else
            ErrorProvider1.SetError(Tcodeinventaire, Nothing)
        End If
        If tmr.Text = "" Then
            ErrorProvider1.SetError(tmr, "entrez la motiv Radiation")
        Else
            ErrorProvider1.SetError(tmr, Nothing)
        End If
        If thistorique.Text = "" Then
            ErrorProvider1.SetError(thistorique, "entrez l'historique")
        Else
            ErrorProvider1.SetError(thistorique, Nothing)
        End If
        If tnbl.Text = "" Then
            ErrorProvider1.SetError(tnbl, "entrez le nombre bl")
        Else
            ErrorProvider1.SetError(tnbl, Nothing)
        End If
        If tnfactt.Text = "" Then
            ErrorProvider1.SetError(tnfactt, "entrez la facture")
        Else
            ErrorProvider1.SetError(tnfactt, Nothing)
        End If
    End Sub
    Private Sub bajouter_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bajouter.Click
        Try
            If MsgBox("vouler vous vraiment ajouter", 1 + 32, "confirmation") = MsgBoxResult.Ok Then
                verification()
                If Tcodeinventaire.Text = "" Or tnbl.Text = "" Or tnfactt.Text = "" Or tmr.Text = "" Or thistorique.Text = "" Then
                    MsgBox("Veuillez remplire tout les champs")
                Else
                    Dim inv As New inventaires(CInt(Tcodeinventaire.Text), DateTimePicker1.Value, thistorique.Text, cexercice.Text, CInt(cnarticle.Text), CInt(cncommande.Text), CInt(ccde.Text), tnfactt.Text, tnbl.Text, tmr.Text, DateTimePicker2.Value)
                    inventaireM.ajouter(inv)
                    My_Message_Boxe.Label_Ajouter.Visible = True
                    My_Message_Boxe.label_Modifier.Visible = False
                    My_Message_Boxe.Label1.Visible = False
                    My_Message_Boxe.Picture_ajouter.Visible = True
                    My_Message_Boxe.Picture_modifier.Visible = False
                    My_Message_Boxe.Picture_supp.Visible = False
                    My_Message_Boxe.Show()
                    vider()
                    ActualiserGrid()
                    Tcodeinventaire.Focus()
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
                If Tcodeinventaire.Text = "" Or tmr.Text = "" Or thistorique.Text = "" Or tnbl.Text = "" Or tnfactt.Text = "" Then
                    MsgBox("Veuillez Remplire tout les champs ")
                Else
                    Dim inv As New inventaires(CInt(Tcodeinventaire.Text), DateTimePicker1.Value, thistorique.Text, cexercice.Text, CInt(cnarticle.Text), CInt(cncommande.Text), CInt(ccde.Text), tnfactt.Text, tnbl.Text, tmr.Text, CType(DateTimePicker2.Value, Date))
                    inventaireM.modifier(inv)
                    vider()
                    My_Message_Boxe.Label_Ajouter.Visible = False
                    My_Message_Boxe.label_Modifier.Visible = True
                    My_Message_Boxe.Label1.Visible = False
                    My_Message_Boxe.Picture_ajouter.Visible = False
                    My_Message_Boxe.Picture_modifier.Visible = True
                    My_Message_Boxe.Picture_supp.Visible = False
                    My_Message_Boxe.Show()
                    ActualiserGrid()
                    Tcodeinventaire.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bsupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsupprimer.Click
        Try
            If MsgBox("vouler vous vraiment suprimer", 1 + 32, "confirmation") = MsgBoxResult.Ok Then
                inventaireM.supprimer(CInt(Tcodeinventaire.Text))
                vider()
                My_Message_Boxe.Label_Ajouter.Visible = False
                My_Message_Boxe.label_Modifier.Visible = False
                My_Message_Boxe.Label1.Visible = True
                My_Message_Boxe.Picture_ajouter.Visible = False
                My_Message_Boxe.Picture_modifier.Visible = False
                My_Message_Boxe.Picture_supp.Visible = True
                My_Message_Boxe.Show()
                ActualiserGrid()
                Tcodeinventaire.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
   
    Private Sub ActualiserGrid()
        dgv1.DataSource = inventaireM.rechercher("1=1")
    End Sub
    Private Sub grid()
        dgv2.DataSource = detailM.rechercher("1=1")
    End Sub
    Private Sub datagridview()
        DataGridView1.DataSource = commandeM.rechercher("1=1")
    End Sub
    Private Sub inventaire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualiserGrid()
        grid()
        datagridview()
        Dim req As String = "select * from detailmarcheBC  "

        Dim dr As SqlDataReader = connexion.extract(req)


        If dr.HasRows Then
            While dr.Read
                cncommande.Items.Add(dr(6))
            End While

        End If
        dr.Close()
        Dim rqeq As String = "select * from detailmarcheBC  "

        Dim dtr As SqlDataReader = connexion.extract(rqeq)


        If dtr.HasRows Then
            While dtr.Read
                cexercice.Items.Add(dtr(7))
            End While

        End If
        dtr.Close()
        Dim rqe As String = "select * from detailmarcheBC  "

        Dim d As SqlDataReader = connexion.extract(rqe)


        If d.HasRows Then
            While d.Read
                cnarticle.Items.Add(d(0))
            End While

        End If
        d.Close()
        Dim q As String = "select * from division_services  "

        Dim t As SqlDataReader = connexion.extract(q)


        If t.HasRows Then
            While t.Read
                ccde.Items.Add(t(0))
            End While

        End If
        t.Close()
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
            condition = "num_invantaire=" & trechercher.Text
        Else
            condition = "1=1"
        End If
        dgv1.DataSource = inventaireM.rechercher(condition)
    End Sub

    Private Sub tmr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tmr.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un char ¡¡¡¡")
        End If
    End Sub

    Private Sub Tcodeinventaire_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tcodeinventaire.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez des Nombes ¡¡¡¡")
        End If
    End Sub

    Private Sub thistorique_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles thistorique.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un char ¡¡¡¡")
        End If
    End Sub

    Private Sub tnfactt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tnfactt.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez des Nombes ¡¡¡¡")
        End If
    End Sub

    Private Sub tnbl_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tnbl.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez des Nombes ¡¡¡¡")
        End If
    End Sub
    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Left += 1
        If Label1.Location.X = 1234 Then
            Label1.Top = 10
            Label1.Left = 0
        End If
    End Sub
    Private Sub Btn_Annuler_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Annuler.Click
        vider()
        Tcodeinventaire.Focus()
    End Sub
End Class