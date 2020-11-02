Public Class Frmarticle
    Dim Dtbarticle As DataTable
    Dim cmpt As String
    Private Sub Frmarticle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActiveButtons("Liste")
        Cnn = New MySqlConnection(DATAMANAGER.IDSERVEURS)
        Cnn.Open()
        Projetload.remplir_Grill_table("ARTICLE", Me.GrdArticle)
        'RemplirCombocat()
        dateenregistrement.Value = Date.Today
        GrdArticle.Columns("numarticle").HeaderText = "Numero article"
        GrdArticle.Columns("lebellearticle").HeaderText = "Désignation article"
        GrdArticle.Columns("marquearticle").HeaderText = "Marque"
        GrdArticle.Columns("taillearticle").HeaderText = "taille"
        GrdArticle.Columns("prixunitarticle").HeaderText = "prix article"
        GrdArticle.Columns("prixvente").HeaderText = "Prix de vente"
        GrdArticle.Columns("beneficearticle").HeaderText = "Bénéfice sur article"
        GrdArticle.Columns("dateenregistrement").HeaderText = "Date enregistrement"

        GrdArticle.Columns(0).Width = 300
        GrdArticle.Columns(1).Width = 300
        GrdArticle.Columns(2).Width = 300
        GrdArticle.Columns(3).Width = 300
        GrdArticle.Columns(4).Width = 300
        GrdArticle.Columns(5).Width = 300
        GrdArticle.Columns(6).Width = 300
        GrdArticle.Columns(7).Width = 300
        GrdArticle.Columns(8).Width = 200
        GrdArticle.Columns(9).Width = 200

        MAJ.CacheColonnes(GrdArticle, True, "0", "4")
        'Txtnumarticle.Text = "A0001"
        'incrementer(Txtnumarticle, "select numarticle from article order by numarticle DESC limit 1;", "A", 3)

        'TxtID_PATIENT_PK.Text = DalGate.LoaderDt.NextNumber("PATIENTS", "ID_PATIENT_PK")
        'Me.Txtnumarticle.Text = Format(Int32.Parse(Txtnumarticle.Text), "DP-000000000")
        'functionClasse.LoardAutoCompletesource(Dtbarticle, txtmarquearticle, "marquearticle")
    End Sub
    Private Function RemplirCombocat() As Boolean
        Dim Cmd As MySqlCommand = New MySqlCommand("SELECT*, concat(idcategorie_PK,'  ',libellecategorie) as aff2 FROM categorie ORDER BY libellecategorie", Cnn)
        Dim Adap As New MySqlDataAdapter
        Adap.SelectCommand = Cmd
        Dim tblCli As New DataTable
        Adap.Fill(tblCli)
        cmb_libellearticle.DataSource = tblCli
        cmb_libellearticle.DisplayMember = tblCli.Columns(1).ColumnName

        cmb_libellearticle.SelectedIndex = -1
        Return True
    End Function

    Private Sub cmb_libellearticle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_libellearticle.SelectedIndexChanged
        If cmb_libellearticle.SelectedIndex = -1 Then
            idcategorie_FK.Text = ""
        Else
            idcategorie_FK.Text = functionClasse.RecupCodeCombo(cmb_libellearticle, "idcategorie_PK")
        End If
    End Sub

    Private Sub txtmarquearticle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles marquearticle.TextChanged
        marquearticle.AutoCompleteCustomSource.Add(marquearticle.Text).ToString()
        functionClasse.AutoCompleteTextBox(marquearticle)
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

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        'Verification_CtrlText(Me.GroupBox1)
        If EstEnregistrable() AndAlso MessageBox.Show("Voulez-vous vraiment enregistrer ces données?", "VALIDATION ENREGISTREMENT", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Try
                'prixunitarticle.Text = CInt(prixunitarticle.Text)
                EnregistrerGroupBox(Me.GroupBox1)
                Initialisation_CtrlText_groupBox(Me.GroupBox1)
                Projetload.remplir_Grill_table("ARTICLE", Me.GrdArticle)
                MAJ.CacheColonnes(GrdArticle, True, "0", "4")
                incrementer(Txtnumarticle, "select numarticle from article order by numarticle DESC limit 1;", "A", 3)
                lebellearticle.Focus()

            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try
        End If

        
    End Sub
    Private Sub EditToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripButton.Click
        If idarticle_PK.Text <> String.Empty Then
            beneficearticle.Text = CDbl(beneficearticle.Text)
            prixvente.Text = CDbl(prixvente.Text)
            prixunitarticle.Text = CDbl(prixunitarticle.Text)
            If MsgBox("VOULEZ - VOUS APPORTER LES MODIFICATIONS SUIVANTES A L'ARTICLE " & GrdArticle.CurrentRow.Cells(2).Value & "  ?", MsgBoxStyle.OkCancel, "MODIFICATION") = MsgBoxResult.Ok Then

                Try
                    Dim requete As String = "UPDATE article SET lebellearticle ='" & Me.lebellearticle.Text.Replace("'", "\'") & "', marquearticle = '" & Me.marquearticle.Text.Replace("'", "\'") & "',taillearticle = '" & Me.txt_taillearticle.Text.Replace("'", "\'") & "', prixunitarticle = '" & Me.prixunitarticle.Text.Replace("'", "\'") & "', dateenregistrement = '" & Me.dateenregistrement.Text.Replace("'", "\'") & "', numarticle = '" & Me.Txtnumarticle.Text.Replace("'", "\'") & "', prixvente = '" & Me.prixvente.Text & "', beneficearticle = '" & Me.beneficearticle.Text & "' WHERE idarticle_PK ='" & GrdArticle.CurrentRow.Cells(0).Value & "'"
                    'Dim requete As String = "UPDATE article SET lebellearticle ='" & Me.lebellearticle.Text.Replace("'", "\'") & "', marquearticle = '" & Me.marquearticle.Text.Replace("'", "\'") & "', idcategorie_FK = '" & Me.idcategorie_FK.Text.Replace("'", "\'") & "', taillearticle = '" & Me.txt_taillearticle.Text.Replace("'", "\'") & "', prixunitarticle = '" & Me.prixunitarticle.Text.Replace("'", "\'") & "', dateenregistrement = '" & Me.dateenregistrement.Text.Replace("'", "\'") & "', numarticle = '" & Me.Txtnumarticle.Text.Replace("'", "\'") & "' WHERE idarticle_PK ='" & GrdArticle.CurrentRow.Cells(0).Value & "'"
                    Dim command As MySqlCommand = New MySqlCommand(requete, Cnn)
                    command.ExecuteNonQuery()
                    MsgBox("MODIFICATION EFFECTUEE AVEC  SUCCES !", MsgBoxStyle.Information, "INFORMATION")



                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If

            'ModifierGroupBox(Me.GroupBox1)
            Initialisation_CtrlText_groupBox(Me.GroupBox1)

            Projetload.remplir_Grill_table("ARTICLE", Me.GrdArticle)
            MAJ.CacheColonnes(GrdArticle, True, "0", "4")
            Me.TabControl1.SelectedTab = Me.TabPage1
        Else
            MsgBox("Double_clique sur l'élement à modifier")
        End If
    End Sub

    Private Sub GrdArticle_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdArticle.CellClick
        If GrdArticle.RowCount = 0 Then
            Beep()
            MsgBox("Pas de donnée dans la base")
            Exit Sub
        Else
            idarticle_PK.Text = GrdArticle.CurrentRow.Cells(0).Value.ToString()
            Txtnumarticle.Text = GrdArticle.CurrentRow.Cells(1).Value.ToString()
            lebellearticle.Text = GrdArticle.CurrentRow.Cells(2).Value.ToString()
            marquearticle.Text = GrdArticle.CurrentRow.Cells(3).Value.ToString()
            'idcategorie_FK.Text = GrdArticle.CurrentRow.Cells(4).Value.ToString()
            txt_taillearticle.Text = GrdArticle.CurrentRow.Cells(5).Value.ToString()
            Me.dateenregistrement.Text = GrdArticle.CurrentRow.Cells(7).Value.ToString()
            prixunitarticle.Text = GrdArticle.CurrentRow.Cells(6).Value.ToString()
            prixvente.Text = GrdArticle.CurrentRow.Cells(8).Value.ToString()
            beneficearticle.Text = GrdArticle.CurrentRow.Cells(9).Value.ToString()
            'Me.dateenregistrement.Text = GrdArticle.CurrentRow.Cells(8).Value.ToString()
            'cmb_libellearticle.Text = GrdArticle.CurrentRow.Cells(9).Value.ToString()
        End If
    End Sub

    Private Sub GrdArticle_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdArticle.CellDoubleClick
        idarticle_PK.Text = GrdArticle.CurrentRow.Cells(0).Value.ToString()
        Txtnumarticle.Text = GrdArticle.CurrentRow.Cells(1).Value.ToString()
        lebellearticle.Text = GrdArticle.CurrentRow.Cells(2).Value.ToString()
        marquearticle.Text = GrdArticle.CurrentRow.Cells(3).Value.ToString()
        'idcategorie_FK.Text = GrdArticle.CurrentRow.Cells(4).Value.ToString()
        txt_taillearticle.Text = GrdArticle.CurrentRow.Cells(5).Value.ToString()
        Me.dateenregistrement.Text = GrdArticle.CurrentRow.Cells(7).Value.ToString()
        prixunitarticle.Text = GrdArticle.CurrentRow.Cells(6).Value.ToString()
        prixvente.Text = GrdArticle.CurrentRow.Cells(8).Value.ToString()
        beneficearticle.Text = GrdArticle.CurrentRow.Cells(9).Value.ToString()
        Me.TabControl1.SelectedTab = Me.TabPage2
        Me.lebellearticle.Focus()
    End Sub
    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        ActiveButtons("Saisie")
        'cmpt = CInt(GrdArticle.Rows(i).Cells("idarticle_PK").Value) + 1
        Me.TabControl1.SelectedTab = Me.TabPage2
        Initialisation_CtrlText_groupBox(Me.GroupBox1)

        Dim param As String
        Dim dr As MySql.Data.MySqlClient.MySqlDataReader
        Dim cmd1 As MySqlClient.MySqlCommand = New MySqlCommand("select numarticle from article order by numarticle DESC limit 1 ", Cnn)
        dr = cmd1.ExecuteReader
        If dr.Read Then
            param = dr.GetValue(0)
        End If

        If param = String.Empty Then
            Txtnumarticle.Text = "A0001"
        Else
            incrementer(Txtnumarticle, "select numarticle from article order by numarticle DESC limit 1;", "A", 3)
        End If


        'Txtnumarticle.Text = "A0001"
        'incrementer(Txtnumarticle, "select numarticle from article order by numarticle DESC limit 1;", "A", 3)
        'Initialisation_CtrlText_groupBox(Me.GroupBox1)
        prixunitarticle.Text = "0"
        Me.lebellearticle.Focus()
    End Sub

    Private Sub DelToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelToolStripButton.Click
        'MAJ.pro_supprimer(Me.)
        If idarticle_PK.Text <> String.Empty Then

            If MsgBox("VOULEZ - VOUS SUPPRIMER L'ARTICLE " & GrdArticle.CurrentRow.Cells(1).Value & "  ?", MsgBoxStyle.OkCancel, "SUPPRESSION") = MsgBoxResult.Ok Then

                Try

                    Dim requete As String = "DELETE FROM article WHERE idarticle_PK ='" & GrdArticle.CurrentRow.Cells(0).Value & "'"
                    Dim command As MySqlCommand = New MySqlCommand(requete, Cnn)
                    command.ExecuteNonQuery()
                    Projetload.remplir_Grill_table("ARTICLE", Me.GrdArticle)
                    MAJ.CacheColonnes(GrdArticle, True, "0", "4")
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
    Private Function EstEnregistrable() As Boolean

        'If (Me.cmb_libellearticle.SelectedIndex = -1) Then
        '    MsgBox("VEUILLEZ  SELECTIONNER LA CATEGORIE  SVP !, REPRENEZ ", MsgBoxStyle.Critical, "ERREUR!!!")
        '    Return False
        'End If

        If (dateenregistrement.Value > Date.Now) Then
            MsgBox("LA DATE D'ENREGISTREMENT NE DOIT ETRE SUPERIEURE A LA DATE DU JOUR, REPRENEZ ", MsgBoxStyle.Critical, "ERREUR!!!")
            Return False
        End If

        'If Verification_CtrlText(Me.GroupBox1) = False Then
        '    Return False
        'End If

        Return True

    End Function

    Private Sub CloseStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseStripButton.Click
        Me.Close()
    End Sub

    Private Sub prixunitarticle_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles prixunitarticle.KeyPress
        Projetload.SaisirChiffre(e)
    End Sub

    Private Sub lebellearticle_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lebellearticle.KeyPress
        'e.KeyChar = String.Empty
    End Sub

    Private Sub prixunitarticle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prixunitarticle.TextChanged
        'prixunitarticle.Text = CInt(prixunitarticle.Text)
        If prixunitarticle.Text = "" Then prixunitarticle.Text = "0"
        'FormatMontant(prixunitarticle)
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub prixvente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles prixvente.KeyPress
        SaisirChiffre(e)
    End Sub

    

    Private Sub prixvente_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles prixvente.Validated
        If CInt(prixunitarticle.Text.Trim()) > IIf(Me.prixvente.Text.Trim() = "", 0, prixvente.Text.Trim()) Then
            MsgBox("LE PRIX DE VENTE DE L'ARTICLE DOIT ETRE SUPPERIEURE AU PRIX D'ACHAT !!! REPENEZ SVP", MsgBoxStyle.Critical, "ERREUR")
            prixvente.Text = ""
            prixvente.Focus()
        Else
            beneficearticle.Text = CDbl(IIf(Me.prixvente.Text.Trim() = "", 0, prixvente.Text.Trim()) - prixunitarticle.Text.Trim())
            beneficearticle.Text = CDbl(beneficearticle.Text.Trim())
            'FormatMontant(beneficearticle)

        End If
    End Sub

   
End Class