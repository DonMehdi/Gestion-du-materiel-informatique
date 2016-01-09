<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Btn_annuler
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Btn_annuler))
        Me.tdivservar = New System.Windows.Forms.TextBox()
        Me.tdivservfr = New System.Windows.Forms.TextBox()
        Me.Tcdedivserv = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ccdenatserv = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tdivservabar = New System.Windows.Forms.TextBox()
        Me.tdivservabfr = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tdivservcourt = New System.Windows.Forms.TextBox()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.tcode = New System.Windows.Forms.Label()
        Me.trechercher = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Btn_Vider = New System.Windows.Forms.Button()
        Me.bmodifier = New System.Windows.Forms.Button()
        Me.bsupprimer = New System.Windows.Forms.Button()
        Me.bajouter = New System.Windows.Forms.Button()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tdivservar
        '
        Me.tdivservar.Location = New System.Drawing.Point(188, 246)
        Me.tdivservar.Name = "tdivservar"
        Me.tdivservar.Size = New System.Drawing.Size(187, 22)
        Me.tdivservar.TabIndex = 39
        '
        'tdivservfr
        '
        Me.tdivservfr.Location = New System.Drawing.Point(193, 123)
        Me.tdivservfr.Name = "tdivservfr"
        Me.tdivservfr.Size = New System.Drawing.Size(183, 22)
        Me.tdivservfr.TabIndex = 38
        '
        'Tcdedivserv
        '
        Me.Tcdedivserv.Location = New System.Drawing.Point(193, 50)
        Me.Tcdedivserv.Name = "Tcdedivserv"
        Me.Tcdedivserv.Size = New System.Drawing.Size(182, 22)
        Me.Tcdedivserv.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(6, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 16)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "divservar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(6, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "code nature service"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "code division de service"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(298, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 32)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Les Divisions de Services"
        '
        'ccdenatserv
        '
        Me.ccdenatserv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ccdenatserv.FormattingEnabled = True
        Me.ccdenatserv.Location = New System.Drawing.Point(193, 82)
        Me.ccdenatserv.Name = "ccdenatserv"
        Me.ccdenatserv.Size = New System.Drawing.Size(182, 24)
        Me.ccdenatserv.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(6, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "divservfr"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(6, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 16)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "divservabfr"
        '
        'tdivservabar
        '
        Me.tdivservabar.Location = New System.Drawing.Point(193, 285)
        Me.tdivservabar.Name = "tdivservabar"
        Me.tdivservabar.Size = New System.Drawing.Size(182, 22)
        Me.tdivservabar.TabIndex = 48
        '
        'tdivservabfr
        '
        Me.tdivservabfr.Location = New System.Drawing.Point(189, 162)
        Me.tdivservabfr.Name = "tdivservabfr"
        Me.tdivservabfr.Size = New System.Drawing.Size(187, 22)
        Me.tdivservabfr.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(6, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 16)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "divservabar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(6, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 16)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "divservcourt"
        '
        'tdivservcourt
        '
        Me.tdivservcourt.Location = New System.Drawing.Point(189, 208)
        Me.tdivservcourt.Name = "tdivservcourt"
        Me.tdivservcourt.Size = New System.Drawing.Size(186, 22)
        Me.tdivservcourt.TabIndex = 50
        '
        'dgv1
        '
        Me.dgv1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(12, 405)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(883, 129)
        Me.dgv1.TabIndex = 52
        '
        'tcode
        '
        Me.tcode.AutoSize = True
        Me.tcode.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tcode.Location = New System.Drawing.Point(6, 36)
        Me.tcode.Name = "tcode"
        Me.tcode.Size = New System.Drawing.Size(161, 16)
        Me.tcode.TabIndex = 37
        Me.tcode.Text = "code division de service"
        '
        'trechercher
        '
        Me.trechercher.Location = New System.Drawing.Point(218, 30)
        Me.trechercher.Name = "trechercher"
        Me.trechercher.Size = New System.Drawing.Size(149, 22)
        Me.trechercher.TabIndex = 36
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.tdivservar)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Tcdedivserv)
        Me.GroupBox2.Controls.Add(Me.tdivservfr)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.ccdenatserv)
        Me.GroupBox2.Controls.Add(Me.tdivservcourt)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tdivservabar)
        Me.GroupBox2.Controls.Add(Me.tdivservabfr)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(23, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(395, 311)
        Me.GroupBox2.TabIndex = 79
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Etat de division_services  :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.Btn_Vider)
        Me.GroupBox3.Controls.Add(Me.bmodifier)
        Me.GroupBox3.Controls.Add(Me.bsupprimer)
        Me.GroupBox3.Controls.Add(Me.bajouter)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(450, 88)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(435, 299)
        Me.GroupBox3.TabIndex = 80
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Manupilation :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.trechercher)
        Me.GroupBox1.Controls.Add(Me.tcode)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 186)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 73)
        Me.GroupBox1.TabIndex = 79
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rechercher par"
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
        'Btn_Vider
        '
        Me.Btn_Vider.BackgroundImage = CType(resources.GetObject("Btn_Vider.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Vider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Vider.Location = New System.Drawing.Point(307, 68)
        Me.Btn_Vider.Name = "Btn_Vider"
        Me.Btn_Vider.Size = New System.Drawing.Size(75, 49)
        Me.Btn_Vider.TabIndex = 91
        Me.Btn_Vider.Text = " "
        Me.Btn_Vider.UseVisualStyleBackColor = True
        '
        'bmodifier
        '
        Me.bmodifier.BackgroundImage = CType(resources.GetObject("bmodifier.BackgroundImage"), System.Drawing.Image)
        Me.bmodifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bmodifier.Location = New System.Drawing.Point(122, 68)
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
        Me.bsupprimer.Location = New System.Drawing.Point(213, 68)
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
        Me.bajouter.Location = New System.Drawing.Point(31, 68)
        Me.bajouter.Name = "bajouter"
        Me.bajouter.Size = New System.Drawing.Size(75, 49)
        Me.bajouter.TabIndex = 88
        Me.bajouter.UseVisualStyleBackColor = True
        '
        'Btn_annuler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(907, 546)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Btn_annuler"
        Me.Text = "division_des_services"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tdivservar As System.Windows.Forms.TextBox
    Friend WithEvents tdivservfr As System.Windows.Forms.TextBox
    Friend WithEvents Tcdedivserv As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ccdenatserv As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tdivservabar As System.Windows.Forms.TextBox
    Friend WithEvents tdivservabfr As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tdivservcourt As System.Windows.Forms.TextBox
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents tcode As System.Windows.Forms.Label
    Friend WithEvents trechercher As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Btn_Vider As System.Windows.Forms.Button
    Friend WithEvents bmodifier As System.Windows.Forms.Button
    Friend WithEvents bsupprimer As System.Windows.Forms.Button
    Friend WithEvents bajouter As System.Windows.Forms.Button
End Class
