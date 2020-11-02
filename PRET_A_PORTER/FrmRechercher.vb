Public Class FrmRechercher

    Private Sub FrmRechercher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn = New MySqlConnection(DATAMANAGER.IDSERVEURS)
        Cnn.Open()
        remplir_table("")
        MAJ.CacheColonnes(grille_load, True, "0", "3", "7", "8", "5", "6", "9", "10")
    End Sub
    Sub remplir_table(ByVal j As String)
        Try

            Dim req As String = ""

            req = " select idpersonne_PK,nompersonne,prenompersonne,idsexe_FK,tel,email,dateembauche,idtypepersonne_FK,idtypepersonnel_FK,sexe,libelletypepersonne,libellepersonnel from personne left join typepersonne on personne.idtypepersonne_FK=typepersonne.idtypepersonne_PK left join typepersonnel on personne.idtypepersonnel_FK=typepersonnel.idtypepersonnel_PK left join sexe on personne.idsexe_FK=sexe.idsexe_PK WHERE nompersonne like'%" & j & "%' or prenompersonne like'%" & j & "%'  ORDER BY nompersonne ,prenompersonne ASC"

            Dim Cmd As MySqlCommand = New MySqlCommand(req, cnn)
            Dim Adap As New MySqlDataAdapter
            Adap.SelectCommand = Cmd
            Dim tblCla As New DataTable
            Adap.Fill(tblCla)
            grille_load.DataSource = tblCla
            grille_load.Columns("nompersonne").HeaderText = "Nom "
            grille_load.Columns("prenompersonne").HeaderText = "Prénom"
            grille_load.Columns("libellepersonnel").HeaderText = "Type personnel"
            grille_load.Columns("libelletypepersonne").HeaderText = "Type de personne"
            grille_load.Columns("sexe").HeaderText = "Sexe"
            grille_load.Columns("tel").HeaderText = "Telephone"
            grille_load.Columns("email").HeaderText = "Email"
            grille_load.Columns("dateembauche").HeaderText = "Date d'enregistrement"
            'Grdpersonne.Columns("sexe").HeaderText = "Sexe"



            grille_load.Columns(0).Width = 300
            grille_load.Columns(1).Width = 300
            grille_load.Columns(2).Width = 300
            grille_load.Columns(3).Width = 300
            grille_load.Columns(4).Width = 300
            grille_load.Columns(5).Width = 300
            grille_load.Columns(6).Width = 300
            grille_load.Columns(7).Width = 300
            grille_load.Columns(8).Width = 300
            grille_load.Columns(9).Width = 300
            grille_load.Columns(10).Width = 300
            grille_load.Columns(11).Width = 300


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub txt_val_load_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_val_load.TextChanged
        remplir_table(txt_val_load.Text)
    End Sub

    Private Sub grille_load_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grille_load.CellContentClick

    End Sub

    Private Sub grille_load_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grille_load.CellDoubleClick
        If grille_load.RowCount = 0 Then
            Beep()
            MsgBox("PAS DE DONNEE DANS LA TABLE !", MsgBoxStyle.Critical, "ERREUR")
            Exit Sub
        Else
            Frmuser.idpersonne_FK.Text = grille_load.CurrentRow.Cells(0).Value
            Frmuser.nomprenom.Text = grille_load.CurrentRow.Cells(1).Value + "    " + grille_load.CurrentRow.Cells(2).Value
            Frmfacture.idpersonne_FK.Text = grille_load.CurrentRow.Cells(0).Value
            Frmfacture.nompersonne.Text = grille_load.CurrentRow.Cells(1).Value + "    " + grille_load.CurrentRow.Cells(2).Value
        End If
        Me.Close()
    End Sub
End Class