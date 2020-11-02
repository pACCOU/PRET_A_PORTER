Imports System
Imports System.Data
Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic
Public Class Liste_des_articles_et_prix
    Private Sub Bt_fermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub CrystalReportViewerarticle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewerarticle.Load
        cnn = New MySqlConnection(DATAMANAGER.IDSERVEURS)
        cnn.Open()
        Dim cmd As MySql.Data.MySqlClient.MySqlCommand = cnn.CreateCommand
        Dim ds As New article2

        cmd.CommandText = "select libellesociete,adresse,telephone,fax,email,ifu,RCCM,raisonsociale,lebellearticle,prixunitarticle from (societe, article) order by lebellearticle "

        ds.Tables("etat_article").Load(cmd.ExecuteReader())

        If ds.Tables("etat_article").Rows.Count <= 0 Then
            MsgBox("Aucune donnée .")
            Me.Close() : Exit Sub
        End If
        Dim cr As New article
        cr.SetDataSource(ds.Tables("etat_article"))
        Me.CrystalReportViewerarticle.ReportSource = cr
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Liste_des_articles_et_prix_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class