Imports System
Imports System.Data
Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic
Public Class Liste_du_Personnel

    Private Sub CrystalReportViewerpersonne_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewerpersonne.Load
        Cnn = New MySqlConnection(DATAMANAGER.IDSERVEURS)
        Cnn.Open()
        Dim cmd As MySql.Data.MySqlClient.MySqlCommand = Cnn.CreateCommand
        Dim ds As New personnel

        cmd.CommandText = "select libellesociete,adresse,telephone,fax,societe.email,societe.ifu,nompersonne,prenompersonne,tel,dateembauche,libellepersonnel,societe.RCCM,societe.raisonsociale from (societe, personne, typepersonnel) where personne.idtypepersonnel_FK = typepersonnel.idtypepersonnel_PK order by nompersonne asc ,prenompersonne asc"

        ds.Tables("etat_personnel").Load(cmd.ExecuteReader())

        If ds.Tables("etat_personnel").Rows.Count <= 0 Then
            MsgBox("Aucune donnée .")
            Me.Close() : Exit Sub
        End If
        Dim cr As New personnel2
        cr.SetDataSource(ds.Tables("etat_personnel"))
        Me.CrystalReportViewerpersonne.ReportSource = cr
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Bt_fermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Liste_du_Personnel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class