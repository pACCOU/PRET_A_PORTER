Public Class EditionFacturationperiode

    Private Sub CrystalReportperiode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportperiode.Load
        Cnn = New MySqlConnection(DATAMANAGER.IDSERVEURS)
        Cnn.Open()
        Dim cmd As MySql.Data.MySqlClient.MySqlCommand = Cnn.CreateCommand
        Dim ds As New DataSetfacture
        cmd.CommandText = "SELECT quantitevendue,montantreduction,montantfacture,datefacture,numfact,montanthred,nompersonne,lebellearticle,iduser_FK,prixunitarticle,libellesociete,adresse,telephone,fax,ifu,RCCM,montantproduitpayer,sum(montantproduitpayer) as monttotal from facture,article,societe where facture.idarticle_FK=article.idarticle_PK and datefacture between '" & Facture_d_une_période_donnée.date1.Text & "' and '" & Facture_d_une_période_donnée.date2.Text & "' group by quantitevendue,montantreduction,montantfacture,datefacture,numfact,montanthred,nompersonne,lebellearticle,iduser_FK,prixunitarticle,libellesociete,adresse,telephone,fax,ifu,RCCM,montantproduitpayer "
        ds.Tables("edit_facture").Load(cmd.ExecuteReader())

        If ds.Tables("edit_facture").Rows.Count <= 0 Then
            MsgBox("Aucune donnée .")
            Me.Close() : Exit Sub
        End If
        Dim cr As New facturationperiode

        cr.SetDataSource(ds.Tables("edit_facture"))
        Me.CrystalReportperiode.ReportSource = cr
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub EditionFacturationperiode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class