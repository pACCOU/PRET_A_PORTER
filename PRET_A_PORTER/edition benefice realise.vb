Imports System
Imports System.Data
Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic
Public Class edition_benefice_realise

    Private Sub CrystalReportbenefice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportbenefice.Load
        Cnn = New MySqlConnection(DATAMANAGER.IDSERVEURS)
        Cnn.Open()
        Dim cmd As MySql.Data.MySqlClient.MySqlCommand = Cnn.CreateCommand
        Dim ds As New DataSetfacture
        cmd.CommandText = "SELECT quantitevendue,montantreduction,montantfacture,datefacture,numfact,montanthred,nompersonne,lebellearticle,iduser_FK,prixvente,libellesociete,adresse,telephone,fax,ifu,RCCM,montantproduitpayer,beneficearticle as monttotal,beneficesurart,beneficetotal from facture,article,societe where facture.idarticle_FK=article.idarticle_PK and datefacture between '" & Filtre_benefice.date1.Text & "' and '" & Filtre_benefice.date2.Text & "' group by quantitevendue,montantreduction,montantfacture,datefacture,numfact,montanthred,nompersonne,lebellearticle,iduser_FK,prixvente,libellesociete,adresse,telephone,fax,ifu,RCCM,montantproduitpayer "
        ds.Tables("edit_facture2").Load(cmd.ExecuteReader())

        If ds.Tables("edit_facture2").Rows.Count <= 0 Then
            MsgBox("Aucune donnée .")
            Me.Close() : Exit Sub
        End If
        '---------recuperer une valeur de sql$$**************
        Dim param As Double
        Dim dr As MySql.Data.MySqlClient.MySqlDataReader
        Dim cmd1 As MySqlClient.MySqlCommand = New MySqlCommand("select sum(beneficesurart) from facture where datefacture between '" & Filtre_benefice.date1.Text & "' and '" & Filtre_benefice.date2.Text & "' ", Cnn)
        dr = cmd1.ExecuteReader
        If dr.Read Then
            param = dr.GetValue(0)
        End If

        Dim cr As New benefice
        cr.SetDataSource(ds.Tables("edit_facture2"))
        Me.CrystalReportbenefice.ReportSource = cr
        cr.SetParameterValue("datedebut", Filtre_benefice.date1.Text)
        cr.SetParameterValue("datefin", Filtre_benefice.date2.Text)
        cr.SetParameterValue("TOTO", param)   '-------------affecter la valeur de la requete au param crys*****************
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub edition_benefice_realise_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class