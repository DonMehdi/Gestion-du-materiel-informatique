<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detail_commande
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(detail_commande))
        Me.tdesignation = New System.Windows.Forms.TextBox()
        Me.tqte = New System.Windows.Forms.TextBox()
        Me.tprixunitaire = New System.Windows.Forms.TextBox()
        Me.tremarques = New System.Windows.Forms.TextBox()
        Me.Tnartcle = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dataGridView = New System.Windows.Forms.DataGridView()
        Me.creferenceproduit = New System.Windows.Forms.ComboBox()
        Me.cexercice = New System.Windows.Forms.ComboBox()
        Me.cncommande = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroboxRechercher = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Btn_Annuler = New System.Windows.Forms.Button()
        Me.bmodifier = New System.Windows.Forms.Button()
        Me.bsupprimer = New System.Windows.Forms.Button()
        Me.bajouter = New System.Windows.Forms.Button()
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroboxRechercher.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tdesignation
        '
        Me.tdesignation.Font = New System.Drawing.Font("Segoe Print", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdesignation.ForeColor = System.Drawing.Color.Black
        Me.tdesignation.Location = New System.Drawing.Point(236, 260)
        Me.tdesignation.Multiline = True
        Me.tdesignation.Name = "tdesignation"
        Me.tdesignation.Size = New System.Drawing.Size(159, 20)
        Me.tdesignation.TabIndex = 33
        '
        'tqte
        '
        Me.tqte.Font = New System.Drawing.Font("Segoe Print", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tqte.ForeColor = System.Drawing.Color.Black
        Me.tqte.Location = New System.Drawing.Point(236, 224)
        Me.tqte.Multiline = True
        Me.tqte.Name = "tqte"
        Me.tqte.Size = New System.Drawing.Size(159, 20)
        Me.tqte.TabIndex = 32
        '
        'tprixunitaire
        '
        Me.tprixunitaire.Font = New System.Drawing.Font("Segoe Print", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tprixunitaire.ForeColor = System.Drawing.Color.Black
        Me.tprixunitaire.Location = New System.Drawing.Point(236, 194)
        Me.tprixunitaire.Multiline = True
        Me.tprixunitaire.Name = "tprixunitaire"
        Me.tprixunitaire.Size = New System.Drawing.Size(159, 20)
        Me.tprixunitaire.TabIndex = 31
        '
        'tremarques
        '
        Me.tremarques.Font = New System.Drawing.Font("Segoe Print", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tremarques.ForeColor = System.Drawing.Color.Black
        Me.tremarques.Location = New System.Drawing.Point(476, 65)
        Me.tremarques.Multiline = True
        Me.tremarques.Name = "tremarques"
        Me.tremarques.Size = New System.Drawing.Size(285, 112)
        Me.tremarques.TabIndex = 29
        '
        'Tnartcle
        '
        Me.Tnartcle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Tnartcle.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Tnartcle.ForeColor = System.Drawing.Color.Black
        Me.Tnartcle.Location = New System.Drawing.Point(236, 53)
        Me.Tnartcle.Multiline = True
        Me.Tnartcle.Name = "Tnartcle"
        Me.Tnartcle.Size = New System.Drawing.Size(159, 20)
        Me.Tnartcle.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(461, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 16)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Remarques :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(21, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 16)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "reférance de produit"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(21, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 16)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "quantité"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(21, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "designation"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(21, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Prix unitaire"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(21, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "exercice"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(21, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "numéro de commande"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(21, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "numéro d'article"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(320, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 31)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Detaile de Commande"
        '
        'dataGridView
        '
        Me.dataGridView.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView.Location = New System.Drawing.Point(38, 569)
        Me.dataGridView.Name = "dataGridView"
        Me.dataGridView.Size = New System.Drawing.Size(870, 156)
        Me.dataGridView.TabIndex = 34
        '
        'creferenceproduit
        '
        Me.creferenceproduit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.creferenceproduit.FormattingEnabled = True
        Me.creferenceproduit.Location = New System.Drawing.Point(236, 121)
        Me.creferenceproduit.Name = "creferenceproduit"
        Me.creferenceproduit.Size = New System.Drawing.Size(159, 24)
        Me.creferenceproduit.TabIndex = 35
        '
        'cexercice
        '
        Me.cexercice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cexercice.FormattingEnabled = True
        Me.cexercice.Location = New System.Drawing.Point(236, 88)
        Me.cexercice.Name = "cexercice"
        Me.cexercice.Size = New System.Drawing.Size(159, 24)
        Me.cexercice.TabIndex = 36
        '
        'cncommande
        '
        Me.cncommande.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cncommande.FormattingEnabled = True
        Me.cncommande.Location = New System.Drawing.Point(236, 153)
        Me.cncommande.Name = "cncommande"
        Me.cncommande.Size = New System.Drawing.Size(159, 24)
        Me.cncommande.TabIndex = 37
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.creferenceproduit)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cncommande)
        Me.GroupBox2.Controls.Add(Me.tdesignation)
        Me.GroupBox2.Controls.Add(Me.Tnartcle)
        Me.GroupBox2.Controls.Add(Me.tremarques)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cexercice)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.tqte)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.tprixunitaire)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 83)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(922, 313)
        Me.GroupBox2.TabIndex = 78
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Etat de Detail Commande :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.Btn_Annuler)
        Me.GroupBox3.Controls.Add(Me.bmodifier)
        Me.GroupBox3.Controls.Add(Me.bsupprimer)
        Me.GroupBox3.Controls.Add(Me.bajouter)
        Me.GroupBox3.Controls.Add(Me.GroboxRechercher)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(97, 402)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(783, 153)
        Me.GroupBox3.TabIndex = 79
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Manupilation :"
        '
        'GroboxRechercher
        '
        Me.GroboxRechercher.Controls.Add(Me.TextBox1)
        Me.GroboxRechercher.Controls.Add(Me.Label10)
        Me.GroboxRechercher.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroboxRechercher.ForeColor = System.Drawing.Color.Blue
        Me.GroboxRechercher.Location = New System.Drawing.Point(340, 20)
        Me.GroboxRechercher.Name = "GroboxRechercher"
        Me.GroboxRechercher.Size = New System.Drawing.Size(410, 113)
        Me.GroboxRechercher.TabIndex = 41
        Me.GroboxRechercher.TabStop = False
        Me.GroboxRechercher.Text = "Rechercher :"
        Me.GroboxRechercher.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("NSimSun", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(110, 74)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(159, 20)
        Me.TextBox1.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(23, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "numéro d'article:"
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
        'Btn_Annuler
        '
        Me.Btn_Annuler.BackgroundImage = CType(resources.GetObject("Btn_Annuler.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Annuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Annuler.Location = New System.Drawing.Point(177, 55)
        Me.Btn_Annuler.Name = "Btn_Annuler"
        Me.Btn_Annuler.Size = New System.Drawing.Size(75, 49)
        Me.Btn_Annuler.TabIndex = 91
        Me.Btn_Annuler.Text = " "
        Me.Btn_Annuler.UseVisualStyleBackColor = True
        '
        'bmodifier
        '
        Me.bmodifier.BackgroundImage = CType(resources.GetObject("bmodifier.BackgroundImage"), System.Drawing.Image)
        Me.bmodifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bmodifier.Location = New System.Drawing.Point(37, 55)
        Me.bmodifier.Name = "bmodifier"
        Me.bmodifier.Size = New System.Drawing.Size(75, 49)
        Me.bmodifier.TabIndex = 90
        Me.bmodifier.Text = "modifier"
        Me.bmodifier.UseVisualStyleBackColor = True
        '
        'bsupprimer
        '
        Me.bsupprimer.BackgroundImage = CType(resources.GetObject("bsupprimer.BackgroundImage"), System.Drawing.Image)
        Me.bsupprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bsupprimer.Location = New System.Drawing.Point(37, 55)
        Me.bsupprimer.Name = "bsupprimer"
        Me.bsupprimer.Size = New System.Drawing.Size(75, 49)
        Me.bsupprimer.TabIndex = 89
        Me.bsupprimer.Text = " "
        Me.bsupprimer.UseVisualStyleBackColor = True
        '
        'bajouter
        '
        Me.bajouter.BackgroundImage = CType(resources.GetObject("bajouter.BackgroundImage"), System.Drawing.Image)
        Me.bajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bajouter.Location = New System.Drawing.Point(37, 55)
        Me.bajouter.Name = "bajouter"
        Me.bajouter.Size = New System.Drawing.Size(75, 49)
        Me.bajouter.TabIndex = 88
        Me.bajouter.UseVisualStyleBackColor = True
        '
        'detail_commande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(946, 756)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dataGridView)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "detail_commande"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "détail_commande"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroboxRechercher.ResumeLayout(False)
        Me.GroboxRechercher.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tdesignation As System.Windows.Forms.TextBox
    Friend WithEvents tqte As System.Windows.Forms.TextBox
    Friend WithEvents tprixunitaire As System.Windows.Forms.TextBox
    Friend WithEvents tremarques As System.Windows.Forms.TextBox
    Friend WithEvents Tnartcle As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents creferenceproduit As System.Windows.Forms.ComboBox
    Friend WithEvents cexercice As System.Windows.Forms.ComboBox
    Friend WithEvents cncommande As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroboxRechercher As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Btn_Annuler As System.Windows.Forms.Button
    Friend WithEvents bmodifier As System.Windows.Forms.Button
    Friend WithEvents bsupprimer As System.Windows.Forms.Button
    Friend WithEvents bajouter As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
