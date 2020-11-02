Public Class functionClasse
    Public Shared NbreLignes, NbreColones As Integer

    Public Shared Tableaus(NbreLignes, NbreColones) As Array

    'Pour proposer une assistante d'aide de saisie à l'utilisateur
    'Ce code s'xeute chaque fois que l'utilisateur saisie un text 
    Public Shared Sub AutoCompleteTextBox(ByVal NamBox As TextBox)
        Try

            NamBox.AutoCompleteCustomSource.Add(NamBox.Text).ToString()
            NamBox.AutoCompleteCustomSource = NamBox.AutoCompleteCustomSource
            NamBox.AutoCompleteMode = AutoCompleteMode.Suggest
            NamBox.AutoCompleteSource = AutoCompleteSource.CustomSource
        Catch ex As Exception

        End Try
    End Sub
    'Pour proposer une assistante d'aide de saisie à l'utilisateur 
    'Ce code charge les données dans l'autocompletecustomesource du contrôle 
    Public Shared Sub LoardAutoCompletesource(ByVal DtbTable As DataTable, ByVal NameBox As TextBox, ByVal NomColonne As String)
        Try
            For i As Integer = 0 To DtbTable.Rows.Count - 1
                NameBox.AutoCompleteCustomSource.Add(DtbTable.Rows(i).Item(NomColonne).ToString)

            Next
        Catch ex As Exception

        End Try
    End Sub

    ''' <summary>
    ''' retrouve le code de la valeur sélectionnée dans le combo
    ''' </summary>
    ''' <param name="ctrl">Contrôle combobox</param>
    ''' <param name="ColonneCode">nom de la colonne comportant le code, dans la source de données du combo</param>

    Public Shared Function RecupCodeCombo(ByVal ctrl As ComboBox, Optional ByVal ColonneCode As String = "") As String
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
    
End Class
