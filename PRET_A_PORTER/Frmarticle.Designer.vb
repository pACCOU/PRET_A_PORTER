<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmarticle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmarticle))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GrdArticle = New System.Windows.Forms.DataGridView
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.beneficearticle = New System.Windows.Forms.TextBox
        Me.prixvente = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dateenregistrement = New System.Windows.Forms.DateTimePicker
        Me.prixunitarticle = New System.Windows.Forms.TextBox
        Me.txt_taillearticle = New System.Windows.Forms.TextBox
        Me.idcategorie_FK = New System.Windows.Forms.TextBox
        Me.marquearticle = New System.Windows.Forms.TextBox
        Me.lebellearticle = New System.Windows.Forms.TextBox
        Me.cmb_libellearticle = New System.Windows.Forms.ComboBox
        Me.Lb_prixunitarticle = New System.Windows.Forms.Label
        Me.Lb_taillearticle = New System.Windows.Forms.Label
        Me.LB = New System.Windows.Forms.Label
        Me.Lb_libellearticle = New System.Windows.Forms.Label
        Me.Lb_dateenregistr = New System.Windows.Forms.Label
        Me.idarticle_PK = New System.Windows.Forms.TextBox
        Me.Txtnumarticle = New System.Windows.Forms.TextBox
        Me.Lb_numarticle = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.UndoToolStripButton = New System.Windows.Forms.Button
        Me.CloseStripButton = New System.Windows.Forms.Button
        Me.SaveToolStripButton = New System.Windows.Forms.Button
        Me.EditToolStripButton = New System.Windows.Forms.Button
        Me.NewToolStripButton = New System.Windows.Forms.Button
        Me.DelToolStripButton = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.GrdArticle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(853, 444)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GrdArticle)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(845, 418)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Liste"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GrdArticle
        '
        Me.GrdArticle.AllowUserToAddRows = False
        Me.GrdArticle.AllowUserToDeleteRows = False
        Me.GrdArticle.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GrdArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdArticle.Location = New System.Drawing.Point(3, 6)
        Me.GrdArticle.Name = "GrdArticle"
        Me.GrdArticle.ReadOnly = True
        Me.GrdArticle.RowHeadersVisible = False
        Me.GrdArticle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrdArticle.Size = New System.Drawing.Size(839, 406)
        Me.GrdArticle.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(845, 418)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Saisie "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.beneficearticle)
        Me.GroupBox1.Controls.Add(Me.prixvente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dateenregistrement)
        Me.GroupBox1.Controls.Add(Me.prixunitarticle)
        Me.GroupBox1.Controls.Add(Me.txt_taillearticle)
        Me.GroupBox1.Controls.Add(Me.idcategorie_FK)
        Me.GroupBox1.Controls.Add(Me.marquearticle)
        Me.GroupBox1.Controls.Add(Me.lebellearticle)
        Me.GroupBox1.Controls.Add(Me.cmb_libellearticle)
        Me.GroupBox1.Controls.Add(Me.Lb_prixunitarticle)
        Me.GroupBox1.Controls.Add(Me.Lb_taillearticle)
        Me.GroupBox1.Controls.Add(Me.LB)
        Me.GroupBox1.Controls.Add(Me.Lb_libellearticle)
        Me.GroupBox1.Controls.Add(Me.Lb_dateenregistr)
        Me.GroupBox1.Controls.Add(Me.idarticle_PK)
        Me.GroupBox1.Controls.Add(Me.Txtnumarticle)
        Me.GroupBox1.Controls.Add(Me.Lb_numarticle)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(828, 297)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = "ARTICLE"
        Me.GroupBox1.Text = "données"
        '
        'beneficearticle
        '
        Me.beneficearticle.BackColor = System.Drawing.Color.Red
        Me.beneficearticle.Location = New System.Drawing.Point(459, 195)
        Me.beneficearticle.Name = "beneficearticle"
        Me.beneficearticle.Size = New System.Drawing.Size(73, 22)
        Me.beneficearticle.TabIndex = 230
        Me.beneficearticle.Tag = "beneficearticle"
        Me.beneficearticle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.beneficearticle.Visible = False
        '
        'prixvente
        '
        Me.prixvente.BackColor = System.Drawing.Color.Red
        Me.prixvente.Location = New System.Drawing.Point(104, 156)
        Me.prixvente.Name = "prixvente"
        Me.prixvente.Size = New System.Drawing.Size(131, 22)
        Me.prixvente.TabIndex = 229
        Me.prixvente.Tag = "prixvente"
        Me.prixvente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 228
        Me.Label2.Text = "Prix de vente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(456, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 227
        Me.Label1.Text = "Catégorie"
        Me.Label1.Visible = False
        '
        'dateenregistrement
        '
        Me.dateenregistrement.CustomFormat = "yyyy-MM-dd"
        Me.dateenregistrement.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateenregistrement.Location = New System.Drawing.Point(578, 163)
        Me.dateenregistrement.Name = "dateenregistrement"
        Me.dateenregistrement.Size = New System.Drawing.Size(131, 22)
        Me.dateenregistrement.TabIndex = 226
        Me.dateenregistrement.Tag = "dateenregistrement"
        Me.dateenregistrement.Value = New Date(2014, 10, 13, 0, 0, 0, 0)
        '
        'prixunitarticle
        '
        Me.prixunitarticle.BackColor = System.Drawing.Color.Red
        Me.prixunitarticle.Location = New System.Drawing.Point(104, 116)
        Me.prixunitarticle.Name = "prixunitarticle"
        Me.prixunitarticle.Size = New System.Drawing.Size(131, 22)
        Me.prixunitarticle.TabIndex = 225
        Me.prixunitarticle.Tag = "prixunitarticle"
        Me.prixunitarticle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_taillearticle
        '
        Me.txt_taillearticle.Location = New System.Drawing.Point(579, 76)
        Me.txt_taillearticle.Name = "txt_taillearticle"
        Me.txt_taillearticle.Size = New System.Drawing.Size(131, 22)
        Me.txt_taillearticle.TabIndex = 224
        Me.txt_taillearticle.Tag = "taillearticle"
        '
        'idcategorie_FK
        '
        Me.idcategorie_FK.Location = New System.Drawing.Point(98, 212)
        Me.idcategorie_FK.Name = "idcategorie_FK"
        Me.idcategorie_FK.Size = New System.Drawing.Size(44, 22)
        Me.idcategorie_FK.TabIndex = 217
        Me.idcategorie_FK.Tag = ""
        Me.idcategorie_FK.Visible = False
        '
        'marquearticle
        '
        Me.marquearticle.Location = New System.Drawing.Point(579, 119)
        Me.marquearticle.Name = "marquearticle"
        Me.marquearticle.Size = New System.Drawing.Size(131, 22)
        Me.marquearticle.TabIndex = 215
        Me.marquearticle.Tag = "marquearticle"
        '
        'lebellearticle
        '
        Me.lebellearticle.Location = New System.Drawing.Point(104, 73)
        Me.lebellearticle.Name = "lebellearticle"
        Me.lebellearticle.Size = New System.Drawing.Size(287, 22)
        Me.lebellearticle.TabIndex = 213
        Me.lebellearticle.Tag = "lebellearticle"
        '
        'cmb_libellearticle
        '
        Me.cmb_libellearticle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_libellearticle.FormattingEnabled = True
        Me.cmb_libellearticle.Location = New System.Drawing.Point(523, 33)
        Me.cmb_libellearticle.Name = "cmb_libellearticle"
        Me.cmb_libellearticle.Size = New System.Drawing.Size(186, 24)
        Me.cmb_libellearticle.TabIndex = 212
        Me.cmb_libellearticle.Visible = False
        '
        'Lb_prixunitarticle
        '
        Me.Lb_prixunitarticle.AutoSize = True
        Me.Lb_prixunitarticle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_prixunitarticle.Location = New System.Drawing.Point(20, 119)
        Me.Lb_prixunitarticle.Name = "Lb_prixunitarticle"
        Me.Lb_prixunitarticle.Size = New System.Drawing.Size(71, 15)
        Me.Lb_prixunitarticle.TabIndex = 211
        Me.Lb_prixunitarticle.Text = "Prix d'achat"
        '
        'Lb_taillearticle
        '
        Me.Lb_taillearticle.AutoSize = True
        Me.Lb_taillearticle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_taillearticle.Location = New System.Drawing.Point(453, 81)
        Me.Lb_taillearticle.Name = "Lb_taillearticle"
        Me.Lb_taillearticle.Size = New System.Drawing.Size(37, 15)
        Me.Lb_taillearticle.TabIndex = 210
        Me.Lb_taillearticle.Text = "Taille"
        '
        'LB
        '
        Me.LB.AutoSize = True
        Me.LB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB.Location = New System.Drawing.Point(453, 119)
        Me.LB.Name = "LB"
        Me.LB.Size = New System.Drawing.Size(50, 15)
        Me.LB.TabIndex = 209
        Me.LB.Text = "Marque"
        '
        'Lb_libellearticle
        '
        Me.Lb_libellearticle.AutoSize = True
        Me.Lb_libellearticle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_libellearticle.Location = New System.Drawing.Point(20, 75)
        Me.Lb_libellearticle.Name = "Lb_libellearticle"
        Me.Lb_libellearticle.Size = New System.Drawing.Size(44, 15)
        Me.Lb_libellearticle.TabIndex = 208
        Me.Lb_libellearticle.Text = "Libellé"
        '
        'Lb_dateenregistr
        '
        Me.Lb_dateenregistr.AutoSize = True
        Me.Lb_dateenregistr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_dateenregistr.Location = New System.Drawing.Point(453, 163)
        Me.Lb_dateenregistr.Name = "Lb_dateenregistr"
        Me.Lb_dateenregistr.Size = New System.Drawing.Size(119, 15)
        Me.Lb_dateenregistr.TabIndex = 207
        Me.Lb_dateenregistr.Text = "Date enregistrement"
        '
        'idarticle_PK
        '
        Me.idarticle_PK.Enabled = False
        Me.idarticle_PK.Location = New System.Drawing.Point(23, 212)
        Me.idarticle_PK.Name = "idarticle_PK"
        Me.idarticle_PK.Size = New System.Drawing.Size(44, 22)
        Me.idarticle_PK.TabIndex = 206
        Me.idarticle_PK.Tag = ""
        Me.idarticle_PK.Visible = False
        '
        'Txtnumarticle
        '
        Me.Txtnumarticle.Enabled = False
        Me.Txtnumarticle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnumarticle.Location = New System.Drawing.Point(104, 35)
        Me.Txtnumarticle.Name = "Txtnumarticle"
        Me.Txtnumarticle.Size = New System.Drawing.Size(178, 20)
        Me.Txtnumarticle.TabIndex = 205
        Me.Txtnumarticle.Tag = "numarticle"
        '
        'Lb_numarticle
        '
        Me.Lb_numarticle.AutoSize = True
        Me.Lb_numarticle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_numarticle.Location = New System.Drawing.Point(21, 38)
        Me.Lb_numarticle.Name = "Lb_numarticle"
        Me.Lb_numarticle.Size = New System.Drawing.Size(44, 13)
        Me.Lb_numarticle.TabIndex = 204
        Me.Lb_numarticle.Text = "Numéro"
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
        Me.Panel1.Location = New System.Drawing.Point(19, 473)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(842, 54)
        Me.Panel1.TabIndex = 3
        '
        'UndoToolStripButton
        '
        Me.UndoToolStripButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UndoToolStripButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.UndoToolStripButton.Image = CType(resources.GetObject("UndoToolStripButton.Image"), System.Drawing.Image)
        Me.UndoToolStripButton.Location = New System.Drawing.Point(545, 9)
        Me.UndoToolStripButton.Name = "UndoToolStripButton"
        Me.UndoToolStripButton.Size = New System.Drawing.Size(98, 37)
        Me.UndoToolStripButton.TabIndex = 234
        Me.UndoToolStripButton.Text = "&Annuler"
        Me.UndoToolStripButton.UseVisualStyleBackColor = True
        '
        'CloseStripButton
        '
        Me.CloseStripButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseStripButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.CloseStripButton.Image = CType(resources.GetObject("CloseStripButton.Image"), System.Drawing.Image)
        Me.CloseStripButton.Location = New System.Drawing.Point(684, 9)
        Me.CloseStripButton.Name = "CloseStripButton"
        Me.CloseStripButton.Size = New System.Drawing.Size(98, 37)
        Me.CloseStripButton.TabIndex = 237
        Me.CloseStripButton.Text = "&Fermer"
        Me.CloseStripButton.UseVisualStyleBackColor = True
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveToolStripButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.Location = New System.Drawing.Point(268, 9)
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
        Me.DelToolStripButton.Location = New System.Drawing.Point(417, 9)
        Me.DelToolStripButton.Name = "DelToolStripButton"
        Me.DelToolStripButton.Size = New System.Drawing.Size(98, 37)
        Me.DelToolStripButton.TabIndex = 236
        Me.DelToolStripButton.Text = "&Supprimer"
        Me.DelToolStripButton.UseVisualStyleBackColor = True
        '
        'Frmarticle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(907, 568)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "Frmarticle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "ARTICLE"
        Me.Text = "Frmarticle"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.GrdArticle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UndoToolStripButton As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GrdArticle As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents idarticle_PK As System.Windows.Forms.TextBox
    Friend WithEvents Txtnumarticle As System.Windows.Forms.TextBox
    Friend WithEvents Lb_numarticle As System.Windows.Forms.Label
    Friend WithEvents CloseStripButton As System.Windows.Forms.Button
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.Button
    Friend WithEvents NewToolStripButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents EditToolStripButton As System.Windows.Forms.Button
    Friend WithEvents DelToolStripButton As System.Windows.Forms.Button
    Friend WithEvents Lb_prixunitarticle As System.Windows.Forms.Label
    Friend WithEvents Lb_taillearticle As System.Windows.Forms.Label
    Friend WithEvents LB As System.Windows.Forms.Label
    Friend WithEvents Lb_libellearticle As System.Windows.Forms.Label
    Friend WithEvents Lb_dateenregistr As System.Windows.Forms.Label
    Friend WithEvents lebellearticle As System.Windows.Forms.TextBox
    Friend WithEvents marquearticle As System.Windows.Forms.TextBox
    Friend WithEvents idcategorie_FK As System.Windows.Forms.TextBox
    Friend WithEvents prixunitarticle As System.Windows.Forms.TextBox
    Friend WithEvents txt_taillearticle As System.Windows.Forms.TextBox
    Friend WithEvents cmb_libellearticle As System.Windows.Forms.ComboBox
    Friend WithEvents dateenregistrement As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents prixvente As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents beneficearticle As System.Windows.Forms.TextBox
End Class
