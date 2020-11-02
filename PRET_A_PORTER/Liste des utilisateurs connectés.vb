Public Class Liste_des_utilisateurs_connectés

    Private Sub Liste_des_utilisateurs_connectés_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn = New MySqlConnection(DATAMANAGER.IDSERVEURS)
        Cnn.Open()
        Me.btn_fermer.Enabled = True
        rempl("")
    End Sub

    Private Sub btn_supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_supprimer.Click
        If MsgBox("VOULEZ - VOUS SUPPRIMER CETTE INSTANCE DE CONNEXION DE L'UTILISATEUR " & grille_listinng.CurrentRow.Cells(2).Value & "  ?", MsgBoxStyle.OkCancel, "SUPPRESSION") = MsgBoxResult.Ok Then

            Try

                Dim requete As String = "DELETE FROM listinning WHERE id ='" & grille_listinng.CurrentRow.Cells(0).Value & "'"
                Dim command As MySqlCommand = New MySqlCommand(requete, Cnn)
                command.ExecuteNonQuery()
                rempl("")
                MsgBox("SUPPRESSION EFFECTUEE AVEC  SUCCES !", MsgBoxStyle.Information, "INFORMATION")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try


        End If
    End Sub
    Sub rempl(ByVal j As String)
        Try
            Dim req As String = ""
            'If (i = "Toute les colones " Or i = "") Then
            req = "select id, listinning.iduser, compte,nomprenom, dateconnect from listinning, user where listinning.id=user.iduser_PK and compte like'%" & j & "' ORDER BY dateconnect DESC "
            'Else
            '    If (i = "Speudo") Then
            '        req = "select * from utilisateur where pseudo like'%" & j & "%'"
            '    Else
            '        req = "select * from utilisateur where motpass like'%" & j & "%'"
            '    End If

            Dim Cmd As MySqlCommand = New MySqlCommand(req, cnn)
            Dim Adap As New MySqlDataAdapter
            Adap.SelectCommand = Cmd
            Dim tblCla As New DataTable
            Adap.Fill(tblCla)
            grille_listinng.DataSource = tblCla
            Num = tblCla.Rows.Count
            grille_listinng.Columns(0).Visible = False
            grille_listinng.Columns(1).Visible = False
            Me.txt_total.Text = Num
            grille_listinng.Columns("compte").HeaderText = "Pseudonyme"
            grille_listinng.Columns("dateconnect").HeaderText = "Date et heure conncter"
            grille_listinng.Columns("nomprenom").HeaderText = "Nom & Prénom"

            grille_listinng.Columns(2).Width = 220
            grille_listinng.Columns(1).Width = 220
            grille_listinng.Columns(3).Width = 220
            grille_listinng.Columns(4).Width = 220

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub txt_valeur_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_valeur.TextChanged
        rempl(txt_valeur.Text)
    End Sub

    Private Sub btn_fermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_fermer.Click
        Me.Close()
    End Sub
End Class