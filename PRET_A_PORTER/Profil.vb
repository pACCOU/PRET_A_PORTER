Public Class profil


    Private Sub profil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActiveButtons("Liste")
        Cnn = New MySqlConnection(DATAMANAGER.IDSERVEURS)
        Cnn.Open()
        Projetload.remplir_Grill_table("PROFIL", Me.Grdprofil)
        'couleurList()
        Grdprofil.Columns("idprofil_PK").HeaderText = "Code profil"
        Grdprofil.Columns("libelleprofil").HeaderText = "Profil"

        Grdprofil.Columns(0).Width = 300
        Grdprofil.Columns(1).Width = 600
        MAJ.CacheColonnes(Grdprofil, True, "0")
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        EnregistrerGroupBox(Me.GroupBox1)
        Initialisation_CtrlText_groupBox(Me.GroupBox1)
        Projetload.remplir_Grill_table("PROFIL", Me.Grdprofil)
    End Sub

    Private Sub EditToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripButton.Click
        If idprofil_PK.Text <> String.Empty Then
            If MsgBox("VOULEZ - VOUS APPORTER LES MODIFICATIONS SUIVANTES A LA CATEGORIE " & Grdprofil.CurrentRow.Cells(1).Value & "  ?", MsgBoxStyle.OkCancel, "MODIFICATION") = MsgBoxResult.Ok Then

                Try
                    Dim requete As String = "UPDATE profil SET libelleprofil ='" & Me.libelleprofil.Text.Replace("'", "\'") & "'WHERE idprofil_PK ='" & Grdprofil.CurrentRow.Cells(0).Value & "'"
                    Dim command As MySqlCommand = New MySqlCommand(requete, Cnn)
                    command.ExecuteNonQuery()
                    MsgBox("MODIFICATION EFFECTUEE AVEC  SUCCES !", MsgBoxStyle.Information, "INFORMATION")

                    Initialisation_CtrlText_groupBox(Me.GroupBox1)
                    Projetload.remplir_Grill_table("PROFIL", Me.Grdprofil)
                    Me.TabControl1.SelectedTab = Me.TabPage1

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
            'ModifierGroupBox(Me.GroupBox1)

        Else
            MsgBox("Double_clique sur l'élement à modifier")
        End If
    End Sub

    Private Sub Grdcprofil_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grdprofil.CellClick, Grdprofil.CellClick
        If Grdprofil.RowCount = 0 Then
            Beep()
            MsgBox("Pas de donnée dans la base")
            Exit Sub
        Else
            idprofil_PK.Text = Grdprofil.CurrentRow.Cells(0).Value.ToString()
            libelleprofil.Text = Grdprofil.CurrentRow.Cells(1).Value.ToString()
        End If
    End Sub

    Private Sub Grdprofil_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grdprofil.CellDoubleClick
        idprofil_PK.Text = Grdprofil.CurrentRow.Cells(0).Value.ToString()
        libelleprofil.Text = Grdprofil.CurrentRow.Cells(1).Value.ToString()
        Me.TabControl1.SelectedTab = Me.TabPage2
        Me.libelleprofil.Focus()
    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        ActiveButtons("Saisie")
        Me.TabControl1.SelectedTab = Me.TabPage2
        Initialisation_CtrlText_groupBox(Me.GroupBox1)
        Me.libelleprofil.Focus()
    End Sub

    Private Sub DelToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelToolStripButton.Click
        'MAJ.pro_supprimer(Me.)
        If idprofil_PK.Text <> String.Empty Then

            If MsgBox("VOULEZ - VOUS SUPPRIMER LA CATEGORIE " & Grdprofil.CurrentRow.Cells(1).Value & "  ?", MsgBoxStyle.OkCancel, "SUPPRESSION") = MsgBoxResult.Ok Then

                Try

                    Dim requete As String = "DELETE FROM categorie WHERE idprofil_PK ='" & Grdprofil.CurrentRow.Cells(0).Value & "'"
                    Dim command As MySqlCommand = New MySqlCommand(requete, Cnn)
                    command.ExecuteNonQuery()
                    Projetload.remplir_Grill_table("PROFIL", Me.Grdprofil)
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
End Class