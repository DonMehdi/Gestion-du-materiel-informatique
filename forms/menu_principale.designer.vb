<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_principale
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menu_principale))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CommandeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RechercherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailCommandeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RechercheToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FournisseurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RechercherToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProduitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RechercherToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BudgetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RechercherToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventaireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RechercherToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DivisionServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RechercherToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NatureServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MadifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RechercherToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FERMERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = CType(resources.GetObject("MenuStrip1.BackgroundImage"), System.Drawing.Image)
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CommandeToolStripMenuItem, Me.DetailCommandeToolStripMenuItem, Me.FournisseurToolStripMenuItem, Me.ProduitToolStripMenuItem, Me.BudgetToolStripMenuItem, Me.InventaireToolStripMenuItem, Me.DivisionServicesToolStripMenuItem, Me.NatureServiceToolStripMenuItem, Me.FERMERToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CommandeToolStripMenuItem
        '
        Me.CommandeToolStripMenuItem.AutoToolTip = True
        Me.CommandeToolStripMenuItem.BackColor = System.Drawing.Color.LightGray
        Me.CommandeToolStripMenuItem.BackgroundImage = CType(resources.GetObject("CommandeToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.CommandeToolStripMenuItem.Checked = True
        Me.CommandeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.CommandeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterToolStripMenuItem, Me.SupprimerToolStripMenuItem, Me.ModifierToolStripMenuItem, Me.RechercherToolStripMenuItem})
        Me.CommandeToolStripMenuItem.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommandeToolStripMenuItem.ForeColor = System.Drawing.Color.Aqua
        Me.CommandeToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.CommandeToolStripMenuItem.Name = "CommandeToolStripMenuItem"
        Me.CommandeToolStripMenuItem.Size = New System.Drawing.Size(138, 26)
        Me.CommandeToolStripMenuItem.Text = "COMMANDE"
        Me.CommandeToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CommandeToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AjouterToolStripMenuItem
        '
        Me.AjouterToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AjouterToolStripMenuItem.Name = "AjouterToolStripMenuItem"
        Me.AjouterToolStripMenuItem.Size = New System.Drawing.Size(188, 26)
        Me.AjouterToolStripMenuItem.Text = "Ajouter"
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(188, 26)
        Me.SupprimerToolStripMenuItem.Text = "Supprimer"
        '
        'ModifierToolStripMenuItem
        '
        Me.ModifierToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ModifierToolStripMenuItem.Name = "ModifierToolStripMenuItem"
        Me.ModifierToolStripMenuItem.Size = New System.Drawing.Size(188, 26)
        Me.ModifierToolStripMenuItem.Text = "Modifier"
        '
        'RechercherToolStripMenuItem
        '
        Me.RechercherToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RechercherToolStripMenuItem.Name = "RechercherToolStripMenuItem"
        Me.RechercherToolStripMenuItem.Size = New System.Drawing.Size(188, 26)
        Me.RechercherToolStripMenuItem.Text = "Rechercher"
        '
        'DetailCommandeToolStripMenuItem
        '
        Me.DetailCommandeToolStripMenuItem.AutoToolTip = True
        Me.DetailCommandeToolStripMenuItem.BackColor = System.Drawing.Color.LightGray
        Me.DetailCommandeToolStripMenuItem.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.images
        Me.DetailCommandeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterToolStripMenuItem1, Me.SupprimerToolStripMenuItem1, Me.ModifierToolStripMenuItem1, Me.RechercheToolStripMenuItem})
        Me.DetailCommandeToolStripMenuItem.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailCommandeToolStripMenuItem.ForeColor = System.Drawing.Color.Aqua
        Me.DetailCommandeToolStripMenuItem.Name = "DetailCommandeToolStripMenuItem"
        Me.DetailCommandeToolStripMenuItem.Size = New System.Drawing.Size(191, 26)
        Me.DetailCommandeToolStripMenuItem.Text = "Detail_Commande"
        Me.DetailCommandeToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DetailCommandeToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AjouterToolStripMenuItem1
        '
        Me.AjouterToolStripMenuItem1.Name = "AjouterToolStripMenuItem1"
        Me.AjouterToolStripMenuItem1.Size = New System.Drawing.Size(180, 26)
        Me.AjouterToolStripMenuItem1.Text = "Ajouter"
        '
        'SupprimerToolStripMenuItem1
        '
        Me.SupprimerToolStripMenuItem1.Name = "SupprimerToolStripMenuItem1"
        Me.SupprimerToolStripMenuItem1.Size = New System.Drawing.Size(180, 26)
        Me.SupprimerToolStripMenuItem1.Text = "Supprimer"
        '
        'ModifierToolStripMenuItem1
        '
        Me.ModifierToolStripMenuItem1.Name = "ModifierToolStripMenuItem1"
        Me.ModifierToolStripMenuItem1.Size = New System.Drawing.Size(180, 26)
        Me.ModifierToolStripMenuItem1.Text = "Modifier"
        '
        'RechercheToolStripMenuItem
        '
        Me.RechercheToolStripMenuItem.Name = "RechercheToolStripMenuItem"
        Me.RechercheToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.RechercheToolStripMenuItem.Text = "Recherche"
        '
        'FournisseurToolStripMenuItem
        '
        Me.FournisseurToolStripMenuItem.AutoToolTip = True
        Me.FournisseurToolStripMenuItem.BackColor = System.Drawing.Color.LightGray
        Me.FournisseurToolStripMenuItem.BackgroundImage = CType(resources.GetObject("FournisseurToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.FournisseurToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouToolStripMenuItem, Me.SupprimerToolStripMenuItem2, Me.ModifierToolStripMenuItem2, Me.RechercherToolStripMenuItem1})
        Me.FournisseurToolStripMenuItem.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FournisseurToolStripMenuItem.ForeColor = System.Drawing.Color.Aqua
        Me.FournisseurToolStripMenuItem.Name = "FournisseurToolStripMenuItem"
        Me.FournisseurToolStripMenuItem.Size = New System.Drawing.Size(136, 26)
        Me.FournisseurToolStripMenuItem.Text = "Fournisseur"
        Me.FournisseurToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.FournisseurToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AjouToolStripMenuItem
        '
        Me.AjouToolStripMenuItem.Name = "AjouToolStripMenuItem"
        Me.AjouToolStripMenuItem.Size = New System.Drawing.Size(188, 26)
        Me.AjouToolStripMenuItem.Text = "Ajouter"
        '
        'SupprimerToolStripMenuItem2
        '
        Me.SupprimerToolStripMenuItem2.Name = "SupprimerToolStripMenuItem2"
        Me.SupprimerToolStripMenuItem2.Size = New System.Drawing.Size(188, 26)
        Me.SupprimerToolStripMenuItem2.Text = "Supprimer"
        '
        'ModifierToolStripMenuItem2
        '
        Me.ModifierToolStripMenuItem2.Name = "ModifierToolStripMenuItem2"
        Me.ModifierToolStripMenuItem2.Size = New System.Drawing.Size(188, 26)
        Me.ModifierToolStripMenuItem2.Text = "Modifier"
        '
        'RechercherToolStripMenuItem1
        '
        Me.RechercherToolStripMenuItem1.Name = "RechercherToolStripMenuItem1"
        Me.RechercherToolStripMenuItem1.Size = New System.Drawing.Size(188, 26)
        Me.RechercherToolStripMenuItem1.Text = "Rechercher"
        '
        'ProduitToolStripMenuItem
        '
        Me.ProduitToolStripMenuItem.AutoToolTip = True
        Me.ProduitToolStripMenuItem.BackColor = System.Drawing.Color.LightGray
        Me.ProduitToolStripMenuItem.BackgroundImage = CType(resources.GetObject("ProduitToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.ProduitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterToolStripMenuItem2, Me.SupprimerToolStripMenuItem3, Me.ModifierToolStripMenuItem3, Me.RechercherToolStripMenuItem2})
        Me.ProduitToolStripMenuItem.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProduitToolStripMenuItem.ForeColor = System.Drawing.Color.Aqua
        Me.ProduitToolStripMenuItem.Name = "ProduitToolStripMenuItem"
        Me.ProduitToolStripMenuItem.Size = New System.Drawing.Size(90, 26)
        Me.ProduitToolStripMenuItem.Text = "Produit"
        Me.ProduitToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ProduitToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AjouterToolStripMenuItem2
        '
        Me.AjouterToolStripMenuItem2.Name = "AjouterToolStripMenuItem2"
        Me.AjouterToolStripMenuItem2.Size = New System.Drawing.Size(188, 26)
        Me.AjouterToolStripMenuItem2.Text = "Ajouter"
        '
        'SupprimerToolStripMenuItem3
        '
        Me.SupprimerToolStripMenuItem3.Name = "SupprimerToolStripMenuItem3"
        Me.SupprimerToolStripMenuItem3.Size = New System.Drawing.Size(188, 26)
        Me.SupprimerToolStripMenuItem3.Text = "Supprimer"
        '
        'ModifierToolStripMenuItem3
        '
        Me.ModifierToolStripMenuItem3.Name = "ModifierToolStripMenuItem3"
        Me.ModifierToolStripMenuItem3.Size = New System.Drawing.Size(188, 26)
        Me.ModifierToolStripMenuItem3.Text = "Modifier"
        '
        'RechercherToolStripMenuItem2
        '
        Me.RechercherToolStripMenuItem2.Name = "RechercherToolStripMenuItem2"
        Me.RechercherToolStripMenuItem2.Size = New System.Drawing.Size(188, 26)
        Me.RechercherToolStripMenuItem2.Text = "Rechercher"
        '
        'BudgetToolStripMenuItem
        '
        Me.BudgetToolStripMenuItem.AutoToolTip = True
        Me.BudgetToolStripMenuItem.BackColor = System.Drawing.Color.LightGray
        Me.BudgetToolStripMenuItem.BackgroundImage = CType(resources.GetObject("BudgetToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.BudgetToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterToolStripMenuItem3, Me.SupprimerToolStripMenuItem4, Me.ModifierToolStripMenuItem4, Me.RechercherToolStripMenuItem3})
        Me.BudgetToolStripMenuItem.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BudgetToolStripMenuItem.ForeColor = System.Drawing.Color.Aqua
        Me.BudgetToolStripMenuItem.Name = "BudgetToolStripMenuItem"
        Me.BudgetToolStripMenuItem.Size = New System.Drawing.Size(89, 26)
        Me.BudgetToolStripMenuItem.Text = "Budget"
        Me.BudgetToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BudgetToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AjouterToolStripMenuItem3
        '
        Me.AjouterToolStripMenuItem3.Name = "AjouterToolStripMenuItem3"
        Me.AjouterToolStripMenuItem3.Size = New System.Drawing.Size(188, 26)
        Me.AjouterToolStripMenuItem3.Text = "Ajouter"
        '
        'SupprimerToolStripMenuItem4
        '
        Me.SupprimerToolStripMenuItem4.Name = "SupprimerToolStripMenuItem4"
        Me.SupprimerToolStripMenuItem4.Size = New System.Drawing.Size(188, 26)
        Me.SupprimerToolStripMenuItem4.Text = "Supprimer"
        '
        'ModifierToolStripMenuItem4
        '
        Me.ModifierToolStripMenuItem4.Name = "ModifierToolStripMenuItem4"
        Me.ModifierToolStripMenuItem4.Size = New System.Drawing.Size(188, 26)
        Me.ModifierToolStripMenuItem4.Text = "Modifier"
        '
        'RechercherToolStripMenuItem3
        '
        Me.RechercherToolStripMenuItem3.Name = "RechercherToolStripMenuItem3"
        Me.RechercherToolStripMenuItem3.Size = New System.Drawing.Size(188, 26)
        Me.RechercherToolStripMenuItem3.Text = "Rechercher"
        '
        'InventaireToolStripMenuItem
        '
        Me.InventaireToolStripMenuItem.AutoToolTip = True
        Me.InventaireToolStripMenuItem.BackColor = System.Drawing.Color.LightGray
        Me.InventaireToolStripMenuItem.BackgroundImage = CType(resources.GetObject("InventaireToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.InventaireToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterToolStripMenuItem4, Me.SupprimerToolStripMenuItem5, Me.ModifierToolStripMenuItem5, Me.RechercherToolStripMenuItem4})
        Me.InventaireToolStripMenuItem.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InventaireToolStripMenuItem.ForeColor = System.Drawing.Color.Aqua
        Me.InventaireToolStripMenuItem.Name = "InventaireToolStripMenuItem"
        Me.InventaireToolStripMenuItem.Size = New System.Drawing.Size(114, 26)
        Me.InventaireToolStripMenuItem.Text = "Inventaire"
        Me.InventaireToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.InventaireToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'AjouterToolStripMenuItem4
        '
        Me.AjouterToolStripMenuItem4.Name = "AjouterToolStripMenuItem4"
        Me.AjouterToolStripMenuItem4.Size = New System.Drawing.Size(188, 26)
        Me.AjouterToolStripMenuItem4.Text = "Ajouter"
        '
        'SupprimerToolStripMenuItem5
        '
        Me.SupprimerToolStripMenuItem5.Name = "SupprimerToolStripMenuItem5"
        Me.SupprimerToolStripMenuItem5.Size = New System.Drawing.Size(188, 26)
        Me.SupprimerToolStripMenuItem5.Text = "Supprimer"
        '
        'ModifierToolStripMenuItem5
        '
        Me.ModifierToolStripMenuItem5.Name = "ModifierToolStripMenuItem5"
        Me.ModifierToolStripMenuItem5.Size = New System.Drawing.Size(188, 26)
        Me.ModifierToolStripMenuItem5.Text = "Modifier"
        '
        'RechercherToolStripMenuItem4
        '
        Me.RechercherToolStripMenuItem4.Name = "RechercherToolStripMenuItem4"
        Me.RechercherToolStripMenuItem4.Size = New System.Drawing.Size(188, 26)
        Me.RechercherToolStripMenuItem4.Text = "Rechercher"
        '
        'DivisionServicesToolStripMenuItem
        '
        Me.DivisionServicesToolStripMenuItem.AutoToolTip = True
        Me.DivisionServicesToolStripMenuItem.BackColor = System.Drawing.Color.LightGray
        Me.DivisionServicesToolStripMenuItem.BackgroundImage = CType(resources.GetObject("DivisionServicesToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.DivisionServicesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterToolStripMenuItem5, Me.SupprimerToolStripMenuItem6, Me.ModifierToolStripMenuItem6, Me.RechercherToolStripMenuItem5})
        Me.DivisionServicesToolStripMenuItem.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DivisionServicesToolStripMenuItem.ForeColor = System.Drawing.Color.Aqua
        Me.DivisionServicesToolStripMenuItem.Name = "DivisionServicesToolStripMenuItem"
        Me.DivisionServicesToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.DivisionServicesToolStripMenuItem.Text = "Division_Services"
        Me.DivisionServicesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DivisionServicesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AjouterToolStripMenuItem5
        '
        Me.AjouterToolStripMenuItem5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AjouterToolStripMenuItem5.Name = "AjouterToolStripMenuItem5"
        Me.AjouterToolStripMenuItem5.Size = New System.Drawing.Size(188, 26)
        Me.AjouterToolStripMenuItem5.Text = "Ajouter"
        '
        'SupprimerToolStripMenuItem6
        '
        Me.SupprimerToolStripMenuItem6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SupprimerToolStripMenuItem6.Name = "SupprimerToolStripMenuItem6"
        Me.SupprimerToolStripMenuItem6.Size = New System.Drawing.Size(188, 26)
        Me.SupprimerToolStripMenuItem6.Text = "Supprimer"
        '
        'ModifierToolStripMenuItem6
        '
        Me.ModifierToolStripMenuItem6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ModifierToolStripMenuItem6.Name = "ModifierToolStripMenuItem6"
        Me.ModifierToolStripMenuItem6.Size = New System.Drawing.Size(188, 26)
        Me.ModifierToolStripMenuItem6.Text = "Modifier"
        '
        'RechercherToolStripMenuItem5
        '
        Me.RechercherToolStripMenuItem5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RechercherToolStripMenuItem5.Name = "RechercherToolStripMenuItem5"
        Me.RechercherToolStripMenuItem5.Size = New System.Drawing.Size(188, 26)
        Me.RechercherToolStripMenuItem5.Text = "Rechercher"
        '
        'NatureServiceToolStripMenuItem
        '
        Me.NatureServiceToolStripMenuItem.AutoToolTip = True
        Me.NatureServiceToolStripMenuItem.BackColor = System.Drawing.Color.LightGray
        Me.NatureServiceToolStripMenuItem.BackgroundImage = CType(resources.GetObject("NatureServiceToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.NatureServiceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterToolStripMenuItem6, Me.SupprimerToolStripMenuItem7, Me.MadifierToolStripMenuItem, Me.RechercherToolStripMenuItem6})
        Me.NatureServiceToolStripMenuItem.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NatureServiceToolStripMenuItem.ForeColor = System.Drawing.Color.Aqua
        Me.NatureServiceToolStripMenuItem.Name = "NatureServiceToolStripMenuItem"
        Me.NatureServiceToolStripMenuItem.Size = New System.Drawing.Size(164, 26)
        Me.NatureServiceToolStripMenuItem.Text = "Nature_Service"
        Me.NatureServiceToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.NatureServiceToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AjouterToolStripMenuItem6
        '
        Me.AjouterToolStripMenuItem6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AjouterToolStripMenuItem6.Name = "AjouterToolStripMenuItem6"
        Me.AjouterToolStripMenuItem6.Size = New System.Drawing.Size(188, 26)
        Me.AjouterToolStripMenuItem6.Text = "Ajouter"
        '
        'SupprimerToolStripMenuItem7
        '
        Me.SupprimerToolStripMenuItem7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SupprimerToolStripMenuItem7.Name = "SupprimerToolStripMenuItem7"
        Me.SupprimerToolStripMenuItem7.Size = New System.Drawing.Size(188, 26)
        Me.SupprimerToolStripMenuItem7.Text = "Supprimer"
        '
        'MadifierToolStripMenuItem
        '
        Me.MadifierToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MadifierToolStripMenuItem.Name = "MadifierToolStripMenuItem"
        Me.MadifierToolStripMenuItem.Size = New System.Drawing.Size(188, 26)
        Me.MadifierToolStripMenuItem.Text = "Modifier"
        '
        'RechercherToolStripMenuItem6
        '
        Me.RechercherToolStripMenuItem6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RechercherToolStripMenuItem6.Name = "RechercherToolStripMenuItem6"
        Me.RechercherToolStripMenuItem6.Size = New System.Drawing.Size(188, 26)
        Me.RechercherToolStripMenuItem6.Text = "Rechercher"
        '
        'FERMERToolStripMenuItem
        '
        Me.FERMERToolStripMenuItem.AutoToolTip = True
        Me.FERMERToolStripMenuItem.BackgroundImage = CType(resources.GetObject("FERMERToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.FERMERToolStripMenuItem.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FERMERToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.FERMERToolStripMenuItem.Name = "FERMERToolStripMenuItem"
        Me.FERMERToolStripMenuItem.Size = New System.Drawing.Size(103, 26)
        Me.FERMERToolStripMenuItem.Text = "FERMER"
        Me.FERMERToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.FERMERToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 14
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Jokerman", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Image = Global.WindowsApplication1.My.Resources.Resources.espace_turquoise
        Me.Label1.Location = New System.Drawing.Point(113, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(657, 158)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "                  GESTION DES                                             MATERIA" & _
            "UX"
        '
        'menu_principale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.espace_turquoise
        Me.ClientSize = New System.Drawing.Size(1370, 472)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "menu_principale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menu_principale"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CommandeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailCommandeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FournisseurToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProduitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BudgetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventaireToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DivisionServicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NatureServiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RechercherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifierToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifierToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RechercherToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifierToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RechercherToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifierToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RechercherToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifierToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RechercherToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifierToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RechercherToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MadifierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RechercherToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FERMERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RechercheToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
