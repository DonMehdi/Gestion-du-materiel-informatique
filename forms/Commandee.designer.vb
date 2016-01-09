<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Commandee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Commandee))
        Me.Cmb_cdeFournisseur = New System.Windows.Forms.ComboBox()
        Me.cmb_typebudget = New System.Windows.Forms.ComboBox()
        Me.txt_region = New System.Windows.Forms.TextBox()
        Me.txt_chapitre = New System.Windows.Forms.TextBox()
        Me.Lbl_region = New System.Windows.Forms.Label()
        Me.Lbl_chapitre = New System.Windows.Forms.Label()
        Me.Txt_nature_presenta = New System.Windows.Forms.TextBox()
        Me.Txt_nature_credi = New System.Windows.Forms.TextBox()
        Me.txt_paragraphe = New System.Windows.Forms.TextBox()
        Me.txt_objectif_depen = New System.Windows.Forms.TextBox()
        Me.Txt_rubrique = New System.Windows.Forms.TextBox()
        Me.txt_ligne = New System.Windows.Forms.TextBox()
        Me.Lbl_natur_presenta = New System.Windows.Forms.Label()
        Me.Lbl_nature_de_credit = New System.Windows.Forms.Label()
        Me.Lbl_paragraphe = New System.Windows.Forms.Label()
        Me.Lbl_obj_depens = New System.Windows.Forms.Label()
        Me.Lbl_rubriq = New System.Windows.Forms.Label()
        Me.lbl_ligne = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Montant = New System.Windows.Forms.TextBox()
        Me.Txt_Observ = New System.Windows.Forms.TextBox()
        Me.Txt_Exerc = New System.Windows.Forms.TextBox()
        Me.Txt_n_marchbc = New System.Windows.Forms.TextBox()
        Me.Lbl_typebudget = New System.Windows.Forms.Label()
        Me.Lbl_cdfourmiss = New System.Windows.Forms.Label()
        Me.Lbl_montant = New System.Windows.Forms.Label()
        Me.Lbl_observ = New System.Windows.Forms.Label()
        Me.Lbl_exerc = New System.Windows.Forms.Label()
        Me.Lbl_marchbc = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Tnºmarchebc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.Btn_modifier = New System.Windows.Forms.Button()
        Me.Btn_supprime = New System.Windows.Forms.Button()
        Me.Btn_ajoute = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cmb_cdeFournisseur
        '
        Me.Cmb_cdeFournisseur.FormattingEnabled = True
        Me.Cmb_cdeFournisseur.Location = New System.Drawing.Point(136, 147)
        Me.Cmb_cdeFournisseur.Name = "Cmb_cdeFournisseur"
        Me.Cmb_cdeFournisseur.Size = New System.Drawing.Size(138, 21)
        Me.Cmb_cdeFournisseur.TabIndex = 67
        '
        'cmb_typebudget
        '
        Me.cmb_typebudget.FormattingEnabled = True
        Me.cmb_typebudget.Location = New System.Drawing.Point(680, 145)
        Me.cmb_typebudget.Name = "cmb_typebudget"
        Me.cmb_typebudget.Size = New System.Drawing.Size(153, 21)
        Me.cmb_typebudget.TabIndex = 66
        '
        'txt_region
        '
        Me.txt_region.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_region.ForeColor = System.Drawing.Color.Black
        Me.txt_region.Location = New System.Drawing.Point(407, 283)
        Me.txt_region.Name = "txt_region"
        Me.txt_region.Size = New System.Drawing.Size(138, 21)
        Me.txt_region.TabIndex = 65
        '
        'txt_chapitre
        '
        Me.txt_chapitre.Location = New System.Drawing.Point(136, 284)
        Me.txt_chapitre.Name = "txt_chapitre"
        Me.txt_chapitre.Size = New System.Drawing.Size(138, 20)
        Me.txt_chapitre.TabIndex = 64
        '
        'Lbl_region
        '
        Me.Lbl_region.AutoSize = True
        Me.Lbl_region.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_region.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_region.Location = New System.Drawing.Point(290, 288)
        Me.Lbl_region.Name = "Lbl_region"
        Me.Lbl_region.Size = New System.Drawing.Size(49, 16)
        Me.Lbl_region.TabIndex = 63
        Me.Lbl_region.Text = "region"
        '
        'Lbl_chapitre
        '
        Me.Lbl_chapitre.AutoSize = True
        Me.Lbl_chapitre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_chapitre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_chapitre.Location = New System.Drawing.Point(2, 291)
        Me.Lbl_chapitre.Name = "Lbl_chapitre"
        Me.Lbl_chapitre.Size = New System.Drawing.Size(60, 16)
        Me.Lbl_chapitre.TabIndex = 62
        Me.Lbl_chapitre.Text = "chapitre"
        '
        'Txt_nature_presenta
        '
        Me.Txt_nature_presenta.Location = New System.Drawing.Point(682, 193)
        Me.Txt_nature_presenta.Name = "Txt_nature_presenta"
        Me.Txt_nature_presenta.Size = New System.Drawing.Size(151, 20)
        Me.Txt_nature_presenta.TabIndex = 61
        '
        'Txt_nature_credi
        '
        Me.Txt_nature_credi.Location = New System.Drawing.Point(407, 188)
        Me.Txt_nature_credi.Name = "Txt_nature_credi"
        Me.Txt_nature_credi.Size = New System.Drawing.Size(138, 20)
        Me.Txt_nature_credi.TabIndex = 60
        '
        'txt_paragraphe
        '
        Me.txt_paragraphe.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_paragraphe.ForeColor = System.Drawing.Color.Black
        Me.txt_paragraphe.Location = New System.Drawing.Point(682, 235)
        Me.txt_paragraphe.Name = "txt_paragraphe"
        Me.txt_paragraphe.Size = New System.Drawing.Size(151, 21)
        Me.txt_paragraphe.TabIndex = 59
        '
        'txt_objectif_depen
        '
        Me.txt_objectif_depen.Location = New System.Drawing.Point(136, 235)
        Me.txt_objectif_depen.Name = "txt_objectif_depen"
        Me.txt_objectif_depen.Size = New System.Drawing.Size(138, 20)
        Me.txt_objectif_depen.TabIndex = 58
        '
        'Txt_rubrique
        '
        Me.Txt_rubrique.Location = New System.Drawing.Point(136, 190)
        Me.Txt_rubrique.Name = "Txt_rubrique"
        Me.Txt_rubrique.Size = New System.Drawing.Size(136, 20)
        Me.Txt_rubrique.TabIndex = 57
        '
        'txt_ligne
        '
        Me.txt_ligne.ForeColor = System.Drawing.Color.Black
        Me.txt_ligne.Location = New System.Drawing.Point(407, 230)
        Me.txt_ligne.Name = "txt_ligne"
        Me.txt_ligne.Size = New System.Drawing.Size(138, 20)
        Me.txt_ligne.TabIndex = 56
        '
        'Lbl_natur_presenta
        '
        Me.Lbl_natur_presenta.AutoSize = True
        Me.Lbl_natur_presenta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_natur_presenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_natur_presenta.Location = New System.Drawing.Point(557, 193)
        Me.Lbl_natur_presenta.Name = "Lbl_natur_presenta"
        Me.Lbl_natur_presenta.Size = New System.Drawing.Size(119, 16)
        Me.Lbl_natur_presenta.TabIndex = 55
        Me.Lbl_natur_presenta.Text = "nature_prestation"
        '
        'Lbl_nature_de_credit
        '
        Me.Lbl_nature_de_credit.AutoSize = True
        Me.Lbl_nature_de_credit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_nature_de_credit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_nature_de_credit.Location = New System.Drawing.Point(290, 192)
        Me.Lbl_nature_de_credit.Name = "Lbl_nature_de_credit"
        Me.Lbl_nature_de_credit.Size = New System.Drawing.Size(115, 16)
        Me.Lbl_nature_de_credit.TabIndex = 54
        Me.Lbl_nature_de_credit.Text = "nature_de_credit"
        '
        'Lbl_paragraphe
        '
        Me.Lbl_paragraphe.AutoSize = True
        Me.Lbl_paragraphe.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_paragraphe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_paragraphe.Location = New System.Drawing.Point(557, 235)
        Me.Lbl_paragraphe.Name = "Lbl_paragraphe"
        Me.Lbl_paragraphe.Size = New System.Drawing.Size(82, 16)
        Me.Lbl_paragraphe.TabIndex = 53
        Me.Lbl_paragraphe.Text = "paragraphe"
        '
        'Lbl_obj_depens
        '
        Me.Lbl_obj_depens.AutoSize = True
        Me.Lbl_obj_depens.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_obj_depens.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_obj_depens.Location = New System.Drawing.Point(2, 236)
        Me.Lbl_obj_depens.Name = "Lbl_obj_depens"
        Me.Lbl_obj_depens.Size = New System.Drawing.Size(116, 16)
        Me.Lbl_obj_depens.TabIndex = 52
        Me.Lbl_obj_depens.Text = "objectif_depense"
        '
        'Lbl_rubriq
        '
        Me.Lbl_rubriq.AutoSize = True
        Me.Lbl_rubriq.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_rubriq.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_rubriq.Location = New System.Drawing.Point(2, 192)
        Me.Lbl_rubriq.Name = "Lbl_rubriq"
        Me.Lbl_rubriq.Size = New System.Drawing.Size(66, 16)
        Me.Lbl_rubriq.TabIndex = 51
        Me.Lbl_rubriq.Text = "Rubrique"
        '
        'lbl_ligne
        '
        Me.lbl_ligne.AutoSize = True
        Me.lbl_ligne.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ligne.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_ligne.Location = New System.Drawing.Point(290, 236)
        Me.lbl_ligne.Name = "lbl_ligne"
        Me.lbl_ligne.Size = New System.Drawing.Size(40, 16)
        Me.lbl_ligne.TabIndex = 50
        Me.lbl_ligne.Text = "ligne"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Batang", 21.75!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(360, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 31)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Marcher BC"
        '
        'Txt_Montant
        '
        Me.Txt_Montant.Location = New System.Drawing.Point(407, 103)
        Me.Txt_Montant.Name = "Txt_Montant"
        Me.Txt_Montant.Size = New System.Drawing.Size(138, 20)
        Me.Txt_Montant.TabIndex = 44
        '
        'Txt_Observ
        '
        Me.Txt_Observ.Location = New System.Drawing.Point(407, 148)
        Me.Txt_Observ.Name = "Txt_Observ"
        Me.Txt_Observ.Size = New System.Drawing.Size(138, 20)
        Me.Txt_Observ.TabIndex = 43
        '
        'Txt_Exerc
        '
        Me.Txt_Exerc.Location = New System.Drawing.Point(680, 105)
        Me.Txt_Exerc.Name = "Txt_Exerc"
        Me.Txt_Exerc.Size = New System.Drawing.Size(153, 20)
        Me.Txt_Exerc.TabIndex = 42
        '
        'Txt_n_marchbc
        '
        Me.Txt_n_marchbc.Location = New System.Drawing.Point(136, 105)
        Me.Txt_n_marchbc.Name = "Txt_n_marchbc"
        Me.Txt_n_marchbc.Size = New System.Drawing.Size(138, 20)
        Me.Txt_n_marchbc.TabIndex = 41
        '
        'Lbl_typebudget
        '
        Me.Lbl_typebudget.AutoSize = True
        Me.Lbl_typebudget.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_typebudget.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_typebudget.Location = New System.Drawing.Point(557, 148)
        Me.Lbl_typebudget.Name = "Lbl_typebudget"
        Me.Lbl_typebudget.Size = New System.Drawing.Size(87, 16)
        Me.Lbl_typebudget.TabIndex = 40
        Me.Lbl_typebudget.Text = "Type Budget"
        '
        'Lbl_cdfourmiss
        '
        Me.Lbl_cdfourmiss.AutoSize = True
        Me.Lbl_cdfourmiss.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_cdfourmiss.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_cdfourmiss.Location = New System.Drawing.Point(2, 150)
        Me.Lbl_cdfourmiss.Name = "Lbl_cdfourmiss"
        Me.Lbl_cdfourmiss.Size = New System.Drawing.Size(119, 16)
        Me.Lbl_cdfourmiss.TabIndex = 39
        Me.Lbl_cdfourmiss.Text = "Code Fournisseur"
        '
        'Lbl_montant
        '
        Me.Lbl_montant.AutoSize = True
        Me.Lbl_montant.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_montant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_montant.Location = New System.Drawing.Point(290, 108)
        Me.Lbl_montant.Name = "Lbl_montant"
        Me.Lbl_montant.Size = New System.Drawing.Size(59, 16)
        Me.Lbl_montant.TabIndex = 38
        Me.Lbl_montant.Text = "Montant"
        '
        'Lbl_observ
        '
        Me.Lbl_observ.AutoSize = True
        Me.Lbl_observ.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_observ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_observ.Location = New System.Drawing.Point(290, 152)
        Me.Lbl_observ.Name = "Lbl_observ"
        Me.Lbl_observ.Size = New System.Drawing.Size(84, 16)
        Me.Lbl_observ.TabIndex = 37
        Me.Lbl_observ.Text = "Observation"
        '
        'Lbl_exerc
        '
        Me.Lbl_exerc.AutoSize = True
        Me.Lbl_exerc.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_exerc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_exerc.Location = New System.Drawing.Point(557, 106)
        Me.Lbl_exerc.Name = "Lbl_exerc"
        Me.Lbl_exerc.Size = New System.Drawing.Size(63, 16)
        Me.Lbl_exerc.TabIndex = 36
        Me.Lbl_exerc.Text = "Exercice"
        '
        'Lbl_marchbc
        '
        Me.Lbl_marchbc.AutoSize = True
        Me.Lbl_marchbc.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_marchbc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_marchbc.Location = New System.Drawing.Point(2, 105)
        Me.Lbl_marchbc.Name = "Lbl_marchbc"
        Me.Lbl_marchbc.Size = New System.Drawing.Size(91, 16)
        Me.Lbl_marchbc.TabIndex = 35
        Me.Lbl_marchbc.Text = "Nº MarcheBC"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'dgv1
        '
        Me.dgv1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(18, 458)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(874, 169)
        Me.dgv1.TabIndex = 82
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Tnºmarchebc)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Script", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(607, 291)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(285, 140)
        Me.GroupBox1.TabIndex = 83
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rechercher Par"
        '
        'Tnºmarchebc
        '
        Me.Tnºmarchebc.Location = New System.Drawing.Point(35, 70)
        Me.Tnºmarchebc.Name = "Tnºmarchebc"
        Me.Tnºmarchebc.Size = New System.Drawing.Size(210, 28)
        Me.Tnºmarchebc.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nº MarcheBC :"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 20
        '
        'btn_annuler
        '
        Me.btn_annuler.BackgroundImage = CType(resources.GetObject("btn_annuler.BackgroundImage"), System.Drawing.Image)
        Me.btn_annuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_annuler.Location = New System.Drawing.Point(348, 380)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(75, 49)
        Me.btn_annuler.TabIndex = 87
        Me.btn_annuler.Text = " "
        Me.btn_annuler.UseVisualStyleBackColor = True
        '
        'Btn_modifier
        '
        Me.Btn_modifier.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.modifier_texte_icone_4855_64
        Me.Btn_modifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_modifier.Location = New System.Drawing.Point(136, 382)
        Me.Btn_modifier.Name = "Btn_modifier"
        Me.Btn_modifier.Size = New System.Drawing.Size(75, 49)
        Me.Btn_modifier.TabIndex = 86
        Me.Btn_modifier.Text = "modifier"
        Me.Btn_modifier.UseVisualStyleBackColor = True
        '
        'Btn_supprime
        '
        Me.Btn_supprime.BackgroundImage = CType(resources.GetObject("Btn_supprime.BackgroundImage"), System.Drawing.Image)
        Me.Btn_supprime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_supprime.Location = New System.Drawing.Point(243, 380)
        Me.Btn_supprime.Name = "Btn_supprime"
        Me.Btn_supprime.Size = New System.Drawing.Size(75, 49)
        Me.Btn_supprime.TabIndex = 85
        Me.Btn_supprime.Text = " "
        Me.Btn_supprime.UseVisualStyleBackColor = True
        '
        'Btn_ajoute
        '
        Me.Btn_ajoute.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.ajouter_document_fichier_nouveau_plus_icone_3884_32
        Me.Btn_ajoute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_ajoute.Location = New System.Drawing.Point(31, 382)
        Me.Btn_ajoute.Name = "Btn_ajoute"
        Me.Btn_ajoute.Size = New System.Drawing.Size(75, 49)
        Me.Btn_ajoute.TabIndex = 84
        Me.Btn_ajoute.UseVisualStyleBackColor = True
        '
        'Commandee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(970, 639)
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.Btn_modifier)
        Me.Controls.Add(Me.Btn_supprime)
        Me.Controls.Add(Me.Btn_ajoute)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Cmb_cdeFournisseur)
        Me.Controls.Add(Me.cmb_typebudget)
        Me.Controls.Add(Me.txt_region)
        Me.Controls.Add(Me.txt_chapitre)
        Me.Controls.Add(Me.Lbl_region)
        Me.Controls.Add(Me.Lbl_chapitre)
        Me.Controls.Add(Me.Txt_nature_presenta)
        Me.Controls.Add(Me.Txt_nature_credi)
        Me.Controls.Add(Me.txt_paragraphe)
        Me.Controls.Add(Me.txt_objectif_depen)
        Me.Controls.Add(Me.Txt_rubrique)
        Me.Controls.Add(Me.txt_ligne)
        Me.Controls.Add(Me.Lbl_natur_presenta)
        Me.Controls.Add(Me.Lbl_nature_de_credit)
        Me.Controls.Add(Me.Lbl_paragraphe)
        Me.Controls.Add(Me.Lbl_obj_depens)
        Me.Controls.Add(Me.Lbl_rubriq)
        Me.Controls.Add(Me.lbl_ligne)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_Montant)
        Me.Controls.Add(Me.Txt_Observ)
        Me.Controls.Add(Me.Txt_Exerc)
        Me.Controls.Add(Me.Txt_n_marchbc)
        Me.Controls.Add(Me.Lbl_typebudget)
        Me.Controls.Add(Me.Lbl_cdfourmiss)
        Me.Controls.Add(Me.Lbl_montant)
        Me.Controls.Add(Me.Lbl_observ)
        Me.Controls.Add(Me.Lbl_exerc)
        Me.Controls.Add(Me.Lbl_marchbc)
        Me.Name = "Commandee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Commande"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cmb_cdeFournisseur As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_typebudget As System.Windows.Forms.ComboBox
    Friend WithEvents txt_region As System.Windows.Forms.TextBox
    Friend WithEvents txt_chapitre As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_region As System.Windows.Forms.Label
    Friend WithEvents Lbl_chapitre As System.Windows.Forms.Label
    Friend WithEvents Txt_nature_presenta As System.Windows.Forms.TextBox
    Friend WithEvents Txt_nature_credi As System.Windows.Forms.TextBox
    Friend WithEvents txt_paragraphe As System.Windows.Forms.TextBox
    Friend WithEvents txt_objectif_depen As System.Windows.Forms.TextBox
    Friend WithEvents Txt_rubrique As System.Windows.Forms.TextBox
    Friend WithEvents txt_ligne As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_natur_presenta As System.Windows.Forms.Label
    Friend WithEvents Lbl_nature_de_credit As System.Windows.Forms.Label
    Friend WithEvents Lbl_paragraphe As System.Windows.Forms.Label
    Friend WithEvents Lbl_obj_depens As System.Windows.Forms.Label
    Friend WithEvents Lbl_rubriq As System.Windows.Forms.Label
    Friend WithEvents lbl_ligne As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_Montant As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Observ As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Exerc As System.Windows.Forms.TextBox
    Friend WithEvents Txt_n_marchbc As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_typebudget As System.Windows.Forms.Label
    Friend WithEvents Lbl_cdfourmiss As System.Windows.Forms.Label
    Friend WithEvents Lbl_montant As System.Windows.Forms.Label
    Friend WithEvents Lbl_observ As System.Windows.Forms.Label
    Friend WithEvents Lbl_exerc As System.Windows.Forms.Label
    Friend WithEvents Lbl_marchbc As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Tnºmarchebc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btn_annuler As System.Windows.Forms.Button
    Friend WithEvents Btn_modifier As System.Windows.Forms.Button
    Friend WithEvents Btn_supprime As System.Windows.Forms.Button
    Friend WithEvents Btn_ajoute As System.Windows.Forms.Button
End Class
