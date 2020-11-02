Imports System.Data.OleDb
Imports Microsoft.VisualBasic
Imports System.Guid
Imports Microsoft.Win32
Imports System.Data
Imports MySql.Data.MySqlClient
Module Module1
    Public Num, Cpt As Integer
    Public vNom, vPrenom, vProfil, vMotpasse, NumA As String
    Public ConnectionString, vNomServeur, Motcherche, Motextrait As String
    Public Cnn As MySqlConnection

    Public myreader As OleDbDataReader
    Dim compteur As Integer

    Public strConn As String
    Public CptLigne As Integer 'Permet de faire next number sur la  GRILLE
    'Dim connStr As String = "SERVER= localhost; UID=root; DATABASE=bon_secours; password=houeto"
    'Dim cnn As New MySqlConnection(connStr)
    'Dim Num As Integer
End Module
