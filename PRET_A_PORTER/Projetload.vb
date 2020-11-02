Imports System.Windows.Forms

Imports System.Data
Imports System.Windows
Imports System.Drawing.Color
Imports MySql.Data.MySqlClient
Module Projetload
    Dim l, b, indexgrid As Integer
    Public Sub SaisirChiffre(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case e.KeyChar
            Case Is = "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", Microsoft.VisualBasic.vbBack

            Case Else
                e.Handled = True
        End Select
    End Sub
    Public Sub SaisirLetreMiniscule(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case e.KeyChar
            Case Is = "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", " ", Microsoft.VisualBasic.vbBack
            Case Else
                e.Handled = True
        End Select
    End Sub
    Public Sub SaisirLetreMajuscule(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case e.KeyChar
            Case Is = "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", " ", Microsoft.VisualBasic.vbBack
            Case Else
                e.Handled = True
        End Select
    End Sub
    Public Sub SaisirLetre(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.KeyChar = UCase(e.KeyChar)
        If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            Beep()
        End If
    End Sub
    Public Sub SaisirLetre2(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'a revoir
        e.KeyChar = UCase(e.KeyChar)
        If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And Asc(e.KeyChar) <> 45 And Asc(e.KeyChar) <> 95 _
            And Asc(e.KeyChar) <> 8 And Not IsNumeric(e.KeyChar) Then
            e.Handled = True
            Beep()
        End If
    End Sub
    Public Sub SaisirLetreTouteForme(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 And Asc(e.KeyChar) <> 45 And Asc(e.KeyChar) <> 232 And Asc(e.KeyChar) <> 233 Then
            e.Handled = True
            Beep()
        End If
    End Sub
    Public Sub remplir_Grill_table(ByVal Nomform As String, ByVal NomGridView As DataGridView)

        Dim tables As New DataTable
        Dim SQL As String
        SQL = "SELECT  *  FROM " & Nomform
        Dim command As New MySqlCommand(SQL, Cnn)
        Dim Adapter As New MySqlDataAdapter(command)
        tables.Clear()
        Adapter.Fill(tables)
        NomGridView.DataSource = tables
        NomGridView.Refresh()
    End Sub
    Public Function COUNT_PARAMETERS(ByVal Formulaire As Form) As Integer
        COUNT_PARAMETERS = 0
        For Each Ctrl In Formulaire.Controls
            If Ctrl.Tag <> "" Then

                COUNT_PARAMETERS = COUNT_PARAMETERS + 1
            End If
        Next
    End Function

    Public Function IDTABLE(ByVal NomTable As String) As Integer
        Dim command As New MySqlCommand("SELECT_IDTABLE", Cnn)
        command.CommandType = CommandType.StoredProcedure
        Dim paramètre As MySqlParameter
        paramètre = command.Parameters.Add("TableParam", MySqlDbType.String, 100)
        paramètre.Value = NomTable
        IDTABLE = command.ExecuteScalar
        Return IDTABLE
    End Function


    Public Function NESTCLEF(ByVal NomTable As String) As Integer
        Dim command As New MySqlCommand("PS_NESTCLEF", Cnn)
        command.CommandType = CommandType.StoredProcedure
        Dim paramètre As MySqlParameter
        paramètre = command.Parameters.Add("IdTable", MySqlDbType.Int32)
        paramètre.Value = IDTABLE(NomTable)
        NESTCLEF = command.ExecuteScalar
        NESTCLEF = NESTCLEF + 1
        UPDATENESTCLEF(NESTCLEF, NomTable)
        Return NESTCLEF
    End Function
    Public Sub UPDATENESTCLEF(ByVal NextClef As Integer, ByVal NomTable As String)
        Dim command As New MySqlCommand("PS_UPDATE_NESTCLEF", Cnn)
        command.CommandType = CommandType.StoredProcedure
        Dim paramètre As MySqlParameter
        paramètre = command.Parameters.Add("NESTCLEF", MySqlDbType.Int32)
        paramètre.Value = NextClef
        paramètre = command.Parameters.Add("IdTable", MySqlDbType.Int32)
        paramètre.Value = IDTABLE(NomTable)
        command.ExecuteNonQuery()

    End Sub
 
    Public Sub couleurList(ByVal Nomlist As ListView)
        If Nomlist.Items.Count <> 0 Then
            Nomlist.Items.Item(indexgrid).SubItems.Item(0).BackColor = CadetBlue
            Nomlist.Items.Item(indexgrid).SubItems.Item(0).ForeColor = Coral
            'Nomlist.Items.Item(indexgrid).SubItems.Item(0).ForeColor = Color.White
        End If
    End Sub
    Public Sub remplir_un_Combo(ByVal NomPs As String, ByVal NomCombo As ComboBox, ByVal NomColonne As String, ByVal ParamArray TableauParam() As String)
        'Dim tables As New DataTable
        'tables = EXEC_PSAdapter_SANS_CTR(NomPs, TableauParam)
        'NomCombo.DisplayMember = NomColonne
        'NomCombo.ValueMember = NomColonne
        'NomCombo.DataSource = tables
    End Sub

    Public Sub remplir_un_Combo(ByVal NomPs As String, ByVal NomCombo As ComboBox, ByVal NomColonne As String)
        Dim command As New MySqlCommand(NomPs, Cnn)

        Dim Adapter As New MySqlDataAdapter(command)
        Dim Databaseset As New DataSet
        Databaseset.Clear()
        Adapter.Fill(Databaseset, "tableau")
        NomCombo.DisplayMember = NomColonne
        NomCombo.ValueMember = NomColonne
        NomCombo.DataSource = Databaseset.Tables("tableau")
    End Sub
    Public Sub remplir_un_ListBox(ByVal NomPs As String, ByVal NomListBox As ListBox, ByVal NomColonne As String, ByVal ParamArray TableauParam() As String)
        'Dim Datatablelist As New DataTable
        'Datatablelist = EXEC_PSAdapter_SANS_CTR(NomPs, TableauParam)
        'NomListBox.DisplayMember = NomColonne
        'NomListBox.ValueMember = NomColonne
        'NomListBox.DataSource = Datatablelist
    End Sub
    Public Sub remplir_un_ListBox(ByVal NomPs As String, ByVal NomListBox As ListBox, ByVal NomColonne As String)
        Dim command As New MySqlCommand(NomPs, Cnn)

        Dim Adapter As New MySqlDataAdapter(command)
        Dim Datatablelist As New DataTable
        Datatablelist.Clear()
        Adapter.Fill(Datatablelist)
        NomListBox.DisplayMember = NomColonne
        NomListBox.ValueMember = NomColonne
        NomListBox.DataSource = Datatablelist
    End Sub
    Public Sub remplir_Textbox(ByVal NomPs As String, ByVal NomCombo As ComboBox, ByVal NomColonne As String, ByVal NomClé As TextBox, ByVal valeurNom As String)
        On Error Resume Next
        Dim command As New MySqlCommand(NomPs, Cnn)
        Dim Adapter As New MySqlDataAdapter(command)
        Dim famset As New DataSet
        famset.Clear()
        Adapter.Fill(famset, "tableau")
        Dim bind As New BindingSource
        bind.DataSource = famset.Tables("tableau")
        Dim itemfind As String
        itemfind = bind.Find(NomColonne, NomCombo.Text)
        NomClé.Text = famset.Tables("tableau").Rows.Item(itemfind).Item(valeurNom).ToString
    End Sub
    Function Verification_CtrlText(ByVal Formul As GroupBox) As Boolean
        Dim reponse As Boolean = True
        For Each fenetre As Control In Formul.Controls()
            If fenetre.Tag <> String.Empty Then
                If fenetre.GetType.Equals((New TextBox).GetType) Or fenetre.GetType.Equals((New ComboBox).GetType) Then
                    If fenetre.Text = String.Empty Then
                        MsgBox("Une zone de saisie est restée vide !" & Chr(10) & "Veuillez la remplir", MsgBoxStyle.Information, "Attention")
                        fenetre.BackColor = DarkBlue
                        fenetre.Focus()
                        reponse = False
                        Exit For
                    End If
                End If

            End If
        Next
        Return reponse
    End Function
    Public Sub FormatMontant(ByRef LeControl As Control)
        LeControl.Text = Microsoft.VisualBasic.FormatNumber((Microsoft.VisualBasic.Format(LeControl.Text, "Standard")), 0) ' "Standard")  Currency   
    End Sub
    Public Sub FormatMontantGeneral(ByRef LeControl As Control)
        LeControl.Text = Microsoft.VisualBasic.FormatNumber((Microsoft.VisualBasic.Format(LeControl.Text, "Standard")), 0) ' "Standard")  Currency   
    End Sub
End Module
