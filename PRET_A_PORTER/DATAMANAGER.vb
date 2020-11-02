Imports System.Data.OleDb
Imports System.Reflection
Imports System.IO
Imports System.Guid
Public Class DATAMANAGER
    Public Shared Function IDSERVEURS() As String
        FileOpen(1, My.Application.Info.DirectoryPath & "\text_serveur.txt", OpenMode.Input)
        Module1.vNomServeur = LineInput(1)
        FileClose()

        IDSERVEURS = Module1.vNomServeur

    End Function

End Class
