<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmtypepersonne
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmtypepersonne))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.CloseStripButton = New System.Windows.Forms.Button
        Me.SaveToolStripButton = New System.Windows.Forms.Button
        Me.EditToolStripButton = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.UndoToolStripButton = New System.Windows.Forms.Button
        Me.NewToolStripButton = New System.Windows.Forms.Button
        Me.DelToolStripButton = New System.Windows.Forms.Button
        Me.idtypepersonne_PK = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.libelletypepersonne = New System.Windows.Forms.TextBox
        Me.Lblibelletypepersonne = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Grdtypepersonne = New System.Windows.Forms.DataGridView
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Grdtypepersonne, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.SaveToolStripButton.Location = New System.Drawing.Point(262, 9)
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
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.UndoToolStripButton)
        Me.Panel1.Controls.Add(Me.CloseStripButton)
        Me.Panel1.Controls.Add(Me.SaveToolStripButton)
        Me.Panel1.Controls.Add(Me.EditToolStripButton)
        Me.Panel1.Controls.Add(Me.NewToolStripButton)
        Me.Panel1.Controls.Add(Me.DelToolStripButton)
        Me.Panel1.Location = New System.Drawing.Point(48, 433)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(820, 54)
        Me.Panel1.TabIndex = 5
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
        Me.UndoToolStripButton.Text = "A&nnuler"
        Me.UndoToolStripButton.UseVisualStyleBackColor = True
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
        'idtypepersonne_PK
        '
        Me.idtypepersonne_PK.Enabled = False
        Me.idtypepersonne_PK.Location = New System.Drawing.Point(686, 118)
        Me.idtypepersonne_PK.Name = "idtypepersonne_PK"
        Me.idtypepersonne_PK.Size = New System.Drawing.Size(44, 22)
        Me.idtypepersonne_PK.TabIndex = 206
        Me.idtypepersonne_PK.Tag = ""
        Me.idtypepersonne_PK.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.idtypepersonne_PK)
        Me.GroupBox1.Controls.Add(Me.libelletypepersonne)
        Me.GroupBox1.Controls.Add(Me.Lblibelletypepersonne)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(769, 153)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = "TYPEPERSONNE"
        Me.GroupBox1.Text = "données"
        '
        'libelletypepersonne
        '
        Me.libelletypepersonne.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.libelletypepersonne.Location = New System.Drawing.Point(130, 49)
        Me.libelletypepersonne.Name = "libelletypepersonne"
        Me.libelletypepersonne.Size = New System.Drawing.Size(405, 20)
        Me.libelletypepersonne.TabIndex = 205
        Me.libelletypepersonne.Tag = "libelletypepersonne"
        '
        'Lblibelletypepersonne
        '
        Me.Lblibelletypepersonne.AutoSize = True
        Me.Lblibelletypepersonne.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblibelletypepersonne.Location = New System.Drawing.Point(6, 52)
        Me.Lblibelletypepersonne.Name = "Lblibelletypepersonne"
        Me.Lblibelletypepersonne.Size = New System.Drawing.Size(79, 13)
        Me.Lblibelletypepersonne.TabIndex = 204
        Me.Lblibelletypepersonne.Text = "Type Personne"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(907, 413)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Grdtypepersonne)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(899, 387)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Liste"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Grdtypepersonne
        '
        Me.Grdtypepersonne.AllowUserToAddRows = False
        Me.Grdtypepersonne.AllowUserToDeleteRows = False
        Me.Grdtypepersonne.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grdtypepersonne.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Grdtypepersonne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Grdtypepersonne.DefaultCellStyle = DataGridViewCellStyle2
        Me.Grdtypepersonne.Location = New System.Drawing.Point(3, 6)
        Me.Grdtypepersonne.Name = "Grdtypepersonne"
        Me.Grdtypepersonne.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grdtypepersonne.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Grdtypepersonne.RowHeadersVisible = False
        Me.Grdtypepersonne.Size = New System.Drawing.Size(890, 376)
        Me.Grdtypepersonne.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(899, 387)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Saisie "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Frmtypepersonne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(921, 508)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "Frmtypepersonne"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "TYPEPERSONNE"
        Me.Text = "Frmtypepersonne"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Grdtypepersonne, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CloseStripButton As System.Windows.Forms.Button
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.Button
    Friend WithEvents EditToolStripButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UndoToolStripButton As System.Windows.Forms.Button
    Friend WithEvents NewToolStripButton As System.Windows.Forms.Button
    Friend WithEvents DelToolStripButton As System.Windows.Forms.Button
    Friend WithEvents idtypepersonne_PK As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents libelletypepersonne As System.Windows.Forms.TextBox
    Friend WithEvents Lblibelletypepersonne As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Grdtypepersonne As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
End Class
