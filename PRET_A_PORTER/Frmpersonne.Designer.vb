<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmpersonne
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmpersonne))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.SaveToolStripButton = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txt_val_load = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Grdpersonne = New System.Windows.Forms.DataGridView
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.idtypepersonnel_FK = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_idtypepersonnel = New System.Windows.Forms.ComboBox
        Me.idsexe_FK = New System.Windows.Forms.TextBox
        Me.dateembauche = New System.Windows.Forms.DateTimePicker
        Me.idtypepersonne_FK = New System.Windows.Forms.TextBox
        Me.idpersonne_PK = New System.Windows.Forms.TextBox
        Me.Cmb_libelletypepersonne = New System.Windows.Forms.ComboBox
        Me.Lb_idtypepersonne = New System.Windows.Forms.Label
        Me.email = New System.Windows.Forms.TextBox
        Me.tel = New System.Windows.Forms.TextBox
        Me.Lb_email = New System.Windows.Forms.Label
        Me.Lb_tel = New System.Windows.Forms.Label
        Me.prenompersonne = New System.Windows.Forms.TextBox
        Me.cmb_sexe = New System.Windows.Forms.ComboBox
        Me.Lb_sexe = New System.Windows.Forms.Label
        Me.Lb_prenompersonne = New System.Windows.Forms.Label
        Me.Lb_dateenregistr = New System.Windows.Forms.Label
        Me.nompersonne = New System.Windows.Forms.TextBox
        Me.Lb_nompersonne = New System.Windows.Forms.Label
        Me.NewToolStripButton = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.UndoToolStripButton = New System.Windows.Forms.Button
        Me.CloseStripButton = New System.Windows.Forms.Button
        Me.EditToolStripButton = New System.Windows.Forms.Button
        Me.DelToolStripButton = New System.Windows.Forms.Button
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Grdpersonne, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveToolStripButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.Location = New System.Drawing.Point(344, 9)
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(98, 37)
        Me.SaveToolStripButton.TabIndex = 235
        Me.SaveToolStripButton.Text = "&Enregistrer"
        Me.SaveToolStripButton.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(19, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(961, 477)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.Grdpersonne)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(953, 451)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Liste"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_val_load)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(717, 58)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rechercher"
        '
        'txt_val_load
        '
        Me.txt_val_load.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_val_load.Location = New System.Drawing.Point(191, 23)
        Me.txt_val_load.Name = "txt_val_load"
        Me.txt_val_load.Size = New System.Drawing.Size(501, 20)
        Me.txt_val_load.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Entrer les initiales du nom ou prénom"
        '
        'Grdpersonne
        '
        Me.Grdpersonne.AllowUserToAddRows = False
        Me.Grdpersonne.AllowUserToDeleteRows = False
        Me.Grdpersonne.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grdpersonne.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Grdpersonne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Grdpersonne.DefaultCellStyle = DataGridViewCellStyle4
        Me.Grdpersonne.Location = New System.Drawing.Point(6, 71)
        Me.Grdpersonne.Name = "Grdpersonne"
        Me.Grdpersonne.ReadOnly = True
        Me.Grdpersonne.RowHeadersVisible = False
        Me.Grdpersonne.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grdpersonne.Size = New System.Drawing.Size(941, 374)
        Me.Grdpersonne.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(953, 451)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Saisie "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.idtypepersonnel_FK)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmb_idtypepersonnel)
        Me.GroupBox1.Controls.Add(Me.idsexe_FK)
        Me.GroupBox1.Controls.Add(Me.dateembauche)
        Me.GroupBox1.Controls.Add(Me.idtypepersonne_FK)
        Me.GroupBox1.Controls.Add(Me.idpersonne_PK)
        Me.GroupBox1.Controls.Add(Me.Cmb_libelletypepersonne)
        Me.GroupBox1.Controls.Add(Me.Lb_idtypepersonne)
        Me.GroupBox1.Controls.Add(Me.email)
        Me.GroupBox1.Controls.Add(Me.tel)
        Me.GroupBox1.Controls.Add(Me.Lb_email)
        Me.GroupBox1.Controls.Add(Me.Lb_tel)
        Me.GroupBox1.Controls.Add(Me.prenompersonne)
        Me.GroupBox1.Controls.Add(Me.cmb_sexe)
        Me.GroupBox1.Controls.Add(Me.Lb_sexe)
        Me.GroupBox1.Controls.Add(Me.Lb_prenompersonne)
        Me.GroupBox1.Controls.Add(Me.Lb_dateenregistr)
        Me.GroupBox1.Controls.Add(Me.nompersonne)
        Me.GroupBox1.Controls.Add(Me.Lb_nompersonne)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(925, 290)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = "PERSONNE"
        Me.GroupBox1.Text = "données"
        '
        'idtypepersonnel_FK
        '
        Me.idtypepersonnel_FK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idtypepersonnel_FK.Location = New System.Drawing.Point(745, 239)
        Me.idtypepersonnel_FK.Name = "idtypepersonnel_FK"
        Me.idtypepersonnel_FK.Size = New System.Drawing.Size(50, 22)
        Me.idtypepersonnel_FK.TabIndex = 242
        Me.idtypepersonnel_FK.Tag = "idtypepersonnel_FK"
        Me.idtypepersonnel_FK.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(462, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 15)
        Me.Label1.TabIndex = 241
        Me.Label1.Text = "Type personnel"
        Me.Label1.Visible = False
        '
        'cmb_idtypepersonnel
        '
        Me.cmb_idtypepersonnel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_idtypepersonnel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_idtypepersonnel.FormattingEnabled = True
        Me.cmb_idtypepersonnel.Location = New System.Drawing.Point(554, 155)
        Me.cmb_idtypepersonnel.Name = "cmb_idtypepersonnel"
        Me.cmb_idtypepersonnel.Size = New System.Drawing.Size(188, 24)
        Me.cmb_idtypepersonnel.TabIndex = 240
        Me.cmb_idtypepersonnel.Tag = ""
        Me.cmb_idtypepersonnel.Visible = False
        '
        'idsexe_FK
        '
        Me.idsexe_FK.Location = New System.Drawing.Point(870, 197)
        Me.idsexe_FK.Name = "idsexe_FK"
        Me.idsexe_FK.Size = New System.Drawing.Size(13, 22)
        Me.idsexe_FK.TabIndex = 239
        Me.idsexe_FK.Tag = "idsexe_FK"
        Me.idsexe_FK.Visible = False
        '
        'dateembauche
        '
        Me.dateembauche.CustomFormat = "yyyy-MM-dd"
        Me.dateembauche.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateembauche.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateembauche.Location = New System.Drawing.Point(147, 188)
        Me.dateembauche.Name = "dateembauche"
        Me.dateembauche.Size = New System.Drawing.Size(120, 22)
        Me.dateembauche.TabIndex = 238
        Me.dateembauche.Tag = "dateembauche"
        Me.dateembauche.Value = New Date(2008, 1, 1, 0, 0, 0, 0)
        '
        'idtypepersonne_FK
        '
        Me.idtypepersonne_FK.Location = New System.Drawing.Point(859, 225)
        Me.idtypepersonne_FK.Name = "idtypepersonne_FK"
        Me.idtypepersonne_FK.Size = New System.Drawing.Size(36, 22)
        Me.idtypepersonne_FK.TabIndex = 229
        Me.idtypepersonne_FK.Tag = "idtypepersonne_FK"
        Me.idtypepersonne_FK.Visible = False
        '
        'idpersonne_PK
        '
        Me.idpersonne_PK.Location = New System.Drawing.Point(820, 197)
        Me.idpersonne_PK.Name = "idpersonne_PK"
        Me.idpersonne_PK.Size = New System.Drawing.Size(35, 22)
        Me.idpersonne_PK.TabIndex = 228
        Me.idpersonne_PK.Tag = ""
        Me.idpersonne_PK.Visible = False
        '
        'Cmb_libelletypepersonne
        '
        Me.Cmb_libelletypepersonne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_libelletypepersonne.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_libelletypepersonne.FormattingEnabled = True
        Me.Cmb_libelletypepersonne.Location = New System.Drawing.Point(145, 29)
        Me.Cmb_libelletypepersonne.Name = "Cmb_libelletypepersonne"
        Me.Cmb_libelletypepersonne.Size = New System.Drawing.Size(275, 24)
        Me.Cmb_libelletypepersonne.TabIndex = 223
        Me.Cmb_libelletypepersonne.Tag = ""
        '
        'Lb_idtypepersonne
        '
        Me.Lb_idtypepersonne.AutoSize = True
        Me.Lb_idtypepersonne.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_idtypepersonne.Location = New System.Drawing.Point(27, 32)
        Me.Lb_idtypepersonne.Name = "Lb_idtypepersonne"
        Me.Lb_idtypepersonne.Size = New System.Drawing.Size(89, 15)
        Me.Lb_idtypepersonne.TabIndex = 222
        Me.Lb_idtypepersonne.Text = "Type Personne"
        '
        'email
        '
        Me.email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.Location = New System.Drawing.Point(554, 112)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(275, 22)
        Me.email.TabIndex = 221
        Me.email.Tag = "email"
        '
        'tel
        '
        Me.tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tel.Location = New System.Drawing.Point(554, 78)
        Me.tel.Name = "tel"
        Me.tel.Size = New System.Drawing.Size(273, 22)
        Me.tel.TabIndex = 220
        Me.tel.Tag = "tel"
        Me.tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lb_email
        '
        Me.Lb_email.AutoSize = True
        Me.Lb_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_email.Location = New System.Drawing.Point(462, 115)
        Me.Lb_email.Name = "Lb_email"
        Me.Lb_email.Size = New System.Drawing.Size(39, 15)
        Me.Lb_email.TabIndex = 219
        Me.Lb_email.Text = "Email"
        '
        'Lb_tel
        '
        Me.Lb_tel.AutoSize = True
        Me.Lb_tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_tel.Location = New System.Drawing.Point(462, 81)
        Me.Lb_tel.Name = "Lb_tel"
        Me.Lb_tel.Size = New System.Drawing.Size(66, 15)
        Me.Lb_tel.TabIndex = 218
        Me.Lb_tel.Text = "Téléphone"
        '
        'prenompersonne
        '
        Me.prenompersonne.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prenompersonne.Location = New System.Drawing.Point(145, 111)
        Me.prenompersonne.Name = "prenompersonne"
        Me.prenompersonne.Size = New System.Drawing.Size(275, 22)
        Me.prenompersonne.TabIndex = 215
        Me.prenompersonne.Tag = "prenompersonne"
        '
        'cmb_sexe
        '
        Me.cmb_sexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_sexe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_sexe.FormattingEnabled = True
        Me.cmb_sexe.Location = New System.Drawing.Point(147, 152)
        Me.cmb_sexe.Name = "cmb_sexe"
        Me.cmb_sexe.Size = New System.Drawing.Size(120, 24)
        Me.cmb_sexe.TabIndex = 212
        Me.cmb_sexe.Tag = ""
        '
        'Lb_sexe
        '
        Me.Lb_sexe.AutoSize = True
        Me.Lb_sexe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_sexe.Location = New System.Drawing.Point(27, 155)
        Me.Lb_sexe.Name = "Lb_sexe"
        Me.Lb_sexe.Size = New System.Drawing.Size(35, 15)
        Me.Lb_sexe.TabIndex = 211
        Me.Lb_sexe.Text = "Sexe"
        '
        'Lb_prenompersonne
        '
        Me.Lb_prenompersonne.AutoSize = True
        Me.Lb_prenompersonne.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_prenompersonne.Location = New System.Drawing.Point(27, 114)
        Me.Lb_prenompersonne.Name = "Lb_prenompersonne"
        Me.Lb_prenompersonne.Size = New System.Drawing.Size(50, 15)
        Me.Lb_prenompersonne.TabIndex = 208
        Me.Lb_prenompersonne.Text = "prénom"
        '
        'Lb_dateenregistr
        '
        Me.Lb_dateenregistr.AutoSize = True
        Me.Lb_dateenregistr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_dateenregistr.Location = New System.Drawing.Point(25, 193)
        Me.Lb_dateenregistr.Name = "Lb_dateenregistr"
        Me.Lb_dateenregistr.Size = New System.Drawing.Size(119, 15)
        Me.Lb_dateenregistr.TabIndex = 207
        Me.Lb_dateenregistr.Text = "Date enregistrement"
        '
        'nompersonne
        '
        Me.nompersonne.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nompersonne.Location = New System.Drawing.Point(145, 80)
        Me.nompersonne.Name = "nompersonne"
        Me.nompersonne.Size = New System.Drawing.Size(275, 20)
        Me.nompersonne.TabIndex = 205
        Me.nompersonne.Tag = "nompersonne"
        '
        'Lb_nompersonne
        '
        Me.Lb_nompersonne.AutoSize = True
        Me.Lb_nompersonne.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_nompersonne.Location = New System.Drawing.Point(27, 83)
        Me.Lb_nompersonne.Name = "Lb_nompersonne"
        Me.Lb_nompersonne.Size = New System.Drawing.Size(29, 13)
        Me.Lb_nompersonne.TabIndex = 204
        Me.Lb_nompersonne.Text = "Nom"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.BackColor = System.Drawing.Color.White
        Me.NewToolStripButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewToolStripButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.Location = New System.Drawing.Point(18, 9)
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(98, 37)
        Me.NewToolStripButton.TabIndex = 232
        Me.NewToolStripButton.Text = "&Ajouter"
        Me.NewToolStripButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.UndoToolStripButton)
        Me.Panel1.Controls.Add(Me.CloseStripButton)
        Me.Panel1.Controls.Add(Me.SaveToolStripButton)
        Me.Panel1.Controls.Add(Me.EditToolStripButton)
        Me.Panel1.Controls.Add(Me.NewToolStripButton)
        Me.Panel1.Controls.Add(Me.DelToolStripButton)
        Me.Panel1.Location = New System.Drawing.Point(24, 482)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(953, 54)
        Me.Panel1.TabIndex = 6
        '
        'UndoToolStripButton
        '
        Me.UndoToolStripButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UndoToolStripButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.UndoToolStripButton.Image = CType(resources.GetObject("UndoToolStripButton.Image"), System.Drawing.Image)
        Me.UndoToolStripButton.Location = New System.Drawing.Point(653, 9)
        Me.UndoToolStripButton.Name = "UndoToolStripButton"
        Me.UndoToolStripButton.Size = New System.Drawing.Size(98, 37)
        Me.UndoToolStripButton.TabIndex = 234
        Me.UndoToolStripButton.Text = "A&nnuler"
        Me.UndoToolStripButton.UseVisualStyleBackColor = True
        '
        'CloseStripButton
        '
        Me.CloseStripButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseStripButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.CloseStripButton.Image = CType(resources.GetObject("CloseStripButton.Image"), System.Drawing.Image)
        Me.CloseStripButton.Location = New System.Drawing.Point(806, 9)
        Me.CloseStripButton.Name = "CloseStripButton"
        Me.CloseStripButton.Size = New System.Drawing.Size(98, 37)
        Me.CloseStripButton.TabIndex = 237
        Me.CloseStripButton.Text = "&Fermer"
        Me.CloseStripButton.UseVisualStyleBackColor = True
        '
        'EditToolStripButton
        '
        Me.EditToolStripButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditToolStripButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.EditToolStripButton.Image = CType(resources.GetObject("EditToolStripButton.Image"), System.Drawing.Image)
        Me.EditToolStripButton.Location = New System.Drawing.Point(178, 9)
        Me.EditToolStripButton.Name = "EditToolStripButton"
        Me.EditToolStripButton.Size = New System.Drawing.Size(98, 37)
        Me.EditToolStripButton.TabIndex = 233
        Me.EditToolStripButton.Text = "&Modifier"
        Me.EditToolStripButton.UseVisualStyleBackColor = True
        '
        'DelToolStripButton
        '
        Me.DelToolStripButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DelToolStripButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.DelToolStripButton.Image = CType(resources.GetObject("DelToolStripButton.Image"), System.Drawing.Image)
        Me.DelToolStripButton.Location = New System.Drawing.Point(500, 9)
        Me.DelToolStripButton.Name = "DelToolStripButton"
        Me.DelToolStripButton.Size = New System.Drawing.Size(98, 37)
        Me.DelToolStripButton.TabIndex = 236
        Me.DelToolStripButton.Text = "&Supprimer"
        Me.DelToolStripButton.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(64, -43)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 7
        '
        'Frmpersonne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(992, 551)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox3)
        Me.MaximizeBox = False
        Me.Name = "Frmpersonne"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "PERSONNE"
        Me.Text = "Frmpersonne"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Grdpersonne, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Grdpersonne As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents prenompersonne As System.Windows.Forms.TextBox
    Friend WithEvents cmb_sexe As System.Windows.Forms.ComboBox
    Friend WithEvents Lb_sexe As System.Windows.Forms.Label
    Friend WithEvents Lb_prenompersonne As System.Windows.Forms.Label
    Friend WithEvents Lb_dateenregistr As System.Windows.Forms.Label
    Friend WithEvents nompersonne As System.Windows.Forms.TextBox
    Friend WithEvents Lb_nompersonne As System.Windows.Forms.Label
    Friend WithEvents NewToolStripButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UndoToolStripButton As System.Windows.Forms.Button
    Friend WithEvents CloseStripButton As System.Windows.Forms.Button
    Friend WithEvents EditToolStripButton As System.Windows.Forms.Button
    Friend WithEvents DelToolStripButton As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents email As System.Windows.Forms.TextBox
    Friend WithEvents tel As System.Windows.Forms.TextBox
    Friend WithEvents Lb_email As System.Windows.Forms.Label
    Friend WithEvents Lb_tel As System.Windows.Forms.Label
    Friend WithEvents Cmb_libelletypepersonne As System.Windows.Forms.ComboBox
    Friend WithEvents Lb_idtypepersonne As System.Windows.Forms.Label
    Friend WithEvents idtypepersonne_FK As System.Windows.Forms.TextBox
    Friend WithEvents idpersonne_PK As System.Windows.Forms.TextBox
    Friend WithEvents dateembauche As System.Windows.Forms.DateTimePicker
    Friend WithEvents idsexe_FK As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_idtypepersonnel As System.Windows.Forms.ComboBox
    Friend WithEvents idtypepersonnel_FK As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_val_load As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
