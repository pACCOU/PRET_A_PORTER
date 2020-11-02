<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmsociete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmsociete))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.email = New System.Windows.Forms.TextBox
        Me.UndoToolStripButton = New System.Windows.Forms.Button
        Me.CloseStripButton = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.SaveToolStripButton = New System.Windows.Forms.Button
        Me.EditToolStripButton = New System.Windows.Forms.Button
        Me.NewToolStripButton = New System.Windows.Forms.Button
        Me.DelToolStripButton = New System.Windows.Forms.Button
        Me.telephone = New System.Windows.Forms.TextBox
        Me.Lb_telephone = New System.Windows.Forms.Label
        Me.Lb_email = New System.Windows.Forms.Label
        Me.idsociete_PK = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.raisonsociale = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.RCCM = New System.Windows.Forms.TextBox
        Me.nompdg = New System.Windows.Forms.TextBox
        Me.Lb_nompdg = New System.Windows.Forms.Label
        Me.adresse = New System.Windows.Forms.TextBox
        Me.ifu = New System.Windows.Forms.TextBox
        Me.fax = New System.Windows.Forms.TextBox
        Me.Lb_RCCM = New System.Windows.Forms.Label
        Me.Lb_ifu = New System.Windows.Forms.Label
        Me.Lb_fax = New System.Windows.Forms.Label
        Me.Lb_adresse = New System.Windows.Forms.Label
        Me.libellesociete = New System.Windows.Forms.TextBox
        Me.Lb_libellesociete = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Grdsociete = New System.Windows.Forms.DataGridView
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Grdsociete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(626, 106)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(209, 22)
        Me.email.TabIndex = 221
        Me.email.Tag = "email"
        '
        'UndoToolStripButton
        '
        Me.UndoToolStripButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UndoToolStripButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.UndoToolStripButton.Image = CType(resources.GetObject("UndoToolStripButton.Image"), System.Drawing.Image)
        Me.UndoToolStripButton.Location = New System.Drawing.Point(410, 9)
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
        Me.CloseStripButton.Location = New System.Drawing.Point(544, 9)
        Me.CloseStripButton.Name = "CloseStripButton"
        Me.CloseStripButton.Size = New System.Drawing.Size(98, 37)
        Me.CloseStripButton.TabIndex = 237
        Me.CloseStripButton.Text = "&Fermer"
        Me.CloseStripButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.UndoToolStripButton)
        Me.Panel1.Controls.Add(Me.CloseStripButton)
        Me.Panel1.Controls.Add(Me.SaveToolStripButton)
        Me.Panel1.Controls.Add(Me.EditToolStripButton)
        Me.Panel1.Controls.Add(Me.NewToolStripButton)
        Me.Panel1.Location = New System.Drawing.Point(222, 457)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(660, 54)
        Me.Panel1.TabIndex = 9
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveToolStripButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.Location = New System.Drawing.Point(283, 9)
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(98, 37)
        Me.SaveToolStripButton.TabIndex = 235
        Me.SaveToolStripButton.Text = "&Enregistrer"
        Me.SaveToolStripButton.UseVisualStyleBackColor = True
        '
        'EditToolStripButton
        '
        Me.EditToolStripButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditToolStripButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.EditToolStripButton.Image = CType(resources.GetObject("EditToolStripButton.Image"), System.Drawing.Image)
        Me.EditToolStripButton.Location = New System.Drawing.Point(143, 9)
        Me.EditToolStripButton.Name = "EditToolStripButton"
        Me.EditToolStripButton.Size = New System.Drawing.Size(98, 37)
        Me.EditToolStripButton.TabIndex = 233
        Me.EditToolStripButton.Text = "&Modifier"
        Me.EditToolStripButton.UseVisualStyleBackColor = True
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
        'DelToolStripButton
        '
        Me.DelToolStripButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DelToolStripButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.DelToolStripButton.Image = CType(resources.GetObject("DelToolStripButton.Image"), System.Drawing.Image)
        Me.DelToolStripButton.Location = New System.Drawing.Point(876, 457)
        Me.DelToolStripButton.Name = "DelToolStripButton"
        Me.DelToolStripButton.Size = New System.Drawing.Size(98, 37)
        Me.DelToolStripButton.TabIndex = 236
        Me.DelToolStripButton.Text = "&Supprimer"
        Me.DelToolStripButton.UseVisualStyleBackColor = True
        Me.DelToolStripButton.Visible = False
        '
        'telephone
        '
        Me.telephone.Location = New System.Drawing.Point(626, 69)
        Me.telephone.Name = "telephone"
        Me.telephone.Size = New System.Drawing.Size(209, 22)
        Me.telephone.TabIndex = 220
        Me.telephone.Tag = "telephone"
        '
        'Lb_telephone
        '
        Me.Lb_telephone.AutoSize = True
        Me.Lb_telephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_telephone.Location = New System.Drawing.Point(502, 69)
        Me.Lb_telephone.Name = "Lb_telephone"
        Me.Lb_telephone.Size = New System.Drawing.Size(66, 15)
        Me.Lb_telephone.TabIndex = 218
        Me.Lb_telephone.Tag = ""
        Me.Lb_telephone.Text = "Téléphone"
        '
        'Lb_email
        '
        Me.Lb_email.AutoSize = True
        Me.Lb_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_email.Location = New System.Drawing.Point(502, 109)
        Me.Lb_email.Name = "Lb_email"
        Me.Lb_email.Size = New System.Drawing.Size(39, 15)
        Me.Lb_email.TabIndex = 219
        Me.Lb_email.Tag = ""
        Me.Lb_email.Text = "Email"
        '
        'idsociete_PK
        '
        Me.idsociete_PK.Location = New System.Drawing.Point(636, 179)
        Me.idsociete_PK.Name = "idsociete_PK"
        Me.idsociete_PK.Size = New System.Drawing.Size(44, 22)
        Me.idsociete_PK.TabIndex = 217
        Me.idsociete_PK.Tag = ""
        Me.idsociete_PK.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.raisonsociale)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.RCCM)
        Me.GroupBox1.Controls.Add(Me.nompdg)
        Me.GroupBox1.Controls.Add(Me.Lb_nompdg)
        Me.GroupBox1.Controls.Add(Me.email)
        Me.GroupBox1.Controls.Add(Me.telephone)
        Me.GroupBox1.Controls.Add(Me.Lb_email)
        Me.GroupBox1.Controls.Add(Me.Lb_telephone)
        Me.GroupBox1.Controls.Add(Me.idsociete_PK)
        Me.GroupBox1.Controls.Add(Me.adresse)
        Me.GroupBox1.Controls.Add(Me.ifu)
        Me.GroupBox1.Controls.Add(Me.fax)
        Me.GroupBox1.Controls.Add(Me.Lb_RCCM)
        Me.GroupBox1.Controls.Add(Me.Lb_ifu)
        Me.GroupBox1.Controls.Add(Me.Lb_fax)
        Me.GroupBox1.Controls.Add(Me.Lb_adresse)
        Me.GroupBox1.Controls.Add(Me.libellesociete)
        Me.GroupBox1.Controls.Add(Me.Lb_libellesociete)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(919, 246)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = "SOCIETE"
        Me.GroupBox1.Text = "données"
        '
        'raisonsociale
        '
        Me.raisonsociale.Location = New System.Drawing.Point(626, 146)
        Me.raisonsociale.Name = "raisonsociale"
        Me.raisonsociale.Size = New System.Drawing.Size(209, 22)
        Me.raisonsociale.TabIndex = 226
        Me.raisonsociale.Tag = "raisonsociale"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(502, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 15)
        Me.Label1.TabIndex = 225
        Me.Label1.Tag = ""
        Me.Label1.Text = "Raison Sociale"
        '
        'RCCM
        '
        Me.RCCM.Location = New System.Drawing.Point(626, 34)
        Me.RCCM.Name = "RCCM"
        Me.RCCM.Size = New System.Drawing.Size(209, 22)
        Me.RCCM.TabIndex = 224
        Me.RCCM.Tag = "RCCM"
        '
        'nompdg
        '
        Me.nompdg.Location = New System.Drawing.Point(143, 72)
        Me.nompdg.Name = "nompdg"
        Me.nompdg.Size = New System.Drawing.Size(299, 22)
        Me.nompdg.TabIndex = 223
        Me.nompdg.Tag = "nompdg"
        '
        'Lb_nompdg
        '
        Me.Lb_nompdg.AutoSize = True
        Me.Lb_nompdg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_nompdg.Location = New System.Drawing.Point(19, 72)
        Me.Lb_nompdg.Name = "Lb_nompdg"
        Me.Lb_nompdg.Size = New System.Drawing.Size(60, 15)
        Me.Lb_nompdg.TabIndex = 222
        Me.Lb_nompdg.Text = "NomPDG"
        '
        'adresse
        '
        Me.adresse.Location = New System.Drawing.Point(143, 106)
        Me.adresse.Name = "adresse"
        Me.adresse.Size = New System.Drawing.Size(299, 22)
        Me.adresse.TabIndex = 215
        Me.adresse.Tag = "adresse"
        '
        'ifu
        '
        Me.ifu.Location = New System.Drawing.Point(143, 179)
        Me.ifu.Name = "ifu"
        Me.ifu.Size = New System.Drawing.Size(299, 22)
        Me.ifu.TabIndex = 214
        Me.ifu.Tag = "ifu"
        '
        'fax
        '
        Me.fax.Location = New System.Drawing.Point(143, 142)
        Me.fax.Name = "fax"
        Me.fax.Size = New System.Drawing.Size(299, 22)
        Me.fax.TabIndex = 213
        Me.fax.Tag = "fax"
        '
        'Lb_RCCM
        '
        Me.Lb_RCCM.AutoSize = True
        Me.Lb_RCCM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_RCCM.Location = New System.Drawing.Point(502, 34)
        Me.Lb_RCCM.Name = "Lb_RCCM"
        Me.Lb_RCCM.Size = New System.Drawing.Size(43, 15)
        Me.Lb_RCCM.TabIndex = 211
        Me.Lb_RCCM.Text = "RCCM"
        '
        'Lb_ifu
        '
        Me.Lb_ifu.AutoSize = True
        Me.Lb_ifu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_ifu.Location = New System.Drawing.Point(19, 179)
        Me.Lb_ifu.Name = "Lb_ifu"
        Me.Lb_ifu.Size = New System.Drawing.Size(26, 15)
        Me.Lb_ifu.TabIndex = 210
        Me.Lb_ifu.Text = "IFU"
        '
        'Lb_fax
        '
        Me.Lb_fax.AutoSize = True
        Me.Lb_fax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_fax.Location = New System.Drawing.Point(19, 149)
        Me.Lb_fax.Name = "Lb_fax"
        Me.Lb_fax.Size = New System.Drawing.Size(27, 15)
        Me.Lb_fax.TabIndex = 209
        Me.Lb_fax.Text = "Fax"
        '
        'Lb_adresse
        '
        Me.Lb_adresse.AutoSize = True
        Me.Lb_adresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_adresse.Location = New System.Drawing.Point(19, 109)
        Me.Lb_adresse.Name = "Lb_adresse"
        Me.Lb_adresse.Size = New System.Drawing.Size(51, 15)
        Me.Lb_adresse.TabIndex = 208
        Me.Lb_adresse.Text = "Adresse"
        '
        'libellesociete
        '
        Me.libellesociete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.libellesociete.Location = New System.Drawing.Point(143, 34)
        Me.libellesociete.Name = "libellesociete"
        Me.libellesociete.Size = New System.Drawing.Size(299, 20)
        Me.libellesociete.TabIndex = 205
        Me.libellesociete.Tag = "libellesociete"
        '
        'Lb_libellesociete
        '
        Me.Lb_libellesociete.AutoSize = True
        Me.Lb_libellesociete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_libellesociete.Location = New System.Drawing.Point(23, 41)
        Me.Lb_libellesociete.Name = "Lb_libellesociete"
        Me.Lb_libellesociete.Size = New System.Drawing.Size(43, 13)
        Me.Lb_libellesociete.TabIndex = 204
        Me.Lb_libellesociete.Text = "Societé"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(945, 390)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Saisie "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Grdsociete
        '
        Me.Grdsociete.AllowUserToAddRows = False
        Me.Grdsociete.AllowUserToDeleteRows = False
        Me.Grdsociete.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grdsociete.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Grdsociete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Grdsociete.DefaultCellStyle = DataGridViewCellStyle2
        Me.Grdsociete.Location = New System.Drawing.Point(6, 6)
        Me.Grdsociete.Name = "Grdsociete"
        Me.Grdsociete.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grdsociete.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Grdsociete.RowHeadersVisible = False
        Me.Grdsociete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grdsociete.Size = New System.Drawing.Size(933, 376)
        Me.Grdsociete.TabIndex = 0
        Me.Grdsociete.Tag = ""
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Grdsociete)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(945, 390)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Tag = ""
        Me.TabPage1.Text = "Liste "
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(953, 416)
        Me.TabControl1.TabIndex = 8
        '
        'Frmsociete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(977, 529)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.DelToolStripButton)
        Me.MaximizeBox = False
        Me.Name = "Frmsociete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "SOCIETE"
        Me.Text = "Frmsociete"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Grdsociete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents email As System.Windows.Forms.TextBox
    Friend WithEvents UndoToolStripButton As System.Windows.Forms.Button
    Friend WithEvents CloseStripButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.Button
    Friend WithEvents EditToolStripButton As System.Windows.Forms.Button
    Friend WithEvents NewToolStripButton As System.Windows.Forms.Button
    Friend WithEvents DelToolStripButton As System.Windows.Forms.Button
    Friend WithEvents telephone As System.Windows.Forms.TextBox
    Friend WithEvents Lb_telephone As System.Windows.Forms.Label
    Friend WithEvents Lb_email As System.Windows.Forms.Label
    Friend WithEvents idsociete_PK As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents adresse As System.Windows.Forms.TextBox
    Friend WithEvents ifu As System.Windows.Forms.TextBox
    Friend WithEvents fax As System.Windows.Forms.TextBox
    Friend WithEvents Lb_RCCM As System.Windows.Forms.Label
    Friend WithEvents Lb_ifu As System.Windows.Forms.Label
    Friend WithEvents Lb_fax As System.Windows.Forms.Label
    Friend WithEvents Lb_adresse As System.Windows.Forms.Label
    Friend WithEvents libellesociete As System.Windows.Forms.TextBox
    Friend WithEvents Lb_libellesociete As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Grdsociete As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents RCCM As System.Windows.Forms.TextBox
    Friend WithEvents nompdg As System.Windows.Forms.TextBox
    Friend WithEvents Lb_nompdg As System.Windows.Forms.Label
    Friend WithEvents raisonsociale As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
