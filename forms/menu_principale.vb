Public Class menu_principale

    Private Sub menu_principale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Visible = False
    End Sub

    Private Sub AjouterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterToolStripMenuItem.Click
        Commandee.Show()
        Commandee.MdiParent = Me
        Commandee.WindowState = FormWindowState.Maximized
        Commandee.Btn_ajoute.Visible = True
        Commandee.Btn_supprime.Visible = False
        Commandee.Btn_modifier.Visible = False
        Commandee.GroupBox1.Visible = False
        Label1.Visible = False

    End Sub

    Private Sub SupprimerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerToolStripMenuItem.Click
        Commandee.Show()
        Commandee.MdiParent = Me
        Commandee.WindowState = FormWindowState.Maximized
        Commandee.Btn_ajoute.Visible = False
        Commandee.Btn_supprime.Visible = True
        Commandee.Btn_modifier.Visible = False
        Commandee.GroupBox1.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub ModifierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierToolStripMenuItem.Click
        Commandee.Show()
        Commandee.MdiParent = Me
        Commandee.WindowState = FormWindowState.Maximized
        Commandee.Btn_ajoute.Visible = False
        Commandee.Btn_supprime.Visible = False
        Commandee.Btn_modifier.Visible = True
        Commandee.GroupBox1.Visible = False
        Label1.Visible = False
    End Sub
    Private Sub RechercherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RechercherToolStripMenuItem.Click
        Commandee.Show()
        Commandee.MdiParent = Me
        Commandee.WindowState = FormWindowState.Maximized
        Commandee.Btn_ajoute.Visible = False
        Commandee.Btn_supprime.Visible = False
        Commandee.Btn_modifier.Visible = False
        Commandee.btn_annuler.Visible = False
        Commandee.GroupBox1.Visible = True
        Label1.Visible = False
    End Sub
    Private Sub FERMERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FERMERToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AjouterToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterToolStripMenuItem1.Click
        detail_commande.Show()
        detail_commande.MdiParent = Me
        detail_commande.WindowState = FormWindowState.Maximized
        detail_commande.bajouter.Visible = True
        detail_commande.bsupprimer.Visible = False
        detail_commande.bmodifier.Visible = False
        detail_commande.GroboxRechercher.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub SupprimerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerToolStripMenuItem1.Click
        detail_commande.Show()
        detail_commande.MdiParent = Me
        detail_commande.WindowState = FormWindowState.Maximized
        detail_commande.bajouter.Visible = False
        detail_commande.bsupprimer.Visible = True
        detail_commande.bmodifier.Visible = False
        detail_commande.GroboxRechercher.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub ModifierToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierToolStripMenuItem1.Click
        detail_commande.Show()
        detail_commande.MdiParent = Me
        detail_commande.WindowState = FormWindowState.Maximized
        detail_commande.bajouter.Visible = False
        detail_commande.bsupprimer.Visible = False
        detail_commande.bmodifier.Visible = True
        detail_commande.GroboxRechercher.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub AjouToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouToolStripMenuItem.Click
        fournisseur.Show()
        fournisseur.MdiParent = Me
        fournisseur.WindowState = FormWindowState.Maximized
        fournisseur.bajouter.Visible = True
        fournisseur.bsupprimer.Visible = False
        fournisseur.bmodifier.Visible = False
        fournisseur.GroupBox1.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub SupprimerToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerToolStripMenuItem2.Click
        fournisseur.Show()
        fournisseur.MdiParent = Me
        fournisseur.WindowState = FormWindowState.Maximized
        fournisseur.bajouter.Visible = False
        fournisseur.bsupprimer.Visible = True
        fournisseur.bmodifier.Visible = False
        fournisseur.GroupBox1.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub ModifierToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierToolStripMenuItem2.Click
        fournisseur.Show()
        fournisseur.MdiParent = Me
        fournisseur.WindowState = FormWindowState.Maximized
        fournisseur.bajouter.Visible = False
        fournisseur.bsupprimer.Visible = False
        fournisseur.bmodifier.Visible = True
        fournisseur.GroupBox1.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub RechercherToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RechercherToolStripMenuItem1.Click
        fournisseur.Show()
        fournisseur.MdiParent = Me
        fournisseur.WindowState = FormWindowState.Maximized
        fournisseur.bajouter.Visible = False
        fournisseur.bsupprimer.Visible = False
        fournisseur.bmodifier.Visible = False
        fournisseur.Btn_annuler.Visible = False
        fournisseur.GroupBox1.Visible = True
        Label1.Visible = False
    End Sub

    Private Sub AjouterToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterToolStripMenuItem2.Click
        produits.Show()
        produits.MdiParent = Me
        produits.WindowState = FormWindowState.Normal
        produits.bajouter.Visible = True
        produits.bsupprimer.Visible = False
        produits.bmodifier.Visible = False
        produits.GroupBox1.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub SupprimerToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerToolStripMenuItem3.Click
        produits.Show()
        produits.MdiParent = Me
        produits.WindowState = FormWindowState.Normal
        produits.bajouter.Visible = False
        produits.bsupprimer.Visible = True
        produits.bmodifier.Visible = False
        produits.GroupBox1.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub ModifierToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierToolStripMenuItem3.Click
        produits.Show()
        produits.MdiParent = Me
        produits.WindowState = FormWindowState.Normal
        produits.bajouter.Visible = False
        produits.bsupprimer.Visible = False
        produits.bmodifier.Visible = True
        produits.GroupBox1.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub RechercherToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RechercherToolStripMenuItem2.Click
        produits.Show()
        produits.MdiParent = Me
        produits.WindowState = FormWindowState.Normal
        produits.bajouter.Visible = False
        produits.bsupprimer.Visible = False
        produits.bmodifier.Visible = False
        produits.Btn_Annuler.Visible = False
        produits.GroupBox1.Visible = True
        Label1.Visible = False
    End Sub

  

    Private Sub AjouterToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterToolStripMenuItem3.Click
        budget.Show()
        budget.MdiParent = Me
        budget.WindowState = FormWindowState.Normal
        budget.Bajouter.Visible = True
        budget.Bsupprimer.Visible = False
        budget.Bmodifier.Visible = False
        budget.GroupBox1.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub SupprimerToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerToolStripMenuItem4.Click
        budget.Show()
        budget.MdiParent = Me
        budget.WindowState = FormWindowState.Normal
        budget.Bajouter.Visible = False
        budget.Bsupprimer.Visible = True
        budget.Bmodifier.Visible = False
        budget.GroupBox1.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub ModifierToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierToolStripMenuItem4.Click
        budget.Show()
        budget.MdiParent = Me
        budget.WindowState = FormWindowState.Normal
        budget.Bajouter.Visible = False
        budget.Bsupprimer.Visible = False
        budget.Bmodifier.Visible = True
        budget.GroupBox1.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub RechercherToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RechercherToolStripMenuItem3.Click
        budget.Show()
        budget.MdiParent = Me
        budget.WindowState = FormWindowState.Normal
        budget.Bajouter.Visible = False
        budget.Bajouter.Visible = False
        budget.Bmodifier.Visible = False
        budget.btn_annuler.Visible = False
        budget.GroupBox1.Visible = True
        Label1.Visible = False
    End Sub

    Private Sub AjouterToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterToolStripMenuItem4.Click
        inventaire.Show()
        inventaire.MdiParent = Me
        inventaire.WindowState = FormWindowState.Maximized
        inventaire.bajouter.Visible = True
        inventaire.bsupprimer.Visible = False
        inventaire.bmodifier.Visible = False
        inventaire.GroupBox1.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub SupprimerToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerToolStripMenuItem5.Click
        inventaire.Show()
        inventaire.MdiParent = Me
        inventaire.WindowState = FormWindowState.Maximized
        inventaire.bajouter.Visible = False
        inventaire.bsupprimer.Visible = True
        inventaire.bmodifier.Visible = False
        inventaire.GroupBox1.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub ModifierToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierToolStripMenuItem5.Click
        inventaire.Show()
        inventaire.MdiParent = Me
        inventaire.WindowState = FormWindowState.Maximized
        inventaire.bajouter.Visible = False
        inventaire.bsupprimer.Visible = False
        inventaire.bmodifier.Visible = True
        inventaire.GroupBox1.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub RechercherToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RechercherToolStripMenuItem4.Click
        inventaire.Show()
        inventaire.MdiParent = Me
        inventaire.WindowState = FormWindowState.Maximized
        inventaire.bajouter.Visible = False
        inventaire.bsupprimer.Visible = False
        inventaire.bmodifier.Visible = False
        inventaire.Btn_Annuler.Visible = False
        inventaire.GroupBox1.Visible = True
        Label1.Visible = False
    End Sub

    Private Sub AjouterToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterToolStripMenuItem5.Click
        'divison de service msammiha aana btn_anuler ,le nom de la classse
        Btn_annuler.Show()
        Btn_annuler.MdiParent = Me
        Btn_annuler.WindowState = FormWindowState.Normal
        Btn_annuler.bajouter.Visible = True
        Btn_annuler.bsupprimer.Visible = False
        Btn_annuler.bmodifier.Visible = False
        Btn_annuler.GroupBox1.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub SupprimerToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerToolStripMenuItem6.Click
        Btn_annuler.Show()
        Btn_annuler.MdiParent = Me
        Btn_annuler.WindowState = FormWindowState.Normal
        Btn_annuler.bajouter.Visible = False
        Btn_annuler.bsupprimer.Visible = True
        Btn_annuler.bmodifier.Visible = False
        Btn_annuler.GroupBox1.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub ModifierToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierToolStripMenuItem6.Click
        Btn_annuler.Show()
        Btn_annuler.MdiParent = Me
        Btn_annuler.WindowState = FormWindowState.Normal
        Btn_annuler.bajouter.Visible = False
        Btn_annuler.bsupprimer.Visible = False
        Btn_annuler.bmodifier.Visible = True
        Btn_annuler.GroupBox1.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub RechercherToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RechercherToolStripMenuItem5.Click
        Btn_annuler.Show()
        Btn_annuler.MdiParent = Me
        Btn_annuler.WindowState = FormWindowState.Normal
        Btn_annuler.bajouter.Visible = False
        Btn_annuler.bsupprimer.Visible = False
        Btn_annuler.bmodifier.Visible = False
        Btn_annuler.Btn_Vider.Visible = False
        Btn_annuler.GroupBox1.Visible = True
        Label1.Visible = False
    End Sub

    Private Sub AjouterToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterToolStripMenuItem6.Click
        nature_de_service.Show()
        nature_de_service.MdiParent = Me
        nature_de_service.WindowState = FormWindowState.Normal
        nature_de_service.Bajouter.Visible = True
        nature_de_service.bsupprimer.Visible = False
        nature_de_service.bmodifier.Visible = False
        nature_de_service.GroupBox1.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub SupprimerToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerToolStripMenuItem7.Click
        nature_de_service.Show()
        nature_de_service.MdiParent = Me
        nature_de_service.WindowState = FormWindowState.Normal
        nature_de_service.Bajouter.Visible = False
        nature_de_service.bsupprimer.Visible = True
        nature_de_service.bmodifier.Visible = False
        nature_de_service.GroupBox1.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub MadifierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MadifierToolStripMenuItem.Click
        nature_de_service.Show()
        nature_de_service.MdiParent = Me
        nature_de_service.WindowState = FormWindowState.Normal
        nature_de_service.Bajouter.Visible = False
        nature_de_service.bsupprimer.Visible = False
        nature_de_service.bmodifier.Visible = True
        nature_de_service.GroupBox1.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub RechercherToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RechercherToolStripMenuItem6.Click
        nature_de_service.Show()
        nature_de_service.MdiParent = Me
        nature_de_service.WindowState = FormWindowState.Normal
        nature_de_service.Bajouter.Visible = False
        nature_de_service.bsupprimer.Visible = False
        nature_de_service.bmodifier.Visible = False
        nature_de_service.Btn_Annuler.Visible = False
        nature_de_service.GroupBox1.Visible = True
        Label1.Visible = False
    End Sub

 

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Left += 1
        If Label1.Location.X = 1234 Then
            Label1.Top = 20
            Label1.Left = 0
        End If
    End Sub

   
    Private Sub RechercheToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RechercheToolStripMenuItem.Click
        detail_commande.Show()
        detail_commande.MdiParent = Me
        detail_commande.WindowState = FormWindowState.Maximized
        detail_commande.bajouter.Visible = False
        detail_commande.bsupprimer.Visible = False
        detail_commande.bmodifier.Visible = False
        detail_commande.Btn_Annuler.Visible = False
        detail_commande.GroboxRechercher.Visible = True
        Label1.Visible = True
    End Sub

   
    




    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub CommandeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandeToolStripMenuItem.Click

    End Sub

    Private Sub FournisseurToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FournisseurToolStripMenuItem.Click

    End Sub

    Private Sub DivisionServicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DivisionServicesToolStripMenuItem.Click

    End Sub
End Class