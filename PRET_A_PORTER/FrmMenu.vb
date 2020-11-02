Public Class FrmMenu

    Private Sub ArticleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArticleToolStripMenuItem.Click
        Frmarticle.ShowDialog()

    End Sub

    Private Sub PersonneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonneToolStripMenuItem.Click
        Frmpersonne.ShowDialog()
    End Sub

    Private Sub TypePersonneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TypePersonneToolStripMenuItem.Click
        Frmtypepersonne.ShowDialog()
    End Sub

    Private Sub TypePersonnelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TypePersonnelToolStripMenuItem.Click
        Frmtypepersonnel.ShowDialog()
    End Sub

    Private Sub SociétéToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SociétéToolStripMenuItem.Click
        Frmsociete.ShowDialog()
    End Sub

    Private Sub STocksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STocksToolStripMenuItem.Click
        Frmstock.ShowDialog()
    End Sub

    Private Sub FactureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FactureToolStripMenuItem.Click
        Frmfacture.ShowDialog()
    End Sub

    Private Sub ProfilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles confirmationToolStripMenuItem.Click
        f_modifier_mot_de_passe.ShowDialog()
    End Sub

    Private Sub GestionDesUtilisateurs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Frmuser.ShowDialog()
    End Sub
    Private Sub AProposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionToolStripMenuItem.Click
        Frmuser.ShowDialog()
    End Sub

    Private Sub ProfilToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'profil.ShowDialog()
    End Sub

    Private Sub ListinningDesConnexionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListinningDesConnexionsToolStripMenuItem.Click
        Liste_des_utilisateurs_connectés.ShowDialog()
    End Sub

    Private Sub FactureToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FactureToolStripMenuItem1.Click
        Filtre_facture.ShowDialog()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub AProposToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AProposToolStripMenuItem1.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub ListeDesFacturesPourUnePériodeDonnéeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListeDesFacturesPourUnePériodeDonnéeToolStripMenuItem.Click
        Facture_d_une_période_donnée.ShowDialog()
    End Sub

    Private Sub ListeDuPersonnelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListeDuPersonnelToolStripMenuItem.Click
        Liste_du_Personnel.ShowDialog()
    End Sub

    Private Sub EtatStockPourUnePériodeDonnéeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EtatStockPourUnePériodeDonnéeToolStripMenuItem.Click
        edition_stock.ShowDialog()
    End Sub

    Private Sub ListeDesArticlesAvecLeursPrixToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListeDesArticlesAvecLeursPrixToolStripMenuItem.Click
        Liste_des_articles_et_prix.ShowDialog()
    End Sub

    Private Sub FrmmMenu_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'Vérifie d'abord si la fermeture n'a pas été annulée (en particulier par un formulaire enfant)
        If Not e.Cancel Then
            If MessageBox.Show("Voulez-vous vraiment quitter le logiciel ?", "Fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then e.Cancel = True
            If Not e.Cancel Then End ' FrmSplashScreen.Close()
        End If
    End Sub

    Private Sub BénéficeRéaliséToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BénéficeRéaliséToolStripMenuItem.Click
        Filtre_benefice.ShowDialog()
    End Sub
End Class
