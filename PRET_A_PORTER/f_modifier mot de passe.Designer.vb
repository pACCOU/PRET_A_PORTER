<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_modifier_mot_de_passe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(f_modifier_mot_de_passe))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txt_compte = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btn_enregistrer = New System.Windows.Forms.Button
        Me.configur = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.nouvo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ancien = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_compte)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.btn_enregistrer)
        Me.GroupBox1.Controls.Add(Me.configur)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.nouvo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ancien)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(29, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(491, 272)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Espace de Configuration de Mot de Passe"
        '
        'txt_compte
        '
        Me.txt_compte.Location = New System.Drawing.Point(262, 29)
        Me.txt_compte.Name = "txt_compte"
        Me.txt_compte.Size = New System.Drawing.Size(180, 19)
        Me.txt_compte.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 12)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Compte"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(43, 214)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'btn_enregistrer
        '
        Me.btn_enregistrer.Image = CType(resources.GetObject("btn_enregistrer.Image"), System.Drawing.Image)
        Me.btn_enregistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_enregistrer.Location = New System.Drawing.Point(214, 225)
        Me.btn_enregistrer.Name = "btn_enregistrer"
        Me.btn_enregistrer.Size = New System.Drawing.Size(90, 28)
        Me.btn_enregistrer.TabIndex = 25
        Me.btn_enregistrer.Text = "&Appliquer"
        Me.btn_enregistrer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_enregistrer.UseVisualStyleBackColor = True
        '
        'configur
        '
        Me.configur.Location = New System.Drawing.Point(262, 183)
        Me.configur.Name = "configur"
        Me.configur.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.configur.Size = New System.Drawing.Size(180, 19)
        Me.configur.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(236, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Confirmer Le Nouveau Mot de Passe"
        '
        'nouvo
        '
        Me.nouvo.Location = New System.Drawing.Point(262, 127)
        Me.nouvo.Name = "nouvo"
        Me.nouvo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.nouvo.Size = New System.Drawing.Size(180, 19)
        Me.nouvo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Entrer Le Nouveau Mot de Passe"
        '
        'ancien
        '
        Me.ancien.Location = New System.Drawing.Point(262, 75)
        Me.ancien.Name = "ancien"
        Me.ancien.Size = New System.Drawing.Size(180, 19)
        Me.ancien.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Entrer Votre Ancien Mot de Passe" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'f_modifier_mot_de_passe
        '
        Me.AcceptButton = Me.btn_enregistrer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(545, 313)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "f_modifier_mot_de_passe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "f_modifier_mot_de_passe"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_enregistrer As System.Windows.Forms.Button
    Friend WithEvents configur As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nouvo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ancien As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_compte As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
