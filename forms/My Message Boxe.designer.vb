<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class My_Message_Boxe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(My_Message_Boxe))
        Me.depart = New System.Windows.Forms.Timer(Me.components)
        Me.mileu = New System.Windows.Forms.Timer(Me.components)
        Me.fin = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.cadre = New System.Windows.Forms.Panel()
        Me.Label_Ajouter = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label_Modifier = New System.Windows.Forms.Label()
        Me.Picture_modifier = New System.Windows.Forms.PictureBox()
        Me.Picture_ajouter = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Picture_supp = New System.Windows.Forms.PictureBox()
        Me.cadre.SuspendLayout()
        CType(Me.Picture_modifier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture_ajouter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture_supp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'depart
        '
        '
        'mileu
        '
        '
        'fin
        '
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'cadre
        '
        Me.cadre.Controls.Add(Me.Label_Ajouter)
        Me.cadre.Controls.Add(Me.Picture_modifier)
        Me.cadre.Controls.Add(Me.Label1)
        Me.cadre.Controls.Add(Me.Picture_ajouter)
        Me.cadre.Controls.Add(Me.PictureBox3)
        Me.cadre.Controls.Add(Me.Picture_supp)
        Me.cadre.Controls.Add(Me.label_Modifier)
        Me.cadre.Location = New System.Drawing.Point(0, -1)
        Me.cadre.Name = "cadre"
        Me.cadre.Size = New System.Drawing.Size(561, 238)
        Me.cadre.TabIndex = 4
        '
        'Label_Ajouter
        '
        Me.Label_Ajouter.AutoSize = True
        Me.Label_Ajouter.BackColor = System.Drawing.Color.Transparent
        Me.Label_Ajouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Ajouter.ForeColor = System.Drawing.Color.Green
        Me.Label_Ajouter.Location = New System.Drawing.Point(75, 110)
        Me.Label_Ajouter.Name = "Label_Ajouter"
        Me.Label_Ajouter.Size = New System.Drawing.Size(227, 24)
        Me.Label_Ajouter.TabIndex = 7
        Me.Label_Ajouter.Text = "AJOUT AVEC SUCCES"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "SUPRESSION AVEC SUCCES"
        '
        'label_Modifier
        '
        Me.label_Modifier.AutoSize = True
        Me.label_Modifier.BackColor = System.Drawing.Color.Transparent
        Me.label_Modifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_Modifier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label_Modifier.Location = New System.Drawing.Point(3, 110)
        Me.label_Modifier.Name = "label_Modifier"
        Me.label_Modifier.Size = New System.Drawing.Size(319, 24)
        Me.label_Modifier.TabIndex = 0
        Me.label_Modifier.Text = " MODIFICATION  AVEC SUCCES"
        '
        'Picture_modifier
        '
        Me.Picture_modifier.BackColor = System.Drawing.Color.Transparent
        Me.Picture_modifier.BackgroundImage = CType(resources.GetObject("Picture_modifier.BackgroundImage"), System.Drawing.Image)
        Me.Picture_modifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Picture_modifier.Location = New System.Drawing.Point(189, 148)
        Me.Picture_modifier.Name = "Picture_modifier"
        Me.Picture_modifier.Size = New System.Drawing.Size(55, 55)
        Me.Picture_modifier.TabIndex = 6
        Me.Picture_modifier.TabStop = False
        '
        'Picture_ajouter
        '
        Me.Picture_ajouter.BackgroundImage = CType(resources.GetObject("Picture_ajouter.BackgroundImage"), System.Drawing.Image)
        Me.Picture_ajouter.Location = New System.Drawing.Point(189, 148)
        Me.Picture_ajouter.Name = "Picture_ajouter"
        Me.Picture_ajouter.Size = New System.Drawing.Size(55, 55)
        Me.Picture_ajouter.TabIndex = 4
        Me.Picture_ajouter.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WindowsApplication1.My.Resources.Resources.Bonhomme_MSN_mini
        Me.PictureBox3.Location = New System.Drawing.Point(189, 33)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(49, 50)
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'Picture_supp
        '
        Me.Picture_supp.BackColor = System.Drawing.Color.Transparent
        Me.Picture_supp.BackgroundImage = CType(resources.GetObject("Picture_supp.BackgroundImage"), System.Drawing.Image)
        Me.Picture_supp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Picture_supp.Location = New System.Drawing.Point(189, 148)
        Me.Picture_supp.Name = "Picture_supp"
        Me.Picture_supp.Size = New System.Drawing.Size(55, 55)
        Me.Picture_supp.TabIndex = 1
        Me.Picture_supp.TabStop = False
        '
        'My_Message_Boxe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 214)
        Me.Controls.Add(Me.cadre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "My_Message_Boxe"
        Me.Text = "My_Message_Boxe"
        Me.TopMost = True
        Me.cadre.ResumeLayout(False)
        Me.cadre.PerformLayout()
        CType(Me.Picture_modifier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture_ajouter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture_supp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents depart As System.Windows.Forms.Timer
    Friend WithEvents mileu As System.Windows.Forms.Timer
    Friend WithEvents fin As System.Windows.Forms.Timer
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents cadre As System.Windows.Forms.Panel
    Friend WithEvents label_Modifier As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Picture_supp As System.Windows.Forms.PictureBox
    Friend WithEvents Picture_ajouter As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Picture_modifier As System.Windows.Forms.PictureBox
    Friend WithEvents Label_Ajouter As System.Windows.Forms.Label
End Class
