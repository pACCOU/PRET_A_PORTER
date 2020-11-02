Public Class Filtre_facture

    Private Sub btnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFermer.Click
        Me.Close()
    End Sub

    Private Sub BtnRechCam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRechCam.Click
        FrmRechercherFacture.ShowDialog()
    End Sub

    Private Sub btnAFFICHER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAFFICHER.Click
        Me.Cursor = Cursors.Arrow
        Edition_Facture.ShowDialog()

    End Sub

    Private Sub Filtre_facture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class