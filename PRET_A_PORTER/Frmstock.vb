Public Class Frmstock

    Private Sub Frmstock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn = New MySqlConnection(DATAMANAGER.IDSERVEURS)
        Cnn.Open()
        RemplirComboarticle()
        remplir_table("")
        ActiveButtons("liste")

    End Sub
    Private Function RemplirComboarticle() As Boolean
        Dim Cmd As MySqlCommand = New MySqlCommand("SELECT idarticle_PK,numarticle,lebellearticle FROM article ORDER BY lebellearticle", Cnn)
        Dim Adap As New MySqlDataAdapter
        Adap.SelectCommand = Cmd
        Dim tblCli As New DataTable
        Adap.Fill(tblCli)
        cmb_libelleart.DataSource = tblCli
        cmb_libelleart.DisplayMember = tblCli.Columns(2).ColumnName

        cmb_libelleart.SelectedIndex = -1
        Return True
    End Function

    Sub remplir_table(ByVal j As String)
        Try

            Dim req As String = ""

            req = " select idstock_PK,numarticle,lebellearticle,quantiteajoute,quantiteinitialstock,idarticle_FK,datestock from stock left join article on stock.idarticle_FK=article.idarticle_PK ORDER BY numarticle ,lebellearticle ASC"

            Dim Cmd As MySqlCommand = New MySqlCommand(req, Cnn)
            Dim Adap As New MySqlDataAdapter
            Adap.SelectCommand = Cmd
            Dim tblCla As New DataTable
            Adap.Fill(tblCla)
            Grdstock.DataSource = tblCla
            Grdstock.Columns("quantiteajoute").HeaderText = "Quantitée ajouter "
            Grdstock.Columns("numarticle").HeaderText = "Numero article"
            Grdstock.Columns("lebellearticle").HeaderText = "Libellé article"
            Grdstock.Columns("quantiteinitialstock").HeaderText = "Quantitée initiale en stock "
            Grdstock.Columns("datestock").HeaderText = "Date stock "
            MAJ.CacheColonnes(Grdstock, True, "0", "5")

            Grdstock.Columns(0).Width = 300
            Grdstock.Columns(1).Width = 300
            Grdstock.Columns(2).Width = 300
            Grdstock.Columns(3).Width = 300
            Grdstock.Columns(4).Width = 300
            Grdstock.Columns(5).Width = 300
            Grdstock.Columns(6).Width = 300

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub cmb_libelleart_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_libelleart.SelectedIndexChanged
        If cmb_libelleart.SelectedIndex = -1 Then
            idarticle_FK.Text = ""
        Else
            idarticle_FK.Text = functionClasse.RecupCodeCombo(cmb_libelleart, "idarticle_PK")
            'verication de l'existance de l'article en stock----------------------------------------------------------

            Dim d As Boolean = False
            For G = 0 To Grdstock.Rows.Count - 1
                If idarticle_FK.Text = Grdstock.Rows(G).Cells("idarticle_FK").Value Then
                    d = True
                    Txtquantiteinitialstock.Text = CInt(IIf(IsDBNull(Grdstock.Rows(G).Cells("quantiteinitialstock").Value), 0, Grdstock.Rows(G).Cells("quantiteinitialstock").Value))
                End If
            Next
            If d = True Then
                Txtquantiteinitialstock.Text = Txtquantiteinitialstock.Text
            Else
                Txtquantiteinitialstock.Text = "0"
            End If
            Txtquantiteajoute.Focus()
        End If


    End Sub
    Private Sub Txtquantiteajoute_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtquantiteajoute.KeyPress
        Projetload.SaisirChiffre(e)
    End Sub

    Private Sub Txtquantiteajoute_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtquantiteajoute.TextChanged
        
        'Txtqtetotal.Text = CDbl(Txtquantiteinitialstock.Text + Txtquantiteajoute.Text)
    End Sub

    Private Function EstEnregistrable() As Boolean

        If (Me.idarticle_FK.Text = "") Then
            MsgBox("VEUILLEZ  SELECTIONNER L'ARTICLE  SVP !, REPRENEZ ", MsgBoxStyle.Critical, "ERREUR!!!")
            Return False
        End If

        If (Me.Txtquantiteajoute.Text = "") Then
            MsgBox("VEUILLEZ  SAISIR LA QUANTITE AJOUTER  SVP !, REPRENEZ ", MsgBoxStyle.Critical, "ERREUR!!!")
            Txtquantiteajoute.Focus()
            Return False
        End If

        If (datestock.Value > Date.Now) Then
            MsgBox("LA DATE DATE ENREGISTREMENT NE DOIT ETRE SUPERIEURE A LA DATE DU JOUR, REPRENEZ ", MsgBoxStyle.Critical, "ERREUR!!!")
            Return False
        End If

        Return True
    End Function
    Private Sub UndoToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub CloseStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Grdstock_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grdstock.CellClick
        idstock_PK.Text = Grdstock.CurrentRow.Cells(0).Value.ToString()
        idarticle_FK.Text = Grdstock.CurrentRow.Cells(5).Value.ToString()
        cmb_libelleart.Text = Grdstock.CurrentRow.Cells(2).Value.ToString()
        Txtquantiteajoute.Text = Grdstock.CurrentRow.Cells(3).Value.ToString()
        Txtquantiteinitialstock.Text = Grdstock.CurrentRow.Cells(4).Value.ToString()
        datestock.Value = Grdstock.CurrentRow.Cells(6).Value
    End Sub

    Private Sub Grdstock_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grdstock.CellDoubleClick
        idstock_PK.Text = Grdstock.CurrentRow.Cells(0).Value.ToString()
        idarticle_FK.Text = Grdstock.CurrentRow.Cells(5).Value.ToString()
        cmb_libelleart.Text = Grdstock.CurrentRow.Cells(2).Value.ToString()
        Txtquantiteajoute.Text = Grdstock.CurrentRow.Cells(3).Value.ToString()
        Txtquantiteinitialstock.Text = Grdstock.CurrentRow.Cells(4).Value.ToString()
        datestock.Value = Grdstock.CurrentRow.Cells(6).Value

        Me.TabControl1.SelectedTab = Me.TabPage2
    End Sub

    Private Sub EditToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripButton.Click
        If idstock_PK.Text <> String.Empty Then
            cmb_libelleart.Enabled = False
            If MsgBox("VOULEZ - VOUS APPORTER LES MODIFICATIONS SUIVANTES A LA PERSONNE " & Grdstock.CurrentRow.Cells(2).Value & "  ?", MsgBoxStyle.OkCancel, "MODIFICATION") = MsgBoxResult.Ok Then

                Try
                    Dim requete As String = "UPDATE stock SET  quantiteajoute = '" & Me.Txtquantiteajoute.Text.Replace("'", "\'") & "', quantiteinitialstock = quantiteinitialstock + '" & IIf(Me.Txtquantiteajoute.Text.Trim() = "", 0, Me.Txtquantiteajoute.Text.Trim()) & "', datestock = '" & Me.datestock.Value & "' WHERE idarticle_FK ='" & idarticle_FK.Text & "'"
                    Dim command As MySqlCommand = New MySqlCommand(requete, Cnn)
                    command.ExecuteNonQuery()

                    MsgBox("MODIFICATION EFFECTUEE AVEC  SUCCES !", MsgBoxStyle.Information, "INFORMATION")


                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
            Initialisation_CtrlText_groupBox(Me.GroupBox1)
            cmb_libelleart.SelectedIndex = -1
            remplir_table("")
            Txtquantiteinitialstock.Text = ""
            ActiveButtons("Liste")
        Else
            MsgBox("Double_clique sur l'élement à modifier")
        End If
        cmb_libelleart.Enabled = True
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Dim Qtetotal As Integer
        Dim Qtetotal2 As Integer
        Dim Qtetotal3 As Integer
        Qtetotal = Qtetotal + Me.Txtquantiteajoute.Text
        Qtetotal2 = Qtetotal2 + Me.Txtquantiteinitialstock.Text
        Qtetotal3 = Qtetotal + Qtetotal2
        Me.Txtqtetotal.Text = Qtetotal3

        Dim j As Integer = Grdstock.RowCount - 1
        Dim re As Boolean = False
        While (j >= 0 And re = False)
            If (Me.idarticle_FK.Text = Grdstock.Rows(j).Cells("idarticle_FK").Value And Me.datestock.Value = Grdstock.Rows(j).Cells("datestock").Value) Then
                re = True
            End If
            j = j - 1
        End While

        If (re = False) Then
            If EstEnregistrable() AndAlso MessageBox.Show("Voulez-vous vraiment enregistrer ces données?", "VALIDATION ENREGISTREMENT", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                Try
                    Dim d As Boolean = False
                    For G = 0 To Grdstock.Rows.Count - 1
                        If idarticle_FK.Text = Grdstock.Rows(G).Cells("idarticle_FK").Value Then
                            d = True
                        End If
                    Next
                    If d = True Then
                        Dim requete As String = "UPDATE stock SET  quantiteajoute = '" & Me.Txtquantiteajoute.Text.Replace("'", "\'") & "', quantiteinitialstock = quantiteinitialstock + '" & IIf(Me.Txtquantiteajoute.Text.Trim() = "", 0, Me.Txtquantiteajoute.Text.Trim()) & "', datestock = '" & Me.datestock.Text & "' WHERE idarticle_FK ='" & idarticle_FK.Text & "'"
                        Dim command As MySqlCommand = New MySqlCommand(requete, Cnn)
                        command.ExecuteNonQuery()
                        MsgBox("ENREGISTREMENT EFFECTUEE AVEC  SUCCES !", MsgBoxStyle.Information, "INFORMATION")
                    Else
                        EnregistrerGroupBox(Me.GroupBox1)

                    End If
                    Initialisation_CtrlText_groupBox(Me.GroupBox1)
                    cmb_libelleart.SelectedIndex = -1
                    remplir_table("")
                    'Txtquantiteinitialstock.Text = ""
                Catch ex As Exception

                    MessageBox.Show(ex.Message)

                End Try
            End If
        Else
            MessageBox.Show(String.Format("CET ARTICLE A ETE DEJA ENREGISTRE A CETTE DATE "))
        End If
    End Sub

    Private Sub DelToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelToolStripButton.Click
        If idstock_PK.Text <> String.Empty Then

            If MsgBox("VOULEZ - VOUS SUPPRIMER LA PERSONNE " & Grdstock.CurrentRow.Cells(2).Value & "  ?", MsgBoxStyle.OkCancel, "SUPPRESSION") = MsgBoxResult.Ok Then

                Try

                    Dim requete As String = "DELETE FROM personne WHERE idstock_PK ='" & Grdstock.CurrentRow.Cells(0).Value & "'"
                    Dim command As MySqlCommand = New MySqlCommand(requete, Cnn)
                    command.ExecuteNonQuery()
                    MsgBox("SUPPRESSION EFFECTUEE AVEC  SUCCES !", MsgBoxStyle.Information, "INFORMATION")
                    Me.TabControl1.SelectedTab = Me.TabPage1
                    Initialisation_CtrlText_groupBox(Me.GroupBox1)
                    cmb_libelleart.SelectedIndex = -1
                    remplir_table("")
                    Txtquantiteinitialstock.Text = ""
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
        Else
            MsgBox("VEUILLEZ  SELECTIONNER L'ELEMENT A SUPPRIMER  SVP !", MsgBoxStyle.Critical, "ERREUR")


        End If
    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        ActiveButtons("Saisie")
        Me.TabControl1.SelectedTab = Me.TabPage2
        Initialisation_CtrlText_groupBox(Me.GroupBox1)
        cmb_libelleart.SelectedIndex = -1
    End Sub

    Private Sub UndoToolStripButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripButton.Click
        ActiveButtons("Liste")
        Initialisation_CtrlText_groupBox(Me.GroupBox1)
        cmb_libelleart.SelectedIndex = -1
        Me.TabControl1.SelectedTab = Me.TabPage1

    End Sub

    Private Sub CloseStripButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseStripButton.Click
        Me.Close()
    End Sub

    Private Sub Txtquantiteinitialstock_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Txtquantiteinitialstock_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtquantiteinitialstock.TextChanged

    End Sub
End Class