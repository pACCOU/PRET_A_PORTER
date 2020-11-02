Imports System
Imports System.Data
Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic
Public Class Liste_des_articles_et_prix
    Dim cnn As New MySql.Data.MySqlClient.MySqlConnection("SERVER= localhost; UID=root; DATABASE=preta_porte; password=admin")

    Private Sub Liste_des_articles_et_prix_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cnn.Open()
        Dim cmd As MySql.Data.MySqlClient.MySqlCommand = cnn.CreateCommand
        Dim ds As New DataSet2

        cmd.CommandText = "select societe.libellesociete,societe.adresse,societe.telephone,societe.RCCM,societe.ifu, article.lebellearticle,prixunitarticle from (societe, article) "


        ds.Tables("etat_article").Load(cmd.ExecuteReader())

        If ds.Tables("etat_article").Rows.Count <= 0 Then
            MsgBox("Aucune donnée .")
            Me.Close() : Exit Sub
        End If
        Dim cr As New CrystalReport2
        cr.SetDataSource(ds.Tables("etat_article"))
        Me.CrystalReportViewerarticle.ReportSource = cr
        Me.WindowState = FormWindowState.Maximized
    End Sub



    Private Sub Bt_fermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_fermer.Click
        Me.Close()
    End Sub
End Class