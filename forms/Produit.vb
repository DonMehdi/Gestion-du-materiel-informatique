Public Class produits
    Public Sub vider()
        treferenceproduit.Clear()
        tcategorie.Clear()
        tproduit.Clear()

    End Sub
    Public Sub verification()
        If treferenceproduit.Text = "" Then
            ErrorProvider1.SetError(treferenceproduit, "Entrez le reference du produit")
        ElseIf Not IsNumeric(treferenceproduit.Text) Then
            ErrorProvider1.SetError(treferenceproduit, "entrez un nombre")
        Else
            ErrorProvider1.SetError(treferenceproduit, Nothing)
        End If
        If tcategorie.Text = "" Then
            ErrorProvider1.SetError(tcategorie, "entrez la categorie")
        Else
            ErrorProvider1.SetError(tcategorie, Nothing)
        End If
        If tproduit.Text = "" Then
            ErrorProvider1.SetError(tproduit, "entrez le produit")
        Else
            ErrorProvider1.SetError(tproduit, Nothing)
        End If

    End Sub
    Private Sub bajouter_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bajouter.Click
        Try
            If MsgBox("vouler vous vraiment ajouter", 1 + 32, "confirmation") = MsgBoxResult.Ok Then
                verification()
                If treferenceproduit.Text = "" Or tcategorie.Text = "" Or tproduit.Text = "" Then
                    MsgBox("Veuillez Remplire tout les champ")
                Else
                    Dim pr As New prod(CInt(treferenceproduit.Text), tcategorie.Text, tproduit.Text)
                    prodM.ajouter(pr)
                    vider()
                    My_Message_Boxe.Label_Ajouter.Visible = True
                    My_Message_Boxe.label_Modifier.Visible = False
                    My_Message_Boxe.Label1.Visible = False
                    My_Message_Boxe.Picture_ajouter.Visible = True
                    My_Message_Boxe.Picture_modifier.Visible = False
                    My_Message_Boxe.Picture_supp.Visible = False
                    My_Message_Boxe.Show()
                    ActualiserGrid()
                    treferenceproduit.Focus()
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
                If treferenceproduit.Text = "" Or tcategorie.Text = "" Or tproduit.Text = "" Then
                    MsgBox("Veuillez Remplire tout les champ")
                Else
                    Dim pr As New prod(CInt(treferenceproduit.Text), tcategorie.Text, tproduit.Text)
                    prodM.modifier(pr)
                    vider()
                    My_Message_Boxe.Label_Ajouter.Visible = False
                    My_Message_Boxe.label_Modifier.Visible = True
                    My_Message_Boxe.Label1.Visible = False
                    My_Message_Boxe.Picture_ajouter.Visible = False
                    My_Message_Boxe.Picture_modifier.Visible = True
                    My_Message_Boxe.Picture_supp.Visible = False
                    My_Message_Boxe.Show()
                    ActualiserGrid()
                    treferenceproduit.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub bsupprimer_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsupprimer.Click
        Try
            If MsgBox("vouler vous vraiment suprimer", 1 + 32, "confirmation") = MsgBoxResult.Ok Then
                prodM.supprimer(CInt(treferenceproduit.Text))
                vider()
                My_Message_Boxe.Label_Ajouter.Visible = False
                My_Message_Boxe.label_Modifier.Visible = False
                My_Message_Boxe.Label1.Visible = True
                My_Message_Boxe.Picture_ajouter.Visible = False
                My_Message_Boxe.Picture_modifier.Visible = False
                My_Message_Boxe.Picture_supp.Visible = True
                My_Message_Boxe.Show()
                ActualiserGrid()
                treferenceproduit.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub ActualiserGrid()
        dgv1.DataSource = prodM.rechercher("1=1")
    End Sub

  
   

    Private Sub produits_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualiserGrid()
    End Sub

    Private Sub trechercher_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trechercher.TextChanged
        Dim condition As String = "1=1"
        If trechercher.Text <> "" Then
            condition = "ref_produit=" & trechercher.Text
        Else
            condition = "1=1"
        End If

        dgv1.DataSource = prodM.rechercher(condition)
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Left += 1
        If Label1.Location.X = 1234 Then
            Label1.Top = 10
            Label1.Left = 0
        End If
    End Sub

    Private Sub treferenceproduit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles treferenceproduit.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un Nombre ¡¡¡¡")
        End If
    End Sub

    Private Sub tcategorie_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tcategorie.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un char ¡¡¡¡")
        End If
    End Sub

    Private Sub tproduit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tproduit.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("¡¡¡¡ Entrez un char ¡¡¡¡")
        End If
    End Sub
    Private Sub Btn_Annuler_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Annuler.Click
        vider()
        tproduit.Focus()
    End Sub
End Class