<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmuser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmuser))
        Me.iduser_PK = New System.Windows.Forms.TextBox
        Me.idprofil_FK = New System.Windows.Forms.TextBox
        Me.CloseStripButton = New System.Windows.Forms.Button
        Me.SaveToolStripButton = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.UndoToolStripButton = New System.Windows.Forms.Button
        Me.NewToolStripButton = New System.Windows.Forms.Button
        Me.DelToolStripButton = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Grduser = New System.Windows.Forms.DataGridView
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.idpersonne_FK = New System.Windows.Forms.TextBox
        Me.BtnRechCam = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtConfirmation = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Cmb_idsociete_FK = New System.Windows.Forms.ComboBox
        Me.Cmb_idprofil_FK = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.motdepasse = New System.Windows.Forms.TextBox
        Me.compte = New System.Windows.Forms.TextBox
        Me.nomprenom = New System.Windows.Forms.TextBox
        Me.idsociete_FK = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Grduser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'iduser_PK
        '
        Me.iduser_PK.Location = New System.Drawing.Point(672, 135)
        Me.iduser_PK.Name = "iduser_PK"
        Me.iduser_PK.Size = New System.Drawing.Size(44, 22)
        Me.iduser_PK.TabIndex = 216
        Me.iduser_PK.Tag = ""
        Me.iduser_PK.Visible = False
        '
        'idprofil_FK
        '
        Me.idprofil_FK.Location = New System.Drawing.Point(672, 204)
        Me.idprofil_FK.Name = "idprofil_FK"
        Me.idprofil_FK.Size = New System.Drawing.Size(44, 22)
        Me.idprofil_FK.TabIndex = 214
        Me.idprofil_FK.Tag = "idprofil_FK"
        Me.idprofil_FK.Visible = False
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
        Me.SaveToolStripButton.Location = New System.Drawing.Point(179, 9)
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(98, 37)
        Me.SaveToolStripButton.TabIndex = 235
        Me.SaveToolStripButton.Text = "&Enregistrer"
        Me.SaveToolStripButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.UndoToolStripButton)
        Me.Panel1.Controls.Add(Me.CloseStripButton)
        Me.Panel1.Controls.Add(Me.SaveToolStripButton)
        Me.Panel1.Controls.Add(Me.NewToolStripButton)
        Me.Panel1.Controls.Add(Me.DelToolStripButton)
        Me.Panel1.Location = New System.Drawing.Point(59, 453)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(820, 54)
        Me.Panel1.TabIndex = 5
        '
        'UndoToolStripButton
        '
        Me.UndoToolStripButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UndoToolStripButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.UndoToolStripButton.Image = CType(resources.GetObject("UndoToolStripButton.Image"), System.Drawing.Image)
        Me.UndoToolStripButton.Location = New System.Drawing.Point(517, 9)
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
        Me.DelToolStripButton.Location = New System.Drawing.Point(342, 9)
        Me.DelToolStripButton.Name = "DelToolStripButton"
        Me.DelToolStripButton.Size = New System.Drawing.Size(98, 37)
        Me.DelToolStripButton.TabIndex = 236
        Me.DelToolStripButton.Text = "&Supprimer"
        Me.DelToolStripButton.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(881, 424)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Grduser)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(873, 398)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Tag = ""
        Me.TabPage1.Text = "Liste "
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Grduser
        '
        Me.Grduser.AllowUserToAddRows = False
        Me.Grduser.AllowUserToDeleteRows = False
        Me.Grduser.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Grduser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grduser.Location = New System.Drawing.Point(3, 6)
        Me.Grduser.Name = "Grduser"
        Me.Grduser.ReadOnly = True
        Me.Grduser.RowHeadersVisible = False
        Me.Grduser.Size = New System.Drawing.Size(864, 386)
        Me.Grduser.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(873, 398)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Saisie "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.idpersonne_FK)
        Me.GroupBox1.Controls.Add(Me.BtnRechCam)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtConfirmation)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Cmb_idsociete_FK)
        Me.GroupBox1.Controls.Add(Me.Cmb_idprofil_FK)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.motdepasse)
        Me.GroupBox1.Controls.Add(Me.compte)
        Me.GroupBox1.Controls.Add(Me.nomprenom)
        Me.GroupBox1.Controls.Add(Me.iduser_PK)
        Me.GroupBox1.Controls.Add(Me.idprofil_FK)
        Me.GroupBox1.Controls.Add(Me.idsociete_FK)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(834, 246)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = "USER"
        Me.GroupBox1.Text = "données"
        '
        'idpersonne_FK
        '
        Me.idpersonne_FK.Location = New System.Drawing.Point(672, 88)
        Me.idpersonne_FK.Name = "idpersonne_FK"
        Me.idpersonne_FK.Size = New System.Drawing.Size(44, 22)
        Me.idpersonne_FK.TabIndex = 233
        Me.idpersonne_FK.Tag = "idpersonne_FK"
        Me.idpersonne_FK.Visible = False
        '
        'BtnRechCam
        '
        Me.BtnRechCam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRechCam.Image = CType(resources.GetObject("BtnRechCam.Image"), System.Drawing.Image)
        Me.BtnRechCam.Location = New System.Drawing.Point(363, 66)
        Me.BtnRechCam.Name = "BtnRechCam"
        Me.BtnRechCam.Size = New System.Drawing.Size(21, 21)
        Me.BtnRechCam.TabIndex = 232
        Me.BtnRechCam.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 231
        Me.Label7.Text = "Confirmation"
        '
        'TxtConfirmation
        '
        Me.TxtConfirmation.Location = New System.Drawing.Point(112, 162)
        Me.TxtConfirmation.Name = "TxtConfirmation"
        Me.TxtConfirmation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtConfirmation.Size = New System.Drawing.Size(247, 22)
        Me.TxtConfirmation.TabIndex = 228
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 226
        Me.Label6.Text = "Profil"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 230
        Me.Label4.Text = "Société"
        '
        'Cmb_idsociete_FK
        '
        Me.Cmb_idsociete_FK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_idsociete_FK.FormattingEnabled = True
        Me.Cmb_idsociete_FK.Location = New System.Drawing.Point(109, 25)
        Me.Cmb_idsociete_FK.Name = "Cmb_idsociete_FK"
        Me.Cmb_idsociete_FK.Size = New System.Drawing.Size(250, 24)
        Me.Cmb_idsociete_FK.TabIndex = 218
        Me.Cmb_idsociete_FK.Tag = ""
        '
        'Cmb_idprofil_FK
        '
        Me.Cmb_idprofil_FK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_idprofil_FK.FormattingEnabled = True
        Me.Cmb_idprofil_FK.Location = New System.Drawing.Point(108, 201)
        Me.Cmb_idprofil_FK.Name = "Cmb_idprofil_FK"
        Me.Cmb_idprofil_FK.Size = New System.Drawing.Size(253, 24)
        Me.Cmb_idprofil_FK.TabIndex = 217
        Me.Cmb_idprofil_FK.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 229
        Me.Label3.Text = "Mot de passe"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 227
        Me.Label2.Text = "Compte"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 224
        Me.Label1.Text = "Nom et Prénom"
        '
        'motdepasse
        '
        Me.motdepasse.Location = New System.Drawing.Point(112, 132)
        Me.motdepasse.Name = "motdepasse"
        Me.motdepasse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.motdepasse.Size = New System.Drawing.Size(248, 22)
        Me.motdepasse.TabIndex = 225
        Me.motdepasse.Tag = "motdepasse"
        '
        'compte
        '
        Me.compte.Location = New System.Drawing.Point(110, 96)
        Me.compte.Name = "compte"
        Me.compte.Size = New System.Drawing.Size(250, 22)
        Me.compte.TabIndex = 223
        Me.compte.Tag = "compte"
        '
        'nomprenom
        '
        Me.nomprenom.BackColor = System.Drawing.Color.LightGray
        Me.nomprenom.Enabled = False
        Me.nomprenom.Location = New System.Drawing.Point(110, 66)
        Me.nomprenom.Name = "nomprenom"
        Me.nomprenom.Size = New System.Drawing.Size(250, 22)
        Me.nomprenom.TabIndex = 220
        Me.nomprenom.Tag = "nomprenom"
        '
        'idsociete_FK
        '
        Me.idsociete_FK.Enabled = False
        Me.idsociete_FK.Location = New System.Drawing.Point(672, 163)
        Me.idsociete_FK.Name = "idsociete_FK"
        Me.idsociete_FK.Size = New System.Drawing.Size(44, 22)
        Me.idsociete_FK.TabIndex = 206
        Me.idsociete_FK.Tag = "idsociete_FK"
        Me.idsociete_FK.Visible = False
        '
        'Frmuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(898, 521)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "Frmuser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "USER"
        Me.Text = "Frmuser"
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Grduser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents iduser_PK As System.Windows.Forms.TextBox
    Friend WithEvents idprofil_FK As System.Windows.Forms.TextBox
    Friend WithEvents CloseStripButton As System.Windows.Forms.Button
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UndoToolStripButton As System.Windows.Forms.Button
    Friend WithEvents NewToolStripButton As System.Windows.Forms.Button
    Friend WithEvents DelToolStripButton As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Grduser As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents idsociete_FK As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtConfirmation As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cmb_idsociete_FK As System.Windows.Forms.ComboBox
    Friend WithEvents Cmb_idprofil_FK As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents motdepasse As System.Windows.Forms.TextBox
    Friend WithEvents compte As System.Windows.Forms.TextBox
    Friend WithEvents nomprenom As System.Windows.Forms.TextBox
    Friend WithEvents BtnRechCam As System.Windows.Forms.Button
    Friend WithEvents idpersonne_FK As System.Windows.Forms.TextBox
End Class
