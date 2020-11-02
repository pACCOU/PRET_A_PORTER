Imports MySql.Data.MySqlClient
Public Class f_modifier_mot_de_passe
    Private Sub btn_enregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_enregistrer.Click
        If (Me.txt_compte.Text = "") Then
            MsgBox("ENTRER  OBLIGATOIREMENT VOTRE COMPTE ! ", MsgBoxStyle.Critical, "ERREUR")
            Me.txt_compte.Focus()
        Else
            If (Me.ancien.Text = "") Then
                MsgBox("ENTRER  OBLIGATOIREMENT L'ANCIEN MOT DE PASSE ! ", MsgBoxStyle.Critical, "ERREUR")
                Me.ancien.Focus()
            Else
                If (Me.nouvo.Text = "" Or Me.configur.Text = "") Then
                    MsgBox("ENTRER  LE NOUVEAU MOT DE PASSE  ET CONFIRMEZ - LE ! ", MsgBoxStyle.Critical, "ERREUR")
                Else
                    If (verifi_compte(Me.txt_compte.Text) = False) Then
                        MsgBox("CE COMPTE N'EXISTE PAS ! ", MsgBoxStyle.Critical, "ERREUR")
                        Me.txt_compte.Focus()
                    Else
                        If (verifi_motpass(Me.ancien.Text) = False) Then
                            MsgBox("VOTRE ANCIEN MOT DE PASSE N'EXISTE ! ", MsgBoxStyle.Critical, "ERREUR")
                            Me.ancien.Focus()
                        Else
                            If (Me.nouvo.Text = Me.configur.Text) Then
                                Try
                                    Dim requete As String = "UPDATE user SET motdepasse ='" & Me.nouvo.Text & "' WHERE compte ='" & Me.txt_compte.Text & "' and motdepasse ='" & Me.ancien.Text & "'"
                                    Dim command As MySqlCommand = New MySqlCommand(requete, Cnn)
                                    command.ExecuteNonQuery()
                                    MsgBox("MODIFICATION  DE L'ANCIEN MOT DE PASSE EFFECTUEE AVEC  SUCCES !", MsgBoxStyle.Information, "INFORMATION")
                                    Me.nouvo.Text = ""
                                    Me.ancien.Text = ""
                                    Me.configur.Text = ""
                                    Me.txt_compte.Text = ""
                                    Me.txt_compte.Focus()

                                Catch ex As Exception
                                    MessageBox.Show(ex.Message)
                                End Try
                            Else
                                MsgBox("LA CONFIRMATION DE VOTRE NOUVEAU MOT DE PASSE EST ERONEE ", MsgBoxStyle.Critical, "ERREUR")
                                Me.configur.Focus()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Function verifi_motpass(ByVal i As String) As Boolean
        Dim an As Boolean
        an = False
        Dim command As MySqlCommand = New MySqlCommand("SELECT * FROM user", Cnn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim mondataset As New DataSet
        Try
            adapter.Fill(mondataset, "user")
            Dim ligne As DataRow
            For Each ligne In mondataset.Tables("user").Rows()
                If ((ligne("motdepasse") = i)) Then
                    an = True
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return an
    End Function
    Function verifi_compte(ByVal i As String) As Boolean
        Dim an As Boolean
        an = False
        Dim command As MySqlCommand = New MySqlCommand("SELECT * FROM user", Cnn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim mondataset As New DataSet
        Try
            adapter.Fill(mondataset, "user")
            Dim ligne As DataRow
            For Each ligne In mondataset.Tables("user").Rows()
                If ((ligne("compte") = i)) Then
                    an = True
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return an
    End Function

    Private Sub configu_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If cnn IsNot Nothing Then cnn.Close()
    End Sub

    Private Sub configu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn = New MySqlConnection(DATAMANAGER.IDSERVEURS)
        Cnn.Open()
        txt_compte.Focus
    End Sub

End Class