Imports System
Imports System.Data
Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic
Public Class edition_stock

    Private Sub CrystalReportstock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportstock.Load
        Cnn = New MySqlConnection(DATAMANAGER.IDSERVEURS)
        Cnn.Open()
        Dim cmd As MySql.Data.MySqlClient.MySqlCommand = Cnn.CreateCommand
        Dim ds As New stock

        cmd.CommandText = "SELECT libellesociete,adresse,telephone,fax,email,ifu,RCCM,raisonsociale,lebellearticle,quantiteinitialstock,datestock FROM stock,article,societe where stock.idarticle_FK=article.idarticle_PK order by lebellearticle"

        ds.Tables("etat_stock").Load(cmd.ExecuteReader())

        If ds.Tables("etat_stock").Rows.Count <= 0 Then
            MsgBox("Aucune donnée .")
            Me.Close() : Exit Sub
        End If
        Dim cr As New stock1
        cr.SetDataSource(ds.Tables("etat_stock"))
        Me.CrystalReportstock.ReportSource = cr
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class