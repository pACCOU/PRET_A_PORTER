<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmcategorie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmcategorie))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Grdcategorie = New System.Windows.Forms.DataGridView
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.idcategorie_PK = New System.Windows.Forms.TextBox
        Me.libellecategorie = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.UndoToolStripButton = New System.Windows.Forms.Button
        Me.CloseStripButton = New System.Windows.Forms.Button
        Me.SaveToolStripButton = New System.Windows.Forms.Button
        Me.EditToolStripButton = New System.Windows.Forms.Button
        Me.NewToolStripButton = New System.Windows.Forms.Button
        Me.DelToolStripButton = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Grdcategorie, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Size = New System.Drawing.Size(824, 414)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Grdcategorie)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(816, 388)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Liste"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Grdcategorie
        '
        Me.Grdcategorie.AllowUserToAddRows = False
        Me.Grdcategorie.AllowUserToDeleteRows = False
        Me.Grdcategorie.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Grdcategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grdcategorie.Location = New System.Drawing.Point(3, 6)
        Me.Grdcategorie.Name = "Grdcategorie"
        Me.Grdcategorie.ReadOnly = True
        Me.Grdcategorie.RowHeadersVisible = False
        Me.Grdcategorie.Size = New System.Drawing.Size(807, 376)
        Me.Grdcategorie.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(816, 388)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Saisie"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.idcategorie_PK)
        Me.GroupBox1.Controls.Add(Me.libellecategorie)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(769, 153)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = "CATEGORIE"
        Me.GroupBox1.Text = "données"
        '
        'idcategorie_PK
        '
        Me.idcategorie_PK.Enabled = False
        Me.idcategorie_PK.Location = New System.Drawing.Point(693, 109)
        Me.idcategorie_PK.Name = "idcategorie_PK"
        Me.idcategorie_PK.Size = New System.Drawing.Size(44, 22)
        Me.idcategorie_PK.TabIndex = 206
        Me.idcategorie_PK.Tag = ""
        Me.idcategorie_PK.Visible = False
        '
        'libellecategorie
        '
        Me.libellecategorie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.libellecategorie.Location = New System.Drawing.Point(92, 49)
        Me.libellecategorie.Name = "libellecategorie"
        Me.libellecategorie.Size = New System.Drawing.Size(405, 20)
        Me.libellecategorie.TabIndex = 205
        Me.libellecategorie.Tag = "libellecategorie"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 204
        Me.Label1.Text = "Désignation"
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
        Me.Panel1.Location = New System.Drawing.Point(12, 443)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(820, 54)
        Me.Panel1.TabIndex = 1
        '
        'UndoToolStripButton
        '
        Me.UndoToolStripButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UndoToolStripButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.UndoToolStripButton.Image = CType(resources.GetObject("UndoToolStripButton.Image"), System.Drawing.Image)
        Me.UndoToolStripButton.Location = New System.Drawing.Point(543, 9)
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
        Me.SaveToolStripButton.Location = New System.Drawing.Point(273, 9)
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
        Me.EditToolStripButton.Location = New System.Drawing.Point(145, 9)
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
        Me.DelToolStripButton.Location = New System.Drawing.Point(411, 9)
        Me.DelToolStripButton.Name = "DelToolStripButton"
        Me.DelToolStripButton.Size = New System.Drawing.Size(98, 37)
        Me.DelToolStripButton.TabIndex = 236
        Me.DelToolStripButton.Text = "&Supprimer"
        Me.DelToolStripButton.UseVisualStyleBackColor = True
        '
        'Frmcategorie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(879, 516)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.MinimizeBox = False
        Me.Name = "Frmcategorie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "CATEGORIE"
        Me.Text = "CATEGORIE"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Grdcategorie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UndoToolStripButton As System.Windows.Forms.Button
    Friend WithEvents CloseStripButton As System.Windows.Forms.Button
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.Button
    Friend WithEvents EditToolStripButton As System.Windows.Forms.Button
    Friend WithEvents NewToolStripButton As System.Windows.Forms.Button
    Friend WithEvents DelToolStripButton As System.Windows.Forms.Button
    Friend WithEvents Grdcategorie As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents idcategorie_PK As System.Windows.Forms.TextBox
    Friend WithEvents libellecategorie As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
