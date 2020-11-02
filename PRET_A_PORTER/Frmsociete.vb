Public Class Frmsociete


    Private Sub Frmsociete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActiveButtons("Liste")
        Cnn = New MySqlConnection(DATAMANAGER.IDSERVEURS)
        Cnn.Open()
        Projetload.remplir_Grill_table("SOCIETE", Me.Grdsociete)
        'couleurList()
        Grdsociete.Columns("idsociete_PK").HeaderText = "Code societe"
        Grdsociete.Columns("libellesociete").HeaderText = "Non Société"
        Grdsociete.Columns("adresse").HeaderText = "Adresse"
        Grdsociete.Columns("telephone").HeaderText = "Téléphone"
        Grdsociete.Columns("fax").HeaderText = "Fax"
        Grdsociete.Columns("email").HeaderText = "Email"
        Grdsociete.Columns("ifu").HeaderText = "IFU"
        Grdsociete.Columns("RCCM").HeaderText = "RCCM"
        Grdsociete.Columns("nompdg").HeaderText = "Nom PDG"
        Grdsociete.Columns("raisonsociale").HeaderText = "raisonsociale"

        Grdsociete.Columns(0).Width = 300
        Grdsociete.Columns(1).Width = 300
        Grdsociete.Columns(2).Width = 300
        Grdsociete.Columns(3).Width = 300
        Grdsociete.Columns(4).Width = 300
        Grdsociete.Columns(5).Width = 300
        Grdsociete.Columns(6).Width = 300
        Grdsociete.Columns(7).Width = 300
        Grdsociete.Columns(8).Width = 300
        Grdsociete.Columns(9).Width = 600

        MAJ.CacheColonnes(Grdsociete, True, "0")
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click

        If MsgBox("VOULEZ - VOUS ENREGISTRER SES DONNEES ?", MsgBoxStyle.OkCancel, "ENREGISTREMENT") = MsgBoxResult.Ok Then

            Try
                'Dim prix As Double
                'prix = CDbl(prixunitarticle.Text)
                Dim requete As String = "UPDATE societe SET libellesociete ='" & Me.libellesociete.Text.Replace("'", "\'") & "', adresse = '" & Me.adresse.Text.Replace("'", "\'") & "', telephone = '" & Me.telephone.Text.Replace("'", "\'") & "', fax = '" & Me.fax.Text.Replace("'", "\'") & "', email ='" & Me.email.Text.Replace("'", "\'") & "', ifu = '" & Me.ifu.Text.Replace("'", "\'") & "', RCCM = '" & Me.RCCM.Text.Replace("'", "\'") & "',nompdg ='" & Me.nompdg.Text.Replace("'", "\'") & "',raisonsociale ='" & Me.raisonsociale.Text.Replace("'", "\'") & "' WHERE idsociete_PK = 2 "
                Dim command As MySqlCommand = New MySqlCommand(requete, Cnn)
                command.ExecuteNonQuery()
                MsgBox("ENREGISTREMENT EFFECTUEE AVEC  SUCCES !", MsgBoxStyle.Information, "INFORMATION")

                'ModifierGroupBox(Me.GroupBox1)
                Initialisation_CtrlText_groupBox(Me.GroupBox1)
                Projetload.remplir_Grill_table("societe", Me.Grdsociete)
                MAJ.CacheColonnes(Grdsociete, True, "0")
                Me.TabControl1.SelectedTab = Me.TabPage1
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

        'EnregistrerGroupBox(Me.GroupBox1)
        'Initialisation_CtrlText_groupBox(Me.GroupBox1)
        'Projetload.remplir_Grill_table("SOCIETE", Me.Grdsociete)

        'Me.libellesociete.Focus()
    End Sub

    Private Sub EditToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripButton.Click
        If idsociete_PK.Text <> String.Empty Then
            'ModifierGroupBox(Me.GroupBox1)
            'Initialisation_CtrlText_groupBox(Me.GroupBox1)
            'Projetload.remplir_Grill_table("SOCIETE", Me.Grdsociete)
            'MAJ.CacheColonnes(Grdsociete, True, "0")
            'Me.TabControl1.SelectedTab = Me.TabPage1
            If MsgBox("VOULEZ - VOUS APPORTER LES MODIFICATIONS SUIVANTES A LA SOCIETE ? " & Grdsociete.CurrentRow.Cells(2).Value & "  ?", MsgBoxStyle.OkCancel, "MODIFICATION") = MsgBoxResult.Ok Then

                Try
                    'Dim prix As Double
                    'prix = CDbl(prixunitarticle.Text)
                    Dim requete As String = "UPDATE societe SET libellesociete ='" & Me.libellesociete.Text.Replace("'", "\'") & "', adresse = '" & Me.adresse.Text.Replace("'", "\'") & "', telephone = '" & Me.telephone.Text.Replace("'", "\'") & "', fax = '" & Me.fax.Text.Replace("'", "\'") & "', email ='" & Me.email.Text.Replace("'", "\'") & "', ifu = '" & Me.ifu.Text.Replace("'", "\'") & "', RCCM = '" & Me.RCCM.Text.Replace("'", "\'") & "',nompdg ='" & Me.nompdg.Text.Replace("'", "\'") & "',raisonsociale ='" & Me.raisonsociale.Text.Replace("'", "\'") & "' WHERE idsociete_PK ='" & Grdsociete.CurrentRow.Cells(0).Value & "'"
                    Dim command As MySqlCommand = New MySqlCommand(requete, Cnn)
                    command.ExecuteNonQuery()
                    MsgBox("MODIFICATION EFFECTUEE AVEC  SUCCES !", MsgBoxStyle.Information, "INFORMATION")

                    'ModifierGroupBox(Me.GroupBox1)
                    Initialisation_CtrlText_groupBox(Me.GroupBox1)
                    Projetload.remplir_Grill_table("societe", Me.Grdsociete)
                    MAJ.CacheColonnes(Grdsociete, True, "0")
                    Me.TabControl1.SelectedTab = Me.TabPage1

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                MsgBox("Double_clique sur l'élement à modifier")
            End If
        End If
    End Sub

    Private Sub Grdsociete_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grdsociete.CellClick
        If Grdsociete.RowCount = 0 Then
            Beep()
            MsgBox("Pas de donnée dans la base")
            Exit Sub
        Else
            idsociete_PK.Text = Grdsociete.CurrentRow.Cells(0).Value.ToString()
            libellesociete.Text = Grdsociete.CurrentRow.Cells(1).Value.ToString()
            adresse.Text = Grdsociete.CurrentRow.Cells(2).Value.ToString()
            telephone.Text = Grdsociete.CurrentRow.Cells(3).Value.ToString()
            fax.Text = Grdsociete.CurrentRow.Cells(4).Value.ToString()
            email.Text = Grdsociete.CurrentRow.Cells(5).Value.ToString()
            ifu.Text = Grdsociete.CurrentRow.Cells(6).Value.ToString()
            RCCM.Text = Grdsociete.CurrentRow.Cells(7).Value.ToString()
            nompdg.Text = Grdsociete.CurrentRow.Cells(8).Value.ToString()
            raisonsociale.Text = Grdsociete.CurrentRow.Cells(9).Value.ToString()


        End If
    End Sub

    Private Sub Grdsociete_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grdsociete.CellDoubleClick
        If Grdsociete.RowCount = 0 Then
            Beep()
            MsgBox("Pas de donnée dans la base")
            Exit Sub
        Else
            idsociete_PK.Text = Grdsociete.CurrentRow.Cells(0).Value.ToString()
            libellesociete.Text = Grdsociete.CurrentRow.Cells(1).Value.ToString()
            adresse.Text = Grdsociete.CurrentRow.Cells(2).Value.ToString()
            telephone.Text = Grdsociete.CurrentRow.Cells(3).Value.ToString()
            fax.Text = Grdsociete.CurrentRow.Cells(4).Value.ToString()
            email.Text = Grdsociete.CurrentRow.Cells(5).Value.ToString()
            ifu.Text = Grdsociete.CurrentRow.Cells(6).Value.ToString()
            RCCM.Text = Grdsociete.CurrentRow.Cells(7).Value.ToString()
            nompdg.Text = Grdsociete.CurrentRow.Cells(8).Value.ToString()
            raisonsociale.Text = Grdsociete.CurrentRow.Cells(9).Value.ToString()


            Me.TabControl1.SelectedTab = Me.TabPage2
            Me.libellesociete.Focus()
        End If
    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        ActiveButtons("Saisie")
        Me.TabControl1.SelectedTab = Me.TabPage2
        Initialisation_CtrlText_groupBox(Me.GroupBox1)
        Me.libellesociete.Focus()
    End Sub

    Private Sub DelToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelToolStripButton.Click
        'MAJ.pro_supprimer(Me.)
        If idsociete_PK.Text <> String.Empty Then

            If MsgBox("VOULEZ - VOUS SUPPRIMER LA SOCIETE " & Grdsociete.CurrentRow.Cells(1).Value & "  ?", MsgBoxStyle.OkCancel, "SUPPRESSION") = MsgBoxResult.Ok Then

                Try

                    Dim requete As String = "DELETE FROM societe WHERE idsociete_PK ='" & Grdsociete.CurrentRow.Cells(0).Value & "'"
                    Dim command As MySqlCommand = New MySqlCommand(requete, Cnn)
                    command.ExecuteNonQuery()
                    Projetload.remplir_Grill_table("SOCIETE", Me.Grdsociete)
                    MAJ.CacheColonnes(Grdsociete, True, "0")
                    MsgBox("SUPPRESSION EFFECTUEE AVEC  SUCCES !", MsgBoxStyle.Information, "INFORMATION")
                    Me.TabControl1.SelectedTab = Me.TabPage1
                    Initialisation_CtrlText_groupBox(Me.GroupBox1)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
        Else
            MsgBox("VEUILLEZ  SELECTIONNER L'ELEMENT A SUPPRIMER  SVP !", MsgBoxStyle.Critical, "ERREUR")


        End If

    End Sub

    Private Sub UndoToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripButton.Click
        ActiveButtons("Liste")
        Initialisation_CtrlText_groupBox(Me.GroupBox1)
        Me.TabControl1.SelectedTab = Me.TabPage1

    End Sub
    Private Sub ActiveButtons(ByVal KelOnglet As String)
        Select Case KelOnglet
            Case "Liste", "List"
                Me.NewToolStripButton.Enabled = True
                Me.EditToolStripButton.Enabled = True
                Me.UndoToolStripButton.Enabled = False
                Me.SaveToolStripButton.Enabled = False
                Me.DelToolStripButton.Enabled = True
            Case "Saisie"
                Me.NewToolStripButton.Enabled = False
                Me.EditToolStripButton.Enabled = False
                Me.UndoToolStripButton.Enabled = True
                Me.SaveToolStripButton.Enabled = True
                Me.DelToolStripButton.Enabled = False
        End Select
    End Sub

    Private Sub CloseStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseStripButton.Click
        Me.Close()
    End Sub

    Private Sub telephone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles telephone.KeyPress
        SaisirChiffre(e)
    End Sub
End Class