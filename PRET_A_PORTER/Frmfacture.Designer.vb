<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmfacture
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmfacture))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Grdfacture = New System.Windows.Forms.DataGridView
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.txttaux = New System.Windows.Forms.TextBox
        Me.Datetampon = New System.Windows.Forms.DateTimePicker
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Txttotalpayer = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtidtaux = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnModifier = New System.Windows.Forms.Button
        Me.BtnRetirer = New System.Windows.Forms.Button
        Me.BtnInserer = New System.Windows.Forms.Button
        Me.grdvalid = New System.Windows.Forms.DataGridView
        Me.idfacture_PK = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.beneficeart = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nompersonne_FK = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idpersonne = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.idarticle = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.article = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.quantitevendue = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.prixunit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.monttotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.datefact = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.qtestock = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.beneficearticlevendu = New System.Windows.Forms.TextBox
        Me.beneficearticle = New System.Windows.Forms.TextBox
        Me.idprofil = New System.Windows.Forms.Label
        Me.Txtiduser = New System.Windows.Forms.Label
        Me.Txtnomprenom = New System.Windows.Forms.Label
        Me.fact = New System.Windows.Forms.Label
        Me.txtnumfact = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Txt_montantfacture = New System.Windows.Forms.TextBox
        Me.TxtCalculReduct = New System.Windows.Forms.TextBox
        Me.Txtlibarticle = New System.Windows.Forms.TextBox
        Me.Grdqte = New System.Windows.Forms.DataGridView
        Me.dateenregistrement = New System.Windows.Forms.DateTimePicker
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Txtqtedispo = New System.Windows.Forms.TextBox
        Me.Txtprixunit = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.idpersonne_FK = New System.Windows.Forms.TextBox
        Me.BtnRechCam = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.nompersonne = New System.Windows.Forms.TextBox
        Me.cmb_libelleart = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.idarticle_FK = New System.Windows.Forms.TextBox
        Me.Txtidfacture_PK = New System.Windows.Forms.TextBox
        Me.Lb_datefacture = New System.Windows.Forms.Label
        Me.Lb_montantfacture = New System.Windows.Forms.Label
        Me.Txtquantitevendue = New System.Windows.Forms.TextBox
        Me.Lb_quantitevendue = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtTotal = New System.Windows.Forms.TextBox
        Me.CmbTauxReduct = New System.Windows.Forms.ComboBox
        Me.NewToolStripButton = New System.Windows.Forms.Button
        Me.SaveToolStripButton = New System.Windows.Forms.Button
        Me.DelToolStripButton = New System.Windows.Forms.Button
        Me.CloseStripButton = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Grdfacture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdvalid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grdqte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(965, 614)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Grdfacture)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(957, 588)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Liste "
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Grdfacture
        '
        Me.Grdfacture.AllowUserToAddRows = False
        Me.Grdfacture.AllowUserToDeleteRows = False
        Me.Grdfacture.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Grdfacture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grdfacture.Location = New System.Drawing.Point(3, 6)
        Me.Grdfacture.Name = "Grdfacture"
        Me.Grdfacture.ReadOnly = True
        Me.Grdfacture.RowHeadersVisible = False
        Me.Grdfacture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grdfacture.Size = New System.Drawing.Size(948, 576)
        Me.Grdfacture.TabIndex = 0
        Me.Grdfacture.Tag = "FACTURE"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txttaux)
        Me.TabPage2.Controls.Add(Me.Datetampon)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.txtidtaux)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.Label24)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.TxtTotal)
        Me.TabPage2.Controls.Add(Me.CmbTauxReduct)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(957, 588)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Saisie "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txttaux
        '
        Me.txttaux.BackColor = System.Drawing.Color.LightGray
        Me.txttaux.Enabled = False
        Me.txttaux.Location = New System.Drawing.Point(97, 517)
        Me.txttaux.Name = "txttaux"
        Me.txttaux.Size = New System.Drawing.Size(29, 20)
        Me.txttaux.TabIndex = 252
        Me.txttaux.Tag = "taux"
        Me.txttaux.Visible = False
        '
        'Datetampon
        '
        Me.Datetampon.CustomFormat = "yyyy-MM-dd"
        Me.Datetampon.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Datetampon.Location = New System.Drawing.Point(616, 5)
        Me.Datetampon.Name = "Datetampon"
        Me.Datetampon.Size = New System.Drawing.Size(105, 20)
        Me.Datetampon.TabIndex = 254
        Me.Datetampon.Value = New Date(2014, 12, 29, 0, 0, 0, 0)
        Me.Datetampon.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Txttotalpayer)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(467, 500)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(459, 57)
        Me.GroupBox3.TabIndex = 241
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total"
        '
        'Txttotalpayer
        '
        Me.Txttotalpayer.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Txttotalpayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txttotalpayer.ForeColor = System.Drawing.Color.Red
        Me.Txttotalpayer.Location = New System.Drawing.Point(274, 19)
        Me.Txttotalpayer.Name = "Txttotalpayer"
        Me.Txttotalpayer.ReadOnly = True
        Me.Txttotalpayer.Size = New System.Drawing.Size(171, 22)
        Me.Txttotalpayer.TabIndex = 246
        Me.Txttotalpayer.Tag = "totalpayer"
        Me.Txttotalpayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(50, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(217, 13)
        Me.Label6.TabIndex = 240
        Me.Label6.Text = "Total à payer par le Client ------------->"
        '
        'txtidtaux
        '
        Me.txtidtaux.BackColor = System.Drawing.Color.LightGray
        Me.txtidtaux.Enabled = False
        Me.txtidtaux.Location = New System.Drawing.Point(335, 519)
        Me.txtidtaux.Name = "txtidtaux"
        Me.txtidtaux.Size = New System.Drawing.Size(29, 20)
        Me.txtidtaux.TabIndex = 251
        Me.txtidtaux.Tag = "idtaux_FK"
        Me.txtidtaux.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnModifier)
        Me.GroupBox2.Controls.Add(Me.BtnRetirer)
        Me.GroupBox2.Controls.Add(Me.BtnInserer)
        Me.GroupBox2.Controls.Add(Me.grdvalid)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(10, 215)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(915, 269)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Validation"
        '
        'BtnModifier
        '
        Me.BtnModifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModifier.Location = New System.Drawing.Point(240, 21)
        Me.BtnModifier.Name = "BtnModifier"
        Me.BtnModifier.Size = New System.Drawing.Size(94, 23)
        Me.BtnModifier.TabIndex = 248
        Me.BtnModifier.Text = "Modifier ligne"
        Me.BtnModifier.UseVisualStyleBackColor = True
        '
        'BtnRetirer
        '
        Me.BtnRetirer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnRetirer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRetirer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRetirer.Location = New System.Drawing.Point(129, 21)
        Me.BtnRetirer.Name = "BtnRetirer"
        Me.BtnRetirer.Size = New System.Drawing.Size(94, 23)
        Me.BtnRetirer.TabIndex = 247
        Me.BtnRetirer.Text = "Enlever ligne"
        Me.BtnRetirer.UseVisualStyleBackColor = True
        '
        'BtnInserer
        '
        Me.BtnInserer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnInserer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInserer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInserer.Location = New System.Drawing.Point(18, 21)
        Me.BtnInserer.Name = "BtnInserer"
        Me.BtnInserer.Size = New System.Drawing.Size(94, 23)
        Me.BtnInserer.TabIndex = 246
        Me.BtnInserer.Text = "&Valider Ligne"
        Me.BtnInserer.UseVisualStyleBackColor = True
        '
        'grdvalid
        '
        Me.grdvalid.AllowUserToAddRows = False
        Me.grdvalid.AllowUserToDeleteRows = False
        Me.grdvalid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdvalid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idfacture_PK, Me.beneficeart, Me.nompersonne_FK, Me.idpersonne, Me.idarticle, Me.article, Me.quantitevendue, Me.prixunit, Me.monttotal, Me.datefact, Me.qtestock})
        Me.grdvalid.Location = New System.Drawing.Point(6, 49)
        Me.grdvalid.Name = "grdvalid"
        Me.grdvalid.ReadOnly = True
        Me.grdvalid.RowHeadersVisible = False
        Me.grdvalid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdvalid.Size = New System.Drawing.Size(887, 220)
        Me.grdvalid.TabIndex = 0
        Me.grdvalid.Tag = "FACTURE"
        '
        'idfacture_PK
        '
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        Me.idfacture_PK.DefaultCellStyle = DataGridViewCellStyle4
        Me.idfacture_PK.HeaderText = "idfacture_PK"
        Me.idfacture_PK.Name = "idfacture_PK"
        Me.idfacture_PK.ReadOnly = True
        Me.idfacture_PK.Visible = False
        Me.idfacture_PK.Width = 300
        '
        'beneficeart
        '
        Me.beneficeart.HeaderText = "Bénéfice sur article vendu"
        Me.beneficeart.Name = "beneficeart"
        Me.beneficeart.ReadOnly = True
        Me.beneficeart.Width = 300
        '
        'nompersonne_FK
        '
        Me.nompersonne_FK.HeaderText = "Client"
        Me.nompersonne_FK.Name = "nompersonne_FK"
        Me.nompersonne_FK.ReadOnly = True
        Me.nompersonne_FK.Visible = False
        '
        'idpersonne
        '
        Me.idpersonne.HeaderText = "idpersonne_PK"
        Me.idpersonne.Name = "idpersonne"
        Me.idpersonne.ReadOnly = True
        Me.idpersonne.Visible = False
        '
        'idarticle
        '
        Me.idarticle.HeaderText = "idarticle_FK"
        Me.idarticle.Name = "idarticle"
        Me.idarticle.ReadOnly = True
        Me.idarticle.Visible = False
        '
        'article
        '
        Me.article.HeaderText = "ARTICLE"
        Me.article.Name = "article"
        Me.article.ReadOnly = True
        Me.article.Width = 300
        '
        'quantitevendue
        '
        Me.quantitevendue.HeaderText = "QUANTITE ACHETER"
        Me.quantitevendue.Name = "quantitevendue"
        Me.quantitevendue.ReadOnly = True
        Me.quantitevendue.Width = 300
        '
        'prixunit
        '
        Me.prixunit.HeaderText = "PRIX UNITAIRE"
        Me.prixunit.Name = "prixunit"
        Me.prixunit.ReadOnly = True
        Me.prixunit.Width = 300
        '
        'monttotal
        '
        Me.monttotal.HeaderText = "MONTANT TOTAL"
        Me.monttotal.Name = "monttotal"
        Me.monttotal.ReadOnly = True
        Me.monttotal.Width = 300
        '
        'datefact
        '
        Me.datefact.HeaderText = "DATE FACTURE"
        Me.datefact.Name = "datefact"
        Me.datefact.ReadOnly = True
        Me.datefact.Visible = False
        Me.datefact.Width = 300
        '
        'qtestock
        '
        Me.qtestock.HeaderText = "qtestock"
        Me.qtestock.Name = "qtestock"
        Me.qtestock.ReadOnly = True
        Me.qtestock.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.beneficearticlevendu)
        Me.GroupBox1.Controls.Add(Me.beneficearticle)
        Me.GroupBox1.Controls.Add(Me.idprofil)
        Me.GroupBox1.Controls.Add(Me.Txtiduser)
        Me.GroupBox1.Controls.Add(Me.Txtnomprenom)
        Me.GroupBox1.Controls.Add(Me.fact)
        Me.GroupBox1.Controls.Add(Me.txtnumfact)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Txt_montantfacture)
        Me.GroupBox1.Controls.Add(Me.TxtCalculReduct)
        Me.GroupBox1.Controls.Add(Me.Txtlibarticle)
        Me.GroupBox1.Controls.Add(Me.Grdqte)
        Me.GroupBox1.Controls.Add(Me.dateenregistrement)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Txtqtedispo)
        Me.GroupBox1.Controls.Add(Me.Txtprixunit)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.idpersonne_FK)
        Me.GroupBox1.Controls.Add(Me.BtnRechCam)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.nompersonne)
        Me.GroupBox1.Controls.Add(Me.cmb_libelleart)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.idarticle_FK)
        Me.GroupBox1.Controls.Add(Me.Txtidfacture_PK)
        Me.GroupBox1.Controls.Add(Me.Lb_datefacture)
        Me.GroupBox1.Controls.Add(Me.Lb_montantfacture)
        Me.GroupBox1.Controls.Add(Me.Txtquantitevendue)
        Me.GroupBox1.Controls.Add(Me.Lb_quantitevendue)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(915, 183)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = "FACTURE"
        Me.GroupBox1.Text = "données"
        '
        'beneficearticlevendu
        '
        Me.beneficearticlevendu.BackColor = System.Drawing.SystemColors.HighlightText
        Me.beneficearticlevendu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.beneficearticlevendu.ForeColor = System.Drawing.Color.Blue
        Me.beneficearticlevendu.Location = New System.Drawing.Point(252, 141)
        Me.beneficearticlevendu.Name = "beneficearticlevendu"
        Me.beneficearticlevendu.Size = New System.Drawing.Size(101, 20)
        Me.beneficearticlevendu.TabIndex = 259
        Me.beneficearticlevendu.Tag = "beneficearticle"
        Me.beneficearticlevendu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.beneficearticlevendu.Visible = False
        '
        'beneficearticle
        '
        Me.beneficearticle.BackColor = System.Drawing.SystemColors.HighlightText
        Me.beneficearticle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.beneficearticle.ForeColor = System.Drawing.Color.Blue
        Me.beneficearticle.Location = New System.Drawing.Point(154, 141)
        Me.beneficearticle.Name = "beneficearticle"
        Me.beneficearticle.Size = New System.Drawing.Size(84, 20)
        Me.beneficearticle.TabIndex = 258
        Me.beneficearticle.Tag = "beneficearticle"
        Me.beneficearticle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.beneficearticle.Visible = False
        '
        'idprofil
        '
        Me.idprofil.AutoSize = True
        Me.idprofil.Location = New System.Drawing.Point(291, 153)
        Me.idprofil.Name = "idprofil"
        Me.idprofil.Size = New System.Drawing.Size(0, 16)
        Me.idprofil.TabIndex = 257
        Me.idprofil.Visible = False
        '
        'Txtiduser
        '
        Me.Txtiduser.AutoSize = True
        Me.Txtiduser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtiduser.Location = New System.Drawing.Point(568, 158)
        Me.Txtiduser.Name = "Txtiduser"
        Me.Txtiduser.Size = New System.Drawing.Size(0, 15)
        Me.Txtiduser.TabIndex = 256
        Me.Txtiduser.Visible = False
        '
        'Txtnomprenom
        '
        Me.Txtnomprenom.AutoSize = True
        Me.Txtnomprenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnomprenom.Location = New System.Drawing.Point(568, 158)
        Me.Txtnomprenom.Name = "Txtnomprenom"
        Me.Txtnomprenom.Size = New System.Drawing.Size(0, 15)
        Me.Txtnomprenom.TabIndex = 255
        Me.Txtnomprenom.Visible = False
        '
        'fact
        '
        Me.fact.AutoSize = True
        Me.fact.Location = New System.Drawing.Point(170, 23)
        Me.fact.Name = "fact"
        Me.fact.Size = New System.Drawing.Size(52, 16)
        Me.fact.TabIndex = 253
        Me.fact.Text = "FACT-"
        Me.fact.Visible = False
        '
        'txtnumfact
        '
        Me.txtnumfact.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtnumfact.Enabled = False
        Me.txtnumfact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumfact.Location = New System.Drawing.Point(154, 23)
        Me.txtnumfact.Name = "txtnumfact"
        Me.txtnumfact.Size = New System.Drawing.Size(99, 21)
        Me.txtnumfact.TabIndex = 252
        Me.txtnumfact.Tag = ""
        Me.txtnumfact.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 15)
        Me.Label5.TabIndex = 251
        Me.Label5.Text = "Numéro Facture"
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(437, 156)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(106, 13)
        Me.Label23.TabIndex = 244
        Me.Label23.Text = "Montant Réduction"
        Me.Label23.Visible = False
        '
        'Txt_montantfacture
        '
        Me.Txt_montantfacture.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Txt_montantfacture.Enabled = False
        Me.Txt_montantfacture.Location = New System.Drawing.Point(592, 119)
        Me.Txt_montantfacture.Name = "Txt_montantfacture"
        Me.Txt_montantfacture.Size = New System.Drawing.Size(176, 22)
        Me.Txt_montantfacture.TabIndex = 211
        Me.Txt_montantfacture.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtCalculReduct
        '
        Me.TxtCalculReduct.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtCalculReduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCalculReduct.ForeColor = System.Drawing.Color.Blue
        Me.TxtCalculReduct.Location = New System.Drawing.Point(557, 153)
        Me.TxtCalculReduct.Name = "TxtCalculReduct"
        Me.TxtCalculReduct.Size = New System.Drawing.Size(181, 20)
        Me.TxtCalculReduct.TabIndex = 242
        Me.TxtCalculReduct.Tag = "CalculReduct"
        Me.TxtCalculReduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtCalculReduct.Visible = False
        '
        'Txtlibarticle
        '
        Me.Txtlibarticle.BackColor = System.Drawing.Color.LightGray
        Me.Txtlibarticle.Enabled = False
        Me.Txtlibarticle.Location = New System.Drawing.Point(808, 33)
        Me.Txtlibarticle.Name = "Txtlibarticle"
        Me.Txtlibarticle.Size = New System.Drawing.Size(29, 22)
        Me.Txtlibarticle.TabIndex = 250
        Me.Txtlibarticle.Tag = "libarticle"
        Me.Txtlibarticle.Visible = False
        '
        'Grdqte
        '
        Me.Grdqte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grdqte.Location = New System.Drawing.Point(811, 90)
        Me.Grdqte.Name = "Grdqte"
        Me.Grdqte.Size = New System.Drawing.Size(10, 28)
        Me.Grdqte.TabIndex = 249
        Me.Grdqte.Visible = False
        '
        'dateenregistrement
        '
        Me.dateenregistrement.CustomFormat = "yyyy-MM-dd"
        Me.dateenregistrement.Enabled = False
        Me.dateenregistrement.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateenregistrement.Location = New System.Drawing.Point(592, 19)
        Me.dateenregistrement.Name = "dateenregistrement"
        Me.dateenregistrement.Size = New System.Drawing.Size(176, 22)
        Me.dateenregistrement.TabIndex = 242
        Me.dateenregistrement.Tag = "dateenregistrement"
        Me.dateenregistrement.Value = New Date(2008, 1, 1, 0, 0, 0, 0)
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Location = New System.Drawing.Point(421, 11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 150)
        Me.Panel2.TabIndex = 241
        '
        'Txtqtedispo
        '
        Me.Txtqtedispo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Txtqtedispo.Enabled = False
        Me.Txtqtedispo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtqtedispo.Location = New System.Drawing.Point(592, 55)
        Me.Txtqtedispo.Name = "Txtqtedispo"
        Me.Txtqtedispo.Size = New System.Drawing.Size(177, 21)
        Me.Txtqtedispo.TabIndex = 240
        Me.Txtqtedispo.Tag = "100003"
        Me.Txtqtedispo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txtprixunit
        '
        Me.Txtprixunit.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Txtprixunit.Enabled = False
        Me.Txtprixunit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtprixunit.Location = New System.Drawing.Point(154, 119)
        Me.Txtprixunit.Name = "Txtprixunit"
        Me.Txtprixunit.Size = New System.Drawing.Size(229, 21)
        Me.Txtprixunit.TabIndex = 239
        Me.Txtprixunit.Tag = "prixunit"
        Me.Txtprixunit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 15)
        Me.Label3.TabIndex = 238
        Me.Label3.Text = "Prix article"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(452, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 15)
        Me.Label2.TabIndex = 237
        Me.Label2.Text = "Quantité disponible"
        '
        'idpersonne_FK
        '
        Me.idpersonne_FK.Location = New System.Drawing.Point(843, 21)
        Me.idpersonne_FK.Name = "idpersonne_FK"
        Me.idpersonne_FK.Size = New System.Drawing.Size(44, 22)
        Me.idpersonne_FK.TabIndex = 236
        Me.idpersonne_FK.Tag = ""
        Me.idpersonne_FK.Visible = False
        '
        'BtnRechCam
        '
        Me.BtnRechCam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRechCam.Image = CType(resources.GetObject("BtnRechCam.Image"), System.Drawing.Image)
        Me.BtnRechCam.Location = New System.Drawing.Point(362, 28)
        Me.BtnRechCam.Name = "BtnRechCam"
        Me.BtnRechCam.Size = New System.Drawing.Size(21, 21)
        Me.BtnRechCam.TabIndex = 235
        Me.BtnRechCam.UseVisualStyleBackColor = True
        Me.BtnRechCam.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 234
        Me.Label1.Text = "client"
        '
        'nompersonne
        '
        Me.nompersonne.BackColor = System.Drawing.Color.LightGray
        Me.nompersonne.Location = New System.Drawing.Point(154, 55)
        Me.nompersonne.Name = "nompersonne"
        Me.nompersonne.Size = New System.Drawing.Size(229, 22)
        Me.nompersonne.TabIndex = 233
        Me.nompersonne.Tag = "nompersonne"
        '
        'cmb_libelleart
        '
        Me.cmb_libelleart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_libelleart.FormattingEnabled = True
        Me.cmb_libelleart.Location = New System.Drawing.Point(154, 86)
        Me.cmb_libelleart.Name = "cmb_libelleart"
        Me.cmb_libelleart.Size = New System.Drawing.Size(229, 24)
        Me.cmb_libelleart.TabIndex = 219
        Me.cmb_libelleart.Tag = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 218
        Me.Label4.Text = "Libellé Article"
        '
        'idarticle_FK
        '
        Me.idarticle_FK.Enabled = False
        Me.idarticle_FK.Location = New System.Drawing.Point(843, 90)
        Me.idarticle_FK.Name = "idarticle_FK"
        Me.idarticle_FK.Size = New System.Drawing.Size(44, 22)
        Me.idarticle_FK.TabIndex = 217
        Me.idarticle_FK.Tag = "idarticle_FK"
        Me.idarticle_FK.Visible = False
        '
        'Txtidfacture_PK
        '
        Me.Txtidfacture_PK.Location = New System.Drawing.Point(843, 122)
        Me.Txtidfacture_PK.Name = "Txtidfacture_PK"
        Me.Txtidfacture_PK.Size = New System.Drawing.Size(44, 22)
        Me.Txtidfacture_PK.TabIndex = 214
        Me.Txtidfacture_PK.Tag = "idfacture_FK"
        Me.Txtidfacture_PK.Visible = False
        '
        'Lb_datefacture
        '
        Me.Lb_datefacture.AutoSize = True
        Me.Lb_datefacture.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_datefacture.Location = New System.Drawing.Point(452, 24)
        Me.Lb_datefacture.Name = "Lb_datefacture"
        Me.Lb_datefacture.Size = New System.Drawing.Size(73, 15)
        Me.Lb_datefacture.TabIndex = 209
        Me.Lb_datefacture.Text = "Date facture"
        '
        'Lb_montantfacture
        '
        Me.Lb_montantfacture.AutoSize = True
        Me.Lb_montantfacture.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_montantfacture.Location = New System.Drawing.Point(452, 122)
        Me.Lb_montantfacture.Name = "Lb_montantfacture"
        Me.Lb_montantfacture.Size = New System.Drawing.Size(52, 15)
        Me.Lb_montantfacture.TabIndex = 208
        Me.Lb_montantfacture.Text = "Montant"
        '
        'Txtquantitevendue
        '
        Me.Txtquantitevendue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtquantitevendue.Location = New System.Drawing.Point(592, 88)
        Me.Txtquantitevendue.Name = "Txtquantitevendue"
        Me.Txtquantitevendue.Size = New System.Drawing.Size(176, 20)
        Me.Txtquantitevendue.TabIndex = 205
        Me.Txtquantitevendue.Tag = "100003"
        Me.Txtquantitevendue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lb_quantitevendue
        '
        Me.Lb_quantitevendue.AutoSize = True
        Me.Lb_quantitevendue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_quantitevendue.Location = New System.Drawing.Point(452, 91)
        Me.Lb_quantitevendue.Name = "Lb_quantitevendue"
        Me.Lb_quantitevendue.Size = New System.Drawing.Size(87, 13)
        Me.Lb_quantitevendue.TabIndex = 204
        Me.Lb_quantitevendue.Text = "Quantité Acheter"
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(28, 524)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(106, 13)
        Me.Label24.TabIndex = 245
        Me.Label24.Text = "Taux Réduction"
        Me.Label24.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 544)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(203, 13)
        Me.Label8.TabIndex = 236
        Me.Label8.Text = "Mont Total ------------------------------->"
        Me.Label8.Visible = False
        '
        'TxtTotal
        '
        Me.TxtTotal.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(253, 539)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(170, 21)
        Me.TxtTotal.TabIndex = 237
        Me.TxtTotal.Tag = "Total"
        Me.TxtTotal.Text = "0"
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTotal.Visible = False
        '
        'CmbTauxReduct
        '
        Me.CmbTauxReduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTauxReduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTauxReduct.FormattingEnabled = True
        Me.CmbTauxReduct.Location = New System.Drawing.Point(148, 520)
        Me.CmbTauxReduct.Name = "CmbTauxReduct"
        Me.CmbTauxReduct.Size = New System.Drawing.Size(181, 21)
        Me.CmbTauxReduct.TabIndex = 243
        Me.CmbTauxReduct.Tag = "CmbTauxReduct"
        Me.CmbTauxReduct.Visible = False
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.BackColor = System.Drawing.Color.White
        Me.NewToolStripButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewToolStripButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.Location = New System.Drawing.Point(528, 632)
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(98, 37)
        Me.NewToolStripButton.TabIndex = 253
        Me.NewToolStripButton.Text = "&Nouveau"
        Me.NewToolStripButton.UseVisualStyleBackColor = False
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveToolStripButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.Location = New System.Drawing.Point(637, 632)
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(98, 37)
        Me.SaveToolStripButton.TabIndex = 235
        Me.SaveToolStripButton.Text = "&Enregistrer"
        Me.SaveToolStripButton.UseVisualStyleBackColor = True
        '
        'DelToolStripButton
        '
        Me.DelToolStripButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DelToolStripButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.DelToolStripButton.Image = CType(resources.GetObject("DelToolStripButton.Image"), System.Drawing.Image)
        Me.DelToolStripButton.Location = New System.Drawing.Point(750, 632)
        Me.DelToolStripButton.Name = "DelToolStripButton"
        Me.DelToolStripButton.Size = New System.Drawing.Size(98, 37)
        Me.DelToolStripButton.TabIndex = 236
        Me.DelToolStripButton.Text = "&Supprimer"
        Me.DelToolStripButton.UseVisualStyleBackColor = True
        '
        'CloseStripButton
        '
        Me.CloseStripButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseStripButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.CloseStripButton.Image = CType(resources.GetObject("CloseStripButton.Image"), System.Drawing.Image)
        Me.CloseStripButton.Location = New System.Drawing.Point(865, 632)
        Me.CloseStripButton.Name = "CloseStripButton"
        Me.CloseStripButton.Size = New System.Drawing.Size(98, 37)
        Me.CloseStripButton.TabIndex = 237
        Me.CloseStripButton.Text = "&Fermer"
        Me.CloseStripButton.UseVisualStyleBackColor = True
        '
        'Frmfacture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1000, 677)
        Me.Controls.Add(Me.NewToolStripButton)
        Me.Controls.Add(Me.SaveToolStripButton)
        Me.Controls.Add(Me.DelToolStripButton)
        Me.Controls.Add(Me.CloseStripButton)
        Me.Controls.Add(Me.TabControl1)
        Me.MinimizeBox = False
        Me.Name = "Frmfacture"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "FACTURE"
        Me.Text = "Frmfacture"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Grdfacture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grdvalid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grdqte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Grdfacture As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Txtquantitevendue As System.Windows.Forms.TextBox
    Friend WithEvents Lb_quantitevendue As System.Windows.Forms.Label
    Friend WithEvents CloseStripButton As System.Windows.Forms.Button
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.Button
    Friend WithEvents DelToolStripButton As System.Windows.Forms.Button
    Friend WithEvents Lb_montantfacture As System.Windows.Forms.Label
    Friend WithEvents Lb_datefacture As System.Windows.Forms.Label
    Friend WithEvents Txt_montantfacture As System.Windows.Forms.TextBox
    Friend WithEvents Txtidfacture_PK As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grdvalid As System.Windows.Forms.DataGridView
    Friend WithEvents BtnModifier As System.Windows.Forms.Button
    Friend WithEvents BtnRetirer As System.Windows.Forms.Button
    Friend WithEvents BtnInserer As System.Windows.Forms.Button
    Friend WithEvents cmb_libelleart As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents idarticle_FK As System.Windows.Forms.TextBox
    Friend WithEvents BtnRechCam As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nompersonne As System.Windows.Forms.TextBox
    Friend WithEvents idpersonne_FK As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txtprixunit As System.Windows.Forms.TextBox
    Friend WithEvents Txtqtedispo As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dateenregistrement As System.Windows.Forms.DateTimePicker
    Friend WithEvents Grdqte As System.Windows.Forms.DataGridView
    Friend WithEvents Txtlibarticle As System.Windows.Forms.TextBox
    Friend WithEvents txtnumfact As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txttaux As System.Windows.Forms.TextBox
    Friend WithEvents txtidtaux As System.Windows.Forms.TextBox
    Friend WithEvents Txttotalpayer As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TxtCalculReduct As System.Windows.Forms.TextBox
    Friend WithEvents CmbTauxReduct As System.Windows.Forms.ComboBox
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents NewToolStripButton As System.Windows.Forms.Button
    Friend WithEvents fact As System.Windows.Forms.Label
    Friend WithEvents Datetampon As System.Windows.Forms.DateTimePicker
    Friend WithEvents Txtiduser As System.Windows.Forms.Label
    Friend WithEvents Txtnomprenom As System.Windows.Forms.Label
    Friend WithEvents idprofil As System.Windows.Forms.Label
    Friend WithEvents beneficearticle As System.Windows.Forms.TextBox
    Friend WithEvents idfacture_PK As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents beneficeart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nompersonne_FK As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idpersonne As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idarticle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents article As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quantitevendue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prixunit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents monttotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datefact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qtestock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents beneficearticlevendu As System.Windows.Forms.TextBox
End Class
