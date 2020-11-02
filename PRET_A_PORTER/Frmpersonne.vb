Public Class Frmpersonne
    Dim Dtbpersonne As DataTable
    Private Sub Frmpersonne_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn = New MySqlConnection(DATAMANAGER.IDSERVEURS)
        Cnn.Open()
        'Projetload.remplir_Grill_table("PERSONNE", Me.Grdpersonne)
        RemplirCombocat()
        RemplirCombosexe()
        RemplirCombopersonnel()
        remplir_table("")


        ActiveButtons("Liste")
        'functionClasse.LoardAutoCompletesource(Dtbarticle, txtmarquearticle, "marquearticle")
    End Sub
    Private Function RemplirCombocat() As Boolean
        Dim Cmd As MySqlCommand = New MySqlCommand("SELECT* FROM typepersonne ORDER BY libelletypepersonne", Cnn)
        Dim Adap As New MySqlDataAdapter
        Adap.SelectCommand = Cmd
        Dim tblCli As New DataTable
        Adap.Fill(tblCli)
        Cmb_libelletypepersonne.DataSource = tblCli
        Cmb_libelletypepersonne.DisplayMember = tblCli.Columns(1).ColumnName

        Cmb_libelletypepersonne.SelectedIndex = -1
        Return True
    End Function
    Private Function RemplirCombosexe() As Boolean
        Dim Cmd As MySqlCommand = New MySqlCommand("SELECT* FROM sexe ORDER BY sexe", Cnn)
        Dim Adap As New MySqlDataAdapter
        Adap.SelectCommand = Cmd
        Dim tblCli As New DataTable
        Adap.Fill(tblCli)
        cmb_sexe.DataSource = tblCli
        cmb_sexe.DisplayMember = tblCli.Columns(1).ColumnName

        cmb_sexe.SelectedIndex = -1
        Return True
    End Function
    Private Function RemplirCombopersonnel() As Boolean
        Dim Cmd As MySqlCommand = New MySqlCommand("SELECT* FROM typepersonnel ORDER BY libellepersonnel", Cnn)
        Dim Adap As New MySqlDataAdapter
        Adap.SelectCommand = Cmd
        Dim tblCli As New DataTable
        Adap.Fill(tblCli)
        cmb_idtypepersonnel.DataSource = tblCli
        cmb_idtypepersonnel.DisplayMember = tblCli.Columns(1).ColumnName

        cmb_idtypepersonnel.SelectedIndex = -1
        Return True
    End Function

    Private Sub cmb_libelletypepersonne_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_libelletypepersonne.SelectedIndexChanged
        If Cmb_libelletypepersonne.SelectedIndex = -1 Then
            idtypepersonne_FK.Text = ""
        Else
            idtypepersonne_FK.Text = functionClasse.RecupCodeCombo(Cmb_libelletypepersonne, "idtypepersonne_PK")
            If idtypepersonne_FK.Text = 1 Then
                idtypepersonnel_FK.Text = "0"
            End If
            If idtypepersonne_FK.Text = 2 Then
                Label1.Visible = True
                cmb_idtypepersonnel.Visible = True
            End If
        End If
    End Sub

    'Private Sub txtmarquearticel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmarquearticle.TextChanged
    '    txtmarquearticle.AutoCompleteCustomSource.Add(txtmarquearticle.Text).ToString()
    '    functionClasse.AutoCompleteTextBox(txtmarquearticle)
    'End Sub
    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        If EstEnregistrable() AndAlso MessageBox.Show("Voulez-vous vraiment enregistrer ces données?", "VALIDATION ENREGISTREMENT", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Try
                EnregistrerGroupBox(Me.GroupBox1)
                Initialisation_CtrlText_groupBox(Me.GroupBox1)
                Cmb_libelletypepersonne.SelectedIndex = -1
                cmb_sexe.SelectedIndex = -1
                remplir_table("")
                nompersonne.Focus()
                'Projetload.remplir_Grill_table("PERSONNE", Me.Grdpersonne)
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        End If
    End Sub

    Private Sub EditToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripButton.Click
        If idpersonne_PK.Text <> String.Empty Then
           
            If MsgBox("VOULEZ - VOUS APPORTER LES MODIFICATIONS SUIVANTES A LA PERSONNE " & Grdpersonne.CurrentRow.Cells(2).Value & "  ?", MsgBoxStyle.OkCancel, "MODIFICATION") = MsgBoxResult.Ok Then

                Try
                    Dim requete As String = "UPDATE personne SET  nompersonne = '" & Me.nompersonne.Text.Replace("'", "\'") & "', prenompersonne = '" & Me.prenompersonne.Text.Replace("'", "\'") & "', idsexe_FK = '" & Me.idsexe_FK.Text.Replace("'", "\'") & "', tel = '" & Me.tel.Text.Replace("'", "\'") & "',email = '" & Me.email.Text.Replace("'", "\'") & "', dateembauche= '" & Me.dateembauche.Text.Replace("'", "\'") & "', idtypepersonne_FK = '" & Me.idtypepersonne_FK.Text.Replace("'", "\'") & "', idtypepersonnel_FK = '" & Me.idtypepersonnel_FK.Text.Replace("'", "\'") & "' WHERE idpersonne_PK ='" & Grdpersonne.CurrentRow.Cells(0).Value & "'"
                    Dim command As MySqlCommand = New MySqlCommand(requete, Cnn)
                    command.ExecuteNonQuery()

                    MsgBox("MODIFICATION EFFECTUEE AVEC  SUCCES !", MsgBoxStyle.Information, "INFORMATION")

                    Label1.Visible = False
                    cmb_idtypepersonnel.Visible = False

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
            'ModifierGroupBox(Me.GroupBox1)
            Initialisation_CtrlText_groupBox(Me.GroupBox1)
            remplir_table("")
            'Projetload.remplir_Grill_table("PERSONNE", Me.Grdpersonne)
            Me.TabControl1.SelectedTab = Me.TabPage1
            Cmb_libelletypepersonne.SelectedIndex = -1
            cmb_sexe.SelectedIndex = -1
            cmb_idtypepersonnel.SelectedIndex = -1
        Else
            MsgBox("Double_clique sur l'élement à modifier")
        End If

    End Sub
    Private Sub Grdpersonne_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grdpersonne.CellClick
        If Grdpersonne.RowCount = 0 Then
            Beep()
            MsgBox("Pas de donnée dans la base")
            Exit Sub
        Else
            idpersonne_PK.Text = Grdpersonne.CurrentRow.Cells(0).Value.ToString()
            nompersonne.Text = Grdpersonne.CurrentRow.Cells(1).Value.ToString()
            prenompersonne.Text = Grdpersonne.CurrentRow.Cells(2).Value.ToString()
            idsexe_FK.Text = Grdpersonne.CurrentRow.Cells(3).Value.ToString()
            tel.Text = Grdpersonne.CurrentRow.Cells(4).Value.ToString()
            email.Text = Grdpersonne.CurrentRow.Cells("email").Value
            dateembauche.Value = Grdpersonne.CurrentRow.Cells("dateembauche").Value
            idtypepersonne_FK.Text = Grdpersonne.CurrentRow.Cells("idtypepersonne_FK").Value
            'idtypepersonnel_FK.Text = Grdpersonne.CurrentRow.Cells(8).Value.ToString()
            'cmb_idtypepersonnel.Text = Grdpersonne.CurrentRow.Cells("libellepersonnel").Value
            Cmb_libelletypepersonne.Text = Grdpersonne.CurrentRow.Cells("libelletypepersonne").Value
            cmb_sexe.Text = Grdpersonne.CurrentRow.Cells("sexe").Value
            idtypepersonnel_FK.Text = Grdpersonne.CurrentRow.Cells("idtypepersonne_FK").Value
        End If
    End Sub
    Private Sub Grdpersonne_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grdpersonne.CellDoubleClick
        idpersonne_PK.Text = Grdpersonne.CurrentRow.Cells(0).Value.ToString()
        nompersonne.Text = Grdpersonne.CurrentRow.Cells(1).Value.ToString()
        prenompersonne.Text = Grdpersonne.CurrentRow.Cells(2).Value.ToString()
        idsexe_FK.Text = Grdpersonne.CurrentRow.Cells(3).Value.ToString()
        tel.Text = Grdpersonne.CurrentRow.Cells(4).Value.ToString()
        email.Text = Grdpersonne.CurrentRow.Cells("email").Value
        dateembauche.Value = Grdpersonne.CurrentRow.Cells("dateembauche").Value
        idtypepersonne_FK.Text = Grdpersonne.CurrentRow.Cells("idtypepersonne_FK").Value
        'idtypepersonnel_FK.Text = Grdpersonne.CurrentRow.Cells(8).Value.ToString()
        'cmb_idtypepersonnel.Text = Grdpersonne.CurrentRow.Cells("libellepersonnel").Value
        Cmb_libelletypepersonne.Text = Grdpersonne.CurrentRow.Cells("libelletypepersonne").Value
        cmb_sexe.Text = Grdpersonne.CurrentRow.Cells("sexe").Value
        idtypepersonnel_FK.Text = Grdpersonne.CurrentRow.Cells("idtypepersonne_FK").Value
        If idtypepersonne_FK.Text = 2 Then
            Label1.Visible = True
            cmb_idtypepersonnel.Visible = True
        End If
        Me.TabControl1.SelectedTab = Me.TabPage2
        'Me.nompersonne.Focus()
    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        ActiveButtons("Saisie")
        Me.TabControl1.SelectedTab = Me.TabPage2
        Initialisation_CtrlText_groupBox(Me.GroupBox1)
        Cmb_libelletypepersonne.SelectedIndex = -1
        cmb_sexe.SelectedIndex = -1
        'Me.Cmb_libelletypepersonne.Focus()
        Me.nompersonne.Focus()
        'Me.prenompersonne.Focus()
        ''Me.raisonsocial.Focus()
        'Me.tel.Focus()
        ''Me.ifu.Focus()
        'Me.email.Focus()
        'Me.dateembauche.Focus()

        '   Me.cmb_sexe.Focus()
    End Sub

    Private Sub DelToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelToolStripButton.Click
        'MAJ.pro_supprimer(Me.)
        If idpersonne_PK.Text <> String.Empty Then

            If MsgBox("VOULEZ - VOUS SUPPRIMER LA PERSONNE " & Grdpersonne.CurrentRow.Cells(1).Value & "  ?", MsgBoxStyle.OkCancel, "SUPPRESSION") = MsgBoxResult.Ok Then

                Try

                    Dim requete As String = "DELETE FROM personne WHERE idpersonne_PK ='" & Grdpersonne.CurrentRow.Cells(0).Value & "'"
                    Dim command As MySqlCommand = New MySqlCommand(requete, Cnn)
                    command.ExecuteNonQuery()
                    'Projetload.remplir_Grill_table("PERSONNE", Me.Grdpersonne)
                    remplir_table("")
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
        Cmb_libelletypepersonne.SelectedIndex = -1
        cmb_sexe.SelectedIndex = -1
        cmb_idtypepersonnel.SelectedIndex = -1
        Label1.Visible = False
        cmb_idtypepersonnel.Visible = False
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

    Private Sub nompersonne_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nompersonne.TextChanged
        'e.KeyChar = String.Empty
        nompersonne.AutoCompleteCustomSource.Add(nompersonne.Text).ToString()
        functionClasse.AutoCompleteTextBox(nompersonne)
    End Sub
    Private Function EstEnregistrable() As Boolean

        If (Me.Cmb_libelletypepersonne.SelectedIndex = -1) Then
            MsgBox("VEUILLEZ  SELECTIONNER D'ABORD LE TYPE PERSONNE  SVP !, REPRENEZ ", MsgBoxStyle.Critical, "ERREUR!!!")
            Return False
        End If

        If (dateembauche.Value > Date.Now) Then
            MsgBox("LA DATE D'EMBAUCHE NE DOIT ETRE SUPERIEURE A LA DATE DU JOUR, REPRENEZ ", MsgBoxStyle.Critical, "ERREUR!!!")
            Return False
        End If

        If idtypepersonne_FK.Text = 2 Then
            If (Me.cmb_idtypepersonnel.SelectedIndex = -1) Then
                MsgBox("VEUILLEZ  SELECTIONNER D'ABORD LE TYPE PERSONNEL  SVP, REPRENEZ ", MsgBoxStyle.Critical, "ERREUR!!!")
                Return False
            End If
        End If

        'If Verification_CtrlText(Me.GroupBox1) = False Then
        '    Return False
        'End If
        Return True
    End Function

    Private Sub cmb_sexe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_sexe.SelectedIndexChanged
        If cmb_sexe.SelectedIndex = -1 Then
            idsexe_FK.Text = ""
        Else
            idsexe_FK.Text = functionClasse.RecupCodeCombo(cmb_sexe, "idsexe_PK")
            
        End If
    End Sub

    Private Sub tel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tel.KeyPress
        Projetload.SaisirChiffre(e)
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_idtypepersonnel.SelectedIndexChanged
        If cmb_idtypepersonnel.SelectedIndex = -1 Then
            idtypepersonnel_FK.Text = ""
        Else
            idtypepersonnel_FK.Text = functionClasse.RecupCodeCombo(cmb_idtypepersonnel, "idtypepersonnel_PK")
        End If
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
            Grdpersonne.DataSource = tblCla
            Grdpersonne.Columns("nompersonne").HeaderText = "Nom "
            Grdpersonne.Columns("prenompersonne").HeaderText = "Prénom"
            Grdpersonne.Columns("libellepersonnel").HeaderText = "Type personnel"
            Grdpersonne.Columns("libelletypepersonne").HeaderText = "Type de personne"
            Grdpersonne.Columns("sexe").HeaderText = "Sexe"
            Grdpersonne.Columns("tel").HeaderText = "Telephone"
            Grdpersonne.Columns("email").HeaderText = "Email"
            Grdpersonne.Columns("dateembauche").HeaderText = "Date d'enregistrement"
            'Grdpersonne.Columns("sexe").HeaderText = "Sexe"



            Grdpersonne.Columns(0).Width = 300
            Grdpersonne.Columns(1).Width = 300
            Grdpersonne.Columns(2).Width = 300
            Grdpersonne.Columns(3).Width = 300
            Grdpersonne.Columns(4).Width = 300
            Grdpersonne.Columns(5).Width = 300
            Grdpersonne.Columns(6).Width = 300
            Grdpersonne.Columns(7).Width = 300
            Grdpersonne.Columns(8).Width = 300
            Grdpersonne.Columns(9).Width = 300
            Grdpersonne.Columns(10).Width = 300
            Grdpersonne.Columns(11).Width = 300

            MAJ.CacheColonnes(Grdpersonne, True, "0", "3", "7", "8")
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub txt_val_load_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_val_load.TextChanged
        remplir_table(txt_val_load.Text)
    End Sub

    Private Sub prenompersonne_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prenompersonne.TextChanged
        prenompersonne.AutoCompleteCustomSource.Add(prenompersonne.Text).ToString()
        functionClasse.AutoCompleteTextBox(prenompersonne)
    End Sub
End Class