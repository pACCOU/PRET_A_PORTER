Imports System
Imports System.Data
Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic
Module Modincrementer
    Dim connStr As String = "SERVER= localhost; UID=root; DATABASE=preta_porte; password=houeto"
    Dim cnn As New MySqlConnection(connStr)
    ' Déclaration Objet Connexion
    Public ObjetConnection As MySqlConnection
    ' Déclaration Objet Commande
    Public ObjetCommand As MySqlCommand
    ' Déclaration Objet DataAdapter
    Public vDataAdapter As MySqlDataAdapter
    ' Déclaration Objet DataSet
    Public vDataSet As New DataSet() 'Attention au New
    Public vdataset2 As New DataSet()
    Public vdataset3 As New DataSet()
    Public vdataset4 As New DataSet()
    Public vdataset5 As New DataSet()

    'String contenant la 'Requête SQL'
    Public strSql, srtsql1, strsql2, strsql3, strsql4 As String
    ' Déclaration Objet DataTable
    Public ObjetDataTable As DataTable
    ' Déclaration Objet DataRow (ligne)
    Public ObjetDataRow As DataRow
    Public myreader As MySqlDataReader
    'Numéro de la ligne en cours
    Public RowNumber As Integer 'Numéro de l'enregistrement courant
    'Paramêtres de connexion à la DB
    'Public strConn As String = " SERVER=localhost; USERID=root; PASSWORD=houeto; DATABASE=bon_secours;"
    '|DataDirectory|
    'Pour recompiler les données modifiées avant de les remettre dans le
    '"DataAdapter"
    Public ObjetCommandBuilder As MySqlCommandBuilder

    Public Sub incrementer(ByVal text1 As TextBox, ByVal req As String, ByVal premier_lettre As String, ByVal nombre_zero As Integer)
        ObjetConnection = New MySqlConnection(connStr)
        ObjetConnection.Open()
        'cnn = New MySqlConnection(DATAMANAGER.IDSERVEURS)
        'Cnn.Open()
        ObjetCommand = New MySqlCommand(req)
        ObjetCommand.Connection = ObjetConnection
        myreader = ObjetCommand.ExecuteReader
        myreader.Read()
        Dim a As Integer = (Mid(myreader(0).ToString, 2) + 1)
        Select Case nombre_zero
            Case 0
                text1.Text = premier_lettre & a
            Case 1
                If a < 10 Then
                    text1.Text = premier_lettre & "0" & a
                Else
                    text1.Text = premier_lettre & a
                End If

            Case 2
                If a < 10 Then
                    text1.Text = premier_lettre & "00" & a
                ElseIf a < 100 Then
                    text1.Text = premier_lettre & "0" & a
                Else
                    text1.Text = premier_lettre & a
                End If

            Case 3
                If a < 10 Then
                    text1.Text = premier_lettre & "000" & a
                ElseIf a < 100 Then
                    text1.Text = premier_lettre & "00" & a
                ElseIf a < 1000 Then
                    text1.Text = premier_lettre & "0" & a
                Else
                    text1.Text = premier_lettre & a
                End If

            Case 4
                If a < 10 Then
                    text1.Text = premier_lettre & "0000" & a
                ElseIf a < 100 Then
                    text1.Text = premier_lettre & "000" & a
                ElseIf a < 1000 Then
                    text1.Text = premier_lettre & "00" & a
                ElseIf a < 10000 Then
                    text1.Text = premier_lettre & "0" & a
                Else
                    text1.Text = premier_lettre & a
                End If
            Case 5
                If a < 10 Then
                    text1.Text = premier_lettre & "00000" & a
                ElseIf a < 100 Then
                    text1.Text = premier_lettre & "0000" & a
                ElseIf a < 1000 Then
                    text1.Text = premier_lettre & "000" & a
                ElseIf a < 10000 Then
                    text1.Text = premier_lettre & "00" & a
                ElseIf a < 100000 Then
                    text1.Text = premier_lettre & "0" & a
                Else
                    text1.Text = premier_lettre & a
                End If

            Case 6
                If a < 10 Then
                    text1.Text = premier_lettre & "000000" & a
                ElseIf a < 100 Then
                    text1.Text = premier_lettre & "00000" & a
                ElseIf a < 1000 Then
                    text1.Text = premier_lettre & "0000" & a
                ElseIf a < 10000 Then
                    text1.Text = premier_lettre & "000" & a
                ElseIf a < 100000 Then
                    text1.Text = premier_lettre & "00" & a
                ElseIf a < 1000000 Then
                    text1.Text = premier_lettre & "0" & a
                Else
                    text1.Text = premier_lettre & a
                End If

            Case Else
                MsgBox("Cette opération n'est pris en compte par cette procédure")

        End Select
        ObjetConnection.Close()


    End Sub
    'Public Sub incrementer2(ByVal text1 As TextBox, ByVal req As String)
    '    ObjetConnection = New MySqlConnection(connStr)
    '    ObjetConnection.Open()
    '    'cnn = New MySqlConnection(DATAMANAGER.IDSERVEURS)
    '    'Cnn.Open()
    '    ObjetCommand = New MySqlCommand(req)
    '    ObjetCommand.Connection = ObjetConnection
    '    myreader = ObjetCommand.ExecuteReader
    '    myreader.Read()
    '    Dim a As Integer = (Mid(myreader(0).ToString, 2) + 1)
    '    Select Case nombre_zero
    '        Case 0
    '            text1.Text = premier_lettre & a
    '        Case 1
    '            If a < 10 Then
    '                text1.Text = premier_lettre & "0" & a
    '            Else
    '                text1.Text = premier_lettre & a
    '            End If

    '        Case 2
    '            If a < 10 Then
    '                text1.Text = premier_lettre & "00" & a
    '            ElseIf a < 100 Then
    '                text1.Text = premier_lettre & "0" & a
    '            Else
    '                text1.Text = premier_lettre & a
    '            End If

    '        Case 3
    '            If a < 10 Then
    '                text1.Text = premier_lettre & "000" & a
    '            ElseIf a < 100 Then
    '                text1.Text = premier_lettre & "00" & a
    '            ElseIf a < 1000 Then
    '                text1.Text = premier_lettre & "0" & a
    '            Else
    '                text1.Text = premier_lettre & a
    '            End If

    '        Case 4
    '            If a < 10 Then
    '                text1.Text = premier_lettre & "0000" & a
    '            ElseIf a < 100 Then
    '                text1.Text = premier_lettre & "000" & a
    '            ElseIf a < 1000 Then
    '                text1.Text = premier_lettre & "00" & a
    '            ElseIf a < 10000 Then
    '                text1.Text = premier_lettre & "0" & a
    '            Else
    '                text1.Text = premier_lettre & a
    '            End If
    '        Case 5
    '            If a < 10 Then
    '                text1.Text = premier_lettre & "00000" & a
    '            ElseIf a < 100 Then
    '                text1.Text = premier_lettre & "0000" & a
    '            ElseIf a < 1000 Then
    '                text1.Text = premier_lettre & "000" & a
    '            ElseIf a < 10000 Then
    '                text1.Text = premier_lettre & "00" & a
    '            ElseIf a < 100000 Then
    '                text1.Text = premier_lettre & "0" & a
    '            Else
    '                text1.Text = premier_lettre & a
    '            End If

    '        Case 6
    '            If a < 10 Then
    '                text1.Text = premier_lettre & "000000" & a
    '            ElseIf a < 100 Then
    '                text1.Text = premier_lettre & "00000" & a
    '            ElseIf a < 1000 Then
    '                text1.Text = premier_lettre & "0000" & a
    '            ElseIf a < 10000 Then
    '                text1.Text = premier_lettre & "000" & a
    '            ElseIf a < 100000 Then
    '                text1.Text = premier_lettre & "00" & a
    '            ElseIf a < 1000000 Then
    '                text1.Text = premier_lettre & "0" & a
    '            Else
    '                text1.Text = premier_lettre & a
    '            End If

    '        Case Else
    '            MsgBox("Cette opération n'est pris en compte par cette procédure")

    '    End Select
    '    ObjetConnection.Close()


    'End Sub
End Module
