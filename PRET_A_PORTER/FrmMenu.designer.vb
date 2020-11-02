<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ParamètresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ArticleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PersonneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TypePersonneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TypePersonnelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SociétéToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListesDesStocksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.STocksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FactureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EtatsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.FactureToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.EtatStockPourUnePériodeDonnéeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListeDesArticlesAvecLeursPrixToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListeDuPersonnelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListeDesFacturesPourUnePériodeDonnéeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OutilsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.confirmationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListinningDesConnexionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AProposToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.BénéficeRéaliséToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Lprofil = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParamètresToolStripMenuItem, Me.ListesDesStocksToolStripMenuItem, Me.FactureToolStripMenuItem, Me.EtatsToolStripMenuItem1, Me.OutilsToolStripMenuItem, Me.AProposToolStripMenuItem1, Me.BénéficeRéaliséToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(704, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ParamètresToolStripMenuItem
        '
        Me.ParamètresToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.ParamètresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArticleToolStripMenuItem, Me.PersonneToolStripMenuItem, Me.TypePersonneToolStripMenuItem, Me.TypePersonnelToolStripMenuItem, Me.SociétéToolStripMenuItem})
        Me.ParamètresToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParamètresToolStripMenuItem.Image = CType(resources.GetObject("ParamètresToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ParamètresToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ParamètresToolStripMenuItem.Name = "ParamètresToolStripMenuItem"
        Me.ParamètresToolStripMenuItem.Size = New System.Drawing.Size(105, 21)
        Me.ParamètresToolStripMenuItem.Text = "Paramètres"
        '
        'ArticleToolStripMenuItem
        '
        Me.ArticleToolStripMenuItem.Image = Global.PRET_A_PORTER.My.Resources.Resources.nv3
        Me.ArticleToolStripMenuItem.Name = "ArticleToolStripMenuItem"
        Me.ArticleToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ArticleToolStripMenuItem.Text = "Article"
        '
        'PersonneToolStripMenuItem
        '
        Me.PersonneToolStripMenuItem.Image = Global.PRET_A_PORTER.My.Resources.Resources.nv3
        Me.PersonneToolStripMenuItem.Name = "PersonneToolStripMenuItem"
        Me.PersonneToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.PersonneToolStripMenuItem.Text = "Personne"
        '
        'TypePersonneToolStripMenuItem
        '
        Me.TypePersonneToolStripMenuItem.Image = Global.PRET_A_PORTER.My.Resources.Resources.nv4
        Me.TypePersonneToolStripMenuItem.Name = "TypePersonneToolStripMenuItem"
        Me.TypePersonneToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.TypePersonneToolStripMenuItem.Text = "Type Personne "
        '
        'TypePersonnelToolStripMenuItem
        '
        Me.TypePersonnelToolStripMenuItem.Image = Global.PRET_A_PORTER.My.Resources.Resources.nv3
        Me.TypePersonnelToolStripMenuItem.Name = "TypePersonnelToolStripMenuItem"
        Me.TypePersonnelToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.TypePersonnelToolStripMenuItem.Text = "Type Personnel"
        '
        'SociétéToolStripMenuItem
        '
        Me.SociétéToolStripMenuItem.Image = Global.PRET_A_PORTER.My.Resources.Resources.nv4
        Me.SociétéToolStripMenuItem.Name = "SociétéToolStripMenuItem"
        Me.SociétéToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.SociétéToolStripMenuItem.Text = "Société"
        '
        'ListesDesStocksToolStripMenuItem
        '
        Me.ListesDesStocksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STocksToolStripMenuItem})
        Me.ListesDesStocksToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListesDesStocksToolStripMenuItem.Image = Global.PRET_A_PORTER.My.Resources.Resources.outils1
        Me.ListesDesStocksToolStripMenuItem.Name = "ListesDesStocksToolStripMenuItem"
        Me.ListesDesStocksToolStripMenuItem.Size = New System.Drawing.Size(138, 21)
        Me.ListesDesStocksToolStripMenuItem.Text = "Gestion de stock"
        '
        'STocksToolStripMenuItem
        '
        Me.STocksToolStripMenuItem.Image = Global.PRET_A_PORTER.My.Resources.Resources.outils
        Me.STocksToolStripMenuItem.Name = "STocksToolStripMenuItem"
        Me.STocksToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.STocksToolStripMenuItem.Text = "Stocks"
        '
        'FactureToolStripMenuItem
        '
        Me.FactureToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FactureToolStripMenuItem.Image = Global.PRET_A_PORTER.My.Resources.Resources.modifier6
        Me.FactureToolStripMenuItem.Name = "FactureToolStripMenuItem"
        Me.FactureToolStripMenuItem.Size = New System.Drawing.Size(81, 21)
        Me.FactureToolStripMenuItem.Text = "Facture"
        '
        'EtatsToolStripMenuItem1
        '
        Me.EtatsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FactureToolStripMenuItem1, Me.EtatStockPourUnePériodeDonnéeToolStripMenuItem, Me.ListeDesArticlesAvecLeursPrixToolStripMenuItem, Me.ListeDuPersonnelToolStripMenuItem, Me.ListeDesFacturesPourUnePériodeDonnéeToolStripMenuItem})
        Me.EtatsToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtatsToolStripMenuItem1.Image = Global.PRET_A_PORTER.My.Resources.Resources.voir
        Me.EtatsToolStripMenuItem1.Name = "EtatsToolStripMenuItem1"
        Me.EtatsToolStripMenuItem1.Size = New System.Drawing.Size(66, 21)
        Me.EtatsToolStripMenuItem1.Text = "Etats"
        '
        'FactureToolStripMenuItem1
        '
        Me.FactureToolStripMenuItem1.Image = Global.PRET_A_PORTER.My.Resources.Resources.modifier62
        Me.FactureToolStripMenuItem1.Name = "FactureToolStripMenuItem1"
        Me.FactureToolStripMenuItem1.Size = New System.Drawing.Size(344, 22)
        Me.FactureToolStripMenuItem1.Text = "Facture"
        '
        'EtatStockPourUnePériodeDonnéeToolStripMenuItem
        '
        Me.EtatStockPourUnePériodeDonnéeToolStripMenuItem.Image = CType(resources.GetObject("EtatStockPourUnePériodeDonnéeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EtatStockPourUnePériodeDonnéeToolStripMenuItem.Name = "EtatStockPourUnePériodeDonnéeToolStripMenuItem"
        Me.EtatStockPourUnePériodeDonnéeToolStripMenuItem.Size = New System.Drawing.Size(344, 22)
        Me.EtatStockPourUnePériodeDonnéeToolStripMenuItem.Text = "Etat Stock"
        '
        'ListeDesArticlesAvecLeursPrixToolStripMenuItem
        '
        Me.ListeDesArticlesAvecLeursPrixToolStripMenuItem.Image = Global.PRET_A_PORTER.My.Resources.Resources.modif31
        Me.ListeDesArticlesAvecLeursPrixToolStripMenuItem.Name = "ListeDesArticlesAvecLeursPrixToolStripMenuItem"
        Me.ListeDesArticlesAvecLeursPrixToolStripMenuItem.Size = New System.Drawing.Size(344, 22)
        Me.ListeDesArticlesAvecLeursPrixToolStripMenuItem.Text = "Liste des articles avec leurs prix"
        '
        'ListeDuPersonnelToolStripMenuItem
        '
        Me.ListeDuPersonnelToolStripMenuItem.Image = Global.PRET_A_PORTER.My.Resources.Resources.modif3
        Me.ListeDuPersonnelToolStripMenuItem.Name = "ListeDuPersonnelToolStripMenuItem"
        Me.ListeDuPersonnelToolStripMenuItem.Size = New System.Drawing.Size(344, 22)
        Me.ListeDuPersonnelToolStripMenuItem.Text = "Liste du personnel"
        '
        'ListeDesFacturesPourUnePériodeDonnéeToolStripMenuItem
        '
        Me.ListeDesFacturesPourUnePériodeDonnéeToolStripMenuItem.Image = CType(resources.GetObject("ListeDesFacturesPourUnePériodeDonnéeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListeDesFacturesPourUnePériodeDonnéeToolStripMenuItem.Name = "ListeDesFacturesPourUnePériodeDonnéeToolStripMenuItem"
        Me.ListeDesFacturesPourUnePériodeDonnéeToolStripMenuItem.Size = New System.Drawing.Size(344, 22)
        Me.ListeDesFacturesPourUnePériodeDonnéeToolStripMenuItem.Text = "Liste des factures pour une période donnée"
        '
        'OutilsToolStripMenuItem
        '
        Me.OutilsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionToolStripMenuItem, Me.confirmationToolStripMenuItem, Me.ListinningDesConnexionsToolStripMenuItem})
        Me.OutilsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutilsToolStripMenuItem.Image = Global.PRET_A_PORTER.My.Resources.Resources.user3
        Me.OutilsToolStripMenuItem.Name = "OutilsToolStripMenuItem"
        Me.OutilsToolStripMenuItem.Size = New System.Drawing.Size(100, 21)
        Me.OutilsToolStripMenuItem.Text = "&Utilisateur"
        '
        'GestionToolStripMenuItem
        '
        Me.GestionToolStripMenuItem.Image = Global.PRET_A_PORTER.My.Resources.Resources.user2
        Me.GestionToolStripMenuItem.Name = "GestionToolStripMenuItem"
        Me.GestionToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.GestionToolStripMenuItem.Text = "Gestionnaire des utilisateurs"
        '
        'confirmationToolStripMenuItem
        '
        Me.confirmationToolStripMenuItem.Image = Global.PRET_A_PORTER.My.Resources.Resources.modifier5
        Me.confirmationToolStripMenuItem.Name = "confirmationToolStripMenuItem"
        Me.confirmationToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.confirmationToolStripMenuItem.Text = "Configuration du mot de passe"
        '
        'ListinningDesConnexionsToolStripMenuItem
        '
        Me.ListinningDesConnexionsToolStripMenuItem.Image = Global.PRET_A_PORTER.My.Resources.Resources.voir1
        Me.ListinningDesConnexionsToolStripMenuItem.Name = "ListinningDesConnexionsToolStripMenuItem"
        Me.ListinningDesConnexionsToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.ListinningDesConnexionsToolStripMenuItem.Text = "Listinning des connexions"
        '
        'AProposToolStripMenuItem1
        '
        Me.AProposToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AProposToolStripMenuItem1.Image = Global.PRET_A_PORTER.My.Resources.Resources.modifier
        Me.AProposToolStripMenuItem1.Name = "AProposToolStripMenuItem1"
        Me.AProposToolStripMenuItem1.Size = New System.Drawing.Size(92, 21)
        Me.AProposToolStripMenuItem1.Text = "&A propos"
        '
        'BénéficeRéaliséToolStripMenuItem
        '
        Me.BénéficeRéaliséToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BénéficeRéaliséToolStripMenuItem.Name = "BénéficeRéaliséToolStripMenuItem"
        Me.BénéficeRéaliséToolStripMenuItem.Size = New System.Drawing.Size(116, 21)
        Me.BénéficeRéaliséToolStripMenuItem.Text = "Bénéfice réalisé"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "****BIENVENU***"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Algerian", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 21)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Profil :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(0, 365)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(704, 20)
        Me.DateTimePicker1.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(31, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 17
        '
        'Lprofil
        '
        Me.Lprofil.AutoSize = True
        Me.Lprofil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lprofil.Location = New System.Drawing.Point(103, 247)
        Me.Lprofil.Name = "Lprofil"
        Me.Lprofil.Size = New System.Drawing.Size(19, 20)
        Me.Lprofil.TabIndex = 19
        Me.Lprofil.Text = "5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 20)
        Me.Label6.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Lime
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Font = New System.Drawing.Font("Algerian", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 294)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(479, 71)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "FASHION-LAND"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(704, 385)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Lprofil)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FrmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GESTION PRÊT A PORTER (GS++) -Copyright 2015 _ Tout Droit Réservé"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ParamètresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArticleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TypePersonneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TypePersonnelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListesDesStocksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents STocksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FactureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EtatsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutilsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents confirmationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents SociétéToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lprofil As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents AProposToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListinningDesConnexionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FactureToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EtatStockPourUnePériodeDonnéeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListeDesArticlesAvecLeursPrixToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListeDuPersonnelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListeDesFacturesPourUnePériodeDonnéeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BénéficeRéaliséToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
