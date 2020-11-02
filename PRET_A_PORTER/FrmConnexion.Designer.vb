<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class FrmConnexion
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents compte As System.Windows.Forms.TextBox
    Friend WithEvents txt_motpass As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConnexion))
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.PasswordLabel = New System.Windows.Forms.Label
        Me.compte = New System.Windows.Forms.TextBox
        Me.txt_motpass = New System.Windows.Forms.TextBox
        Me.grille_id = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.L_idprofil = New System.Windows.Forms.Label
        Me.OK = New System.Windows.Forms.Button
        Me.Cancel = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        Me.Datecreation = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        CType(Me.grille_id, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(172, 24)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&Compte Utilisateur"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(172, 81)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Mot de passe"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'compte
        '
        Me.compte.Location = New System.Drawing.Point(174, 44)
        Me.compte.Name = "compte"
        Me.compte.Size = New System.Drawing.Size(220, 20)
        Me.compte.TabIndex = 1
        '
        'txt_motpass
        '
        Me.txt_motpass.Location = New System.Drawing.Point(174, 101)
        Me.txt_motpass.Name = "txt_motpass"
        Me.txt_motpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_motpass.Size = New System.Drawing.Size(220, 20)
        Me.txt_motpass.TabIndex = 3
        '
        'grille_id
        '
        Me.grille_id.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.grille_id.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grille_id.Location = New System.Drawing.Point(185, 142)
        Me.grille_id.Name = "grille_id"
        Me.grille_id.Size = New System.Drawing.Size(10, 10)
        Me.grille_id.TabIndex = 7
        Me.grille_id.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(367, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Visible = False
        '
        'L_idprofil
        '
        Me.L_idprofil.Location = New System.Drawing.Point(322, 129)
        Me.L_idprofil.Name = "L_idprofil"
        Me.L_idprofil.Size = New System.Drawing.Size(39, 23)
        Me.L_idprofil.TabIndex = 15
        Me.L_idprofil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.L_idprofil.Visible = False
        '
        'OK
        '
        Me.OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Image = Global.PRET_A_PORTER.My.Resources.Resources.Valider1
        Me.OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OK.Location = New System.Drawing.Point(197, 161)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&Connecter"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Image = Global.PRET_A_PORTER.My.Resources.Resources.supprimer3
        Me.Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cancel.Location = New System.Drawing.Point(300, 161)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Annuler"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(357, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.ErrorImage = Nothing
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.InitialImage = Nothing
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(165, 193)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'Datecreation
        '
        Me.Datecreation.CustomFormat = "yyyy-MM-dd"
        Me.Datecreation.Enabled = False
        Me.Datecreation.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Datecreation.Location = New System.Drawing.Point(287, 70)
        Me.Datecreation.Name = "Datecreation"
        Me.Datecreation.Size = New System.Drawing.Size(74, 20)
        Me.Datecreation.TabIndex = 257
        Me.Datecreation.Tag = "dateenregistrement"
        Me.Datecreation.Value = New Date(2008, 1, 1, 0, 0, 0, 0)
        Me.Datecreation.Visible = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(185, 70)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(43, 20)
        Me.DateTimePicker2.TabIndex = 258
        Me.DateTimePicker2.Tag = "dateenregistrement"
        Me.DateTimePicker2.Value = New Date(2008, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker2.Visible = False
        '
        'FrmConnexion
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(418, 196)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Datecreation)
        Me.Controls.Add(Me.L_idprofil)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grille_id)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.txt_motpass)
        Me.Controls.Add(Me.compte)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConnexion"
        Me.Opacity = 0.75
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connexion à (GP++)"
        CType(Me.grille_id, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grille_id As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents L_idprofil As System.Windows.Forms.Label
    Friend WithEvents Datecreation As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker

End Class
