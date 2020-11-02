Public Class Frmuser

    Private Sub Frmuser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn = New MySqlConnection(DATAMANAGER.IDSERVEURS)
        Cnn.Open()
        Projetload.remplir_Grill_table("USER", Me.Grduser)
        RemplirComboprofil()
        RemplirCombosociete()
        Grduser.Columns("nomprenom").HeaderText = "Nom & Prénom"
        Grduser.Columns("compte").HeaderText = "Compte"
        Grduser.Columns("idprofil_FK").HeaderText = "Profil"
        Grduser.Columns(1).Width = 300
        Grduser.Columns(2).Width = 300
        Grduser.Columns(5).Width = 300
        Grduser.Columns(6).Width = 300
        'Grdcategorie.Columns(1).Width = 600
        MAJ.CacheColonnes(Grduser, True, "0", "2", "3", "4", "6")
        ActiveButtons("Liste")
    End Sub
    Private Function RemplirCombosociete() As Boolean
        Dim Cmd As MySqlCommand = New MySqlCommand("SELECT idsociete_PK,libellesociete FROM societe ORDER BY libellesociete", Cnn)
        Dim Adap As New MySqlDataAdapter
        Adap.SelectCommand = Cmd
        Dim tblCli As New DataTable
        Adap.Fill(tblCli)
        Cmb_idsociete_FK.DataSource = tblCli
        Cmb_idsociete_FK.DisplayMember = tblCli.Columns(1).ColumnName

        Cmb_idsociete_FK.SelectedIndex = -1
        Return True
    End Function
    Private Function RemplirComboprofil() As Boolean
        Dim Cmd As MySqlCommand = New MySqlCommand("SELECT* FROM profil ORDER BY libelleprofil", Cnn)
        Dim Adap As New MySqlDataAdapter
        Adap.SelectCommand = Cmd
        Dim tblCli As New DataTable
        Adap.Fill(tblCli)
        Cmb_idprofil_FK.DataSource = tblCli
        Cmb_idprofil_FK.DisplayMember = tblCli.Columns(1).ColumnName

        Cmb_idprofil_FK.SelectedIndex = -1
        Return True
    End Function

    Private Sub Cmb_idsociete_FK_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_idsociete_FK.SelectedIndexChanged
        If Cmb_idsociete_FK.SelectedIndex = -1 Then
            idsociete_FK.Text = ""
        Else
            idsociete_FK.Text = functionClasse.RecupCodeCombo(Cmb_idsociete_FK, "idsociete_PK")
        End If
    End Sub

    Private Sub Cmb_idprofil_FK_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_idprofil_FK.SelectedIndexChanged
        If Cmb_idprofil_FK.SelectedIndex = -1 Then
            idprofil_FK.Text = ""
        Else
            idprofil_FK.Text = functionClasse.RecupCodeCombo(Cmb_idprofil_FK, "idprofil_PK")
        End If
    End Sub
    Private Function CanSave() As Boolean
        If nomprenom.Text.Trim = String.Empty Then
            MsgBox(GlobalConstants.MSG_SAISIR_NOMPRENOM_USER)
            nomprenom.Focus()
            Exit Function
        End If
        If compte.Text.Trim = String.Empty Then
            MsgBox(GlobalConstants.MSG_SAISIR_LOGIN_USER)
            compte.Focus()
            Exit Function
        End If
        If motdepasse.Text.Trim = String.Empty Then
            MsgBox(GlobalConstants.MSG_SAISIR_PWD_USER)
            motdepasse.Focus()
            Exit Function
        End If
        If TxtConfirmation.Text.Trim = String.Empty Then
            MsgBox(GlobalConstants.MSG_SAISIR_CONFIRPWD_USER)
            TxtConfirmation.Focus()
            Exit Function
        End If
        If TxtConfirmation.Text.Trim <> motdepasse.Text.Trim Then
            MsgBox(GlobalConstants.MSG_SAISIR_CONFIRPWD_USER)
            TxtConfirmation.Focus()
            TxtConfirmation.SelectionStart = 0
            TxtConfirmation.SelectionLength = TxtConfirmation.TextLength
            Exit Function
        End If
        'If ChkLstProfil.CheckedItems.Count = 0 Then
        '    MsgBox(GlobalConstants.MSG_COCHER_PROFIL_USER)
        '    ChkLstProfil.Focus()
        '    Exit Function
        'End If
        If Cmb_idprofil_FK.Text.Trim = String.Empty Then
            MsgBox(GlobalConstants.MSG_SELECTIONNER_PROFILDEFAUT_USER)
            Cmb_idprofil_FK.Focus()
            Exit Function
        End If
        If Cmb_idsociete_FK.Text.Trim = String.Empty Then
            MsgBox(GlobalConstants.MSG_SELECTIONNER_USINE_USER)
            Cmb_idprofil_FK.Focus()
            Exit Function
        End If

        Return True
    End Function

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        If CanSave() Then
            Try
                'Enregistre les données de l'utilisateur
                EnregistrerGroupBox(Me.GroupBox1)
                Initialisation_CtrlText_groupBox(Me.GroupBox1)
                Cmb_idprofil_FK.SelectedIndex = -1
                Cmb_idsociete_FK.SelectedIndex = -1
                Projetload.remplir_Grill_table("USER", Me.Grduser)
                MAJ.CacheColonnes(Grduser, True, "0", "2", "3", "4", "6")
                
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub DelToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelToolStripButton.Click
        If iduser_PK.Text <> String.Empty Then

            If MsgBox("VOULEZ - VOUS SUPPRIMER LA PERSONNE " & Grduser.CurrentRow.Cells(1).Value & "  ?", MsgBoxStyle.OkCancel, "SUPPRESSION") = MsgBoxResult.Ok Then

                Try

                    Dim requete As String = "DELETE FROM user WHERE iduser_PK ='" & Grduser.CurrentRow.Cells(0).Value & "'"
                    Dim command As MySqlCommand = New MySqlCommand(requete, Cnn)
                    command.ExecuteNonQuery()
                    Projetload.remplir_Grill_table("USER", Me.Grduser)
                    MAJ.CacheColonnes(Grduser, True, "0", "2", "3", "4", "6")
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
    Private Sub ActiveButtons(ByVal KelOnglet As String)
        Select Case KelOnglet
            Case "Liste", "List"
                Me.NewToolStripButton.Enabled = True
                'Me.EditToolStripButton.Enabled = True
                Me.UndoToolStripButton.Enabled = False
                Me.SaveToolStripButton.Enabled = False
                Me.DelToolStripButton.Enabled = True
            Case "Saisie"
                Me.NewToolStripButton.Enabled = False
                'Me.EditToolStripButton.Enabled = False
                Me.UndoToolStripButton.Enabled = True
                Me.SaveToolStripButton.Enabled = True
                Me.DelToolStripButton.Enabled = False
        End Select
    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        ActiveButtons("Saisie")
        Me.TabControl1.SelectedTab = Me.TabPage2
        Initialisation_CtrlText_groupBox(Me.GroupBox1)
        Cmb_idprofil_FK.SelectedIndex = -1
        Cmb_idsociete_FK.SelectedIndex = -1
        'Me.Cmb_libelletypepersonne.Focus()
        Me.nomprenom.Focus()
    End Sub

    Private Sub Grduser_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grduser.CellClick
        iduser_PK.Text = Grduser.CurrentRow.Cells(0).Value.ToString()
        nomprenom.Text = Grduser.CurrentRow.Cells(1).Value.ToString()
        motdepasse.Text = Grduser.CurrentRow.Cells(2).Value.ToString()
        TxtConfirmation.Text = Grduser.CurrentRow.Cells(2).Value.ToString()
        idprofil_FK.Text = Grduser.CurrentRow.Cells(3).Value.ToString()
        idsociete_FK.Text = Grduser.CurrentRow.Cells(4).Value.ToString()
        compte.Text = Grduser.CurrentRow.Cells("compte").Value
        idpersonne_FK.Text = Grduser.CurrentRow.Cells("idpersonne_PK").Value
    End Sub

    Private Sub Grduser_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grduser.CellDoubleClick
        iduser_PK.Text = Grduser.CurrentRow.Cells(0).Value.ToString()
        nomprenom.Text = Grduser.CurrentRow.Cells(1).Value.ToString()
        motdepasse.Text = Grduser.CurrentRow.Cells(2).Value.ToString()
        TxtConfirmation.Text = Grduser.CurrentRow.Cells(2).Value.ToString()
        idprofil_FK.Text = Grduser.CurrentRow.Cells(3).Value.ToString()
        idsociete_FK.Text = Grduser.CurrentRow.Cells(4).Value.ToString()
        compte.Text = Grduser.CurrentRow.Cells("compte").Value
        idpersonne_FK.Text = Grduser.CurrentRow.Cells("idpersonne_PK").Value
    End Sub

    Private Sub BtnRechCam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRechCam.Click
        FrmRechercher.ShowDialog()
    End Sub

    Private Sub UndoToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripButton.Click
        ActiveButtons("Liste")
        Initialisation_CtrlText_groupBox(Me.GroupBox1)
        Cmb_idprofil_FK.SelectedIndex = -1
        Cmb_idsociete_FK.SelectedIndex = -1
        Me.TabControl1.SelectedTab = Me.TabPage1

    End Sub

    Private Sub CloseStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseStripButton.Click
        Me.Close()
    End Sub
End Class