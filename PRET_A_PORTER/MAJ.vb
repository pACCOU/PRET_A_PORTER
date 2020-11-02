Imports System.IO
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient


Module MAJ
    Public ob As Control
    Public Nom_column As String = ""
    Public Nom_table As String = ""
    Public Sql As String = ""
    Public valeur_column As Object = ""
    Public virg As Char = ","
    Public column As String = ""
    Public valeur_rel As String = ""
    Public nom_clé As String = ""
    Public valeur_clé As String = ""
    Public Sub pro_enregistrer(ByVal NomForm As Form)
        Nom_table = NomForm.Tag
        For Each Ctrl In NomForm.Controls
            If Ctrl.Tag <> "" Then
                Nom_column = Nom_column & Ctrl.Tag & ","
                If IsNumeric(Ctrl.Text) = True Then
                    valeur_column = valeur_column & Replace(Ctrl.Text, ",", ".") & ","

                ElseIf Ctrl.GetType.Equals((New TextBox).GetType) Then
                    valeur_column = valeur_column & "'" & Replace(Replace(Ctrl.Text, "'", " '' "), ",", ".") & "'" & ","

                End If
                If Ctrl.GetType.Equals((New DateTimePicker).GetType) Then
                    Dim Datepick As DateTimePicker
                    Datepick = Ctrl
                    Datepick.Tag = Ctrl.Tag
                    valeur_column = valeur_column & " " & "#" & Datepick.Value.Date & "#" & " " & ","

                End If
                If Ctrl.GetType.Equals((New CheckBox).GetType) Then
                    Dim chec As New CheckBox
                    chec = Ctrl
                    chec.Tag = Ctrl.Tag
                    valeur_column = valeur_column & " " & "'" & chec.Checked & "'" & " " & ","

                End If
                If Ctrl.GetType.Equals((New RadioButton).GetType) Then
                    Dim radio As New RadioButton
                    radio = Ctrl
                    radio.Tag = Ctrl.Tag
                    valeur_column = valeur_column & " " & "'" & radio.Checked & "'" & " " & ","

                End If
                If Ctrl.GetType.Equals((New ListBox).GetType) Then
                    Dim LIST As New ListBox
                    LIST = Ctrl
                    LIST.Tag = Ctrl.Tag
                    valeur_column = valeur_column & " " & "'" & LIST.Text & "'" & " " & ","

                    Exit For
                End If

                If Ctrl.GetType.Equals((New Label).GetType) Then
                    Dim Lab As New Label
                    Lab = Ctrl
                    Lab.Tag = Ctrl.Tag
                    valeur_column = valeur_column & " " & "'" & Lab.Text & "'" & " " & ","

                    Exit For
                End If

                If Ctrl.GetType.Equals((New RichTextBox).GetType) Then
                    Dim RitchText As New RichTextBox
                    RitchText = Ctrl
                    RitchText.Tag = Ctrl.Tag
                    valeur_column = valeur_column & " " & "'" & RitchText.Text & "'" & " " & ","

                    Exit For
                End If

                If Ctrl.GetType.Equals((New PictureBox).GetType) Then
                    Dim Pictures As New PictureBox
                    Pictures = Ctrl
                    Pictures.Tag = Ctrl.Tag
                    valeur_column = MAJ.ImageToByteArray(Pictures.Image)
                    Exit For
                End If



            End If
        Next
        Nom_column = Nom_column.TrimEnd(virg)
        valeur_column = valeur_column.TrimEnd(virg)

        Sql = "INSERT INTO " & Nom_table & " " & "(" & " " & Nom_column & " " & ")" & " " & "VALUES" & " " & "(" & valeur_column & ")"
        Dim command As New MySqlCommand(Sql, Cnn)
        command.ExecuteNonQuery()

        MessageBox.Show("enregistrement effectuer avec succès ")



    End Sub
    Public Sub EnregistrerGroupBox(ByVal NomForm As GroupBox)
        Nom_column = ""
        valeur_column = ""
        Nom_table = NomForm.Tag
        For Each Ctrl In NomForm.Controls
            If Ctrl.Tag <> "" Then
                Nom_column = Nom_column & Ctrl.Tag & ","
                If IsNumeric(Ctrl.Text) = True Then
                    valeur_column = valeur_column & Replace(Ctrl.Text, ",", ".") & ","

                ElseIf Ctrl.GetType.Equals((New TextBox).GetType) Then
                    valeur_column = valeur_column & "'" & Replace(Replace(Ctrl.Text, "'", " '' "), ",", ".") & "'" & ","

                End If
                If Ctrl.GetType.Equals((New DateTimePicker).GetType) Then
                    Dim Datepick As DateTimePicker
                    Datepick = Ctrl
                    Datepick.Tag = Ctrl.Tag
                    valeur_column = valeur_column & " " & "'" & Ctrl.Text & "'" & " " & ","

                End If
                If Ctrl.GetType.Equals((New CheckBox).GetType) Then
                    Dim chec As New CheckBox
                    chec = Ctrl
                    chec.Tag = Ctrl.Tag
                    valeur_column = valeur_column & " " & "'" & chec.Checked & "'" & " " & ","

                End If
                If Ctrl.GetType.Equals((New RadioButton).GetType) Then
                    Dim radio As New RadioButton
                    radio = Ctrl
                    radio.Tag = Ctrl.Tag
                    valeur_column = valeur_column & " " & "'" & radio.Checked & "'" & " " & ","

                End If
                If Ctrl.GetType.Equals((New ListBox).GetType) Then
                    Dim LIST As New ListBox
                    LIST = Ctrl
                    LIST.Tag = Ctrl.Tag
                    valeur_column = valeur_column & " " & "'" & LIST.Text & "'" & " " & ","

                    Exit For
                End If

                If Ctrl.GetType.Equals((New Label).GetType) Then
                    Dim Lab As New Label
                    Lab = Ctrl
                    Lab.Tag = Ctrl.Tag
                    valeur_column = valeur_column & " " & "'" & Lab.Text & "'" & " " & ","

                    Exit For
                End If

                If Ctrl.GetType.Equals((New RichTextBox).GetType) Then
                    Dim RitchText As New RichTextBox
                    RitchText = Ctrl
                    RitchText.Tag = Ctrl.Tag
                    valeur_column = valeur_column & " " & "'" & RitchText.Text & "'" & " " & ","

                    Exit For
                End If

                If Ctrl.GetType.Equals((New PictureBox).GetType) Then
                    Dim Pictures As New PictureBox
                    Pictures = Ctrl
                    Pictures.Tag = Ctrl.Tag
                    valeur_column = MAJ.ImageToByteArray(Pictures.Image)
                    Exit For
                End If



            End If
        Next
        Nom_column = Nom_column.TrimEnd(virg)
        valeur_column = valeur_column.TrimEnd(virg)

        Sql = "INSERT INTO " & Nom_table & " " & "(" & " " & Nom_column & " " & ")" & " " & "VALUES" & " " & "(" & valeur_column & ")"

        Dim command As New MySqlCommand(Sql, Cnn)
        command.ExecuteNonQuery()
        Nom_column = ""
        valeur_column = ""


        MessageBox.Show("enregistrement effectuer avec succès ")

    End Sub
    Public Sub ModifierGroupBox(ByVal NomForm As GroupBox)
        Nom_table = NomForm.Tag
        For Each Ctrl In NomForm.Controls
            Nom_column = ""
            valeur_column = ""

            If Ctrl.Name <> String.Empty Then
                '''''recupere le pk dans le name'((''''''''''''
                'If Left(Ctrl.tag, 3) = Left(Nom_table, 3) Or Right(Ctrl.Tag, 2) = "PK" Then
                '    nom_clé = nom_clé & Ctrl.Tag
                If Left(Ctrl.Name, 3) = Left(Nom_table, 3) Or Right(Ctrl.Name, 2) = "PK" Then
                    nom_clé = nom_clé & Ctrl.Name
                    valeur_clé = valeur_clé & Ctrl.Text
                    column = column & " " & nom_clé & " " & "=" & " " & valeur_clé
                    nom_clé = ""
                    valeur_clé = ""
                Else
                    Nom_column = Nom_column & Ctrl.Tag

                    If IsNumeric(Ctrl.Text) = True Then
                        valeur_column = valeur_column & Replace(Ctrl.Text, ",", ".")

                    ElseIf Ctrl.GetType.Equals((New TextBox).GetType) Then
                        valeur_column = valeur_column & "'" & Replace(Replace(Ctrl.Text, "'", " '' "), ",", ".") & "'"

                    End If
                    If Ctrl.GetType.Equals((New DateTimePicker).GetType) Then
                        Dim Datepick As DateTimePicker
                        Datepick = Ctrl
                        Datepick.Tag = Ctrl.Tag
                        valeur_column = valeur_column & " " & "'" & Ctrl.text & "'" & " "

                    End If
                    If Ctrl.GetType.Equals((New CheckBox).GetType) Then
                        Dim chec As New CheckBox
                        chec = Ctrl
                        chec.Tag = Ctrl.Tag
                        valeur_column = valeur_column & " " & "'" & chec.Checked & "'" & " "

                    End If
                    If Ctrl.GetType.Equals((New RadioButton).GetType) Then
                        Dim radio As New RadioButton
                        radio = Ctrl
                        radio.Tag = Ctrl.Tag
                        valeur_column = valeur_column & " " & "'" & radio.Checked & "'" & " "

                    End If
                    If Ctrl.GetType.Equals((New ListBox).GetType) Then
                        Dim LIST As New ListBox
                        LIST = Ctrl
                        LIST.Tag = Ctrl.Tag
                        valeur_column = valeur_column & " " & "'" & LIST.Text & "'" & " " & ","

                        Exit For
                    End If

                    'If Ctrl.GetType.Equals((New Label).GetType) Then
                    '    Dim Lab As New Label
                    '    Lab = Ctrl
                    '    Lab.Tag = Ctrl.Tag
                    '    valeur_column = valeur_column & " " & "'" & Lab.Text & "'" & " " & ","

                    '    Exit For
                    'End If

                    If Ctrl.GetType.Equals((New RichTextBox).GetType) Then
                        Dim RitchText As New RichTextBox
                        RitchText = Ctrl
                        RitchText.Tag = Ctrl.Tag
                        valeur_column = valeur_column & " " & "'" & RitchText.Text & "'" & " " & ","

                        Exit For
                    End If



                    If Ctrl.GetType.Equals((New PictureBox).GetType) Then
                        Dim Pictures As New PictureBox
                        Pictures = Ctrl
                        Pictures.Tag = Ctrl.Tag
                        valeur_column = MAJ.ImageToByteArray(Pictures.Image)
                        Exit For
                    End If



                    valeur_rel = valeur_rel & " " & Nom_column & " " & "=" & " " & valeur_column & ","
                    Nom_column = ""
                    valeur_column = ""
                End If

            End If
        Next Ctrl

        valeur_rel = valeur_rel.TrimEnd(virg)

        Sql = "UPDATE " & " " & Nom_table & " " & "SET" & " " & valeur_rel & " " & "where" & " " & column
        Dim command As New MySqlCommand(Sql, Cnn)
        command.ExecuteNonQuery()
        Nom_column = ""
        valeur_column = ""



        MessageBox.Show("Modification effectuée avec succès ")


    End Sub
    Public Sub pro_supprimer(ByVal NomForm As Form)
        Nom_table = NomForm.Tag
        For Each Conteneur In NomForm.Controls
            If Conteneur.GetType.Equals((New Panel).GetType) Then
                Dim PanelCtrl As New Panel
                PanelCtrl = Conteneur
                For Each objet In PanelCtrl.Controls
                    If objet.tag <> String.Empty Then
                        If Right(objet.Name, 2) = "PK" Then
                            nom_clé = nom_clé & objet.tag
                            valeur_clé = valeur_clé & objet.Text
                            column = column & " " & nom_clé & " " & "=" & " " & valeur_clé
                            nom_clé = ""
                            valeur_clé = ""

                        End If
                    End If
                Next
            End If
            If Conteneur.GetType.Equals((New GroupBox).GetType) Then
                Dim PanelCtrl As New GroupBox
                PanelCtrl = Conteneur
                For Each objet In PanelCtrl.Controls
                    If objet.tag <> String.Empty Then
                        If Right(objet.Name, 2) = "PK" Then
                            nom_clé = nom_clé & objet.tag
                            valeur_clé = valeur_clé & objet.Text
                            column = column & " " & nom_clé & " " & "=" & " " & valeur_clé
                            nom_clé = ""
                            valeur_clé = ""
                            Exit For
                        End If
                    End If
                Next
            End If


            If Conteneur.tag <> String.Empty Then
                If Right(Conteneur.Name, 2) = "PK" Then
                    nom_clé = nom_clé & Conteneur.tag
                    valeur_clé = valeur_clé & Conteneur.Text
                    column = column & " " & nom_clé & " " & "=" & " " & valeur_clé
                    nom_clé = ""
                    valeur_clé = ""
                End If
            End If

        Next Conteneur
        Sql = "DELETE " & " " & "FROM " & Nom_table & " " & "where" & " " & column

        Dim command As New MySqlCommand(Sql, Cnn)
        command.ExecuteNonQuery()

        MessageBox.Show("Suppression effectuée avec succès ")


    End Sub
    Function Initialisation_CtrlText_groupBox(ByVal Formul As GroupBox) As Boolean
        Dim reponse As Boolean = True
        For Each fenetre As Control In Formul.Controls()
            If fenetre.GetType.Equals((New TextBox).GetType) Or fenetre.GetType.Equals((New ComboBox).GetType) Then
                fenetre.Text = String.Empty
            End If
            If fenetre.GetType.Equals((New DateTimePicker).GetType) Then
                fenetre.Text = Now.Date
            End If
            If fenetre.GetType.Equals((New CheckBox).GetType) Then
                Dim chec As New CheckBox
                chec = fenetre
                chec.Tag = fenetre.Tag
                chec.Checked = False
            End If
            If fenetre.GetType.Equals((New RadioButton).GetType) Then
                Dim radio As New RadioButton
                radio = fenetre
                radio.Tag = fenetre.Tag
                radio.Checked = False
            End If
            If fenetre.GetType.Equals((New PictureBox).GetType) Then
                Dim Pictures As New PictureBox
                Pictures = fenetre
                Pictures.Tag = fenetre.Tag
                Pictures.Image = Nothing
            End If
        Next
        Return reponse
    End Function
    Public Sub CacheColonnes(ByRef laGrille As DataGridView, ByVal isListIndices As Boolean, ByVal ParamArray ListIndicesOuNoms() As String)
        Dim i As Integer
        If isListIndices Then
            For i = 0 To ListIndicesOuNoms.Length - 1
                laGrille.Columns(CInt(ListIndicesOuNoms(i))).Visible = False
            Next
        Else
            For i = 0 To ListIndicesOuNoms.Length - 1
                laGrille.Columns(ListIndicesOuNoms(i)).Visible = False
            Next
        End If
    End Sub



    Public Function ImageToByteArray(ByVal img As Image) As Byte()
        Dim stream As New MemoryStream
        img.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Return stream.ToArray
    End Function
    Public Function ByteArrayToImage(ByVal ByteArray As Byte()) As Image
        Dim stream As New MemoryStream(ByteArray, 0, ByteArray.Length)
        Return Image.FromStream(stream, True)
    End Function
    Public Sub insertNewRowIntoGrid(ByRef laGrille As DataGridView, ByVal TabloControls As List(Of Control), Optional ByVal recupcodeCombo As Boolean = False)
        'Dim tabloValeurs(laGrille.Columns.Count) As String, i As Integer

        'For i = 0 To laGrille.Columns.Count - 1
        '    tabloValeurs(i) = ValControle_ByType(GetItemByName(laGrille.Columns(i).Name, TabloControls), recupcodeCombo)
        'Next
        'Dim uneLigne As New DataGridViewRow()
        'uneLigne.CreateCells(laGrille, tabloValeurs)
        'laGrille.Rows.Add(uneLigne)
        ''laGrille.Rows.Add(tabloValeurs)
    End Sub
    Private Function ValControle_ByType(ByVal ctrl As Control, Optional ByVal searchInGrille As Boolean = False) As String
        Dim valeur As String = ""
        If isCombo(ctrl) Then
            If Not searchInGrille Then
                valeur = ctrl.Text
            Else
                valeur = RecupCodeCombo(ctrl)
            End If
        ElseIf isTextBox(ctrl) Then
            valeur = ctrl.Text
        ElseIf isDtPicker(ctrl) Then
            Select Case CType(ctrl, DateTimePicker).Format
                'Uniquement la date
                Case DateTimePickerFormat.Short
                    valeur = CType(ctrl, DateTimePicker).Value.ToShortDateString()
                    'Masqué par Arnauld car l'utilité n'est pas pertinente---------------
                    '    'Uniquement l'heure
                    'Case DateTimePickerFormat.Time
                    '    valeur = CType(ctrl, DateTimePicker).Value.ToLongTimeString()
                    '--------------------------------------------------------------------
                    'Date et heure
                Case Else
                    valeur = CType(ctrl, DateTimePicker).Value.ToShortDateString() & " " & CType(ctrl, DateTimePicker).Value.ToLongTimeString()
            End Select
            'valeur = CType(ctrl, DateTimePicker).Value.ToString()

        ElseIf isCheckBox(ctrl) Then
            valeur = CStr(CInt(CType(ctrl, CheckBox).Checked))
        ElseIf isRadioBtn(ctrl) Then
            valeur = CStr(CInt(CType(ctrl, RadioButton).Checked))
        End If
        Return valeur
    End Function
    ''' <summary>
    ''' retrouve le code de la valeur sélectionnée dans le combo
    ''' </summary>
    ''' <param name="ctrl">Contrôle combobox</param>
    ''' <param name="ColonneCode">nom de la colonne comportant le code, dans la source de données du combo</param>

    Public Function RecupCodeCombo(ByVal ctrl As ComboBox, Optional ByVal ColonneCode As String = "") As String
        Dim code As String = "-1"

        If Not ctrl.SelectedItem Is Nothing Then
            'par defaut on supposera que c'est la première colonne du combo qui contient les codes
            If ColonneCode = "" Then
                code = CType(ctrl.SelectedItem, DataRowView).Item(0).ToString()
            Else
                code = CType(ctrl.SelectedItem, DataRowView).Item(ColonneCode).ToString()
            End If
        End If
        Return code
    End Function
    ''' <summary>
    ''' Retourne dans un contrôle,depuis la base de données, la valeur incrémentée du champ correspondant au contrôle
    ''' </summary>
    ''' <param name="ctrl">Contrôle</param>
    ''' <param name="cnn">Connection active</param>
    ''' <param name="condition">Condition de selection à ajouter à la requête de base</param>
    '''<param name="transactLocale">Est utilisée au cas où l'incrementation se déroulerait dans une transaction</param>


    'Public Shared Sub IncrementChamp(ByRef Ctrl As Control, ByVal condition As String, Optional ByVal transactLocale As DbTransaction = Nothing)
    '    'Dim nomTable As String, nomChamp As String, reqSql As String
    '    'Dim ActiveCommand As DbCommand, ActiveDataTable As DataTable
    '    'Dim valeur As String

    '    'nomTable = RecupValPropriete(Ctrl.Tag, "NomTable", "=", "|")
    '    'nomChamp = RecupValPropriete(Ctrl.Tag, "NomChamp", "=", "|")

    '    ''Constitution de la requête
    '    'reqSql = "SELECT MAX(" & nomChamp & ") FROM " & nomTable
    '    ''Execution de la requete
    '    'If condition <> "" Then reqSql = reqSql & " " & condition


    '    ''initialisation de la transaction de l'objet commande due à celle de l'objet connection passée en parametre
    '    'If Not transactLocale Is Nothing Then
    '    '    DalGate.LoaderDt.ExecuteCommand(transactLocale, reqSql)
    '    'Else
    '    '    DalGate.LoaderDt.ExecuteCommand(reqSql)
    '    'End If

    '    'ActiveDataTable = DalGate.LoaderDt.ResultGeneric

    '    'If ActiveDataTable.Rows.Count > 0 Then

    '    '    If IsDBNull(ActiveDataTable.Rows(0).Item(0)) Then
    '    '        Ctrl.Text = "1"
    '    '    Else
    '    '        If IsNumeric(ActiveDataTable.Rows(0).Item(0)) Then Ctrl.Text = CInt(ActiveDataTable.Rows(0).Item(0)) + 1

    '    '    End If
    '    'Else
    '    '    Ctrl.Text = "1"
    '    'End If
    'End Sub
    Private Function isCombo(ByVal ctrl As Control) As Boolean
        If TypeOf (ctrl) Is ComboBox Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function isDtPicker(ByVal ctrl As Control) As Boolean
        If TypeOf (ctrl) Is DateTimePicker Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function isCheckBox(ByVal ctrl As Control) As Boolean
        If TypeOf (ctrl) Is CheckBox Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function isRadioBtn(ByVal ctrl As Control) As Boolean
        If TypeOf (ctrl) Is RadioButton Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function isTextBox(ByVal ctrl As Control) As Boolean
        If TypeOf (ctrl) Is TextBox Then
            Return True
        Else
            Return False
        End If
    End Function
End Module
