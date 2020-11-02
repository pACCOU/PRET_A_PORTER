Imports MySql.Data.MySqlClient
Public Class FrmConnexion

    ' TODO : insérez le code pour effectuer une authentification personnalisée à l'aide du nom d'utilisateur et du mot de passe fournis 
    ' (Voir http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' L'objet Principal personnalisé peut ensuite être associé à l'objet Principal du thread actuel comme suit : 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' CustomPrincipal est l'implémentation IPrincipal utilisée pour effectuer l'authentification. 
    ' Par la suite, My.User retournera les informations d'identité encapsulées dans l'objet CustomPrincipal
    ' telles que le nom d'utilisateur, le nom complet, etc.
    Dim Num, Cpt As Integer
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Cnn = New MySqlConnection(DATAMANAGER.IDSERVEURS)
        Cnn.Open()
        If EstEnregistrable() AndAlso MessageBox.Show("CONFIRMEZ-VOUS SES DONNEES?", "CONFIRMATION", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim i As Boolean = False
            Dim mondataset As New DataSet
            Dim datecc As Date = Now
            Dim ki As String = datecc

            Try

                Dim command As MySqlCommand = New MySqlCommand("SELECT user.*,libelleprofil FROM user,profil where user.idprofil_FK=profil.idprofil_PK", Cnn)
                Dim adapter As New MySqlDataAdapter(command)
                adapter.Fill(mondataset, "user")
                Dim nomview As New DataView(mondataset.Tables("user"))

                For Each ligne As DataRow In mondataset.Tables("user").Rows()
                    If (Me.compte.Text = ligne("compte") And Me.txt_motpass.Text = ligne("motdepasse")) Then
                        i = True

                        'UsernameLabel.Text = ligne("idprofil_FK")
                        L_idprofil.Text = ligne("idprofil_FK")
                        Frmfacture.idprofil.Text = ligne("idprofil_FK")
                        FrmMenu.Label1.Text = ligne("compte") & "  est  connecté  à  " & TimeOfDay
                        FrmMenu.Lprofil.Text = ligne("libelleprofil")
                        FrmMenu.Label6.Text = ligne("nomprenom")
                        'Frmfacture.nompersonne.Text = ligne("nomprenom")
                        Frmfacture.Txtiduser.Text = envoie_id(Me.txt_motpass.Text, Me.compte.Text)

                        FrmMenu.OutilsToolStripMenuItem.Visible = True
                        If ligne("idprofil_FK") = 1 Then
                            FrmMenu.OutilsToolStripMenuItem.Enabled = False
                            FrmMenu.ListesDesStocksToolStripMenuItem.Enabled = False
                            FrmMenu.ParamètresToolStripMenuItem.Enabled = False
                        End If
                        Dim requete As String = "INSERT INTO listinning (iduser, dateconnect) VALUES ('" & envoie_id(Me.txt_motpass.Text, Me.compte.Text) & "','" & ki.Replace("/", "-") & "')"
                        Dim commande As MySqlCommand = New MySqlCommand(requete, Cnn)
                        commande.ExecuteNonQuery()
                    End If

                Next

                If (i = True) Then
                    MsgBox("AUTHENTIFICATION REUSSIE  !", MsgBoxStyle.Information, "INFORMATION")

                    FrmMenu.ShowDialog()
                    End



                Else

                    MessageBox.Show("AUTHENTIFICATION INCORRECTE!! 3 essais. " & Cpt & "° essai", "Controle d'identification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.compte.ResetText()
                    compte.Focus()
                    Me.compte.Text = ""
                    Me.txt_motpass.Text = ""
                    Cpt = Cpt + 1
                    If Cpt > 3 Then
                        MessageBox.Show("Au Revoir, Réessayer plus tard!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question)
                        End
                    End If

                End If

                'MsgBox("MOT DE PASSE OU NOM D'UTILISATEUR ERRONE  !", MsgBoxStyle.Critical, "ERREUR")
                'Me.txt_motpass.Focus()
                'End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub FrmConnexion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn = New MySqlConnection(DATAMANAGER.IDSERVEURS)
        Cnn.Open()
        Cpt = 1


        '''''''- - - - -  - - -  ----------Crack aapplication--------------
        Dim req As String = "select * from crack_application"
        Dim tabcrak As New DataGridView
        Dim crak As String = "CRAK2015STOCKVER1PRODHBD"
        Dim cin As Integer = 0
        Dim datecrak As Date = Date.Today
        Dim Cmd As MySqlCommand = New MySqlCommand(req, Cnn)
        Dim Adap As New MySqlDataAdapter
        Adap.SelectCommand = Cmd
        Dim tblCla As New DataTable
        Adap.Fill(tblCla)
        tabcrak.DataSource = tblCla
        Me.Datecreation.Value = Date.Today

        If tblCla.Rows.Count = 0 Then
            Try
                Dim requet As String = "INSERT INTO crack_application (date_activation, cle_active,definitive_crak) VALUES ('" & Me.Datecreation.Text & "','" & crak & "','" & cin & "' )"
                Dim commande As MySqlCommand = New MySqlCommand(requet, Cnn)
                commande.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            If envoie_nbcrak() = 0 Then
                Try
                    DateTimePicker2.Value = Date.Today
                    If DateDiff(DateInterval.Day, envoie_date(), DateTimePicker2.Value) >= 10 Then
                        MsgBox("VOTRE  LICENCE  OU  DELAI  D'UTILISATION  EST  EXPIRE.  VEUILLEZ  CONTACTER  LE  CONCEPTEUR  DU  LOGICIEL  Mr  Obed HOUETO  AU  66 - 61 - 64 - 63  POUR  ACTIVATION  DEFINITIVE  ... ", MsgBoxStyle.Critical, "LICENCE!!!")
                        Me.Close()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
        ''''''''''''''''''''''''''''''''FIN''''''''''''''-----------------------------''''''''*$$$*$$$$$$$$$$$$$$$$$$$
    End Sub
    Private Function EstEnregistrable() As Boolean
        If (Me.compte.Text = "") Then
            MsgBox("VEUILLEZ  SAISIR LE NOM DE VOTRE COMPTE SVP !, REPRENEZ ", MsgBoxStyle.Critical, "ERREUR!!!")
            Return False
            compte.Focus()
        End If
        If (Me.txt_motpass.Text = "") Then
            MsgBox("VEUILLEZ  SAISIR LE MOT DE PASSE SVP !, REPRENEZ ", MsgBoxStyle.Critical, "ERREUR!!!")
            Return False
            txt_motpass.Focus()
        End If
        Return True
    End Function
    Function envoie_id(ByVal mot As String, ByVal pseu As String)
        Dim idd As Integer = 0
        Try
            Dim req As String = "select iduser_PK from user where motdepasse ='" & mot & "' and compte ='" & pseu & "'"
            Dim Cmd As MySqlCommand = New MySqlCommand(req, Cnn)
            Dim Adap As New MySqlDataAdapter
            Adap.SelectCommand = Cmd
            Dim tblCla As New DataTable
            Adap.Fill(tblCla)
            grille_id.DataSource = tblCla
            idd = grille_id.Rows(0).Cells(0).Value
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return idd

    End Function
    Function envoie_nbcrak() As Integer
        Cnn = New MySqlConnection(DATAMANAGER.IDSERVEURS)
        Cnn.Open()
        Try
            Dim dr As MySql.Data.MySqlClient.MySqlDataReader
            Dim cmd1 As MySqlClient.MySqlCommand = New MySqlCommand("select definitive_crak from crack_application", Cnn)
            dr = cmd1.ExecuteReader
            If dr.Read Then
                envoie_nbcrak = dr.GetValue(0)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return envoie_nbcrak
    End Function
    Function envoie_date() As Date
        Cnn = New MySqlConnection(DATAMANAGER.IDSERVEURS)
        Cnn.Open()
        Try
            Dim dr As MySql.Data.MySqlClient.MySqlDataReader
            Dim cmd1 As MySqlClient.MySqlCommand = New MySqlCommand("select date_activation from crack_application", Cnn)
            dr = cmd1.ExecuteReader
            If dr.Read Then
                envoie_date = dr.GetValue(0)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return envoie_date
    End Function

    Private Sub txt_motpass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_motpass.TextChanged

    End Sub
End Class
