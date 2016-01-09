<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class budget
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(budget))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.Bmodifier = New System.Windows.Forms.Button()
        Me.Bsupprimer = New System.Windows.Forms.Button()
        Me.Bajouter = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.trechercher = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Ttypebuget = New System.Windows.Forms.TextBox()
        Me.ttype = New System.Windows.Forms.TextBox()
        Me.tbudget = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_num_budget = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.btn_annuler)
        Me.GroupBox3.Controls.Add(Me.Bmodifier)
        Me.GroupBox3.Controls.Add(Me.Bsupprimer)
        Me.GroupBox3.Controls.Add(Me.Bajouter)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(508, 79)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(409, 210)
        Me.GroupBox3.TabIndex = 88
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Manupilation :"
        '
        'btn_annuler
        '
        Me.btn_annuler.BackgroundImage = CType(resources.GetObject("btn_annuler.BackgroundImage"), System.Drawing.Image)
        Me.btn_annuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_annuler.Location = New System.Drawing.Point(297, 46)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(75, 49)
        Me.btn_annuler.TabIndex = 83
        Me.btn_annuler.Text = " "
        Me.btn_annuler.UseVisualStyleBackColor = True
        '
        'Bmodifier
        '
        Me.Bmodifier.BackgroundImage = CType(resources.GetObject("Bmodifier.BackgroundImage"), System.Drawing.Image)
        Me.Bmodifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bmodifier.Location = New System.Drawing.Point(17, 48)
        Me.Bmodifier.Name = "Bmodifier"
        Me.Bmodifier.Size = New System.Drawing.Size(75, 44)
        Me.Bmodifier.TabIndex = 82
        Me.Bmodifier.Text = "modifier"
        Me.Bmodifier.UseVisualStyleBackColor = True
        '
        'Bsupprimer
        '
        Me.Bsupprimer.BackgroundImage = CType(resources.GetObject("Bsupprimer.BackgroundImage"), System.Drawing.Image)
        Me.Bsupprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bsupprimer.Location = New System.Drawing.Point(201, 48)
        Me.Bsupprimer.Name = "Bsupprimer"
        Me.Bsupprimer.Size = New System.Drawing.Size(75, 44)
        Me.Bsupprimer.TabIndex = 81
        Me.Bsupprimer.Text = " "
        Me.Bsupprimer.UseVisualStyleBackColor = True
        '
        'Bajouter
        '
        Me.Bajouter.BackgroundImage = CType(resources.GetObject("Bajouter.BackgroundImage"), System.Drawing.Image)
        Me.Bajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bajouter.Location = New System.Drawing.Point(109, 48)
        Me.Bajouter.Name = "Bajouter"
        Me.Bajouter.Size = New System.Drawing.Size(75, 44)
        Me.Bajouter.TabIndex = 80
        Me.Bajouter.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.trechercher)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Script", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(14, 144)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(380, 50)
        Me.GroupBox1.TabIndex = 77
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rechercher par :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(22, 32)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 16)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "numéro de budget"
        '
        'trechercher
        '
        Me.trechercher.Location = New System.Drawing.Point(187, 23)
        Me.trechercher.Margin = New System.Windows.Forms.Padding(4)
        Me.trechercher.Name = "trechercher"
        Me.trechercher.Size = New System.Drawing.Size(171, 28)
        Me.trechercher.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(7, 120)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "type"
        '
        'Ttypebuget
        '
        Me.Ttypebuget.Location = New System.Drawing.Point(187, 81)
        Me.Ttypebuget.Margin = New System.Windows.Forms.Padding(4)
        Me.Ttypebuget.Name = "Ttypebuget"
        Me.Ttypebuget.Size = New System.Drawing.Size(148, 26)
        Me.Ttypebuget.TabIndex = 17
        '
        'ttype
        '
        Me.ttype.Location = New System.Drawing.Point(187, 120)
        Me.ttype.Margin = New System.Windows.Forms.Padding(4)
        Me.ttype.Name = "ttype"
        Me.ttype.Size = New System.Drawing.Size(148, 26)
        Me.ttype.TabIndex = 18
        '
        'tbudget
        '
        Me.tbudget.Location = New System.Drawing.Point(187, 150)
        Me.tbudget.Margin = New System.Windows.Forms.Padding(4)
        Me.tbudget.Name = "tbudget"
        Me.tbudget.Size = New System.Drawing.Size(148, 26)
        Me.tbudget.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(7, 154)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "budget"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(426, 28)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 35)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Budget"
        '
        'dgv1
        '
        Me.dgv1.AllowUserToOrderColumns = True
        Me.dgv1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(54, 296)
        Me.dgv1.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(863, 185)
        Me.dgv1.TabIndex = 85
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(7, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "numéro de budget"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.txt_num_budget)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Ttypebuget)
        Me.GroupBox2.Controls.Add(Me.ttype)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tbudget)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(54, 79)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(399, 201)
        Me.GroupBox2.TabIndex = 87
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Etat de budget :"
        '
        'txt_num_budget
        '
        Me.txt_num_budget.Location = New System.Drawing.Point(187, 48)
        Me.txt_num_budget.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_num_budget.Name = "txt_num_budget"
        Me.txt_num_budget.Size = New System.Drawing.Size(148, 26)
        Me.txt_num_budget.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(7, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "type budget"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 20
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'budget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(987, 480)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "budget"
        Me.Text = "budget"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents trechercher As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Ttypebuget As System.Windows.Forms.TextBox
    Friend WithEvents ttype As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbudget As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txt_num_budget As System.Windows.Forms.TextBox
    Friend WithEvents Bajouter As System.Windows.Forms.Button
    Friend WithEvents Bsupprimer As System.Windows.Forms.Button
    Friend WithEvents Bmodifier As System.Windows.Forms.Button
    Friend WithEvents btn_annuler As System.Windows.Forms.Button
End Class
