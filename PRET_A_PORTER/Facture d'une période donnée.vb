Public Class Facture_d_une_période_donnée

    Private Sub Facture_d_une_période_donnée_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn = New MySqlConnection(DATAMANAGER.IDSERVEURS)
        Cnn.Open()
    End Sub

    Private Sub btnAFFICHER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAFFICHER.Click
        Dim req As String
        req = " SELECT quantitevendue,montantreduction,montantfacture,datefacture,numfact,montanthred,nompersonne,lebellearticle,iduser_FK,prixunitarticle,libellesociete,adresse,telephone,fax,ifu,RCCM,montantproduitpayer,sum(montantproduitpayer) as monttotal from facture,article,societe where facture.idarticle_FK=article.idarticle_PK and datefacture between '" & Me.date1.Text & "' and '" & Me.date2.Text & "' group by quantitevendue,montantreduction,montantfacture,datefacture,numfact,montanthred,nompersonne,lebellearticle,iduser_FK,prixunitarticle,libellesociete,adresse,telephone,fax,ifu,RCCM,montantproduitpayer "
        Dim Cmd As MySqlCommand = New MySqlCommand(req, Cnn)
        Dim Adap As New MySqlDataAdapter
        Adap.SelectCommand = Cmd
        Dim tblCla As New DataTable
        Adap.Fill(tblCla)

        If tblCla.Rows.Count <= 0 Then
            btnAFFICHER.Enabled = True
            MsgBox("PAS DE FACTURE A IMPRIMER POUR CETTE PERIODE.")
        Else
            EditionFacturationperiode.ShowDialog()
        End If
    End Sub

    Private Sub btnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFermer.Click
        Me.Close()
    End Sub
End Class