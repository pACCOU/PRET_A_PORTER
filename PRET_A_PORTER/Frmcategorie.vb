Public Class Frmcategorie

   
    Private Sub Frmcategorie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActiveButtons("Liste")
        Cnn = New MySqlConnection(DATAMANAGER.IDSERVEURS)
        Cnn.Open()
        Projetload.remplir_Grill_table("CATEGORIE", Me.Grdcategorie)
        'couleurList()
        Grdcategorie.Columns("idcategorie_PK").HeaderText = "Code categorie"
        Grdcategorie.Columns("libellecategorie").HeaderText = "Désignation categorie"

        Grdcategorie.Columns(0).Width = 300
        Grdcategorie.Columns(1).Width = 600
        MAJ.CacheColonnes(Grdcategorie, True, "0")
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        EnregistrerGroupBox(Me.GroupBox1)
        Initialisation_CtrlText_groupBox(Me.GroupBox1)
        Projetload.remplir_Grill_table("CATEGORIE", Me.Grdcategorie)
        MAJ.CacheColonnes(Grdcategorie, True, "0")
    End Sub

    Private Sub EditToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripButton.Click
        If idcategorie_PK.Text <> String.Empty Then
            If MsgBox("VOULEZ - VOUS APPORTER LES MODIFICATIONS SUIVANTES A LA CATEGORIE " & Grdcategorie.CurrentRow.Cells(1).Value & "  ?", MsgBoxStyle.OkCancel, "MODIFICATION") = MsgBoxResult.Ok Then

                Try
                    Dim requete As String = "UPDATE categorie SET lebellecategorie ='" & Me.libellecategorie.Text.Replace("'", "\'") & "'WHERE idcategorie_PK ='" & Grdcategorie.CurrentRow.Cells(0).Value & "'"
                    Dim command As MySqlCommand = New MySqlCommand(requete, Cnn)
                    command.ExecuteNonQuery()
                    MsgBox("MODIFICATION EFFECTUEE AVEC  SUCCES !", MsgBoxStyle.Information, "INFORMATION")

                    Initialisation_CtrlText_groupBox(Me.GroupBox1)
                    Projetload.remplir_Grill_table("CATEGORIE", Me.Grdcategorie)
                    MAJ.CacheColonnes(Grdcategorie, True, "0")
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

    Private Sub Grdcategorie_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grdcategorie.CellClick
        If Grdcategorie.RowCount = 0 Then
            Beep()
            MsgBox("Pas de donnée dans la base")
            Exit Sub
        Else
            idcategorie_PK.Text = Grdcategorie.CurrentRow.Cells(0).Value.ToString()
            libellecategorie.Text = Grdcategorie.CurrentRow.Cells(1).Value.ToString()
        End If
    End Sub

    Private Sub Grdcategorie_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grdcategorie.CellDoubleClick
        idcategorie_PK.Text = Grdcategorie.CurrentRow.Cells(0).Value.ToString()
        libellecategorie.Text = Grdcategorie.CurrentRow.Cells(1).Value.ToString()
        Me.TabControl1.SelectedTab = Me.TabPage2
        Me.libellecategorie.Focus()
    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        ActiveButtons("Saisie")
        Me.TabControl1.SelectedTab = Me.TabPage2
        Initialisation_CtrlText_groupBox(Me.GroupBox1)
        Me.libellecategorie.Focus()
    End Sub

    Private Sub DelToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelToolStripButton.Click
        'MAJ.pro_supprimer(Me.)
        If idcategorie_PK.Text <> String.Empty Then

            If MsgBox("VOULEZ - VOUS SUPPRIMER LA CATEGORIE " & Grdcategorie.CurrentRow.Cells(1).Value & "  ?", MsgBoxStyle.OkCancel, "SUPPRESSION") = MsgBoxResult.Ok Then

                Try

                    Dim requete As String = "DELETE FROM categorie WHERE idcategorie_PK ='" & Grdcategorie.CurrentRow.Cells(0).Value & "'"
                    Dim command As MySqlCommand = New MySqlCommand(requete, Cnn)
                    command.ExecuteNonQuery()
                    Projetload.remplir_Grill_table("CATEGORIE", Me.Grdcategorie)
                    MAJ.CacheColonnes(Grdcategorie, True, "0")
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