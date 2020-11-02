<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Liste_des_utilisateurs_connectés
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Liste_des_utilisateurs_connectés))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btn_fermer = New System.Windows.Forms.Button
        Me.btn_supprimer = New System.Windows.Forms.Button
        Me.grille_listinng = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_total = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_valeur = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        CType(Me.grille_listinng, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btn_fermer)
        Me.Panel1.Controls.Add(Me.btn_supprimer)
        Me.Panel1.Location = New System.Drawing.Point(520, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(187, 56)
        Me.Panel1.TabIndex = 12
        '
        'btn_fermer
        '
        Me.btn_fermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_fermer.Image = CType(resources.GetObject("btn_fermer.Image"), System.Drawing.Image)
        Me.btn_fermer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_fermer.Location = New System.Drawing.Point(98, 10)
        Me.btn_fermer.Name = "btn_fermer"
        Me.btn_fermer.Size = New System.Drawing.Size(82, 34)
        Me.btn_fermer.TabIndex = 10
        Me.btn_fermer.Text = "&Fermer"
        Me.btn_fermer.UseVisualStyleBackColor = True
        '
        'btn_supprimer
        '
        Me.btn_supprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_supprimer.Location = New System.Drawing.Point(5, 10)
        Me.btn_supprimer.Name = "btn_supprimer"
        Me.btn_supprimer.Size = New System.Drawing.Size(88, 34)
        Me.btn_supprimer.TabIndex = 8
        Me.btn_supprimer.Text = "&Supprimer"
        Me.btn_supprimer.UseVisualStyleBackColor = True
        '
        'grille_listinng
        '
        Me.grille_listinng.AllowUserToAddRows = False
        Me.grille_listinng.AllowUserToDeleteRows = False
        Me.grille_listinng.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grille_listinng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grille_listinng.Location = New System.Drawing.Point(12, 92)
        Me.grille_listinng.Name = "grille_listinng"
        Me.grille_listinng.ReadOnly = True
        Me.grille_listinng.RowHeadersVisible = False
        Me.grille_listinng.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grille_listinng.Size = New System.Drawing.Size(695, 401)
        Me.grille_listinng.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_total)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_valeur)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(466, 64)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rechercher"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(310, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Total :"
        '
        'txt_total
        '
        Me.txt_total.Enabled = False
        Me.txt_total.Location = New System.Drawing.Point(368, 23)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(68, 20)
        Me.txt_total.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Valeur"
        '
        'txt_valeur
        '
        Me.txt_valeur.Location = New System.Drawing.Point(97, 21)
        Me.txt_valeur.Name = "txt_valeur"
        Me.txt_valeur.Size = New System.Drawing.Size(185, 20)
        Me.txt_valeur.TabIndex = 29
        '
        'Liste_des_utilisateurs_connectés
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(730, 539)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grille_listinng)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Liste_des_utilisateurs_connectés"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liste_des_utilisateurs_connectés"
        Me.Panel1.ResumeLayout(False)
        CType(Me.grille_listinng, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_fermer As System.Windows.Forms.Button
    Friend WithEvents btn_supprimer As System.Windows.Forms.Button
    Friend WithEvents grille_listinng As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_valeur As System.Windows.Forms.TextBox
End Class
