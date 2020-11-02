Imports System
Imports System.Data
Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic
Public Class Edition_Facture

    Private Sub Edition_Facture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CrystalReportFacture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportFacture.Load
        Cnn = New MySqlConnection(DATAMANAGER.IDSERVEURS)
        Cnn.Open()
        Dim cmd As MySql.Data.MySqlClient.MySqlCommand = Cnn.CreateCommand
        Dim ds As New DataSetfacture
        cmd.CommandText = "SELECT quantitevendue,montantreduction,montantfacture,datefacture,numfact,montanthred,nompersonne,lebellearticle,iduser_FK,prixvente,libellesociete,adresse,telephone,fax,ifu,RCCM,montantproduitpayer,sum(montantproduitpayer) as monttotal,beneficesurart,beneficetotal from facture,article,societe where facture.idarticle_FK=article.idarticle_PK and numfact= '" & Filtre_facture.txt_numfact.Text & "' group by quantitevendue,montantreduction,montantfacture,datefacture,numfact,montanthred,nompersonne,lebellearticle,iduser_FK,prixunitarticle,libellesociete,adresse,telephone,fax,ifu,RCCM,montantproduitpayer "
        ds.Tables("edit_facture2").Load(cmd.ExecuteReader())

        If ds.Tables("edit_facture2").Rows.Count <= 0 Then
            MsgBox("Aucune donnée .")
            Me.Close() : Exit Sub
        End If
        Dim cr As New facturation2
        'Dim ce As New Facturation
        cr.SetDataSource(ds.Tables("edit_facture2"))
        'cr.SetDataSource(ds.Tables("societe"))
        Me.CrystalReportFacture.ReportSource = cr
        'cr.SetDataSource(de.Tables("etat_societe"))
        'Me.CrystalReportFacture.ReportSource = ce
        Me.WindowState = FormWindowState.Maximized
        'Filtre_facture.Close()
    End Sub
End Class