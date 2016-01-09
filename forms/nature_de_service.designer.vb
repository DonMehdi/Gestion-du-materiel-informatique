<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nature_de_service
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(nature_de_service))
        Me.Tcdenatserv = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tservfr = New System.Windows.Forms.TextBox()
        Me.tservar = New System.Windows.Forms.TextBox()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tcode = New System.Windows.Forms.Label()
        Me.trechercher = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Btn_Annuler = New System.Windows.Forms.Button()
        Me.bmodifier = New System.Windows.Forms.Button()
        Me.bsupprimer = New System.Windows.Forms.Button()
        Me.Bajouter = New System.Windows.Forms.Button()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tcdenatserv
        '
        Me.Tcdenatserv.Location = New System.Drawing.Point(162, 50)
        Me.Tcdenatserv.Name = "Tcdenatserv"
        Me.Tcdenatserv.Size = New System.Drawing.Size(136, 22)
        Me.Tcdenatserv.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 16)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "code nature service"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(274, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 35)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Nature de  Service"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "service francais"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 16)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "service arabe"
        '
        'tservfr
        '
        Me.tservfr.Location = New System.Drawing.Point(154, 99)
        Me.tservfr.Name = "tservfr"
        Me.tservfr.Size = New System.Drawing.Size(144, 22)
        Me.tservfr.TabIndex = 42
        '
        'tservar
        '
        Me.tservar.Location = New System.Drawing.Point(154, 147)
        Me.tservar.Name = "tservar"
        Me.tservar.Size = New System.Drawing.Size(144, 22)
        Me.tservar.TabIndex = 43
        '
        'dgv1
        '
        Me.dgv1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgv1.BackgroundColor = System.Drawing.Color.Silver
        Me.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(38, 303)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(797, 149)
        Me.dgv1.TabIndex = 44
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tcode)
        Me.GroupBox1.Controls.Add(Me.trechercher)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Script", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(28, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(377, 67)
        Me.GroupBox1.TabIndex = 77
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rechercher par"
        '
        'tcode
        '
        Me.tcode.AutoSize = True
        Me.tcode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tcode.Location = New System.Drawing.Point(57, 32)
        Me.tcode.Name = "tcode"
        Me.tcode.Size = New System.Drawing.Size(133, 16)
        Me.tcode.TabIndex = 37
        Me.tcode.Text = "code nature service"
        '
        'trechercher
        '
        Me.trechercher.Location = New System.Drawing.Point(205, 26)
        Me.trechercher.Name = "trechercher"
        Me.trechercher.Size = New System.Drawing.Size(149, 28)
        Me.trechercher.TabIndex = 36
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.tservfr)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Tcdenatserv)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tservar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(38, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(330, 191)
        Me.GroupBox2.TabIndex = 78
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Etat de nature_service :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.Btn_Annuler)
        Me.GroupBox3.Controls.Add(Me.bmodifier)
        Me.GroupBox3.Controls.Add(Me.bsupprimer)
        Me.GroupBox3.Controls.Add(Me.Bajouter)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(433, 92)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(411, 191)
        Me.GroupBox3.TabIndex = 79
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Manupilation :"
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
        Me.Btn_Annuler.Location = New System.Drawing.Point(233, 30)
        Me.Btn_Annuler.Name = "Btn_Annuler"
        Me.Btn_Annuler.Size = New System.Drawing.Size(75, 49)
        Me.Btn_Annuler.TabIndex = 103
        Me.Btn_Annuler.Text = " "
        Me.Btn_Annuler.UseVisualStyleBackColor = True
        '
        'bmodifier
        '
        Me.bmodifier.BackgroundImage = CType(resources.GetObject("bmodifier.BackgroundImage"), System.Drawing.Image)
        Me.bmodifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bmodifier.Location = New System.Drawing.Point(113, 30)
        Me.bmodifier.Name = "bmodifier"
        Me.bmodifier.Size = New System.Drawing.Size(75, 49)
        Me.bmodifier.TabIndex = 102
        Me.bmodifier.Text = "modifier"
        Me.bmodifier.UseVisualStyleBackColor = True
        '
        'bsupprimer
        '
        Me.bsupprimer.BackgroundImage = CType(resources.GetObject("bsupprimer.BackgroundImage"), System.Drawing.Image)
        Me.bsupprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bsupprimer.Location = New System.Drawing.Point(113, 30)
        Me.bsupprimer.Name = "bsupprimer"
        Me.bsupprimer.Size = New System.Drawing.Size(75, 49)
        Me.bsupprimer.TabIndex = 101
        Me.bsupprimer.Text = " "
        Me.bsupprimer.UseVisualStyleBackColor = True
        '
        'Bajouter
        '
        Me.Bajouter.BackgroundImage = CType(resources.GetObject("Bajouter.BackgroundImage"), System.Drawing.Image)
        Me.Bajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bajouter.Location = New System.Drawing.Point(113, 30)
        Me.Bajouter.Name = "Bajouter"
        Me.Bajouter.Size = New System.Drawing.Size(75, 49)
        Me.Bajouter.TabIndex = 100
        Me.Bajouter.UseVisualStyleBackColor = True
        '
        'nature_de_service
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(847, 464)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "nature_de_service"
        Me.Text = "nature_de_service"
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
    Friend WithEvents Tcdenatserv As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tservfr As System.Windows.Forms.TextBox
    Friend WithEvents tservar As System.Windows.Forms.TextBox
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
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
    Friend WithEvents Bajouter As System.Windows.Forms.Button
End Class
