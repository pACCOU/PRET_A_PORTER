Public Class Frmfacture
    Dim cumul As Double
    Dim I As Integer
    Dim totalbenefice As Double
    Dim cumulbenefice As Double


    Private Sub Frmfacture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn = New MySqlConnection(DATAMANAGER.IDSERVEURS)
        Cnn.Open()
        RemplirComboarticle()
        Remplirtaux()
        remplir_table("")
        dateenregistrement.Value = Date.Today
        GroupBox1.Enabled = False
        'Me.idprofil.Text = 2
        ActiveButtons("Liste")
        If Me.idprofil.Text = 2 Then
            Me.DelToolStripButton.Enabled = True
        End If
        'Initialisation_CtrlText_groupBox(Me.GroupBox1)
        nompersonne.Text = String.Empty
        Me.beneficearticle.Text = "0"
        Txtprixunit.Text = "0"
        Txtqtedispo.Text = "0"
        Txtquantitevendue.Text = "0"
        idarticle_FK.Text = String.Empty
        Txtlibarticle.Text = String.Empty
        CmbTauxReduct.SelectedIndex = -1
        txtnumfact.Text = incrementation()

    End Sub
    Private Sub BtnRechCam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRechCam.Click
        FrmRechercher.ShowDialog()
    End Sub
    Private Function RemplirComboarticle() As Boolean
        Dim Cmd As MySqlCommand = New MySqlCommand("SELECT idarticle_PK,numarticle,lebellearticle,prixvente,beneficearticle FROM article ORDER BY lebellearticle", Cnn)
        Dim Adap As New MySqlDataAdapter
        Adap.SelectCommand = Cmd
        Dim tblCli As New DataTable
        Adap.Fill(tblCli)
        cmb_libelleart.DataSource = tblCli
        cmb_libelleart.DisplayMember = tblCli.Columns(2).ColumnName

        cmb_libelleart.SelectedIndex = -1
        Return True
    End Function
    Private Function Remplirtaux() As Boolean
        Dim Cmd As MySqlCommand = New MySqlCommand("SELECT idtauxreduction_PK,taux FROM tauxreduction ORDER BY taux ASC", Cnn)
        Dim Adap As New MySqlDataAdapter
        Adap.SelectCommand = Cmd
        Dim tblCli As New DataTable
        Adap.Fill(tblCli)
        CmbTauxReduct.DataSource = tblCli
        CmbTauxReduct.DisplayMember = tblCli.Columns(1).ColumnName

        CmbTauxReduct.SelectedIndex = -1
        Return True
    End Function
    Private Sub cmb_libelleart_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_libelleart.SelectedIndexChanged
        If cmb_libelleart.SelectedIndex = -1 Then
            idarticle_FK.Text = ""
        Else
            idarticle_FK.Text = functionClasse.RecupCodeCombo(cmb_libelleart, "idarticle_PK")
            Txtprixunit.Text = functionClasse.RecupCodeCombo(cmb_libelleart, "prixvente")
            beneficearticle.Text = functionClasse.RecupCodeCombo(cmb_libelleart, "beneficearticle")
            Txtlibarticle.Text = functionClasse.RecupCodeCombo(cmb_libelleart, "lebellearticle")

            'quantité en stock----------------------------------------------------------
            Dim Cmd As MySqlCommand = New MySqlCommand("SELECT quantiteinitialstock FROM stock inner join article on stock.idarticle_FK= '" & idarticle_FK.Text & "' ", Cnn)
            Dim Adap As New MySqlDataAdapter
            Adap.SelectCommand = Cmd
            Dim mondataset As New DataSet
            Adap.Fill(mondataset, "stock")
            Dim a As Integer
            Dim ligne As DataRow
            For Each ligne In mondataset.Tables("stock").Rows()
                a = ligne("quantiteinitialstock")
            Next
            Txtqtedispo.Text = a
            FormatMontant(Txtqtedispo)
            Txtquantitevendue.Focus()
        End If


    End Sub

    Private Sub BtnInserer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInserer.Click
        Dim j As Integer = grdvalid.RowCount - 1
        Dim re As Boolean = False
        While (j >= 0 And re = False)
            If (Me.idarticle_FK.Text = grdvalid.Rows(j).Cells("idarticle").Value And Me.dateenregistrement.Value = grdvalid.Rows(j).Cells("datefact").Value) Then
                re = True
            End If
            j = j - 1
        End While

        If (re = False) Then
            If EstEnregistrable() AndAlso MessageBox.Show("Voulez-vous valider cette ligne?", "VALIDATION", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                Dim I As Integer

                I = grdvalid.Rows.Count

                'CptLigne = CptLigne + 1

                grdvalid.Rows.Add()

                'grdvalid.Rows(I).Cells("idfacture_PK").Value = Me.Txtidfacture.Text
                'grdvalid.Rows(I).Cells("idpersonne").Value = Me.idpersonne_FK.Text
                grdvalid.Rows(I).Cells("nompersonne_FK").Value = Me.nompersonne.Text
                grdvalid.Rows(I).Cells("idarticle").Value = Me.idarticle_FK.Text
                grdvalid.Rows(I).Cells("monttotal").Value = Me.Txt_montantfacture.Text
                grdvalid.Rows(I).Cells("datefact").Value = Me.dateenregistrement.Value
                grdvalid.Rows(I).Cells("prixunit").Value = Me.Txtprixunit.Text
                grdvalid.Rows(I).Cells("quantitevendue").Value = Me.Txtquantitevendue.Text
                grdvalid.Rows(I).Cells("article").Value = Me.Txtlibarticle.Text
                grdvalid.Rows(I).Cells("qtestock").Value = Me.Txtqtedispo.Text
                grdvalid.Rows(I).Cells("beneficeart").Value = Me.beneficearticlevendu.Text
                cumul = "0"
                totalbenefice = "0"
                cumulbenefice = "0"
                For G = 0 To grdvalid.Rows.Count - 1
                    TxtTotal.Text = CDbl(cumul + CDbl(grdvalid.Rows(G).Cells("monttotal").Value))
                    totalbenefice = CDbl(cumulbenefice + CDbl(grdvalid.Rows(G).Cells("beneficeart").Value))
                    cumul = TxtTotal.Text
                    cumulbenefice = totalbenefice
                Next
                'TxtTotal.Text = CDbl(cumul + CDbl(grdvalid.Rows(I).Cells("monttotal").Value))
                'cumul = TxtTotal.Text
                TxtCalculReduct.Text = "0"
                FormatMontant(TxtTotal)
                Txttotalpayer.Text = (CInt(Me.TxtTotal.Text) - CInt(Me.TxtCalculReduct.Text))
                If Me.Txttotalpayer.Text <> "" Then FormatMontant(Txttotalpayer)

                'Nettoyage--------------------------

                cmb_libelleart.SelectedIndex = -1
                Txtprixunit.Text = "0"
                'beneficearticle.Text = "0"
                Txtqtedispo.Text = "0"
                Txtquantitevendue.Text = "0"
                idarticle_FK.Text = String.Empty
                Txtlibarticle.Text = String.Empty
                'txtMontAPayer_NoEnabled.Text = String.Empty
                '--------------------------------------------------
            End If
        Else
            MsgBox("CET ARTICLE  EST DEJA VALIDE A CETTE DATE!!! CHANGER D'ARTICLE SVP", MsgBoxStyle.Critical, "ERREUR")
        End If
        BtnRetirer.Enabled = True
    End Sub

    Private Sub Txtquantitevendue_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtquantitevendue.KeyPress
        Projetload.SaisirChiffre(e)
    End Sub

    Private Sub Txtquantitevendue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtquantitevendue.TextChanged
        If CInt(Txtqtedispo.Text.Trim()) < IIf(Me.Txtquantitevendue.Text.Trim() = "", 0, Txtquantitevendue.Text.Trim()) Then
            MsgBox("LA QUANTITE SAISIE  EST SUPERIEURE A LA QUANTITE DISPONIBLE !!! REPENEZ SVP", MsgBoxStyle.Critical, "ERREUR")
            Txtquantitevendue.Text = ""
            Txtquantitevendue.Focus()
        Else
            Txt_montantfacture.Text = CDbl(Txtprixunit.Text.Trim() * IIf(Me.Txtquantitevendue.Text.Trim() = "", 0, Txtquantitevendue.Text.Trim()))
            Txt_montantfacture.Text = CDbl(Txt_montantfacture.Text.Trim())
            beneficearticlevendu.Text = CDbl(beneficearticle.Text.Trim() * IIf(Me.Txtquantitevendue.Text.Trim() = "", 0, Txtquantitevendue.Text.Trim()))
            FormatMontant(Txt_montantfacture)

        End If
        
    End Sub

    Private Sub BtnRetirer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRetirer.Click
        BtnModifier.Enabled = False
        cumul = "0"
        cumulbenefice = "0"
        totalbenefice = "0"
        grdvalid.Rows.Remove(grdvalid.CurrentRow)
        For G = 0 To grdvalid.Rows.Count - 1
            TxtTotal.Text = CDbl(cumul + CDbl(grdvalid.Rows(G).Cells("monttotal").Value))
            totalbenefice = CDbl(cumulbenefice + CDbl(grdvalid.Rows(G).Cells("beneficeart").Value))
            cumul = TxtTotal.Text
            cumulbenefice = totalbenefice
        Next
        TxtCalculReduct.Text = "0"
        FormatMontant(TxtTotal)
        Txttotalpayer.Text = (CInt(Me.TxtTotal.Text) - CInt(Me.TxtCalculReduct.Text))
        If Me.Txttotalpayer.Text <> "" Then FormatMontant(Txttotalpayer)
        'nompersonne.Text = String.Empty
        TxtCalculReduct.Text = "0"
        TxtTotal.Text = "0"
        txttaux.Text = "0"

        cumulbenefice = "0"
        totalbenefice = "0"
        'Txttotalpayer.Text = "0"
        beneficearticle.Text = "0"
        Txtprixunit.Text = "0"
        CmbTauxReduct.SelectedIndex = -1
        txtidtaux.Text = "0"
        cumul = "0"
    End Sub

    Private Sub grdvalid_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdvalid.CellDoubleClick
        Me.Txtqtedispo.Text = grdvalid.CurrentRow.Cells("qtestock").Value
        Me.Txtidfacture_PK.Text = grdvalid.CurrentRow.Cells("idfacture_PK").Value
        'Me.idpersonne_FK.Text = grdvalid.CurrentRow.Cells("idpersonne").Value
        Me.idpersonne_FK.Text = grdvalid.CurrentRow.Cells("nompersonne_FK").Value
        Me.idarticle_FK.Text = grdvalid.CurrentRow.Cells("idarticle").Value
        Me.Txt_montantfacture.Text = grdvalid.CurrentRow.Cells("monttotal").Value
        Me.dateenregistrement.Value = grdvalid.CurrentRow.Cells("datefact").Value
        Me.Txtprixunit.Text = grdvalid.CurrentRow.Cells("prixunit").Value
        Me.Txtquantitevendue.Text = grdvalid.CurrentRow.Cells("quantitevendue").Value
        Me.Txtlibarticle.Text = grdvalid.CurrentRow.Cells("article").Value
        Me.beneficearticlevendu.Text = grdvalid.CurrentRow.Cells("beneficeart").Value

        cmb_libelleart.Enabled = False
        nompersonne.Enabled = False
        BtnRetirer.Enabled = False
        BtnInserer.Enabled = False
        BtnModifier.Enabled = True
        Txtquantitevendue.Focus()

    End Sub

    Private Sub BtnModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModifier.Click
        cumul = "0"
        cumulbenefice = "0"
        totalbenefice = "0"
        If idarticle_FK.Text = grdvalid.CurrentRow.Cells("idarticle").Value Then

            grdvalid.Rows.Remove(grdvalid.CurrentRow)
            I = grdvalid.Rows.Count
            'Me.Txt_montantfacture.Text = grdvalid.CurrentRow.
            grdvalid.Rows.Add()

            grdvalid.Rows(I).Cells("idfacture_PK").Value = Me.Txtidfacture_PK.Text
            grdvalid.Rows(I).Cells("nompersonne_FK").Value = Me.nompersonne.Text
            'grdvalid.Rows(I).Cells("idpersonne").Value = Me.idpersonne_FK.Text
            grdvalid.Rows(I).Cells("idarticle").Value = Me.idarticle_FK.Text
            grdvalid.Rows(I).Cells("monttotal").Value = Me.Txt_montantfacture.Text
            grdvalid.Rows(I).Cells("datefact").Value = Me.dateenregistrement.Value
            grdvalid.Rows(I).Cells("prixunit").Value = Me.Txtprixunit.Text
            grdvalid.Rows(I).Cells("quantitevendue").Value = Me.Txtquantitevendue.Text
            grdvalid.Rows(I).Cells("article").Value = Me.Txtlibarticle.Text
            grdvalid.Rows(I).Cells("beneficeart").Value = Me.beneficearticlevendu.Text


        End If

        '------------------calcul du montant$*--------------
        For G = 0 To grdvalid.Rows.Count - 1
            TxtTotal.Text = CDbl(cumul + CDbl(grdvalid.Rows(G).Cells("monttotal").Value))
            totalbenefice = CDbl(cumulbenefice + CDbl(grdvalid.Rows(G).Cells("beneficeart").Value))
            cumulbenefice = totalbenefice
            cumul = TxtTotal.Text
        Next
        TxtCalculReduct.Text = "0"
        FormatMontant(TxtTotal)
        Txttotalpayer.Text = (CInt(Me.TxtTotal.Text) - CInt(Me.TxtCalculReduct.Text))
        If Me.Txttotalpayer.Text <> "" Then FormatMontant(Txttotalpayer)
        'nompersonne.Text = String.Empty
        TxtCalculReduct.Text = "0"
        TxtTotal.Text = "0"
        txttaux.Text = "0"
        'Txttotalpayer.Text = "0"
        Txtprixunit.Text = "0"
        beneficearticle.Text = "0"
        CmbTauxReduct.SelectedIndex = -1
        txtidtaux.Text = "0"
        cumul = "0"
        BtnModifier.Enabled = False
        BtnRetirer.Enabled = True
        BtnInserer.Enabled = True
        nompersonne.Enabled = True
        cmb_libelleart.Enabled = True
    End Sub

    Private Sub CloseStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseStripButton.Click
        Me.Close()
    End Sub

    Private Sub CmbTauxReduct_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbTauxReduct.SelectedIndexChanged
        If CmbTauxReduct.SelectedIndex <> -1 Then
            txtidtaux.Text = functionClasse.RecupCodeCombo(CmbTauxReduct, "idtauxreduction_PK")
            txttaux.Text = functionClasse.RecupCodeCombo(CmbTauxReduct, "taux")
            If CmbTauxReduct.SelectedIndex = "0" Then
                TxtCalculReduct.Text = "0"
                Me.TxtCalculReduct.ReadOnly = False
                TxtCalculReduct.Focus()
            Else
                Me.TxtCalculReduct.Text = (Me.TxtTotal.Text * (CmbTauxReduct.Text / 100))
                If Me.TxtCalculReduct.Text <> "" Then FormatMontant(TxtCalculReduct)
            End If
        Else
            txtidtaux.Text = ""
        End If

    End Sub

    Private Sub TxtCalculReduct_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCalculReduct.TextChanged
        Txttotalpayer.Text = (CInt(Me.TxtTotal.Text) - CInt(Me.TxtCalculReduct.Text))
        If Me.Txttotalpayer.Text <> "" Then FormatMontant(Txttotalpayer)

    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
      
        'TxtCalculReduct.Text = CDbl(Me.TxtCalculReduct.Text)
        Txttotalpayer.Text = CDbl(Me.Txttotalpayer.Text)
        TxtTotal.Text = CDbl(Me.TxtTotal.Text)
        TxtCalculReduct.Text = "0"
        'Txtiduser.Text = 1
        Dim ene As String = fact.Text + "" + txtnumfact.Text
        'TxtCalculReduct.Text = CDbl(Me.TxtCalculReduct.Text)
        Try
            Dim i As Boolean
            For G = 0 To grdvalid.Rows.Count - 1
                Dim req As String = "UPDATE stock SET quantiteinitialstock = quantiteinitialstock - '" & grdvalid.Rows(G).Cells("quantitevendue").Value & "' WHERE idarticle_FK ='" & grdvalid.Rows(G).Cells("idarticle").Value & "'"
                Dim comd As MySqlCommand = New MySqlCommand(req, Cnn)
                comd.ExecuteNonQuery()

                Dim requete As String = "INSERT INTO facture (nompersonne,idarticle_FK,quantitevendue,montantreduction,montantfacture,iduser_FK,datefacture,numfact,montanthred,montantproduitpayer,beneficesurart,beneficetotal) VALUES ('" & grdvalid.Rows(G).Cells("nompersonne_FK").Value.Replace("'", "\'") & "','" & grdvalid.Rows(G).Cells("idarticle").Value & "','" & grdvalid.Rows(G).Cells("quantitevendue").Value & "','" & Me.TxtCalculReduct.Text & "','" & Me.Txttotalpayer.Text & "','" & Me.Txtiduser.Text & "','" & Me.dateenregistrement.Text & "','" & ene & "','" & Me.TxtTotal.Text & "','" & CDbl(grdvalid.Rows(G).Cells("monttotal").Value) & "','" & CDbl(grdvalid.Rows(G).Cells("beneficeart").Value) & "','" & CDbl(totalbenefice) & "')"
                Dim command As MySqlCommand = New MySqlCommand(requete, Cnn)
                i = command.ExecuteNonQuery()
                ','" & Me.txtidtaux.Text & "'
            Next

            If (i = True) Then

                MsgBox("ENREGISTREMENT EFFECTUEE AVEC  SUCCES !", MsgBoxStyle.Information, "INFORMATION")
                txtnumfact.Text = incrementation()
                'Initialisation_CtrlText_groupBox(GroupBox1)
                nompersonne.Text = String.Empty
                TxtCalculReduct.Text = "0"
                TxtTotal.Text = "0"
                txttaux.Text = "0"
                Txttotalpayer.Text = "0"
                Txtprixunit.Text = "0"
                CmbTauxReduct.SelectedIndex = -1
                txtidtaux.Text = "0"
                cumul = "0"
                grdvalid.Rows.Clear()
                MsgBox("IMPRESSION DE LA FACTURE !", MsgBoxStyle.Information, "IMPRESSION")
                'Dim I As Integer

                'I = grdvalid.Rows.Count
                'grdvalid.Rows(.Remove(grdvalid.CurrentRow)


                'Génération facture
                Filtre_facture.txt_numfact.Text = ene
                Edition_Facture.ShowDialog()

            Else

                MsgBox("ENREGISTREMENT ECHOUE !", MsgBoxStyle.Critical, "ERREUR")

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try


    End Sub
    Private Function EstEnregistrable() As Boolean

        If (Me.cmb_libelleart.SelectedIndex = -1) Then
            MsgBox("VEUILLEZ  SELECTIONNER L'ARTICLE  SVP !, REPRENEZ ", MsgBoxStyle.Critical, "ERREUR!!!")
            Return False
        End If

        Return True
    End Function

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        ActiveButtons("Saisie")
        GroupBox1.Enabled = True
        Me.TabControl1.SelectedTab = Me.TabPage2
        Txtprixunit.Text = String.Empty
        Txtqtedispo.Text = "0"
        Txtquantitevendue.Text = "0"
        idarticle_FK.Text = String.Empty
        Txtlibarticle.Text = String.Empty
        CmbTauxReduct.SelectedIndex = -1
        nompersonne.Text = String.Empty
        BtnRetirer.Enabled = False
        BtnModifier.Enabled = False
        'Initialisation_CtrlText_groupBox(Me.GroupBox1)
        txtnumfact.Text = incrementation()
        nompersonne.Focus()
        'incrementer(txtnumfact, "select numfact from facture order by numfact DESC limit 1;", "FACT-", 3)
        'prixunitarticle.Text = "0"
    End Sub
    Private Sub ActiveButtons(ByVal KelOnglet As String)
        Select Case KelOnglet
            Case "Liste", "List"
                Me.NewToolStripButton.Enabled = True
                Me.SaveToolStripButton.Enabled = False
                Me.DelToolStripButton.Enabled = False
            Case "Saisie"
                Me.NewToolStripButton.Enabled = False
                Me.SaveToolStripButton.Enabled = True
                Me.DelToolStripButton.Enabled = False
        End Select
    End Sub

    Private Sub txtnumfact_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnumfact.TextChanged

    End Sub

    Private Sub DelToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelToolStripButton.Click
        If txtnumfact.Text <> String.Empty Then
            Dim i As Boolean = False
            Dim datecc As Date = Now
            Dim ki As String = datecc

            Me.Datetampon.Value = Date.Today
            'Datetampon.Text = Date.Today

            If MsgBox("VOULEZ - VOUS SUPPRIMER LA FACTURE " & Grdfacture.CurrentRow.Cells(0).Value & "  ?", MsgBoxStyle.OkCancel, "SUPPRESSION") = MsgBoxResult.Ok Then
                'dateenregistrement.Value = FormatDateTime(Date.Today)
                Try
                    Dim y As Boolean
                    Dim sql As String = "INSERT INTO tabletampon (iduser_FK,numfact,date,nom) VALUES ('" & Me.Txtiduser.Text & "','" & Me.txtnumfact.Text & "','" & ki.Replace("/", "-") & "','" & Me.Txtnomprenom.Text.Replace("'", "\'") & "')"
                    Dim cmd1 As MySqlCommand = New MySqlCommand(sql, Cnn)
                    y = cmd1.ExecuteNonQuery()

                    Dim requete As String = "DELETE FROM facture WHERE numfact ='" & Grdfacture.CurrentRow.Cells(0).Value & "'"
                    Dim command As MySqlCommand = New MySqlCommand(requete, Cnn)
                    command.ExecuteNonQuery()
                    remplir_table("")
                    MsgBox("SUPPRESSION EFFECTUEE AVEC  SUCCES !", MsgBoxStyle.Information, "INFORMATION")
                    Me.TabControl1.SelectedTab = Me.TabPage1
                    'Initialisation_CtrlText_groupBox(Me.GroupBox1)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
        Else
            MsgBox("VEUILLEZ  SELECTIONNER L'ELEMENT A SUPPRIMER  SVP !", MsgBoxStyle.Critical, "ERREUR")


        End If

    End Sub
    Sub remplir_table(ByVal j As String)
        Try

            Dim req As String = ""

            req = " select numfact,nompersonne as Client,datefacture from facture group by numfact,datefacture,nompersonne ORDER BY numfact ,datefacture ASC"
            'req = " select numfact,idpersonne_FK,concat(nompersonne,'  ',prenompersonne) as Client,datefacture from facture inner join personne on facture.idpersonne_FK=personne.idpersonne_PK group by numfact,datefacture,idpersonne_FK ORDER BY numfact ,datefacture ASC"
            Dim Cmd As MySqlCommand = New MySqlCommand(req, Cnn)
            Dim Adap As New MySqlDataAdapter
            Adap.SelectCommand = Cmd
            Dim tblCla As New DataTable
            Adap.Fill(tblCla)
            Grdfacture.DataSource = tblCla
            Grdfacture.Columns("numfact").HeaderText = "N° Facture "
            Grdfacture.Columns("datefacture").HeaderText = "Date Facture"

            'MAJ.CacheColonnes(Grdfacture, True, "1")

            Grdfacture.Columns(0).Width = 300
            Grdfacture.Columns(1).Width = 300
            Grdfacture.Columns(2).Width = 300
            'Grdfacture.Columns(3).Width = 300

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Public Sub incrementer2(ByVal text1 As TextBox, ByVal req As String)
        incrementer2(txtnumfact, "select idfacture_PK from facture order by idfacture_PK DESC limit 1;")
    End Sub
    Private Function incrementation() As Integer
        Dim e As Integer

        Dim Cmd As MySqlCommand = New MySqlCommand("select idfacture_PK from facture order by idfacture_PK DESC limit 1;", Cnn)
        Dim adapter As New MySqlDataAdapter(Cmd)
        adapter.SelectCommand = Cmd
        Dim mondataset As New DataSet
        Try
            adapter.Fill(mondataset, "facture")
            Dim ligne As DataRow
            For Each ligne In mondataset.Tables("facture").Rows()
                e = ligne("idfacture_PK")

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return e
    End Function

    Private Sub Grdfacture_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grdfacture.CellClick
        txtnumfact.Text = Grdfacture.CurrentRow.Cells(0).Value.ToString()

    End Sub

    Private Sub grdvalid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdvalid.CellContentClick

    End Sub
End Class