<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class produits
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(produits))
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.tproduit = New System.Windows.Forms.TextBox()
        Me.tcategorie = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.treferenceproduit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tcode = New System.Windows.Forms.Label()
        Me.trechercher = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Btn_Annuler = New System.Windows.Forms.Button()
        Me.bmodifier = New System.Windows.Forms.Button()
        Me.bsupprimer = New System.Windows.Forms.Button()
        Me.bajouter = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv1
        '
        Me.dgv1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgv1.BackgroundColor = System.Drawing.Color.Silver
        Me.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv1.Location = New System.Drawing.Point(203, 298)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(543, 167)
        Me.dgv1.TabIndex = 55
        '
        'tproduit
        '
        Me.tproduit.Location = New System.Drawing.Point(193, 128)
        Me.tproduit.Name = "tproduit"
        Me.tproduit.Size = New System.Drawing.Size(136, 22)
        Me.tproduit.TabIndex = 54
        '
        'tcategorie
        '
        Me.tcategorie.Location = New System.Drawing.Point(193, 88)
        Me.tcategorie.Name = "tcategorie"
        Me.tcategorie.Size = New System.Drawing.Size(136, 22)
        Me.tcategorie.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(19, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "produit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(19, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "catégorie"
        '
        'treferenceproduit
        '
        Me.treferenceproduit.Location = New System.Drawing.Point(193, 46)
        Me.treferenceproduit.Name = "treferenceproduit"
        Me.treferenceproduit.Size = New System.Drawing.Size(136, 22)
        Me.treferenceproduit.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(17, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 16)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "référence de produit"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(364, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 38)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Produit"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tcode)
        Me.GroupBox1.Controls.Add(Me.trechercher)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Script", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(15, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 56)
        Me.GroupBox1.TabIndex = 77
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rechercher par"
        '
        'tcode
        '
        Me.tcode.AutoSize = True
        Me.tcode.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tcode.Location = New System.Drawing.Point(6, 26)
        Me.tcode.Name = "tcode"
        Me.tcode.Size = New System.Drawing.Size(130, 16)
        Me.tcode.TabIndex = 37
        Me.tcode.Text = "référence de prduit"
        '
        'trechercher
        '
        Me.trechercher.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.trechercher.Location = New System.Drawing.Point(185, 23)
        Me.trechercher.Name = "trechercher"
        Me.trechercher.Size = New System.Drawing.Size(149, 28)
        Me.trechercher.TabIndex = 36
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.tproduit)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.treferenceproduit)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tcategorie)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(53, 84)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(348, 174)
        Me.GroupBox2.TabIndex = 78
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Etat Produit :"
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
        Me.GroupBox3.Location = New System.Drawing.Point(472, 90)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(393, 202)
        Me.GroupBox3.TabIndex = 79
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Manupilation :"
        '
        'Btn_Annuler
        '
        Me.Btn_Annuler.BackgroundImage = CType(resources.GetObject("Btn_Annuler.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Annuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Annuler.Location = New System.Drawing.Point(245, 50)
        Me.Btn_Annuler.Name = "Btn_Annuler"
        Me.Btn_Annuler.Size = New System.Drawing.Size(75, 49)
        Me.Btn_Annuler.TabIndex = 107
        Me.Btn_Annuler.Text = " "
        Me.Btn_Annuler.UseVisualStyleBackColor = True
        '
        'bmodifier
        '
        Me.bmodifier.BackgroundImage = CType(resources.GetObject("bmodifier.BackgroundImage"), System.Drawing.Image)
        Me.bmodifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bmodifier.Location = New System.Drawing.Point(106, 49)
        Me.bmodifier.Name = "bmodifier"
        Me.bmodifier.Size = New System.Drawing.Size(75, 49)
        Me.bmodifier.TabIndex = 106
        Me.bmodifier.Text = "modifier"
        Me.bmodifier.UseVisualStyleBackColor = True
        '
        'bsupprimer
        '
        Me.bsupprimer.BackgroundImage = CType(resources.GetObject("bsupprimer.BackgroundImage"), System.Drawing.Image)
        Me.bsupprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bsupprimer.Location = New System.Drawing.Point(106, 50)
        Me.bsupprimer.Name = "bsupprimer"
        Me.bsupprimer.Size = New System.Drawing.Size(75, 49)
        Me.bsupprimer.TabIndex = 105
        Me.bsupprimer.Text = " "
        Me.bsupprimer.UseVisualStyleBackColor = True
        '
        'bajouter
        '
        Me.bajouter.BackgroundImage = CType(resources.GetObject("bajouter.BackgroundImage"), System.Drawing.Image)
        Me.bajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bajouter.Location = New System.Drawing.Point(106, 50)
        Me.bajouter.Name = "bajouter"
        Me.bajouter.Size = New System.Drawing.Size(75, 49)
        Me.bajouter.TabIndex = 104
        Me.bajouter.UseVisualStyleBackColor = True
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
        'produits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(877, 477)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "produits"
        Me.Text = "Produit"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents tproduit As System.Windows.Forms.TextBox
    Friend WithEvents tcategorie As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents treferenceproduit As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tcode As System.Windows.Forms.Label
    Friend WithEvents trechercher As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Btn_Annuler As System.Windows.Forms.Button
    Friend WithEvents bmodifier As System.Windows.Forms.Button
    Friend WithEvents bsupprimer As System.Windows.Forms.Button
    Friend WithEvents bajouter As System.Windows.Forms.Button
End Class
