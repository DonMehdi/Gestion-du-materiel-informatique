<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fournisseur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fournisseur))
        Me.tville = New System.Windows.Forms.TextBox()
        Me.Tacivite = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Rcode = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbanque = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.trip = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tcodefournisseur = New System.Windows.Forms.TextBox()
        Me.ttypeste = New System.Windows.Forms.TextBox()
        Me.tfax = New System.Windows.Forms.TextBox()
        Me.temail = New System.Windows.Forms.TextBox()
        Me.tcodepostale = New System.Windows.Forms.TextBox()
        Me.tagence = New System.Windows.Forms.TextBox()
        Me.tpatente = New System.Windows.Forms.TextBox()
        Me.tadresse = New System.Windows.Forms.TextBox()
        Me.tgsm = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tfournisseurabr = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tinterlocuteur = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ttel = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tfournisseur = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.trechercher = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rfourni = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Btn_annuler = New System.Windows.Forms.Button()
        Me.bmodifier = New System.Windows.Forms.Button()
        Me.bsupprimer = New System.Windows.Forms.Button()
        Me.bajouter = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tville
        '
        Me.tville.ForeColor = System.Drawing.Color.Black
        Me.tville.Location = New System.Drawing.Point(153, 158)
        Me.tville.Name = "tville"
        Me.tville.Size = New System.Drawing.Size(148, 22)
        Me.tville.TabIndex = 31
        '
        'Tacivite
        '
        Me.Tacivite.ForeColor = System.Drawing.Color.Black
        Me.Tacivite.Location = New System.Drawing.Point(749, 155)
        Me.Tacivite.Name = "Tacivite"
        Me.Tacivite.Size = New System.Drawing.Size(185, 22)
        Me.Tacivite.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(634, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 16)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "acivité"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "code fournisseur"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(6, 121)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 16)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "fax"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(6, 234)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 16)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "banque"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(6, 164)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 16)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "ville"
        '
        'Rcode
        '
        Me.Rcode.AutoSize = True
        Me.Rcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rcode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Rcode.Location = New System.Drawing.Point(16, 19)
        Me.Rcode.Name = "Rcode"
        Me.Rcode.Size = New System.Drawing.Size(153, 22)
        Me.Rcode.TabIndex = 0
        Me.Rcode.TabStop = True
        Me.Rcode.Text = "code fournisseur"
        Me.Rcode.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(6, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "type de societe"
        '
        'tbanque
        '
        Me.tbanque.ForeColor = System.Drawing.Color.Black
        Me.tbanque.Location = New System.Drawing.Point(153, 233)
        Me.tbanque.Name = "tbanque"
        Me.tbanque.Size = New System.Drawing.Size(148, 22)
        Me.tbanque.TabIndex = 32
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.tville)
        Me.GroupBox2.Controls.Add(Me.Tacivite)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.tbanque)
        Me.GroupBox2.Controls.Add(Me.trip)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.tcodefournisseur)
        Me.GroupBox2.Controls.Add(Me.ttypeste)
        Me.GroupBox2.Controls.Add(Me.tfax)
        Me.GroupBox2.Controls.Add(Me.temail)
        Me.GroupBox2.Controls.Add(Me.tcodepostale)
        Me.GroupBox2.Controls.Add(Me.tagence)
        Me.GroupBox2.Controls.Add(Me.tpatente)
        Me.GroupBox2.Controls.Add(Me.tadresse)
        Me.GroupBox2.Controls.Add(Me.tgsm)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.tfournisseurabr)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tinterlocuteur)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.ttel)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.tfournisseur)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(18, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(943, 271)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Etat de fornisseur :"
        '
        'trip
        '
        Me.trip.ForeColor = System.Drawing.Color.Black
        Me.trip.Location = New System.Drawing.Point(749, 195)
        Me.trip.Name = "trip"
        Me.trip.Size = New System.Drawing.Size(179, 22)
        Me.trip.TabIndex = 35
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(6, 200)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 16)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "agence"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(636, 197)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(29, 16)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Rib"
        '
        'tcodefournisseur
        '
        Me.tcodefournisseur.ForeColor = System.Drawing.Color.Black
        Me.tcodefournisseur.Location = New System.Drawing.Point(153, 48)
        Me.tcodefournisseur.Name = "tcodefournisseur"
        Me.tcodefournisseur.Size = New System.Drawing.Size(148, 22)
        Me.tcodefournisseur.TabIndex = 19
        '
        'ttypeste
        '
        Me.ttypeste.ForeColor = System.Drawing.Color.Black
        Me.ttypeste.Location = New System.Drawing.Point(153, 82)
        Me.ttypeste.Name = "ttypeste"
        Me.ttypeste.Size = New System.Drawing.Size(148, 22)
        Me.ttypeste.TabIndex = 23
        '
        'tfax
        '
        Me.tfax.ForeColor = System.Drawing.Color.Black
        Me.tfax.Location = New System.Drawing.Point(153, 117)
        Me.tfax.Name = "tfax"
        Me.tfax.Size = New System.Drawing.Size(148, 22)
        Me.tfax.TabIndex = 26
        Me.tfax.Text = "05"
        '
        'temail
        '
        Me.temail.ForeColor = System.Drawing.Color.Black
        Me.temail.Location = New System.Drawing.Point(462, 191)
        Me.temail.Name = "temail"
        Me.temail.Size = New System.Drawing.Size(146, 22)
        Me.temail.TabIndex = 34
        '
        'tcodepostale
        '
        Me.tcodepostale.ForeColor = System.Drawing.Color.Black
        Me.tcodepostale.Location = New System.Drawing.Point(749, 120)
        Me.tcodepostale.Name = "tcodepostale"
        Me.tcodepostale.Size = New System.Drawing.Size(185, 22)
        Me.tcodepostale.TabIndex = 30
        '
        'tagence
        '
        Me.tagence.ForeColor = System.Drawing.Color.Black
        Me.tagence.Location = New System.Drawing.Point(153, 197)
        Me.tagence.Name = "tagence"
        Me.tagence.Size = New System.Drawing.Size(148, 22)
        Me.tagence.TabIndex = 33
        '
        'tpatente
        '
        Me.tpatente.ForeColor = System.Drawing.Color.Black
        Me.tpatente.Location = New System.Drawing.Point(749, 81)
        Me.tpatente.Name = "tpatente"
        Me.tpatente.Size = New System.Drawing.Size(185, 22)
        Me.tpatente.TabIndex = 28
        '
        'tadresse
        '
        Me.tadresse.ForeColor = System.Drawing.Color.Black
        Me.tadresse.Location = New System.Drawing.Point(462, 158)
        Me.tadresse.Name = "tadresse"
        Me.tadresse.Size = New System.Drawing.Size(146, 22)
        Me.tadresse.TabIndex = 29
        '
        'tgsm
        '
        Me.tgsm.ForeColor = System.Drawing.Color.Black
        Me.tgsm.Location = New System.Drawing.Point(751, 48)
        Me.tgsm.Name = "tgsm"
        Me.tgsm.Size = New System.Drawing.Size(231, 22)
        Me.tgsm.TabIndex = 25
        Me.tgsm.Text = "06"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(338, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "fournisseur"
        '
        'tfournisseurabr
        '
        Me.tfournisseurabr.ForeColor = System.Drawing.Color.Black
        Me.tfournisseurabr.Location = New System.Drawing.Point(462, 228)
        Me.tfournisseurabr.Name = "tfournisseurabr"
        Me.tfournisseurabr.Size = New System.Drawing.Size(146, 22)
        Me.tfournisseurabr.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(338, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "tel"
        '
        'tinterlocuteur
        '
        Me.tinterlocuteur.ForeColor = System.Drawing.Color.Black
        Me.tinterlocuteur.Location = New System.Drawing.Point(462, 118)
        Me.tinterlocuteur.Name = "tinterlocuteur"
        Me.tinterlocuteur.Size = New System.Drawing.Size(146, 22)
        Me.tinterlocuteur.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(338, 118)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 16)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "interlocuteur"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(634, 123)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 16)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "code_postale"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(338, 160)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 16)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "adresse"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(631, 83)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 16)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "patente"
        '
        'ttel
        '
        Me.ttel.ForeColor = System.Drawing.Color.Black
        Me.ttel.Location = New System.Drawing.Point(462, 82)
        Me.ttel.Name = "ttel"
        Me.ttel.Size = New System.Drawing.Size(146, 22)
        Me.ttel.TabIndex = 24
        Me.ttel.Text = "06"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(634, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "GSM"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(338, 193)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 16)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "E_mail"
        '
        'tfournisseur
        '
        Me.tfournisseur.ForeColor = System.Drawing.Color.Black
        Me.tfournisseur.Location = New System.Drawing.Point(462, 48)
        Me.tfournisseur.Name = "tfournisseur"
        Me.tfournisseur.Size = New System.Drawing.Size(146, 22)
        Me.tfournisseur.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(338, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "fournisseurabr"
        '
        'trechercher
        '
        Me.trechercher.Location = New System.Drawing.Point(247, 38)
        Me.trechercher.Name = "trechercher"
        Me.trechercher.Size = New System.Drawing.Size(149, 22)
        Me.trechercher.TabIndex = 36
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.trechercher)
        Me.GroupBox1.Controls.Add(Me.rfourni)
        Me.GroupBox1.Controls.Add(Me.Rcode)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(521, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(416, 90)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rechercher par"
        '
        'rfourni
        '
        Me.rfourni.AutoSize = True
        Me.rfourni.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rfourni.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rfourni.Location = New System.Drawing.Point(16, 47)
        Me.rfourni.Name = "rfourni"
        Me.rfourni.Size = New System.Drawing.Size(111, 22)
        Me.rfourni.TabIndex = 1
        Me.rfourni.TabStop = True
        Me.rfourni.Text = "fournisseur"
        Me.rfourni.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.Btn_annuler)
        Me.GroupBox3.Controls.Add(Me.bmodifier)
        Me.GroupBox3.Controls.Add(Me.bsupprimer)
        Me.GroupBox3.Controls.Add(Me.bajouter)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(18, 357)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(943, 135)
        Me.GroupBox3.TabIndex = 51
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Manupilation :"
        '
        'Btn_annuler
        '
        Me.Btn_annuler.BackgroundImage = CType(resources.GetObject("Btn_annuler.BackgroundImage"), System.Drawing.Image)
        Me.Btn_annuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_annuler.Location = New System.Drawing.Point(390, 34)
        Me.Btn_annuler.Name = "Btn_annuler"
        Me.Btn_annuler.Size = New System.Drawing.Size(75, 49)
        Me.Btn_annuler.TabIndex = 95
        Me.Btn_annuler.Text = " "
        Me.Btn_annuler.UseVisualStyleBackColor = True
        '
        'bmodifier
        '
        Me.bmodifier.BackgroundImage = CType(resources.GetObject("bmodifier.BackgroundImage"), System.Drawing.Image)
        Me.bmodifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bmodifier.Location = New System.Drawing.Point(153, 34)
        Me.bmodifier.Name = "bmodifier"
        Me.bmodifier.Size = New System.Drawing.Size(75, 49)
        Me.bmodifier.TabIndex = 94
        Me.bmodifier.Text = "modifier"
        Me.bmodifier.UseVisualStyleBackColor = True
        '
        'bsupprimer
        '
        Me.bsupprimer.BackgroundImage = CType(resources.GetObject("bsupprimer.BackgroundImage"), System.Drawing.Image)
        Me.bsupprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bsupprimer.Location = New System.Drawing.Point(276, 34)
        Me.bsupprimer.Name = "bsupprimer"
        Me.bsupprimer.Size = New System.Drawing.Size(75, 49)
        Me.bsupprimer.TabIndex = 93
        Me.bsupprimer.Text = " "
        Me.bsupprimer.UseVisualStyleBackColor = True
        '
        'bajouter
        '
        Me.bajouter.BackgroundImage = CType(resources.GetObject("bajouter.BackgroundImage"), System.Drawing.Image)
        Me.bajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bajouter.Location = New System.Drawing.Point(33, 34)
        Me.bajouter.Name = "bajouter"
        Me.bajouter.Size = New System.Drawing.Size(75, 49)
        Me.bajouter.TabIndex = 92
        Me.bajouter.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        Me.dgv1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(1, 498)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(960, 121)
        Me.dgv1.TabIndex = 49
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(659, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(392, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 38)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Fournisseur"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 20
        '
        'fournisseur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(985, 622)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Name = "fournisseur"
        Me.Text = "fournisseur"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tville As System.Windows.Forms.TextBox
    Friend WithEvents Tacivite As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Rcode As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbanque As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents trip As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tcodefournisseur As System.Windows.Forms.TextBox
    Friend WithEvents ttypeste As System.Windows.Forms.TextBox
    Friend WithEvents tfax As System.Windows.Forms.TextBox
    Friend WithEvents temail As System.Windows.Forms.TextBox
    Friend WithEvents tcodepostale As System.Windows.Forms.TextBox
    Friend WithEvents tagence As System.Windows.Forms.TextBox
    Friend WithEvents tpatente As System.Windows.Forms.TextBox
    Friend WithEvents tadresse As System.Windows.Forms.TextBox
    Friend WithEvents tgsm As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tfournisseurabr As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tinterlocuteur As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ttel As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tfournisseur As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents trechercher As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rfourni As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Btn_annuler As System.Windows.Forms.Button
    Friend WithEvents bmodifier As System.Windows.Forms.Button
    Friend WithEvents bsupprimer As System.Windows.Forms.Button
    Friend WithEvents bajouter As System.Windows.Forms.Button
End Class
