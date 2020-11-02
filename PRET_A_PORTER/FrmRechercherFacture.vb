Public Class FrmRechercherFacture

    Private Sub FrmRechercherFacture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn = New MySqlConnection(DATAMANAGER.IDSERVEURS)
        Cnn.Open()
        remplir_table("")
    End Sub
    Sub remplir_table(ByVal j As String)
        Try

            Dim req As String = ""

            req = "SELECT numfact,nompersonne as client,datefacture FROM facture WHERE numfact like'%" & j & "%' group by numfact,nompersonne ,datefacture ORDER BY numfact ASC"

            Dim Cmd As MySqlCommand = New MySqlCommand(req, cnn)
            Dim Adap As New MySqlDataAdapter
            Adap.SelectCommand = Cmd
            Dim tblCla As New DataTable
            Adap.Fill(tblCla)
            grille_load.DataSource = tblCla
            grille_load.Columns("numfact").HeaderText = "Numéro Facture "
            'grille_load.Columns("prenompersonne").HeaderText = "Prénom"


            grille_load.Columns(0).Width = 300
            grille_load.Columns(1).Width = 300
            grille_load.Columns(2).Width = 300


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub txt_val_load_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_val_load.TextChanged
        remplir_table(txt_val_load.Text)
    End Sub
    Private Sub grille_load_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grille_load.CellDoubleClick
        If grille_load.RowCount = 0 Then
            Beep()
            MsgBox("PAS DE DONNEE DANS LA TABLE !", MsgBoxStyle.Critical, "ERREUR")
            Exit Sub
        Else
            Filtre_facture.txt_numfact.Text = grille_load.CurrentRow.Cells(0).Value
            Filtre_facture.txt_prenomp.Text = grille_load.CurrentRow.Cells(1).Value
            Filtre_facture.btnAFFICHER.Enabled = True
            'Filtre_facture.idpersonne_FK.Text = grille_load.CurrentRow.Cells(0).Value
            'Frmfacture.nomprenom.Text = grille_load.CurrentRow.Cells(1).Value + "    " + grille_load.CurrentRow.Cells(2).Value
        End If
        Me.Close()
    End Sub
End Class