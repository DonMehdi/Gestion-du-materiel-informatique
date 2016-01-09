<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inventaire
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inventaire))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tcode = New System.Windows.Forms.Label()
        Me.trechercher = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ccde = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Tcodeinventaire = New System.Windows.Forms.TextBox()
        Me.tmr = New System.Windows.Forms.TextBox()
        Me.tnbl = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tnfactt = New System.Windows.Forms.TextBox()
        Me.cexercice = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cnarticle = New System.Windows.Forms.ComboBox()
        Me.thistorique = New System.Windows.Forms.TextBox()
        Me.cncommande = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Btn_Annuler = New System.Windows.Forms.Button()
        Me.bmodifier = New System.Windows.Forms.Button()
        Me.bsupprimer = New System.Windows.Forms.Button()
        Me.bajouter = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(30, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "code d'inventaire"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-7, 603)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(516, 118)
        Me.DataGridView1.TabIndex = 103
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.Btn_Annuler)
        Me.GroupBox3.Controls.Add(Me.bmodifier)
        Me.GroupBox3.Controls.Add(Me.bsupprimer)
        Me.GroupBox3.Controls.Add(Me.bajouter)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(547, 95)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(350, 284)
        Me.GroupBox3.TabIndex = 101
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Manupilation :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.tcode)
        Me.GroupBox1.Controls.Add(Me.trechercher)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 106)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rechercher par"
        '
        'tcode
        '
        Me.tcode.AutoSize = True
        Me.tcode.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tcode.Location = New System.Drawing.Point(24, 23)
        Me.tcode.Name = "tcode"
        Me.tcode.Size = New System.Drawing.Size(126, 16)
        Me.tcode.TabIndex = 37
        Me.tcode.Text = "code d'inventaire :"
        '
        'trechercher
        '
        Me.trechercher.Location = New System.Drawing.Point(84, 51)
        Me.trechercher.Name = "trechercher"
        Me.trechercher.Size = New System.Drawing.Size(212, 22)
        Me.trechercher.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(30, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 16)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "code division de service"
        '
        'ccde
        '
        Me.ccde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ccde.FormattingEnabled = True
        Me.ccde.Location = New System.Drawing.Point(193, 68)
        Me.ccde.Name = "ccde"
        Me.ccde.Size = New System.Drawing.Size(200, 24)
        Me.ccde.TabIndex = 74
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(30, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 16)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "motirradiation"
        '
        'Tcodeinventaire
        '
        Me.Tcodeinventaire.Location = New System.Drawing.Point(189, 34)
        Me.Tcodeinventaire.Name = "Tcodeinventaire"
        Me.Tcodeinventaire.Size = New System.Drawing.Size(200, 22)
        Me.Tcodeinventaire.TabIndex = 50
        '
        'tmr
        '
        Me.tmr.Location = New System.Drawing.Point(189, 103)
        Me.tmr.Name = "tmr"
        Me.tmr.Size = New System.Drawing.Size(200, 22)
        Me.tmr.TabIndex = 56
        '
        'tnbl
        '
        Me.tnbl.Location = New System.Drawing.Point(117, 357)
        Me.tnbl.Name = "tnbl"
        Me.tnbl.Size = New System.Drawing.Size(276, 22)
        Me.tnbl.TabIndex = 55
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(189, 297)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker2.TabIndex = 66
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe Script", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(30, 360)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 20)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "N_bl"
        '
        'tnfactt
        '
        Me.tnfactt.Location = New System.Drawing.Point(189, 329)
        Me.tnfactt.Name = "tnfactt"
        Me.tnfactt.Size = New System.Drawing.Size(200, 22)
        Me.tnfactt.TabIndex = 54
        '
        'cexercice
        '
        Me.cexercice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cexercice.FormattingEnabled = True
        Me.cexercice.Location = New System.Drawing.Point(189, 200)
        Me.cexercice.Name = "cexercice"
        Me.cexercice.Size = New System.Drawing.Size(196, 24)
        Me.cexercice.TabIndex = 69
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(189, 234)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 65
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.ccde)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Tcodeinventaire)
        Me.GroupBox2.Controls.Add(Me.tmr)
        Me.GroupBox2.Controls.Add(Me.tnbl)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tnfactt)
        Me.GroupBox2.Controls.Add(Me.cexercice)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.cnarticle)
        Me.GroupBox2.Controls.Add(Me.thistorique)
        Me.GroupBox2.Controls.Add(Me.cncommande)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(33, 86)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(486, 390)
        Me.GroupBox2.TabIndex = 100
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Etat de inventaire  :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(27, 329)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 16)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "N_fact"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(27, 301)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 16)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "date de radiation"
        '
        'cnarticle
        '
        Me.cnarticle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cnarticle.FormattingEnabled = True
        Me.cnarticle.Location = New System.Drawing.Point(189, 141)
        Me.cnarticle.Name = "cnarticle"
        Me.cnarticle.Size = New System.Drawing.Size(196, 24)
        Me.cnarticle.TabIndex = 67
        '
        'thistorique
        '
        Me.thistorique.Location = New System.Drawing.Point(189, 262)
        Me.thistorique.Name = "thistorique"
        Me.thistorique.Size = New System.Drawing.Size(196, 22)
        Me.thistorique.TabIndex = 52
        '
        'cncommande
        '
        Me.cncommande.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cncommande.FormattingEnabled = True
        Me.cncommande.Location = New System.Drawing.Point(189, 170)
        Me.cncommande.Name = "cncommande"
        Me.cncommande.Size = New System.Drawing.Size(196, 24)
        Me.cncommande.TabIndex = 68
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(30, 143)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 16)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "numéro d'article"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(30, 172)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(152, 16)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "numéro de commande"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(30, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "historique"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(30, 200)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 16)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "exercice"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(30, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 16)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "date d'affectation"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(373, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 37)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "Inventaire"
        '
        'dgv2
        '
        Me.dgv2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.Location = New System.Drawing.Point(515, 603)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.Size = New System.Drawing.Size(416, 118)
        Me.dgv2.TabIndex = 102
        '
        'dgv1
        '
        Me.dgv1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(-7, 482)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(938, 115)
        Me.dgv1.TabIndex = 99
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Timer1
        '
        '
        'Btn_Annuler
        '
        Me.Btn_Annuler.BackgroundImage = CType(resources.GetObject("Btn_Annuler.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Annuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Annuler.Location = New System.Drawing.Point(214, 46)
        Me.Btn_Annuler.Name = "Btn_Annuler"
        Me.Btn_Annuler.Size = New System.Drawing.Size(75, 49)
        Me.Btn_Annuler.TabIndex = 99
        Me.Btn_Annuler.Text = " "
        Me.Btn_Annuler.UseVisualStyleBackColor = True
        '
        'bmodifier
        '
        Me.bmodifier.BackgroundImage = CType(resources.GetObject("bmodifier.BackgroundImage"), System.Drawing.Image)
        Me.bmodifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bmodifier.Location = New System.Drawing.Point(86, 46)
        Me.bmodifier.Name = "bmodifier"
        Me.bmodifier.Size = New System.Drawing.Size(75, 49)
        Me.bmodifier.TabIndex = 98
        Me.bmodifier.Text = "modifier"
        Me.bmodifier.UseVisualStyleBackColor = True
        '
        'bsupprimer
        '
        Me.bsupprimer.BackgroundImage = CType(resources.GetObject("bsupprimer.BackgroundImage"), System.Drawing.Image)
        Me.bsupprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bsupprimer.Location = New System.Drawing.Point(86, 46)
        Me.bsupprimer.Name = "bsupprimer"
        Me.bsupprimer.Size = New System.Drawing.Size(75, 49)
        Me.bsupprimer.TabIndex = 97
        Me.bsupprimer.Text = " "
        Me.bsupprimer.UseVisualStyleBackColor = True
        '
        'bajouter
        '
        Me.bajouter.BackgroundImage = CType(resources.GetObject("bajouter.BackgroundImage"), System.Drawing.Image)
        Me.bajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bajouter.Location = New System.Drawing.Point(86, 46)
        Me.bajouter.Name = "bajouter"
        Me.bajouter.Size = New System.Drawing.Size(75, 49)
        Me.bajouter.TabIndex = 96
        Me.bajouter.UseVisualStyleBackColor = True
        '
        'inventaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(925, 746)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv2)
        Me.Controls.Add(Me.dgv1)
        Me.Name = "inventaire"
        Me.Text = "inventairevb"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tcode As System.Windows.Forms.Label
    Friend WithEvents trechercher As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ccde As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Tcodeinventaire As System.Windows.Forms.TextBox
    Friend WithEvents tmr As System.Windows.Forms.TextBox
    Friend WithEvents tnbl As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tnfactt As System.Windows.Forms.TextBox
    Friend WithEvents cexercice As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cnarticle As System.Windows.Forms.ComboBox
    Friend WithEvents thistorique As System.Windows.Forms.TextBox
    Friend WithEvents cncommande As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv2 As System.Windows.Forms.DataGridView
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Btn_Annuler As System.Windows.Forms.Button
    Friend WithEvents bmodifier As System.Windows.Forms.Button
    Friend WithEvents bsupprimer As System.Windows.Forms.Button
    Friend WithEvents bajouter As System.Windows.Forms.Button
End Class
